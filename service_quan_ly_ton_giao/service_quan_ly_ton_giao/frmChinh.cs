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
                    ribbonPageGroupHeThong.Visible = false;
                    break;
                default:
                    ribbonPageGroupHeThong.Visible = false;
                    ribbonNhap_Xuat.Visible = false;
                    ribbonSaoLuu_PhucHoi.Visible = false;
                    bbtnThemCoSo.Enabled = false;
                    bbtnThemTinDo.Enabled = false;
                    bbtnThemTonGiao.Enabled = false;
                    btnThemToChuc.Enabled = false;
                    break;
              }
        }
        xFrmDanhMuc _frmDanhMuc = new xFrmDanhMuc();
        xFrmTrangChu _frmTrangChu = new xFrmTrangChu();
        xFrmChucNang _frmChucNang = new xFrmChucNang();
        ServiceTonGiao.ServiceTonGiaoSoapClient wsTonGiao = new ServiceTonGiao.ServiceTonGiaoSoapClient();
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
            TabCreating(xtraTabControl1, "Danh Mục", "DanhMuc", _frmDanhMuc, 1);
            frmDSCoSoTonGiao frmDSTG = new frmDSCoSoTonGiao(_quyen);

            frmDSTG.FormBorderStyle = FormBorderStyle.None;
            _frmDanhMuc.TabCreating("Danh Sách Cơ sỏ Tôn giáo", frmDSTG.Name, frmDSTG, imageCollection16x16, 7);
             
        }

        private void bbtnThemCoSo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TabCreating(xtraTabControl1, "Danh Mục", "DanhMuc", _frmDanhMuc, 1);
            frmThemCoSoTonGiao frmDSTG = new frmThemCoSoTonGiao();

            frmDSTG.FormBorderStyle = FormBorderStyle.None;
            _frmDanhMuc.TabCreating("Thêm cơ sở Tôn giáo", frmDSTG.Name, frmDSTG, imageCollection16x16, 6);
           
        }

        private void bbtnDSTonGiao_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TabCreating(xtraTabControl1, "Danh Mục", "DanhMuc", _frmDanhMuc, 1);
            FormDSTonGiao f = new FormDSTonGiao();
            _frmDanhMuc.TabCreating("Danh sách Tôn giáo", f.Name, f, imageCollection16x16, 1);
        }

        private void bbtnBanDoCoSo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TabCreating(xtraTabControl1, "Chức Năng", "ChucNang", _frmChucNang, 2);
            frmMapCoSo f = new frmMapCoSo();
            _frmChucNang.TabCreating("Bản đồ cơ sở Tôn giáo", f.Name, f, imageCollection16x16, 13);
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TabCreating(xtraTabControl1, "Chức Năng", "ChucNang", _frmChucNang, 2);
            frmMapTinDo f = new frmMapTinDo();
            _frmChucNang.TabCreating("Bản đồ tín đồ tôn giáo", f.Name, f, imageCollection16x16, 14);
        }

        private void bbtnThemTonGiao_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TabCreating(xtraTabControl1, "Danh Mục", "DanhMuc", _frmDanhMuc, 1);
            FormThemTonGiao f = new FormThemTonGiao();
            _frmDanhMuc.TabCreating("Thêm tôn giáo", f.Name, f, imageCollection16x16, 11);
        }

        private void bbtnSaoLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string path;
            SaveFileDialog backup = new SaveFileDialog();
            backup.Filter = "|*.bak";
            backup.RestoreDirectory = true;
            if (backup.ShowDialog() == DialogResult.OK)
            {
                path = backup.FileName;
                string kq= wsTonGiao.Exec("BACKUP DATABASE QUANLYTONGIAO TO DISK = '" + path + "'");
                MessageBox.Show(kq);
            }
        }

        private void bbtnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string path;
            OpenFileDialog phuchoi = new OpenFileDialog();
            //phuchoi.Filter = "|.bak";
            if (phuchoi.ShowDialog() == DialogResult.OK)
            {
                path = phuchoi.FileName;
                string kq =wsTonGiao.PhucHoi(path);
                MessageBox.Show(kq);
            }
        }

        private void bbtnDSToChuc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TabCreating(xtraTabControl1, "Danh Mục", "DanhMuc", _frmDanhMuc, 1);
            frmDSToChucQuanTri f = new frmDSToChucQuanTri(_quyen);
            _frmDanhMuc.TabCreating("Danh sách tổ chức tôn giáo", f.Name, f, imageCollection16x16, 12);
        }

        private void btnThemToChuc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TabCreating(xtraTabControl1, "Danh Mục", "DanhMuc", _frmDanhMuc, 1);
            frmThemToChucQuanTri f = new frmThemToChucQuanTri();
            _frmDanhMuc.TabCreating(f.Text, f.Name, f, imageCollection16x16, 15);
        }

        private void bbtnThongKe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TabCreating(xtraTabControl1, "Chức Năng", "ChucNang", _frmChucNang, 2);
            xtrThongKe f = new xtrThongKe();
            _frmChucNang.TabCreating("Thống kê", f.Name, f, imageCollection16x16, 16);
        }
    }
}