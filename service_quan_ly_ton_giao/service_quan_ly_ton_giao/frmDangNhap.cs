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
    public partial class frmDangNhap : System.Windows.Forms.Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            tblUser.WebServiceSoapClient wf = new tblUser.WebServiceSoapClient();
            DataTable dt = wf.DangNhap(txtTenDangNhap.Text, txtMatKhau.Text);
            if (dt.Rows.Count == 1)
            {
                string idUser,username;
                int quyen;
                quyen = int.Parse(dt.Rows[0]["PhanQuyen"].ToString());
                idUser = dt.Rows[0]["IDUser"].ToString();
                username = dt.Rows[0]["UserName"].ToString();
                frmChinh frm = new frmChinh(quyen,idUser,username);
                this.Visible = false;
                frm.FormClosed += new FormClosedEventHandler(frmChinh_Closed);
                //frm.VisibleChanged += new EventHandler(frmChinh_Closed);
                frm.ShowDialog();

            }
            else
            {
                //hien thi thong bao
                MessageBox.Show("Tên người dùng hoặc mật khẩu sai");
            }
        }
        private void frmChinh_Closed(object sender, FormClosedEventArgs e)
        {
            this.Show();
            txtTenDangNhap.Text = "";
            txtMatKhau.Text = "";
            txtTenDangNhap.Focus();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
