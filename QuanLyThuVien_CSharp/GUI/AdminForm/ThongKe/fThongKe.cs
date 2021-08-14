using QuanLyThuVien_CSharp.BLL;
using QuanLyThuVien_CSharp.DTO;
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

namespace QuanLyThuVien_CSharp.GUI.AdminForm.ThongKe
{
    public partial class fThongKe : Form
    {
        public fThongKe()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            cbbNam.Items.Clear();
            cbbThang.Items.Clear();
            int NamHienTai = DateTime.Now.Year;
            for (int i = NamHienTai - 10; i <= NamHienTai; i++)
            {
                cbbNam.Items.Add(i);
            }

            cbbThang.Items.Add("Tất cả");
            for (int i = 1; i <= 12; i++)
            {
                cbbThang.Items.Add("Tháng " + i);
            }
            cbbNam.SelectedIndex = 0;
            cbbThang.SelectedIndex = 0;
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            int month, year;
            if (cbbThang.SelectedIndex == 0)
                month = 0;
            else
                month = Int32.Parse(cbbThang.SelectedItem.ToString().Split(' ')[1]);
            year = Int32.Parse(cbbNam.SelectedItem.ToString());
            DataTable table = new DataTable();
            if (month != 0)
            {
                table.Columns.Add("Ngày", typeof(string));
                table.Columns.Add("Số sách được mượn", typeof(int));
                table.Columns.Add("Số sách được trả", typeof(int));
                table.Columns.Add("Số độc giả đến thư viện", typeof(string));
                int days = DateTime.DaysInMonth(year, month);
                for (int i = 1; i <= days; i++)
                {
                    ThongKe_BLL thongKe = new ThongKe_BLL();
                    string date = year + "-" + (month < 10 ? "0" + month.ToString() : month.ToString()) + "-" + (i < 10 ? "0" + i.ToString() : i.ToString());
                    DataRow row = table.NewRow();
                    row["Ngày"] = "Ngày " + i + "/" + month + "/" + year;
                    row["Số sách được mượn"] = thongKe.getSachMuonNgay(date);
                    row["Số sách được trả"] = thongKe.getSachTraNgay(date);
                    if (File.Exists(@"LichSuDocGia/" + date.Substring(0, 4) + date.Substring(5, 2) + date.Substring(8, 2) + ".txt"))
                    {
                        int slDocGia = 0;
                        using (StreamReader r = new StreamReader(@"LichSuDocGia/" + date.Substring(0, 4) + date.Substring(5, 2) + date.Substring(8, 2) + ".txt"))
                        {
                            string json = r.ReadToEnd();
                            List<DocGia> items = JsonConvert.DeserializeObject<List<DocGia>>(json);
                            if (items != null)
                            {
                                slDocGia = items.Count;
                            }
                        }
                        row["Số độc giả đến thư viện"] = slDocGia.ToString();
                    }
                    else
                    {
                        row["Số độc giả đến thư viện"] = "Không có dữ liệu";
                    }
                    table.Rows.Add(row);
                }
            }
            else
            {
                table.Columns.Add("Tháng", typeof(string));
                table.Columns.Add("Số sách được mượn", typeof(int));
                table.Columns.Add("Số sách được trả", typeof(int));
                table.Columns.Add("Số độc giả đến thư viện", typeof(string));
                for (int i = 1; i <= 12; i++)
                {
                    ThongKe_BLL thongKe = new ThongKe_BLL();
                    DataRow row = table.NewRow();
                    row["Tháng"] = "Tháng " + i;
                    row["Số sách được mượn"] = thongKe.getSachMuonThang(i, year);
                    row["Số sách được trả"] = thongKe.getSachTraThang(i, year);
                    int slDocGia = 0;
                    int days = DateTime.DaysInMonth(year, i);
                    for (int dayIndex = 1; dayIndex <= days; dayIndex++)
                    {
                        string date = year + "-" + (i < 10 ? "0" + i.ToString() : i.ToString()) + "-" + (dayIndex < 10 ? "0" + dayIndex.ToString() : dayIndex.ToString());
                        if (File.Exists(@"LichSuDocGia/" + date.Substring(0, 4) + date.Substring(5, 2) + date.Substring(8, 2) + ".txt"))
                        {
                            using (StreamReader r = new StreamReader(@"LichSuDocGia/" + date.Substring(0, 4) + date.Substring(5, 2) + date.Substring(8, 2) + ".txt"))
                            {
                                string json = r.ReadToEnd();
                                List<DocGia> items = JsonConvert.DeserializeObject<List<DocGia>>(json);
                                if (items != null)
                                {
                                    slDocGia += items.Count;
                                }
                            }
                        }
                    }
                    row["Số độc giả đến thư viện"] = slDocGia;
                    table.Rows.Add(row);
                }
            }
            dgvThongKe.DataSource = table;
        }
    }
}
