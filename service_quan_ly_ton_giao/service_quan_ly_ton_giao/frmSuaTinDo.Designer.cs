namespace service_quan_ly_ton_giao
{
    partial class frmSuaTinDo
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
            this.dtNgayVaoTonGiao = new System.Windows.Forms.DateTimePicker();
            this.txtNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.cbbCoSo = new System.Windows.Forms.ComboBox();
            this.cbbChucVu = new System.Windows.Forms.ComboBox();
            this.cbbChucSac = new System.Windows.Forms.ComboBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbQueQuanXa = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.cbQueQuanHuyen = new System.Windows.Forms.ComboBox();
            this.cbQueQuanTinh = new System.Windows.Forms.ComboBox();
            this.txtMatDao = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.cbDiaChiXa = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.cbDiaChiHuyen = new System.Windows.Forms.ComboBox();
            this.cbDiaChiTinh = new System.Windows.Forms.ComboBox();
            this.cbDanToc = new System.Windows.Forms.ComboBox();
            this.txtPhapDanh = new System.Windows.Forms.TextBox();
            this.txtHdCaNhan = new System.Windows.Forms.TextBox();
            this.txtMatDoi = new System.Windows.Forms.TextBox();
            this.txtTcNguyHiem = new System.Windows.Forms.TextBox();
            this.txtTcTichCuc = new System.Windows.Forms.TextBox();
            this.txtTaiChinh = new System.Windows.Forms.TextBox();
            this.txtDhToChuc = new System.Windows.Forms.TextBox();
            this.txtTheDanh = new System.Windows.Forms.TextBox();
            this.txtNgayVaoTonGiao = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSucKhoe = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtNgayVaoTonGiao
            // 
            this.dtNgayVaoTonGiao.CustomFormat = "MM/dd/yyyy";
            this.dtNgayVaoTonGiao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayVaoTonGiao.Location = new System.Drawing.Point(652, 90);
            this.dtNgayVaoTonGiao.Name = "dtNgayVaoTonGiao";
            this.dtNgayVaoTonGiao.Size = new System.Drawing.Size(157, 20);
            this.dtNgayVaoTonGiao.TabIndex = 167;
            this.dtNgayVaoTonGiao.Value = new System.DateTime(2017, 6, 14, 0, 0, 0, 0);
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.CustomFormat = "MM/dd/yyyy";
            this.txtNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtNgaySinh.Location = new System.Drawing.Point(122, 96);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Size = new System.Drawing.Size(167, 20);
            this.txtNgaySinh.TabIndex = 166;
            this.txtNgaySinh.Value = new System.DateTime(1995, 10, 14, 0, 0, 0, 0);
            // 
            // cbbCoSo
            // 
            this.cbbCoSo.FormattingEnabled = true;
            this.cbbCoSo.Items.AddRange(new object[] {
            "Chùa Keo",
            "Chùa Hương"});
            this.cbbCoSo.Location = new System.Drawing.Point(650, 317);
            this.cbbCoSo.Name = "cbbCoSo";
            this.cbbCoSo.Size = new System.Drawing.Size(159, 21);
            this.cbbCoSo.TabIndex = 165;
            // 
            // cbbChucVu
            // 
            this.cbbChucVu.FormattingEnabled = true;
            this.cbbChucVu.Items.AddRange(new object[] {
            "Pháp chủ",
            "Phó Pháp chủ"});
            this.cbbChucVu.Location = new System.Drawing.Point(650, 356);
            this.cbbChucVu.Name = "cbbChucVu";
            this.cbbChucVu.Size = new System.Drawing.Size(159, 21);
            this.cbbChucVu.TabIndex = 164;
            // 
            // cbbChucSac
            // 
            this.cbbChucSac.FormattingEnabled = true;
            this.cbbChucSac.Items.AddRange(new object[] {
            "Hòa thượng",
            "Thượng tọa"});
            this.cbbChucSac.Location = new System.Drawing.Point(125, 356);
            this.cbbChucSac.Name = "cbbChucSac";
            this.cbbChucSac.Size = new System.Drawing.Size(164, 21);
            this.cbbChucSac.TabIndex = 163;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(368, 131);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(103, 17);
            this.radioButton3.TabIndex = 162;
            this.radioButton3.Text = "Không Xác Định";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(243, 131);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(39, 17);
            this.radioButton2.TabIndex = 161;
            this.radioButton2.Text = "Nữ";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(128, 131);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(47, 17);
            this.radioButton1.TabIndex = 160;
            this.radioButton1.Text = "Nam";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(406, 483);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 33);
            this.button1.TabIndex = 159;
            this.button1.Text = "Lưu";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(650, 124);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(159, 24);
            this.textBox9.TabIndex = 158;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(530, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 157;
            this.label6.Text = "Xã";
            // 
            // cbQueQuanXa
            // 
            this.cbQueQuanXa.FormattingEnabled = true;
            this.cbQueQuanXa.Location = new System.Drawing.Point(565, 192);
            this.cbQueQuanXa.Name = "cbQueQuanXa";
            this.cbQueQuanXa.Size = new System.Drawing.Size(121, 21);
            this.cbQueQuanXa.TabIndex = 156;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(125, 200);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(28, 13);
            this.label25.TabIndex = 155;
            this.label25.Text = "Tỉnh";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(336, 200);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(38, 13);
            this.label26.TabIndex = 154;
            this.label26.Text = "Huyện";
            // 
            // cbQueQuanHuyen
            // 
            this.cbQueQuanHuyen.FormattingEnabled = true;
            this.cbQueQuanHuyen.Location = new System.Drawing.Point(380, 192);
            this.cbQueQuanHuyen.Name = "cbQueQuanHuyen";
            this.cbQueQuanHuyen.Size = new System.Drawing.Size(119, 21);
            this.cbQueQuanHuyen.TabIndex = 153;
            // 
            // cbQueQuanTinh
            // 
            this.cbQueQuanTinh.FormattingEnabled = true;
            this.cbQueQuanTinh.Location = new System.Drawing.Point(157, 192);
            this.cbQueQuanTinh.Name = "cbQueQuanTinh";
            this.cbQueQuanTinh.Size = new System.Drawing.Size(132, 21);
            this.cbQueQuanTinh.TabIndex = 152;
            // 
            // txtMatDao
            // 
            this.txtMatDao.Location = new System.Drawing.Point(125, 317);
            this.txtMatDao.Multiline = true;
            this.txtMatDao.Name = "txtMatDao";
            this.txtMatDao.Size = new System.Drawing.Size(164, 24);
            this.txtMatDao.TabIndex = 151;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(530, 233);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(20, 13);
            this.label24.TabIndex = 150;
            this.label24.Text = "Xã";
            // 
            // cbDiaChiXa
            // 
            this.cbDiaChiXa.FormattingEnabled = true;
            this.cbDiaChiXa.Location = new System.Drawing.Point(565, 225);
            this.cbDiaChiXa.Name = "cbDiaChiXa";
            this.cbDiaChiXa.Size = new System.Drawing.Size(121, 21);
            this.cbDiaChiXa.TabIndex = 149;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(125, 233);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(28, 13);
            this.label23.TabIndex = 148;
            this.label23.Text = "Tỉnh";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(336, 233);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(38, 13);
            this.label18.TabIndex = 147;
            this.label18.Text = "Huyện";
            // 
            // cbDiaChiHuyen
            // 
            this.cbDiaChiHuyen.FormattingEnabled = true;
            this.cbDiaChiHuyen.Location = new System.Drawing.Point(380, 225);
            this.cbDiaChiHuyen.Name = "cbDiaChiHuyen";
            this.cbDiaChiHuyen.Size = new System.Drawing.Size(119, 21);
            this.cbDiaChiHuyen.TabIndex = 146;
            // 
            // cbDiaChiTinh
            // 
            this.cbDiaChiTinh.FormattingEnabled = true;
            this.cbDiaChiTinh.Location = new System.Drawing.Point(157, 225);
            this.cbDiaChiTinh.Name = "cbDiaChiTinh";
            this.cbDiaChiTinh.Size = new System.Drawing.Size(132, 21);
            this.cbDiaChiTinh.TabIndex = 145;
            // 
            // cbDanToc
            // 
            this.cbDanToc.FormattingEnabled = true;
            this.cbDanToc.Items.AddRange(new object[] {
            "Kinh",
            "Mường",
            "Thái",
            "Dao"});
            this.cbDanToc.Location = new System.Drawing.Point(125, 161);
            this.cbDanToc.Name = "cbDanToc";
            this.cbDanToc.Size = new System.Drawing.Size(164, 21);
            this.cbDanToc.TabIndex = 144;
            // 
            // txtPhapDanh
            // 
            this.txtPhapDanh.Location = new System.Drawing.Point(125, 25);
            this.txtPhapDanh.Multiline = true;
            this.txtPhapDanh.Name = "txtPhapDanh";
            this.txtPhapDanh.Size = new System.Drawing.Size(164, 24);
            this.txtPhapDanh.TabIndex = 143;
            // 
            // txtHdCaNhan
            // 
            this.txtHdCaNhan.Location = new System.Drawing.Point(125, 393);
            this.txtHdCaNhan.Multiline = true;
            this.txtHdCaNhan.Name = "txtHdCaNhan";
            this.txtHdCaNhan.Size = new System.Drawing.Size(164, 86);
            this.txtHdCaNhan.TabIndex = 142;
            // 
            // txtMatDoi
            // 
            this.txtMatDoi.Location = new System.Drawing.Point(125, 275);
            this.txtMatDoi.Multiline = true;
            this.txtMatDoi.Name = "txtMatDoi";
            this.txtMatDoi.Size = new System.Drawing.Size(164, 24);
            this.txtMatDoi.TabIndex = 141;
            // 
            // txtTcNguyHiem
            // 
            this.txtTcNguyHiem.Location = new System.Drawing.Point(650, 58);
            this.txtTcNguyHiem.Multiline = true;
            this.txtTcNguyHiem.Name = "txtTcNguyHiem";
            this.txtTcNguyHiem.Size = new System.Drawing.Size(159, 24);
            this.txtTcNguyHiem.TabIndex = 140;
            // 
            // txtTcTichCuc
            // 
            this.txtTcTichCuc.Location = new System.Drawing.Point(650, 25);
            this.txtTcTichCuc.Multiline = true;
            this.txtTcTichCuc.Name = "txtTcTichCuc";
            this.txtTcTichCuc.Size = new System.Drawing.Size(159, 24);
            this.txtTcTichCuc.TabIndex = 139;
            // 
            // txtTaiChinh
            // 
            this.txtTaiChinh.Location = new System.Drawing.Point(650, 278);
            this.txtTaiChinh.Multiline = true;
            this.txtTaiChinh.Name = "txtTaiChinh";
            this.txtTaiChinh.Size = new System.Drawing.Size(159, 24);
            this.txtTaiChinh.TabIndex = 138;
            // 
            // txtDhToChuc
            // 
            this.txtDhToChuc.Location = new System.Drawing.Point(650, 393);
            this.txtDhToChuc.Multiline = true;
            this.txtDhToChuc.Name = "txtDhToChuc";
            this.txtDhToChuc.Size = new System.Drawing.Size(159, 93);
            this.txtDhToChuc.TabIndex = 137;
            // 
            // txtTheDanh
            // 
            this.txtTheDanh.Location = new System.Drawing.Point(125, 58);
            this.txtTheDanh.Multiline = true;
            this.txtTheDanh.Name = "txtTheDanh";
            this.txtTheDanh.Size = new System.Drawing.Size(164, 24);
            this.txtTheDanh.TabIndex = 136;
            // 
            // txtNgayVaoTonGiao
            // 
            this.txtNgayVaoTonGiao.AutoSize = true;
            this.txtNgayVaoTonGiao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayVaoTonGiao.Location = new System.Drawing.Point(528, 96);
            this.txtNgayVaoTonGiao.Name = "txtNgayVaoTonGiao";
            this.txtNgayVaoTonGiao.Size = new System.Drawing.Size(118, 13);
            this.txtNgayVaoTonGiao.TabIndex = 135;
            this.txtNgayVaoTonGiao.Text = "Ngày Vào Tôn Giáo";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(515, 364);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(55, 13);
            this.label20.TabIndex = 134;
            this.label20.Text = "Chức Vụ";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(514, 418);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(77, 13);
            this.label19.TabIndex = 133;
            this.label19.Text = "HD Tổ Chức";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(28, 364);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(62, 13);
            this.label17.TabIndex = 132;
            this.label17.Text = "Chức Sắc";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(514, 325);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(67, 13);
            this.label16.TabIndex = 131;
            this.label16.Text = "Tên Cơ Sở";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(528, 36);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 13);
            this.label15.TabIndex = 130;
            this.label15.Text = "TC Tích Cực";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(528, 66);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 13);
            this.label14.TabIndex = 129;
            this.label14.Text = "TC Nguy Hiểm";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(27, 286);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 13);
            this.label13.TabIndex = 128;
            this.label13.Text = "Mặt Đời";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(28, 328);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 127;
            this.label12.Text = "Mặt Đạo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(31, 418);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 13);
            this.label11.TabIndex = 126;
            this.label11.Text = "HD Cá Nhân";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(31, 200);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 125;
            this.label10.Text = "Quê Quán";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(31, 233);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 124;
            this.label9.Text = "Địa Chỉ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(514, 286);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 123;
            this.label8.Text = "Tài Chính";
            // 
            // txtSucKhoe
            // 
            this.txtSucKhoe.AutoSize = true;
            this.txtSucKhoe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSucKhoe.Location = new System.Drawing.Point(528, 135);
            this.txtSucKhoe.Name = "txtSucKhoe";
            this.txtSucKhoe.Size = new System.Drawing.Size(62, 13);
            this.txtSucKhoe.TabIndex = 122;
            this.txtSucKhoe.Text = "Sức Khỏe";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 121;
            this.label5.Text = "Pháp Danh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 120;
            this.label4.Text = "Ngày Sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 119;
            this.label3.Text = "Giới Tính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 118;
            this.label2.Text = "Dân Tộc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 117;
            this.label1.Text = "Thế Danh";
            // 
            // frmSuaTinDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(852, 547);
            this.Controls.Add(this.dtNgayVaoTonGiao);
            this.Controls.Add(this.txtNgaySinh);
            this.Controls.Add(this.cbbCoSo);
            this.Controls.Add(this.cbbChucVu);
            this.Controls.Add(this.cbbChucSac);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbQueQuanXa);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.cbQueQuanHuyen);
            this.Controls.Add(this.cbQueQuanTinh);
            this.Controls.Add(this.txtMatDao);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.cbDiaChiXa);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.cbDiaChiHuyen);
            this.Controls.Add(this.cbDiaChiTinh);
            this.Controls.Add(this.cbDanToc);
            this.Controls.Add(this.txtPhapDanh);
            this.Controls.Add(this.txtHdCaNhan);
            this.Controls.Add(this.txtMatDoi);
            this.Controls.Add(this.txtTcNguyHiem);
            this.Controls.Add(this.txtTcTichCuc);
            this.Controls.Add(this.txtTaiChinh);
            this.Controls.Add(this.txtDhToChuc);
            this.Controls.Add(this.txtTheDanh);
            this.Controls.Add(this.txtNgayVaoTonGiao);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSucKhoe);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmSuaTinDo";
            this.Text = "frmSuaTinDo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtNgayVaoTonGiao;
        private System.Windows.Forms.DateTimePicker txtNgaySinh;
        private System.Windows.Forms.ComboBox cbbCoSo;
        private System.Windows.Forms.ComboBox cbbChucVu;
        private System.Windows.Forms.ComboBox cbbChucSac;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbQueQuanXa;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.ComboBox cbQueQuanHuyen;
        private System.Windows.Forms.ComboBox cbQueQuanTinh;
        private System.Windows.Forms.TextBox txtMatDao;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ComboBox cbDiaChiXa;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cbDiaChiHuyen;
        private System.Windows.Forms.ComboBox cbDiaChiTinh;
        private System.Windows.Forms.ComboBox cbDanToc;
        private System.Windows.Forms.TextBox txtPhapDanh;
        private System.Windows.Forms.TextBox txtHdCaNhan;
        private System.Windows.Forms.TextBox txtMatDoi;
        private System.Windows.Forms.TextBox txtTcNguyHiem;
        private System.Windows.Forms.TextBox txtTcTichCuc;
        private System.Windows.Forms.TextBox txtTaiChinh;
        private System.Windows.Forms.TextBox txtDhToChuc;
        private System.Windows.Forms.TextBox txtTheDanh;
        private System.Windows.Forms.Label txtNgayVaoTonGiao;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label txtSucKhoe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}