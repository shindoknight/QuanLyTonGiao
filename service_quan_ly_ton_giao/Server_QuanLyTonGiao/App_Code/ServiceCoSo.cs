using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;//dùng để sd DataTable
using System.Data.SqlClient;//dùng để sử dụng các câu lệnh kết nối

/// <summary>
/// Summary description for ServiceCoSo
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class ServiceCoSo : System.Web.Services.WebService
{

    public ServiceCoSo()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    SqlConnection conn = new SqlConnection(@"server=.\SQLEXPRESS; database=QUANLYTONGIAO; integrated security = true;");
    [WebMethod]
    public int ThemDLCoSo(string TenCoSo, string DiaChi, int NguoiQuanLy, string HinhAnh, int IDToChuc, string GioiThieu, int ChucNang, int DaXoa, string TenThuongGoi)
    {
        try
        {
            //SqlConnection conn = new SqlConnection(@"server=MI\M; database=QUANLYTONGIAO; integrated security = true;");
            SqlCommand comm = new SqlCommand(@"INSERT INTO tblCoSo(TenCoSo, DiaChi, NguoiQuanLy, HinhAnh, IDToChuc, GioiThieu,ChucNang,DaXoa,TenThuongGoi) VALUES
            (N'" + TenCoSo + "', N'" + DiaChi + "', N'" + NguoiQuanLy + "', N'" + HinhAnh + "', N'" + IDToChuc + "', N'" + GioiThieu + "', " + ChucNang + ", N'" + DaXoa + "', N'" + TenThuongGoi + "')", conn);
            comm.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(comm);
            DataTable dtdistrict = new DataTable("tblCoSo");
            da.Fill(dtdistrict);
            return 1;
        }
        catch
        {
            return 0;
        }
    }
    [WebMethod]
    public int SuaDLCoSo(int IDCoSo, string TenCoSo, string DiaChi, int NguoiQuanLy, string HinhAnh, int IDToChuc, string GioiThieu, int ChucNang, int DaXoa, string TenThuongGoi)
    {
        try
        {
            //SqlConnection conn = new SqlConnection(@"server=MI\M; database=QUANLYTONGIAO; integrated security = true;");
            SqlCommand comm = new SqlCommand(@"UPDATE tblCoSo SET TenCoSo =N'" + TenCoSo + "', DiaChi =N'" + DiaChi + "', NguoiQuanLy =N'" +
                NguoiQuanLy + "',HinhAnh =N'" + HinhAnh + "', IDToChuc =N'" + IDToChuc + "', GioiThieu =N'" + GioiThieu + "',TenThuongGoi =N'" +
                TenThuongGoi + "', ChucNang =" + ChucNang + " where IDCoSo=N'" + IDCoSo + "' and  DaXoa =N'" + DaXoa + "'", conn);
            comm.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(comm);
            DataTable dtdistrict = new DataTable("tblCoSo");
            da.Fill(dtdistrict);
            return 1;
        }
        catch
        {
            return 0;
        }
    }
    [WebMethod]
    public int XoaLogicDLCoSo(int IDCoSo)
    {
        try
        {
            //SqlConnection conn = new SqlConnection(@"server=MI\M; database=QUANLYTONGIAO; integrated security = true;");
            SqlCommand comm = new SqlCommand(@"UPDATE tblCoSo SET DaXoa =N'1' where IDCoSo=N'" + IDCoSo + "' ", conn);
            int a=comm.ExecuteNonQuery();
            return a;
        }
        catch
        {
            return 0;
        }
    }
    [WebMethod]
    public DataTable HienThiDSCoSo(string GioiThieu, string dieukien)
    {

        //SqlConnection conn = new SqlConnection(@"server=MI\M; database=QUANLYTONGIAO; integrated security = true;");
        /*SqlCommand comm = new SqlCommand(@"select IDCoSo,TenCoSo,TenThuongGoi,TenXa,ChucNang,TenToChuc,TenTonGiao from  tblCoSo ,tblXa ,tblToChucQuanTri ,tblTonGiao
        where tblCoSo.DiaChi=tblXa.IDXa and tblCoSo.DaXoa =N'0' and tblToChucQuanTri.IDToChuc=tblCoSo.IDToChuc and tblTonGiao.IDTonGiao=tblToChucQuanTri.IDTonGiao " + dieukien, conn);*/
        /*SqlCommand comm = new SqlCommand(@"select * from  tblCoSo ,tblXa ,tblToChucQuanTri ,tblTonGiao,tblTinDo where tblCoSo.DiaChi=tblXa.IDXa and tblCoSo.DaXoa =N'0' 
        and tblToChucQuanTri.IDToChuc=tblCoSo.IDToChuc and tblTonGiao.IDTonGiao=tblToChucQuanTri.IDTonGiao and tblTinDo.IDTinDo=tblCoSo.NguoiQuanLy " + dieukien, conn);*/
        SqlCommand comm = new SqlCommand(@"select a.DiaChi,a.TenToChuc,a.IDCoSo,a.TenXa,a.IDXa,ChucNang,TenThuongGoi,TenCoSo,TenTonGiao,a.IDTonGiao,NguoiQuanLy,a.HinhAnh,PhapDanh" + GioiThieu + " from (select tblCoSo.DiaChi,tblToChucQuanTri.TenToChuc,tblCoSo.IDCoSo,tblXa.TenXa,tblXa.IDXa,ChucNang,TenThuongGoi,TenCoSo,TenTonGiao,tblTonGiao.IDTonGiao,NguoiQuanLy,tblCoSo.GioiThieu,tblCoSo.HinhAnh from  tblToChucQuanTri ,tblCoSo , tblTonGiao ,tblXa where tblTonGiao.IDTonGiao=tblToChucQuanTri.IDTonGiao and tblCoSo.IDToChuc=tblToChucQuanTri.IDToChuc and tblCoSo.DiaChi=tblXa.IDXa and tblCoSo.DaXoa=0) a left join tblTinDo on a.NguoiQuanLy=tblTinDo.IDTinDo " + dieukien, conn);
        comm.CommandType = CommandType.Text;
        SqlDataAdapter da = new SqlDataAdapter(comm);
        DataTable dtdistrict = new DataTable("a","tblTinDo");
        da.Fill(dtdistrict);

        return dtdistrict;
    }
    [WebMethod]
    public DataTable DuLieuTinh(string dieukien)
    {
        //SqlConnection conn = new SqlConnection(@"server=MI\M; database=dia_gioi_hanh_chinh; integrated security = true;");
        SqlCommand comm = new SqlCommand("select * from tblTinh " + dieukien, conn);
        comm.CommandType = CommandType.Text;
        SqlDataAdapter da = new SqlDataAdapter(comm);
        DataTable dtprovince = new DataTable("tblTinh");
        da.Fill(dtprovince);
        return dtprovince;
    }
    [WebMethod]
    public DataTable TruyVanTenHuyen(string tinh)
    {
        //SqlConnection conn = new SqlConnection(@"server=MI\M; database=dia_gioi_hanh_chinh; integrated security = true;");
        SqlCommand comm = new SqlCommand("select TenHuyen from tblHuyen where IDTinh=(select IDTinh from tblTinh where TenTinh=N'" + tinh + "')", conn);
        comm.CommandType = CommandType.Text;
        SqlDataAdapter da = new SqlDataAdapter(comm);
        DataTable dtdistrict = new DataTable("tblHuyen");
        da.Fill(dtdistrict);
        return dtdistrict;
    }
    [WebMethod]
    public DataTable TruyVanTenXa(string huyen)
    {
        //SqlConnection conn = new SqlConnection(@"server=MI\M; database=dia_gioi_hanh_chinh; integrated security = true;");
        SqlCommand comm = new SqlCommand("select TenXa from tblXa where IDHuyen=(select IDHuyen from tblHuyen where TenHuyen=N'" + huyen + "')", conn);
        comm.CommandType = CommandType.Text;
        SqlDataAdapter da = new SqlDataAdapter(comm);
        DataTable dtward = new DataTable("tblXa");
        da.Fill(dtward);
        return dtward;
    }
    [WebMethod]
    public DataTable TruyVanTenTonGiao(string dieukien)
    {
        //SqlConnection conn = new SqlConnection(@"server=MI\M; database=dia_gioi_hanh_chinh; integrated security = true;");
        SqlCommand comm = new SqlCommand("select TenTonGiao from tblTonGiao " + dieukien, conn);
        comm.CommandType = CommandType.Text;
        SqlDataAdapter da = new SqlDataAdapter(comm);
        DataTable dt = new DataTable("tblTonGiao");
        da.Fill(dt);
        return dt;
    }
    [WebMethod]
    public DataTable TimViTri(string dieukien)
    {
        //SqlConnection conn = new SqlConnection(@"server=MI\M; database=dia_gioi_hanh_chinh; integrated security = true;");
        SqlCommand comm = new SqlCommand("select * from tblXa " + dieukien, conn);
        comm.CommandType = CommandType.Text;
        SqlDataAdapter da = new SqlDataAdapter(comm);
        DataTable dt = new DataTable("tblXa");
        da.Fill(dt);
        return dt;
    }
    [WebMethod]
    public DataTable TimViTriTheoHuyen(string dieukien)
    {
        //SqlConnection conn = new SqlConnection(@"server=MI\M; database=dia_gioi_hanh_chinh; integrated security = true;");
        SqlCommand comm = new SqlCommand("select * from tblHuyen " + dieukien, conn);
        comm.CommandType = CommandType.Text;
        SqlDataAdapter da = new SqlDataAdapter(comm);
        DataTable dt = new DataTable("tblHuyen");
        da.Fill(dt);
        return dt;
    }
    [WebMethod]
    public DataTable TimViTriTheoTinh(string dieukien)
    {
        //SqlConnection conn = new SqlConnection(@"server=MI\M; database=dia_gioi_hanh_chinh; integrated security = true;");
        SqlCommand comm = new SqlCommand("select * from tblTinh " + dieukien, conn);
        comm.CommandType = CommandType.Text;
        SqlDataAdapter da = new SqlDataAdapter(comm);
        DataTable dt = new DataTable("tblTinh");
        da.Fill(dt);
        return dt;
    }
    [WebMethod]
    public DataTable DuLieuTonGiao(string dieukien)
    {
        //SqlConnection conn = new SqlConnection(@"server=MI\M; database=dia_gioi_hanh_chinh; integrated security = true;");
        SqlCommand comm = new SqlCommand("select * from tblTonGiao " + dieukien, conn);
        comm.CommandType = CommandType.Text;
        SqlDataAdapter da = new SqlDataAdapter(comm);
        DataTable dt = new DataTable("tblTonGiao");
        da.Fill(dt);
        return dt;
    }
    [WebMethod]
    public DataTable DuLieuVung(string dieukien)
    {
        //SqlConnection conn = new SqlConnection(@"server=MI\M; database=dia_gioi_hanh_chinh; integrated security = true;");
        SqlCommand comm = new SqlCommand("select * from tblVungDiaLy " + dieukien, conn);
        comm.CommandType = CommandType.Text;
        SqlDataAdapter da = new SqlDataAdapter(comm);
        DataTable dt = new DataTable("tblVungDiaLy");
        da.Fill(dt);
        return dt;
    }
    [WebMethod]
    public DataTable DuLieuToChucQuanTri(string dieukien)
    {
        //SqlConnection conn = new SqlConnection(@"server=MI\M; database=dia_gioi_hanh_chinh; integrated security = true;");
        SqlCommand comm = new SqlCommand("select * from tblToChucQuanTri " + dieukien, conn);
        comm.CommandType = CommandType.Text;
        SqlDataAdapter da = new SqlDataAdapter(comm);
        DataTable dt = new DataTable("tblToChucQuanTri");
        da.Fill(dt);
        return dt;
    }
    [WebMethod]
    public DataTable DuLieuTinDo(string dieukien)
    {
        //SqlConnection conn = new SqlConnection(@"server=MI\M; database=dia_gioi_hanh_chinh; integrated security = true;");
        SqlCommand comm = new SqlCommand("select * from tblTinDo " + dieukien, conn);
        comm.CommandType = CommandType.Text;
        SqlDataAdapter da = new SqlDataAdapter(comm);
        DataTable dt = new DataTable("tblTinDo");
        da.Fill(dt);
        return dt;
    }
   
    [WebMethod]
    public DataTable DuLieuXa(string dieukien)
    {
        //SqlConnection conn = new SqlConnection(@"server=MI\M; database=dia_gioi_hanh_chinh; integrated security = true;");
        SqlCommand comm = new SqlCommand("select * from tblXa " + dieukien, conn);
        comm.CommandType = CommandType.Text;
        SqlDataAdapter da = new SqlDataAdapter(comm);
        DataTable dt = new DataTable("tblXa");
        da.Fill(dt);
        return dt;
    }
    [WebMethod]
    public DataTable DuLieuHuyen(string dieukien)
    {
        //SqlConnection conn = new SqlConnection(@"server=MI\M; database=dia_gioi_hanh_chinh; integrated security = true;");
        SqlCommand comm = new SqlCommand("select * from tblHuyen " + dieukien, conn);
        comm.CommandType = CommandType.Text;
        SqlDataAdapter da = new SqlDataAdapter(comm);
        DataTable dt = new DataTable("tblHuyen");
        da.Fill(dt);
        return dt;
    }
    [WebMethod]
    public DataTable TaoIDCoSo()
    {
        //SqlConnection conn = new SqlConnection(@"server=MI\M; database=dia_gioi_hanh_chinh; integrated security = true;");
        SqlCommand comm = new SqlCommand("select top 1 * from tblCoSo order by IDCoSo desc ", conn);
        comm.CommandType = CommandType.Text;
        SqlDataAdapter da = new SqlDataAdapter(comm);
        DataTable dt = new DataTable("tblCoSo");
        da.Fill(dt);
        return dt;
    }
    [WebMethod]
    public int XoaCoSotblTinDo(int IDCoSo,string DieuKien)
    {
        try
        {
            //SqlConnection conn = new SqlConnection(@"server=MI\M; database=dia_gioi_hanh_chinh; integrated security = true;");
            SqlCommand comm = new SqlCommand("UPDATE tblTinDo SET IDCoSo = NULL where IDCoSo =N'"+IDCoSo+"' " + DieuKien, conn);
            comm.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(comm);
            DataTable dt = new DataTable("tblTinDo");
            da.Fill(dt);
            return 1;
        }
        catch
        {
            return 0;
        }
    }
}
