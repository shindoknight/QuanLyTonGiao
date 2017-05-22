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
using DevExpress.XtraNavBar;

namespace service_quan_ly_ton_giao
{
    public partial class frmDSCoSoTonGiao : DevExpress.XtraEditors.XtraForm
    {
        tblCoSo.ServiceCoSoSoapClient wf = new tblCoSo.ServiceCoSoSoapClient();
        tblToChucQuanTri.tblToChucQuanTriSoapClient wf1 = new tblToChucQuanTri.tblToChucQuanTriSoapClient();
        int _quyen;
        public frmDSCoSoTonGiao()
        {
            InitializeComponent();
        }
        public frmDSCoSoTonGiao(int quyen)
        {
            InitializeComponent();
            _quyen = quyen;
            if(quyen==3)
            {
                gridColumn1.Visible = false;
            }
        }
        void HienThi(string where)
        {
            cboTonGiao.DataSource = wf.TruyVanTenTonGiao("");
            cboTonGiao.DisplayMember = "TenTonGiao";
            cboTinh.DataSource = wf.DuLieuTinh("");
            cboTinh.DisplayMember = "TenTinh";
            grcDSTonGiao.DataSource = wf.HienThiDSCoSo("",where);
            //làm việc với treeview
            ///group các thành phố trực thuộc trung ương
            DataTable ds1 = wf.DuLieuTinh(" where Loai=N'Thành phố'");
            for(int i=0;i<int.Parse(ds1.Rows.Count.ToString());i++)
            {
                treeView1.Nodes["nodediagioihanhchinh"].Nodes["nodecThanhPhoTU"].Nodes.Add(ds1.Rows[i]["TenTinh"].ToString());
            }
            //group ton giáo
            DataTable ds2 = wf.DuLieuTonGiao("");
            for (int i = 0; i < int.Parse(ds2.Rows.Count.ToString()); i++)
            {
                treeView1.Nodes["nodeTonGiao"].Nodes.Add(ds2.Rows[i]["TenTonGiao"].ToString());
                DataTable ds6 = wf.DuLieuToChucQuanTri(" where IDTonGiao=N'"+int.Parse(ds2.Rows[i]["IDTonGiao"].ToString()) +"'");
                for (int j = 0; j < int.Parse(ds6.Rows.Count.ToString()); j++)
                {
                    treeView1.Nodes["nodeTonGiao"].Nodes[i].Nodes.Add(ds6.Rows[j]["TenToChuc"].ToString());
                }

            }
            //group khu vuc dia gioi hanh chinh
            DataTable ds3 = wf.DuLieuVung("");
            for (int i = 0; i < int.Parse(ds3.Rows.Count.ToString()); i++)
            {
                treeView1.Nodes["nodediagioihanhchinh"].Nodes["nodecKhuVucDiaGioiHanhChinh"].Nodes.Add(ds3.Rows[i]["TenVungDiaLy"].ToString());
                DataTable ds4 = wf.DuLieuTinh(" where IDVungDiaLy=N'"+ ds3.Rows[i]["IDVungDiaLy"].ToString() + "'");
                for (int j = 0; j < int.Parse(ds4.Rows.Count.ToString()); j++)
                {
                    treeView1.Nodes["nodediagioihanhchinh"].Nodes["nodecKhuVucDiaGioiHanhChinh"].Nodes[i].Nodes.Add(ds4.Rows[j]["TenTinh"].ToString());
                }
            }
        }
        private void frmDSCoSoTonGiao_Load(object sender, EventArgs e)
        {
            HienThi("");
        }

        private void btnXoa_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
          
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DataRow row = gridView1.GetFocusedDataRow();
            if (MessageBox.Show("Bạn muốn xóa toàn bộ thông tin về " + row["TenCoSo"].ToString(), "Thông báo???", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                
                wf.XoaLogicDLCoSo(int.Parse(row["IDCoSo"].ToString()));
                //load lai du lieu
                grcDSTonGiao.DataSource = wf.HienThiDSCoSo("", "");
                try
                {
                    wf.XoaCoSotblTinDo(int.Parse(row["IDCoSo"].ToString()), "");
                }
                catch
                {
                    MessageBox.Show("Không thể xóa bên bảng tin đồ");
                }
            }

        }

        private void grcDSTonGiao_Click(object sender, EventArgs e)
        {
             
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            
        }

        private void cboTinh_TextChanged(object sender, EventArgs e)
        {
            cboHuyen.DataSource = wf.TruyVanTenHuyen(cboTinh.Text);
            cboHuyen.DisplayMember = "TenHuyen";
        }

