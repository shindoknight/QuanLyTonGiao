using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraMap;

namespace service_quan_ly_ton_giao
{
    public partial class frmThemCoSoTonGiao : Form
    {
        string imageFilePath = @"../../icon/cstg";
        string imageFilePath2 = @"../../icon/tcqt";

        VectorItemsLayer VectorLayer { get { return (VectorItemsLayer)map.Layers["VectorLayer"]; } }
        MapItemStorage ItemStorage { get { return (MapItemStorage)VectorLayer.Data; } }
        tblCoSo.ServiceCoSoSoapClient wf = new tblCoSo.ServiceCoSoSoapClient();
        //
        private bool _them = false;
        //sử dụng để dùng với picbox

        private bool _doianh = false;
        private string _anh;
        private string _src;
        private string _dst;
        public frmThemCoSoTonGiao()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        void HienThiToanBoCacCoSoSoTheoTinh()
        {
            map.CenterPoint = new GeoPoint(latitude: 21.04778, longitude: 105.8478);
            map.Zoom(12);
            ItemStorage.Items.Clear();
            DataTable ds = wf.HienThiDSCoSo("", " where a.DiaChi in (select IDXa from tblXa,tblHuyen,tblTinh where tblXa.IDHuyen=tblHuyen.IDHuyen and tblHuyen.IDTinh=tblTinh.IDTinh and TenTinh=N'" + cboTinh.Text + "') ");
            //txtSoLuong.Text = ds.Rows.Count.ToString();
            //DataTable ds2 = wf.HienThiDSCoSo("", " where a.TenTonGiao=N'" + ds.Rows[0]["TenTonGiao"].ToString() + "'");
            if (int.Parse(ds.Rows.Count.ToString()) == 0)
            {
                MessageBox.Show("Thành phố " + cboTinh.Text + " không có cơ sở tôn giáo");
            }
            //xac dinh tam
            DataTable ds3 = wf.DuLieuTinh(" where TenTinh=N'" + cboTinh.Text + "' ");
            DataTable ds4 = wf.DuLieuHuyen(" where IDTinh=N'" + ds3.Rows[0]["IDTinh"].ToString() + "'");
            DataTable ds5 = wf.DuLieuXa("where IDHuyen=N'" + ds4.Rows[0]["IDHuyen"].ToString() + "'");
            try
            {
                string ki = ds5.Rows[0]["ViDo"].ToString();
                string vi = ds5.Rows[0]["KinhDo"].ToString();

                map.CenterPoint = new GeoPoint(latitude: float.Parse(ki), longitude: float.Parse(vi));
                map.Zoom(12);
            }
            catch//trong truong hop không có tọa độ xã->lấy tọa độ của huyện
            {
                DataTable tv3 = wf.TimViTriTheoHuyen(" where IDHuyen=N'" + ds5.Rows[0]["IDHuyen"].ToString() + "'");
                string ki = tv3.Rows[0]["ViDo"].ToString();
                string vi = tv3.Rows[0]["KinhDo"].ToString();

                map.CenterPoint = new GeoPoint(latitude: float.Parse(ki), longitude: float.Parse(vi));
                //map.Zoom(5);
            }
            int i;
            for (i = 0; i < int.Parse(ds.Rows.Count.ToString()); i++)
            {

               
                try
                {
                    string ki = ds.Rows[i]["ViDo"].ToString();
                    string vi = ds.Rows[i]["KinhDo"].ToString();
                    #region #MapCustomElementExample
                    var customElement = new MapCustomElement() { Location = new GeoPoint(float.Parse(ki), float.Parse(vi)), Text = "" + ds.Rows[i]["TenCoSo"].ToString() + "-Địa chỉ: " + ds.Rows[i]["TenXa"].ToString() };
                    var image = new Bitmap(imageFilePath + ds.Rows[i]["IDTonGiao"].ToString() + ".png");
                    customElement.Image = new Bitmap(image, new Size(40, 40));
                    ItemStorage.Items.Add(customElement);
                    #endregion #MapCustomElementExample

                }
                catch//trong truong hop không có tọa độ xã->lấy tọa độ của huyện
                {
                    MessageBox.Show("Xảy ra lỗi");
                }

            }
        }
        void HienThi()
        {
            cboTinh.DataSource = wf.DuLieuTinh("");
            cboTinh.DisplayMember = "TenTinh";
            cboTenTonGiao.DataSource = wf.DuLieuTonGiao("");
            cboTenTonGiao.DisplayMember = "TenTonGiao";
            txtTenCoSo.ResetText();
            txtIDCoSo.ResetText();
            cboIDNguoiQL.ResetText();
            txtTenNguoiQuanLy.ResetText();
            txtTenThuongGoi.ResetText();
            txtKinh.ResetText();
            txtVi.ResetText();
            picAnh.Load("../../hinh_anh/h.a.co_so_tg/hinh_anh.png");
            radCo.Checked = true;
            txtGioiThieu.ResetText();
            txtIDCoSo.Text = (int.Parse(wf.TaoIDCoSo().Rows[0]["IDCoSo"].ToString()) + 1).ToString();
            //DataTable ds = wf.DuLieuTinDo(" where PhapDanh like N'%" + txtTenThuongGoi.Text + "%' and IDCoSo = (select IDCoSo from tblCoSo where DiaChi in(select IDXa from tblXa,tblHuyen,tblTinh where tblXa.IDHuyen=tblHuyen.IDHuyen and tblHuyen.IDTinh=tblTinh.IDTinh and TenXa=N'" + cboXa.Text + "' and TenHuyen=N'" + cboHuyen.Text + "' and TenTinh=N'" + cboTinh.Text + "')) ");
            DataTable ds = wf.DuLieuTinDo(" where PhapDanh like N'%" + txtTenNguoiQuanLy.Text + "%'");
            cboTenNguoiQuanLy.DataSource = ds;
            cboTenNguoiQuanLy.DisplayMember = "PhapDanh";
            HienThiToanBoCacCoSoSoTheoTinh();
        }
        private void frmThemCoSoTonGiao_Load(object sender, EventArgs e)
        {
            HienThi();
        }

