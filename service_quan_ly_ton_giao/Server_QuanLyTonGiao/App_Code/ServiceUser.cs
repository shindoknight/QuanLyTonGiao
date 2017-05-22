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

}
