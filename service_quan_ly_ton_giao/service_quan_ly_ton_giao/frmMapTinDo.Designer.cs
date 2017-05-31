namespace service_quan_ly_ton_giao
{
    partial class frmMapTinDo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMapTinDo));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Thành phố trực thuộc Trung ương");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Khu vực địa giới hành chính");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Địa giới hành chính", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            DevExpress.XtraMap.SizeLegend sizeLegend1 = new DevExpress.XtraMap.SizeLegend();
            DevExpress.XtraMap.ColorListLegend colorListLegend1 = new DevExpress.XtraMap.ColorListLegend();
            this.vectorItemsLayer1 = new DevExpress.XtraMap.VectorItemsLayer();
            this.mapItemStorage2 = new DevExpress.XtraMap.MapItemStorage();
            this.openStreetMapDataProvider1 = new DevExpress.XtraMap.OpenStreetMapDataProvider();
            this.mapItemStorage1 = new DevExpress.XtraMap.MapItemStorage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.map = new DevExpress.XtraMap.MapControl();
            this.imageLayer1 = new DevExpress.XtraMap.ImageLayer();
            this.openStreetMapDataProvider2 = new DevExpress.XtraMap.OpenStreetMapDataProvider();
            this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
            this.groupControl5 = new DevExpress.XtraEditors.GroupControl();
            this.txtTenTonGiao = new System.Windows.Forms.TextBox();
            this.btnHoiGiao = new System.Windows.Forms.Button();
            this.btnCaoDai = new System.Windows.Forms.Button();
            this.btnTinLanh = new System.Windows.Forms.Button();
            this.btnCongGiao = new System.Windows.Forms.Button();
            this.btnPhatGiao = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.map)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).BeginInit();
            this.groupControl5.SuspendLayout();
            this.SuspendLayout();
            // 
            // vectorItemsLayer1
            // 
            this.vectorItemsLayer1.Data = this.mapItemStorage2;
            this.vectorItemsLayer1.Name = "VectorLayer";
            this.vectorItemsLayer1.ToolTipPattern = "<b>%A%</b>\r\nPhật giáo: %V0%\r\nCông giáo: %V1%\r\nTổng tín đồ: %V%\"";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer1.Size = new System.Drawing.Size(1185, 595);
            this.splitContainer1.SplitterDistance = 69;
            this.splitContainer1.TabIndex = 1;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupControl1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.groupControl2);
            this.splitContainer2.Size = new System.Drawing.Size(1185, 69);
            this.splitContainer2.SplitterDistance = 1155;
            this.splitContainer2.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.pictureBox1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1155, 69);
            this.groupControl1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Lime;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1151, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupControl2
            // 
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(26, 69);
            this.groupControl2.TabIndex = 1;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.groupControl4);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer3.Size = new System.Drawing.Size(1185, 522);
            this.splitContainer3.SplitterDistance = 240;
            this.splitContainer3.TabIndex = 0;
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.treeView1);
            this.groupControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl4.Location = new System.Drawing.Point(0, 0);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(240, 522);
            this.groupControl4.TabIndex = 1;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.Location = new System.Drawing.Point(2, 20);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "nodecThanhPhoTU";
            treeNode1.Text = "Thành phố trực thuộc Trung ương";
            treeNode2.Name = "nodecKhuVucDiaGioiHanhChinh";
            treeNode2.Text = "Khu vực địa giới hành chính";
            treeNode3.Name = "nodediagioihanhchinh";
            treeNode3.Text = "Địa giới hành chính";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.treeView1.Size = new System.Drawing.Size(236, 500);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.groupControl3);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.groupControl5);
            this.splitContainer4.Size = new System.Drawing.Size(941, 522);
            this.splitContainer4.SplitterDistance = 463;
            this.splitContainer4.TabIndex = 0;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.map);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(0, 0);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(941, 463);
            this.groupControl3.TabIndex = 1;
            // 
            // map
            // 
            this.map.Dock = System.Windows.Forms.DockStyle.Fill;
            this.map.Layers.Add(this.imageLayer1);
            this.map.Layers.Add(this.vectorItemsLayer1);
            sizeLegend1.Header = "Số lượng tín đồ";
            sizeLegend1.Layer = this.vectorItemsLayer1;
            colorListLegend1.Alignment = DevExpress.XtraMap.LegendAlignment.TopRight;
            colorListLegend1.Header = "Tôn giáo";
            colorListLegend1.Layer = this.vectorItemsLayer1;
            this.map.Legends.Add(sizeLegend1);
            this.map.Legends.Add(colorListLegend1);
            this.map.Location = new System.Drawing.Point(2, 20);
            this.map.Name = "map";
            this.map.Size = new System.Drawing.Size(937, 441);
            this.map.TabIndex = 0;
            this.map.ToolTipController = this.toolTipController1;
            // 
            // imageLayer1
            // 
            this.imageLayer1.DataProvider = this.openStreetMapDataProvider2;
            // 
            // toolTipController1
            // 
            this.toolTipController1.AllowHtmlText = true;
            // 
            // groupControl5
            // 
            this.groupControl5.Controls.Add(this.txtTenTonGiao);
            this.groupControl5.Controls.Add(this.btnHoiGiao);
            this.groupControl5.Controls.Add(this.btnCaoDai);
            this.groupControl5.Controls.Add(this.btnTinLanh);
            this.groupControl5.Controls.Add(this.btnCongGiao);
            this.groupControl5.Controls.Add(this.btnPhatGiao);
            this.groupControl5.Controls.Add(this.button1);
            this.groupControl5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl5.Location = new System.Drawing.Point(0, 0);
            this.groupControl5.Name = "groupControl5";
            this.groupControl5.Size = new System.Drawing.Size(941, 55);
            this.groupControl5.TabIndex = 1;
            this.groupControl5.Text = "Tôn giáo";
            // 
            // txtTenTonGiao
            // 
            this.txtTenTonGiao.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtTenTonGiao.Location = new System.Drawing.Point(839, 20);
            this.txtTenTonGiao.Name = "txtTenTonGiao";
            this.txtTenTonGiao.Size = new System.Drawing.Size(100, 21);
            this.txtTenTonGiao.TabIndex = 6;
            // 
            // btnHoiGiao
            // 
            this.btnHoiGiao.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnHoiGiao.Location = new System.Drawing.Point(377, 20);
            this.btnHoiGiao.Name = "btnHoiGiao";
            this.btnHoiGiao.Size = new System.Drawing.Size(75, 33);
            this.btnHoiGiao.TabIndex = 5;
            this.btnHoiGiao.Text = "Hồi giáo";
            this.btnHoiGiao.UseVisualStyleBackColor = true;
            this.btnHoiGiao.Click += new System.EventHandler(this.btnHoiGiao_Click);
            // 
            // btnCaoDai
            // 
            this.btnCaoDai.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCaoDai.Location = new System.Drawing.Point(302, 20);
            this.btnCaoDai.Name = "btnCaoDai";
            this.btnCaoDai.Size = new System.Drawing.Size(75, 33);
            this.btnCaoDai.TabIndex = 4;
            this.btnCaoDai.Text = "Cao Đài";
            this.btnCaoDai.UseVisualStyleBackColor = true;
            this.btnCaoDai.Click += new System.EventHandler(this.btnCaoDai_Click);
            // 
            // btnTinLanh
            // 
            this.btnTinLanh.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnTinLanh.Location = new System.Drawing.Point(227, 20);
            this.btnTinLanh.Name = "btnTinLanh";
            this.btnTinLanh.Size = new System.Drawing.Size(75, 33);
            this.btnTinLanh.TabIndex = 3;
            this.btnTinLanh.Text = "Tin lành";
            this.btnTinLanh.UseVisualStyleBackColor = true;
            this.btnTinLanh.Click += new System.EventHandler(this.btnTinLanh_Click);
            // 
            // btnCongGiao
            // 
            this.btnCongGiao.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCongGiao.Location = new System.Drawing.Point(152, 20);
            this.btnCongGiao.Name = "btnCongGiao";
            this.btnCongGiao.Size = new System.Drawing.Size(75, 33);
            this.btnCongGiao.TabIndex = 2;
            this.btnCongGiao.Text = "Công giáo";
            this.btnCongGiao.UseVisualStyleBackColor = true;
            this.btnCongGiao.Click += new System.EventHandler(this.btnCongGiao_Click);
            // 
            // btnPhatGiao
            // 
            this.btnPhatGiao.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPhatGiao.Location = new System.Drawing.Point(77, 20);
            this.btnPhatGiao.Name = "btnPhatGiao";
            this.btnPhatGiao.Size = new System.Drawing.Size(75, 33);
            this.btnPhatGiao.TabIndex = 1;
            this.btnPhatGiao.Text = "Phật giáo";
            this.btnPhatGiao.UseVisualStyleBackColor = true;
            this.btnPhatGiao.Click += new System.EventHandler(this.btnPhatGiao_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.Location = new System.Drawing.Point(2, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Tất cả";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmMapTinDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 595);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmMapTinDo";
            this.Text = "frmMapTinDo";
            this.Load += new System.EventHandler(this.frmMapTinDo_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.map)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).EndInit();
            this.groupControl5.ResumeLayout(false);
            this.groupControl5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraMap.OpenStreetMapDataProvider openStreetMapDataProvider1;
        private DevExpress.XtraMap.MapItemStorage mapItemStorage1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraMap.MapControl map;
        private DevExpress.XtraEditors.GroupControl groupControl5;
        private System.Windows.Forms.TextBox txtTenTonGiao;
        private System.Windows.Forms.Button btnHoiGiao;
        private System.Windows.Forms.Button btnCaoDai;
        private System.Windows.Forms.Button btnTinLanh;
        private System.Windows.Forms.Button btnCongGiao;
        private System.Windows.Forms.Button btnPhatGiao;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraMap.ImageLayer imageLayer1;
        private DevExpress.XtraMap.OpenStreetMapDataProvider openStreetMapDataProvider2;
        private DevExpress.XtraMap.VectorItemsLayer vectorItemsLayer1;
        private DevExpress.XtraMap.MapItemStorage mapItemStorage2;
        private DevExpress.Utils.ToolTipController toolTipController1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
    }
}