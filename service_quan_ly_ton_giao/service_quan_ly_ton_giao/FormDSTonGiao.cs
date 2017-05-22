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
using DevExpress.XtraMap;
using System.Xml;
using System.Xml.Linq;

namespace service_quan_ly_ton_giao
{
    public partial class FormDSTonGiao : Form
    {
        ServiceTonGiao.ServiceTonGiaoSoapClient ws = new ServiceTonGiao.ServiceTonGiaoSoapClient();
       string id;
        string hinhanh;
        tblCoSo.ServiceCoSoSoapClient wf = new tblCoSo.ServiceCoSoSoapClient();
        Map.ServiceMapSoapClient wf1 = new Map.ServiceMapSoapClient();
        
        VectorItemsLayer VectorLayer { get { return (VectorItemsLayer)map.Layers["VectorLayer"]; } }
        
        #region #CreateData
        // Create pie chart data adapter and specify its parameters.    
        const string xmlFilepath = "..\\..\\xml\\dulieutindo.xml";
        const string xmlFilepathTinh = "..\\..\\xml\\dulieutindotheotinh.xml";
        const string xmlFilepath1 = "..\\..\\xml\\dulieutindo1.xml";
        const string xmlFilepathMien = "..\\..\\xml\\dulieutindotheomien.xml";
        void GhiDuLieuVaoFileTheoTinh(string TonGiao, string TenVung)
        {

            DataTable ds1 = wf1.HienThiSLTinDoTheoTinh(TonGiao, " and c.TenVungDiaLy=N'" + TenVung + "' group by c.TenTinh");
            XDocument xmlDoc = XDocument.Load(xmlFilepath1);
            XmlTextWriter xtw = new XmlTextWriter(xmlFilepathMien, null);
            xtw.Formatting = Formatting.Indented;
            xtw.Close();
            for (int i = 0; i < int.Parse(ds1.Rows.Count.ToString()); i++)
            {
                DataTable ds2 = wf.DuLieuTonGiao(" where TenTonGiao like N'%" + TonGiao + "%'");
                for (int j = 0; j < int.Parse(ds2.Rows.Count.ToString()); j++)
                {
                    DataTable ds3 = wf1.HienThiSLTinDoTheoTinh(ds2.Rows[j]["TenTonGiao"].ToString(), "and c.TenVungDiaLy=N'" + TenVung + "' and c.TenTinh=N'" + ds1.Rows[i]["TenTinh"].ToString() + "' group by c.TenTinh");
                    DataTable ds4 = wf.DuLieuHuyen(",tblTinh,tblVungDiaLy where tblTinh.IDTinh=tblHuyen.IDTinh and tblTinh.IDVungDiaLy=tblVungDiaLy.IDVungDiaLy and TenTinh=N'" + ds1.Rows[i]["TenTinh"].ToString() + "' and TenVungDiaLy=N'" + TenVung + "'");

                    //DataTable ds5 = wf.DuLieuXa("where IDHuyen=N'" + ds4.Rows[0]["IDHuyen"].ToString() + "'");

                    string ki = ds4.Rows[0]["ViDo"].ToString();
                    string vi = ds4.Rows[0]["KinhDo"].ToString();
                    try
                    {
                        xmlDoc.Element("NewDataSet").Add(
                    new XElement("Table1",
                    new XElement("Tinh", ds1.Rows[i]["TenTinh"].ToString()),
                    new XElement("VungDiaLy", TenVung),
                    new XElement("TonGiao", ds2.Rows[j]["IDTonGiao"].ToString()),
                    new XElement("SLTinDo", ds3.Rows[0]["SLTinDo"].ToString()),
                    new XElement("CapitalLat", ki),
                    new XElement("CapitalLon", vi)
                    )
                    );
                    }
                    catch
                    {
                        //neu khÔng có tôn giáo nào thì sẽ không in vào file xml
                    }
                }



                xmlDoc.Save(xmlFilepathMien);
            }

        }
        void GhiDuLieuThemVaoFileTheoTinh(string TonGiao, string TenVung)
        {

            DataTable ds1 = wf1.HienThiSLTinDoTheoTinh(TonGiao, "and c.TenVungDiaLy=N'" + TenVung + "' group by c.TenTinh");
            XDocument xmlDoc = XDocument.Load(xmlFilepathMien);
            /*XmlTextWriter xtw = new XmlTextWriter(xmlFilepathMien, null);
            xtw.Formatting = Formatting.Indented;
            xtw.Close();*/
            for (int i = 0; i < int.Parse(ds1.Rows.Count.ToString()); i++)
            {
                DataTable ds2 = wf.DuLieuTonGiao(" where TenTonGiao like N'%" + TonGiao + "%'");
                for (int j = 0; j < int.Parse(ds2.Rows.Count.ToString()); j++)
                {
                    DataTable ds3 = wf1.HienThiSLTinDoTheoTinh(ds2.Rows[j]["TenTonGiao"].ToString(), "and c.TenVungDiaLy=N'" + TenVung + "' and c.TenTinh=N'" + ds1.Rows[i]["TenTinh"].ToString() + "' group by c.TenTinh");
                    DataTable ds4 = wf.DuLieuHuyen(",tblTinh,tblVungDiaLy where tblTinh.IDTinh=tblHuyen.IDTinh and tblTinh.IDVungDiaLy=tblVungDiaLy.IDVungDiaLy and TenTinh=N'" + ds1.Rows[i]["TenTinh"].ToString() + "' and TenVungDiaLy=N'" + TenVung + "'");

                    //DataTable ds5 = wf.DuLieuXa("where IDHuyen=N'" + ds4.Rows[0]["IDHuyen"].ToString() + "'");

                    string ki = ds4.Rows[0]["ViDo"].ToString();
                    string vi = ds4.Rows[0]["KinhDo"].ToString();
                    try
                    {
                        xmlDoc.Element("NewDataSet").Add(
                    new XElement("Table1",
                    new XElement("Tinh", ds1.Rows[i]["TenTinh"].ToString()),
                    new XElement("VungDiaLy", TenVung),
                    new XElement("TonGiao", ds2.Rows[j]["IDTonGiao"].ToString()),
                    new XElement("SLTinDo", ds3.Rows[0]["SLTinDo"].ToString()),
                    new XElement("CapitalLat", ki),
                    new XElement("CapitalLon", vi)
                    )
                    );
                    }
                    catch
                    {
                        //neu khÔng có tôn giáo nào thì sẽ không in vào file xml
                    }
                }



                xmlDoc.Save(xmlFilepathMien);
            }

        }
        IMapDataAdapter CreateData1()
        {
            PieChartDataAdapter adapter = new PieChartDataAdapter()
            {
                DataSource = LoadDataFromXml(xmlFilepathMien),
                PieItemDataMember = "Tinh",
                ItemMinSize = 20,
                ItemMaxSize = 60
            };

            // Specify mappings.
            adapter.Mappings.Latitude = "CapitalLat";
            adapter.Mappings.Longitude = "CapitalLon";
            adapter.Mappings.PieSegment = "TonGiao";
            adapter.Mappings.Value = "SLTinDo";

            // Specify measure rules
            adapter.MeasureRules = new MeasureRules();
            adapter.MeasureRules.RangeStops.Add(1);
            adapter.MeasureRules.RangeStops.Add(2);
            adapter.MeasureRules.RangeStops.Add(3);
            adapter.MeasureRules.RangeStops.Add(4);
            adapter.MeasureRules.RangeStops.Add(5);

            return adapter;
        }
        #region #CreateColorizer
        MapColorizer CreateColorizer()
        {
            KeyColorColorizer colorizer = new KeyColorColorizer()
            {
                ItemKeyProvider = new ArgumentItemKeyProvider()
            };

            colorizer.Colors.Add(Color.FromArgb(255, 207, 98));
            colorizer.Colors.Add(Color.FromArgb(169, 181, 188));
            colorizer.Colors.Add(Color.FromArgb(233, 152, 118));

            colorizer.Keys.Add(new ColorizerKeyItem() { Key = 1, Name = "Phật giáo" });
            colorizer.Keys.Add(new ColorizerKeyItem() { Key = 2, Name = "Công giáo" });
            colorizer.Keys.Add(new ColorizerKeyItem() { Key = 3, Name = "Tin lành" });

            return colorizer;
        }
        private DataTable LoadDataFromXml(string path)
        {
            DataSet ds = new DataSet();
            ds.ReadXml(path);
            DataTable table = ds.Tables[0];
            return table;
        }
        #endregion #CreateData
        #endregion #CreateColorizer
        void HienThiThongKeLenmap1()
        {
            //ItemStorage.Items.Clear();
            #region #DataProperty
            // Assign a PieChartDataAdapter object to Data.
            VectorLayer.Data = CreateData1();
            #endregion #DataProperty

            #region #ColorizerProperty
            // Assign a KeyColorColorizer object to Colorizer.
            VectorLayer.Colorizer = CreateColorizer();
            #endregion #ColorizerProperty
        }
        void HienThiTinDo()
        {

            //hien thi tin do
            DataTable dsvung = wf.DuLieuVung("");

            int m = 0;
            for (int i = 0; i < int.Parse(dsvung.Rows.Count.ToString()); i++)
            {
                DataTable ds8 = wf1.HienThiSLTinDoTheoTinh("", " and c.TenVungDiaLy=N'" + dsvung.Rows[i]["TenVungDiaLy"].ToString() + "' group by c.TenTinh");
                if (int.Parse(ds8.Rows.Count.ToString()) != 0 && m == 0)//xac dinh vung dau tien co du lieu ton giao de ghi vao file
                {
                    GhiDuLieuVaoFileTheoTinh("", dsvung.Rows[i]["TenVungDiaLy"].ToString());
                    m = i;
                }
                if (int.Parse(ds8.Rows.Count.ToString()) != 0 && i != m)//xac dinh day khong phai la vung dau tien co du lieu ton giao de ghi vao file
                {
                    GhiDuLieuThemVaoFileTheoTinh("", dsvung.Rows[i]["TenVungDiaLy"].ToString());
                }

            }
            HienThiThongKeLenmap1();
            map.CenterPoint = new GeoPoint(latitude: 15.46056, longitude: 107.7433);
            map.Zoom(5);

        }
        void XacDinhTinDoTheoTungTonGiao(string TonGiao)
        {

            DataTable dsvung = wf.DuLieuVung("");

            int m = 0;
            for (int i = 0; i < int.Parse(dsvung.Rows.Count.ToString()); i++)
            {
                DataTable ds8 = wf1.HienThiSLTinDoTheoTinh(TonGiao, " and c.TenVungDiaLy=N'" + dsvung.Rows[i]["TenVungDiaLy"].ToString() + "' group by c.TenTinh");
                if (int.Parse(ds8.Rows.Count.ToString()) != 0 && m == 0)//xac dinh vung dau tien co du lieu ton giao de ghi vao file
                {
                    GhiDuLieuVaoFileTheoTinh(TonGiao, dsvung.Rows[i]["TenVungDiaLy"].ToString());
                    m = i;
                }
                if (int.Parse(ds8.Rows.Count.ToString()) != 0 && i != m)//xac dinh day khong phai la vung dau tien co du lieu ton giao de ghi vao file
                {
                    GhiDuLieuThemVaoFileTheoTinh(TonGiao, dsvung.Rows[i]["TenVungDiaLy"].ToString());
                }

            }
            HienThiThongKeLenmap1();
            map.CenterPoint = new GeoPoint(latitude: 15.46056, longitude: 107.7433);
            map.Zoom(5);
        }
        public FormDSTonGiao()
        {
            InitializeComponent();

        }
        public FormDSTonGiao(int quyen)
        {
            InitializeComponent();
            if (quyen==3)
            {
                btnLuu.Visible = false;
                btnSua.Visible = false;
                btnThemChucSac.Visible = false;
                btnThemToChuc.Visible = false;
                btnXoa.Visible = false;
                btnLoad.Visible = false;
            }


        }
        private void FormDSTonGiao_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            DataTable s = ws.LayDanhSach();
            dgvDSTG.DataSource = s;
            HienThiTinDo();
        }



