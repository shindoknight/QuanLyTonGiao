namespace service_quan_ly_ton_giao
{
    partial class FormUser
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.btnChonFile = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnDoiMK = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMKCu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMKMoi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtXNMK = new System.Windows.Forms.TextBox();
            this.lbTittle = new System.Windows.Forms.Label();
            this.btnXong = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Đăng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ngày sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Email";
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Location = new System.Drawing.Point(194, 100);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(318, 20);
            this.txtTenDangNhap.TabIndex = 1;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(194, 147);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(318, 20);
            this.txtHoTen.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(194, 244);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(318, 20);
            this.txtEmail.TabIndex = 4;
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(194, 197);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Size = new System.Drawing.Size(318, 20);
            this.dateEdit1.TabIndex = 3;
            // 
            // btnChonFile
            // 
            this.btnChonFile.Location = new System.Drawing.Point(738, 251);
            this.btnChonFile.Name = "btnChonFile";
            this.btnChonFile.Size = new System.Drawing.Size(75, 23);
            this.btnChonFile.TabIndex = 5;
            this.btnChonFile.Text = "Chọn File";
            this.btnChonFile.UseVisualStyleBackColor = true;
            this.btnChonFile.Click += new System.EventHandler(this.btnChonFile_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Image = global::service_quan_ly_ton_giao.Properties.Resources.Floppy_Small_icon__1_;
            this.btnLuu.Location = new System.Drawing.Point(432, 485);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 51);
            this.btnLuu.TabIndex = 6;
            this.btnLuu.Text = "Lưu lại";
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnDoiMK
            // 
            this.btnDoiMK.Image = global::service_quan_ly_ton_giao.Properties.Resources.Apps_preferences_desktop_user_password_icon;
            this.btnDoiMK.Location = new System.Drawing.Point(241, 485);
            this.btnDoiMK.Name = "btnDoiMK";
            this.btnDoiMK.Size = new System.Drawing.Size(92, 51);
            this.btnDoiMK.TabIndex = 6;
            this.btnDoiMK.Text = "Đổi mật khẩu";
            this.btnDoiMK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDoiMK.UseVisualStyleBackColor = true;
            this.btnDoiMK.Click += new System.EventHandler(this.btnDoiMK_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(679, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Mật khẩu cũ";
            this.label5.Visible = false;
            // 
            // txtMKCu
            // 
            this.txtMKCu.Location = new System.Drawing.Point(194, 297);
            this.txtMKCu.Name = "txtMKCu";
            this.txtMKCu.PasswordChar = '*';
            this.txtMKCu.Size = new System.Drawing.Size(318, 20);
            this.txtMKCu.TabIndex = 2;
            this.txtMKCu.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 356);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Mật khẩu mới";
            this.label6.Visible = false;
            // 
            // txtMKMoi
            // 
            this.txtMKMoi.Location = new System.Drawing.Point(194, 349);
            this.txtMKMoi.Name = "txtMKMoi";
            this.txtMKMoi.PasswordChar = '☼';
            this.txtMKMoi.Size = new System.Drawing.Size(318, 20);
            this.txtMKMoi.TabIndex = 5;
            this.txtMKMoi.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 409);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Xác nhận mật khẩu mới";
            this.label7.Visible = false;
            // 
            // txtXNMK
            // 
            this.txtXNMK.Location = new System.Drawing.Point(194, 402);
            this.txtXNMK.Name = "txtXNMK";
            this.txtXNMK.PasswordChar = '☼';
            this.txtXNMK.Size = new System.Drawing.Size(318, 20);
            this.txtXNMK.TabIndex = 6;
            this.txtXNMK.Visible = false;
            // 
            // lbTittle
            // 
            this.lbTittle.AutoSize = true;
            this.lbTittle.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTittle.Location = new System.Drawing.Point(367, 18);
            this.lbTittle.Name = "lbTittle";
            this.lbTittle.Size = new System.Drawing.Size(168, 22);
            this.lbTittle.TabIndex = 7;
            this.lbTittle.Text = "Đăng ký Tài khoản";
            // 
            // btnXong
            // 
            this.btnXong.Image = global::service_quan_ly_ton_giao.Properties.Resources.Floppy_Small_icon__1_;
            this.btnXong.Location = new System.Drawing.Point(620, 485);
            this.btnXong.Name = "btnXong";
            this.btnXong.Size = new System.Drawing.Size(75, 51);
            this.btnXong.TabIndex = 6;
            this.btnXong.Text = "Xong";
            this.btnXong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnXong.UseVisualStyleBackColor = true;
            this.btnXong.Click += new System.EventHandler(this.btnXong_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Admin",
            "Nhân Viên Quản Lý",
            "Người Dùng"});
            this.comboBox1.Location = new System.Drawing.Point(194, 443);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(318, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(51, 451);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Nhóm";
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 559);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lbTittle);
            this.Controls.Add(this.btnXong);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnDoiMK);
            this.Controls.Add(this.btnChonFile);
            this.Controls.Add(this.dateEdit1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtXNMK);
            this.Controls.Add(this.txtMKMoi);
            this.Controls.Add(this.txtMKCu);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTenDangNhap);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormUser";
            this.Text = "FormUser";
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private System.Windows.Forms.Button btnChonFile;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnDoiMK;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMKCu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMKMoi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtXNMK;
        private System.Windows.Forms.Label lbTittle;
        private System.Windows.Forms.Button btnXong;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
    }
}