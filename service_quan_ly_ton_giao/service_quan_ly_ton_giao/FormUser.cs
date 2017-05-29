using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace service_quan_ly_ton_giao
{
    public partial class FormUser : Form
    {
        int _doimk = 0;
        string _mk;
        string _id=null;
        string _hinhanh;
        bool _ad = false;
        string _quyen;
        public FormUser(bool ad)
        {
            InitializeComponent();
            _ad = ad;
            
            label5.Visible = false;
            txtMKCu.Visible = false;
            btnLuu.Visible = false;
            btnDoiMK.Visible = false;
            label6.Text = "Mật khẩu";
            label7.Text = "Nhập lại mật khẩu";
            label7.Visible = true;
            label6.Visible = true;
            txtMKMoi.Visible = true;
            txtXNMK.Visible = true;
            if(ad)
            {    
                
                comboBox1.Text = "Người Dùng";
                comboBox1.Enabled = true;
                
            }
            
            
        }
        ServiceUser.ServiceUserSoapClient ws = new ServiceUser.ServiceUserSoapClient();
        FilesTransfer.FilesTransferSoapClient WSFile = new FilesTransfer.FilesTransferSoapClient();
        public FormUser(string id,bool ad)
        {
            InitializeComponent();
            _id = id;
            _ad = ad;
           
            DataTable dt =ws.GetInfo(id);
            txtHoTen.Text = dt.Rows[0]["HoTen"].ToString();
            txtEmail.Text= dt.Rows[0]["Email"].ToString();
            txtTenDangNhap.Text= dt.Rows[0]["UserName"].ToString();
            dateEdit1.Text= dt.Rows[0]["Ngaysinh"].ToString();
            _mk= dt.Rows[0]["PassWord"].ToString();
            _quyen = dt.Rows[0]["PhanQuyen"].ToString();
            btnXong.Visible = false; 
            if(ad)
            {
               
                comboBox1.Enabled = true;
                
                
            }
            comboBox1.Text = comboBox1.Items[int.Parse(dt.Rows[0]["PhanQuyen"].ToString()) - 1].ToString();
            lbTittle.Text = "Thông tin tài khoản";
            string hinhanh= dt.Rows[0]["HinhAnh"].ToString();
            if (hinhanh != "")
            {
                
                System.IO.FileStream fs1 = null;
                byte[] b1 = null;
                string name = hinhanh.Substring(hinhanh.LastIndexOf("/") + 1);
                if (File.Exists(@"..\..\hinh_anh\user\" + name + ".xml"))
                {

                }
                else
                {
                    b1 = WSFile.DownloadFile(hinhanh);
                    fs1 = new FileStream(@"..\..\hinh_anh\user\" + name + ".xml", FileMode.Create);
                    fs1.Write(b1, 0, b1.Length);
                    fs1.Close();
                    fs1 = null;
                }
                pictureBox1.Image = Image.FromFile(@"..\..\hinh_anh\user\" + name + ".xml");
            }
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            txtHoTen.Enabled = false;
            txtTenDangNhap.Enabled = false;
            txtEmail.Enabled = false;
            dateEdit1.Enabled = false;
            btnChonFile.Enabled = false;
            label5.Visible = label6.Visible = label7.Visible = true;
            txtMKCu.Visible = txtMKMoi.Visible = txtXNMK.Visible = true;
            comboBox1.Enabled = false;
            _doimk = 1;
            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(_doimk==1)
            {
                int kt;
                if(txtMKCu.Text==_mk)
                {
                    if(txtMKMoi.Text==txtXNMK.Text)
                    {
                        kt=ws.DoiMatKhau(txtMKMoi.Text,_id);
                        if (kt == 1)
                            MessageBox.Show("Đổi mật khẩu thành công");
                        else MessageBox.Show("Đổi mật khẩu không thành công");
                    }
                    else
                    {
                        MessageBox.Show("Xác nhận mật khẩu không đúng");
                    }

                }
                else
                {
                    MessageBox.Show("Mật khẩu cũ không đúng");
                }
                
            }
            else
            {
                if(_hinhanh!=null)
                {
                    try
                    {

                        // get the exact file name from the path
                        String strFile = System.IO.Path.GetFileName(_hinhanh);

                        // create an instance fo the web service


                        // get the file information form the selected file
                        FileInfo fInfo = new FileInfo(_hinhanh);

                        // get the length of the file to see if it is possible
                        // to upload it (with the standard 4 MB limit)
                        long numBytes = fInfo.Length;
                        double dLen = Convert.ToDouble(fInfo.Length / 1000000);

                        // Default limit of 4 MB on web server
                        // have to change the web.config to if
                        // you want to allow larger uploads
                        if (dLen < 10)
                        {
                            // set up a file stream and binary reader for the
                            // selected file
                            FileStream fStream = new FileStream(_hinhanh, FileMode.Open, FileAccess.Read);
                            BinaryReader br = new BinaryReader(fStream);

                            // convert the file to a byte array
                            byte[] data = br.ReadBytes((int)numBytes);
                            br.Close();

                            // pass the byte array (file) and file name to the web
                            //service
                            string sTmp;
                            if (_ad)
                            {
                                int quyen = 3;
                                switch (comboBox1.Text)
                                {
                                    case "Admin":
                                        quyen = 1;
                                        break;
                                    case "Nhân Viên Quản Lý":
                                        quyen = 2;
                                        break;
                                    default:
                                        quyen = 3;
                                        break;
                                }
                                sTmp = ws.Sua(_id, txtHoTen.Text, txtEmail.Text, dateEdit1.Text, strFile, data, quyen.ToString());
                            }
                            else
                            {
                                sTmp = ws.Sua(_id, txtHoTen.Text, txtEmail.Text, dateEdit1.Text, strFile, data, "3");
                            }
                            
                            fStream.Close();
                            fStream.Dispose();
                            // this will always say OK unless an error occurs,
                            // if an error occurs, the service returns the error
                            //message

                            MessageBox.Show(sTmp);
                        }
                        else
                        {
                            // Display message if the file was too large to upload
                            MessageBox.Show("Độ lớn ảnh vượt quá giới hạn 10MB", "File Size");
                        }
                    }
                    catch (Exception ex)
                    {
                        // display an error message to the user
                        MessageBox.Show(ex.Message.ToString(), "Lỗi upload, vui lòng xem lại file đã chọn");
                    }
                }
                else
                {
                    string sTmp;
                    if (_ad)
                    {
                        int quyen = 3;
                        switch (comboBox1.Text)
                        {
                            case "Admin":
                                quyen = 1;
                                break;
                            case "Nhân Viên Quản Lý":
                                quyen = 2;
                                break;
                            default:
                                quyen = 3;
                                break;
                        }
                        sTmp = ws.Sua(_id, txtHoTen.Text, txtEmail.Text, dateEdit1.Text,"", null, quyen.ToString());
                    }
                    else
                    {
                        sTmp = ws.Sua(_id, txtHoTen.Text, txtEmail.Text, dateEdit1.Text, "", null, _quyen);
                    }
                    MessageBox.Show(sTmp);
                }
                
               
            }
        }

        private void btnChonFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdImages = new OpenFileDialog();
            ofdImages.Filter = "file ảnh .jpg|*.jpg|file ảnh .png|*.png|Tất cả các file|*.*";
            if (ofdImages.ShowDialog() == DialogResult.OK)
            {
                _hinhanh = ofdImages.FileName;
            }
            pictureBox1.Image = Image.FromFile(_hinhanh.ToString());
        }

        private void btnXong_Click(object sender, EventArgs e)
        {
            try
            {

                // get the exact file name from the path
                String strFile = System.IO.Path.GetFileName(_hinhanh);

                // create an instance fo the web service


                // get the file information form the selected file
                FileInfo fInfo = new FileInfo(_hinhanh);

                // get the length of the file to see if it is possible
                // to upload it (with the standard 4 MB limit)
                long numBytes = fInfo.Length;
                double dLen = Convert.ToDouble(fInfo.Length / 1000000);

                // Default limit of 4 MB on web server
                // have to change the web.config to if
                // you want to allow larger uploads
                if (dLen < 10)
                {
                    // set up a file stream and binary reader for the
                    // selected file
                    FileStream fStream = new FileStream(_hinhanh, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fStream);

                    // convert the file to a byte array
                    byte[] data = br.ReadBytes((int)numBytes);
                    br.Close();

                    // pass the byte array (file) and file name to the web
                    //service
                    int quyen=3;
                    switch(comboBox1.Text)
                    {
                        case "Admin":
                            quyen = 1;
                            break;
                        case "Nhân Viên Quản Lý":
                            quyen = 2;
                            break;
                        default:
                            quyen = 3;
                            break;
                    }
                    string sTmp = ws.ThemUser(txtTenDangNhap.Text, txtMKMoi.Text,txtHoTen.Text,txtEmail.Text,dateEdit1.Text, strFile, data,quyen);
                    fStream.Close();
                    fStream.Dispose();
                    // this will always say OK unless an error occurs,
                    // if an error occurs, the service returns the error
                    //message

                    MessageBox.Show(sTmp);
                }
                else
                {
                    // Display message if the file was too large to upload
                    MessageBox.Show("Độ lớn ảnh vượt quá giới hạn 10MB", "File Size");
                }
            }
            catch (Exception ex)
            {
                // display an error message to the user
                MessageBox.Show(ex.Message.ToString(), "Lỗi upload, vui lòng xem lại file đã chọn");
            }
        }
    }
}
