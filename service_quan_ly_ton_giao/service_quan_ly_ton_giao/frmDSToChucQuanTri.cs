using System;
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
    public partial class frmDSToChucQuanTri : DevExpress.XtraEditors.XtraForm
    {
        tblToChucQuanTri.tblToChucQuanTriSoapClient wf1 = new tblToChucQuanTri.tblToChucQuanTriSoapClient();
        tblCoSo.ServiceCoSoSoapClient wf2 = new tblCoSo.ServiceCoSoSoapClient();
        public frmDSToChucQuanTri()
        {
            InitializeComponent();
        }
        void HienThi(string where)
        {
            //do du lieu len gridcontrol
            DataTable ds = wf1.HienThiDSToChucQuanTri(where);
            gridControl1.DataSource =ds;
            txtSoLuong.Text = ds.Rows.Count.ToString();
        }
        private void frmDSToChucQuanTri_Load(object sender, EventArgs e)
        {
            HienThi("");
            //do ton giao len treeview
            DataTable ds2 = wf2.DuLieuTonGiao("");
            for (int i = 0; i < int.Parse(ds2.Rows.Count.ToString()); i++)
            {
                treeView1.Nodes["nodeTonGiao"].Nodes.Add(ds2.Rows[i]["TenTonGiao"].ToString());

            }
        }

        private void txtTenTCQTri_TextChanged(object sender, EventArgs e)
        {
            HienThi(" where b.TenToChuc like N'%" + txtTenTCQTri.Text + "%'");
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if(e.Node.Text=="Tôn giáo")
            {
                HienThi("");
            }
            else
            {
                HienThi(" where b.TenTonGiao=N'" + e.Node.Text + "'");
            }
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DataRow row = gridView1.GetFocusedDataRow();
            if (MessageBox.Show("Bạn muốn xóa toàn bộ thông tin về " + row["TenToChuc"].ToString(), "Thông báo???", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                wf1.XoaLogicDLCoSo(int.Parse(row["IDToChuc"].ToString()));
                wf1.XoaCoSotblTinDo(row["TenToChuc"].ToString(), row["TenTonGiao"].ToString(), "");
                //load lai du lieu
                HienThi("");
            }
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            DataRow row = gridView1.GetFocusedDataRow();
            frmChiTietToChucQuanTri frm = new frmChiTietToChucQuanTri();
            frm.txtIDToChuc.Text = row["IDToChuc"].ToString();
            frm.Show();
        }
    }
}