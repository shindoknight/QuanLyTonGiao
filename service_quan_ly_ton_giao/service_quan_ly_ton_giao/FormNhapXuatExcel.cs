using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;//important
using System.Data.OleDb;//important

namespace service_quan_ly_ton_giao
{
    public partial class FormNhapXuatExcel : Form
    {
        string addressFile;
        List<string> eRror = new List<string>();
        public FormNhapXuatExcel()
        {
            InitializeComponent();
        }

        private void btnChonFile_Click(object sender, EventArgs e)
        {
            oFD.Filter = "Tất Cả Các File |*.*|Excel 2003 Files |*.xls|Excel 2007 File|*.xlsx";
            oFD.FileName = "";
            oFD.ShowDialog();
        }
        private List<string> getListSheet(string urlFile)
        {
            try
            {
                List<string> sheets = new List<string>();
                string connec = string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=""Excel 8.0;HDR=YES;IMEX=1;""", urlFile);
                DbProviderFactory factory = DbProviderFactories.GetFactory("System.Data.OleDb");
                DbConnection connection = factory.CreateConnection();
                connection.ConnectionString = connec;
                connection.Open();
                DataTable dt = connection.GetSchema("Tables");
                connection.Close();
                foreach (DataRow row in dt.Rows)
                {
                    string sheetnames = (string)row["TABLE_NAME"];
                    sheets.Add(sheetnames);
                }
                return sheets;
            }
            catch (Exception)
            {
                return null;
            }
        }

        private void cboDanhSachSheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string connec = string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=""Excel 8.0;HDR=YES;IMEX=1;""", addressFile);
                string query = string.Format("Select * from [{0}]", cboDanhSachSheet.Text);
                OleDbDataAdapter adapter = new OleDbDataAdapter(query, connec);
                DataTable tbSinhVien = new DataTable();
                adapter.Fill(tbSinhVien);
                if (tbSinhVien.Rows.Count > 0)
                {
                    dgvData.DataSource = tbSinhVien;
                }
                else
                {
                    dgvData.DataSource = null;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Test");
            }
        }

        private void oFD_FileOk(object sender, CancelEventArgs e)
        {
            addressFile = oFD.FileName;
            txtFileName.Text = addressFile.Substring(addressFile.LastIndexOf(@"\") + 1);
            List<string> sheets = getListSheet(addressFile);
            cboDanhSachSheet.DataSource = sheets;
           
        }
    }
}
