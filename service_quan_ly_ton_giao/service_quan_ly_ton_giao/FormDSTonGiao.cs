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
    public partial class FormDSTonGiao : Form
    {
        ServiceTonGiao.ServiceTonGiaoSoapClient ws = new ServiceTonGiao.ServiceTonGiaoSoapClient();
       string id;
        string hinhanh;
        public FormDSTonGiao()
        {
            InitializeComponent();

        }
        private void FormDSTonGiao_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            DataTable s = ws.LayDanhSach();
            dgvDSTG.DataSource = s;
            
        }



        private void dgvDSTG_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                pictureBox1.Image = null;
               txtTenTG.Text =lbTenTG.Text = dgvDSTG.CurrentRow.Cells["clmTenTG"].Value.ToString();
                txtSLTindo.Text= dgvDSTG.CurrentRow.Cells["clmSLTinDo"].Value.ToString();
                rtbGioiThieu.Text= dgvDSTG.CurrentRow.Cells["clmGioiThieu"].Value.ToString();
                hinhanh= dgvDSTG.CurrentRow.Cells["clmHinhAnh"].Value.ToString();
                id = dgvDSTG.CurrentRow.Cells["clmID"].Value.ToString();
                if (hinhanh!="")
                {
                    FilesTransfer.FilesTransferSoapClient WSFile = new FilesTransfer.FilesTransferSoapClient();
                    System.IO.FileStream fs1 = null;
                    byte[] b1 = null;
                    if(File.Exists(@"..\..\hinh_anh\tongiao\" + id.ToString() + ".xml"))
                    {
                        File.Delete(@"..\..\hinh_anh\tongiao\" + id.ToString() + ".xml");
                        b1 = WSFile.DownloadFile(hinhanh);
                        fs1 = new FileStream(@"..\..\hinh_anh\tongiao\" + id + ".xml", FileMode.Create);
                        fs1.Write(b1, 0, b1.Length);
                        fs1.Close();
                        fs1 = null;
                    }
                    else
                    {
                        b1 = WSFile.DownloadFile(hinhanh);
                        fs1 = new FileStream(@"..\..\hinh_anh\tongiao\" + id + ".xml", FileMode.Create);
                        fs1.Write(b1, 0, b1.Length);
                        fs1.Close();
                        fs1 = null;
                    }
                    pictureBox1.Image = Image.FromFile(@"..\..\hinh_anh\tongiao\" + id.ToString() + ".xml");
                }
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
               
                
                // panelHinhAnh.BackgroundImage = global::service_quan_ly_ton_giao.Properties.Resources.user_login_icon;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            labelTen.Visible = true;
            txtTenTG.Visible = true;
            btnLuu.Enabled = true;
            lbTenTG.Visible = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (ws.SuaTonGiao(id, txtTenTG.Text, rtbGioiThieu.Text, hinhanh, txtSLTindo.Text) > 0)
                {
                    {
                        MessageBox.Show("Sửa thành công!");
                        DataTable s = ws.LayDanhSach();
                        dgvDSTG.DataSource = s;

                        labelTen.Visible = false;
                        txtTenTG.Visible = false;
                        btnLuu.Enabled = false;
                        
                        lbTenTG.Text = labelTen.Text;
                        lbTenTG.Visible = true;

                    }
                }
                    
                else MessageBox.Show("Sửa không thành công!");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi kết nối WebService, vui lòng update");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            DialogResult dlrTraloi;
            dlrTraloi = MessageBox.Show("Bạn chắc chắn muốn xóa ?"+lbTenTG.Text, "Trả Lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dlrTraloi == DialogResult.OK)
            {
                if (ws.Xoa(id) > 0)
                {
                    MessageBox.Show("Xóa thành công!");
                    DataTable s = ws.LayDanhSach();
                    dgvDSTG.DataSource = s;
                    labelTen.Visible = false;
                    txtTenTG.Visible = false;
                    btnLuu.Enabled = false;
                    lbTenTG.Visible = true;
                    txtTenTG.Text = lbTenTG.Text = dgvDSTG.CurrentRow.Cells["clmTenTG"].Value.ToString();
                    txtSLTindo.Text = dgvDSTG.CurrentRow.Cells["clmSLTinDo"].Value.ToString();
                    rtbGioiThieu.Text = dgvDSTG.CurrentRow.Cells["clmGioiThieu"].Value.ToString();
                    hinhanh = dgvDSTG.CurrentRow.Cells["clmHinhAnh"].Value.ToString();
                    id = dgvDSTG.CurrentRow.Cells["clmID"].Value.ToString();
                    if (hinhanh != "")
                    {
                        FilesTransfer.FilesTransferSoapClient WSFile = new FilesTransfer.FilesTransferSoapClient();
                        System.IO.FileStream fs1 = null;
                        byte[] b1 = null;
                        b1 = WSFile.DownloadFile(hinhanh);
                        fs1 = new FileStream(@"..\\..\\hinh_anh\\tongiao\\"+id+".xml", FileMode.Create);
                        fs1.Write(b1, 0, b1.Length);
                        fs1.Close();
                        fs1 = null;
                        
                        pictureBox1.Image = Image.FromFile(@"..\\..\\hinh_anh\\tongiao\\"+id.ToString()+".xml");
                    }
                        

                }
            }
           
              

            else MessageBox.Show("xóa không thành công!");
        }

        private void dgvDSTG_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                dgvDSTG.CurrentRow.Selected = true; //dữ liệu đc chọn cả dòng
            }
            catch
            { }
        }
    }
}
