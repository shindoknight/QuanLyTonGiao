using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;//dùng để sd DataTable
using System.Data.SqlClient;//dùng để sử dụng các câu lệnh kết nối

/// <summary>
/// Summary description for tblUser
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class tblUser : System.Web.Services.WebService
{

    public tblUser()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    SqlConnection conn = new SqlConnection(@"server=.\SQLEXPRESS; database=QUANLYTONGIAO; integrated security = true;");
    [WebMethod]
    public DataTable DangNhap(string username, string password)
    {

        SqlCommand comm = new SqlCommand("select * from tblUser where UserName=N'" + username + "' and PassWord=N'" + password + "'", conn);
        comm.CommandType = CommandType.Text;
        SqlDataAdapter da = new SqlDataAdapter(comm);
        DataTable dtdistrict = new DataTable("tblUser");
        da.Fill(dtdistrict);
        return dtdistrict;
    }

}
