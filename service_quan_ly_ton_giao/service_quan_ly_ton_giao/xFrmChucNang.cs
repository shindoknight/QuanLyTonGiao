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
    public partial class xFrmChucNang : DevExpress.XtraEditors.XtraForm
    {
        public xFrmChucNang()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }
        static int KiemTraTonTai(DevExpress.XtraTab.XtraTabControl tabControlName, string tabName)
        {
            int re = -1;
            for (int i = 0; i < tabControlName.TabPages.Count; i++)
            {
                if (tabControlName.TabPages[i].Name == tabName)
                {
                    re = i;
                    break;
                }
            }
            return re;
        }
        /// <summary>
        /// Tạo thêm tab mới
        /// </summary>
        /// <param name="tabControl">Tên TabControl để add thêm tabpage mới vào</param>
        /// <param name="Text">Tiêu đề tabpage mới</param>
        /// <param name="Name">Tên tabpage mới</param>
        /// <param name="form">Tên form con của tab mới</param>
        /// <param name="imageIndex">index của icon</param>
        public void TabCreating(string Text, string Name, System.Windows.Forms.Form form, DevExpress.Utils.ImageCollection imgcl, int imgindex)
        {
            xtraTabControl1.Images = imgcl;
            int index = KiemTraTonTai(xtraTabControl1, Name);
            if (index >= 0)
            {
                xtraTabControl1.SelectedTabPage = xtraTabControl1.TabPages[index];
                xtraTabControl1.SelectedTabPage.Text = Text;
            }
            else
            {
                DevExpress.XtraTab.XtraTabPage tabpage = new DevExpress.XtraTab.XtraTabPage { Text = Text, Name = Name, ImageIndex = imgindex };
                xtraTabControl1.TabPages.Add(tabpage);
                xtraTabControl1.SelectedTabPage = tabpage;
                form.FormBorderStyle = FormBorderStyle.None;
                form.TopLevel = false;
                form.Parent = tabpage;
                form.Show();
                form.Dock = DockStyle.Fill;
            }
        }

        private void xtraTabControl1_CloseButtonClick(object sender, EventArgs e)
        {
            DevExpress.XtraTab.XtraTabControl xtab = (DevExpress.XtraTab.XtraTabControl)sender;
            //if (xtab.Name == "xtraTabPage1") return;
            if (xtab.SelectedTabPageIndex == 0) return;
            int i = xtab.SelectedTabPageIndex;
            xtab.TabPages.RemoveAt(xtab.SelectedTabPageIndex);
            xtab.SelectedTabPageIndex = i - 1;
        }
    }
}