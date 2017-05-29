namespace service_quan_ly_ton_giao
{
    partial class FormNhapXuatExcel
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
            this.btnNhapFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboDanhSachSheet = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.btnChonFile = new System.Windows.Forms.Button();
            this.oFD = new System.Windows.Forms.OpenFileDialog();
            this.dgvData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.btnNhapFile);
            this.splitContainerControl1.Panel1.Controls.Add(this.label1);
            this.splitContainerControl1.Panel1.Controls.Add(this.cboDanhSachSheet);
            this.splitContainerControl1.Panel1.Controls.Add(this.comboBox1);
            this.splitContainerControl1.Panel1.Controls.Add(this.txtFileName);
            this.splitContainerControl1.Panel1.Controls.Add(this.btnChonFile);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.dgvData);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1025, 440);
            this.splitContainerControl1.SplitterPosition = 129;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // btnNhapFile
            // 
            this.btnNhapFile.Location = new System.Drawing.Point(460, 74);
            this.btnNhapFile.Name = "btnNhapFile";
            this.btnNhapFile.Size = new System.Drawing.Size(75, 44);
            this.btnNhapFile.TabIndex = 4;
            this.btnNhapFile.Text = "Nhập file";
            this.btnNhapFile.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Chọn Bảng";
            // 
            // cboDanhSachSheet
            // 
            this.cboDanhSachSheet.FormattingEnabled = true;
            this.cboDanhSachSheet.Location = new System.Drawing.Point(797, 47);
            this.cboDanhSachSheet.Name = "cboDanhSachSheet";
            this.cboDanhSachSheet.Size = new System.Drawing.Size(161, 21);
            this.cboDanhSachSheet.TabIndex = 2;
            this.cboDanhSachSheet.SelectedIndexChanged += new System.EventHandler(this.cboDanhSachSheet_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Tín Đồ",
            "Cơ Sở"});
            this.comboBox1.Location = new System.Drawing.Point(174, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(246, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(174, 47);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(576, 21);
            this.txtFileName.TabIndex = 1;
            // 
            // btnChonFile
            // 
            this.btnChonFile.Location = new System.Drawing.Point(12, 38);
            this.btnChonFile.Name = "btnChonFile";
            this.btnChonFile.Size = new System.Drawing.Size(114, 37);
            this.btnChonFile.TabIndex = 0;
            this.btnChonFile.Text = "Chọn file Excel";
            this.btnChonFile.UseVisualStyleBackColor = true;
            this.btnChonFile.Click += new System.EventHandler(this.btnChonFile_Click);
            // 
            // oFD
            // 
            this.oFD.FileName = "openFileDialog1";
            this.oFD.FileOk += new System.ComponentModel.CancelEventHandler(this.oFD_FileOk);
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvData.Location = new System.Drawing.Point(0, 0);
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(1025, 306);
            this.dgvData.TabIndex = 0;
            // 
            // FormNhapXuatExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 440);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "FormNhapXuatExcel";
            this.Text = "FormNhapXuatExcel";
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private System.Windows.Forms.Button btnNhapFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboDanhSachSheet;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button btnChonFile;
        private System.Windows.Forms.OpenFileDialog oFD;
        private System.Windows.Forms.DataGridView dgvData;
    }
}