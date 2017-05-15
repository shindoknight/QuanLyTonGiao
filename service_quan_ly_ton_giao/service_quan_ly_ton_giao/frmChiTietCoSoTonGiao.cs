using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraMap;

namespace service_quan_ly_ton_giao
{
    public partial class frmChiTietCoSoTonGiao : DevExpress.XtraEditors.XtraForm
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
        public frmChiTietCoSoTonGiao()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
        void HienThiToanBoCacCoSoSoTheoTG()
        {
            DataTable ds = wf.HienThiDSCoSo("", " where a.IDCoSo=N'" + int.Parse(txtIDCoSo.Text) + "'");
            DataTable ds2 = wf.HienThiDSCoSo("", " where a.TenTonGiao=N'" + ds.Rows[0]["TenTonGiao"].ToString() + "'");

            int i;
            for (i = 0; i < int.Parse(ds2.Rows.Count.ToString()); i++)
            {

                DataTable tv1 = wf.TimViTri(" where IDXa=N'" + ds2.Rows[i]["DiaChi"].ToString() + "'");
                try
                {
                    string ki = tv1.Rows[0]["ViDo"].ToString().Replace(".", ",");
                    string vi = tv1.Rows[0]["KinhDo"].ToString().Replace(".", ",");
                    #region #MapCustomElementExample
                    var customElement = new MapCustomElement() { Location = new GeoPoint(float.Parse(ki), float.Parse(vi)), Text = "" + ds2.Rows[i]["TenCoSo"].ToString() + "-Địa chỉ: " + ds2.Rows[i]["TenXa"].ToString() };
                    var image = new Bitmap(imageFilePath + ds.Rows[0]["IDTonGiao"].ToString() + ".png");
                    customElement.Image = new Bitmap(image, new Size(40, 40));
                    ItemStorage.Items.Add(customElement);
                    #endregion #MapCustomElementExample
                }
                catch//trong truong hop không có tọa độ xã->lấy tọa độ của huyện
                {
                    DataTable tv2 = wf.TimViTriTheoHuyen(" where IDHuyen=N'" + tv1.Rows[i]["IDHuyen"].ToString() + "'");
                    string ki = tv2.Rows[0]["ViDo"].ToString().Replace(".", ",");
                    string vi = tv2.Rows[0]["KinhDo"].ToString().Replace(".", ",");
                    #region #MapCustomElementExample
                    var customElement = new MapCustomElement() { Location = new GeoPoint(float.Parse(ki), float.Parse(vi)), Text = "" + ds2.Rows[i]["TenCoSo"].ToString() + "-Địa chỉ: " + ds2.Rows[i]["TenXa"].ToString() };
                    var image = new Bitmap(imageFilePath + ds.Rows[0]["IDTonGiao"].ToString() + ".png");
                    customElement.Image = new Bitmap(image, new Size(40, 40));
                    ItemStorage.Items.Add(customElement);
                    #endregion #MapCustomElementExample*/
                }

            }
        }
        void HienThiLenMap()
        {
            HienThiToanBoCacCoSoSoTheoTG();
            DataTable ds = wf.HienThiDSCoSo("", " where a.IDCoSo=N'" + int.Parse(txtIDCoSo.Text) + "'");
            //xác định tọa độ của xã
            DataTable tv = wf.TimViTri(" where IDXa=N'" + ds.Rows[0]["DiaChi"].ToString() + "'");
            string ki1 = tv.Rows[0]["ViDo"].ToString().Replace(".", ",");
            string vi1 = tv.Rows[0]["KinhDo"].ToString().Replace(".", ",");
            map.CenterPoint = new GeoPoint(latitude: (float.Parse(ki1)), longitude: (float.Parse(vi1)));
        }
        void HienThi()
        {
            ///do ra cboTinh Huyen Xa toan bo du lieu tinh
            cboTinh.DataSource = wf.DuLieuTinh("");
            cboTinh.DisplayMember = "TenTinh";
            cboTenTonGiao.DataSource = wf.DuLieuTonGiao("");
            cboTenTonGiao.DisplayMember = "TenTonGiao";
            
            ////
            DataTable ds = wf.HienThiDSCoSo(",a.GioiThieu", " where a.IDCoSo=N'" + int.Parse(txtIDCoSo.Text) + "'");
            txtIDCoSo.Text = ds.Rows[0]["IDCoSo"].ToString();
            txtTenCoSo.Text= ds.Rows[0]["TenCoSo"].ToString();
            txtTenThuongGoi.Text= ds.Rows[0]["TenThuongGoi"].ToString();
            //hien thi anh len pica
            if (ds.Rows[0]["HinhAnh"].ToString() != null && ds.Rows[0]["HinhAnh"].ToString() != "")
            {
                picAnh.Load("../../hinh_anh/h.a.co_so_tg/" + ds.Rows[0]["HinhAnh"].ToString());
            }
            
            if (ds.Rows[0]["ChucNang"].ToString() == "True")
            {
                radCo.Checked = true;
            }
            else
            {
                radKhong.Checked = true;
            }
            cboTenTonGiao.Text = ds.Rows[0]["TenTonGiao"].ToString();
            cboTenToChucQuanTri.Text = ds.Rows[0]["TenToChuc"].ToString();
            cboTenXa.Text = ds.Rows[0]["TenXa"].ToString();
            //truyen van ra ten huyen
            DataTable huy= wf.TimViTriTheoHuyen(" where IDHuyen in (select IDHuyen from tblXa where IDXa =N'" + ds.Rows[0]["DiaChi"].ToString() + "')");
            cboHuyen.Text = huy.Rows[0]["TenHuyen"].ToString();
            
            //truy van ra tinh
            DataTable ti = wf.TimViTriTheoTinh(" where IDTinh in (select IDTinh from tblHuyen where IDHuyen = N'" + huy.Rows[0]["IDHuyen"].ToString() + "')");
            cboTinh.Text = ti.Rows[0]["TenTinh"].ToString();
            if(ti.Rows[0]["Loai"].ToString()== "Thành Phố")
            {
                ckThanhPho.Checked = true;
            }
            /////
            txtGioiThieu.Text = ds.Rows[0]["GioiThieu"].ToString();
            txtTenNguoiQuanLy.Text = ds.Rows[0]["PhapDanh"].ToString();
            //in len map cac cƠ sở có cùng tôn giáo

            HienThiLenMap();
            
            
           

        }
        private void frmChiTietCoSoTonGiao_Load(object sender, EventArgs e)
        {
            HienThi();
            
        }

