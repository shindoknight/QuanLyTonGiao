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

namespace service_quan_ly_ton_giao
{
    public partial class frmMapTinDo : DevExpress.XtraEditors.XtraForm
    {
        string tree = "";
        tblCoSo.ServiceCoSoSoapClient wf = new tblCoSo.ServiceCoSoSoapClient();
        Map.ServiceMapSoapClient wf1 = new Map.ServiceMapSoapClient();
        VectorItemsLayer PieLayer { get { return (VectorItemsLayer)map.Layers["PieLayer"]; } }
        VectorItemsLayer VectorLayer { get { return (VectorItemsLayer)map.Layers["VectorLayer"]; } }
        MapItemStorage ItemStorage { get { return (MapItemStorage)VectorLayer.Data; } }
        #region #CreateData
        // Create pie chart data adapter and specify its parameters.    
        const string xmlFilepath = "..\\..\\xml\\dulieutindo.xml";
        const string xmlFilepathTinh = "..\\..\\xml\\dulieutindotheotinh.xml";
        const string xmlFilepath1 = "..\\..\\xml\\dulieutindo1.xml";
        const string xmlFilepathMien = "..\\..\\xml\\dulieutindotheomien.xml";
        //ghi du lieu vao filexml
        void GhiDuLieuVaoFileTheoHuyen(string TonGiao, string TenTinh)
        {

            DataTable ds1 = wf1.HienThiSLTinDoTheoHuyen(TonGiao, "and c.TenTinh=N'" + TenTinh + "' group by c.TenHuyen");
            XDocument xmlDoc = XDocument.Load(xmlFilepath);
            XmlTextWriter xtw = new XmlTextWriter(xmlFilepathTinh, null);
            xtw.Formatting = Formatting.Indented;
            xtw.Close();
            for (int i = 0; i < int.Parse(ds1.Rows.Count.ToString()); i++)
            {
                DataTable ds2 = wf.DuLieuTonGiao(" where TenTonGiao like N'%" + TonGiao + "%'");
                for (int j = 0; j < int.Parse(ds2.Rows.Count.ToString()); j++)
                {
                    DataTable ds3 = wf1.HienThiSLTinDoTheoHuyen(ds2.Rows[j]["TenTonGiao"].ToString(), "and c.TenTinh=N'" + TenTinh + "' and c.TenHuyen=N'" + ds1.Rows[i]["TenHuyen"].ToString() + "' group by c.TenHuyen");
                    DataTable ds4 = wf.DuLieuHuyen(",tblTinh where tblTinh.IDTinh=tblHuyen.IDTinh and TenHuyen=N'" + ds1.Rows[i]["TenHuyen"].ToString() + "' and TenTinh=N'" + TenTinh + "'");

                    DataTable ds5 = wf.DuLieuXa("where IDHuyen=N'" + ds4.Rows[0]["IDHuyen"].ToString() + "'");

                    string ki = ds5.Rows[0]["ViDo"].ToString();
                    string vi = ds5.Rows[0]["KinhDo"].ToString();
                    try
                    {
                        xmlDoc.Element("NewDataSet").Add(
                    new XElement("Table1",
                    new XElement("Huyen", ds1.Rows[i]["TenHuyen"].ToString()),
                    new XElement("Tinh", TenTinh),
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



                xmlDoc.Save(xmlFilepathTinh);
            }

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
        void GhiDuLieuThemVaoFileTheoHuyen(string TonGiao, string TenTinh)
        {

            DataTable ds1 = wf1.HienThiSLTinDoTheoHuyen(TonGiao, "and c.TenTinh=N'" + TenTinh + "' group by c.TenHuyen");
            XDocument xmlDoc = XDocument.Load(xmlFilepathTinh);
            /*XmlTextWriter xtw = new XmlTextWriter(xmlFilepathTinh, null);
            xtw.Formatting = Formatting.Indented;
            xtw.Close();*/
            for (int i = 0; i < int.Parse(ds1.Rows.Count.ToString()); i++)
            {
                DataTable ds2 = wf.DuLieuTonGiao(" where TenTonGiao like N'%" + TonGiao + "%'");
                for (int j = 0; j < int.Parse(ds2.Rows.Count.ToString()); j++)
                {
                    DataTable ds3 = wf1.HienThiSLTinDoTheoHuyen(ds2.Rows[j]["TenTonGiao"].ToString(), "and c.TenTinh=N'" + TenTinh + "' and c.TenHuyen=N'" + ds1.Rows[i]["TenHuyen"].ToString() + "' group by c.TenHuyen");
                    DataTable ds4 = wf.DuLieuHuyen(",tblTinh where tblTinh.IDTinh=tblHuyen.IDTinh and TenHuyen=N'" + ds1.Rows[i]["TenHuyen"].ToString() + "' and TenTinh=N'" + TenTinh + "'");

                    DataTable ds5 = wf.DuLieuXa("where IDHuyen=N'" + ds4.Rows[0]["IDHuyen"].ToString() + "'");

                    string ki = ds5.Rows[0]["ViDo"].ToString();
                    string vi = ds5.Rows[0]["KinhDo"].ToString();
                    try
                    {
                        xmlDoc.Element("NewDataSet").Add(
                    new XElement("Table1",
                    new XElement("Huyen", ds1.Rows[i]["TenHuyen"].ToString()),
                    new XElement("Tinh", TenTinh),
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



                xmlDoc.Save(xmlFilepathTinh);
            }

        }
        IMapDataAdapter CreateData()
        {
            PieChartDataAdapter adapter = new PieChartDataAdapter()
            {
                DataSource = LoadDataFromXml(xmlFilepathTinh),
                PieItemDataMember = "Huyen",
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
        IMapDataAdapter CreateData2()
        {
            PieChartDataAdapter adapter = new PieChartDataAdapter()
            {
                DataSource = LoadDataFromXml(xmlFilepath1),
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
        IMapDataAdapter CreateData3()
        {
            PieChartDataAdapter adapter = new PieChartDataAdapter()
            {
                DataSource = LoadDataFromXml(xmlFilepath),
                PieItemDataMember = "Huyen",
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
        private DataTable LoadDataFromXml(string path)
        {
            DataSet ds = new DataSet();
            ds.ReadXml(path);
            DataTable table = ds.Tables[0];
            return table;
        }
        #endregion #CreateData

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
        #endregion #CreateColorizer

        public frmMapTinDo()
        {
            InitializeComponent();
        }
<<<<<<< HEAD
       
=======
>>>>>>> refs/remotes/origin/master
        void HienThiHinhLenMap(int SoLuong, string ki, string vi)
        {
            if (SoLuong == 1)
            {
                #region #MapDotExample
                ItemStorage.Items.Add(new MapDot() { Location = new GeoPoint(float.Parse(ki), float.Parse(vi)), Size = 18, Stroke = Color.Blue });
                #endregion #MapDotExample
            }
            if (SoLuong == 2)
            {
                #region #MapDotExample
                ItemStorage.Items.Add(new MapDot() { Location = new GeoPoint(float.Parse(ki), float.Parse(vi)), Size = 27, Stroke = Color.Blue });
                #endregion #MapDotExample
            }
            if (SoLuong == 3)
            {
                #region #MapDotExample
                ItemStorage.Items.Add(new MapDot() { Location = new GeoPoint(float.Parse(ki), float.Parse(vi)), Size = 36, Stroke = Color.Blue });
                #endregion #MapDotExample
            }
        }
        void HienThiThongKeLenmap()
        {
            //ItemStorage.Items.Clear();
            #region #DataProperty
            // Assign a PieChartDataAdapter object to Data.
            VectorLayer.Data = CreateData();
            #endregion #DataProperty

            #region #ColorizerProperty
            // Assign a KeyColorColorizer object to Colorizer.
            VectorLayer.Colorizer = CreateColorizer();
            #endregion #ColorizerProperty
        }
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
        void HienThiThongKeLenmap2()
        {
            //ItemStorage.Items.Clear();
            #region #DataProperty
            // Assign a PieChartDataAdapter object to Data.
            VectorLayer.Data = CreateData2();
            #endregion #DataProperty

            #region #ColorizerProperty
            // Assign a KeyColorColorizer object to Colorizer.
            VectorLayer.Colorizer = CreateColorizer();
            #endregion #ColorizerProperty
        }
        void HienThiThongKeLenmap3()
        {
            //ItemStorage.Items.Clear();
            #region #DataProperty
            // Assign a PieChartDataAdapter object to Data.
            VectorLayer.Data = CreateData3();
            #endregion #DataProperty

            #region #ColorizerProperty
            // Assign a KeyColorColorizer object to Colorizer.
            VectorLayer.Colorizer = CreateColorizer();
            #endregion #ColorizerProperty
        }
        /* void HienThiTinDoTheoTinh(string TonGiao, string TenTinh)
         {
             map.CenterPoint = new GeoPoint(latitude: 21.04778, longitude: 105.8478);
             map.Zoom(12);
             ItemStorage.Items.Clear();
             DataTable ds = wf1.HienThiSLTinDoTheoHuyen(TonGiao, "and c.TenTinh=N'" + TenTinh + "' group by c.TenHuyen");

             //txtSoLuong.Text = ds.Rows.Count.ToString();
             //DataTable ds2 = wf.HienThiDSCoSo("", " where a.TenTonGiao=N'" + ds.Rows[0]["TenTonGiao"].ToString() + "'");
             if (int.Parse(ds.Rows.Count.ToString()) == 0)
             {
                 MessageBox.Show("Thành phố " + TenTinh + " không có tín đồ");
             }
             //xac dinh tam
             DataTable ds3 = wf.DuLieuTinh(" where TenTinh=N'" + TenTinh + "' ");
             DataTable ds4 = wf.DuLieuHuyen(" where IDTinh=N'" + ds3.Rows[0]["IDTinh"].ToString() + "'");
             DataTable ds5 = wf.DuLieuXa("where IDHuyen=N'" + ds4.Rows[0]["IDHuyen"].ToString() + "'");
             try
             {
                 string ki = ds5.Rows[0]["ViDo"].ToString().Replace(".", ",");
                 string vi = ds5.Rows[0]["KinhDo"].ToString().Replace(".", ",");

                 map.CenterPoint = new GeoPoint(latitude: float.Parse(ki), longitude: float.Parse(vi));
                 map.Zoom(8);
             }
             catch//trong truong hop không có tọa độ xã->lấy tọa độ của huyện
             {
                 DataTable tv3 = wf.TimViTriTheoHuyen(" where IDHuyen=N'" + ds5.Rows[0]["IDHuyen"].ToString() + "'");
                 string ki = tv3.Rows[0]["ViDo"].ToString().Replace(".", ",");
                 string vi = tv3.Rows[0]["KinhDo"].ToString().Replace(".", ",");

                 map.CenterPoint = new GeoPoint(latitude: float.Parse(ki), longitude: float.Parse(vi));
                 map.Zoom(8);
             }
             int i;
             for (i = 0; i < int.Parse(ds.Rows.Count.ToString()); i++)
             {
                 int SoLuongTD = int.Parse(ds.Rows[i]["SLTinDo"].ToString());
                 DataTable tv1 = wf.TimViTri(" where IDXa in (select IDXa from tblXa,tblHuyen,tblTinh where tblXa.IDHuyen=tblHuyen.IDHuyen and tblTinh.IDTinh =tblHuyen.IDTinh and TenHuyen=N'" + ds.Rows[i]["TenHuyen"].ToString() + "' and TenTinh=N'" + TenTinh + "')");

                 try
                 {
                     string ki = tv1.Rows[0]["ViDo"].ToString().Replace(".", ",");
                     string vi = tv1.Rows[0]["KinhDo"].ToString().Replace(".", ",");

                     HienThiHinhLenMap(SoLuongTD, ki, vi);

                 }
                 catch//trong truong hop không có tọa độ xã->lấy tọa độ của huyện
                 {
                     DataTable tv2 = wf.TimViTriTheoHuyen(" where IDHuyen=N'" + tv1.Rows[0]["IDHuyen"].ToString() + "'");
                     string ki = tv2.Rows[0]["ViDo"].ToString().Replace(".", ",");
                     string vi = tv2.Rows[0]["KinhDo"].ToString().Replace(".", ",");

                     HienThiHinhLenMap(SoLuongTD, ki, vi);
                 }

             }
         }*/
        void HienThi()
        {


            //làm việc với treeview
            ///group các thành phố trực thuộc trung ương
            DataTable ds1 = wf.DuLieuTinh(" where Loai=N'Thành phố'");
            for (int i = 0; i < int.Parse(ds1.Rows.Count.ToString()); i++)
            {
                treeView1.Nodes["nodediagioihanhchinh"].Nodes["nodecThanhPhoTU"].Nodes.Add(ds1.Rows[i]["TenTinh"].ToString());
            }
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
            //hien thi len map tín đồ thuoc ha noi
            //HienThiTinDoTheoTinh("Phật Giáo","Hà Nội");
        }
        private void frmMapTinDo_Load(object sender, EventArgs e)
        {
            HienThi();
            GhiDuLieuVaoFileTheoHuyen("", "Hà Nội");
            HienThiThongKeLenmap();
            map.CenterPoint = new GeoPoint(latitude: 21.03555, longitude: 105.8272);
            map.Zoom(9);
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            tree = e.Node.Text;
            if (e.Node.Text == "Địa giới hành chính" || e.Node.Text == "Thành phố trực thuộc Trung ương" || e.Node.Text == "Khu vực địa giới hành chính")
            {
                DataTable dsvung = wf.DuLieuVung("");
                
                int m = 0;
                for (int i = 0; i < int.Parse(dsvung.Rows.Count.ToString()); i++)
                {
                    DataTable ds8 = wf1.HienThiSLTinDoTheoTinh("", " and c.TenVungDiaLy=N'" + dsvung.Rows[i]["TenVungDiaLy"].ToString() + "' group by c.TenTinh");
                    if(int.Parse(ds8.Rows.Count.ToString())!=0 && m==0)//xac dinh vung dau tien co du lieu ton giao de ghi vao file
                    {
                        GhiDuLieuVaoFileTheoTinh("", dsvung.Rows[i]["TenVungDiaLy"].ToString());
                        m = i;
                    }
                    if (int.Parse(ds8.Rows.Count.ToString()) != 0 && i!=m)//xac dinh day khong phai la vung dau tien co du lieu ton giao de ghi vao file
                    {
                        GhiDuLieuThemVaoFileTheoTinh("", dsvung.Rows[i]["TenVungDiaLy"].ToString());
                    }
                    
                }
                HienThiThongKeLenmap1();
                map.CenterPoint = new GeoPoint(latitude: 15.46056, longitude: 107.7433);
                map.Zoom(5);
            }
            //click vÀo các tên tỉnh 
            DataTable ds1 = wf.DuLieuTinh(" where TenTinh=N'" + e.Node.Text + "'");

            if (int.Parse(ds1.Rows.Count.ToString()) == 1)
            {
                try
                {
                    GhiDuLieuVaoFileTheoHuyen("", e.Node.Text);

                    HienThiThongKeLenmap();
                }
                catch
                {
                    HienThiThongKeLenmap3();
                    MessageBox.Show(e.Node.Text + " không có tín đồ");
                }
                //xac dinh tam cua map
                DataTable ds2 = wf.DuLieuHuyen(" where IDTinh=N'" + ds1.Rows[0]["IDTinh"].ToString() + "'");
                string ki = ds2.Rows[0]["ViDo"].ToString().Replace(".", ",");
                string vi = ds2.Rows[0]["KinhDo"].ToString().Replace(".", ",");
                map.CenterPoint = new GeoPoint(latitude: float.Parse(ki), longitude: float.Parse(vi));
                map.Zoom(9);
            }
            //click vao khu vuc
            DataTable ds3 = wf.DuLieuVung(" where TenVungDiaLy=N'" + e.Node.Text + "'");
            if (int.Parse(ds3.Rows.Count.ToString()) == 1)
            {
                DataTable ds4 = wf.DuLieuTinh(" where IDVungDiaLy=N'" + ds3.Rows[0]["IDVungDiaLy"].ToString() + "' ");
                int tam = int.Parse(ds4.Rows.Count.ToString()) / 2;
                DataTable ds5 = wf.DuLieuHuyen(" where IDTinh=N'" + ds4.Rows[tam]["IDTinh"].ToString() + "'");
                DataTable ds6 = wf.DuLieuXa("where IDHuyen=N'" + ds5.Rows[0]["IDHuyen"].ToString() + "'");
                try
                {
                    string ki = ds6.Rows[0]["ViDo"].ToString().Replace(".", ",");
                    string vi = ds6.Rows[0]["KinhDo"].ToString().Replace(".", ",");

                    map.CenterPoint = new GeoPoint(latitude: float.Parse(ki), longitude: float.Parse(vi));
                    map.Zoom(7);
                }
                catch//trong truong hop không có tọa độ xã->lấy tọa độ của huyện
                {
                    DataTable tv3 = wf.TimViTriTheoHuyen(" where IDHuyen=N'" + ds6.Rows[tam]["IDHuyen"].ToString() + "'");
                    string ki = tv3.Rows[0]["ViDo"].ToString().Replace(".", ",");
                    string vi = tv3.Rows[0]["KinhDo"].ToString().Replace(".", ",");

                    map.CenterPoint = new GeoPoint(latitude: float.Parse(ki), longitude: float.Parse(vi));
                    map.Zoom(7);
                }
                //hien thi toan bo tin do len map theo vung
                //txtTen.Text = e.Node.Text;

               
                DataTable ds8 = wf1.HienThiSLTinDoTheoTinh("", " and c.TenVungDiaLy=N'" + e.Node.Text + "' group by c.TenTinh");
                if (int.Parse(ds8.Rows.Count.ToString()) == 0 )//xac dinh vung dau tien co du lieu ton giao de ghi vao file
                {
                    HienThiThongKeLenmap2();
                    
                }
                if (int.Parse(ds8.Rows.Count.ToString()) >= 1 )
                {
                    GhiDuLieuVaoFileTheoTinh("", e.Node.Text);
                    HienThiThongKeLenmap1();
                }
                   
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tree == "Địa giới hành chính" ||tree == "Thành phố trực thuộc Trung ương" ||tree == "Khu vực địa giới hành chính")
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
            //click vÀo các tên tỉnh 
            DataTable ds1 = wf.DuLieuTinh(" where TenTinh=N'" +tree + "'");

            if (int.Parse(ds1.Rows.Count.ToString()) == 1)
            {
                try
                {
                    GhiDuLieuVaoFileTheoHuyen("",tree);

                    HienThiThongKeLenmap();
                }
                catch
                {
                    HienThiThongKeLenmap3();
                    MessageBox.Show(tree + " không có tín đồ");
                }
                //xac dinh tam cua map
                DataTable ds2 = wf.DuLieuHuyen(" where IDTinh=N'" + ds1.Rows[0]["IDTinh"].ToString() + "'");
                string ki = ds2.Rows[0]["ViDo"].ToString().Replace(".", ",");
                string vi = ds2.Rows[0]["KinhDo"].ToString().Replace(".", ",");
                map.CenterPoint = new GeoPoint(latitude: float.Parse(ki), longitude: float.Parse(vi));
                map.Zoom(9);
            }
            //click vao khu vuc
            DataTable ds3 = wf.DuLieuVung(" where TenVungDiaLy=N'" +tree + "'");
            if (int.Parse(ds3.Rows.Count.ToString()) == 1)
            {
                DataTable ds4 = wf.DuLieuTinh(" where IDVungDiaLy=N'" + ds3.Rows[0]["IDVungDiaLy"].ToString() + "' ");
                int tam = int.Parse(ds4.Rows.Count.ToString()) / 2;
                DataTable ds5 = wf.DuLieuHuyen(" where IDTinh=N'" + ds4.Rows[tam]["IDTinh"].ToString() + "'");
                DataTable ds6 = wf.DuLieuXa("where IDHuyen=N'" + ds5.Rows[0]["IDHuyen"].ToString() + "'");
                try
                {
                    string ki = ds6.Rows[0]["ViDo"].ToString().Replace(".", ",");
                    string vi = ds6.Rows[0]["KinhDo"].ToString().Replace(".", ",");

                    map.CenterPoint = new GeoPoint(latitude: float.Parse(ki), longitude: float.Parse(vi));
                    map.Zoom(7);
                }
                catch//trong truong hop không có tọa độ xã->lấy tọa độ của huyện
                {
                    DataTable tv3 = wf.TimViTriTheoHuyen(" where IDHuyen=N'" + ds6.Rows[tam]["IDHuyen"].ToString() + "'");
                    string ki = tv3.Rows[0]["ViDo"].ToString().Replace(".", ",");
                    string vi = tv3.Rows[0]["KinhDo"].ToString().Replace(".", ",");

                    map.CenterPoint = new GeoPoint(latitude: float.Parse(ki), longitude: float.Parse(vi));
                    map.Zoom(7);
                }
                //hien thi toan bo tin do len map theo vung
                //txtTen.Text =tree;


                DataTable ds8 = wf1.HienThiSLTinDoTheoTinh("", " and c.TenVungDiaLy=N'" +tree + "' group by c.TenTinh");
                if (int.Parse(ds8.Rows.Count.ToString()) == 0)//xac dinh vung dau tien co du lieu ton giao de ghi vao file
                {
                    HienThiThongKeLenmap2();

                }
                if (int.Parse(ds8.Rows.Count.ToString()) >= 1)
                {
                    GhiDuLieuVaoFileTheoTinh("",tree);
                    HienThiThongKeLenmap1();
                }

            }
        }
        void XacDinhTinDoTheoTungTonGiao(string TonGiao)
        {
            if (tree == "Địa giới hành chính" || tree == "Thành phố trực thuộc Trung ương" || tree == "Khu vực địa giới hành chính")
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
                        GhiDuLieuThemVaoFileTheoTinh("", dsvung.Rows[i]["TenVungDiaLy"].ToString());
                    }

                }
                HienThiThongKeLenmap1();
                map.CenterPoint = new GeoPoint(latitude: 15.46056, longitude: 107.7433);
                map.Zoom(5);
            }
            //click vÀo các tên tỉnh 
            DataTable ds1 = wf.DuLieuTinh(" where TenTinh=N'" + tree + "'");

            if (int.Parse(ds1.Rows.Count.ToString()) == 1)
            {
                try
                {
                    GhiDuLieuVaoFileTheoHuyen(TonGiao, tree);

                    HienThiThongKeLenmap();
                }
                catch
                {
                    HienThiThongKeLenmap3();
                    MessageBox.Show(tree + " không có tín đồ");
                }
                //xac dinh tam cua map
                DataTable ds2 = wf.DuLieuHuyen(" where IDTinh=N'" + ds1.Rows[0]["IDTinh"].ToString() + "'");
                string ki = ds2.Rows[0]["ViDo"].ToString().Replace(".", ",");
                string vi = ds2.Rows[0]["KinhDo"].ToString().Replace(".", ",");
                map.CenterPoint = new GeoPoint(latitude: float.Parse(ki), longitude: float.Parse(vi));
                map.Zoom(9);
            }
            //click vao khu vuc
            DataTable ds3 = wf.DuLieuVung(" where TenVungDiaLy=N'" + tree + "'");
            if (int.Parse(ds3.Rows.Count.ToString()) == 1)
            {
                DataTable ds4 = wf.DuLieuTinh(" where IDVungDiaLy=N'" + ds3.Rows[0]["IDVungDiaLy"].ToString() + "' ");
                int tam = int.Parse(ds4.Rows.Count.ToString()) / 2;
                DataTable ds5 = wf.DuLieuHuyen(" where IDTinh=N'" + ds4.Rows[tam]["IDTinh"].ToString() + "'");
                DataTable ds6 = wf.DuLieuXa("where IDHuyen=N'" + ds5.Rows[0]["IDHuyen"].ToString() + "'");
                try
                {
                    string ki = ds6.Rows[0]["ViDo"].ToString().Replace(".", ",");
                    string vi = ds6.Rows[0]["KinhDo"].ToString().Replace(".", ",");

                    map.CenterPoint = new GeoPoint(latitude: float.Parse(ki), longitude: float.Parse(vi));
                    map.Zoom(7);
                }
                catch//trong truong hop không có tọa độ xã->lấy tọa độ của huyện
                {
                    DataTable tv3 = wf.TimViTriTheoHuyen(" where IDHuyen=N'" + ds6.Rows[tam]["IDHuyen"].ToString() + "'");
                    string ki = tv3.Rows[0]["ViDo"].ToString().Replace(".", ",");
                    string vi = tv3.Rows[0]["KinhDo"].ToString().Replace(".", ",");

                    map.CenterPoint = new GeoPoint(latitude: float.Parse(ki), longitude: float.Parse(vi));
                    map.Zoom(7);
                }
                //hien thi toan bo tin do len map theo vung
                //txtTen.Text =tree;


                DataTable ds8 = wf1.HienThiSLTinDoTheoTinh(TonGiao, " and c.TenVungDiaLy=N'" + tree + "' group by c.TenTinh");
                if (int.Parse(ds8.Rows.Count.ToString()) == 0)//xac dinh vung dau tien co du lieu ton giao de ghi vao file
                {
                    HienThiThongKeLenmap2();

                }
                if (int.Parse(ds8.Rows.Count.ToString()) >= 1)
                {
                    GhiDuLieuVaoFileTheoTinh(TonGiao, tree);
                    HienThiThongKeLenmap1();
                }

            }
        }
        private void btnPhatGiao_Click(object sender, EventArgs e)
        {
            XacDinhTinDoTheoTungTonGiao("Phật Giáo");
            txtTenTonGiao.Text = "Phật Giáo";
        }

        private void btnCongGiao_Click(object sender, EventArgs e)
        {
            XacDinhTinDoTheoTungTonGiao("Công giáo");
            txtTenTonGiao.Text = "Công giáo";
        }

        private void btnTinLanh_Click(object sender, EventArgs e)
        {
            XacDinhTinDoTheoTungTonGiao("Tin Lành");
            txtTenTonGiao.Text = "Tin Lành";
        }

        private void btnCaoDai_Click(object sender, EventArgs e)
        {
            XacDinhTinDoTheoTungTonGiao("Cao Đài");
            txtTenTonGiao.Text = "Cao Đài";
        }

        private void btnHoiGiao_Click(object sender, EventArgs e)
        {
            XacDinhTinDoTheoTungTonGiao("Hồi giáo");
            txtTenTonGiao.Text = "Hồi giáo";
        }
    }
}