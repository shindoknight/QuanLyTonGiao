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

namespace service_quan_ly_ton_giao
{
    public partial class frmDSCoSoTonGiao : DevExpress.XtraEditors.XtraForm
    {
        public frmDSCoSoTonGiao()
        {
            InitializeComponent();
        }

        private void frmDSCoSoTonGiao_Load(object sender, EventArgs e)
        {
            tblCoSo.WebServiceSoapClient wf = new tblCoSo.WebServiceSoapClient();
            grcDSTonGiao.DataSource = wf.HienThiDSCoSo("");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}