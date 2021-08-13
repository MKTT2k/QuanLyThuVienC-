using System;
using System.Data;
using System.Windows.Forms;
using LVH.BUS;
using System.Linq;
using System.Reflection;

namespace LVH.GUI
{
    public partial class fQuanLyTaiKhoan : Form
    {
        int index = -1;
        QLThuVienCSharpDataContext dataContext = new QLThuVienCSharpDataContext();

        public fQuanLyTaiKhoan()
        {
            InitializeComponent();
        }


        private void GUI_QuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            try
            {
                dgvTaiKhoan.DataSource = dataContext.TAIKHOANs.Select(p => p).OrderBy(p => p.IDTaiKhoan);
                //dgvTaiKhoan.DataSource = dataContext.TAIKHOANs.Where(p => p.IDTaiKhoan == 1);
                //TAIKHOAN themTaiKhoan = new TAIKHOAN();
                //themTaiKhoan.TenDangNhap = TenDangNhap.Text;

                //dataContext.TAIKHOANs.InsertOnSubmit(themTaiKhoan);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Có lỗi xảy ra");
            }          
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            fThemTaiKhoan f = new fThemTaiKhoan(this);
            f.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e) 
        {
            //byte[] AnhDaiDien = new BUS.ConvertImage().ConvertImageToBytes(dgvTaiKhoan.Rows[index].Cells[0].Value);
            fSuaTaiKhoan f = new fSuaTaiKhoan();
            f.ShowDialog();
        }

        private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index >= 0)
            {
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
            }
            else
            {
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        public void DeleteAccount()
        {
            TAIKHOAN xoaTaiKhoan = new TAIKHOAN();
            xoaTaiKhoan.TenDangNhap = dgvTaiKhoan.Rows[index].Cells[0].Value.ToString();
            dataContext.TAIKHOANs.DeleteOnSubmit(xoaTaiKhoan);
            dataContext.SubmitChanges();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (index < 0)
                {
                    MessageBox.Show("Vui lòng chọn đối tượng cần xoá!");
                }
                else
                {
                    if (MessageBox.Show("Bạn có chắc chắn muốn xoá tài khoản " + dgvTaiKhoan.Rows[index].Cells[1].Value.ToString() + " không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                    {
                        DeleteAccount();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }
    }
}
