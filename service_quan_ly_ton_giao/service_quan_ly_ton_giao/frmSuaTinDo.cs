﻿using System;
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
        public string id;
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
        public void HienThi()
        {
            cbQueQuanTinh.DataSource = tindo.DuLieuTinh();
            cbQueQuanTinh.DisplayMember = "TenTinh";

            cbDiaChiTinh.DataSource = tindo.DuLieuTinh();
            cbDiaChiTinh.DisplayMember = "TenTinh";

            cbbTonGiao.DataSource = tindo.OneRecord("tblTonGiao", "select * from tblTonGiao");
            cbbTonGiao.DisplayMember = "TenTonGiao";


        }
       
        private void frmSuaTinDo_Load(object sender, EventArgs e)
        {
            HienThi();
            int id = BienToanCuc.IdTinDo;

            DataTable DataTinDo = new DataTable();
            DataTinDo = tindo.OneRecord("tblTinDo", "Select * from tblTinDo where IDTinDo = N'" + id + "'");

            string idXa = DataTinDo.Rows[0]["QueQuan"].ToString();
            if(idXa!="")
            {
                DataTable xahuyentinh = tindo.LayDiaChi(idXa);
                cbQueQuanXa.Text = xahuyentinh.Rows[0]["TenXa"].ToString();
                cbQueQuanHuyen.Text = xahuyentinh.Rows[0]["TenHuyen"].ToString();
                cbQueQuanTinh.Text = xahuyentinh.Rows[0]["TenTinh"].ToString();
            }
            else
            {
                cbQueQuanXa.Text = "";
                cbQueQuanHuyen.Text = "";
                cbQueQuanTinh.Text = "";
            }


            string idXaDiaChi = DataTinDo.Rows[0]["DiaChi"].ToString();
            if (idXaDiaChi != "")
            {
                DataTable xahuyentinh = tindo.LayDiaChi(idXaDiaChi);
                cbDiaChiXa.Text = xahuyentinh.Rows[0]["TenXa"].ToString();
                cbDiaChiHuyen.Text = xahuyentinh.Rows[0]["TenHuyen"].ToString();
                cbDiaChiTinh.Text = xahuyentinh.Rows[0]["TenTinh"].ToString();
            }
            else
            {
                cbDiaChiXa.Text = "";
                cbDiaChiHuyen.Text = "";
                cbDiaChiTinh.Text = "";
            }

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
            txtTenTheDanh.Text = DataTinDo.Rows[0]["TenTheDanh"].ToString();
            txtHoDemTheDanh.Text = DataTinDo.Rows[0]["HoDemTheDanh"].ToString();
            //txtNgaySinh.Value = DateTime.ParseExact(DataTinDo.Rows[0]["NgaySinh"].ToString(), "d", null);


            cbDanToc.Text = DataTinDo.Rows[0]["DanToc"].ToString();
            

            txtTaiChinh.Text = DataTinDo.Rows[0]["TaiChinh"].ToString();

            txtSucKhoe.Text = DataTinDo.Rows[0]["SucKhoe"].ToString();
             txtTcTichCuc.Text = DataTinDo.Rows[0]["TCTichCuc"].ToString();
            txtTcNguyHiem.Text = DataTinDo.Rows[0]["TCNguyHiem"].ToString();
            string hinhAnh = "";
            txtMatDoi.Text = DataTinDo.Rows[0]["MatDoi"].ToString();
            txtMatDao.Text = DataTinDo.Rows[0]["MatDao"].ToString();
            txtHdCaNhan.Text = DataTinDo.Rows[0]["HDCaNhan"].ToString();
            txtDhToChuc.Text = DataTinDo.Rows[0]["HDToChuc"].ToString();

            string ChucSac = DataTinDo.Rows[0]["IDChucSac"].ToString();
            if(ChucSac!="")
            {
                int idChucSac = Int16.Parse(ChucSac);
                object tenchucsac = tindo.LayGiaTriDon("select TenChucSac from tblChucSac where idChucSac = N'"+idChucSac+"'");
                string TenChucSac = tenchucsac.ToString();
                cbbChucSac.Text = TenChucSac;

                object tentongiao = tindo.LayGiaTriDon("select TenTonGiao from tblTonGiao, tblChucSac  where tblTonGiao.IDTonGiao = tblChucSac.IDTonGiao and IDChucSac = N'"+idChucSac+"'");
                string TenTonGiao = tentongiao.ToString();
                cbbTonGiao.Text = TenTonGiao;


            }

            string CoSo = DataTinDo.Rows[0]["IDCoSo"].ToString();
            if (CoSo != "")
            {
                int idCoSo = Int16.Parse(CoSo);
                object tencoso = tindo.LayGiaTriDon("select TenCoSo from tblCoSo where idCoSo = N'" + idCoSo + "'");
                string TenChucSac = tencoso.ToString();
                cbbCoSo.Text = TenChucSac;
            }

            string chucvu = DataTinDo.Rows[0]["IDChucVu"].ToString();
            if (chucvu != "")
            {
                int idChucVu = Int16.Parse(chucvu);
                object tenchucvu = tindo.LayGiaTriDon("select TenChucVu from tblChucVu where IDChucVu = N'" + idChucVu + "'");
                string TenChucVu = tenchucvu.ToString();
                cbbChucVu.Text = TenChucVu;
            }

            /*
            int idChusSac = tindo.IdChucSac(ChucSac); if (idChusSac == 0) idChusSac = 10;

            string CoSo = cbbCoSo.Text;
            int idCoSo = tindo.IdCoSo(CoSo); if (idCoSo == 0) idCoSo = 51;

            int daXoa = 0;
            DateTime ngayVaoTonGiao = dtNgayVaoTonGiao.Value;

            string ChucVu = cbbChucVu.Text;
            int idChucVu = tindo.IdChucVu(ChucVu); if (idChucVu == 0) idChucVu = 13;
            */

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void cbQueQuanTinh_TextChanged(object sender, EventArgs e)
        {
            string tinh = cbQueQuanTinh.Text;
            if (tinh != null || tinh != "")
            {
                cbQueQuanHuyen.DataSource = tindo.TruyVanTenHuyen(tinh);
                cbQueQuanHuyen.DisplayMember = "TenHuyen";

            }
        }

        private void cbDiaChiTinh_TextChanged(object sender, EventArgs e)
        {
            string tinh = cbDiaChiTinh.Text;
            if (tinh != null || tinh != "")
            {
                cbDiaChiHuyen.DataSource = tindo.TruyVanTenHuyen(tinh);
                cbDiaChiHuyen.DisplayMember = "TenHuyen";

            }
        }

        private void cbQueQuanHuyen_TextChanged(object sender, EventArgs e)
        {
            string huyen = cbQueQuanHuyen.Text;
            if (huyen != null || huyen != "")
            {
                cbQueQuanXa.DataSource = tindo.TruyVanTenXa(huyen);
                cbQueQuanXa.DisplayMember = "TenXa";
            }
        }

        private void cbDiaChiHuyen_TextChanged(object sender, EventArgs e)
        {
            string huyen = cbDiaChiHuyen.Text;
            if (huyen != null || huyen != "")
            {
                cbDiaChiXa.DataSource = tindo.TruyVanTenXa(huyen);
                cbDiaChiXa.DisplayMember = "TenXa";
            }
        }

        private void cbbChucSac_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cbbTonGiao_TextChanged(object sender, EventArgs e)
        {
            string tongiao = cbbTonGiao.Text;
            if (tongiao != null || tongiao != "")
            {
                cbbChucSac.DataSource = tindo.OneRecord("tblChucSac","select TenChucSac from tblChucSac, tblTonGiao where tblChucSac.IDTonGiao = tblTonGiao.IDTonGiao and tblTonGiao.TenTonGiao = N'" + tongiao + "'");
                cbbChucSac.DisplayMember = "TenChucSac";
            }

        }
    }
}