        private void cboTenXa_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboTinh_TextChanged(object sender, EventArgs e)
        {
            cboHuyen.DataSource = wf.TruyVanTenHuyen(cboTinh.Text);
            cboHuyen.DisplayMember = "TenHuyen";
            //xac dinh gia tri cbo
            DataTable ds = wf.HienThiDSCoSo("", " where a.IDCoSo=N'" + int.Parse(txtIDCoSo.Text) + "'");
            DataTable huy = wf.TimViTriTheoHuyen(" where IDHuyen in (select IDHuyen from tblXa where IDXa =N'" + ds.Rows[0]["DiaChi"].ToString() + "')");
            cboHuyen.Text = huy.Rows[0]["TenHuyen"].ToString();
        }

        private void cboHuyen_TextChanged(object sender, EventArgs e)
        {
            cboTenXa.DataSource = wf.TruyVanTenXa(cboHuyen.Text);
            cboTenXa.DisplayMember = "TenXa";
            DataTable ds = wf.HienThiDSCoSo(",a.GioiThieu", " where a.IDCoSo=N'" + int.Parse(txtIDCoSo.Text) + "'");
            cboTenXa.Text = ds.Rows[0]["TenXa"].ToString();
        }

        private void ckThanhPho_CheckedChanged(object sender, EventArgs e)
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