        private void cboTenTonGiao_TextChanged(object sender, EventArgs e)
        {
            cboTenToChucQuanTri.DataSource = wf.DuLieuToChucQuanTri(" where IDTonGiao=(select IDTonGiao from tblTonGiao where TenTonGiao=N'" + cboTenTonGiao.Text + "')");
            cboTenToChucQuanTri.DisplayMember = "TenToChuc";
        }
        
        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtTenCoSo.Text==""||txtVi.Text==""||txtKinh.Text=="")
            {
                MessageBox.Show("Thông tin về cơ sở tôn giáo chưa đầy đủ không thể thêm.Yêu cầu xem lại !");
            }
            else
            {
                if (MessageBox.Show("Bạn muốn có muốn thêm toàn bộ thông tin về cơ sở tôn giáo " + txtTenCoSo.Text, "Thông báo???", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string TenCoSo = txtTenCoSo.Text;
                    string TenThuongGoi = txtTenThuongGoi.Text;
                    int ChucNang = 0;
                    if (radCo.Checked == true) ChucNang = 1;
                    if (radKhong.Checked == true) ChucNang = 0;
                    int NguoiQuanLy = 0;
                    int IDToChuc = int.Parse(wf.DuLieuToChucQuanTri(" where TenToChuc=N'" + cboTenToChucQuanTri.Text + "'").Rows[0]["IDToChuc"].ToString());
                    try
                    {
                        DataTable tind = wf.DuLieuTinDo(" where PhapDanh=N'" + txtTenNguoiQuanLy.Text + "' and IDCoSo=N'" + int.Parse(txtIDCoSo.Text) + "'");
                        NguoiQuanLy = int.Parse(tind.Rows[0]["IDTinDo"].ToString());
                    }
                    catch
                    {
                        NguoiQuanLy = 0;
                    }
                    string HinhAnh = _anh;
                    if (_doianh)
                    {
                        File.Delete(_dst);
                        File.Copy(_src, _dst);
                        _doianh = false;
                    }
                    string DiaChi = wf.DuLieuXa(" ,tblHuyen,tblTinh where tblXa.IDHuyen=tblHuyen.IDHuyen and tblHuyen.IDTinh=tblTinh.IDTinh and TenXa=N'" + cboXa.Text + "' and TenHuyen=N'" + cboHuyen.Text + "' and TenTinh=N'" + cboTinh.Text + "'").Rows[0]["IDXa"].ToString();
                    //kiem tra xem xa do da co so ton giao chua
                   
                    string GioiThieu = txtGioiThieu.Text;
                    wf.ThemDLCoSo( TenCoSo, DiaChi, NguoiQuanLy, HinhAnh, IDToChuc, GioiThieu, ChucNang, 0, TenThuongGoi,txtKinh.Text,txtVi.Text);
                    MessageBox.Show("Thông tin về cơ sở tôn giáo đã được lưu");
                    HienThi();
                    //HienThiLenMap();
                    
                }
            }
            
        }

