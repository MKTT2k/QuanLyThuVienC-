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
using System.Globalization;
using Newtonsoft.Json;
using FastMember;
using Office = Microsoft.Office.Interop.Excel;
using QuanLyThuVien_CSharp.DTO;


namespace QuanLyThuVien_CSharp.GUI.ManagerForm.QLDocGia
{
    public partial class fQLDocGia : Form
    {
        String currentDate;
        List<DocGia> items;
        int index = -1;
        int i = 0;
        bool isCurrent;

        public fQLDocGia()
        {
            InitializeComponent();
        }

        public void loadForm()
        {
            timer.Start();
            DateTime localDate = DateTime.Now;
            currentDate = localDate.Date.ToString(new CultureInfo("en-GB")).Split(' ')[0];
            Directory.CreateDirectory("LichSuDocGia");
            String ngay = currentDate.Substring(0, 2);
            String thang = currentDate.Substring(3, 2);
            String nam = currentDate.Substring(6);
            using (StreamWriter writer = File.AppendText(@"LichSuDocGia/" + nam + thang + ngay + ".txt")) ;
            loadCombo();
            cbbDate.SelectedIndex = 0;
            cbbSearch.SelectedIndex = 0;
        }

        public void loadCombo()
        {
            cbbDate.Items.Clear();
            DirectoryInfo d = new DirectoryInfo(@"LichSuDocGia");
            FileInfo[] Files = d.GetFiles("*.txt");
            for(int i= Files.Length -1; i>=0; i--)
            {
                var file = Files[i];
                string nam = file.Name.Substring(0, 4);
                string thang = file.Name.Substring(4, 2);
                string ngay = file.Name.Substring(6, 2);
                cbbDate.Items.Add(ngay + "/" + thang + "/" + nam);
            }
        }

        public void loadList()
        {
            i = 0;
            String chooseDate = cbbDate.SelectedItem.ToString();
            String ngay = chooseDate.Substring(0, 2);
            String thang = chooseDate.Substring(3, 2);
            String nam = chooseDate.Substring(6);

            using (StreamReader reader = new StreamReader(@"LichSuDocGia" + "/" + nam + thang + ngay + ".txt"))
            {
                String js = reader.ReadToEnd();
                items = JsonConvert.DeserializeObject<List<DocGia>>(js);
                if(items != null)
                {
                    dgvList.DataSource = items;
                }
                else
                {
                    items = new List<DocGia>();
                    dgvList.DataSource = items;
                }
            }
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
        }
        private void fQLDocGia_Load(object sender, EventArgs e)
        {

        }
    }
}
