using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;
/// <summary>
/// Summary description for tblTinDo
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class tblTinDo : System.Web.Services.WebService
{

    public tblTinDo()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    SqlConnection conn = new SqlConnection(@"server=.\SQLEXPRESS; database=QUANLYTONGIAO; integrated security = true;");


    [WebMethod]
    public DataTable HienThiDSTinDo()
    {
        SqlCommand comm = new SqlCommand("select * from tblTinDo  where DaXoa = 0", conn);
        comm.CommandType = CommandType.Text;
        SqlDataAdapter da = new SqlDataAdapter(comm);
        DataTable dtdistrict = new DataTable("tblTinDo");
        da.Fill(dtdistrict);
        return dtdistrict;
    }

    
}
