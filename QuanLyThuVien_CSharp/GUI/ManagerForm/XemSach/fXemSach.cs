using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq.SqlClient;

namespace QuanLyThuVien_CSharp.GUI.ManagerForm.XemSach
{
    public partial class fXemSach : Form
    {
        public fXemSach()
        {
            InitializeComponent();
        }

        private void fXemSach_Load(object sender, EventArgs e)
        {
            QuanLyThuVien_CSharpDataContext db = new QuanLyThuVien_CSharpDataContext();
            var s = from p in db.SACHes
                    join k in db.DANHMUCs
                    on p.MaDanhMuc equals k.MaDanhMuc
                    select new { AnhSach = p.AnhSach.ToArray(), p.MaSach, p.TenSach, p.TacGia, p.NhaXuatBan, k.TenDanhMuc, p.NamXuatBan, p.LanXuatBan, p.SoLuong, p.GiaMuon };
            dgvSach.DataSource = s.ToList();
        }
    }
}
