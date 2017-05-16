namespace service_quan_ly_ton_giao
{
    partial class FormThemTonGiao
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
            this.txtTenTG = new System.Windows.Forms.TextBox();
            this.labelTen = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnChonFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnXong = new System.Windows.Forms.Button();
            this.rtbGioiThieu = new System.Windows.Forms.RichTextBox();
            this.btnNhapLai = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTenTG
            // 
            this.txtTenTG.Location = new System.Drawing.Point(145, 87);
            this.txtTenTG.Name = "txtTenTG";
            this.txtTenTG.Size = new System.Drawing.Size(160, 25);
            this.txtTenTG.TabIndex = 23;
            // 
            // labelTen
            // 
            this.labelTen.AutoSize = true;
            this.labelTen.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTen.Location = new System.Drawing.Point(17, 90);
            this.labelTen.Name = "labelTen";
            this.labelTen.Size = new System.Drawing.Size(86, 17);
            this.labelTen.TabIndex = 22;
            this.labelTen.Text = "Tên Tôn giáo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(101, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 19);
            this.label4.TabIndex = 16;
            this.label4.Text = "Giới Thiệu";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnChonFile);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.labelTen);
            this.groupBox1.Controls.Add(this.txtTenTG);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(746, 195);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin Tôn Giáo";
            // 
            // btnChonFile
            // 
            this.btnChonFile.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonFile.Location = new System.Drawing.Point(558, 151);
            this.btnChonFile.Name = "btnChonFile";
            this.btnChonFile.Size = new System.Drawing.Size(116, 38);
            this.btnChonFile.TabIndex = 24;
            this.btnChonFile.Text = "Chọn File";
            this.btnChonFile.UseVisualStyleBackColor = true;
            this.btnChonFile.Click += new System.EventHandler(this.btnChonFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(426, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Hình Ảnh";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(546, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnNhapLai);
            this.panel1.Controls.Add(this.btnXong);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 311);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(746, 53);
            this.panel1.TabIndex = 25;
            // 
            // btnXong
            // 
            this.btnXong.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXong.Image = global::service_quan_ly_ton_giao.Properties.Resources.Floppy_Small_icon__1_;
            this.btnXong.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnXong.Location = new System.Drawing.Point(424, 6);
            this.btnXong.Name = "btnXong";
            this.btnXong.Size = new System.Drawing.Size(67, 35);
            this.btnXong.TabIndex = 24;
            this.btnXong.Text = "Xong";
            this.btnXong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXong.UseVisualStyleBackColor = true;
            this.btnXong.Click += new System.EventHandler(this.btnXong_Click);
            // 
            // rtbGioiThieu
            // 
            this.rtbGioiThieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbGioiThieu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbGioiThieu.Location = new System.Drawing.Point(0, 195);
            this.rtbGioiThieu.Name = "rtbGioiThieu";
            this.rtbGioiThieu.Size = new System.Drawing.Size(746, 116);
            this.rtbGioiThieu.TabIndex = 26;
            this.rtbGioiThieu.Text = "";
            // 
            // btnNhapLai
            // 
            this.btnNhapLai.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapLai.Image = global::service_quan_ly_ton_giao.Properties.Resources.Remove;
            this.btnNhapLai.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnNhapLai.Location = new System.Drawing.Point(211, 6);
            this.btnNhapLai.Name = "btnNhapLai";
            this.btnNhapLai.Size = new System.Drawing.Size(94, 35);
            this.btnNhapLai.TabIndex = 24;
            this.btnNhapLai.Text = "Nhập lại";
            this.btnNhapLai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNhapLai.UseVisualStyleBackColor = true;
            this.btnNhapLai.Click += new System.EventHandler(this.btnNhapLai_Click);
            // 
            // FormThemTonGiao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 364);
            this.Controls.Add(this.rtbGioiThieu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormThemTonGiao";
            this.Text = "FormThemTonGiao";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtTenTG;
        private System.Windows.Forms.Label labelTen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnChonFile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox rtbGioiThieu;
        private System.Windows.Forms.Button btnXong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNhapLai;
    }
}