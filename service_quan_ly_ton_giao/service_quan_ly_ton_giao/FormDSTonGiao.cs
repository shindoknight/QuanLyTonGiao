using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace service_quan_ly_ton_giao
{
    public partial class FormDSTonGiao : Form
    {
        public FormDSTonGiao()
        {
            InitializeComponent();
        }

        private void FormDSTonGiao_Load(object sender, EventArgs e)
        {
            ServiceTonGiao.ServiceTonGiaoSoapClient ws = new ServiceTonGiao.ServiceTonGiaoSoapClient();
            DataTable s=  ws.LayDanhSach();
            gridControl1.DataSource = s;
        }
    }
}
