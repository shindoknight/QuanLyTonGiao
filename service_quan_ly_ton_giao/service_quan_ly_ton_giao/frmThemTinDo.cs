using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using service_quan_ly_ton_giao.tblTinDo;
namespace service_quan_ly_ton_giao
{
    public partial class frmThemTinDo : Form
    {
        public frmThemTinDo()
        {
            InitializeComponent();
        }

        tblTinDo.tblTinDoSoapClient tindo = new tblTinDoSoapClient();

        void HienThi()
        {

            txtPhapDanh.Clear();
            txtHoDemTheDanh.Clear();
            txtTenTheDanh.Clear();
            txtMatDao.Clear();
            txtMatDoi.Clear();
            textBox9.Clear();
            txtTaiChinh.Clear();
            txtHdCaNhan.Clear();
            txtDhToChuc.Clear();
            txtTcNguyHiem.Clear();
            txtTcTichCuc.Clear();
            
            cbQueQuanTinh.DataSource= tindo.DuLieuTinh();
            cbQueQuanTinh.DisplayMember= "TenTinh";

            cbDiaChiTinh.DataSource = tindo.DuLieuTinh();
            cbDiaChiTinh.DisplayMember = "TenTinh";


            string tongiao = "select * from tblTonGiao";
            cbbTonGiao.DataSource = tindo.OneRecord("tblTonGiao", tongiao);
            cbbTonGiao.DisplayMember = "TenTonGiao";

            string chucsac = "select * from tblchucsac";
            cbbChucSac.DataSource = tindo.OneRecord("tblChucSac",chucsac);
            cbbChucSac.DisplayMember = "TenChucSac";

            string tencoso = "select TenCoSo from tblCoSo";
            cbbCoSo.DataSource = tindo.OneRecord("tblCoSo", tencoso);
            cbbCoSo.DisplayMember = "TenCoSo";

            string chucvu = "select * from tblChucVu";
            cbbChucVu.DataSource = tindo.OneRecord("tblChucVu", chucvu);
            cbbChucVu.DisplayMember = "TenChucVu";
        }

        string IdQueQuan()
        {
            string tinh = cbQueQuanTinh.Text;
            string huyen = cbQueQuanHuyen.Text;
            string xa = cbQueQuanXa.Text;

            string idQQ = tindo.IdQueQuan(tinh, huyen, xa);
            return idQQ;

        }

        string IdDiaChi()
        {
            string tinh = cbDiaChiTinh.Text;
            string huyen = cbDiaChiHuyen.Text;
            string xa = cbDiaChiXa.Text;

            string idDC = tindo.IdDiaChi(tinh, huyen, xa);
            return idDC;

        }

       

        private void frmThemTinDo_Load(object sender, EventArgs e)
        {
            HienThi();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtPhapDanh.Text == "" || txtTenTheDanh.Text == "" || txtHoDemTheDanh.Text == "")
            {
                MessageBox.Show("Bạn Chưa Nhập Đầy Đủ Thông Tin. Yêu Cầu Nhập Đủ");
            }
            else
            {

                string gioiTinh = null;
                if (radioButton1.Checked == true)
                {
                    gioiTinh = radioButton1.Text;
                }
                else
                    if (radioButton2.Checked == true)
                {
                    gioiTinh = radioButton2.Text;
                }
                else if (radioButton3.Checked == true)
                {
                    gioiTinh = radioButton1.Text;
                }

                string phapDanh = txtPhapDanh.Text;
                string tenTheDanh = txtTenTheDanh.Text;
                string hodemTheDanh = txtHoDemTheDanh.Text;
                DateTime NgaySinh = txtNgaySinh.Value;


                string danToc = cbDanToc.Text;
                string queQuan = IdQueQuan();
                string diaChi = IdDiaChi();
                string taiChinh = txtTaiChinh.Text;
                string sucKhoe = txtSucKhoe.Text;
                string tcTichCuc = txtTcTichCuc.Text;
                string tcNguyHiem = txtTcNguyHiem.Text;
                string hinhAnh = "";
                string matDoi = txtMatDoi.Text;
                string matDao = txtMatDao.Text;
                string hdCaNhan = txtHdCaNhan.Text;
                string hdToChuc = txtDhToChuc.Text;

                string ChucSac = cbbChucSac.Text;
                int idChusSac = tindo.IdChucSac(ChucSac);

                string CoSo = cbbCoSo.Text;
                int idCoSo = tindo.IdCoSo(CoSo);

                int daXoa = 0;
                DateTime ngayVaoTonGiao = dtNgayVaoTonGiao.Value;

                string ChucVu = cbbChucVu.Text;
                int idChucVu = tindo.IdChucVu(ChucVu);

                int them = tindo.ThemTinDo(phapDanh, hodemTheDanh, tenTheDanh, NgaySinh, gioiTinh, danToc, queQuan, diaChi, taiChinh, sucKhoe, tcTichCuc, tcNguyHiem, hinhAnh, matDoi, matDao, hdCaNhan, hdToChuc, idChusSac, idCoSo, daXoa, ngayVaoTonGiao, idChucVu);
                if (them == 1)
                {
                    MessageBox.Show("Ok");
                    HienThi();
                }
                else { MessageBox.Show("Fail!"); }
            }
        }

        private void cbQueQuanTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tinh = cbQueQuanTinh.Text;
            if (tinh != null || tinh !="")
            { cbQueQuanHuyen.DataSource = tindo.TruyVanTenHuyen(tinh);
                cbQueQuanHuyen.DisplayMember = "TenHuyen";
                
            }
        }

        private void cbQueQuanHuyen_SelectedIndexChanged(object sender, EventArgs e)
        {
            string huyen = cbQueQuanHuyen.Text;
            if (huyen != null || huyen != "")
            {
                cbQueQuanXa.DataSource = tindo.TruyVanTenXa(huyen);
                cbQueQuanXa.DisplayMember = "TenXa";
            }
        } 

        private void cbDiaChiTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tinh = cbDiaChiTinh.Text;
            if (tinh != null || tinh != "")
            {
                cbDiaChiHuyen.DataSource = tindo.TruyVanTenHuyen(tinh);
                cbDiaChiHuyen.DisplayMember = "TenHuyen";
                
            }
        }
        private void cbDiaChiHuyen_SelectedIndexChanged(object sender, EventArgs e)
        {
            string huyen = cbDiaChiHuyen.Text;
            if (huyen != null || huyen != "")
            {
                cbDiaChiXa.DataSource = tindo.TruyVanTenXa(huyen);
                cbDiaChiXa.DisplayMember = "TenXa";
            }
        }

        private void cbQueQuanXa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtTonGiao_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tongiao = cbbTonGiao.Text;
            
            if (tongiao != null || tongiao != "")
            {
                int id = tindo.IDTonGiao(tongiao);
                cbbChucSac.DataSource = tindo.OneRecord("tblChucSac", "select * from tblChucSac where IDTonGiao = N'"+id+"'");
                cbbChucSac.DisplayMember = "TenChucSac";
            }
        }

        private void cbDiaChiXa_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbbCoSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tencoso = cbbCoSo.Text;

            if (tencoso != null || tencoso != "")
            {
                int id = tindo.IDTonGiao(tencoso);
                cbbChucSac.DataSource = tindo.OneRecord("tblChucSac", "select * from tblChucSac where IDTonGiao = N'" + id + "'");
                cbbChucSac.DisplayMember = "TenChucSac";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HienThi();
        }
    }
}
