using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;//dùng để sd DataTable
using System.Data.SqlClient;//dùng để sử dụng các câu lệnh kết nối

/// <summary>
/// Summary description for WebService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class WebService : System.Web.Services.WebService
{

    public WebService()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }
    SqlConnection conn = new SqlConnection(@"server=.\SQLEXPRESS; database=QUANLYTONGIAO; integrated security = true;");
    [WebMethod]
    public int  ThemDLCoSo(string TenCoSo,int DiaChi,int NguoiQuanLy,string HinhAnh,int IDToChuc,string GioiThieu,int ChucNang,int DaXoa,string TenThuongGoi)
    {
        try
        {
            //SqlConnection conn = new SqlConnection(@"server=.\SQLEXPRESS; database=QUANLYTONGIAO; integrated security = true;");
            SqlCommand comm = new SqlCommand(@"INSERT INTO tblCoSo(TenCoSo, DiaChi, NguoiQuanLy, HinhAnh, IDToChuc, GioiThieu,ChucNang,DaXoa,TenThuongGoi) VALUES
            (N'" + TenCoSo + "', N'"+ DiaChi + "', N'"+ NguoiQuanLy + "', N'"+ HinhAnh + "', N'"+ IDToChuc + "', N'"+ GioiThieu + "', N'" + ChucNang + "', N'" + DaXoa + "', N'" + TenThuongGoi + "')", conn);
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
    public int SuaDLCoSo(int IDCoSo,string TenCoSo, int DiaChi, int NguoiQuanLy, string HinhAnh, int IDToChuc, string GioiThieu, int ChucNang, int DaXoa, string TenThuongGoi)
    {
        try
        {
            //SqlConnection conn = new SqlConnection(@"server=MI\M; database=QUANLYTONGIAO; integrated security = true;");
            SqlCommand comm = new SqlCommand(@"UPDATE tblCoSo SET TenCoSo =N'" + TenCoSo + "', DiaChi =N'" +DiaChi + "', NguoiQuanLy =N'" + 
                NguoiQuanLy + "',HinhAnh =N'" +HinhAnh + "', IDToChuc =N'" + IDToChuc + "', GioiThieu =N'" + GioiThieu + "',TenThuongGoi =N'" +
                TenThuongGoi + "', ChucNang =N'" + ChucNang + "' where IDCoSo=N'" + IDCoSo + "' and  DaXoa =N'" + DaXoa + "'", conn);
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
            SqlCommand comm = new SqlCommand(@"UPDATE tblCoSo SET DaXoa =N'0' where IDCoSo=N'" + IDCoSo + "' " , conn);
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
    public DataTable HienThiDSCoSo(string dieukien)
    {
       
        //SqlConnection conn = new SqlConnection(@"server=MI\M; database=QUANLYTONGIAO; integrated security = true;");
        SqlCommand comm = new SqlCommand(@"select IDCoSo,TenCoSo,TenThuongGoi,TenXa,ChucNang from  tblCoSo ,tblXa where tblCoSo.DiaChi=tblXa.IDXa and tblCoSo.DaXoa =N'0' "+dieukien, conn);
        comm.CommandType = CommandType.Text;
        SqlDataAdapter da = new SqlDataAdapter(comm);
        DataTable dtdistrict = new DataTable("tblCoSo","tblXa");
        da.Fill(dtdistrict);

        return dtdistrict;
    }
}