        private void txtTenNguoiQuanLy_TextChanged(object sender, EventArgs e)
        {
            //DataTable ds = wf.DuLieuTinDo(" where PhapDanh like N'%" + txtTenThuongGoi.Text + "%' and IDCoSo = (select IDCoSo from tblCoSo where DiaChi in(select IDXa from tblXa,tblHuyen,tblTinh where tblXa.IDHuyen=tblHuyen.IDHuyen and tblHuyen.IDTinh=tblTinh.IDTinh and TenXa=N'" + cboXa.Text + "' and TenHuyen=N'" + cboHuyen.Text + "' and TenTinh=N'" + cboTinh.Text + "')) ");
            DataTable ds = wf.DuLieuTinDo(" where PhapDanh like N'%" + txtTenNguoiQuanLy.Text + "%'");
            cboTenNguoiQuanLy.DataSource = ds;
            cboTenNguoiQuanLy.DisplayMember = "PhapDanh";

        }

        private void cboTenNguoiQuanLy_TextChanged(object sender, EventArgs e)
        {
            //DataTable ds = wf.DuLieuTinDo(" where PhapDanh ='" + cboTenNguoiQuanLy.Text + "' and IDCoSo =(select IDCoSo from tblCoSo where DiaChi in(select IDXa from tblXa,tblHuyen,tblTinh where tblXa.IDHuyen=tblHuyen.IDHuyen and tblHuyen.IDTinh=tblTinh.IDTinh and TenXa=N'" + cboXa.Text + "' and TenHuyen=N'" + cboHuyen.Text + "' and TenTinh=N'" + cboTinh.Text + "') )");
            DataTable ds = wf.DuLieuTinDo(" where PhapDanh =N'" + cboTenNguoiQuanLy.Text + "'");
            cboIDNguoiQL.DataSource= ds;
            cboIDNguoiQL.DisplayMember = "IDTinDo";
        }

        private void cboTenNguoiQuanLy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboTinh_TextChanged_1(object sender, EventArgs e)
        {
            cboHuyen.DataSource = wf.TruyVanTenHuyen(cboTinh.Text);
            cboHuyen.DisplayMember = "TenHuyen";
            //HienThiToanBoCacCoSoSoTheoTinh();
        }

        private void cboHuyen_TextChanged_1(object sender, EventArgs e)
        {
            cboXa.DataSource = wf.TruyVanTenXa(cboHuyen.Text);
            cboXa.DisplayMember = "TenXa";
        }

        private void cboTenTonGiao_TextChanged_1(object sender, EventArgs e)
        {
            cboTenToChucQuanTri.DataSource = wf.DuLieuToChucQuanTri(" where IDTonGiao=(select IDTonGiao from tblTonGiao where TenTonGiao=N'" + cboTenTonGiao.Text + "')");
            cboTenToChucQuanTri.DisplayMember = "TenToChuc";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //DataTable ds = wf.HienThiDSCoSo("", " where a.IDCoSo=N'" + int.Parse(txtIDCoSo.Text) + "'");
            DataTable ds2 = wf.HienThiDSCoSo("", " where a.TenTonGiao=N'" + cboTenTonGiao.Text + "'");
            ItemStorage.Items.Clear();
            if (int.Parse(ds2.Rows.Count.ToString()) == 0)
            {
                MessageBox.Show(cboTenTonGiao.Text + " không có cơ sở tôn giáo !");
                map.CenterPoint = new GeoPoint(latitude: 15.46056, longitude: 107.7433);
                map.Zoom(5);
            }
            else
            {
                int i;
                for (i = 0; i < int.Parse(ds2.Rows.Count.ToString()); i++)
                {

                    //DataTable tv1 = wf.TimViTri(" where IDXa=N'" + ds2.Rows[i]["DiaChi"].ToString() + "'");
                    try
                    {
                        string ki = ds2.Rows[i]["ViDo"].ToString();
                        string vi = ds2.Rows[i]["KinhDo"].ToString();
                        #region #MapCustomElementExample
                        var customElement = new MapCustomElement() { Location = new GeoPoint(float.Parse(ki), float.Parse(vi)), Text = "" + ds2.Rows[i]["TenCoSo"].ToString() + "-Địa chỉ: " + ds2.Rows[i]["TenXa"].ToString() };
                        var image = new Bitmap(imageFilePath + ds2.Rows[0]["IDTonGiao"].ToString() + ".png");
                        customElement.Image = new Bitmap(image, new Size(40, 40));
                        ItemStorage.Items.Add(customElement);
                        #endregion #MapCustomElementExample
                    }
                    catch//trong truong hop không có tọa độ xã->lấy tọa độ của huyện
                    {
                        MessageBox.Show("Xảy ra lỗi");
                    }

                }
                map.CenterPoint = new GeoPoint(latitude: 15.46056, longitude: 107.7433);
                map.Zoom(5);
            }
        }

