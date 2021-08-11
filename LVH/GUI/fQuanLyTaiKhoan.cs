using System;
using System.Data;
using System.Windows.Forms;
using LVH.BUS;
using System.Linq;

namespace LVH.GUI
{
    public partial class fQuanLyTaiKhoan : Form
    {

        QLThuVienCSharpDataContext dataContext = new QLThuVienCSharpDataContext();

        public fQuanLyTaiKhoan()
        {
            InitializeComponent();
        }

        public void prepare()
        {
            loadData(new BUS_TaiKhoan().GetAllTaiKhoan());
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            cbbTimKiem.SelectedIndex = 0;
        }

        public void loadData(DataTable dt)
        {
            ConvertImage convert = new ConvertImage();
            dgvTaiKhoan.Rows.Clear();
            foreach (DataRow a in dt.Rows)
            {
                dgvTaiKhoan.Rows.Add((byte[])a.ItemArray[1],
                    (string)a.ItemArray[2],
                    (string)a.ItemArray[3],
                    (string)a.ItemArray[4],
                    Int32.Parse(a.ItemArray[5].ToString()) == 0 ? "Người quản trị" : "Nhân viên",
                    (bool)a.ItemArray[6] ? "Kích hoạt" : "Vô hiệu hoá",
                    Int32.Parse(a.ItemArray[5].ToString())
                    );
            }
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void GUI_QuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            try
            {
                
                dgvTaiKhoan.DataSource = dataContext.TAIKHOANs.Select(p => p).OrderBy(p => p.IDTaiKhoan);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Có lỗi xảy ra");
            }
            //try
            //{
            //    prepare();
            //}
            
            //catch (Exception ex)
            //{
            //    MessageBox.Show("error: " + ex.Message, "có lỗi xảy ra");
            //}
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            fThemTaiKhoan f = new fThemTaiKhoan(this);
            f.ShowDialog();
        }
    }
}
