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
            loadForm();
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
            cbbSearch.SelectedIndex = -1;
        }

        public void loadCombo()
        {
            cbbDate.Items.Clear();
            DirectoryInfo d = new DirectoryInfo(@"LichSuDocGia");
            FileInfo[] Files = d.GetFiles("*.txt");
            for (int i = Files.Length - 1; i >= 0; i--)
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
            String currentchooseDate = cbbDate.SelectedItem.ToString();
            String ngay = currentchooseDate.Substring(0, 2);
            String thang = currentchooseDate.Substring(3, 2);
            String nam = currentchooseDate.Substring(6);
            using (StreamReader r = new StreamReader(@"LichSuDocGia/" + nam + thang + ngay + ".txt"))
            {
                String js = r.ReadToEnd();
                items = JsonConvert.DeserializeObject<List<DocGia>>(js);
                if (items != null)
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

        public void searchStudentName()
        {
            i = 1;
            String chooseDate = cbbDate.SelectedItem.ToString();
            String ngay = chooseDate.Substring(0, 2);
            String thang = chooseDate.Substring(3, 2);
            String nam = chooseDate.Substring(6);
            using (StreamReader reader = new StreamReader(@"LichSuDocGia" + "/" + nam + thang + ngay + ".txt"))
            {
                String js = reader.ReadToEnd();
                items = JsonConvert.DeserializeObject<List<DocGia>>(js);
                List<DocGia> newList = new List<DocGia>();
                foreach (var a in items)
                {
                    if (a.hoTen.Contains(txtSearch.Text))
                        newList.Add(a);
                }
                if (newList != null)
                {
                    dgvList.DataSource = items;
                }
                else
                {
                    newList = new List<DocGia>();
                    dgvList.DataSource = items;
                }
            }
        }

        public void searchStudentCode()
        {
            i = 2;
            String chooseDate = cbbDate.SelectedItem.ToString();
            String ngay = chooseDate.Substring(0, 2);
            String thang = chooseDate.Substring(3, 2);
            String nam = chooseDate.Substring(6);
            using (StreamReader reader = new StreamReader(@"LichSuDocGia" + "/" + nam + thang + ngay + ".txt"))
            {
                String js = reader.ReadToEnd();
                items = JsonConvert.DeserializeObject<List<DocGia>>(js);
                List<DocGia> newList = new List<DocGia>();
                foreach (var a in items)
                {
                    if (a.maSV.Contains(txtSearch.Text))
                        newList.Add(a);
                }
                if (newList != null)
                {
                    dgvList.DataSource = items;
                }
                else
                {
                    newList = new List<DocGia>();
                    dgvList.DataSource = items;
                }
            }
        }

        public void addReader(String TenDocGia, String MaSV, String NgayNhap)
        {
            String chooseDate = cbbDate.SelectedItem.ToString();
            String ngay = chooseDate.Substring(0, 2);
            String thang = chooseDate.Substring(3, 2);
            String nam = chooseDate.Substring(6);
            items.Add(new DocGia()
            {
                hoTen = TenDocGia,
                maSV = MaSV,
                thoiGian = DateTime.Now.ToString("h:mm:ss tt")
            });

            String jsOut = JsonConvert.SerializeObject(items.ToArray(), Formatting.Indented);

            //write file
            File.WriteAllText(@"LichSuDocGia/" + NgayNhap + ".txt", jsOut);
            txtStudentName.Clear();
            txtStudentCode.Clear();
            txtStudentName.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtStudentName.Text.Equals(""))
                {
                    txtStudentName.Focus();
                    MessageBox.Show("Tên không được để trống");
                }
                if (txtStudentCode.Text.Equals(""))
                {
                    txtStudentCode.Focus();
                    MessageBox.Show("Mã sinh viên không được để trống");
                }
                String chooseDate = cbbDate.SelectedItem.ToString();
                String ngay = chooseDate.Substring(0, 2);
                String thang = chooseDate.Substring(3, 2);
                String nam = chooseDate.Substring(6);
                addReader(txtStudentName.Text, txtStudentCode.Text, nam + thang + ngay);
                loadList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Lỗi");
            }
        }
        private void dgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if(index >= 0)
            {
                txtStudentName.Text = dgvList.Rows[index].Cells[0].Value.ToString();
                txtStudentCode.Text = dgvList.Rows[index].Cells[1].Value.ToString();
                if (isCurrent)
                {
                    btnDelete.Enabled = true;
                    btnEdit.Enabled = true;
                }
            }
            else
            {
                btnDelete.Enabled = false;
                btnEdit.Enabled = false;
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {

        }


    }
}
