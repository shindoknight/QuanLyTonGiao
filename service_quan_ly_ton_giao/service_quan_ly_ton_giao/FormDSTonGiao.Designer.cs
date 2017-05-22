namespace service_quan_ly_ton_giao
{
    partial class FormDSTonGiao
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
            DevExpress.XtraMap.SizeLegend sizeLegend1 = new DevExpress.XtraMap.SizeLegend();
            DevExpress.XtraMap.ColorListLegend colorListLegend1 = new DevExpress.XtraMap.ColorListLegend();
            this.vectorItemsLayer1 = new DevExpress.XtraMap.VectorItemsLayer();
            this.mapItemStorage1 = new DevExpress.XtraMap.MapItemStorage();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.dgvDSTG = new System.Windows.Forms.DataGridView();
            this.clmTenTG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmGioiThieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSLTinDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmHinhAnh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rtbGioiThieu = new System.Windows.Forms.RichTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.dgvToChuc = new System.Windows.Forms.DataGridView();
            this.clmTenToChuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmGioiThieuTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dgvChucSac = new System.Windows.Forms.DataGridView();
            this.clmTenChucSac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmThongTin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTenTG = new System.Windows.Forms.TextBox();
            this.labelTen = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbTenTG = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSLTindo = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.map = new DevExpress.XtraMap.MapControl();
            this.imageLayer1 = new DevExpress.XtraMap.ImageLayer();
            this.openStreetMapDataProvider1 = new DevExpress.XtraMap.OpenStreetMapDataProvider();
            this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnThemToChuc = new System.Windows.Forms.Button();
            this.btnThemChucSac = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSTG)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvToChuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChucSac)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.map)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // vectorItemsLayer1
            // 
            this.vectorItemsLayer1.Data = this.mapItemStorage1;
            this.vectorItemsLayer1.Name = "VectorLayer";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.dgvDSTG);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.panel2);
            this.splitContainerControl1.Panel2.Controls.Add(this.panel1);
            this.splitContainerControl1.Panel2.Controls.Add(this.map);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1352, 601);
            this.splitContainerControl1.SplitterPosition = 238;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // dgvDSTG
            // 
            this.dgvDSTG.AllowUserToAddRows = false;
            this.dgvDSTG.AllowUserToDeleteRows = false;
            this.dgvDSTG.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvDSTG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSTG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmTenTG,
            this.Column2,
            this.clmGioiThieu,
            this.clmSLTinDo,
            this.clmHinhAnh,
            this.clmID});
            this.dgvDSTG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSTG.Location = new System.Drawing.Point(0, 0);
            this.dgvDSTG.Name = "dgvDSTG";
            this.dgvDSTG.ReadOnly = true;
            this.dgvDSTG.Size = new System.Drawing.Size(238, 601);
            this.dgvDSTG.TabIndex = 0;
            this.dgvDSTG.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSTG_CellDoubleClick);
            this.dgvDSTG.SelectionChanged += new System.EventHandler(this.dgvDSTG_SelectionChanged);
            // 
            // clmTenTG
            // 
            this.clmTenTG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmTenTG.DataPropertyName = "TenTonGiao";
            this.clmTenTG.HeaderText = "Tên Tôn Giáo";
            this.clmTenTG.Name = "clmTenTG";
            this.clmTenTG.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "DaXoa";
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            // 
            // clmGioiThieu
            // 
            this.clmGioiThieu.DataPropertyName = "GioiThieu";
            this.clmGioiThieu.HeaderText = "Giới Thiệu";
            this.clmGioiThieu.Name = "clmGioiThieu";
            this.clmGioiThieu.ReadOnly = true;
            this.clmGioiThieu.Visible = false;
            // 
            // clmSLTinDo
            // 
            this.clmSLTinDo.DataPropertyName = "SoLuongTinDo";
            this.clmSLTinDo.HeaderText = "Số Lượng Tín Đồ";
            this.clmSLTinDo.Name = "clmSLTinDo";
            this.clmSLTinDo.ReadOnly = true;
            // 
            // clmHinhAnh
            // 
            this.clmHinhAnh.DataPropertyName = "HinhAnh";
            this.clmHinhAnh.HeaderText = "Column1";
            this.clmHinhAnh.Name = "clmHinhAnh";
            this.clmHinhAnh.ReadOnly = true;
            this.clmHinhAnh.Visible = false;
            // 
            // clmID
            // 
            this.clmID.DataPropertyName = "IDtonGiao";
            this.clmID.HeaderText = "Column1";
            this.clmID.Name = "clmID";
            this.clmID.ReadOnly = true;
            this.clmID.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rtbGioiThieu);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.txtTenTG);
            this.panel2.Controls.Add(this.labelTen);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.lbTenTG);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtSLTindo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(726, 531);
            this.panel2.TabIndex = 15;
            // 
            // rtbGioiThieu
            // 
            this.rtbGioiThieu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rtbGioiThieu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbGioiThieu.Location = new System.Drawing.Point(0, 162);
            this.rtbGioiThieu.Name = "rtbGioiThieu";
            this.rtbGioiThieu.Size = new System.Drawing.Size(726, 169);
            this.rtbGioiThieu.TabIndex = 17;
            this.rtbGioiThieu.Text = "";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupControl2);
            this.panel3.Controls.Add(this.groupControl1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 331);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(726, 200);
            this.panel3.TabIndex = 16;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.dgvToChuc);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(396, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(330, 200);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "Hệ thống Tổ chức quản trị";
            // 
            // dgvToChuc
            // 
            this.dgvToChuc.AllowUserToAddRows = false;
            this.dgvToChuc.AllowUserToDeleteRows = false;
            this.dgvToChuc.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvToChuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvToChuc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmTenToChuc,
            this.clmGioiThieuTC});
            this.dgvToChuc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvToChuc.Location = new System.Drawing.Point(2, 20);
            this.dgvToChuc.Name = "dgvToChuc";
            this.dgvToChuc.ReadOnly = true;
            this.dgvToChuc.Size = new System.Drawing.Size(326, 178);
            this.dgvToChuc.TabIndex = 0;
            // 
            // clmTenToChuc
            // 
            this.clmTenToChuc.DataPropertyName = "TenToChuc";
            this.clmTenToChuc.HeaderText = "Tên Tổ Chức";
            this.clmTenToChuc.Name = "clmTenToChuc";
            this.clmTenToChuc.ReadOnly = true;
            // 
            // clmGioiThieuTC
            // 
            this.clmGioiThieuTC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmGioiThieuTC.DataPropertyName = "GioiThieu";
            this.clmGioiThieuTC.HeaderText = "Giới Thiệu";
            this.clmGioiThieuTC.Name = "clmGioiThieuTC";
            this.clmGioiThieuTC.ReadOnly = true;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.dgvChucSac);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(396, 200);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Hệ thống chức sắc";
            // 
            // dgvChucSac
            // 
            this.dgvChucSac.AllowUserToAddRows = false;
            this.dgvChucSac.AllowUserToDeleteRows = false;
            this.dgvChucSac.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvChucSac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChucSac.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmTenChucSac,
            this.clmThongTin});
            this.dgvChucSac.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChucSac.Location = new System.Drawing.Point(2, 20);
            this.dgvChucSac.Name = "dgvChucSac";
            this.dgvChucSac.ReadOnly = true;
            this.dgvChucSac.Size = new System.Drawing.Size(392, 178);
            this.dgvChucSac.TabIndex = 0;
            // 
            // clmTenChucSac
            // 
            this.clmTenChucSac.DataPropertyName = "TenChucSac";
            this.clmTenChucSac.HeaderText = "Tên Chức Sắc";
            this.clmTenChucSac.Name = "clmTenChucSac";
            this.clmTenChucSac.ReadOnly = true;
            // 
            // clmThongTin
            // 
            this.clmThongTin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmThongTin.DataPropertyName = "GioiThieu";
            this.clmThongTin.HeaderText = "Thông Tin";
            this.clmThongTin.Name = "clmThongTin";
            this.clmThongTin.ReadOnly = true;
            // 
            // txtTenTG
            // 
            this.txtTenTG.Location = new System.Drawing.Point(162, 17);
            this.txtTenTG.Name = "txtTenTG";
            this.txtTenTG.Size = new System.Drawing.Size(160, 21);
            this.txtTenTG.TabIndex = 15;
            this.txtTenTG.Visible = false;
            // 
            // labelTen
            // 
            this.labelTen.AutoSize = true;
            this.labelTen.Location = new System.Drawing.Point(42, 17);
            this.labelTen.Name = "labelTen";
            this.labelTen.Size = new System.Drawing.Size(69, 13);
            this.labelTen.TabIndex = 14;
            this.labelTen.Text = "Tên Tôn giáo";
            this.labelTen.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Giới Thiệu";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbTenTG
            // 
            this.lbTenTG.AutoSize = true;
            this.lbTenTG.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenTG.ForeColor = System.Drawing.Color.Brown;
            this.lbTenTG.Location = new System.Drawing.Point(138, 12);
            this.lbTenTG.Name = "lbTenTG";
            this.lbTenTG.Size = new System.Drawing.Size(44, 24);
            this.lbTenTG.TabIndex = 8;
            this.lbTenTG.Text = "Tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Số lượng tín đồ";
            // 
            // txtSLTindo
            // 
            this.txtSLTindo.Enabled = false;
            this.txtSLTindo.Location = new System.Drawing.Point(162, 44);
            this.txtSLTindo.Name = "txtSLTindo";
            this.txtSLTindo.Size = new System.Drawing.Size(160, 21);
            this.txtSLTindo.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnThemToChuc);
            this.panel1.Controls.Add(this.btnThemChucSac);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.btnLoad);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 531);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(726, 70);
            this.panel1.TabIndex = 14;
            // 
            // map
            // 
            this.map.CenterPoint = new DevExpress.XtraMap.GeoPoint(15D, 107D);
            this.map.Dock = System.Windows.Forms.DockStyle.Right;
            this.map.Layers.Add(this.imageLayer1);
            this.map.Layers.Add(this.vectorItemsLayer1);
            sizeLegend1.Layer = this.vectorItemsLayer1;
            colorListLegend1.Layer = this.vectorItemsLayer1;
            this.map.Legends.Add(sizeLegend1);
            this.map.Legends.Add(colorListLegend1);
            this.map.Location = new System.Drawing.Point(726, 0);
            this.map.Name = "map";
            this.map.Size = new System.Drawing.Size(383, 601);
            this.map.TabIndex = 12;
            this.map.ToolTipController = this.toolTipController1;
            this.map.ZoomLevel = 5D;
            // 
            // imageLayer1
            // 
            this.imageLayer1.DataProvider = this.openStreetMapDataProvider1;
            // 
            // toolTipController1
            // 
            this.toolTipController1.AllowHtmlText = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(387, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // btnThemToChuc
            // 
            this.btnThemToChuc.Image = global::service_quan_ly_ton_giao.Properties.Resources.Add;
            this.btnThemToChuc.Location = new System.Drawing.Point(638, 15);
            this.btnThemToChuc.Name = "btnThemToChuc";
            this.btnThemToChuc.Size = new System.Drawing.Size(82, 43);
            this.btnThemToChuc.TabIndex = 1;
            this.btnThemToChuc.Text = "Thêm tổ chức";
            this.btnThemToChuc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThemToChuc.UseVisualStyleBackColor = true;
            this.btnThemToChuc.Visible = false;
            this.btnThemToChuc.Click += new System.EventHandler(this.btnThemToChuc_Click);
            // 
            // btnThemChucSac
            // 
            this.btnThemChucSac.Image = global::service_quan_ly_ton_giao.Properties.Resources.Actions_list_add_icon__1_;
            this.btnThemChucSac.Location = new System.Drawing.Point(511, 15);
            this.btnThemChucSac.Name = "btnThemChucSac";
            this.btnThemChucSac.Size = new System.Drawing.Size(91, 43);
            this.btnThemChucSac.TabIndex = 1;
            this.btnThemChucSac.Text = "Thêm Chức sắc";
            this.btnThemChucSac.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThemChucSac.UseVisualStyleBackColor = true;
            this.btnThemChucSac.Visible = false;
            // 
            // btnXoa
            // 
            this.btnXoa.Enabled = false;
            this.btnXoa.Image = global::service_quan_ly_ton_giao.Properties.Resources.Remove;
            this.btnXoa.Location = new System.Drawing.Point(413, 15);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(74, 43);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Enabled = false;
            this.btnLuu.Image = global::service_quan_ly_ton_giao.Properties.Resources.Floppy_Small_icon__1_;
            this.btnLuu.Location = new System.Drawing.Point(298, 15);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(80, 43);
            this.btnLuu.TabIndex = 0;
            this.btnLuu.Text = "Lưu Lại";
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Enabled = false;
            this.btnLoad.Image = global::service_quan_ly_ton_giao.Properties.Resources.Button_Refresh_icon__1_;
            this.btnLoad.Location = new System.Drawing.Point(13, 15);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(98, 43);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Refresh";
            this.btnLoad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSua
            // 
            this.btnSua.Enabled = false;
            this.btnSua.Image = global::service_quan_ly_ton_giao.Properties.Resources.edit_icon__1_;
            this.btnSua.Location = new System.Drawing.Point(142, 15);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(108, 43);
            this.btnSua.TabIndex = 0;
            this.btnSua.Text = "Chỉnh Sửa";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // FormDSTonGiao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 601);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "FormDSTonGiao";
            this.Text = "FormDSTonGiao";
            this.Load += new System.EventHandler(this.FormDSTonGiao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSTG)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvToChuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChucSac)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.map)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private System.Windows.Forms.TextBox txtSLTindo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTenTG;
        private DevExpress.XtraMap.MapControl map;
        private System.Windows.Forms.DataGridView dgvDSTG;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.TextBox txtTenTG;
        private System.Windows.Forms.Label labelTen;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTenTG;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmGioiThieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSLTinDo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmHinhAnh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmID;
        private System.Windows.Forms.RichTextBox rtbGioiThieu;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.DataGridView dgvToChuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTenToChuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmGioiThieuTC;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.DataGridView dgvChucSac;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTenChucSac;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmThongTin;
        private System.Windows.Forms.Button btnThemToChuc;
        private System.Windows.Forms.Button btnThemChucSac;
        private DevExpress.XtraMap.ImageLayer imageLayer1;
        private DevExpress.XtraMap.OpenStreetMapDataProvider openStreetMapDataProvider1;
        private DevExpress.XtraMap.VectorItemsLayer vectorItemsLayer1;
        private DevExpress.XtraMap.MapItemStorage mapItemStorage1;
        private DevExpress.Utils.ToolTipController toolTipController1;
        private System.Windows.Forms.Button btnLoad;
    }
}