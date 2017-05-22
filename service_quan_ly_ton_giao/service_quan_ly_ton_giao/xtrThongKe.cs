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
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace service_quan_ly_ton_giao
{
    public partial class xtrThongKe : DevExpress.XtraEditors.XtraForm
    {
        int xacdinh = 0;//neu xac dinh =1 tuc la dang bam vao tinh no do
        string tree = "";
        tblCoSo.ServiceCoSoSoapClient wf = new tblCoSo.ServiceCoSoSoapClient();
        ServiceTonGiao.ServiceTonGiaoSoapClient wstongiao = new ServiceTonGiao.ServiceTonGiaoSoapClient();
        Map.ServiceMapSoapClient wsmap = new Map.ServiceMapSoapClient();
        public xtrThongKe()
        {
            InitializeComponent();
        }
        
        void HienThiLenBieuDo(string DieuKien)
        {
            DataTable ds = wsmap.HienThiTinDoTheoTonGiaoTheoTinh(DieuKien);
            if (ds.Rows.Count <= 0)//khi bam vao vung dia ly
            {
                ds = wsmap.HienThiTinDoTheoTonGiaoTheoKhuVuc(DieuKien);
            }
            chartTinDo.DataSource = ds;
            
            chartTinDo.Series[0].ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative;
            chartTinDo.Series[0].ArgumentDataMember = "TenTonGiao";
            chartTinDo.Series[0].ValueDataMembers[0] = "SLTinDo";
            gridTinDo.DataSource = ds;

            /*chartCoSo.DataSource = ds;
            chartCoSo.Series[0].ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative;
            chartCoSo.Series[0].ArgumentDataMember = "TenTonGiao";
            chartCoSo.Series[0].ValueDataMembers[0] = "SLCoSo";
            */
            chartCoSo.Series.Clear();
            DataTable dscosokhuvuc = wsmap.HienThiCoSoTheoTonGiaoTheoKhuVuc(DieuKien, "");
            if (dscosokhuvuc.Rows.Count<=0)
            {
                //DataTable dscosotinh = wsmap.HienThiCoSoTheoTonGiaoTheoTinh(DieuKien, "");
                DataTable dstongiao = wf.DuLieuTonGiao("");
                for (int i = dstongiao.Rows.Count-1; i >=0; i--)
                {
                    DataTable dscs = wsmap.HienThiCoSoTheoTonGiaoTheoTinh(DieuKien, dstongiao.Rows[i]["IDTonGiao"].ToString());
                    if (dscs.Rows.Count > 0)
                    {
                        
                        DevExpress.XtraCharts.Series series = new DevExpress.XtraCharts.Series(dstongiao.Rows[i]["TenTonGiao"].ToString(), DevExpress.XtraCharts.ViewType.StackedBar);
                        chartCoSo.Series.Add(series);

                        
                        series.DataSource = dscs;

                        series.ArgumentDataMember = "TenHuyen";
                        series.ValueScaleType = DevExpress.XtraCharts.ScaleType.Numerical;
                        series.ValueDataMembers.AddRange(new string[] { "SLCoSo" });
                        

                       
                    }

                }
                //tao cot trong grid co so
                GridColumn colId = new GridColumn();
                colId.FieldName =  "TenHuyen";
                colId.Caption = "Tên huyện";
                colId.VisibleIndex = 0;
                GridColumn colName = new GridColumn();
                colName.FieldName =  "SLCoSo";
                colName.Caption = "Số lượng cơ sở";
                colName.VisibleIndex = 1;
                //GridView gView = this.View;
                grvCoSo.Columns.Clear();
                grvCoSo.Columns.Add(colId);
                grvCoSo.Columns.Add(colName);
                DataTable dstongiao2 = wf.DuLieuTonGiao(" where TenTonGiao=N'" + cboTonGiao.Text + "'");
                grcCoSo.DataSource = wsmap.HienThiCoSoTheoTonGiaoTheoTinh(DieuKien, dstongiao2.Rows[0]["IDTonGiao"].ToString());
                xacdinh = 1;
            }
            else
            {
                DataTable dstongiao = wf.DuLieuTonGiao("");
                for (int i = dstongiao.Rows.Count - 1; i >= 0; i--)
                {
                    DataTable dscs = wsmap.HienThiCoSoTheoTonGiaoTheoKhuVuc(DieuKien, dstongiao.Rows[i]["IDTonGiao"].ToString());
                    if (dscs.Rows.Count > 0)
                    {

                        DevExpress.XtraCharts.Series series = new DevExpress.XtraCharts.Series(dstongiao.Rows[i]["TenTonGiao"].ToString(), DevExpress.XtraCharts.ViewType.StackedBar);
                        chartCoSo.Series.Add(series);

                        
                        series.DataSource = dscs;

                        series.ArgumentDataMember = "TenTinh";
                        series.ValueScaleType = DevExpress.XtraCharts.ScaleType.Numerical;
                        series.ValueDataMembers.AddRange(new string[] { "SLCoSo" });

                       
                    }

                }
                GridColumn colId = new GridColumn();
                colId.FieldName = "TenTinh";
                colId.Caption = "Tên Tỉnh";
                colId.VisibleIndex = 0;
                GridColumn colName = new GridColumn();
                colName.FieldName = "SLCoSo";
                colName.Caption = "Số lượng cơ sở";
                colName.VisibleIndex = 1;
                //GridView gView = this.View;
                grvCoSo.Columns.Clear();
                grvCoSo.Columns.Add(colId);
                grvCoSo.Columns.Add(colName);
                DataTable dstongiao2 = wf.DuLieuTonGiao(" where TenTonGiao=N'"+cboTonGiao.Text+"'");
                grcCoSo.DataSource = wsmap.HienThiCoSoTheoTonGiaoTheoKhuVuc(DieuKien, dstongiao2.Rows[0]["IDTonGiao"].ToString());
            }
            
        }
        void HienThi()
        {
            cboTonGiao.DataSource = wf.DuLieuTonGiao("");
            cboTonGiao.DisplayMember = "TenTonGiao";
            cboTonGiao.ValueMember = "IDTonGiao";
            //chartTinDo.DataSource = wstongiao.GetTable("select TenTonGiao,SoLuongTinDo from tblTonGiao", "tblTongiao");
            HienThiLenBieuDo("");

            //làm việc với treeview
            ///group các thành phố trực thuộc trung ương
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
            //do du lieu len combobox co so ton giao
            
        }
        private void xtrThongKe_Load(object sender, EventArgs e)
        {
            HienThi();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            tree = e.Node.Text;
            if ( e.Node.Text == "Địa giới hành chính" || e.Node.Text == "Khu vực địa giới hành chính" || e.Node.Text == "Thành phố trực thuộc Trung ương")
            {
                HienThiLenBieuDo("");
            }
            else
            {
                HienThiLenBieuDo(tree);
            }
            
        }

        private void cboTonGiao_TextChanged(object sender, EventArgs e)
        {
            DataTable dstongiao2 = wf.DuLieuTonGiao(" where TenTonGiao = N'" + cboTonGiao.Text + "'");
            
            if(dstongiao2.Rows.Count>0)
            {
                if(tree == "Địa giới hành chính" || tree == "Khu vực địa giới hành chính" || tree == "Thành phố trực thuộc Trung ương")
                {
                    tree = "";
                    if (xacdinh == 0)
                    {

                        grcCoSo.DataSource = wsmap.HienThiCoSoTheoTonGiaoTheoKhuVuc(tree, dstongiao2.Rows[0]["IDTonGiao"].ToString());
                    }
                }
                else
                {
                    if (xacdinh == 0)
                    {

                        grcCoSo.DataSource = wsmap.HienThiCoSoTheoTonGiaoTheoKhuVuc(tree, dstongiao2.Rows[0]["IDTonGiao"].ToString());
                    }
                    else
                    {

                        grcCoSo.DataSource = wsmap.HienThiCoSoTheoTonGiaoTheoTinh(tree, dstongiao2.Rows[0]["IDTonGiao"].ToString());
                    }
                }
                
            }
           
        }
    }
}