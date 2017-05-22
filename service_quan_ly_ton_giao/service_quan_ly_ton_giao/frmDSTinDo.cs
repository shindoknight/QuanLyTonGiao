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
using service_quan_ly_ton_giao.tblTinDo;


namespace service_quan_ly_ton_giao
{
    public partial class frmDSTinDo : DevExpress.XtraEditors.XtraForm
    {
        public frmDSTinDo()
        {
            InitializeComponent();
        }
        tblTinDo.tblTinDoSoapClient tindo = new tblTinDoSoapClient();
        private void frmDSTinDo_Load(object sender, EventArgs e)
        {
            
            gridCTinDo.DataSource = tindo.HienThiDSTinDo();
            TreeView();
            DataTable ds2 = wf.DuLieuTonGiao("");
           
            //cboTonGiao.Items.Add("Tất Cả");
            for(int i=0;i<ds2.Rows.Count;i++)
            {
                cboTonGiao.Items.Add(ds2.Rows[i]["TenTonGiao"].ToString());
            }
        }

        private void gridCTinDo_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void gridCTinDo_Click(object sender, EventArgs e)
        {
            DataRow row = gridVTinDo.GetFocusedDataRow();
            BienToanCuc.IdTinDo = int.Parse(row["IDTinDo"].ToString());
            BienToanCuc.tenTinDo = row["HoDemTheDanh"].ToString() + row["TenTheDanh"].ToString();
            bntSua.Enabled = true;
            bntXoa.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            
        }

        private void gridCTinDo_DoubleClick(object sender, EventArgs e)
        {
            DataRow row = gridVTinDo.GetFocusedDataRow();
            BienToanCuc.IdTinDo = int.Parse(row["IDTinDo"].ToString());
            BienToanCuc.tenTinDo = row["HoDemTheDanh"].ToString() + row["TenTheDanh"].ToString();
        }

        private void gridCTinDo_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bntSua.Enabled = false;
            bntXoa.Enabled = false;
            gridCTinDo.DataSource = tindo.HienThiDSTinDo();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void bntSua_Click(object sender, EventArgs e)
        {
            frmSuaTinDo sua = new frmSuaTinDo();
            sua.ShowDialog();
            gridCTinDo.DataSource = tindo.HienThiDSTinDo();
        }

