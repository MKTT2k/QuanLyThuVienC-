using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien_CSharp
{
    public partial class DanhMuc_Form : Form
    {
        public DanhMuc_Form()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            txtTenDanhMuc.Clear();
            txtTenDanhMuc.Focus();
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoQua.Enabled = false;
        }

        private void DanhMuc_Form_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void txtTenDanhMuc_TextChanged(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
