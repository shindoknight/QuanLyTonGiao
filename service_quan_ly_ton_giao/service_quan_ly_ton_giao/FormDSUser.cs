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
    public partial class FormDSUser : Form
    {
        public FormDSUser()
        {
            InitializeComponent();
        }
        ServiceUser.ServiceUserSoapClient ws = new ServiceUser.ServiceUserSoapClient();
        private void FormDSUser_Load(object sender, EventArgs e)
        {
           
            gridControl1.DataSource = ws.DanhSach();
        }


        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            btnChiTiet.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            DataRow row = gridView1.GetFocusedDataRow();
            FormUser form = new FormUser(row["IDUser"].ToString(), true);
            form.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DataRow row = gridView1.GetFocusedDataRow();
            DialogResult dlrTraloi;

            dlrTraloi = MessageBox.Show("Bạn chắc chắn muốn xóa ?" + row["username"].ToString(), "Trả Lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dlrTraloi == DialogResult.OK)
            {
                if (ws.Xoa(row["IDUser"].ToString()) > 0)
                {
                    MessageBox.Show("Xóa thành công!");
                }
                else MessageBox.Show("Xóa không thành công!");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = ws.DanhSach();
        }
    }
}
