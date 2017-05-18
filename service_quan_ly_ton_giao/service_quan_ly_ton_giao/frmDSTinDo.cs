using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using service_quan_ly_ton_giao.tblTinDo;


namespace service_quan_ly_ton_giao
{
    public partial class frmDSTinDo : DevExpress.XtraEditors.XtraForm
    {
        public frmDSTinDo()
        {
            InitializeComponent();
        }
        tblTinDo.tblTinDoSoapClient tindo = new tblTinDoSoapClient();
        private void frmDSTinDo_Load(object sender, EventArgs e)
        {
            
            gridCTinDo.DataSource = tindo.HienThiDSTinDo();
        }

        private void gridCTinDo_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void gridCTinDo_Click(object sender, EventArgs e)
        {
            DataRow row = gridVTinDo.GetFocusedDataRow();
            BienToanCuc.IdTinDo = int.Parse(row["IDTinDo"].ToString());
            BienToanCuc.tenTinDo = row["HoDemTheDanh"].ToString() + row["TenTheDanh"].ToString();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            
        }

        private void gridCTinDo_DoubleClick(object sender, EventArgs e)
        {
            DataRow row = gridVTinDo.GetFocusedDataRow();
            BienToanCuc.IdTinDo = int.Parse(row["IDTinDo"].ToString());
            BienToanCuc.tenTinDo = row["HoDemTheDanh"].ToString() + row["TenTheDanh"].ToString();
        }

        private void gridCTinDo_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           
        }
    }
}