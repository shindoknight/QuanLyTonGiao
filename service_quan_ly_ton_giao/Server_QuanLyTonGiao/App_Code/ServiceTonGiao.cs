using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for ServiceTonGiao
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class ServiceTonGiao : System.Web.Services.WebService
{

    public ServiceTonGiao()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    static SqlConnection conn = null;
    public static void OpenConnect()
    {
        try
        {
            string strConnect = @"Data Source=.\SQLEXPRESS;Initial Catalog=QUANLYTONGIAO;Integrated Security=True";
            conn = new SqlConnection(strConnect);
            conn.Open();
        }
        catch
        {

        }
    }
    public static void CloseConnect()
    {
        if (conn.State == ConnectionState.Open)
            conn.Close();
    }
    [WebMethod]
    public DataTable LayDanhSach()
    {
        OpenConnect();
        SqlCommand comm = new SqlCommand("select * from tblTonGiao where DaXoa=0", conn);
        SqlDataAdapter da = new SqlDataAdapter(comm);
        DataTable dtdistrict = new DataTable("tblTonGiao");
        da.Fill(dtdistrict);
        CloseConnect();
        return dtdistrict;
    }
    [WebMethod]
    public string ThemTonGiao(string Ten, string gioithieu, string hinhanh, byte[] f)
    {
        FilesTransfer trans = new FilesTransfer();
        try
        {
            OpenConnect();
            int n=0;
            if (hinhanh != "")
            {
                string upfile = trans.UploadFile(f, hinhanh);

                if (upfile == "OK")
                {
                    SqlCommand comm = new SqlCommand("insert into tblTonGiao values (N'" + Ten + "',N'" + gioithieu + "',N'"+ "/Images/" + hinhanh+"',0,0)", conn);
                    n = comm.ExecuteNonQuery();
                }

                else
                {
                    CloseConnect();
                    return "Lỗi up file: \n" + upfile;
                }
                CloseConnect();
            }
            else
            {
                SqlCommand comm = new SqlCommand("insert into tblTonGiao values (N'" + Ten + "',N'" + gioithieu + "',N'',0,0)", conn);
                n = comm.ExecuteNonQuery();
                CloseConnect();
            }
            if (n > 0)
            {
                return "Thêm Tôn giáo thành công!";
            }
            else return "Thêm Tôn giáo không thành công!";
        }
        catch(Exception ex)
        {
            return "Thêm Tôn giáo không thành công!";
        }
    }
    [WebMethod]
    public int SuaTonGiao(string id, string Ten, string gioithieu, string hinhanh, string sltindo)
    {
        try
        {
            OpenConnect();
            SqlCommand comm = new SqlCommand("update tblTonGiao set TenTonGiao= N'" + Ten + "',GioiThieu= N'" + gioithieu + "',HinhAnh=N'" + hinhanh + "', SLTinDo=0 where IDTonGiao=" + id, conn);
            int n;
            n = comm.ExecuteNonQuery();
            CloseConnect();
            return n;
        }
        catch(Exception e)
        {
            return 0;
        }
    }
    [WebMethod]
    public int Xoa(string id)
    {
        try
        {
            OpenConnect();
            SqlCommand comm = new SqlCommand("update tblTonGiao set daxoa=1 where IDTonGiao=" + id, conn);
            int n;
            n = comm.ExecuteNonQuery();
            CloseConnect();
            return n;
        }
        catch
        {
            return 0;
        }
    }
   // [WebMethod]
    //public Bitmap LoadAnh (string path)
   // {

    //    return Bitmap.FromFile(path);
   // }


}
