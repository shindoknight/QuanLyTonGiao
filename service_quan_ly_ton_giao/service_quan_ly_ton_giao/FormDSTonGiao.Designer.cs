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
            this.dgvDSTG = new System.Windows.Forms.DataGridView();
            this.clmTenTG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmGioiThieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSLTinDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmHinhAnh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rtbGioiThieu = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbTenTG = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSLTindo = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.mapControl1 = new DevExpress.XtraMap.MapControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSTG)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).BeginInit();
            this.SuspendLayout();
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
            this.splitContainerControl1.Panel2.Controls.Add(this.mapControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1080, 469);
            this.splitContainerControl1.SplitterPosition = 238;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // dgvDSTG
            // 
            this.dgvDSTG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSTG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmTenTG,
            this.Column2,
            this.clmGioiThieu,
            this.clmSLTinDo,
            this.clmHinhAnh,
            this.Column1});
            this.dgvDSTG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSTG.Location = new System.Drawing.Point(0, 0);
            this.dgvDSTG.Name = "dgvDSTG";
            this.dgvDSTG.Size = new System.Drawing.Size(238, 469);
            this.dgvDSTG.TabIndex = 0;
            this.dgvDSTG.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSTG_CellDoubleClick);
            // 
            // clmTenTG
            // 
            this.clmTenTG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmTenTG.DataPropertyName = "TenTonGiao";
            this.clmTenTG.HeaderText = "Tên Tôn Giáo";
            this.clmTenTG.Name = "clmTenTG";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "DaXoa";
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.Visible = false;
            // 
            // clmGioiThieu
            // 
            this.clmGioiThieu.DataPropertyName = "GioiThieu";
            this.clmGioiThieu.HeaderText = "Giới Thiệu";
            this.clmGioiThieu.Name = "clmGioiThieu";
            this.clmGioiThieu.Visible = false;
            // 
            // clmSLTinDo
            // 
            this.clmSLTinDo.DataPropertyName = "SLTinDo";
            this.clmSLTinDo.HeaderText = "Số Lượng Tín Đồ";
            this.clmSLTinDo.Name = "clmSLTinDo";
            // 
            // clmHinhAnh
            // 
            this.clmHinhAnh.DataPropertyName = "HinhAnh";
            this.clmHinhAnh.HeaderText = "Column1";
            this.clmHinhAnh.Name = "clmHinhAnh";
            this.clmHinhAnh.ReadOnly = true;
            this.clmHinhAnh.Visible = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "IDtonGiao";
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rtbGioiThieu);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.lbTenTG);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtSLTindo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 399);
            this.panel2.TabIndex = 15;
            // 
            // rtbGioiThieu
            // 
            this.rtbGioiThieu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rtbGioiThieu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbGioiThieu.Location = new System.Drawing.Point(0, 154);
            this.rtbGioiThieu.Name = "rtbGioiThieu";
            this.rtbGioiThieu.Size = new System.Drawing.Size(500, 245);
            this.rtbGioiThieu.TabIndex = 9;
            this.rtbGioiThieu.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(174, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Giới Thiệu";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(341, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
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
            this.label2.Location = new System.Drawing.Point(32, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Số lượng tín đồ";
            // 
            // txtSLTindo
            // 
            this.txtSLTindo.Enabled = false;
            this.txtSLTindo.Location = new System.Drawing.Point(162, 79);
            this.txtSLTindo.Name = "txtSLTindo";
            this.txtSLTindo.Size = new System.Drawing.Size(160, 21);
            this.txtSLTindo.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 399);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 70);
            this.panel1.TabIndex = 14;
            // 
            // btnXoa
            // 
            this.btnXoa.Enabled = false;
            this.btnXoa.Image = global::service_quan_ly_ton_giao.Properties.Resources.Remove;
            this.btnXoa.Location = new System.Drawing.Point(313, 15);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(94, 43);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Enabled = false;
            this.btnSua.Image = global::service_quan_ly_ton_giao.Properties.Resources.edit_icon__1_;
            this.btnSua.Location = new System.Drawing.Point(123, 15);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(104, 43);
            this.btnSua.TabIndex = 0;
            this.btnSua.Text = "Chỉnh Sửa";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // mapControl1
            // 
            this.mapControl1.CenterPoint = new DevExpress.XtraMap.GeoPoint(15D, 107D);
            this.mapControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.mapControl1.Location = new System.Drawing.Point(500, 0);
            this.mapControl1.Name = "mapControl1";
            this.mapControl1.Size = new System.Drawing.Size(337, 469);
            this.mapControl1.TabIndex = 12;
            this.mapControl1.ZoomLevel = 5D;
            // 
            // FormDSTonGiao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 469);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "FormDSTonGiao";
            this.Text = "FormDSTonGiao";
            this.Load += new System.EventHandler(this.FormDSTonGiao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSTG)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private System.Windows.Forms.TextBox txtSLTindo;
        private System.Windows.Forms.RichTextBox rtbGioiThieu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTenTG;
        private DevExpress.XtraMap.MapControl mapControl1;
        private System.Windows.Forms.DataGridView dgvDSTG;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTenTG;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmGioiThieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSLTinDo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmHinhAnh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
    }
}