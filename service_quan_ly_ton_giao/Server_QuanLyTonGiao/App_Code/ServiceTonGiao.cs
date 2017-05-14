using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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
    public int ThemTonGiao(string Ten, string gioithieu, string hinhanh)
    {
        try
        {
            OpenConnect();
            SqlCommand comm = new SqlCommand("insert into tblTonGiao (N'" + Ten + "',N'" + gioithieu + "',N'" + hinhanh + "',0,0)", conn);
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
    [WebMethod]
    public int SuaTonGiao(string id, string Ten, string gioithieu, string hinhanh, string sltindo)
    {
        try
        {
            OpenConnect();
            SqlCommand comm = new SqlCommand("update tblTonGiao set TenTonGiao= N'" + Ten + "',GioiThieu= N'" + gioithieu + "',HinhAnh=N'" + hinhanh + "', SLTinDo=0 where id=" + id, conn);
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
    [WebMethod]
    public int Xoa(string id)
    {
        try
        {
            OpenConnect();
            SqlCommand comm = new SqlCommand("update tblTonGiao set daxoa=1 where id=" + id, conn);
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


}
