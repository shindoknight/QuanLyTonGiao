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
using DevExpress.XtraMap;

namespace service_quan_ly_ton_giao
{
    public partial class frmMapCoSo : DevExpress.XtraEditors.XtraForm
    {
        string imageFilePath = @"../../icon/cstg";//2 duong link de lay icon in len map
        string imageFilePath2 = @"../../icon/tcqt";
        VectorItemsLayer VectorLayer { get { return (VectorItemsLayer)map.Layers["VectorLayer"]; } }
        MapItemStorage ItemStorage { get { return (MapItemStorage)VectorLayer.Data; } }
        tblCoSo.ServiceCoSoSoapClient wf = new tblCoSo.ServiceCoSoSoapClient();
        public frmMapCoSo()
        {
            InitializeComponent();
        }
        void HienThiToanBoCacCoSoSoTheoTinh()
        {
            map.CenterPoint = new GeoPoint(latitude: 21.04778, longitude: 105.8478);
            map.Zoom(12);
            ItemStorage.Items.Clear();
            DataTable ds = wf.HienThiDSCoSo("", " where a.DiaChi in (select IDXa from tblXa,tblHuyen,tblTinh where tblXa.IDHuyen=tblHuyen.IDHuyen and tblHuyen.IDTinh=tblTinh.IDTinh and TenTinh=N'"+txtTen.Text+"') ");
            txtSoLuong.Text = ds.Rows.Count.ToString();
            //DataTable ds2 = wf.HienThiDSCoSo("", " where a.TenTonGiao=N'" + ds.Rows[0]["TenTonGiao"].ToString() + "'");
            if (int.Parse(ds.Rows.Count.ToString())==0)
            {
                MessageBox.Show("Thành phố " + txtTen.Text + " không có cơ sở tôn giáo");
            }
            //xac dinh tam
            DataTable ds3 = wf.DuLieuTinh(" where TenTinh=N'" + txtTen.Text + "' ");
            DataTable ds4 = wf.DuLieuHuyen(" where IDTinh=N'"+ds3.Rows[0]["IDTinh"].ToString()+"'");
            DataTable ds5 = wf.DuLieuXa("where IDHuyen=N'" + ds4.Rows[0]["IDHuyen"].ToString() + "'");
            try
            {
                string ki = ds5.Rows[0]["ViDo"].ToString().Replace(".", ",");
                string vi = ds5.Rows[0]["KinhDo"].ToString().Replace(".", ",");

                map.CenterPoint = new GeoPoint(latitude: float.Parse(ki), longitude: float.Parse(vi));
                map.Zoom(12);
            }
            catch//trong truong hop không có tọa độ xã->lấy tọa độ của huyện
            {
                DataTable tv3 = wf.TimViTriTheoHuyen(" where IDHuyen=N'" + ds5.Rows[0]["IDHuyen"].ToString() + "'");
                string ki = tv3.Rows[0]["ViDo"].ToString().Replace(".", ",");
                string vi = tv3.Rows[0]["KinhDo"].ToString().Replace(".", ",");

                map.CenterPoint = new GeoPoint(latitude: float.Parse(ki), longitude: float.Parse(vi));
                //map.Zoom(5);
            }
            int i;
            for (i = 0; i < int.Parse(ds.Rows.Count.ToString()); i++)
            {

                //DataTable tv1 = wf.TimViTri(" where IDXa=N'" + ds.Rows[i]["DiaChi"].ToString() + "'");
                try
                {
                    string ki = ds.Rows[i]["ViDo"].ToString().Replace(".", ",");
                    string vi = ds.Rows[i]["KinhDo"].ToString().Replace(".", ",");
                    #region #MapCustomElementExample
                    var customElement = new MapCustomElement() { Location = new GeoPoint(float.Parse(ki), float.Parse(vi)), Text = "" + ds.Rows[i]["TenCoSo"].ToString() + "-Địa chỉ: " + ds.Rows[i]["TenXa"].ToString() };
                    var image = new Bitmap(imageFilePath + ds.Rows[i]["IDTonGiao"].ToString() + ".png");
                    customElement.Image = new Bitmap(image, new Size(40, 40));
                    ItemStorage.Items.Add(customElement);
                    #endregion #MapCustomElementExample

                }
                catch//trong truong hop không có tọa độ xã->lấy tọa độ của huyện
                {
                    MessageBox.Show("Xảy ra lỗi");
                }

            }
        }
        
        
        void HienThi()
        {
            //do du lieu len cac combobox
            cboTonGiao.DataSource = wf.TruyVanTenTonGiao("");
            cboTonGiao.DisplayMember = "TenTonGiao";
            cboTinh.DataSource = wf.DuLieuTinh("");
            cboTinh.DisplayMember = "TenTinh";
            //làm việc với treeview
            ///group các thành phố trực thuộc trung ương
            DataTable ds1 = wf.DuLieuTinh(" where Loai=N'Thành phố'");
            for (int i = 0; i < int.Parse(ds1.Rows.Count.ToString()); i++)
            {
                treeView1.Nodes["nodediagioihanhchinh"].Nodes["nodecThanhPhoTU"].Nodes.Add(ds1.Rows[i]["TenTinh"].ToString());
            }
            //group ton giáo
            /*DataTable ds2 = wf.DuLieuTonGiao("");
            for (int i = 0; i < int.Parse(ds2.Rows.Count.ToString()); i++)
            {
                treeView1.Nodes["nodeTonGiao"].Nodes.Add(ds2.Rows[i]["TenTonGiao"].ToString());

            }*/
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
            //hien thi len map cac co so ton giao thuoc ha noi
            HienThiToanBoCacCoSoSoTheoTinh();
        }
        private void frmMapCoSo_Load(object sender, EventArgs e)
        {
            HienThi();
        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {
            //HienThiToanBoCacCoSoSoTheoTinh();
        }

        private void txtTen_Click(object sender, EventArgs e)
        {
            //HienThiToanBoCacCoSoSoTheoTinh();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Text == "Địa giới hành chính" || e.Node.Text == "Thành phố trực thuộc Trung ương" || e.Node.Text == "Khu vực địa giới hành chính")
            {
                DataTable ds = wf.HienThiDSCoSo("", "");
                txtSoLuong.Text = ds.Rows.Count.ToString();
                ItemStorage.Items.Clear();
                txtTen.Text = "Cả nước";
                int i;
                for (i = 0; i < int.Parse(ds.Rows.Count.ToString()); i++)
                {

                    //DataTable tv1 = wf.TimViTri(" where IDXa=N'" + ds.Rows[i]["DiaChi"].ToString() + "'");
                    try
                    {
                        string ki = ds.Rows[0]["ViDo"].ToString().Replace(".", ",");
                        string vi = ds.Rows[0]["KinhDo"].ToString().Replace(".", ",");
                        #region #MapCustomElementExample
                        var customElement = new MapCustomElement() { Location = new GeoPoint(float.Parse(ki), float.Parse(vi)), Text = "" + ds.Rows[i]["TenCoSo"].ToString() + "-Địa chỉ: " + ds.Rows[i]["TenXa"].ToString() };
                        var image = new Bitmap(imageFilePath + ds.Rows[i]["IDTonGiao"].ToString() + ".png");
                        customElement.Image = new Bitmap(image, new Size(40, 40));
                        ItemStorage.Items.Add(customElement);
                        #endregion #MapCustomElementExample
                    }
                    catch//trong truong hop không có tọa độ xã->lấy tọa độ của huyện
                    {
                        MessageBox.Show("Xảy ra lỗi");
                    }

                }
                map.CenterPoint = new GeoPoint(latitude: 15.46056, longitude: 107.7433);
                map.Zoom(5);

            }
            //click vÀo các tên tỉnh 
            DataTable ds1 = wf.DuLieuTinh(" where TenTinh=N'" + e.Node.Text + "'");
            
            if (int.Parse(ds1.Rows.Count.ToString()) == 1)
            {
                ItemStorage.Items.Clear();
                txtTen.Text = e.Node.Text;
                HienThiToanBoCacCoSoSoTheoTinh();
                
            }
            //click vao khu vuc
            DataTable ds2 = wf.DuLieuVung(" where TenVungDiaLy=N'"+ e.Node.Text + "'");
            if(int.Parse(ds2.Rows.Count.ToString())==1)
            {
                DataTable ds3 = wf.DuLieuTinh(" where IDVungDiaLy=N'" + ds2.Rows[0]["IDVungDiaLy"].ToString() + "' ");
                int tam = int.Parse(ds3.Rows.Count.ToString()) / 2;
                DataTable ds4 = wf.DuLieuHuyen(" where IDTinh=N'" + ds3.Rows[tam]["IDTinh"].ToString() + "'");
                DataTable ds5 = wf.DuLieuXa("where IDHuyen=N'" + ds4.Rows[0]["IDHuyen"].ToString() + "'");
                try
                {
                    string ki = ds5.Rows[0]["ViDo"].ToString().Replace(".", ",");
                    string vi = ds5.Rows[0]["KinhDo"].ToString().Replace(".", ",");

                    map.CenterPoint = new GeoPoint(latitude: float.Parse(ki), longitude: float.Parse(vi));
                    map.Zoom(7);
                }
                catch//trong truong hop không có tọa độ xã->lấy tọa độ của huyện
                {
                    DataTable tv3 = wf.TimViTriTheoHuyen(" where IDHuyen=N'" + ds5.Rows[tam]["IDHuyen"].ToString() + "'");
                    string ki = tv3.Rows[0]["ViDo"].ToString().Replace(".", ",");
                    string vi = tv3.Rows[0]["KinhDo"].ToString().Replace(".", ",");

                    map.CenterPoint = new GeoPoint(latitude: float.Parse(ki), longitude: float.Parse(vi));
                    map.Zoom(7);
                }
                //hien thi toan bo cs ton giao len map theo vung
                txtTen.Text = e.Node.Text;
                if (int.Parse(ds2.Rows.Count.ToString()) == 1)
                {
                    DataTable ds = wf.HienThiDSCoSo("", " where a.DiaChi in (select IDXa from tblXa,tblHuyen,tblTinh,tblVungDiaLy where tblXa.IDHuyen=tblHuyen.IDHuyen and tblHuyen.IDTinh=tblTinh.IDTinh and tblVungDiaLy.IDVungDiaLy=tblTinh.IDVungDiaLy and TenVungDiaLy=N'" + txtTen.Text + "') ");
                    ItemStorage.Items.Clear();
                    txtTen.Text = e.Node.Text;
                    int i;
                    for (i = 0; i < int.Parse(ds.Rows.Count.ToString()); i++)
                    {

                        //DataTable tv1 = wf.TimViTri(" where IDXa=N'" + ds.Rows[i]["DiaChi"].ToString() + "'");
                        try
                        {
                            string ki = ds.Rows[i]["ViDo"].ToString().Replace(".", ",");
                            string vi = ds.Rows[i]["KinhDo"].ToString().Replace(".", ",");
                            #region #MapCustomElementExample
                            var customElement = new MapCustomElement() { Location = new GeoPoint(float.Parse(ki), float.Parse(vi)), Text = "" + ds.Rows[i]["TenCoSo"].ToString() + "-Địa chỉ: " + ds.Rows[i]["TenXa"].ToString() };
                            var image = new Bitmap(imageFilePath + ds.Rows[i]["IDTonGiao"].ToString() + ".png");
                            customElement.Image = new Bitmap(image, new Size(40, 40));
                            ItemStorage.Items.Add(customElement);
                            #endregion #MapCustomElementExample
                        }
                        catch//trong truong hop không có tọa độ xã->lấy tọa độ của huyện
                        {
                            MessageBox.Show("Xảy ra lỗi");
                        }

                    }
                    
                }
            }
        }

        private void btnTimKiemNhanh_Click(object sender, EventArgs e)
        {
            DataTable ds = wf.HienThiDSCoSo("", " where a.TenCoSo like N'%"+txtTenCoSoTG.Text+"%'");
            txtSoLuong.Text = ds.Rows.Count.ToString();
            ItemStorage.Items.Clear();
            if(int.Parse(ds.Rows.Count.ToString())==1)
            {
                //DataTable tv1 = wf.TimViTri(" where IDXa=N'" + ds.Rows[0]["DiaChi"].ToString() + "'");
                try
                {
                    string ki = ds.Rows[0]["ViDo"].ToString().Replace(".", ",");
                    string vi = ds.Rows[0]["KinhDo"].ToString().Replace(".", ",");
                    #region #MapCustomElementExample
                    var customElement = new MapCustomElement() { Location = new GeoPoint(float.Parse(ki), float.Parse(vi)), Text = "" + ds.Rows[0]["TenCoSo"].ToString() + "-Địa chỉ: " + ds.Rows[0]["TenXa"].ToString() };
                    var image = new Bitmap(imageFilePath + ds.Rows[0]["IDTonGiao"].ToString() + ".png");
                    customElement.Image = new Bitmap(image, new Size(40, 40));
                    ItemStorage.Items.Add(customElement);
                    #endregion #MapCustomElementExample
                    map.CenterPoint = new GeoPoint(latitude: float.Parse(ki), longitude: float.Parse(vi));
                    map.Zoom(15);
                }
                catch//trong truong hop không có tọa độ xã->lấy tọa độ của huyện
                {
                    MessageBox.Show("Xảy ra lỗi");
                }
            }
            else
            {
                int i;
                for (i = 0; i < int.Parse(ds.Rows.Count.ToString()); i++)
                {

                    //DataTable tv1 = wf.TimViTri(" where IDXa=N'" + ds.Rows[i]["DiaChi"].ToString() + "'");
                    try
                    {
                        string ki = ds.Rows[i]["ViDo"].ToString().Replace(".", ",");
                        string vi = ds.Rows[i]["KinhDo"].ToString().Replace(".", ",");
                        #region #MapCustomElementExample
                        var customElement = new MapCustomElement() { Location = new GeoPoint(float.Parse(ki), float.Parse(vi)), Text = "" + ds.Rows[i]["TenCoSo"].ToString() + "-Địa chỉ: " + ds.Rows[i]["TenXa"].ToString() };
                        var image = new Bitmap(imageFilePath + ds.Rows[0]["IDTonGiao"].ToString() + ".png");
                        customElement.Image = new Bitmap(image, new Size(40, 40));
                        ItemStorage.Items.Add(customElement);
                        #endregion #MapCustomElementExample
                    }
                    catch//trong truong hop không có tọa độ xã->lấy tọa độ của huyện
                    {
                        MessageBox.Show("Xảy ra lỗi");
                    }

                }
                map.CenterPoint = new GeoPoint(latitude: 15.46056, longitude: 107.7433);
                map.Zoom(5);
            }
            
        }

        private void cboTinh_TextChanged(object sender, EventArgs e)
        {
            cboHuyen.DataSource = wf.TruyVanTenHuyen(cboTinh.Text);
            cboHuyen.DisplayMember = "TenHuyen";
        }

        private void cboHuyen_TextChanged(object sender, EventArgs e)
        {
            cboXa.DataSource = wf.TruyVanTenXa(cboHuyen.Text);
            cboXa.DisplayMember = "TenXa";
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
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

        private void btnTimKiemCt_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable ds = wf.HienThiDSCoSo(""," where a.DiaChi in (select IDXa from tblXa ,tblHuyen,tblTinh where tblXa.IDHuyen=tblHuyen.IDHuyen and tblHuyen.IDTinh=tblTinh.IDTinh and TenXa=N'" + cboXa.Text + "' and TenHuyen=N'" + cboHuyen.Text + "' and TenTinh=N'" + cboTinh.Text + "') and a.TenToChuc=N'"+ cboTenToChucQuanTri.Text+"'");
                txtSoLuong.Text = ds.Rows.Count.ToString();
                DataTable xa = wf.DuLieuXa(" ,tblHuyen,tblTinh where tblXa.IDHuyen=tblHuyen.IDHuyen and tblHuyen.IDTinh=tblTinh.IDTinh and TenXa=N'" + cboXa.Text + "' and TenHuyen=N'" + cboHuyen.Text + "' and TenTinh=N'" + cboTinh.Text + "'");
                ItemStorage.Items.Clear();
                string ki1 = xa.Rows[0]["ViDo"].ToString().Replace(".", ",");
                string vi1 = xa.Rows[0]["KinhDo"].ToString().Replace(".", ",");
                map.CenterPoint = new GeoPoint(latitude: (float.Parse(ki1)), longitude: (float.Parse(vi1)));
                for(int i=0;i<ds.Rows.Count;i++)
                {
                    #region #MapCustomElementExample
                    var customElement = new MapCustomElement() { Location = new GeoPoint(float.Parse(ki1), float.Parse(vi1)), Text = ds.Rows[i]["TenCoSo"].ToString() + "- Địa chỉ: " + ds.Rows[i]["TenXa"].ToString() };
                    var image = new Bitmap(imageFilePath + ds.Rows[i]["IDTonGiao"].ToString() + ".png");
                    customElement.Image = new Bitmap(image, new Size(40, 40));
                    ItemStorage.Items.Add(customElement);
                    #endregion #MapCustomElementExample*/
                    map.Zoom(15);
                }
                
            }
            catch
            {
                MessageBox.Show("Không có dữ liệu về cơ sở tôn giáo tại "+cboXa.Text );
                try
                {
                    DataTable ds = wf.DuLieuXa(" ,tblHuyen,tblTinh where tblXa.IDHuyen=tblHuyen.IDHuyen and tblHuyen.IDTinh=tblTinh.IDTinh and TenXa=N'" + cboXa.Text + "' and TenHuyen=N'" + cboHuyen.Text + "' and TenTinh=N'" + cboTinh.Text + "'");
                    DataTable ds2 = wf.DuLieuTonGiao(" where TenTonGiao=N'"+cboTonGiao.Text+"'");
                    string ki1 = ds.Rows[0]["ViDo"].ToString().Replace(".", ",");
                    string vi1 = ds.Rows[0]["KinhDo"].ToString().Replace(".", ",");
                    map.CenterPoint = new GeoPoint(latitude: (float.Parse(ki1)), longitude: (float.Parse(vi1)));
                    
                }
                catch
                {
                    MessageBox.Show("Không thể hiển thị tôn giáo do chưa có icon tôn giáo");
                }
                
            }
        }

