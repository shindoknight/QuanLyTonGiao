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
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gvTonGiao = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clmTenTG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmGioiThieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmHinhAnh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmSTTinDo = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTonGiao)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gridControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(757, 379);
            this.splitContainerControl1.SplitterPosition = 449;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gvTonGiao;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(303, 379);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTonGiao});
            // 
            // gvTonGiao
            // 
            this.gvTonGiao.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.clmTenTG,
            this.clmGioiThieu,
            this.clmHinhAnh,
            this.clmSTTinDo});
            this.gvTonGiao.GridControl = this.gridControl1;
            this.gvTonGiao.Name = "gvTonGiao";
            this.gvTonGiao.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            // 
            // clmTenTG
            // 
            this.clmTenTG.Caption = "Tên Tôn Giáo";
            this.clmTenTG.FieldName = "TenTonGiao";
            this.clmTenTG.Name = "clmTenTG";
            this.clmTenTG.Visible = true;
            this.clmTenTG.VisibleIndex = 0;
            // 
            // clmGioiThieu
            // 
            this.clmGioiThieu.Caption = "Giới thiệu";
            this.clmGioiThieu.FieldName = "GioiThieu";
            this.clmGioiThieu.Name = "clmGioiThieu";
            this.clmGioiThieu.Visible = true;
            this.clmGioiThieu.VisibleIndex = 1;
            // 
            // clmHinhAnh
            // 
            this.clmHinhAnh.Caption = "Hình Ảnh";
            this.clmHinhAnh.Name = "clmHinhAnh";
            this.clmHinhAnh.Visible = true;
            this.clmHinhAnh.VisibleIndex = 2;
            // 
            // clmSTTinDo
            // 
            this.clmSTTinDo.Caption = "Số Lượng Tín Đồ";
            this.clmSTTinDo.FieldName = "SLTinDo";
            this.clmSTTinDo.Name = "clmSTTinDo";
            this.clmSTTinDo.Visible = true;
            this.clmSTTinDo.VisibleIndex = 3;
            // 
            // FormDSTonGiao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 379);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "FormDSTonGiao";
            this.Text = "FormDSTonGiao";
            this.Load += new System.EventHandler(this.FormDSTonGiao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTonGiao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTonGiao;
        private DevExpress.XtraGrid.Columns.GridColumn clmTenTG;
        private DevExpress.XtraGrid.Columns.GridColumn clmGioiThieu;
        private DevExpress.XtraGrid.Columns.GridColumn clmHinhAnh;
        private DevExpress.XtraGrid.Columns.GridColumn clmSTTinDo;
    }
}