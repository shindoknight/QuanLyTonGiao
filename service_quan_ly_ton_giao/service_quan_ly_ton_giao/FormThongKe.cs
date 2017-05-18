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
    public partial class FormThongKe : Form
    {
        public FormThongKe()
        {
            InitializeComponent();
        }
        tblCoSo.ServiceCoSoSoapClient wf = new tblCoSo.ServiceCoSoSoapClient();
        ServiceTonGiao.ServiceTonGiaoSoapClient wstongiao = new ServiceTonGiao.ServiceTonGiaoSoapClient();
        private void FormThongKe_Load(object sender, EventArgs e)
        {
            
            chartTinDo.DataSource= wstongiao.GetTable("select TenTonGiao,SoLuongTinDo from tblTonGiao", "tblTongiao");
            chartTinDo.ChartAreas["ChartArea1"].AxisX.Title = "Toàn Quốc";
            chartTinDo.Series["Tín đồ"].XValueMember = "TenTonGiao";
            chartTinDo.Series["Tín đồ"].YValueMembers = "SoLuongTinDo";
            
            //làm việc với treeview
            ///group các thành phố trực thuộc trung ương

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

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string tree = e.Node.Text;
            DataTable dt= wstongiao.GetTable(@"select TenTonGiao, COUNT(d.IDTinDo) as SoLuongtindo from tblXa a, tblHuyen b, tblTinh c, tblTinDo d, tblTonGiao e, tblChucSac f where a.IDHuyen = b.IDHuyen and b.IDTinh = c.IDTinh  and d.DiaChi = a.IDXa and d.IDChucSac = f.IDChucSac and f.IDTonGiao = e.IDTonGiao and TenTinh = N'"+tree+"' group by TenTonGiao","tblTonGiao");
            
            if(dt.Rows.Count<=0)
            {
                dt = wstongiao.GetTable(@"select TenTonGiao, COUNT(d.IDTinDo) as SoLuongtindo from tblXa a, tblHuyen b, tblTinh c, tblTinDo d, tblTonGiao e, tblChucSac f,tblvungDialy s where a.IDHuyen = b.IDHuyen and b.IDTinh = c.IDTinh  and d.DiaChi = a.IDXa and d.IDChucSac = f.IDChucSac and f.IDTonGiao = e.IDTonGiao and c.IDVungDiaLy=s.IDVungDiaLy and TenVungDiaLy= N'" + tree + "' group by TenTonGiao", "tblTonGiao");
            }

            chartTinDo.DataSource = dt;
            chartTinDo.ChartAreas["ChartArea1"].AxisX.Title = "Tín đồ ở " + tree;
            chartTinDo.Series["Tín đồ"].XValueMember = "TenTonGiao";
            chartTinDo.Series["Tín đồ"].YValueMembers = "soluongtindo";
        }
    }
}
