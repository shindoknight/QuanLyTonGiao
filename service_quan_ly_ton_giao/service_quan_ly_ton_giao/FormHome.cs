using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraMap;

namespace service_quan_ly_ton_giao
{
    public partial class FormHome : Form
    {
        const string filepath = @"../../Data/sochi2014.xml";
        public FormHome()
        {
            InitializeComponent();
        }
        
        private void FormHome_Load(object sender, EventArgs e)
        {
            // Create an image tiles layer and add it to the map.
            ImageLayer tilesLayer = new ImageLayer();
            mapControl1.Layers.Add(tilesLayer);

            // Create an Open Street data provider.
            OpenStreetMapDataProvider provider = new OpenStreetMapDataProvider();
            tilesLayer.DataProvider = provider;
            // Assign loaded data as data source for pie chart data adapter.
            pieChartDataAdapter1.DataSource = LoadData(filepath);
        }
        private DataTable LoadData(string path)
        {
            DataSet ds = new DataSet();
            ds.ReadXml(path);
            DataTable table = ds.Tables[0];
            return table;
        }
        private void OnDataLoaded(object sender, DataLoadedEventArgs e)
        {
            
            mapControl1.ZoomToFitLayerItems();
        }
    }
    
}