        private void cboXa_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked==true)
            {
                cboTinh.DataSource = wf.DuLieuTinh("where Loai=N'Thành Phố'");
                cboTinh.DisplayMember = "TenTinh";
            }
            else
            {
                cboTinh.DataSource = wf.DuLieuTinh("");
                cboTinh.DisplayMember = "TenTinh";
            }
        }

        private void cboHuyen_TextChanged(object sender, EventArgs e)
        {
            cboXa.DataSource = wf.TruyVanTenXa(cboHuyen.Text);
            cboXa.DisplayMember = "TenXa";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            DataRow row = gridView1.GetFocusedDataRow();
            frmChiTietCoSoTonGiao frm = new frmChiTietCoSoTonGiao(_quyen);
            frm.txtIDCoSo.Text = row["IDCoSo"].ToString();
            frm.Show();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            DataTable ds2 = wf.DuLieuTonGiao(" where TenTonGiao=N'"+ e.Node.Text + "'");
            if(e.Node.Text=="Tôn giáo" || e.Node.Text== "Địa giới hành chính" || e.Node.Text == "Khu vực địa giới hành chính"|| e.Node.Text == "Thành phố trực thuộc Trung ương")
            {
                grcDSTonGiao.DataSource = wf.HienThiDSCoSo("", "");
            }
            if(int.Parse(ds2.Rows.Count.ToString())==1)
            {
                grcDSTonGiao.DataSource = wf.HienThiDSCoSo(""," where a.TenTonGiao=N'"+ e.Node.Text + "'");
            }
            //click vÀo các tên tỉnh 
            DataTable ds1 = wf.DuLieuTinh(" where TenTinh=N'"+ e.Node.Text + "'"); 
            if(int.Parse(ds1.Rows.Count.ToString()) == 1)
            {
                grcDSTonGiao.DataSource = wf.HienThiDSCoSo("", " where a.DiaChi in (select tblXa.IDXa from tblXa,tblHuyen,tblTinh where tblXa.IDHuyen=tblHuyen.IDHuyen and tblHuyen.IDTinh=tblTinh.IDTinh and TenTinh=N'" +e.Node.Text+"')");
            }
            ///click vào vùng địa lý
            DataTable ds3= wf.DuLieuVung(" where TenVungDiaLy=N'" + e.Node.Text + "'");
            if (int.Parse(ds3.Rows.Count.ToString()) == 1)
            {
                grcDSTonGiao.DataSource = wf.HienThiDSCoSo("", " where a.DiaChi in (select tblXa.IDXa from tblXa,tblHuyen,tblTinh,tblVungDiaLy where tblXa.IDHuyen=tblHuyen.IDHuyen and tblHuyen.IDTinh=tblTinh.IDTinh and tblTinh.IDVungDiaLy=tblVungDiaLy.IDVungDiaLy and TenVungDiaLy=N'" + e.Node.Text + "')");
            }
            //click vao to chuc quan tri
            DataTable ds4 = wf.DuLieuToChucQuanTri(" where TenToChuc=N'" + e.Node.Text + "'");
            if (int.Parse(ds4.Rows.Count.ToString()) == 1)
            {
                grcDSTonGiao.DataSource = wf.HienThiDSCoSo("", " where a.TenToChuc=N'" + e.Node.Text + "'");
            }
        }

        private void cboTonGiao_TextChanged(object sender, EventArgs e)
        {
            cboTenToChucQuanTri.DataSource = wf.DuLieuToChucQuanTri(" where IDTonGiao=(select IDTonGiao from tblTonGiao where TenTonGiao=N'" + cboTonGiao.Text + "')");
            cboTenToChucQuanTri.DisplayMember = "TenToChuc";
        }

        private void btnTimKiemCt_Click(object sender, EventArgs e)
        {
            DataTable xa= wf.DuLieuXa(" ,tblHuyen,tblTinh where tblXa.IDHuyen=tblHuyen.IDHuyen and tblHuyen.IDTinh=tblTinh.IDTinh and TenXa=N'" + cboXa.Text + "' and TenHuyen=N'" + cboHuyen.Text + "' and TenTinh=N'" + cboTinh.Text + "'");
            
            grcDSTonGiao.DataSource = wf.HienThiDSCoSo("", " where a.DiaChi =N'"+xa.Rows[0]["IDXa"].ToString()+"' and a.TenToChuc=N'"+cboTenToChucQuanTri.Text+"'");
        }
        
        private void txtTenCoSo_TextChanged(object sender, EventArgs e)
        {
            grcDSTonGiao.DataSource = wf.HienThiDSCoSo("", " where TenCoSo like N'%" + txtTenCoSo.Text + "%'");
        }

        private void btnChiTietTC_Click(object sender, EventArgs e)
        {
            DataTable tc = wf.DuLieuToChucQuanTri(" where TenToChuc=N'" + cboTenToChucQuanTri.Text + "' and IDTonGiao in (select IDTonGiao from tblTonGiao where TenTonGiao=N'"+cboTonGiao.Text+"' and DaXoa=0)");
            frmChiTietToChucQuanTri frm = new frmChiTietToChucQuanTri();
            frm.txtIDToChuc.Text = tc.Rows[0]["IDToChuc"].ToString();
            frm.Show();
        }

        private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {

        }
    }
}