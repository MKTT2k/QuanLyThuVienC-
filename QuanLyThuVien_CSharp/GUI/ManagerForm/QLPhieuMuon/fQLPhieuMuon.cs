using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien_CSharp.GUI.ManagerForm.QLPhieuMuon
{
    public partial class fQLPhieuMuon : Form
    {
        QuanLyThuVien_CSharpDataContext db = new QuanLyThuVien_CSharpDataContext();
        int index = -1;
        public fQLPhieuMuon()
        {
            InitializeComponent();
        }

        private void fQLPhieuMuon_Load(object sender, EventArgs e)
        {
            loadForm();
        }
        public void loadForm()
        {
            var s = from p in db.PHIEUMUONs
                    select new { p.SoPhieuMuon, p.TenDangNhap, p.MaSinhVien };
            dgvPhieuMuon.DataSource = s.ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            fAddPhieuMuon f = new fAddPhieuMuon(this);
            f.ShowDialog();
        }

        private void dgvPheuMuon_DoubleClick(object sender, EventArgs e)
        {
            fEditPhieuMuon f = new fEditPhieuMuon(this, 2);
            f.ShowDialog();
            index = -1;
        }
    }
}
