using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LVH
{
    

    class BUS_TaiKhoan
    {
        DBConnection dataConn = new DBConnection();

        public DataTable GetAllTaiKhoan()
        {
            //String sql = "Select AnhDaiDien, TenDangNhap,MatKhau,TenNguoiDung,LoaiTaiKhoan,TinhTrang From TAIKHOAN";           
            String sql = "Select * From dbo.TAIKHOAN";
            return dataConn.GetTable(sql);
        }

        public void ThemTaiKhoan(byte[] AnhDaiDien, string TenDanhNhap, string MatKhau, string TenNguoiDung, int LoaiTaiKhoan, bool TinhTrang)
        {
            string sql = "Insert into dbo.TAIKHOAN values(@image,'" + TenDanhNhap + "','" + MatKhau + "',N'" + TenNguoiDung + "','" + LoaiTaiKhoan + "','" + TinhTrang + "')";
            dataConn.ExecuteNonQueryWithImage(sql, AnhDaiDien);
        }
    }
}
