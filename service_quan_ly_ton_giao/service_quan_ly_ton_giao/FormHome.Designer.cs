namespace service_quan_ly_ton_giao
{
    partial class FormHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraMap.KeyColorColorizer keyColorColorizer3 = new DevExpress.XtraMap.KeyColorColorizer();
            DevExpress.XtraMap.ArgumentItemKeyProvider argumentItemKeyProvider3 = new DevExpress.XtraMap.ArgumentItemKeyProvider();
            DevExpress.XtraMap.ColorizerKeyItem colorizerKeyItem7 = new DevExpress.XtraMap.ColorizerKeyItem();
            DevExpress.XtraMap.ColorizerKeyItem colorizerKeyItem8 = new DevExpress.XtraMap.ColorizerKeyItem();
            DevExpress.XtraMap.ColorizerKeyItem colorizerKeyItem9 = new DevExpress.XtraMap.ColorizerKeyItem();
            DevExpress.XtraMap.MeasureRules measureRules3 = new DevExpress.XtraMap.MeasureRules();
            DevExpress.XtraMap.LinearRangeDistribution linearRangeDistribution3 = new DevExpress.XtraMap.LinearRangeDistribution();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.mapControl1 = new DevExpress.XtraMap.MapControl();
            this.imageLayer1 = new DevExpress.XtraMap.ImageLayer();
            this.openStreetMapDataProvider1 = new DevExpress.XtraMap.OpenStreetMapDataProvider();
            this.analyticalDataLayer = new DevExpress.XtraMap.VectorItemsLayer();
            this.pieChartDataAdapter1 = new DevExpress.XtraMap.PieChartDataAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.mapControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(842, 490);
            this.splitContainerControl1.SplitterPosition = 500;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // mapControl1
            // 
            this.mapControl1.CenterPoint = new DevExpress.XtraMap.GeoPoint(15D, 107D);
            this.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapControl1.Layers.Add(this.imageLayer1);
            this.mapControl1.Layers.Add(this.analyticalDataLayer);
            this.mapControl1.Location = new System.Drawing.Point(0, 0);
            this.mapControl1.Name = "mapControl1";
            this.mapControl1.Size = new System.Drawing.Size(337, 490);
            this.mapControl1.TabIndex = 0;
            this.mapControl1.ZoomLevel = 5D;
            // 
            // imageLayer1
            // 
            this.imageLayer1.DataProvider = this.openStreetMapDataProvider1;
            // 
            // openStreetMapDataProvider1
            // 
            this.openStreetMapDataProvider1.TileUriTemplate = "http://{0}.tile.INSERT_SERVER_NAME.com/{1}/{2}/{3}.png";
            // 
            // analyticalDataLayer
            // 
            keyColorColorizer3.Colors.Add(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0))))));
            keyColorColorizer3.Colors.Add(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0))))));
            keyColorColorizer3.Colors.Add(System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255))))));
            keyColorColorizer3.Colors.Add(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255))))));
            keyColorColorizer3.ItemKeyProvider = argumentItemKeyProvider3;
            colorizerKeyItem7.Key = "1";
            colorizerKeyItem7.Name = "Gold";
            colorizerKeyItem8.Key = "2";
            colorizerKeyItem8.Name = "Silver";
            colorizerKeyItem9.Key = "3";
            colorizerKeyItem9.Name = "Bronze";
            keyColorColorizer3.Keys.Add(colorizerKeyItem7);
            keyColorColorizer3.Keys.Add(colorizerKeyItem8);
            keyColorColorizer3.Keys.Add(colorizerKeyItem9);
            this.analyticalDataLayer.Colorizer = keyColorColorizer3;
            this.analyticalDataLayer.Data = this.pieChartDataAdapter1;
            this.analyticalDataLayer.ToolTipPattern = "<b>%A%</b>\r\nGold: %V0%\r\nSilver: %V1%\r\nBronze: %V2%\r\nTotal:%V%";
            this.analyticalDataLayer.DataLoaded += new DevExpress.XtraMap.DataLoadedEventHandler(this.OnDataLoaded);
            // 
            // pieChartDataAdapter1
            // 
            this.pieChartDataAdapter1.ItemMaxSize = 60;
            this.pieChartDataAdapter1.ItemMinSize = 20;
            this.pieChartDataAdapter1.Mappings.Latitude = "CapitalLat";
            this.pieChartDataAdapter1.Mappings.Longitude = "CapitalLon";
            this.pieChartDataAdapter1.Mappings.PieSegment = "MedalClass";
            this.pieChartDataAdapter1.Mappings.Value = "Quantity";
            measureRules3.RangeDistribution = linearRangeDistribution3;
            measureRules3.RangeStops.Add(10D);
            measureRules3.RangeStops.Add(50D);
            measureRules3.RangeStops.Add(100D);
            measureRules3.RangeStops.Add(500D);
            measureRules3.RangeStops.Add(1000D);
            measureRules3.RangeStops.Add(2000D);
            measureRules3.RangeStops.Add(5000D);
            measureRules3.RangeStops.Add(10000D);
            measureRules3.RangeStops.Add(100000D);
            measureRules3.RangeStops.Add(1000000D);
            this.pieChartDataAdapter1.MeasureRules = measureRules3;
            this.pieChartDataAdapter1.PieItemDataMember = "Name";
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 490);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "FormHome";
            this.Text = "FormHome";
            this.Load += new System.EventHandler(this.FormHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraMap.MapControl mapControl1;
        private DevExpress.XtraMap.ImageLayer imageLayer1;
        private DevExpress.XtraMap.OpenStreetMapDataProvider openStreetMapDataProvider1;
        private DevExpress.XtraMap.VectorItemsLayer analyticalDataLayer;
        private DevExpress.XtraMap.PieChartDataAdapter pieChartDataAdapter1;
    }
}