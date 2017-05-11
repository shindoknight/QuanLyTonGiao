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
    public partial class frmChiTietToChucQuanTri : DevExpress.XtraEditors.XtraForm
    {
        string imageFilePath = @"../../icon/cstg";
        string imageFilePath2 = @"../../icon/tcqt";

        VectorItemsLayer VectorLayer { get { return (VectorItemsLayer)map.Layers["VectorLayer"]; } }
        MapItemStorage ItemStorage { get { return (MapItemStorage)VectorLayer.Data; } }
        tblToChucQuanTri.tblToChucQuanTriSoapClient wf1 = new tblToChucQuanTri.tblToChucQuanTriSoapClient();
        tblCoSo.ServiceCoSoSoapClient wf2 = new tblCoSo.ServiceCoSoSoapClient();
        private bool _doianh = false;
        private string _anh;
        private string _src;
        private string _dst;
        public frmChiTietToChucQuanTri()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        void HienThiLenMapToChucQT()
        {
            DataTable ds2 = wf2.HienThiDSCoSo("", " where a.TenToChuc=N'" + txtTenToChuc.Text + "'");
            ItemStorage.Items.Clear();
            if (int.Parse(ds2.Rows.Count.ToString()) == 0)
            {
                //MessageBox.Show("Tổ chức quản trị " + txtTenToChuc.Text + " không có cơ sở tôn giáo !");
                map.CenterPoint = new GeoPoint(latitude: 15.46056, longitude: 107.7433);
                map.Zoom(5);
            }
            else
            {
                int i;
                for (i = 0; i < int.Parse(ds2.Rows.Count.ToString()); i++)
                {

                    DataTable tv1 = wf2.TimViTri(" where IDXa=N'" + ds2.Rows[i]["DiaChi"].ToString() + "'");
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
                        DataTable tv2 = wf2.TimViTriTheoHuyen(" where IDHuyen=N'" + tv1.Rows[i]["IDHuyen"].ToString() + "'");
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
                DataTable tv4 = wf2.TimViTri(" where IDXa=N'" + ds2.Rows[tam]["DiaChi"].ToString() + "'");
                try
                {
                    string ki = tv4.Rows[0]["ViDo"].ToString().Replace(".", ",");
                    string vi = tv4.Rows[0]["KinhDo"].ToString().Replace(".", ",");

                    map.CenterPoint = new GeoPoint(latitude: float.Parse(ki), longitude: float.Parse(vi));
                    map.Zoom(5);
                }
                catch//trong truong hop không có tọa độ xã->lấy tọa độ của huyện
                {
                    DataTable tv3 = wf2.TimViTriTheoHuyen(" where IDHuyen=N'" + tv4.Rows[tam]["IDHuyen"].ToString() + "'");
                    string ki = tv3.Rows[0]["ViDo"].ToString().Replace(".", ",");
                    string vi = tv3.Rows[0]["KinhDo"].ToString().Replace(".", ",");

                    map.CenterPoint = new GeoPoint(latitude: float.Parse(ki), longitude: float.Parse(vi));
                    map.Zoom(5);
                }
            }
        }
        void HienThi()
        {
            
            DataTable ds = wf1.HienThiDSToChucQuanTri(" where b.IDToChuc=N'"+txtIDToChuc.Text+"'");
            txtTenToChuc.Text = ds.Rows[0]["TenToChuc"].ToString();
            txtSLCS.Text= ds.Rows[0]["SLCoSoTonGiao"].ToString();
            txtSLTD.Text= ds.Rows[0]["SoLuongTinDo"].ToString();
            txtGioiThieu.Text= ds.Rows[0]["GioiThieu"].ToString();
            cboTenTonGiao.Text= ds.Rows[0]["TenTonGiao"].ToString();
            HienThiLenMapToChucQT();
        }
        private void frmChiTietToChucQuanTri_Load(object sender, EventArgs e)
        {
            //do ton giao len cboTonGiao
            cboTenTonGiao.DataSource = wf2.TruyVanTenTonGiao("");
            cboTenTonGiao.DisplayMember = "TenTonGiao";
            HienThi();
            txtIDToChuc.ReadOnly = true;
            txtSLTD.ReadOnly = true;
            txtSLCS.ReadOnly = true;
            txtTenToChuc.ReadOnly = true;
            txtGioiThieu.ReadOnly = true;
            cboTenTonGiao.Enabled = false;

            btnLuu.Enabled = false;
            btnQuayLai.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xóa toàn bộ thông tin về " + txtTenToChuc.Text, "Thông báo???", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                //txtTenCoSo.ReadOnly = false;
                txtIDToChuc.ReadOnly = true;
                txtSLTD.ReadOnly = true;
                txtSLCS.ReadOnly = true;
                txtTenToChuc.ReadOnly = true;
                txtGioiThieu.ReadOnly = true;
                cboTenTonGiao.Enabled = false;

                btnLuu.Enabled = false;
                btnQuayLai.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;

                wf1.XoaLogicDLCoSo(int.Parse(txtIDToChuc.Text));
                MessageBox.Show("Bạn đã xóa toàn bộ thông tin về " + txtTenToChuc.Text + " thành công ");
                this.Close();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtTenToChuc.ReadOnly = false;
            txtGioiThieu.ReadOnly = false;
            cboTenTonGiao.Enabled = true;

            btnLuu.Enabled = true;
            btnQuayLai.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled =false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(txtTenToChuc.Text=="")
            {
                MessageBox.Show("Bạn chưa nhập tên tổ chức.Yêu cầu nhập đầy đủ thông tin!");
            }
            else
            {
                DataTable tg = wf2.DuLieuTonGiao(" where TenTonGiao=N'"+cboTenTonGiao.Text+"'");
                int IDTonGiao = int.Parse(tg.Rows[0]["IDTonGiao"].ToString());
                string HinhAnh = _anh;
                if (_doianh)
                {
                    File.Delete(_dst);
                    File.Copy(_src, _dst);
                    _doianh = false;
                }
                wf1.SuaDLToChuc(int.Parse(txtIDToChuc.Text), txtTenToChuc.Text, IDTonGiao, txtGioiThieu.Text,HinhAnh);
                HienThi();
                txtIDToChuc.ReadOnly = true;
                txtSLTD.ReadOnly = true;
                txtSLCS.ReadOnly = true;
                txtTenToChuc.ReadOnly = true;
                txtGioiThieu.ReadOnly = true;
                cboTenTonGiao.Enabled = false;

                btnLuu.Enabled = false;
                btnQuayLai.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            HienThi();
            txtIDToChuc.ReadOnly = true;
            txtSLTD.ReadOnly = true;
            txtSLCS.ReadOnly = true;
            txtTenToChuc.ReadOnly = true;
            txtGioiThieu.ReadOnly = true;
            cboTenTonGiao.Enabled = false;

            btnLuu.Enabled = false;
            btnQuayLai.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (txtTenToChuc.Text == "")
            {
                MessageBox.Show("Bạn phải điền tên cơ sở tôn giáo trước khi lấy ảnh cơ sở");
            }
            else
            {
                OpenFileDialog LoadAnh = new OpenFileDialog();
                LoadAnh.Filter = "tc(*.png,*.jpg)|*.png;*.jpg|All files(*.*)|*.*";
                LoadAnh.ShowDialog();
                if (LoadAnh.FileName != "")
                {
                    picAnh.Load("../../hinh_anh/tochucquantri/hinh_anh.png");
                    _dst = "../../hinh_anh/tochucquantri/";
                    _anh = "tx_" + txtTenToChuc.Text + ".jpg";
                    _dst += _anh;
                    _src = LoadAnh.FileName;
                    picAnh.Load(LoadAnh.FileName);
                    // _codulieu = true;
                    _doianh = true;
                }
            }
        }
    }
}