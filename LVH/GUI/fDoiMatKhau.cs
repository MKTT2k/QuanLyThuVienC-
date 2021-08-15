using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace LVH.GUI
{
    public partial class fDoiMatKhau : Form
    {
        QuanLyThuVienDataContext dataContext = new QuanLyThuVienDataContext();
        String userName;

        public fDoiMatKhau(string username)
        {
            InitializeComponent();
            userName = username;
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtNewPassword.Text != txtConfirmPassword.Text)
                    MessageBox.Show("Xác nhận mật khẩu mới không đúng", "Có lỗi xảy ra");
                else if (dataContext.TAIKHOANs.Where(p=>p.MatKhau == txtOldPassword.Text).Count() > 0) 
                {
                    var querry = (from p in dataContext.TAIKHOANs
                                  where p.TenDangNhap == userName
                                  select p).FirstOrDefault<TAIKHOAN>();
                    querry.MatKhau = txtNewPassword.Text;
                    dataContext.SubmitChanges();
                    MessageBox.Show("OK");
                    this.Dispose();
                }
                else MessageBox.Show("Sai mật khẩu", "Lỗi");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Có lỗi xảy ra");
            }
        }
    }
}