        private void map_MapItemClick(object sender, MapItemClickEventArgs e)
        {
            string x= map.CenterPoint.GetX().ToString();
            string y = map.CenterPoint.GetY().ToString();
            //chi lấy 3 số sau . để so sánh tọa đọ lấy được với tọa độ trong csdl
            string[] x1 = x.Split(',');
            x1[1] = x1[1].Substring(0, 3);
            x = x1[0] + "." + x1[1];
            //textBox2.Text = x;
            string[] y1 = y.Split(',');
            y1[1] = y1[1].Substring(0, 3);
            y = y1[0] + "." + y1[1];
            //textBox3.Text = y;
            //x:kinh do ,y:vi do:sau khi lay duoc thi tim ID Xa ->IDCoS0
            DataTable ds = wf.HienThiDSCoSo(",a.GioiThieu", " where a.DiaChi in (select IDXa from tblXa where ViDo like N'%"+y+"%' and KinhDo like N'%"+x+"%')");
            if (int.Parse(ds.Rows.Count.ToString() )== 1)
            {
                txtIDCoSo.Text = ds.Rows[0]["IDCoSo"].ToString();
                HienThi();
            }
                
            //khắc phục thêm nếu có từ 2 cơ sở trở lên

        }

        private void map_MouseClick(object sender, MouseEventArgs e)
        {
          
        }

        private void map_ExportMapItem(object sender, ExportMapItemEventArgs e)
        {
            
        }

        private void cboTenTonGiao_TextChanged(object sender, EventArgs e)
        {
            cboTenToChucQuanTri.DataSource = wf.DuLieuToChucQuanTri(" where IDTonGiao=(select IDTonGiao from tblTonGiao where TenTonGiao=N'" + cboTenTonGiao.Text + "')");
            cboTenToChucQuanTri.DisplayMember = "TenToChuc";
        }