        private void cboTonGiao_TextChanged(object sender, EventArgs e)
        {
            cboTenToChucQuanTri.DataSource = wf.DuLieuToChucQuanTri(" where IDTonGiao=(select IDTonGiao from tblTonGiao where TenTonGiao=N'" + cboTonGiao.Text + "')");
            cboTenToChucQuanTri.DisplayMember = "TenToChuc";
        }

        private void btnPhatGiao_Click(object sender, EventArgs e)
        {
            //click vÀo các tên tỉnh 
            if (txtTen.Text == "Địa giới hành chính" || txtTen.Text == "Thành phố trực thuộc Trung ương" || txtTen.Text == "Khu vực địa giới hành chính"|| txtTen.Text == ""|| txtTen.Text == "Cả nước")
            {
                DataTable ds = wf.HienThiDSCoSo("", " where a.IDTonGiao=1");
                txtSoLuong.Text = ds.Rows.Count.ToString();
                ItemStorage.Items.Clear();
                txtTen.Text = "Cả nước";
                int i;
                for (i = 0; i < int.Parse(ds.Rows.Count.ToString()); i++)
                {

                    //DataTable tv1 = wf.TimViTri(" where IDXa=N'" + ds.Rows[i]["DiaChi"].ToString() + "'");
                    try
                    {
                        string ki = ds.Rows[i]["ViDo"].ToString().Replace(".", ",");
                        string vi = ds.Rows[i]["KinhDo"].ToString().Replace(".", ",");
                        #region #MapCustomElementExample
                        var customElement = new MapCustomElement() { Location = new GeoPoint(float.Parse(ki), float.Parse(vi)), Text = "" + ds.Rows[i]["TenCoSo"].ToString() + "-Địa chỉ: " + ds.Rows[i]["TenXa"].ToString() };
                        var image = new Bitmap(imageFilePath + ds.Rows[i]["IDTonGiao"].ToString() + ".png");
                        customElement.Image = new Bitmap(image, new Size(40, 40));
                        ItemStorage.Items.Add(customElement);
                        #endregion #MapCustomElementExample
                    }
                    catch//trong truong hop không có tọa độ xã->lấy tọa độ của huyện
                    {
                        MessageBox.Show("Có lỗi xảy ra");
                    }

                }
                map.CenterPoint = new GeoPoint(latitude: 15.46056, longitude: 107.7433);
                map.Zoom(5);

            }
            DataTable ds1 = wf.DuLieuTinh(" where TenTinh=N'" + txtTen.Text + "'");
            if (int.Parse(ds1.Rows.Count.ToString()) == 1)
            {
                map.CenterPoint = new GeoPoint(latitude: 21.04778, longitude: 105.8478);
                map.Zoom(12);
                ItemStorage.Items.Clear();
                DataTable ds = wf.HienThiDSCoSo("", " where a.DiaChi in (select IDXa from tblXa,tblHuyen,tblTinh where tblXa.IDHuyen=tblHuyen.IDHuyen and tblHuyen.IDTinh=tblTinh.IDTinh and TenTinh=N'" + txtTen.Text + "') and a.IDTonGiao=1");
                txtSoLuong.Text = ds.Rows.Count.ToString();
                //DataTable ds2 = wf.HienThiDSCoSo("", " where a.TenTonGiao=N'" + ds.Rows[0]["TenTonGiao"].ToString() + "'");
                if (int.Parse(ds.Rows.Count.ToString()) == 0)
                {
                    MessageBox.Show("Thành phố " + txtTen.Text + " không có cơ sở tôn giáo");
                }
                //xac dinh tam
                DataTable ds3 = wf.DuLieuTinh(" where TenTinh=N'" + txtTen.Text + "' ");
                DataTable ds4 = wf.DuLieuHuyen(" where IDTinh=N'" + ds3.Rows[0]["IDTinh"].ToString() + "'");
                DataTable ds5 = wf.DuLieuXa("where IDHuyen=N'" + ds4.Rows[0]["IDHuyen"].ToString() + "'");
                try
                {
                    string ki = ds5.Rows[0]["ViDo"].ToString().Replace(".", ",");
                    string vi = ds5.Rows[0]["KinhDo"].ToString().Replace(".", ",");

                    map.CenterPoint = new GeoPoint(latitude: float.Parse(ki), longitude: float.Parse(vi));
                    map.Zoom(12);
                }
                catch//trong truong hop không có tọa độ xã->lấy tọa độ của huyện
                {
                    DataTable tv3 = wf.TimViTriTheoHuyen(" where IDHuyen=N'" + ds5.Rows[0]["IDHuyen"].ToString() + "'");
                    string ki = tv3.Rows[0]["ViDo"].ToString().Replace(".", ",");
                    string vi = tv3.Rows[0]["KinhDo"].ToString().Replace(".", ",");

                    map.CenterPoint = new GeoPoint(latitude: float.Parse(ki), longitude: float.Parse(vi));
                    //map.Zoom(5);
                }
                int i;
                for (i = 0; i < int.Parse(ds.Rows.Count.ToString()); i++)
                {

                    //DataTable tv1 = wf.TimViTri(" where IDXa=N'" + ds.Rows[i]["DiaChi"].ToString() + "'");
                    try
                    {
                        string ki = ds.Rows[i]["ViDo"].ToString().Replace(".", ",");
                        string vi = ds.Rows[i]["KinhDo"].ToString().Replace(".", ",");
                        #region #MapCustomElementExample
                        var customElement = new MapCustomElement() { Location = new GeoPoint(float.Parse(ki), float.Parse(vi)), Text = "" + ds.Rows[i]["TenCoSo"].ToString() + "-Địa chỉ: " + ds.Rows[i]["TenXa"].ToString() };
                        var image = new Bitmap(imageFilePath + ds.Rows[i]["IDTonGiao"].ToString() + ".png");
                        customElement.Image = new Bitmap(image, new Size(40, 40));
                        ItemStorage.Items.Add(customElement);
                        #endregion #MapCustomElementExample

                    }
                    catch//trong truong hop không có tọa độ xã->lấy tọa độ của huyện
                    {
                        MessageBox.Show("Có lỗi xảy ra");
                    }

                }

            }
            //click vao khu vuc
            DataTable ds2 = wf.DuLieuVung(" where TenVungDiaLy=N'" + txtTen.Text + "'");
            if (int.Parse(ds2.Rows.Count.ToString()) == 1)
            {
                DataTable ds3 = wf.DuLieuTinh(" where IDVungDiaLy=N'" + ds2.Rows[0]["IDVungDiaLy"].ToString() + "' ");
                int tam = int.Parse(ds3.Rows.Count.ToString()) / 2;
                DataTable ds4 = wf.DuLieuHuyen(" where IDTinh=N'" + ds3.Rows[tam]["IDTinh"].ToString() + "'");
                DataTable ds5 = wf.DuLieuXa("where IDHuyen=N'" + ds4.Rows[0]["IDHuyen"].ToString() + "'");
                try
                {
                    string ki = ds5.Rows[0]["ViDo"].ToString().Replace(".", ",");
                    string vi = ds5.Rows[0]["KinhDo"].ToString().Replace(".", ",");

                    map.CenterPoint = new GeoPoint(latitude: float.Parse(ki), longitude: float.Parse(vi));
                    map.Zoom(7);
                }
                catch//trong truong hop không có tọa độ xã->lấy tọa độ của huyện
                {
                    DataTable tv3 = wf.TimViTriTheoHuyen(" where IDHuyen=N'" + ds5.Rows[tam]["IDHuyen"].ToString() + "'");
                    string ki = tv3.Rows[0]["ViDo"].ToString().Replace(".", ",");
                    string vi = tv3.Rows[0]["KinhDo"].ToString().Replace(".", ",");

                    map.CenterPoint = new GeoPoint(latitude: float.Parse(ki), longitude: float.Parse(vi));
                    map.Zoom(7);
                }
                //hien thi toan bo cs ton giao len map theo vung
                //txtTen.Text = e.Node.Text;
                if (int.Parse(ds2.Rows.Count.ToString()) == 1)
                {
                    DataTable ds = wf.HienThiDSCoSo("", " where a.DiaChi in (select IDXa from tblXa,tblHuyen,tblTinh,tblVungDiaLy where tblXa.IDHuyen=tblHuyen.IDHuyen and tblHuyen.IDTinh=tblTinh.IDTinh and tblVungDiaLy.IDVungDiaLy=tblTinh.IDVungDiaLy and TenVungDiaLy=N'" + txtTen.Text + "') and a.IDTonGiao=1");
                    txtSoLuong.Text = ds.Rows.Count.ToString();
                    ItemStorage.Items.Clear();
                    //txtTen.Text = e.Node.Text;
                    int i;
                    for (i = 0; i < int.Parse(ds.Rows.Count.ToString()); i++)
                    {

                        //DataTable tv1 = wf.TimViTri(" where IDXa=N'" + ds.Rows[i]["DiaChi"].ToString() + "'");
                        try
                        {
                            string ki = ds.Rows[i]["ViDo"].ToString().Replace(".", ",");
                            string vi = ds.Rows[i]["KinhDo"].ToString().Replace(".", ",");
                            #region #MapCustomElementExample
                            var customElement = new MapCustomElement() { Location = new GeoPoint(float.Parse(ki), float.Parse(vi)), Text = "" + ds.Rows[i]["TenCoSo"].ToString() + "-Địa chỉ: " + ds.Rows[i]["TenXa"].ToString() };
                            var image = new Bitmap(imageFilePath + ds.Rows[0]["IDTonGiao"].ToString() + ".png");
                            customElement.Image = new Bitmap(image, new Size(40, 40));
                            ItemStorage.Items.Add(customElement);
                            #endregion #MapCustomElementExample
                        }
                        catch//trong truong hop không có tọa độ xã->lấy tọa độ của huyện
                        {
                            MessageBox.Show("Có lỗi xảy ra");
                        }

                    }

                }
            }

        }

