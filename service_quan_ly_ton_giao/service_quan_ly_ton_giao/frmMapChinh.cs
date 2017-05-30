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
using System.Xml;
using System.Xml.Linq;
//using DevExpress.XtraCharts;

namespace service_quan_ly_ton_giao
{
    public partial class frmMapChinh : DevExpress.XtraEditors.XtraForm
    {
        string imageFilePath = @"../../icon/cstg";//2 duong link de lay icon in len map
        tblCoSo.ServiceCoSoSoapClient wf = new tblCoSo.ServiceCoSoSoapClient();
        Map.ServiceMapSoapClient wf1 = new Map.ServiceMapSoapClient();
        VectorItemsLayer VectorLayer1 { get { return (VectorItemsLayer)mapCoSo.Layers["VectorLayer1"]; } }
        VectorItemsLayer VectorLayer { get { return (VectorItemsLayer)map.Layers["VectorLayer"]; } }
        MapItemStorage ItemStorage { get { return (MapItemStorage)VectorLayer1.Data; } }
        #region #CreateData
        // Create pie chart data adapter and specify its parameters.    
        const string xmlFilepath = "..\\..\\xml\\dulieutindo.xml";
        const string xmlFilepathTinh = "..\\..\\xml\\dulieutindotheotinh.xml";
        const string xmlFilepath1 = "..\\..\\xml\\dulieutindo1.xml";
        const string xmlFilepathMien = "..\\..\\xml\\dulieutindotheomien.xml";
        public frmMapChinh()
        {
            InitializeComponent();
        }
        void GhiDuLieuVaoFileTheoTinh(string TonGiao, string TenVung)
        {

            DataTable ds1 = wf1.HienThiSLTinDoTheoTinh(TonGiao, " and c.TenVungDiaLy=N'" + TenVung + "' group by c.TenTinh");
            XDocument xmlDoc = XDocument.Load(xmlFilepath1);
            XmlTextWriter xtw = new XmlTextWriter(xmlFilepathMien, null);
            xtw.Formatting = Formatting.Indented;
            xtw.Close();
            for (int i = 0; i < int.Parse(ds1.Rows.Count.ToString()); i++)
            {
                DataTable ds2 = wf.DuLieuTonGiao(" where TenTonGiao like N'%" + TonGiao + "%'");
                for (int j = 0; j < int.Parse(ds2.Rows.Count.ToString()); j++)
                {
                    DataTable ds3 = wf1.HienThiSLTinDoTheoTinh(ds2.Rows[j]["TenTonGiao"].ToString(), "and c.TenVungDiaLy=N'" + TenVung + "' and c.TenTinh=N'" + ds1.Rows[i]["TenTinh"].ToString() + "' group by c.TenTinh");
                    DataTable ds4 = wf.DuLieuHuyen(",tblTinh,tblVungDiaLy where tblTinh.IDTinh=tblHuyen.IDTinh and tblTinh.IDVungDiaLy=tblVungDiaLy.IDVungDiaLy and TenTinh=N'" + ds1.Rows[i]["TenTinh"].ToString() + "' and TenVungDiaLy=N'" + TenVung + "'");

                    //DataTable ds5 = wf.DuLieuXa("where IDHuyen=N'" + ds4.Rows[0]["IDHuyen"].ToString() + "'");

                    string ki = ds4.Rows[0]["ViDo"].ToString();
                    string vi = ds4.Rows[0]["KinhDo"].ToString();
                    try
                    {
                        xmlDoc.Element("NewDataSet").Add(
                    new XElement("Table1",
                    new XElement("Tinh", ds1.Rows[i]["TenTinh"].ToString()),
                    new XElement("VungDiaLy", TenVung),
                    new XElement("TonGiao", ds2.Rows[j]["IDTonGiao"].ToString()),
                    new XElement("SLTinDo", ds3.Rows[0]["SLTinDo"].ToString()),
                    new XElement("CapitalLat", ki),
                    new XElement("CapitalLon", vi)
                    )
                    );
                    }
                    catch
                    {
                        //neu khÔng có tôn giáo nào thì sẽ không in vào file xml
                    }
                }



                xmlDoc.Save(xmlFilepathMien);
            }

        }
        void GhiDuLieuThemVaoFileTheoTinh(string TonGiao, string TenVung)
        {

            DataTable ds1 = wf1.HienThiSLTinDoTheoTinh(TonGiao, "and c.TenVungDiaLy=N'" + TenVung + "' group by c.TenTinh");
            XDocument xmlDoc = XDocument.Load(xmlFilepathMien);
            /*XmlTextWriter xtw = new XmlTextWriter(xmlFilepathMien, null);
            xtw.Formatting = Formatting.Indented;
            xtw.Close();*/
            for (int i = 0; i < int.Parse(ds1.Rows.Count.ToString()); i++)
            {
                DataTable ds2 = wf.DuLieuTonGiao(" where TenTonGiao like N'%" + TonGiao + "%'");
                for (int j = 0; j < int.Parse(ds2.Rows.Count.ToString()); j++)
                {
                    DataTable ds3 = wf1.HienThiSLTinDoTheoTinh(ds2.Rows[j]["TenTonGiao"].ToString(), "and c.TenVungDiaLy=N'" + TenVung + "' and c.TenTinh=N'" + ds1.Rows[i]["TenTinh"].ToString() + "' group by c.TenTinh");
                    DataTable ds4 = wf.DuLieuHuyen(",tblTinh,tblVungDiaLy where tblTinh.IDTinh=tblHuyen.IDTinh and tblTinh.IDVungDiaLy=tblVungDiaLy.IDVungDiaLy and TenTinh=N'" + ds1.Rows[i]["TenTinh"].ToString() + "' and TenVungDiaLy=N'" + TenVung + "'");

                    //DataTable ds5 = wf.DuLieuXa("where IDHuyen=N'" + ds4.Rows[0]["IDHuyen"].ToString() + "'");

                    string ki = ds4.Rows[0]["ViDo"].ToString();
                    string vi = ds4.Rows[0]["KinhDo"].ToString();
                    try
                    {
                        xmlDoc.Element("NewDataSet").Add(
                    new XElement("Table1",
                    new XElement("Tinh", ds1.Rows[i]["TenTinh"].ToString()),
                    new XElement("VungDiaLy", TenVung),
                    new XElement("TonGiao", ds2.Rows[j]["IDTonGiao"].ToString()),
                    new XElement("SLTinDo", ds3.Rows[0]["SLTinDo"].ToString()),
                    new XElement("CapitalLat", ki),
                    new XElement("CapitalLon", vi)
                    )
                    );
                    }
                    catch
                    {
                        //neu khÔng có tôn giáo nào thì sẽ không in vào file xml
                    }
                }



                xmlDoc.Save(xmlFilepathMien);
            }

        }
        IMapDataAdapter CreateData1()
        {
            PieChartDataAdapter adapter = new PieChartDataAdapter()
            {
                DataSource = LoadDataFromXml(xmlFilepathMien),
                PieItemDataMember = "Tinh",
                ItemMinSize = 20,
                ItemMaxSize = 60
            };

            // Specify mappings.
            adapter.Mappings.Latitude = "CapitalLat";
            adapter.Mappings.Longitude = "CapitalLon";
            adapter.Mappings.PieSegment = "TonGiao";
            adapter.Mappings.Value = "SLTinDo";

            // Specify measure rules
            adapter.MeasureRules = new MeasureRules();
            adapter.MeasureRules.RangeStops.Add(1);
            adapter.MeasureRules.RangeStops.Add(2);
            adapter.MeasureRules.RangeStops.Add(3);
            adapter.MeasureRules.RangeStops.Add(4);
            adapter.MeasureRules.RangeStops.Add(5);

            return adapter;
        }
        #region #CreateColorizer
        MapColorizer CreateColorizer()
        {
            KeyColorColorizer colorizer = new KeyColorColorizer()
            {
                ItemKeyProvider = new ArgumentItemKeyProvider()
            };

            colorizer.Colors.Add(Color.FromArgb(255, 207, 98));
            colorizer.Colors.Add(Color.FromArgb(169, 181, 188));
            colorizer.Colors.Add(Color.FromArgb(233, 152, 118));

            colorizer.Keys.Add(new ColorizerKeyItem() { Key = 1, Name = "Phật giáo" });
            colorizer.Keys.Add(new ColorizerKeyItem() { Key = 2, Name = "Công giáo" });
            colorizer.Keys.Add(new ColorizerKeyItem() { Key = 3, Name = "Tin lành" });

            return colorizer;
        }
        private DataTable LoadDataFromXml(string path)
        {
            DataSet ds = new DataSet();
            ds.ReadXml(path);
            DataTable table = ds.Tables[0];
            return table;
        }
        #endregion #CreateData
        #endregion #CreateColorizer
        void HienThiThongKeLenmap1()
        {
            //ItemStorage.Items.Clear();
            #region #DataProperty
            // Assign a PieChartDataAdapter object to Data.
            VectorLayer.Data = CreateData1();
            #endregion #DataProperty

            #region #ColorizerProperty
            // Assign a KeyColorColorizer object to Colorizer.
            VectorLayer.Colorizer = CreateColorizer();
            #endregion #ColorizerProperty
        }
        void HienThiCoSo()
        {
            //hien thi co so
            DataTable ds = wf.HienThiDSCoSo("", "");
            //txtSoLuong.Text = ds.Rows.Count.ToString();
            ItemStorage.Items.Clear();
            //txtTen.Text = "Cả nước";

            for (int i = 0; i < int.Parse(ds.Rows.Count.ToString()); i++)
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
                    MessageBox.Show("Có lỗi xảy ra với "+ds.Rows[i]["IDCoSo"].ToString());
                }

            }
            mapCoSo.CenterPoint = new GeoPoint(latitude: 15.46056, longitude: 107.7433);
            mapCoSo.Zoom(5);
        }
        void HienThiTinDo()
        {

            //hien thi tin do
            DataTable dsvung = wf.DuLieuVung("");

            int m = 0;
            for (int i = 0; i < int.Parse(dsvung.Rows.Count.ToString()); i++)
            {
                DataTable ds8 = wf1.HienThiSLTinDoTheoTinh("", " and c.TenVungDiaLy=N'" + dsvung.Rows[i]["TenVungDiaLy"].ToString() + "' group by c.TenTinh");
                if (int.Parse(ds8.Rows.Count.ToString()) != 0 && m == 0)//xac dinh vung dau tien co du lieu ton giao de ghi vao file
                {
                    GhiDuLieuVaoFileTheoTinh("", dsvung.Rows[i]["TenVungDiaLy"].ToString());
                    m = i;
                }
                if (int.Parse(ds8.Rows.Count.ToString()) != 0 && i != m)//xac dinh day khong phai la vung dau tien co du lieu ton giao de ghi vao file
                {
                    GhiDuLieuThemVaoFileTheoTinh("", dsvung.Rows[i]["TenVungDiaLy"].ToString());
                }

            }
            HienThiThongKeLenmap1();
            map.CenterPoint = new GeoPoint(latitude: 15.46056, longitude: 107.7433);
            map.Zoom(5);
            
        }
        void HienThiThongKetonGiao()
        {
            /*DevExpress.XtraCharts.Series series = new DevExpress.XtraCharts.Series("Series1", DevExpress.XtraCharts.ViewType.Bar);
            series.DataSource = wf1.HienThiTinDoTheoTonGiao("");
            //series.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative;
            series.ArgumentDataMember = "TenTonGiao";
            series.ValueScaleType = DevExpress.XtraCharts.ScaleType.Numerical;
            series.ValueDataMembers.AddRange(new string[] { "SLTinDo" });
            ((DevExpress.XtraCharts.SideBySideBarSeriesView)series.View).ColorEach = true;
            //((DevExpress.XtraCharts.XYDiagram)chart.Diagram).AxisY.Visibility = DevExpress.Utils.DefaultBoolean.False;
            chart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;*/
            DataTable ds= wf1.HienThiTinDoTheoTonGiaoTheoTinh("");
            chart.DataSource =ds;
            
            chart.Series[0].ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative;
            chart.Series[0].ArgumentDataMember = "TenTonGiao";
            chart.Series[0].ValueDataMembers[0] = "SLTinDo";
                
         
            
        }
        private void frmMapChinh_Load(object sender, EventArgs e)
        {
            HienThiTinDo();
            HienThiCoSo();
            HienThiThongKetonGiao();
        }

        private void btnTatCa_Click(object sender, EventArgs e)
        {
           
            DataTable dsvung = wf.DuLieuVung("");

            int m = 0;
            for (int i = 0; i < int.Parse(dsvung.Rows.Count.ToString()); i++)
            {
                DataTable ds8 = wf1.HienThiSLTinDoTheoTinh("", " and c.TenVungDiaLy=N'" + dsvung.Rows[i]["TenVungDiaLy"].ToString() + "' group by c.TenTinh");
                if (int.Parse(ds8.Rows.Count.ToString()) != 0 && m == 0)//xac dinh vung dau tien co du lieu ton giao de ghi vao file
                {
                    GhiDuLieuVaoFileTheoTinh("", dsvung.Rows[i]["TenVungDiaLy"].ToString());
                    m = i;
                }
                if (int.Parse(ds8.Rows.Count.ToString()) != 0 && i != m)//xac dinh day khong phai la vung dau tien co du lieu ton giao de ghi vao file
                {
                    GhiDuLieuThemVaoFileTheoTinh("", dsvung.Rows[i]["TenVungDiaLy"].ToString());
                }

            }
            HienThiThongKeLenmap1();
            map.CenterPoint = new GeoPoint(latitude: 15.46056, longitude: 107.7433);
            map.Zoom(5);
           
        }
        void XacDinhTinDoTheoTungTonGiao(string TonGiao)
        {
           
                DataTable dsvung = wf.DuLieuVung("");

                int m = 0;
                for (int i = 0; i < int.Parse(dsvung.Rows.Count.ToString()); i++)
                {
                    DataTable ds8 = wf1.HienThiSLTinDoTheoTinh(TonGiao, " and c.TenVungDiaLy=N'" + dsvung.Rows[i]["TenVungDiaLy"].ToString() + "' group by c.TenTinh");
                    if (int.Parse(ds8.Rows.Count.ToString()) != 0 && m == 0)//xac dinh vung dau tien co du lieu ton giao de ghi vao file
                    {
                        GhiDuLieuVaoFileTheoTinh(TonGiao, dsvung.Rows[i]["TenVungDiaLy"].ToString());
                        m = i;
                    }
                    if (int.Parse(ds8.Rows.Count.ToString()) != 0 && i != m)//xac dinh day khong phai la vung dau tien co du lieu ton giao de ghi vao file
                    {
                        GhiDuLieuThemVaoFileTheoTinh(TonGiao, dsvung.Rows[i]["TenVungDiaLy"].ToString());
                    }

                }
                HienThiThongKeLenmap1();
                map.CenterPoint = new GeoPoint(latitude: 15.46056, longitude: 107.7433);
                map.Zoom(5);
        }
        private void btnPhatGiao_Click(object sender, EventArgs e)
        {
            XacDinhTinDoTheoTungTonGiao("Phật giáo");
        }

        private void btnCongGiao_Click(object sender, EventArgs e)
        {
            XacDinhTinDoTheoTungTonGiao("Công giáo");
        }

        private void btnTatCaCoSo_Click(object sender, EventArgs e)
        {
            HienThiCoSo();
        }

        private void btnPhatGiaoCoSo_Click(object sender, EventArgs e)
        {
            DataTable ds = wf.HienThiDSCoSo("", " where a.IDTonGiao=1");
            //txtSoLuong.Text = ds.Rows.Count.ToString();
            ItemStorage.Items.Clear();
            //txtTen.Text = "Cả nước";
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
            mapCoSo.CenterPoint = new GeoPoint(latitude: 15.46056, longitude: 107.7433);
            mapCoSo.Zoom(5);
        }

        private void btnCongGiaoCoSo_Click(object sender, EventArgs e)
        {
            DataTable ds = wf.HienThiDSCoSo("", " where a.IDTonGiao=2");
            //txtSoLuong.Text = ds.Rows.Count.ToString();
            ItemStorage.Items.Clear();
            //txtTen.Text = "Cả nước";
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
            mapCoSo.CenterPoint = new GeoPoint(latitude: 15.46056, longitude: 107.7433);
            mapCoSo.Zoom(5);
        }

        private void mapCoSo_MapItemClick(object sender, MapItemClickEventArgs e)
        {
            string x = mapCoSo.CenterPoint.GetX().ToString();
            string y = mapCoSo.CenterPoint.GetY().ToString();
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
    }
}