        private void picAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog LoadAnh = new OpenFileDialog();
            LoadAnh.Filter = "cstg(*.png,*.jpg)|*.png;*.jpg|All files(*.*)|*.*";
            LoadAnh.ShowDialog();
            if (LoadAnh.FileName != "")
            {
                picAnh.Load("../../hinh_anh/h.a.co_so_tg/hinh_anh.png");
                _dst = "../../hinh_anh/h.a.co_so_tg/";
                _anh = "cstg_" +txtTenCoSo.Text + ".jpg";
                _dst += _anh;
                _src = LoadAnh.FileName;
                picAnh.Load(LoadAnh.FileName);
               // _codulieu = true;
                _doianh = true;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //danh dau la sua
            txtTenCoSo.ReadOnly = false;
            txtTenCoSo.ReadOnly = false;
            txtTenThuongGoi.ReadOnly = false;
            radCo.Enabled = true;
            radKhong.Enabled = true;
            cboTenTonGiao.Enabled = true;
            cboTenToChucQuanTri.Enabled = true;
            txtTenNguoiQuanLy.ReadOnly = false;
            cboTinh.Enabled = true;
            cboHuyen.Enabled = true;
            cboTenXa.Enabled = true;
            ckThanhPho.Enabled = true;
            txtGioiThieu.ReadOnly = false;
            picAnh.Enabled = true;
            cboNguoiQuanLy.Enabled = true;
            cboIDNguoiQL.Enabled = true;

            btnQuayLai.Enabled = true;
            btnLuu.Enabled = true;
            btnXoa.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //txtTenCoSo.ReadOnly = false;
            txtTenCoSo.ReadOnly = true;
            txtTenThuongGoi.ReadOnly = true;
            radCo.Enabled = false;
            radKhong.Enabled = false;
            cboTenTonGiao.Enabled = false;
            cboTenToChucQuanTri.Enabled = false;
            txtTenNguoiQuanLy.ReadOnly = true;
            cboTinh.Enabled = false;
            cboHuyen.Enabled = false;
            cboTenXa.Enabled = false;
            ckThanhPho.Enabled = false;
            txtGioiThieu.ReadOnly = true;
            cboNguoiQuanLy.Enabled = false;
            cboIDNguoiQL.Enabled = false;

            btnQuayLai.Enabled = false;
            btnLuu.Enabled = false;
            btnXoa.Enabled = true;
            try
            {
                if (txtTenCoSo.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập Tên cơ sở tôn giáo.Yêu cầu nhập đầy đủ !");
                }
                else
                {
                    int IDCoSo = int.Parse(txtIDCoSo.Text);
                    string TenCoSo = txtTenCoSo.Text;
                    string TenThuongGoi = txtTenThuongGoi.Text;
                    int ChucNang = 0;
                    if (radCo.Checked == true) ChucNang = 1;
                    if (radKhong.Checked == true) ChucNang = 0;
                    int NguoiQuanLy = 0;
                    int IDToChuc = int.Parse(wf.DuLieuToChucQuanTri(" where TenToChuc=N'" + cboTenToChucQuanTri.Text + "'").Rows[0]["IDToChuc"].ToString());
                    NguoiQuanLy = int.Parse(cboIDNguoiQL.Text);
                    string HinhAnh = _anh;
                    if (_doianh)
                    {
                        File.Delete(_dst);
                        File.Copy(_src, _dst);
                        _doianh = false;
                    }
                    string DiaChi = wf.DuLieuXa(" ,tblHuyen,tblTinh where tblXa.IDHuyen=tblHuyen.IDHuyen and tblHuyen.IDTinh=tblTinh.IDTinh and TenXa=N'" + cboTenXa.Text + "' and TenHuyen=N'" + cboHuyen.Text + "' and TenTinh=N'" + cboTinh.Text + "'").Rows[0]["IDXa"].ToString();
                    //kiem tra xem xa do da co so ton giao chua
                    DataTable dsx= wf.HienThiDSCoSo(",a.GioiThieu", " where a.DiaChi=N'" + DiaChi + "'");
                    if(int.Parse(dsx.Rows.Count.ToString())==0)
                    {
                        string GioiThieu = txtGioiThieu.Text;
                        wf.SuaDLCoSo(IDCoSo, TenCoSo, DiaChi, NguoiQuanLy, HinhAnh, IDToChuc, GioiThieu, ChucNang, 0, TenThuongGoi);
                        MessageBox.Show("Thông tin về cơ sở tôn giáo đã được lưu");
                        HienThiLenMap();
                    }
                    else
                    {
                        MessageBox.Show("Thông tin về cơ sở tôn giáo có sai sót yêu cầu xem lại !");
                        HienThi();
                    }
                   
                }
            }
            catch
            {
                MessageBox.Show("Thông tin về cơ sở tôn giáo chưa được lưu .Hay xem lại !");
            }
            
            


        }

        private void radCo_CheckedChanged(object sender, EventArgs e)
        {
            if (radCo.Checked == true) radKhong.Checked =false;
        }

