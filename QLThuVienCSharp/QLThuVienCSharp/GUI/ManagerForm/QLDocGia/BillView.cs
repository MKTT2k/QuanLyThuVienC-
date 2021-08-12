using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLThuVienCSharp.GUI.ManagerForm.QLDocGia
{
    public partial class BillView : Form
    {
        public BillView()
        {
            InitializeComponent();
        }

        private void BillView_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