        private void btnTimKiemTCQT_Click_1(object sender, EventArgs e)
        {
            DataTable ds2 = wf.HienThiDSCoSo("", " where a.TenToChuc=N'" + cboTenToChucQuanTri.Text + "'");
            ItemStorage.Items.Clear();
            if (int.Parse(ds2.Rows.Count.ToString()) == 0)
            {
                MessageBox.Show("Tổ chức quản trị " + cboTenToChucQuanTri.Text + " không có cơ sở tôn giáo !");
                map.CenterPoint = new GeoPoint(latitude: 15.46056, longitude: 107.7433);
                map.Zoom(5);
            }
            else
            {
                int i;
                for (i = 0; i < int.Parse(ds2.Rows.Count.ToString()); i++)
                {

                    //DataTable tv1 = wf.TimViTri(" where IDXa=N'" + ds2.Rows[i]["DiaChi"].ToString() + "'");
                    try
                    {
                        string ki = ds2.Rows[i]["ViDo"].ToString();
                        string vi = ds2.Rows[i]["KinhDo"].ToString();
                        #region #MapCustomElementExample
                        var customElement = new MapCustomElement() { Location = new GeoPoint(float.Parse(ki), float.Parse(vi)), Text = "" + ds2.Rows[i]["TenCoSo"].ToString() + "-Địa chỉ: " + ds2.Rows[i]["TenXa"].ToString() };
                        var image = new Bitmap(imageFilePath2 + ds2.Rows[0]["IDTonGiao"].ToString() + ".png");
                        customElement.Image = new Bitmap(image, new Size(40, 40));
                        ItemStorage.Items.Add(customElement);
                        #endregion #MapCustomElementExample
                    }
                    catch//trong truong hop không có tọa độ xã->lấy tọa độ của huyện
                    {
                        MessageBox.Show("Xảy ra lỗi");
                    }

                }
                //tim co so lam tam de hien thi

                int tam = int.Parse(ds2.Rows.Count.ToString()) / 2;
                DataTable tv4 = wf.TimViTri(" where IDXa=N'" + ds2.Rows[tam]["DiaChi"].ToString() + "'");
                try
                {
                    string ki = tv4.Rows[0]["ViDo"].ToString();
                    string vi = tv4.Rows[0]["KinhDo"].ToString();

                    map.CenterPoint = new GeoPoint(latitude: float.Parse(ki), longitude: float.Parse(vi));
                    map.Zoom(5);
                }
                catch//trong truong hop không có tọa độ xã->lấy tọa độ của huyện
                {
                    DataTable tv3 = wf.TimViTriTheoHuyen(" where IDHuyen=N'" + tv4.Rows[tam]["IDHuyen"].ToString() + "'");
                    string ki = tv3.Rows[0]["ViDo"].ToString();
                    string vi = tv3.Rows[0]["KinhDo"].ToString();

                    map.CenterPoint = new GeoPoint(latitude: float.Parse(ki), longitude: float.Parse(vi));
                    map.Zoom(5);
                }
            }
        }

