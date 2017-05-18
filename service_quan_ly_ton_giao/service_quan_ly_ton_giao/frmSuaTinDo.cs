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
    public partial class frmSuaTinDo : Form
    {
        public frmSuaTinDo()
        {
            InitializeComponent();
        }
        tblTinDoSoapClient tindo = new tblTinDoSoapClient();

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

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void frmSuaTinDo_Load(object sender, EventArgs e)
        {
            int id = BienToanCuc.IdTinDo;

            DataTable DataTinDo = new DataTable();
            DataTinDo = tindo.GetData("tblTinDo", "Select * from tblTinDo where IDTinDo = N'" + id + "'");

            int idXa = Int32.Parse(DataTinDo.Rows[0]["QueQuan"].ToString());



            string gioiTinh = DataTinDo.Rows[0]["GioiTinh"].ToString();
            if (gioiTinh == "Nam")
            {
                radioButton1.Checked = true;
            }
            else
                if (gioiTinh == "Nữ")
            {
                radioButton2.Checked = true;
            }
            else radioButton3.Checked = true;

            txtPhapDanh.Text = DataTinDo.Rows[0]["PhapDanh"].ToString();
            txtTenTheDanh.Text = DataTinDo.Rows[0]["TenPhapDanh"].ToString();
            txtHoDemTheDanh.Text = DataTinDo.Rows[0]["HoDemTheDanh"].ToString();
            txtNgaySinh.Value = DateTime.ParseExact(DataTinDo.Rows[0]["NgaySinh"].ToString(), "d", null);


            cbDanToc.Text = DataTinDo.Rows[0]["DanToc"].ToString();


            string queQuan = DataTinDo.Rows[0]["QueQuan"].ToString();
            int quequan = Int16.Parse(queQuan);
            DataTable xahuyentinh = tindo.DuLieuDon(quequan);
            cbQueQuanXa.Text = xahuyentinh.Rows[0][0].ToString();
            cbQueQuanHuyen.Text = xahuyentinh.Rows[0][1].ToString();
            cbQueQuanTinh.Text = xahuyentinh.Rows[0][2].ToString();

            /*
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
            int idChusSac = tindo.IdChucSac(ChucSac); if (idChusSac == 0) idChusSac = 10;

            string CoSo = cbbCoSo.Text;
            int idCoSo = tindo.IdCoSo(CoSo); if (idCoSo == 0) idCoSo = 51;

            int daXoa = 0;
            DateTime ngayVaoTonGiao = dtNgayVaoTonGiao.Value;

            string ChucVu = cbbChucVu.Text;
            int idChucVu = tindo.IdChucVu(ChucVu); if (idChucVu == 0) idChucVu = 13;

            //int them = tindo.ThemTinDo(phapDanh, hodemTheDanh, tenTheDanh, NgaySinh, gioiTinh, danToc, queQuan, diaChi, taiChinh, sucKhoe, tcTichCuc, tcNguyHiem, hinhAnh, matDoi, matDao, hdCaNhan, hdToChuc, idChusSac, idCoSo, daXoa, ngayVaoTonGiao, idChucVu);
            if (them == 1)
            {
                MessageBox.Show("Ok");
            }
            else { MessageBox.Show("Fail!"); }
            */
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
