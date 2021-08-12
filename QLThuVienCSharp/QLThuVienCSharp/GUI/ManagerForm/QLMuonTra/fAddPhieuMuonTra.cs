using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace QLThuVienCSharp.GUI.ManagerForm.QLMuonTra
{
    public partial class fAddPhieuMuonTra : Form
    {
        QLThuVienCSharpDataContext db = new QLThuVienCSharpDataContext();
        int index = -1;
        String tenDN;
        public fAddPhieuMuonTra()
        {
            InitializeComponent();
        }

        private void fAddPhieuMuonTra_Load(object sender, EventArgs e)
        {

        }
    }
}
