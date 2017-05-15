using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;//dùng để sd DataTable
using System.Data.SqlClient;//dùng để sử dụng các câu lệnh kết nối

/// <summary>
/// Summary description for ServiceMap
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class ServiceMap : System.Web.Services.WebService
{
    SqlConnection conn = new SqlConnection(@"server=MI\M; database=QUANLYTONGIAO; integrated security = true;");

    public ServiceMap()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]

    public DataTable HienThiSLTinDoTheoHuyen(string TenTonGiao, string dieukien)
    {
        SqlCommand comm = new SqlCommand(@"select COUNT(IDTinDo) as SLTinDo ,c.TenHuyen from  tblTinDo,
                (select a.IDCoSo,TenTinh,b.KinhDo,b.ViDo ,a.TenTonGiao,b.IDXa,b.TenVungDiaLy,TenHuyen,IDTinh,IDHuyen from (select TenTonGiao,tblCoSo.DiaChi,tblCoSo.IDCoSo from tblCoSo,tblTonGiao,tblToChucQuanTri where tblCoSo.IDToChuc=tblToChucQuanTri.IDToChuc and tblToChucQuanTri.IDTonGiao=tblTonGiao.IDTonGiao) a,(select tblXa.KinhDo,tblXa.ViDo,TenTinh,IDXa,TenVungDiaLy,TenHuyen,tblHuyen.IDHuyen,tblTinh.IDTinh from tblXa,tblHuyen,tblTinh,tblVungDiaLy where tblXa.IDHuyen=tblHuyen.IDHuyen and tblHuyen.IDTinh=tblTinh.IDTinh and tblVungDiaLy.IDVungDiaLy=tblTinh.IDVungDiaLy) as b
                where a.DiaChi=b.IDXa) c where tblTinDo.IDCoSo=c.IDCoSo and c.TenTonGiao like N'%" + TenTonGiao + 
                        "%' " + dieukien, conn);
        comm.CommandType = CommandType.Text;
        SqlDataAdapter da = new SqlDataAdapter(comm);
        DataTable dtdistrict = new DataTable( "tblTinDo","c");
        da.Fill(dtdistrict);

        return dtdistrict;
    }
    [WebMethod]

    public DataTable HienThiSLTinDoTheoTinh(string TenTonGiao, string dieukien)
    {
        SqlCommand comm = new SqlCommand(@"select COUNT(IDTinDo) as SLTinDo ,c.TenTinh from  tblTinDo,
        (select a.IDCoSo,TenTinh,b.KinhDo,b.ViDo ,a.TenTonGiao,b.IDXa,b.TenVungDiaLy,TenHuyen,IDTinh,IDHuyen from (select TenTonGiao,tblCoSo.DiaChi,tblCoSo.IDCoSo from tblCoSo,tblTonGiao,tblToChucQuanTri where tblCoSo.IDToChuc=tblToChucQuanTri.IDToChuc and tblToChucQuanTri.IDTonGiao=tblTonGiao.IDTonGiao) a,(select tblXa.KinhDo,tblXa.ViDo,TenTinh,IDXa,TenVungDiaLy,TenHuyen,tblHuyen.IDHuyen,tblTinh.IDTinh from tblXa,tblHuyen,tblTinh,tblVungDiaLy where tblXa.IDHuyen=tblHuyen.IDHuyen and tblHuyen.IDTinh=tblTinh.IDTinh and tblVungDiaLy.IDVungDiaLy=tblTinh.IDVungDiaLy) as b
        where a.DiaChi=b.IDXa) c where tblTinDo.IDCoSo=c.IDCoSo and c.TenTonGiao like N'%" + TenTonGiao +
                                "%' " + dieukien, conn);
        comm.CommandType = CommandType.Text;
        SqlDataAdapter da = new SqlDataAdapter(comm);
        DataTable dtdistrict = new DataTable("tblTinDo", "c");
        da.Fill(dtdistrict);

        return dtdistrict;
    }
}
