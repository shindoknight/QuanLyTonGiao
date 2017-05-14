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

        private void frmDSTinDo_Load(object sender, EventArgs e)
        {
            tblTinDo.tblTinDoSoapClient tindo = new tblTinDoSoapClient();
            gridCTinDo.DataSource = tindo.HienThiDSTinDo();

        }
    }
}