        private void bntXoa_Click(object sender, EventArgs e)
        {
            int id = BienToanCuc.IdTinDo;

            string tenTindo = BienToanCuc.tenTinDo;

            if (MessageBox.Show("Xóa " + tenTindo, "Thông báo???", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                int i = tindo.XoaTinDo(id);
                if (i > 0)
                {
                    MessageBox.Show("Xóa Thành Công ");
                    bntXoa.Enabled = false;
                    bntSua.Enabled = false;
                    gridCTinDo.DataSource = tindo.HienThiDSTinDo();
                  
                }
                else
                {
                    MessageBox.Show("Xóa Không Thành Công ");
                }

            }

        }
        tblCoSo.ServiceCoSoSoapClient wf = new tblCoSo.ServiceCoSoSoapClient();
        public void TreeView()
        {
            DataTable ds1 = wf.DuLieuTinh(" where Loai=N'Thành phố'");
            for (int i = 0; i < int.Parse(ds1.Rows.Count.ToString()); i++)
            {
                treeView1.Nodes["nodediagioihanhchinh"].Nodes["nodecThanhPhoTU"].Nodes.Add(ds1.Rows[i]["TenTinh"].ToString());
            }
            //group ton giáo
            
            
            //group khu vuc dia gioi hanh chinh
            DataTable ds3 = wf.DuLieuVung("");
            for (int i = 0; i < int.Parse(ds3.Rows.Count.ToString()); i++)
            {
                treeView1.Nodes["nodediagioihanhchinh"].Nodes["nodecKhuVucDiaGioiHanhChinh"].Nodes.Add(ds3.Rows[i]["TenVungDiaLy"].ToString());
                DataTable ds4 = wf.DuLieuTinh(" where IDVungDiaLy=N'" + ds3.Rows[i]["IDVungDiaLy"].ToString() + "'");
                for (int j = 0; j < int.Parse(ds4.Rows.Count.ToString()); j++)
                {
                    treeView1.Nodes["nodediagioihanhchinh"].Nodes["nodecKhuVucDiaGioiHanhChinh"].Nodes[i].Nodes.Add(ds4.Rows[j]["TenTinh"].ToString());
       
                }
            }
        }


        string str = "";
        private void treeView1_AfterSelect_1(object sender, TreeViewEventArgs e)
        {
            bntSua.Enabled = false;
            bntXoa.Enabled = false;
             str= e.Node.Text;
            if (e.Node.Text == "Địa giới hành chính" || e.Node.Text == "Khu vực địa giới hành chính" || e.Node.Text == "Thành phố trực thuộc Trung ương")
            {
                if (cboTonGiao.Text == "" || cboTonGiao.Text == "Tất cả")
                {
                    gridCTinDo.DataSource = tindo.HienThiDSTinDo();
                }
                else
                {
                    string tongiao = cboTonGiao.Text;
                    string sqlString = "select PhapDanh, HoDemTheDanh, TenTheDanh, NgaySinh, TCTichCuc, TCNguyHiem, HDCaNhan, HDToChuc,NgayVaoTonGiao from  tblTinDo , tblCoSo, tblToChucQuanTri, tblTonGiao where tblTinDo.IDCoSo = tblCoSo.IDCoSo and tblCoSo.IDToChuc = tblToChucQuanTri.IDToChuc and tblToChucQuanTri.IDTonGiao = tblTonGiao.IDTonGiao and tblTonGiao.TenTonGiao = N'" + tongiao + "' and tbltinDo.daxoa=0";
                    gridCTinDo.DataSource = tindo.OneRecord("tblTinDo",sqlString);


                }
            }
            else
            {
                DataTable ds = wf.DuLieuTinh("where TenTinh=N'" + str + "'");
                if(ds.Rows.Count>0)
                {

                    if (cboTonGiao.Text == "" || cboTonGiao.Text == "Tất cả")
                    {
                        string tongiao = cboTonGiao.Text;
                        string sqlString = "select IdTinDo,PhapDanh, HoDemTheDanh, TenTheDanh, NgaySinh, TCTichCuc, TCNguyHiem, HDCaNhan, HDToChuc,NgayVaoTonGiao from  tblTinDo , tblCoSo, tblToChucQuanTri, tblTonGiao,tblTinh,tblHuyen,tblXa where tblTinDo.IDCoSo = tblCoSo.IDCoSo and tblCoSo.IDToChuc = tblToChucQuanTri.IDToChuc and tblToChucQuanTri.IDTonGiao = tblTonGiao.IDTonGiao  and tbltinDo.daxoa=0 and tblXa.IDXa=tblCoSo.DiaChi and tblHuyen.IDHuyen=tblXa.IDhuyen and tblTinh.IDTinh=tblHuyen.IDTinh and TenTinh=N'" + str+"'";
                        gridCTinDo.DataSource = tindo.OneRecord("tblTinDo", sqlString);
                    }
                    else
                    {
                        string tongiao = cboTonGiao.Text;
                        string sqlString = "select IdTinDo,PhapDanh, HoDemTheDanh, TenTheDanh, NgaySinh, TCTichCuc, TCNguyHiem, HDCaNhan, HDToChuc,NgayVaoTonGiao from  tblTinDo , tblCoSo, tblToChucQuanTri, tblTonGiao,tblTinh,tblHuyen,tblXa where tblTinDo.IDCoSo = tblCoSo.IDCoSo and tblCoSo.IDToChuc = tblToChucQuanTri.IDToChuc and tblToChucQuanTri.IDTonGiao = tblTonGiao.IDTonGiao and tblTonGiao.TenTonGiao = N'" + tongiao + "' and tbltinDo.daxoa=0 and tblXa.IDXa=tblCoSo.DiaChi and tblHuyen.IDHuyen=tblXa.IDhuyen and tblTinh.IDTinh=tblHuyen.IDTinh and TenTinh=N'" + str + "'";
                        gridCTinDo.DataSource = tindo.OneRecord("tblTinDo", sqlString);


                    }
                }
                else
                {
                    if (cboTonGiao.Text == "" || cboTonGiao.Text == "Tất cả")
                    {
                        string tongiao = cboTonGiao.Text;
                        string sqlString = "select IdTinDo,PhapDanh, HoDemTheDanh, TenTheDanh, NgaySinh, TCTichCuc, TCNguyHiem, HDCaNhan, HDToChuc,NgayVaoTonGiao from  tblTinDo , tblCoSo, tblToChucQuanTri, tblTonGiao,tblTinh,tblHuyen,tblXa,tblVungDiaLy where tblTinDo.IDCoSo = tblCoSo.IDCoSo and tblCoSo.IDToChuc = tblToChucQuanTri.IDToChuc and tblToChucQuanTri.IDTonGiao = tblTonGiao.IDTonGiao  and tbltinDo.daxoa=0 and tblXa.IDXa=tblCoSo.DiaChi and tblHuyen.IDHuyen=tblXa.IDhuyen and tblTinh.IDTinh=tblHuyen.IDTinh and tblVungDiaLy.IDVungDiaLy=tblTinh.IDVungDiaLy and TenVungDiaLy=N'" + str + "'";
                        gridCTinDo.DataSource = tindo.OneRecord("tblTinDo", sqlString);
                    }
                    else
                    {
                        string tongiao = cboTonGiao.Text;
                        string sqlString = "select IdTinDo,PhapDanh, HoDemTheDanh, TenTheDanh, NgaySinh, TCTichCuc, TCNguyHiem, HDCaNhan, HDToChuc,NgayVaoTonGiao from  tblTinDo , tblCoSo, tblToChucQuanTri, tblTonGiao,tblTinh,tblHuyen,tblXa,tblVungDiaLy where tblTinDo.IDCoSo = tblCoSo.IDCoSo and tblCoSo.IDToChuc = tblToChucQuanTri.IDToChuc and tblToChucQuanTri.IDTonGiao = tblTonGiao.IDTonGiao and tblTonGiao.TenTonGiao = N'" + tongiao + "' and tbltinDo.daxoa=0 and tblXa.IDXa=tblCoSo.DiaChi and tblHuyen.IDHuyen=tblXa.IDhuyen and tblTinh.IDTinh=tblHuyen.IDTinh and tblVungDiaLy.IDVungDiaLy=tblTinh.IDVungDiaLy and TenVungDiaLy=N'" + str + "'";
                        gridCTinDo.DataSource = tindo.OneRecord("tblTinDo", sqlString);


                    }
                }
            }
           

        }

        private void cboTonGiao_TextChanged(object sender, EventArgs e)
        {
            if (str == "Địa giới hành chính" || str == "Khu vực địa giới hành chính" || str == "Thành phố trực thuộc Trung ương"||str=="")
            {
                if (cboTonGiao.Text == "" || cboTonGiao.Text == "Tất cả")
                {
                    gridCTinDo.DataSource = tindo.HienThiDSTinDo();
                }
                else
                {
                    string tongiao = cboTonGiao.Text;
                    string sqlString = "select PhapDanh, HoDemTheDanh, TenTheDanh, NgaySinh, TCTichCuc, TCNguyHiem, HDCaNhan, HDToChuc,NgayVaoTonGiao from  tblTinDo , tblCoSo, tblToChucQuanTri, tblTonGiao where tblTinDo.IDCoSo = tblCoSo.IDCoSo and tblCoSo.IDToChuc = tblToChucQuanTri.IDToChuc and tblToChucQuanTri.IDTonGiao = tblTonGiao.IDTonGiao and tblTonGiao.TenTonGiao = N'" + tongiao + "' and tbltinDo.daxoa=0";
                    gridCTinDo.DataSource = tindo.OneRecord("tblTinDo", sqlString);


                }
            }
            else
            {
                DataTable ds = wf.DuLieuTinh("where TenTinh=N'" + str + "'");
                if (ds.Rows.Count > 0)
                {

                    if (cboTonGiao.Text == "" || cboTonGiao.Text == "Tất cả")
                    {
                        string tongiao = cboTonGiao.Text;
                        string sqlString = "select IdTinDo,PhapDanh, HoDemTheDanh, TenTheDanh, NgaySinh, TCTichCuc, TCNguyHiem, HDCaNhan, HDToChuc,NgayVaoTonGiao from  tblTinDo , tblCoSo, tblToChucQuanTri, tblTonGiao,tblTinh,tblHuyen,tblXa where tblTinDo.IDCoSo = tblCoSo.IDCoSo and tblCoSo.IDToChuc = tblToChucQuanTri.IDToChuc and tblToChucQuanTri.IDTonGiao = tblTonGiao.IDTonGiao  and tbltinDo.daxoa=0 and tblXa.IDXa=tblCoSo.DiaChi and tblHuyen.IDHuyen=tblXa.IDhuyen and tblTinh.IDTinh=tblHuyen.IDTinh and TenTinh=N'" + str + "'";
                        gridCTinDo.DataSource = tindo.OneRecord("tblTinDo", sqlString);
                    }
                    else
                    {
                        string tongiao = cboTonGiao.Text;
                        string sqlString = "select IdTinDo,PhapDanh, HoDemTheDanh, TenTheDanh, NgaySinh, TCTichCuc, TCNguyHiem, HDCaNhan, HDToChuc,NgayVaoTonGiao from  tblTinDo , tblCoSo, tblToChucQuanTri, tblTonGiao,tblTinh,tblHuyen,tblXa where tblTinDo.IDCoSo = tblCoSo.IDCoSo and tblCoSo.IDToChuc = tblToChucQuanTri.IDToChuc and tblToChucQuanTri.IDTonGiao = tblTonGiao.IDTonGiao and tblTonGiao.TenTonGiao = N'" + tongiao + "' and tbltinDo.daxoa=0 and tblXa.IDXa=tblCoSo.DiaChi and tblHuyen.IDHuyen=tblXa.IDhuyen and tblTinh.IDTinh=tblHuyen.IDTinh and TenTinh=N'" + str + "'";
                        gridCTinDo.DataSource = tindo.OneRecord("tblTinDo", sqlString);


                    }
                }
                else
                {
                    if (cboTonGiao.Text == "" || cboTonGiao.Text == "Tất cả")
                    {
                        string tongiao = cboTonGiao.Text;
                        string sqlString = "select IdTinDo,PhapDanh, HoDemTheDanh, TenTheDanh, NgaySinh, TCTichCuc, TCNguyHiem, HDCaNhan, HDToChuc,NgayVaoTonGiao from  tblTinDo , tblCoSo, tblToChucQuanTri, tblTonGiao,tblTinh,tblHuyen,tblXa,tblVungDiaLy where tblTinDo.IDCoSo = tblCoSo.IDCoSo and tblCoSo.IDToChuc = tblToChucQuanTri.IDToChuc and tblToChucQuanTri.IDTonGiao = tblTonGiao.IDTonGiao  and tbltinDo.daxoa=0 and tblXa.IDXa=tblCoSo.DiaChi and tblHuyen.IDHuyen=tblXa.IDhuyen and tblTinh.IDTinh=tblHuyen.IDTinh and tblVungDiaLy.IDVungDiaLy=tblTinh.IDVungDiaLy and TenVungDiaLy=N'" + str + "'";
                        gridCTinDo.DataSource = tindo.OneRecord("tblTinDo", sqlString);
                    }
                    else
                    {
                        string tongiao = cboTonGiao.Text;
                        string sqlString = "select IdTinDo,PhapDanh, HoDemTheDanh, TenTheDanh, NgaySinh, TCTichCuc, TCNguyHiem, HDCaNhan, HDToChuc,NgayVaoTonGiao from  tblTinDo , tblCoSo, tblToChucQuanTri, tblTonGiao,tblTinh,tblHuyen,tblXa,tblVungDiaLy where tblTinDo.IDCoSo = tblCoSo.IDCoSo and tblCoSo.IDToChuc = tblToChucQuanTri.IDToChuc and tblToChucQuanTri.IDTonGiao = tblTonGiao.IDTonGiao and tblTonGiao.TenTonGiao = N'" + tongiao + "' and tbltinDo.daxoa=0 and tblXa.IDXa=tblCoSo.DiaChi and tblHuyen.IDHuyen=tblXa.IDhuyen and tblTinh.IDTinh=tblHuyen.IDTinh and tblVungDiaLy.IDVungDiaLy=tblTinh.IDVungDiaLy and TenVungDiaLy=N'" + str + "'";
                        gridCTinDo.DataSource = tindo.OneRecord("tblTinDo", sqlString);


                    }
                }
            }
        }
    }
}