﻿using System;
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
            string strConnect = @"Data Source=MI\M;Initial Catalog=QUANLYTONGIAO;Integrated Security=True";
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
                string upfile = trans.UploadFile(f, hinhanh,"TonGiao");

                if (upfile == "OK")
                {
                    SqlCommand comm = new SqlCommand("insert into tblTonGiao values (N'" + Ten + "',N'" + gioithieu + "',N'"+ "/Images/TonGiao/" + hinhanh+"',0,0)", conn);
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
    public string SuaTonGiao(string id, string Ten, string gioithieu, string hinhanh,byte[] f)
    {
        FilesTransfer trans = new FilesTransfer();
        try
        {
            OpenConnect();
            int n = 0;
            if (hinhanh != "")
            {
                string upfile = trans.UploadFile(f, hinhanh, "TonGiao");

                if (upfile == "OK")
                {
                    SqlCommand comm = new SqlCommand("update tblTonGiao set TenTonGiao= N'" + Ten + "',GioiThieu= N'" + gioithieu + "',HinhAnh=N'~/Images/TonGiao/" + hinhanh + "' where IDTonGiao=" + id, conn);
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
                SqlCommand comm = new SqlCommand("update tblTonGiao set TenTonGiao= N'" + Ten + "',GioiThieu= N'" + gioithieu + " where IDTonGiao=" + id, conn);
                n = comm.ExecuteNonQuery();
                CloseConnect();
            }
            if (n > 0)
            {
                return "Sửa Tôn giáo thành công!";
            }
            else return "Sửa Tôn giáo không thành công!";
        }
        catch (Exception ex)
        {
            return "Sửa Tôn giáo không thành công!";
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
    [WebMethod]
    public string Exec(string sql) // hàm thực thi câu lệnh trong sql
    {
        try
        {
            OpenConnect();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
              CloseConnect();
              return "Back up thành công!";
            
        }
        catch (Exception ex)
        {
            return "Lỗi: " + ex;
        }
    }
    [WebMethod]
    public DataTable GetTable(string sql, string name) // hàm lấy bảng bất kỳ
    {
        DataTable table = new DataTable(name);
        try
        {
            OpenConnect();
            SqlCommand comm = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(comm);
            da.Fill(table);
            CloseConnect();
            return table;

        }
        catch (Exception ex)
        {
            return table;

        }
    }
    [WebMethod]
    public DataTable GetTable2(string sql) // hàm lấy bảng bất kỳ
    {
        DataTable table = new DataTable();
        try
        {
            OpenConnect();
            SqlCommand comm = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(comm);
            da.Fill(table);
            CloseConnect();
            return table;

        }
        catch (Exception ex)
        {
            return table;

        }
    }
    [WebMethod]
    public string PhucHoi(string path)
    {
        try
        {
            string strConnect = @"Data Source=.\SQLEXPRESS; Database=Master;Integrated Security=True";
            conn = new SqlConnection(strConnect);
            conn.Open();

            string stRestore = "ALTER DATABASE [QUANLYTONGIAO] SET SINGLE_USER WITH ROLLBACK IMMEDIATE ";
            stRestore += " RESTORE DATABASE [QUANLYTONGIAO] FROM DISK = N'" + path + "'";
            stRestore += " WITH FILE = 1, NOUNLOAD, REPLACE, STATS = 10";
            stRestore += " ALTER DATABASE [QUANLYTONGIAO] SET MULTI_USER ";
            SqlCommand cmd = new SqlCommand(stRestore, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            return "Phục Hồi thành công!";
        }
        catch(Exception e)
        {
            return "Phục hồi không thành công! Lỗi: \n"+e.ToString();
        }
    }

}
