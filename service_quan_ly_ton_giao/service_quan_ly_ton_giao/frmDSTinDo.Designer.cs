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
            this.gridCTinDo = new DevExpress.XtraGrid.GridControl();
            this.gridVTinDo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.PhapDanh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TheDanh = new DevExpress.XtraGrid.Columns.GridColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.gridCTinDo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVTinDo)).BeginInit();
            this.SuspendLayout();
            // 
            // gridCTinDo
            // 
            this.gridCTinDo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCTinDo.Location = new System.Drawing.Point(0, 0);
            this.gridCTinDo.MainView = this.gridVTinDo;
            this.gridCTinDo.Name = "gridCTinDo";
            this.gridCTinDo.Size = new System.Drawing.Size(504, 329);
            this.gridCTinDo.TabIndex = 0;
            this.gridCTinDo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridVTinDo});
            // 
            // gridVTinDo
            // 
            this.gridVTinDo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.PhapDanh,
            this.TheDanh,
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
            this.TheDanh.Caption = "Thế Danh";
            this.TheDanh.FieldName = "TheDanh";
            this.TheDanh.MinWidth = 70;
            this.TheDanh.Name = "TheDanh";
            this.TheDanh.Visible = true;
            this.TheDanh.VisibleIndex = 1;
            this.TheDanh.Width = 70;
            // 
            // NgaySinh
            // 
            this.NgaySinh.Caption = "Ngày Sinh";
            this.NgaySinh.FieldName = "NgaySinh";
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.Visible = true;
            this.NgaySinh.VisibleIndex = 2;
            // 
            // GioiTinh
            // 
            this.GioiTinh.Caption = "Giới Tính";
            this.GioiTinh.FieldName = "GioiTinh";
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.Visible = true;
            this.GioiTinh.VisibleIndex = 3;
            // 
            // QueQuan
            // 
            this.QueQuan.Caption = "Quê Quán";
            this.QueQuan.FieldName = "QueQuan";
            this.QueQuan.MaxWidth = 70;
            this.QueQuan.Name = "QueQuan";
            this.QueQuan.Visible = true;
            this.QueQuan.VisibleIndex = 4;
            this.QueQuan.Width = 70;
            // 
            // DiaChi
            // 
            this.DiaChi.Caption = "Địa Chỉ";
            this.DiaChi.FieldName = "DiaChi";
            this.DiaChi.MaxWidth = 70;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Visible = true;
            this.DiaChi.VisibleIndex = 5;
            this.DiaChi.Width = 70;
            // 
            // TCTichCuc
            // 
            this.TCTichCuc.Caption = "TC Tích Cực";
            this.TCTichCuc.FieldName = "TCTichCuc";
            this.TCTichCuc.Name = "TCTichCuc";
            this.TCTichCuc.Visible = true;
            this.TCTichCuc.VisibleIndex = 6;
            // 
            // TCNguyHiem
            // 
            this.TCNguyHiem.Caption = "TC Nguy Hiểm";
            this.TCNguyHiem.FieldName = "TCNguyHiem";
            this.TCNguyHiem.Name = "TCNguyHiem";
            this.TCNguyHiem.Visible = true;
            this.TCNguyHiem.VisibleIndex = 7;
            // 
            // HinhAnh
            // 
            this.HinhAnh.Caption = "Hình Ảnh";
            this.HinhAnh.FieldName = "HinhAnh";
            this.HinhAnh.Name = "HinhAnh";
            this.HinhAnh.Visible = true;
            this.HinhAnh.VisibleIndex = 8;
            // 
            // HDCaNhan
            // 
            this.HDCaNhan.Caption = "HD Cá Nhân";
            this.HDCaNhan.FieldName = "HDCaNhan";
            this.HDCaNhan.Name = "HDCaNhan";
            this.HDCaNhan.Visible = true;
            this.HDCaNhan.VisibleIndex = 9;
            // 
            // HDToChuc
            // 
            this.HDToChuc.Caption = "HD Tổ CHức";
            this.HDToChuc.FieldName = "HDToChuc";
            this.HDToChuc.Name = "HDToChuc";
            this.HDToChuc.Visible = true;
            this.HDToChuc.VisibleIndex = 10;
            // 
            // NgayVaoTonGiao
            // 
            this.NgayVaoTonGiao.Caption = "Ngày Vào Tôn Giáo";
            this.NgayVaoTonGiao.FieldName = "NgayVaoTonGiao";
            this.NgayVaoTonGiao.Name = "NgayVaoTonGiao";
            this.NgayVaoTonGiao.Visible = true;
            this.NgayVaoTonGiao.VisibleIndex = 11;
            // 
            // frmDSTinDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 329);
            this.Controls.Add(this.gridCTinDo);
            this.Name = "frmDSTinDo";
            this.Text = "frmDSTinDo";
            this.Load += new System.EventHandler(this.frmDSTinDo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCTinDo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVTinDo)).EndInit();
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
    }
}