        private void btnTimKiemXa_Click_1(object sender, EventArgs e)
        {
            try
            {
                DataTable ds = wf.DuLieuXa(" ,tblHuyen,tblTinh where tblXa.IDHuyen=tblHuyen.IDHuyen and tblHuyen.IDTinh=tblTinh.IDTinh and TenXa=N'" + cboXa.Text + "' and TenHuyen=N'" + cboHuyen.Text + "' and TenTinh=N'" + cboTinh.Text + "'");
                ItemStorage.Items.Clear();
                string ki1 = ds.Rows[0]["ViDo"].ToString();
                string vi1 = ds.Rows[0]["KinhDo"].ToString();
                map.CenterPoint = new GeoPoint(latitude: (float.Parse(ki1)), longitude: (float.Parse(vi1)));
                
                
                map.Zoom(15);
            }
            catch
            {
                MessageBox.Show("Không thể hiển thị tôn giáo do chưa có icon tôn giáo");
            }
        }

        private void ckThanhPho_CheckedChanged_1(object sender, EventArgs e)
        {
            if (ckThanhPho.Checked == true)
            {
                cboTinh.DataSource = wf.DuLieuTinh("where Loai=N'Thành Phố'");
                cboTinh.DisplayMember = "TenTinh";
            }
            else
            {
                cboTinh.DataSource = wf.DuLieuTinh("");
                cboTinh.DisplayMember = "TenTinh";
            }
        }

        private void radCo_CheckedChanged(object sender, EventArgs e)
        {
            if (radCo.Checked == true) radKhong.Checked = false;
        }

        private void radKhong_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radKhong.Checked == true) radCo.Checked = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            HienThi();
        }

        private void picAnh_Click_1(object sender, EventArgs e)
        {
            if(txtTenCoSo.Text=="")
            {
                MessageBox.Show("Bạn phải điền tên cơ sở tôn giáo trước khi lấy ảnh cơ sở");
            }
            else
            {
                OpenFileDialog LoadAnh = new OpenFileDialog();
                LoadAnh.Filter = "cstg(*.png,*.jpg)|*.png;*.jpg|All files(*.*)|*.*";
                LoadAnh.ShowDialog();
                if (LoadAnh.FileName != "")
                {
                    picAnh.Load("../../hinh_anh/h.a.co_so_tg/hinh_anh.png");
                    _dst = "../../hinh_anh/h.a.co_so_tg/";
                    _anh = "cstg_" + txtTenCoSo.Text + ".jpg";
                    _dst += _anh;
                    _src = LoadAnh.FileName;
                    picAnh.Load(LoadAnh.FileName);
                    // _codulieu = true;
                    _doianh = true;
                }
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataTable tc = wf.DuLieuToChucQuanTri(" where TenToChuc=N'" + cboTenToChucQuanTri.Text + "' and IDTonGiao in (select IDTonGiao from tblTonGiao where TenTonGiao=N'" + cboTenTonGiao.Text + "' and DaXoa=0)");
            frmChiTietToChucQuanTri frm = new frmChiTietToChucQuanTri();
            frm.txtIDToChuc.Text = tc.Rows[0]["IDToChuc"].ToString();
            frm.Show();
        }

        private void map_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string x = map.CenterPoint.GetX().ToString();
            string y = map.CenterPoint.GetY().ToString();
            ItemStorage.Items.Clear();
            #region #MapCustomElementExample
            var customElement = new MapCustomElement() { Location = new GeoPoint(float.Parse(y), float.Parse(x)), Text = "" };
            var image = new Bitmap(imageFilePath + "0.png");
            customElement.Image = new Bitmap(image, new Size(40, 40));
            ItemStorage.Items.Add(customElement);
            #endregion #MapCustomElementExample
            /*string[] x1 = x.Split(',');
            x1[1] = x1[1].Substring(0, 8);
            x = x1[0] + "." + x1[1];
            //textBox2.Text = x;
            string[] y1 = y.Split(',');
            y1[1] = y1[1].Substring(0, 8);
            y = y1[0] + "." + y1[1];*/
            x = x.Substring(0, 8);
            y = y.Substring(0, 8);
            txtVi.Text = y;
            txtKinh.Text = x;

        }

        private void map_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormDSTonGiao f = new FormDSTonGiao();
            f.Show();
        }
    }
}