        private void dgvDSTG_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                pictureBox1.Image = null;
                txtTenTG.Text =lbTenTG.Text = dgvDSTG.CurrentRow.Cells["clmTenTG"].Value.ToString();
                XacDinhTinDoTheoTungTonGiao(txtTenTG.Text);
                txtSLTindo.Text= dgvDSTG.CurrentRow.Cells["clmSLTinDo"].Value.ToString();
                rtbGioiThieu.Text= dgvDSTG.CurrentRow.Cells["clmGioiThieu"].Value.ToString();
                hinhanh= dgvDSTG.CurrentRow.Cells["clmHinhAnh"].Value.ToString();
                id = dgvDSTG.CurrentRow.Cells["clmID"].Value.ToString();
                if (hinhanh!="")
                {
                    FilesTransfer.FilesTransferSoapClient WSFile = new FilesTransfer.FilesTransferSoapClient();
                    System.IO.FileStream fs1 = null;
                    byte[] b1 = null;
                    string name = hinhanh.Substring(hinhanh.LastIndexOf("/") + 1);
                    if (File.Exists(@"..\..\hinh_anh\tongiao\" + name+".xml"))
                    {
                       
                    }
                    else
                    {
                        b1 = WSFile.DownloadFile(hinhanh);
                        fs1 = new FileStream(@"..\..\hinh_anh\tongiao\" + name + ".xml", FileMode.Create);
                        fs1.Write(b1, 0, b1.Length);
                        fs1.Close();
                        fs1 = null;
                    }
                    pictureBox1.Image = Image.FromFile(@"..\..\hinh_anh\tongiao\" + name + ".xml");
                }
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnLuu.Enabled = false;
                btnThemChucSac.Visible = true;
                btnThemToChuc.Visible = true;
                dgvChucSac.DataSource = ws.GetTable("select tenchucsac,gioithieu from tblChucSac where daxoa=0 and idtongiao="+id,"tblChucSac");
                dgvToChuc.DataSource = ws.GetTable("select tentochuc,gioithieu from tblTochucquantri where daxoa=0 and idtongiao=" + id, "tblToChucQuanTri");
                
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
            catch
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnThemToChuc_Click(object sender, EventArgs e)
        {
            frmThemToChucQuanTri frm = new frmThemToChucQuanTri();
            frm.cboTenTonGiao.Text = lbTenTG.Text;
            frm.cboTenTonGiao.Enabled = false;
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable s = ws.LayDanhSach();
            dgvDSTG.DataSource = s;
        }
    }
}
