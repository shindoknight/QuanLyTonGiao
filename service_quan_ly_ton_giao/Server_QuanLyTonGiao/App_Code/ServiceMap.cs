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
    SqlConnection conn = new SqlConnection(@"server=.\SQLEXPRESS; database=QUANLYTONGIAO; integrated security = true;");

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
    [WebMethod]

    public DataTable HienThiTinDoTheoTonGiaoTheoTinh( string dieukien)
    {
        SqlCommand comm = new SqlCommand(@"select SLCoSo,SLTinDo,b.TenTonGiao from (select count(IDTinDo) as SLTinDo,a.TenTonGiao from (select TenTonGiao,tblCoSo.DiaChi,tblCoSo.IDCoSo,tblHuyen.TenHuyen,TenTinh 
        from tblCoSo,tblTonGiao,tblToChucQuanTri,tblXa,tblHuyen,tblTinh where tblCoSo.IDToChuc=tblToChucQuanTri.IDToChuc 
        and tblToChucQuanTri.IDTonGiao=tblTonGiao.IDTonGiao and tblXa.IDXa=tblCoSo.DiaChi and tblHuyen.IDHuyen=tblXa.IDHuyen and tblTinh.IDTinh=tblHuyen.IDTinh and TenTinh like N'%"+dieukien+@"%') a,tblTinDo where tblTinDo.IDCoSo=a.IDCoSo
        group by a.TenTonGiao) b,
        (select TenTonGiao,count(tblCoSo.IDCoSo) as SLCoSo
        from tblCoSo,tblTonGiao,tblToChucQuanTri,tblXa,tblHuyen,tblTinh where tblCoSo.IDToChuc=tblToChucQuanTri.IDToChuc 
        and tblToChucQuanTri.IDTonGiao=tblTonGiao.IDTonGiao and tblXa.IDXa=tblCoSo.DiaChi and tblHuyen.IDHuyen=tblXa.IDHuyen and tblTinh.IDTinh=tblHuyen.IDTinh and TenTinh like N'%"+dieukien+@"%'
        group by tblTonGiao.TenTonGiao) c
        where b.TenTonGiao=c.TenTonGiao", conn);
        comm.CommandType = CommandType.Text;
        SqlDataAdapter da = new SqlDataAdapter(comm);
        DataTable dtdistrict = new DataTable("b", "c");
        da.Fill(dtdistrict);

        return dtdistrict;
    }
    [WebMethod]

    public DataTable HienThiTinDoTheoTonGiaoTheoKhuVuc(string dieukien)
    {
        SqlCommand comm = new SqlCommand(@"select SLCoSo,SLTinDo,b.TenTonGiao from (select count(IDTinDo) as SLTinDo,a.TenTonGiao from (select TenTonGiao,tblCoSo.DiaChi,tblCoSo.IDCoSo,tblHuyen.TenHuyen,TenTinh 
        from tblCoSo,tblTonGiao,tblToChucQuanTri,tblXa,tblHuyen,tblTinh,tblVungDiaLy where tblCoSo.IDToChuc=tblToChucQuanTri.IDToChuc 
        and tblToChucQuanTri.IDTonGiao=tblTonGiao.IDTonGiao and tblXa.IDXa=tblCoSo.DiaChi and tblHuyen.IDHuyen=tblXa.IDHuyen and tblTinh.IDTinh=tblHuyen.IDTinh and tblTinh.IDVungDiaLy=tblVungDiaLy.IDVungDiaLy and TenVungDiaLy like N'%" + dieukien + @"%') a,tblTinDo where tblTinDo.IDCoSo=a.IDCoSo
        group by a.TenTonGiao) b,
        (select TenTonGiao,count(tblCoSo.IDCoSo) as SLCoSo
        from tblCoSo,tblTonGiao,tblToChucQuanTri,tblXa,tblHuyen,tblTinh,tblVungDiaLy where tblCoSo.IDToChuc=tblToChucQuanTri.IDToChuc 
        and tblToChucQuanTri.IDTonGiao=tblTonGiao.IDTonGiao and tblXa.IDXa=tblCoSo.DiaChi and tblHuyen.IDHuyen=tblXa.IDHuyen and tblTinh.IDTinh=tblHuyen.IDTinh and tblTinh.IDVungDiaLy=tblVungDiaLy.IDVungDiaLy and TenVungDiaLy like N'%" + dieukien + @"%'
        group by tblTonGiao.TenTonGiao) c
        where b.TenTonGiao=c.TenTonGiao", conn);
        comm.CommandType = CommandType.Text;
        SqlDataAdapter da = new SqlDataAdapter(comm);
        DataTable dtdistrict = new DataTable("b", "c");
        da.Fill(dtdistrict);

        return dtdistrict;
    }
    [WebMethod]

    public DataTable HienThiCoSoTheoTonGiaoTheoTinh(string TenTinh,string TenTonGiao)
    {
        SqlCommand comm = new SqlCommand(@"select count(IDCoSo) as SLCoSo,TenHuyen from (select IDCoSo,TenHuyen,IDToChuc from tblCoSo,tblXa,tblHuyen,tblTinh where tblXa.IDXa=tblCoSo.DiaChi and tblHuyen.IDHuyen=tblXa.IDHuyen and tblTinh.IDTinh=tblHuyen.IDTinh and TenTinh like N'%" + TenTinh + @"%') a, 
        (select IDToChuc,TenTonGiao from tblToChucQuanTri,tblTonGiao where  tblToChucQuanTri.IDTonGiao=tblTonGiao.IDTonGiao and tblTonGiao.IDTonGiao like N'%" + TenTonGiao+@"%' ) b where  a.IDToChuc=b.IDToChuc
        group by a.TenHuyen", conn);
        comm.CommandType = CommandType.Text;
        SqlDataAdapter da = new SqlDataAdapter(comm);
        DataTable dtdistrict = new DataTable("a", "b");
        da.Fill(dtdistrict);

        return dtdistrict;
    }
    [WebMethod]

    public DataTable HienThiCoSoTheoTonGiaoTheoKhuVuc(string TenKhuVuc, string TenTonGiao)
    {
        SqlCommand comm = new SqlCommand(@"select count(IDCoSo) as SLCoSo,TenTinh from (select IDCoSo,TenTinh,IDToChuc from tblCoSo,tblXa,tblHuyen,tblTinh,tblVungDiaLy where tblXa.IDXa=tblCoSo.DiaChi and tblHuyen.IDHuyen=tblXa.IDHuyen and tblTinh.IDTinh=tblHuyen.IDTinh and tblTinh.IDVungDiaLy=tblVungDiaLy.IDVungDiaLy and TenVungDiaLy like N'%" + TenKhuVuc + @"%') a, 
        (select IDToChuc,TenTonGiao from tblToChucQuanTri,tblTonGiao where  tblToChucQuanTri.IDTonGiao=tblTonGiao.IDTonGiao and tblTonGiao.IDTonGiao like N'%" + TenTonGiao + @"%' ) b where  a.IDToChuc=b.IDToChuc
        group by a.TenTinh", conn);
        comm.CommandType = CommandType.Text;
        SqlDataAdapter da = new SqlDataAdapter(comm);
        DataTable dtdistrict = new DataTable("a", "b");
        da.Fill(dtdistrict);

        return dtdistrict;
    }

}
