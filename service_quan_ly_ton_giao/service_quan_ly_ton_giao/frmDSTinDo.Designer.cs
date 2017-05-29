namespace service_quan_ly_ton_giao
{
    partial class frmDSTinDo
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDSTinDo));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Thành phố trực thuộc Trung ương");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Khu vực địa giới hành chính");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Địa giới hành chính", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            this.gridCTinDo = new DevExpress.XtraGrid.GridControl();
            this.gridVTinDo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.PhapDanh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TheDanh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HoDemTheDanh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgaySinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GioiTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.QueQuan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TCTichCuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TCNguyHiem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HinhAnh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HDCaNhan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HDToChuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayVaoTonGiao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.bntXoa = new System.Windows.Forms.Button();
            this.bntSua = new System.Windows.Forms.Button();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.cboTonGiao = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridCTinDo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVTinDo)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridCTinDo
            // 
            this.gridCTinDo.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "Level1";
            this.gridCTinDo.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridCTinDo.Location = new System.Drawing.Point(3, 17);
            this.gridCTinDo.MainView = this.gridVTinDo;
            this.gridCTinDo.Name = "gridCTinDo";
            this.gridCTinDo.Size = new System.Drawing.Size(926, 489);
            this.gridCTinDo.TabIndex = 0;
            this.gridCTinDo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridVTinDo});
            this.gridCTinDo.Click += new System.EventHandler(this.gridCTinDo_Click);
            this.gridCTinDo.DoubleClick += new System.EventHandler(this.gridCTinDo_DoubleClick);
            this.gridCTinDo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gridCTinDo_MouseClick);
            this.gridCTinDo.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridCTinDo_MouseDoubleClick);
            // 
            // gridVTinDo
            // 
            this.gridVTinDo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.PhapDanh,
            this.TheDanh,
            this.HoDemTheDanh,
            this.NgaySinh,
            this.GioiTinh,
            this.QueQuan,
            this.DiaChi,
            this.TCTichCuc,
            this.TCNguyHiem,
            this.HinhAnh,
            this.HDCaNhan,
            this.HDToChuc,
            this.NgayVaoTonGiao});
            this.gridVTinDo.GridControl = this.gridCTinDo;
            this.gridVTinDo.Name = "gridVTinDo";
            this.gridVTinDo.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            // 
            // PhapDanh
            // 
            this.PhapDanh.Caption = "Pháp Danh";
            this.PhapDanh.FieldName = "PhapDanh";
            this.PhapDanh.MinWidth = 70;
            this.PhapDanh.Name = "PhapDanh";
            this.PhapDanh.Visible = true;
            this.PhapDanh.VisibleIndex = 0;
            this.PhapDanh.Width = 70;
            // 
            // TheDanh
            // 
            this.TheDanh.Caption = "Tên Thế Danh";
            this.TheDanh.FieldName = "TenTheDanh";
            this.TheDanh.MinWidth = 70;
            this.TheDanh.Name = "TheDanh";
            this.TheDanh.Visible = true;
            this.TheDanh.VisibleIndex = 2;
            this.TheDanh.Width = 70;
            // 
            // HoDemTheDanh
            // 
            this.HoDemTheDanh.Caption = "Họ Đệm";
            this.HoDemTheDanh.FieldName = "HoDemTheDanh";
            this.HoDemTheDanh.Name = "HoDemTheDanh";
            this.HoDemTheDanh.Visible = true;
            this.HoDemTheDanh.VisibleIndex = 1;
            // 
            // NgaySinh
            // 
            this.NgaySinh.Caption = "Ngày Sinh";
            this.NgaySinh.FieldName = "NgaySinh";
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.Visible = true;
            this.NgaySinh.VisibleIndex = 3;
            // 
            // GioiTinh
            // 
            this.GioiTinh.Caption = "Giới Tính";
            this.GioiTinh.FieldName = "GioiTinh";
            this.GioiTinh.Name = "GioiTinh";
            // 
            // QueQuan
            // 
            this.QueQuan.Caption = "Quê Quán";
            this.QueQuan.FieldName = "QueQuan";
            this.QueQuan.MaxWidth = 70;
            this.QueQuan.Name = "QueQuan";
            this.QueQuan.Width = 70;
            // 
            // DiaChi
            // 
            this.DiaChi.Caption = "Địa Chỉ";
            this.DiaChi.FieldName = "DiaChi";
            this.DiaChi.MaxWidth = 70;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Width = 70;
            // 
            // TCTichCuc
            // 
            this.TCTichCuc.Caption = "TC Tích Cực";
            this.TCTichCuc.FieldName = "TCTichCuc";
            this.TCTichCuc.Name = "TCTichCuc";
            this.TCTichCuc.Visible = true;
            this.TCTichCuc.VisibleIndex = 4;
            // 
            // TCNguyHiem
            // 
            this.TCNguyHiem.Caption = "TC Nguy Hiểm";
            this.TCNguyHiem.FieldName = "TCNguyHiem";
            this.TCNguyHiem.Name = "TCNguyHiem";
            this.TCNguyHiem.Visible = true;
            this.TCNguyHiem.VisibleIndex = 5;
            // 
            // HinhAnh
            // 
            this.HinhAnh.Caption = "Hình Ảnh";
            this.HinhAnh.FieldName = "HinhAnh";
            this.HinhAnh.Name = "HinhAnh";
            // 
            // HDCaNhan
            // 
            this.HDCaNhan.Caption = "HD Cá Nhân";
            this.HDCaNhan.FieldName = "HDCaNhan";
            this.HDCaNhan.Name = "HDCaNhan";
            this.HDCaNhan.Visible = true;
            this.HDCaNhan.VisibleIndex = 6;
            // 
            // HDToChuc
            // 
            this.HDToChuc.Caption = "HD Tổ CHức";
            this.HDToChuc.FieldName = "HDToChuc";
            this.HDToChuc.Name = "HDToChuc";
            this.HDToChuc.Visible = true;
            this.HDToChuc.VisibleIndex = 7;
            // 
            // NgayVaoTonGiao
            // 
            this.NgayVaoTonGiao.Caption = "Ngày Vào Tôn Giáo";
            this.NgayVaoTonGiao.FieldName = "NgayVaoTonGiao";
            this.NgayVaoTonGiao.Name = "NgayVaoTonGiao";
            this.NgayVaoTonGiao.Visible = true;
            this.NgayVaoTonGiao.VisibleIndex = 8;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.Image = global::service_quan_ly_ton_giao.Properties.Resources.Button_Refresh_icon__1_;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 60);
            this.button1.TabIndex = 1;
            this.button1.Text = "Refresh";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.splitContainer1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(932, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 509);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thuộc Tính";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 17);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.bntXoa);
            this.splitContainer1.Panel1.Controls.Add(this.bntSua);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupControl1);
            this.splitContainer1.Size = new System.Drawing.Size(283, 489);
            this.splitContainer1.SplitterDistance = 60;
            this.splitContainer1.TabIndex = 2;
            // 
            // bntXoa
            // 
            this.bntXoa.Dock = System.Windows.Forms.DockStyle.Left;
            this.bntXoa.Enabled = false;
            this.bntXoa.Image = ((System.Drawing.Image)(resources.GetObject("bntXoa.Image")));
            this.bntXoa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bntXoa.Location = new System.Drawing.Point(190, 0);
            this.bntXoa.Name = "bntXoa";
            this.bntXoa.Size = new System.Drawing.Size(84, 60);
            this.bntXoa.TabIndex = 3;
            this.bntXoa.Text = "Xóa";
            this.bntXoa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bntXoa.UseVisualStyleBackColor = true;
            this.bntXoa.Click += new System.EventHandler(this.bntXoa_Click);
            // 
            // bntSua
            // 
            this.bntSua.Dock = System.Windows.Forms.DockStyle.Left;
            this.bntSua.Enabled = false;
            this.bntSua.Image = ((System.Drawing.Image)(resources.GetObject("bntSua.Image")));
            this.bntSua.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bntSua.Location = new System.Drawing.Point(101, 0);
            this.bntSua.Name = "bntSua";
            this.bntSua.Size = new System.Drawing.Size(89, 60);
            this.bntSua.TabIndex = 2;
            this.bntSua.Text = "Sửa";
            this.bntSua.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bntSua.UseVisualStyleBackColor = true;
            this.bntSua.Click += new System.EventHandler(this.bntSua_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.splitContainer2);
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(283, 425);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Tìm Kiếm";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(2, 20);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.cboTonGiao);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.treeView1);
            this.splitContainer2.Size = new System.Drawing.Size(279, 403);
            this.splitContainer2.SplitterDistance = 43;
            this.splitContainer2.TabIndex = 0;
            // 
            // cboTonGiao
            // 
            this.cboTonGiao.FormattingEnabled = true;
            this.cboTonGiao.Items.AddRange(new object[] {
            "Tất cả"});
            this.cboTonGiao.Location = new System.Drawing.Point(99, 10);
            this.cboTonGiao.Name = "cboTonGiao";
            this.cboTonGiao.Size = new System.Drawing.Size(121, 21);
            this.cboTonGiao.TabIndex = 1;
            this.cboTonGiao.TextChanged += new System.EventHandler(this.cboTonGiao_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tôn giáo";
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "nodecThanhPhoTU";
            treeNode1.Text = "Thành phố trực thuộc Trung ương";
            treeNode2.Name = "nodecKhuVucDiaGioiHanhChinh";
            treeNode2.Text = "Khu vực địa giới hành chính";
            treeNode3.Name = "nodediagioihanhchinh";
            treeNode3.Text = "Địa giới hành chính";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.treeView1.Size = new System.Drawing.Size(279, 356);
            this.treeView1.TabIndex = 1;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gridCTinDo);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(932, 509);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Tín Đồ";
            // 
            // frmDSTinDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 509);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.Name = "frmDSTinDo";
            this.Text = "frmDSTinDo";
            this.Load += new System.EventHandler(this.frmDSTinDo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCTinDo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVTinDo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridCTinDo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridVTinDo;
        private DevExpress.XtraGrid.Columns.GridColumn PhapDanh;
        private DevExpress.XtraGrid.Columns.GridColumn TheDanh;
        private DevExpress.XtraGrid.Columns.GridColumn NgaySinh;
        private DevExpress.XtraGrid.Columns.GridColumn GioiTinh;
        private DevExpress.XtraGrid.Columns.GridColumn QueQuan;
        private DevExpress.XtraGrid.Columns.GridColumn DiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn TCTichCuc;
        private DevExpress.XtraGrid.Columns.GridColumn TCNguyHiem;
        private DevExpress.XtraGrid.Columns.GridColumn HinhAnh;
        private DevExpress.XtraGrid.Columns.GridColumn HDCaNhan;
        private DevExpress.XtraGrid.Columns.GridColumn HDToChuc;
        private DevExpress.XtraGrid.Columns.GridColumn NgayVaoTonGiao;
        private DevExpress.XtraGrid.Columns.GridColumn HoDemTheDanh;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button bntXoa;
        private System.Windows.Forms.Button bntSua;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ComboBox cboTonGiao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView treeView1;
    }
}