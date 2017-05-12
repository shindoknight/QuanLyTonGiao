using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;//dùng để sd DataTable
using System.Data.SqlClient;//dùng để sử dụng các câu lệnh kết nối

/// <summary>
/// Summary description for tblToChucQuanTri
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class tblToChucQuanTri : System.Web.Services.WebService
{

    public tblToChucQuanTri()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

   
    SqlConnection conn = new SqlConnection(@"server=MI\M; database=QUANLYTONGIAO; integrated security = true;");
    [WebMethod]
    public int ThemDLToChuc(string TenToChuc, int IDTonGiao, string GioiThieu, string HinhAnh)
    {
        try
        {
            //SqlConnection conn = new SqlConnection(@"server=MI\M; database=QUANLYTONGIAO; integrated security = true;");
            SqlCommand comm = new SqlCommand(@"INSERT INTO tblToChucQuanTri(TenToChuc, IDTonGiao, GioiThieu,DaXoa,HinhAnh) VALUES
            (N'" + TenToChuc + "', N'" + IDTonGiao + "', N'" + GioiThieu + "', N'0',N'" + HinhAnh + "')", conn);
            comm.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(comm);
            DataTable dtdistrict = new DataTable("tblToChucQuanTri");
            da.Fill(dtdistrict);
            return 1;
        }
        catch
        {
            return 0;
        }
    }
    [WebMethod]
    public int SuaDLToChuc(int IDToChuc, string TenToChuc, int IDTonGiao, string GioiThieu, string HinhAnh)
    {
        try
        {
            //SqlConnection conn = new SqlConnection(@"server=MI\M; database=QUANLYTONGIAO; integrated security = true;");
            SqlCommand comm = new SqlCommand(@"UPDATE tblToChucQuanTri SET TenToChuc =N'" + TenToChuc + "', IDTonGiao =N'" + IDTonGiao + "', GioiThieu =N'" + GioiThieu + "',HinhAnh=N'" + HinhAnh + "' where IDToChuc=N'" + IDToChuc + "' and  DaXoa =N'0'", conn);
            comm.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(comm);
            DataTable dtdistrict = new DataTable("tblToChucQuanTri");
            da.Fill(dtdistrict);
            return 1;
        }
        catch
        {
            return 0;
        }
    }
    [WebMethod]
    public int XoaLogicDLCoSo(int IDToChuc)
    {
        try
        {
            //SqlConnection conn = new SqlConnection(@"server=MI\M; database=QUANLYTONGIAO; integrated security = true;");
            SqlCommand comm = new SqlCommand(@"UPDATE tblToChucQuanTri SET DaXoa =N'1' where IDToChuc=N'" + IDToChuc + "' ", conn);
            comm.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(comm);
            DataTable dtdistrict = new DataTable("tblToChucQuanTri");
            da.Fill(dtdistrict);
            return 1;
        }
        catch
        {
            return 0;
        }
    }
    [WebMethod]
    public DataTable HienThiDSToChucQuanTri(string dieukien)
    {
        SqlCommand comm = new SqlCommand(@"select b.IDToChuc,b.TenToChuc,a.SLCoSoTonGiao,b.TenTonGiao,b.IDTonGiao,a.SoLuongTinDo,b.GioiThieu,b.HinhAnh from (select IDToChuc,TenTonGiao,TenToChuc,tblToChucQuanTri.GioiThieu,tblToChucQuanTri.IDTonGiao,tblToChucQuanTri.HinhAnh from tblToChucQuanTri,tblTonGiao where tblTonGiao.IDTonGiao=tblToChucQuanTri.IDTonGiao and tblToChucQuanTri.DaXoa=0) b left join 
        (select COUNT(tblCoSo.IDCoSo) as SLCoSoTonGiao ,IDToChuc,SUM(c.SL) as SoLuongTinDo from tblCoSo ,(select COUNT(IDTinDo) as SL,tblTinDo.IDCoSo from tblTinDo,tblCoSo where tblTinDo.IDCoSo= tblCoSo.IDCoSo
        group by tblTinDo.IDCoSo) c where c.IDCoSo=tblCoSo.IDCoSo group by IDToChuc) a on a.IDToChuc=b.IDToChuc" + dieukien, conn);
        comm.CommandType = CommandType.Text;
        SqlDataAdapter da = new SqlDataAdapter(comm);
        DataTable dtdistrict = new DataTable("a", "b");
        da.Fill(dtdistrict);

        return dtdistrict;
    }
    [WebMethod]
    public DataTable TaoIDToChuc()
    {
        //SqlConnection conn = new SqlConnection(@"server=MI\M; database=dia_gioi_hanh_chinh; integrated security = true;");
        SqlCommand comm = new SqlCommand("select top 1 * from tblToChucQuanTri order by IDToChuc desc ", conn);
        comm.CommandType = CommandType.Text;
        SqlDataAdapter da = new SqlDataAdapter(comm);
        DataTable dt = new DataTable("tblToChucQuanTri");
        da.Fill(dt);
        return dt;
    }

}
