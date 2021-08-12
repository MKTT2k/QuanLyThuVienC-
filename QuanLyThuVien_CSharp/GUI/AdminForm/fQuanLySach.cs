using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien_CSharp.GUI.AdminForm
{
    public partial class fQuanLySach : Form
    {
        QuanLyThuVien_CSharpDataContext dataContext = new QuanLyThuVien_CSharpDataContext();
        //int index = -1;
        public fQuanLySach()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            cbbTimKiem.Items.Add("Tên sách");
            cbbTimKiem.Items.Add("Tác giả");
            cbbTimKiem.Items.Add("Nhà xuất bản");
            cbbTimKiem.Items.Add("Năm xuất bản");
            cbbTimKiem.Items.Add("Tên danh mục");
            cbbTimKiem.SelectedIndex = 0;
            txtNoiDungTim.Clear();
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnIn.Enabled = false;
            btnTimKiem.Enabled = false;

            try
            {
                var s = from p in dataContext.SACHes
                        join k in dataContext.DANHMUCs
                        on p.MaDanhMuc equals k.MaDanhMuc
                        select new { AnhSach = p.AnhSach.ToArray(), p.MaSach, p.TenSach, p.TacGia, p.NhaXuatBan, k.TenDanhMuc, p.NamXuatBan, p.LanXuatBan, p.SoLuong, p.GiaMuon };
                dgvSach.DataSource = s.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}
