using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DTO
{
    class SachDTO
    {
        public string MaSach { get; set; }
        public string TenSach { get; set; }
        public string TacGia { get; set; }
        public string TenNXB { get; set; }
        public int MaDanhMuc { get; set; }
        public int NamXB { get; set; }
        public int LanXB { get; set; }
        public int SoLuong { get; set; }
        public int GiaMuon { get; set; }
        public byte[] AnhSach { get; set; }
    }
}
