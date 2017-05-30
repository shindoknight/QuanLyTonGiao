using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for ServiceUser
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class ServiceUser : System.Web.Services.WebService
{

    public ServiceUser()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }
    static SqlConnection con = null;
    public static void OpenConnect()
    {
        try
        {
            string strConnect = @"Data Source=.\SQLEXPRESS;Initial Catalog=QUANLYTONGIAO;Integrated Security=True";
            con = new SqlConnection(strConnect);
            con.Open();
        }
        catch
        {

        }
    }
    public static void CloseConnect()
    {
        if (con.State == ConnectionState.Open)
            con.Close();
    }
    [WebMethod]
    public DataTable DangNhap(string username, string password)
    {
        OpenConnect();
        SqlCommand comm = new SqlCommand("select * from tblUser where UserName=N'" + username + "' and PassWord=N'" + password + "' and daxoa=0", con);
        comm.CommandType = CommandType.Text;
        SqlDataAdapter da = new SqlDataAdapter(comm);
        DataTable dtdistrict = new DataTable("tblUser");
        da.Fill(dtdistrict);
        CloseConnect();
        return dtdistrict;
    }
    [WebMethod]
    public DataTable GetInfo(string id)
    {
        OpenConnect();
        SqlCommand comm = new SqlCommand("select * from tblUser where iduser=N'" + id + "' ", con);
        comm.CommandType = CommandType.Text;
        SqlDataAdapter da = new SqlDataAdapter(comm);
        DataTable dtdistrict = new DataTable("tblUser");
        da.Fill(dtdistrict);
        CloseConnect();
        return dtdistrict;
    }
    [WebMethod]
    public DataTable DanhSach()
    {
        OpenConnect();
        SqlCommand comm = new SqlCommand("select * from tblUser where daxoa=0 ", con);
        comm.CommandType = CommandType.Text;
        SqlDataAdapter da = new SqlDataAdapter(comm);
        DataTable dtdistrict = new DataTable("tblUser");
        da.Fill(dtdistrict);
        CloseConnect();
        return dtdistrict;
    }
    [WebMethod]
    public int DoiMatKhau(string mkmoi,string id)
    {
        OpenConnect();
        SqlCommand comm = new SqlCommand("update tblUser set password='"+mkmoi+"' where iduser=N'" + id + "' ", con);
        int n = comm.ExecuteNonQuery();
        CloseConnect();
        return n;
    }
    [WebMethod]
    public int Xoa( string id)
    {
        OpenConnect();
        SqlCommand comm = new SqlCommand("update tblUser set daxoa=1 where iduser=N'" + id + "' ", con);
        int n = comm.ExecuteNonQuery();
        CloseConnect();
        return n;
    }
    [WebMethod]
    public string Sua(string id, string hoten, string Email, string ngaysinh,string hinhanh,byte[] f,string quyen)
    {
        FilesTransfer trans = new FilesTransfer();
        try
        {
            OpenConnect();
            int n = 0;
            if (hinhanh != "")
            {
                string upfile = trans.UploadFile(f, hinhanh, "User");

                if (upfile == "OK")
                {
                    SqlCommand comm = new SqlCommand("update tblUser set Hoten=N'" + hoten + "',email=N'" + Email + "',ngaysinh=N'" + ngaysinh + "',hinhanh=N'" + "/Images/User/" + hinhanh + "',phanquyen="+quyen+" where IDUser='"+id+"'", con);
                    n = comm.ExecuteNonQuery();
                }

                else
                {
                    CloseConnect();
                    return "Lỗi up ảnh: \n" + upfile;
                }
                CloseConnect();
            }
            else
            {
                SqlCommand comm = new SqlCommand("update tblUser set Hoten=N'" + hoten + "',email=N'" + Email + "',ngaysinh=N'" + ngaysinh + "',phanquyen=" + quyen + " where iduser='" + id + "'", con);
                n = comm.ExecuteNonQuery();
                CloseConnect();
            }
            if (n > 0)
            {
                return "Sửa thành công!";
            }
            else return "Sửa không thành công!";
        }
        catch (Exception ex)
        {
            return "Sửa không thành công!\n"+ex.ToString();
        }
    }

    [WebMethod]
    public string ThemUser(string user, string pass,string hoten, string Email, string ngaysinh,string hinhanh, byte[] f ,int phanquyen)
    {
        FilesTransfer trans = new FilesTransfer();
        
         try
        {
            OpenConnect();
            SqlCommand com = new SqlCommand("select * from tblUser where username=N'" + user + "' ", con);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dtdistrict = new DataTable("tblUser");
            da.Fill(dtdistrict);
            if(dtdistrict.Rows.Count>0)
            {
                return "Tên tài khoản " + user + " đã tồn tại.!";
            }
            int n = 0;
            if (hinhanh != "")
            {
                string upfile = trans.UploadFile(f, hinhanh,"User");

                if (upfile == "OK")
                {
                    SqlCommand comm = new SqlCommand("insert into tblUser values (N'" + user + "',N'" + pass + "',N'" + phanquyen.ToString() + "',0,N'" + hoten + "',N'" + ngaysinh + "',N'" + Email + "',N'" + "/Images/User/" + hinhanh + "')", con);
                    n = comm.ExecuteNonQuery();
                }

                else
                {
                    CloseConnect();
                    return "Lỗi up ảnh: \n" + upfile;
                }
                CloseConnect();
            }
            else
            {
                SqlCommand comm = new SqlCommand("insert into tblUser values (N'" + user + "',N'" + pass + "',N'" + phanquyen.ToString() + "',0,N'" + hoten + "',N'" + ngaysinh + "',N'" + Email + "',N'')", con);
                n = comm.ExecuteNonQuery();
                CloseConnect();
            }
            if (n > 0)
            {
                return "Đăng ký thành công!";
            }
            else return "Đăng ký không thành công!";
        }
        catch (Exception ex)
        {
            return "Đăng ký không thành công!";
        }
    }

}
