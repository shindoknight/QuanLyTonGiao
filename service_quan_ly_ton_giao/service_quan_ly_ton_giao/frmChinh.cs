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
using DevExpress.XtraTabbedMdi;
using service_quan_ly_ton_giao;
namespace service_quan_ly_ton_giao
{
    public partial class frmChinh : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private int _quyen;
        private string _id;
        private string _user;
        public frmChinh()
        {
            InitializeComponent();
        }
        public frmChinh(int quyen, string id, string username)
        {
            InitializeComponent();
            _quyen = quyen;
            _id = id;
            _user = username;
            labelName.Text = "Chào " + username;
            switch (quyen)
            {
                case 1: break;
                case 2:
                    
                    break;
                default:
                    ribbonPageGroupHeThong.Visible = false;
                    break;
              }
        }
        xFrmDanhMuc _frmDanhMuc = new xFrmDanhMuc();
        xFrmTrangChu _frmTrangChu = new xFrmTrangChu();
        private void frmChinh_Load(object sender, EventArgs e)
        {
            _frmTrangChu.TopLevel = false;
            _frmTrangChu.Parent = xtraTabPage1;
            _frmTrangChu.Dock = DockStyle.Fill;
            _frmTrangChu.Show();

        }
         private bool ExistForm(string name)
        {
            foreach (var child in this.MdiChildren)
            {
                if(child.Name==name)
                {
                    child.Activate();
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Kiểm tra tabpage có tồn tại hay không.
        /// </summary>
        /// <param name="tabControlName">Tên tabControl để kiểm tra.</param>
        /// <param name="tabName">Tên tabpage cần kiểm tra.</param>
        /// <returns></returns>
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
        void TabCreating(DevExpress.XtraTab.XtraTabControl tabControl, string Text, string Name, DevExpress.XtraEditors.XtraForm form, int imageIndex)
        {
            int index = KiemTraTonTai(tabControl, Name);
            if (index >= 0)
            {
                tabControl.SelectedTabPage = tabControl.TabPages[index];
                tabControl.SelectedTabPage.Text = Text;
            }
            else
            {
                DevExpress.XtraTab.XtraTabPage tabpage = new DevExpress.XtraTab.XtraTabPage { Text = Text, Name = Name, ImageIndex = imageIndex };
                tabControl.TabPages.Add(tabpage);
                tabControl.SelectedTabPage = tabpage;

                form.TopLevel = false;
                form.Parent = tabpage;
                form.Show();
                form.Dock = DockStyle.Fill;
            }
        }

        

        private void ribbonControl1_SelectedPageChanged(object sender, EventArgs e)
        {
            if (ribbonControl1.SelectedPage == ribbonPageTrangChu)
            {
                TabCreating(xtraTabControl1, ribbonPageTrangChu.Text, "xtraTabPage1", _frmTrangChu, ribbonPageTrangChu.ImageIndex);
            }
            //if (ribbonControl1.SelectedPage == ribbonPageDanhMuc)
              //  TabCreating(xTab_BtmTabCtrl, ribbonPageDanhMuc.Name, ribbonPageDanhMuc.Name, xfrmrbp2, ribbonPageDanhMuc.ImageIndex);
        }

        private void bbtnTTTaiKhoan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDSTinDo f = new frmDSTinDo();

            _frmTrangChu.TabCreating(f.Text, f.Name, f, imageCollection16x16, 0);
            
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

        private void bbtnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void bbtnDSCSTG_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDSCoSoTonGiao frmDSTG = new frmDSCoSoTonGiao();
          
            frmDSTG.Show();
        }

        private void bbtnThemCoSo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmThemCoSoTonGiao frmDSTG = new frmThemCoSoTonGiao();
           
            frmDSTG.Show();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmMapCoSo frmDSTG = new frmMapCoSo();
          
            frmDSTG.Show();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmMapTinDo frmMapTinDo = new frmMapTinDo();
            frmMapTinDo.Show();
        }
    }
}