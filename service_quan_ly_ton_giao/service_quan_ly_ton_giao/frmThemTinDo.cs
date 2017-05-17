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
            
            cbQueQuanTinh.DataSource= tindo.DuLieuTinh();
            cbQueQuanTinh.DisplayMember= "TenTinh";

            cbDiaChiTinh.DataSource = tindo.DuLieuTinh();
            cbDiaChiTinh.DisplayMember = "TenTinh";


            string chucsac = "select * from tblchucsac";
            cbbChucSac.DataSource = tindo.OneRecord("tblChucSac",chucsac);
            cbbChucSac.DisplayMember = "TenChucSac";


           


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
            string gioiTinh =null;
            if (radioButton1.Checked==true)
            {
                  gioiTinh = radioButton1.Text;
            }
            else 
                if(radioButton2.Checked==true)
            {
                 gioiTinh = radioButton2.Text;
            }
            else if(radioButton3.Checked==true)
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
            string hinhAnh = null;
            string matDoi = txtMatDoi.Text;
            string matDao = txtMatDao.Text;
            string hdCaNhan = txtHdCaNhan.Text;
            string hdToChuc = txtDhToChuc.Text;

            string ChucSac = cbbChucSac.Text;
            int idChusSac = tindo.IdChucSac(ChucSac); if(idChusSac==0) idChusSac=10;

            string CoSo = cbbCoSo.Text;
            int idCoSo = tindo.IdCoSo(CoSo); if (idCoSo == 0) idCoSo = 51;

            int daXoa = 0;
            DateTime ngayVaoTonGiao = dtNgayVaoTonGiao.Value;

            string ChucVu = cbbChucVu.Text;
            int idChucVu = tindo.IdChucVu(ChucVu); if (idChucVu == 0) idChucVu = 13;

            int them = tindo.ThemTinDo(phapDanh, hodemTheDanh, tenTheDanh, NgaySinh,gioiTinh , danToc, queQuan, diaChi, taiChinh, sucKhoe, tcTichCuc, tcNguyHiem, hinhAnh, matDoi, matDao, hdCaNhan, hdToChuc, idChusSac, idCoSo, daXoa, ngayVaoTonGiao, idChucVu);
            if(them==1)
            {
                MessageBox.Show("Ok");
            }
            else { MessageBox.Show("Fail!"); }
        }

        private void cbQueQuanTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tinh = cbQueQuanTinh.Text;
            if (tinh != null || tinh !="")
            { cbQueQuanHuyen.DataSource = tindo.TruyVanTenHuyen(tinh);
                cbQueQuanHuyen.DisplayMember = "TenHuyen";
                string huyen = cbQueQuanHuyen.Text;
                if (huyen != null || huyen != "") { cbQueQuanXa.DataSource = tindo.TruyVanTenXa(huyen);
                    cbQueQuanXa.DisplayMember = "TenXa";
                }
            }
        }

        private void cbDiaChiTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tinh = cbDiaChiTinh.Text;
            if (tinh != null || tinh != "")
            {
                cbDiaChiHuyen.DataSource = tindo.TruyVanTenHuyen(tinh);
                cbDiaChiHuyen.DisplayMember = "TenHuyen";
                string huyen = cbDiaChiHuyen.Text;
                if (huyen != null || huyen != "")
                {
                    cbDiaChiXa.DataSource = tindo.TruyVanTenXa(huyen);
                    cbDiaChiXa.DisplayMember = "TenXa";
                }
            }
        }

        private void cbQueQuanXa_SelectedIndexChanged(object sender, EventArgs e)
        {
            //txtPhapDanh.Text = IdQueQuan();
        }
    }
}