        private void map_MapItemClick(object sender, MapItemClickEventArgs e)
        {
            string x = map.CenterPoint.GetX().ToString();
            string y = map.CenterPoint.GetY().ToString();
            //chi lấy 3 số sau . để so sánh tọa đọ lấy được với tọa độ trong csdl
            string[] x1 = x.Split(',');
            x1[1] = x1[1].Substring(0, 3);
            x = x1[0] + "." + x1[1];
            //textBox2.Text = x;
            string[] y1 = y.Split(',');
            y1[1] = y1[1].Substring(0, 3);
            y = y1[0] + "." + y1[1];
            //textBox3.Text = y;
            //x:kinh do ,y:vi do:sau khi lay duoc thi tim ID Xa ->IDCoS0
            DataTable ds = wf.HienThiDSCoSo(",a.GioiThieu", " where a.ViDo like N'%" + y + "%' and a.KinhDo like N'%" + x + "%'");
            if (int.Parse(ds.Rows.Count.ToString()) == 1)
            {
                frmChiTietCoSoTonGiao frm = new frmChiTietCoSoTonGiao();
                frm.txtIDCoSo.Text = ds.Rows[0]["IDCoSo"].ToString();
                frm.Show();
            }
        }

        private void btnConggiao_Click(object sender, EventArgs e)
        {
            //click vÀo các tên tỉnh 
            if (txtTen.Text == "Địa giới hành chính" || txtTen.Text == "Thành phố trực thuộc Trung ương" || txtTen.Text == "Khu vực địa giới hành chính" || txtTen.Text == "" || txtTen.Text == "Cả nước")
            {
                DataTable ds = wf.HienThiDSCoSo("", " where a.IDTonGiao=2");
                txtSoLuong.Text = ds.Rows.Count.ToString();
                ItemStorage.Items.Clear();
                txtTen.Text = "Cả nước";
                int i;
                for (i = 0; i < int.Parse(ds.Rows.Count.ToString()); i++)
                {

                    //DataTable tv1 = wf.TimViTri(" where IDXa=N'" + ds.Rows[i]["DiaChi"].ToString() + "'");
                    try
                    {
                        string ki = ds.Rows[i]["ViDo"].ToString().Replace(".", ",");
                        string vi = ds.Rows[i]["KinhDo"].ToString().Replace(".", ",");
                        #region #MapCustomElementExample
                        var customElement = new MapCustomElement() { Location = new GeoPoint(float.Parse(ki), float.Parse(vi)), Text = "" + ds.Rows[i]["TenCoSo"].ToString() + "-Địa chỉ: " + ds.Rows[i]["TenXa"].ToString() };
                        var image = new Bitmap(imageFilePath + ds.Rows[i]["IDTonGiao"].ToString() + ".png");
                        customElement.Image = new Bitmap(image, new Size(40, 40));
                        ItemStorage.Items.Add(customElement);
                        #endregion #MapCustomElementExample
                    }
                    catch//trong truong hop không có tọa độ xã->lấy tọa độ của huyện
                    {
                        MessageBox.Show("Có lỗi xảy ra");
                    }

                }
                map.CenterPoint = new GeoPoint(latitude: 15.46056, longitude: 107.7433);
                map.Zoom(5);

            }
            DataTable ds1 = wf.DuLieuTinh(" where TenTinh=N'" + txtTen.Text + "'");
            if (int.Parse(ds1.Rows.Count.ToString()) == 1)
            {
                map.CenterPoint = new GeoPoint(latitude: 21.04778, longitude: 105.8478);
                map.Zoom(12);
                ItemStorage.Items.Clear();
                DataTable ds = wf.HienThiDSCoSo("", " where a.DiaChi in (select IDXa from tblXa,tblHuyen,tblTinh where tblXa.IDHuyen=tblHuyen.IDHuyen and tblHuyen.IDTinh=tblTinh.IDTinh and TenTinh=N'" + txtTen.Text + "') and a.IDTonGiao=2");
                txtSoLuong.Text = ds.Rows.Count.ToString();
                //DataTable ds2 = wf.HienThiDSCoSo("", " where a.TenTonGiao=N'" + ds.Rows[0]["TenTonGiao"].ToString() + "'");
                if (int.Parse(ds.Rows.Count.ToString()) == 0)
                {
                    MessageBox.Show("Thành phố " + txtTen.Text + " không có cơ sở tôn giáo");
                }
                //xac dinh tam
                DataTable ds3 = wf.DuLieuTinh(" where TenTinh=N'" + txtTen.Text + "' ");
                DataTable ds4 = wf.DuLieuHuyen(" where IDTinh=N'" + ds3.Rows[0]["IDTinh"].ToString() + "'");
                DataTable ds5 = wf.DuLieuXa("where IDHuyen=N'" + ds4.Rows[0]["IDHuyen"].ToString() + "'");
                try
                {
                    string ki = ds5.Rows[0]["ViDo"].ToString().Replace(".", ",");
                    string vi = ds5.Rows[0]["KinhDo"].ToString().Replace(".", ",");

                    map.CenterPoint = new GeoPoint(latitude: float.Parse(ki), longitude: float.Parse(vi));
                    map.Zoom(12);
                }
                catch//trong truong hop không có tọa độ xã->lấy tọa độ của huyện
                {
                    DataTable tv3 = wf.TimViTriTheoHuyen(" where IDHuyen=N'" + ds5.Rows[0]["IDHuyen"].ToString() + "'");
                    string ki = tv3.Rows[0]["ViDo"].ToString().Replace(".", ",");
                    string vi = tv3.Rows[0]["KinhDo"].ToString().Replace(".", ",");

                    map.CenterPoint = new GeoPoint(latitude: float.Parse(ki), longitude: float.Parse(vi));
                    //map.Zoom(5);
                }
                int i;
                for (i = 0; i < int.Parse(ds.Rows.Count.ToString()); i++)
                {

                    //DataTable tv1 = wf.TimViTri(" where IDXa=N'" + ds.Rows[i]["DiaChi"].ToString() + "'");
                    try
                    {
                        string ki = ds.Rows[i]["ViDo"].ToString().Replace(".", ",");
                        string vi = ds.Rows[i]["KinhDo"].ToString().Replace(".", ",");
                        #region #MapCustomElementExample
                        var customElement = new MapCustomElement() { Location = new GeoPoint(float.Parse(ki), float.Parse(vi)), Text = "" + ds.Rows[i]["TenCoSo"].ToString() + "-Địa chỉ: " + ds.Rows[i]["TenXa"].ToString() };
                        var image = new Bitmap(imageFilePath + ds.Rows[i]["IDTonGiao"].ToString() + ".png");
                        customElement.Image = new Bitmap(image, new Size(40, 40));
                        ItemStorage.Items.Add(customElement);
                        #endregion #MapCustomElementExample

                    }
                    catch//trong truong hop không có tọa độ xã->lấy tọa độ của huyện
                    {
                        MessageBox.Show("Có lỗi xảy ra");
                    }

                }

            }
            //click vao khu vuc
            DataTable ds2 = wf.DuLieuVung(" where TenVungDiaLy=N'" + txtTen.Text + "'");
            if (int.Parse(ds2.Rows.Count.ToString()) == 1)
            {
                DataTable ds3 = wf.DuLieuTinh(" where IDVungDiaLy=N'" + ds2.Rows[0]["IDVungDiaLy"].ToString() + "' ");
                int tam = int.Parse(ds3.Rows.Count.ToString()) / 2;
                DataTable ds4 = wf.DuLieuHuyen(" where IDTinh=N'" + ds3.Rows[tam]["IDTinh"].ToString() + "'");
                DataTable ds5 = wf.DuLieuXa("where IDHuyen=N'" + ds4.Rows[0]["IDHuyen"].ToString() + "'");
                try
                {
                    string ki = ds5.Rows[0]["ViDo"].ToString().Replace(".", ",");
                    string vi = ds5.Rows[0]["KinhDo"].ToString().Replace(".", ",");

                    map.CenterPoint = new GeoPoint(latitude: float.Parse(ki), longitude: float.Parse(vi));
                    map.Zoom(7);
                }
                catch//trong truong hop không có tọa độ xã->lấy tọa độ của huyện
                {
                    DataTable tv3 = wf.TimViTriTheoHuyen(" where IDHuyen=N'" + ds5.Rows[tam]["IDHuyen"].ToString() + "'");
                    string ki = tv3.Rows[0]["ViDo"].ToString().Replace(".", ",");
                    string vi = tv3.Rows[0]["KinhDo"].ToString().Replace(".", ",");

                    map.CenterPoint = new GeoPoint(latitude: float.Parse(ki), longitude: float.Parse(vi));
                    map.Zoom(7);
                }
                //hien thi toan bo cs ton giao len map theo vung
                //txtTen.Text = e.Node.Text;
                if (int.Parse(ds2.Rows.Count.ToString()) == 1)
                {
                    DataTable ds = wf.HienThiDSCoSo("", " where a.DiaChi in (select IDXa from tblXa,tblHuyen,tblTinh,tblVungDiaLy where tblXa.IDHuyen=tblHuyen.IDHuyen and tblHuyen.IDTinh=tblTinh.IDTinh and tblVungDiaLy.IDVungDiaLy=tblTinh.IDVungDiaLy and TenVungDiaLy=N'" + txtTen.Text + "') and a.IDTonGiao=2");
                    txtSoLuong.Text = ds.Rows.Count.ToString();
                    ItemStorage.Items.Clear();
                    //txtTen.Text = e.Node.Text;
                    int i;
                    for (i = 0; i < int.Parse(ds.Rows.Count.ToString()); i++)
                    {

                        //DataTable tv1 = wf.TimViTri(" where IDXa=N'" + ds.Rows[i]["DiaChi"].ToString() + "'");
                        try
                        {
                            string ki = ds.Rows[i]["ViDo"].ToString().Replace(".", ",");
                            string vi = ds.Rows[i]["KinhDo"].ToString().Replace(".", ",");
                            #region #MapCustomElementExample
                            var customElement = new MapCustomElement() { Location = new GeoPoint(float.Parse(ki), float.Parse(vi)), Text = "" + ds.Rows[i]["TenCoSo"].ToString() + "-Địa chỉ: " + ds.Rows[i]["TenXa"].ToString() };
                            var image = new Bitmap(imageFilePath + ds.Rows[0]["IDTonGiao"].ToString() + ".png");
                            customElement.Image = new Bitmap(image, new Size(40, 40));
                            ItemStorage.Items.Add(customElement);
                            #endregion #MapCustomElementExample
                        }
                        catch//trong truong hop không có tọa độ xã->lấy tọa độ của huyện
                        {
                            MessageBox.Show("Có lỗi xảy ra");
                        }

                    }

                }
            }
        }

        private void btnChiTietTC_Click(object sender, EventArgs e)
        {
            DataTable tc = wf.DuLieuToChucQuanTri(" where TenToChuc=N'" + cboTenToChucQuanTri.Text + "' and IDTonGiao in (select IDTonGiao from tblTonGiao where TenTonGiao=N'" + cboTonGiao.Text + "' and DaXoa=0)");
            frmChiTietToChucQuanTri frm = new frmChiTietToChucQuanTri();
            frm.txtIDToChuc.Text = tc.Rows[0]["IDToChuc"].ToString();
            frm.Show();
        }
    }
}