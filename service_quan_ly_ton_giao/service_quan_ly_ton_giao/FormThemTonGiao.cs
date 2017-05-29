using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace service_quan_ly_ton_giao
{
    public partial class FormThemTonGiao : Form
    {
        string filename = null;
        public FormThemTonGiao()
        {
            InitializeComponent();
        }
        ServiceTonGiao.ServiceTonGiaoSoapClient ws = new ServiceTonGiao.ServiceTonGiaoSoapClient();
        private void btnChonFile_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog ofdImages = new OpenFileDialog();
            ofdImages.Filter = "file ảnh |*.jpg|*.png";
            if (ofdImages.ShowDialog() == DialogResult.OK)
            {
                filename = ofdImages.FileName;
            }
             pictureBox1.Image = Image.FromFile(filename.ToString());
        }
        
        private void btnXong_Click(object sender, EventArgs e)
        {
            try
            {
                
                // get the exact file name from the path
                String strFile = System.IO.Path.GetFileName(filename);

                // create an instance fo the web service


                // get the file information form the selected file
                FileInfo fInfo = new FileInfo(filename);

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
                    FileStream fStream = new FileStream(filename,FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fStream);

                    // convert the file to a byte array
                    byte[] data = br.ReadBytes((int)numBytes);
                    br.Close();

                    // pass the byte array (file) and file name to the web
                    //service
                    string sTmp = ws.ThemTonGiao(txtTenTG.Text,rtbGioiThieu.Text,strFile, data);
                    fStream.Close();
                    fStream.Dispose();

                    // this will always say OK unless an error occurs,
                    // if an error occurs, the service returns the error
                    //message
                  
                        MessageBox.Show( sTmp);
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

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtTenTG.Text = null;
            pictureBox1.Image = null;
            filename = null;
            rtbGioiThieu.Text = null;
        }
    }
}
