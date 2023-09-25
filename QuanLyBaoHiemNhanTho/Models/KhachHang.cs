using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBaoHiemNhanTho.Models
{
    public class KhachHang
    {
        public string HoTen { get; set; }
        public string CCCD { get; set; }
        public string GioiTinh { get; set; }
        public string QuocTich { get; set; }
        public DateTime NgaySinh { get; set; }
        public DiaChi DiaChi { get; set; }
        public string Email { get; set; }
        public string SDT { get; set; }
    }
}
