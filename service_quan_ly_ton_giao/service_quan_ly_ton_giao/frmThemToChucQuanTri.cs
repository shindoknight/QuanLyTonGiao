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

namespace service_quan_ly_ton_giao
{
    public partial class frmThemToChucQuanTri : DevExpress.XtraEditors.XtraForm
    {
        tblToChucQuanTri.tblToChucQuanTriSoapClient wf1 = new tblToChucQuanTri.tblToChucQuanTriSoapClient();
        tblCoSo.ServiceCoSoSoapClient wf2 = new tblCoSo.ServiceCoSoSoapClient();
        public frmThemToChucQuanTri()
        {
            InitializeComponent();
        }
        private bool _doianh = false;
        private string _anh;
        private string _src;
        private string _dst;
        void HienThi()
        {
            txtIDTC.ResetText();
            txtTenToChuc.ResetText();
            txtGioiThieu.ResetText();
            DataTable ds = wf1.TaoIDToChuc();
            txtIDTC.Text = (int.Parse(ds.Rows[0]["IDToChuc"].ToString()) + 1).ToString();
            cboTenTonGiao.DataSource = wf2.TruyVanTenTonGiao("");
            cboTenTonGiao.DisplayMember = "TenTonGiao";
            picAnh.Load("../../hinh_anh/tochucquantri/hinh_anh.png");
        }
        private void picAnh_Click(object sender, EventArgs e)
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
        void HienThiDS(string where)
        {
            DataTable ds = wf1.HienThiDSToChucQuanTri(where);
            gridControl2.DataSource = ds;
        }
        private void frmThemToChucQuanTri_Load(object sender, EventArgs e)
        {
            HienThi();
            HienThiDS("");
        }

        private void btnXoaTT_Click(object sender, EventArgs e)
        {
            HienThi();
        }

        private void btnThemToChuc_Click(object sender, EventArgs e)
        {
            if (txtTenToChuc.Text == "")
            {
                MessageBox.Show("Thông tin về tổ chức quản tri chưa đầy đủ không thể thêm.Yêu cầu xem lại !");
            }
            else
            {
                if (MessageBox.Show("Bạn muốn có muốn thêm toàn bộ thông tin về cơ sở tôn giáo " + txtTenToChuc.Text, "Thông báo???", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DataTable tg = wf2.DuLieuTonGiao(" where TenTonGiao=N'" + cboTenTonGiao.Text + "'");
                    int IDTonGiao = int.Parse(tg.Rows[0]["IDTonGiao"].ToString());
                    string HinhAnh = _anh;
                    if (_doianh)
                    {
                        File.Delete(_dst);
                        File.Copy(_src, _dst);
                        _doianh = false;
                    }
                    wf1.ThemDLToChuc(txtTenToChuc.Text, IDTonGiao, txtGioiThieu.Text, HinhAnh);
                    MessageBox.Show("Bạn đã thêm thành công tổ chức " + txtTenToChuc.Text);
                }
            }
        }

        private void btnTonGiao_Click(object sender, EventArgs e)
        {
            HienThiDS(" where b.TenTonGiao=N'"+cboTenTonGiao.Text+"'");
            FormDSTonGiao f = new FormDSTonGiao();
            f.Show();
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            DataRow row = gridView2.GetFocusedDataRow();
            frmChiTietToChucQuanTri frm = new frmChiTietToChucQuanTri();
            frm.txtIDToChuc.Text = row["IDToChuc"].ToString();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HienThiDS(" where b.TenTonGiao=N'" + cboTenTonGiao.Text + "'");
        }
    }
}