        private void radKhong_CheckedChanged(object sender, EventArgs e)
        {
            if (radKhong.Checked == true) radCo.Checked = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DataTable ds = wf.HienThiDSCoSo("", " where a.IDCoSo=N'" + int.Parse(txtIDCoSo.Text) + "'");
            if (MessageBox.Show("Bạn muốn xóa toàn bộ thông tin về " + ds.Rows[0]["TenCoSo"].ToString(), "Thông báo???", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                
                //txtTenCoSo.ReadOnly = false;
                txtTenCoSo.ReadOnly = true;
                txtTenThuongGoi.ReadOnly = true;
                radCo.Enabled = false;
                radKhong.Enabled = false;
                cboTenTonGiao.Enabled = false;
                cboTenToChucQuanTri.Enabled = false;
                txtTenNguoiQuanLy.ReadOnly = true;
                cboTinh.Enabled = false;
                cboHuyen.Enabled = false;
                cboTenXa.Enabled = false;
                ckThanhPho.Enabled = false;
                txtGioiThieu.ReadOnly = true;
                cboNguoiQuanLy.Enabled = false;

                btnQuayLai.Enabled = false;
                btnLuu.Enabled = false;
                btnXoa.Enabled = true;
                try
                {
                    wf.XoaCoSotblTinDo(int.Parse(txtIDCoSo.Text), "");
                }
                catch
                {
                    MessageBox.Show("Không thể xóa bên bảng tin đồ");
                }
                wf.XoaLogicDLCoSo(int.Parse(txtIDCoSo.Text));
                MessageBox.Show("Bạn đã xóa toàn bộ thông tin về " + ds.Rows[0]["TenCoSo"].ToString()+" thành công ");
                this.Close();
            }
            
            
            
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            txtTenCoSo.ReadOnly = true;
            txtTenThuongGoi.ReadOnly = true;
            radCo.Enabled = false;
            radKhong.Enabled = false;
            cboTenTonGiao.Enabled = false;
            cboTenToChucQuanTri.Enabled = false;
            txtTenNguoiQuanLy.ReadOnly = true;
            cboTinh.Enabled = false;
            cboHuyen.Enabled = false;
            cboTenXa.Enabled = false;
            ckThanhPho.Enabled = false;
            txtGioiThieu.ReadOnly = true;
            cboIDNguoiQL.Enabled = false;
            cboNguoiQuanLy.Enabled = false;

            btnQuayLai.Enabled = false;
            btnLuu.Enabled = false;
            btnXoa.Enabled = true;
            HienThi();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //xác định tâm map
            //xac dinh IDXa
            try
            {
                DataTable ds = wf.DuLieuXa(" ,tblHuyen,tblTinh where tblXa.IDHuyen=tblHuyen.IDHuyen and tblHuyen.IDTinh=tblTinh.IDTinh and TenXa=N'" + cboTenXa.Text + "' and TenHuyen=N'" + cboHuyen.Text + "' and TenTinh=N'" + cboTinh.Text + "'");

                string ki1 = ds.Rows[0]["ViDo"].ToString().Replace(".", ",");
                string vi1 = ds.Rows[0]["KinhDo"].ToString().Replace(".", ",");
                map.CenterPoint = new GeoPoint(latitude: (float.Parse(ki1)), longitude: (float.Parse(vi1)));
                //hiển thị toàn vộ các cơ sở theo tôn giáo
                //HienThiToanBoCacCoSoSoTheoTG();
                //hien thi co so TG len map
                DataTable ds2 = wf.DuLieuTonGiao(" where TenTonGiao=N'" + cboTenTonGiao.Text + "'");//xác định là tôn giáo nào
                //ve len map
                #region #MapCustomElementExample
                var customElement = new MapCustomElement() { Location = new GeoPoint(float.Parse(ki1), float.Parse(vi1)), Text = "Địa chỉ: " + cboTenXa.Text };
                var image = new Bitmap(imageFilePath + ds2.Rows[0]["IDTonGiao"].ToString() + ".png");
                customElement.Image = new Bitmap(image, new Size(40, 40));
                ItemStorage.Items.Add(customElement);
                #endregion #MapCustomElementExample*/
                
            }
            catch
            {
                MessageBox.Show("Không thể hiển thị tôn giáo do chưa có icon tôn giáo");
            }
        }

        private void btnTimTonGiao_Click(object sender, EventArgs e)
        {
            
            //DataTable ds = wf.HienThiDSCoSo("", " where a.IDCoSo=N'" + int.Parse(txtIDCoSo.Text) + "'");
            DataTable ds2 = wf.HienThiDSCoSo("", " where a.TenTonGiao=N'" + cboTenTonGiao.Text + "'");
            ItemStorage.Items.Clear();
            if(int.Parse(ds2.Rows.Count.ToString())==0)
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

                    DataTable tv1 = wf.TimViTri(" where IDXa=N'" + ds2.Rows[i]["DiaChi"].ToString() + "'");
                    try
                    {
                        string ki = tv1.Rows[0]["ViDo"].ToString().Replace(".", ",");
                        string vi = tv1.Rows[0]["KinhDo"].ToString().Replace(".", ",");
                        #region #MapCustomElementExample
                        var customElement = new MapCustomElement() { Location = new GeoPoint(float.Parse(ki), float.Parse(vi)), Text = "" + ds2.Rows[i]["TenCoSo"].ToString() + "-Địa chỉ: " + ds2.Rows[i]["TenXa"].ToString() };
                        var image = new Bitmap(imageFilePath + ds2.Rows[0]["IDTonGiao"].ToString() + ".png");
                        customElement.Image = new Bitmap(image, new Size(40, 40));
                        ItemStorage.Items.Add(customElement);
                        #endregion #MapCustomElementExample
                    }
                    catch//trong truong hop không có tọa độ xã->lấy tọa độ của huyện
                    {
                        DataTable tv2 = wf.TimViTriTheoHuyen(" where IDHuyen=N'" + tv1.Rows[i]["IDHuyen"].ToString() + "'");
                        string ki = tv2.Rows[0]["ViDo"].ToString().Replace(".", ",");
                        string vi = tv2.Rows[0]["KinhDo"].ToString().Replace(".", ",");
                        #region #MapCustomElementExample
                        var customElement = new MapCustomElement() { Location = new GeoPoint(float.Parse(ki), float.Parse(vi)), Text = "" + ds2.Rows[i]["TenCoSo"].ToString() + "-Địa chỉ: " + ds2.Rows[i]["TenXa"].ToString() };
                        var image = new Bitmap(imageFilePath + ds2.Rows[0]["IDTonGiao"].ToString() + ".png");
                        customElement.Image = new Bitmap(image, new Size(40, 40));
                        ItemStorage.Items.Add(customElement);
                        #endregion #MapCustomElementExample*/
                    }

                }
                map.CenterPoint = new GeoPoint(latitude: 15.46056, longitude: 107.7433);
                map.Zoom(5);
            }
            
        }

        private void btnTimToChucQuanTri_Click(object sender, EventArgs e)
        {
            DataTable ds2 = wf.HienThiDSCoSo("", " where a.TenToChuc=N'" + cboTenToChucQuanTri.Text + "'");
            ItemStorage.Items.Clear();
            if(int.Parse(ds2.Rows.Count.ToString())==0)
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

                    DataTable tv1 = wf.TimViTri(" where IDXa=N'" + ds2.Rows[i]["DiaChi"].ToString() + "'");
                    try
                    {
                        string ki = tv1.Rows[0]["ViDo"].ToString().Replace(".", ",");
                        string vi = tv1.Rows[0]["KinhDo"].ToString().Replace(".", ",");
                        #region #MapCustomElementExample
                        var customElement = new MapCustomElement() { Location = new GeoPoint(float.Parse(ki), float.Parse(vi)), Text = "" + ds2.Rows[i]["TenCoSo"].ToString() + "-Địa chỉ: " + ds2.Rows[i]["TenXa"].ToString() };
                        var image = new Bitmap(imageFilePath2 + ds2.Rows[0]["IDTonGiao"].ToString() + ".png");
                        customElement.Image = new Bitmap(image, new Size(40, 40));
                        ItemStorage.Items.Add(customElement);
                        #endregion #MapCustomElementExample
                    }
                    catch//trong truong hop không có tọa độ xã->lấy tọa độ của huyện
                    {
                        DataTable tv2 = wf.TimViTriTheoHuyen(" where IDHuyen=N'" + tv1.Rows[i]["IDHuyen"].ToString() + "'");
                        string ki = tv2.Rows[0]["ViDo"].ToString().Replace(".", ",");
                        string vi = tv2.Rows[0]["KinhDo"].ToString().Replace(".", ",");
                        #region #MapCustomElementExample
                        var customElement = new MapCustomElement() { Location = new GeoPoint(float.Parse(ki), float.Parse(vi)), Text = "" + ds2.Rows[i]["TenCoSo"].ToString() + "-Địa chỉ: " + ds2.Rows[i]["TenXa"].ToString() };
                        var image = new Bitmap(imageFilePath2 + ds2.Rows[0]["IDTonGiao"].ToString() + ".png");
                        customElement.Image = new Bitmap(image, new Size(40, 40));
                        ItemStorage.Items.Add(customElement);
                        #endregion #MapCustomElementExample*/
                    }

                }
                //tim co so lam tam de hien thi

                int tam = int.Parse(ds2.Rows.Count.ToString()) / 2;
                DataTable tv4 = wf.TimViTri(" where IDXa=N'" + ds2.Rows[tam]["DiaChi"].ToString() + "'");
                try
                {
                    string ki = tv4.Rows[0]["ViDo"].ToString().Replace(".", ",");
                    string vi = tv4.Rows[0]["KinhDo"].ToString().Replace(".", ",");

                    map.CenterPoint = new GeoPoint(latitude: float.Parse(ki), longitude: float.Parse(vi));
                    map.Zoom(5);
                }
                catch//trong truong hop không có tọa độ xã->lấy tọa độ của huyện
                {
                    DataTable tv3 = wf.TimViTriTheoHuyen(" where IDHuyen=N'" + tv4.Rows[tam]["IDHuyen"].ToString() + "'");
                    string ki = tv3.Rows[0]["ViDo"].ToString().Replace(".", ",");
                    string vi = tv3.Rows[0]["KinhDo"].ToString().Replace(".", ",");

                    map.CenterPoint = new GeoPoint(latitude: float.Parse(ki), longitude: float.Parse(vi));
                    map.Zoom(5);
                }
            }
            
            
        }

        private void btnToChucQuanTri_Click(object sender, EventArgs e)
        {
            DataTable tc = wf.DuLieuToChucQuanTri(" where TenToChuc=N'" + cboTenToChucQuanTri.Text + "' and IDTonGiao in (select IDTonGiao from tblTonGiao where TenTonGiao=N'" + cboTenTonGiao.Text + "' and DaXoa=0)");
            frmChiTietToChucQuanTri frm = new frmChiTietToChucQuanTri();
            frm.txtIDToChuc.Text = tc.Rows[0]["IDToChuc"].ToString();
            frm.Show();
        }

        private void txtTenNguoiQuanLy_TextChanged(object sender, EventArgs e)
        {
            DataTable ds = wf.DuLieuTinDo(" where PhapDanh like N'%" + txtTenNguoiQuanLy.Text + "%'");
            cboNguoiQuanLy.DataSource = ds;
            cboNguoiQuanLy.DisplayMember = "PhapDanh";
        }

        private void cboNguoiQuanLy_TextChanged(object sender, EventArgs e)
        {
            //DataTable ds = wf.DuLieuTinDo(" where PhapDanh ='" + cboTenNguoiQuanLy.Text + "' and IDCoSo =(select IDCoSo from tblCoSo where DiaChi in(select IDXa from tblXa,tblHuyen,tblTinh where tblXa.IDHuyen=tblHuyen.IDHuyen and tblHuyen.IDTinh=tblTinh.IDTinh and TenXa=N'" + cboXa.Text + "' and TenHuyen=N'" + cboHuyen.Text + "' and TenTinh=N'" + cboTinh.Text + "') )");
            DataTable ds = wf.DuLieuTinDo(" where PhapDanh =N'" + cboNguoiQuanLy.Text + "'");
            cboIDNguoiQL.DataSource = ds;
            cboIDNguoiQL.DisplayMember = "IDTinDo";
        }
    }
}