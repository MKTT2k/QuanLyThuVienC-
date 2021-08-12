using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLThuVienCSharp.GUI.ManagerForm.QLMuonTra;
using System.Data.Linq.SqlClient;

namespace QLThuVienCSharp.GUI.ManagerForm.QLMuonTra
{
    public partial class fQLPhieuMuonTra : Form
    {
        int index = -1;
        string tenDN;
        public fQLPhieuMuonTra()
        {
            InitializeComponent();
        }

        private void fQLPhieuMuonTra_Load(object sender, EventArgs e)
        {
            prepare();
            cbb_search.SelectedIndex = 0;
        }

        public void prepare()
        {
            QLThuVienCSharpDataContext db = new QLThuVienCSharpDataContext();
            dgvPhieu.DataSource = db.PHIEUMUONs.Select(p => p);
        }
    }
}