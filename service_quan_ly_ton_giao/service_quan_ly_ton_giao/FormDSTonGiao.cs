using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace service_quan_ly_ton_giao
{
    public partial class FormDSTonGiao : Form
    {
        public FormDSTonGiao()
        {
            InitializeComponent();

        }
        ServiceTonGiao.ServiceTonGiaoSoapClient ws = new ServiceTonGiao.ServiceTonGiaoSoapClient();
        private void FormDSTonGiao_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            DataTable s = ws.LayDanhSach();
            dgvDSTG.DataSource = s;
            
        }



        private void dgvDSTG_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                lbTenTG.Text = dgvDSTG.CurrentRow.Cells["clmTenTG"].Value.ToString();
                txtSLTindo.Text= dgvDSTG.CurrentRow.Cells["clmSLTinDo"].Value.ToString();
                rtbGioiThieu.Text= dgvDSTG.CurrentRow.Cells["clmGioiThieu"].Value.ToString();
                string hinhanh= dgvDSTG.CurrentRow.Cells["clmHinhAnh"].Value.ToString();
                if (hinhanh!="")
                pictureBox1.Image = Image.FromFile(hinhanh);
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                              // panelHinhAnh.BackgroundImage = global::service_quan_ly_ton_giao.Properties.Resources.user_login_icon;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }
    }
}
