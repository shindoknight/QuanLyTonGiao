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
    public DataTable HienThiDSTinDo()
    {
        OpenConnect();
        //SqlCommand comm = new SqlCommand("select * from tblTinDo  where DaXoa = 0", conn);
        SqlCommand comm = new SqlCommand("select * from tblTinDo where DaXoa =0", conn);
        comm.CommandType = CommandType.Text;
        SqlDataAdapter da = new SqlDataAdapter(comm);
        DataTable dtdistrict = new DataTable("tblTinDo");
        da.Fill(dtdistrict);
        CloseConnect();
        return dtdistrict;
    }

    [WebMethod]
    public int ThemTinDo(string phapDanh, string hodemTheDanh, string tenTheDanh, DateTime ngaySinh, string gioiTinh, string danToc, string queQuan, string diaChi, string taiChinh, string sucKhoe, string tcTichCuc, string tcNguyHiem, string hinhAnh, string matDoi, string matDao, string hdCaNhan, string hdToChuc, int idChucSac, int idCoSo, int daXoa, DateTime ngayVaoTonGiao, int idChucVu)
    {
        OpenConnect();
        SqlCommand comm = new SqlCommand("insert into tblTinDo (PhapDanh, HoDemTheDanh, TenTheDanh, NgaySinh, GioiTinh, DanToc, QueQuan, DiaChi,TaiChinh, SucKhoe, " +
            "TCTichCuc, TCNguyHiem, HinhAnh, MatDoi, MatDao, HDCaNhan, HDToChuc, IDChucSac, IDCoSo, DaXoa, NgayVaoTonGiao, IDChucVu) " +
            "Values ( N'" + phapDanh + "', N'" + hodemTheDanh + "', N'" + tenTheDanh + "', N'" + ngaySinh + "' , N'" + gioiTinh + "' , N'" + danToc + "' , N'" + queQuan + "',N'" + diaChi + "' ,N'" + taiChinh + "',N'" + sucKhoe + "'," +
            " N'" + tcTichCuc + "',N'" + tcNguyHiem + "',N'" + hinhAnh + "',N'" + matDoi + "',N'" + matDao + "',N'" + hdCaNhan + "',N'" + hdToChuc + "','" + idChucSac + "','" + idCoSo + "','" + daXoa + "',N'" + ngayVaoTonGiao + "',N'" + idChucVu + "' ) ", conn);

        int kt=comm.ExecuteNonQuery();
        CloseConnect();
        return kt;
    }

    [WebMethod]
    public int XoaTinDo(int Id)
    {
        OpenConnect();
        SqlCommand comm = new SqlCommand("update tblTinDo set DaXoa = 1 where IDTinDo ='" + Id + "' ", conn);
        int t = comm.ExecuteNonQuery();
        CloseConnect();
        if (t > 0) return 1;
        else return 0;
    }

    [WebMethod]
    public DataTable DuLieuTinh()
    {
        OpenConnect();
        //SqlCommand comm = new SqlCommand("select * from tblTinDo  where DaXoa = 0", conn);
        SqlCommand comm = new SqlCommand("select * from tblTinh ", conn);
        comm.CommandType = CommandType.Text;
        SqlDataAdapter da = new SqlDataAdapter(comm);
        DataTable dtdistrict = new DataTable("tblTinh");
        da.Fill(dtdistrict);
        CloseConnect();
        return dtdistrict;
    }

    [WebMethod]
    public DataTable TruyVanTenHuyen(string tinh)
    {
        OpenConnect();
        //SqlConnection conn = new SqlConnection(@"server=MI\M; database=dia_gioi_hanh_chinh; integrated security = true;");
        SqlCommand comm = new SqlCommand("select TenHuyen from tblHuyen where IDTinh=(select IDTinh from tblTinh where TenTinh=N'" + tinh + "')", conn);
        comm.CommandType = CommandType.Text;
        SqlDataAdapter da = new SqlDataAdapter(comm);
        DataTable dtdistrict = new DataTable("tblHuyen");
        da.Fill(dtdistrict);
        CloseConnect();
        return dtdistrict;
    }
    [WebMethod]
    public DataTable TruyVanTenXa(string huyen)
    {
        OpenConnect();
        //SqlConnection conn = new SqlConnection(@"server=MI\M; database=dia_gioi_hanh_chinh; integrated security = true;");
        SqlCommand comm = new SqlCommand("select TenXa from tblXa where IDHuyen=(select IDHuyen from tblHuyen where TenHuyen=N'" + huyen + "')", conn);
        comm.CommandType = CommandType.Text;
        SqlDataAdapter da = new SqlDataAdapter(comm);
        DataTable dtward = new DataTable("tblXa");
        da.Fill(dtward);
        CloseConnect();
        return dtward;
    }

    [WebMethod]
    public string IdQueQuan(string tinh, string huyen, string xa)
    {
        OpenConnect();
        string temp = null;
        //SqlConnection conn = new SqlConnection(@"server=MI\M; database=dia_gioi_hanh_chinh; integrated security = true;");
        SqlCommand comm = new SqlCommand("select IDXa from tblXa where IDHuyen in (select h.IdHuyen from tblHuyen h where IDTinh = (select IdTinh from tblTinh where TenTinh= N'" + tinh + "') and TenHuyen =N'" + huyen + "') and TenXa =N'" + xa + "' ", conn);
        SqlDataReader sqldr = comm.ExecuteReader();
        while (sqldr.Read())
            temp = sqldr[0].ToString();
        CloseConnect();

        return temp;

    }
    [WebMethod]
    public string IdDiaChi(string tinh, string huyen, string xa)
    {
        OpenConnect();
        string temp = null;
        //SqlConnection conn = new SqlConnection(@"server=MI\M; database=dia_gioi_hanh_chinh; integrated security = true;");
        SqlCommand comm = new SqlCommand("select IDXa from tblXa where IDHuyen in (select h.IdHuyen from tblHuyen h where IDTinh = (select IdTinh from tblTinh where TenTinh= N'" + tinh + "') and TenHuyen =N'" + huyen + "') and TenXa =N'" + xa + "' ", conn);
        SqlDataReader sqldr = comm.ExecuteReader();
        while (sqldr.Read())
            temp = sqldr[0].ToString();
        CloseConnect();

        return temp;

    }
    [WebMethod]
    public int IdChucSac(string tenChucSac)
    {
        OpenConnect();
        string temp = null;
        //SqlConnection conn = new SqlConnection(@"server=MI\M; database=dia_gioi_hanh_chinh; integrated security = true;");
        SqlCommand comm = new SqlCommand("select IDChucSac from tblChucSac where TenChucSac = N'" + tenChucSac + "' ", conn);
        SqlDataReader sqldr = comm.ExecuteReader();
        while (sqldr.Read())
            temp = sqldr[0].ToString();
        CloseConnect();
        int id = 0;
        if (temp == null) return id;
        else
        {
            id = Int32.Parse(temp); return id;
        }

    }

    [WebMethod]
    public int IdCoSo(string tenCoSo)
    {
        OpenConnect();
        string temp = null;
        //SqlConnection conn = new SqlConnection(@"server=MI\M; database=dia_gioi_hanh_chinh; integrated security = true;");
        SqlCommand comm = new SqlCommand("select IDCoSo from tblCoSo where TenCoSo = N'" + tenCoSo + "' ", conn);
        SqlDataReader sqldr = comm.ExecuteReader();
        while (sqldr.Read())
            temp = sqldr[0].ToString();
        CloseConnect();

        int id = 0;
        if (temp == null) return id;
        else
        {
            id = Int32.Parse(temp); return id;
        }


    }

    [WebMethod]
    public int IdChucVu(string tenChucVu)
    {
        OpenConnect();
        string temp = null;
        //SqlConnection conn = new SqlConnection(@"server=MI\M; database=dia_gioi_hanh_chinh; integrated security = true;");
        SqlCommand comm = new SqlCommand("select IDChucVu from tblChucVu where TenChucVu = N'" + tenChucVu + "' ", conn);
        SqlDataReader sqldr = comm.ExecuteReader();
        while (sqldr.Read())
            temp = sqldr[0].ToString();
        CloseConnect();
        int id = 0;
        if (temp == null) return id;
        else
        {
            id = Int32.Parse(temp); return id;
        }


    }

    [WebMethod]
    public DataTable OneRecord(string tblBang, string sqlString)
    {
        OpenConnect();

        SqlCommand comm = new SqlCommand(sqlString, conn);
        comm.CommandType = CommandType.Text;
        SqlDataAdapter da = new SqlDataAdapter(comm);
        DataTable dtdistrict = new DataTable(tblBang);
        da.Fill(dtdistrict);
        CloseConnect();
        return dtdistrict;
    }

    [WebMethod]
    public int IDTonGiao(string tenTonGiao)
    {
        OpenConnect();
        string temp = null;
        //SqlConnection conn = new SqlConnection(@"server=MI\M; database=dia_gioi_hanh_chinh; integrated security = true;");
        SqlCommand comm = new SqlCommand("select IdTonGiao from tblTonGiao where TenTonGiao = N'" + tenTonGiao + "' ", conn);
        SqlDataReader sqldr = comm.ExecuteReader();
        while (sqldr.Read())
            temp = sqldr[0].ToString();
        CloseConnect();
        int id = 0;
        if (temp == null) return id;
        else
        {
            id = Int32.Parse(temp); return id;
        }

    }

    [WebMethod]
    public DataTable LayDiaChi(string idxa)
    {
        OpenConnect();
        //string temp = null;
        //SqlConnection conn = new SqlConnection(@"server=MI\M; database=dia_gioi_hanh_chinh; integrated security = true;");
        SqlCommand comm = new SqlCommand("select TenXa,TenHuyen,TenTinh from tblXa a,tblTinh c, tblHuyen b where a.IDHuyen=b.IDHuyen and b.IDTinh=c.IDTinh and IDXa=" + idxa + "", conn);
        SqlDataAdapter da = new SqlDataAdapter(comm);
        DataTable dt = new DataTable("tblXa");
        da.Fill(dt);
        CloseConnect();
        return dt;

    }

    [WebMethod]
    public object LayGiaTriDon(string sqlString)
    {
        OpenConnect();
        object temp = null;
        //SqlConnection conn = new SqlConnection(@"server=MI\M; database=dia_gioi_hanh_chinh; integrated security = true;");
        SqlCommand comm = new SqlCommand(sqlString, conn);
        SqlDataReader sqldr = comm.ExecuteReader();
        while (sqldr.Read())
            temp = sqldr[0].ToString();
        CloseConnect();

        return temp;

    }
    [WebMethod]
    public DataTable LayMotBang(string sqlString)
    {
        OpenConnect();

        SqlCommand comm = new SqlCommand(sqlString, conn);
        comm.CommandType = CommandType.Text;
        SqlDataAdapter da = new SqlDataAdapter(comm);
        DataTable dtdistrict = new DataTable();
        da.Fill(dtdistrict);
        CloseConnect();
        return dtdistrict;
    }
    [WebMethod]
    public int UpdateTinDo(int idTinDo, string phapDanh, string hodemTheDanh, string tenTheDanh, DateTime ngaySinh, string gioiTinh, string danToc, string queQuan, string diaChi, string taiChinh, string sucKhoe, string tcTichCuc, string tcNguyHiem, string hinhAnh, string matDoi, string matDao, string hdCaNhan, string hdToChuc, int idChucSac, int idCoSo, int daXoa, DateTime ngayVaoTonGiao, int idChucVu)
    {
        OpenConnect();
        string sqlString = "update tblTinDo set PhapDanh =N'" + phapDanh + "' , HoDemTheDanh= N'" + hodemTheDanh + "', TenTheDanh= N'" + tenTheDanh + "' , NgaySinh=  N'" + ngaySinh + "', GioiTinh= N'" + gioiTinh + "' , DanToc=  N'" + danToc + "', QueQuan= N'" + queQuan + "', DiaChi= N'" + diaChi + "',TaiChinh= N'" + taiChinh + "', SucKhoe= N'" + sucKhoe + "', " +
                " TCTichCuc =  N'" + tcTichCuc + "', TCNguyHiem =N'" + tcNguyHiem + "' , HinhAnh = N'" + hinhAnh + "', MatDoi =N'" + matDoi + "' , MatDao =N'" + matDao + "' , HDCaNhan = N'" + hdCaNhan + "', HDToChuc =N'" + hdToChuc + "' , IDChucSac ='" + idChucSac + "' , IDCoSo = '" + idCoSo + "', DaXoa = N'" + daXoa + "', NgayVaoTonGiao = N'" + ngayVaoTonGiao + "', IDChucVu = N'" + idChucVu + "' " +
                          " where IDTinDo = N'" + idTinDo + "' ";

        SqlCommand comm = new SqlCommand(sqlString, conn);
        int check = comm.ExecuteNonQuery();
        CloseConnect();
        return check;
    }

}
