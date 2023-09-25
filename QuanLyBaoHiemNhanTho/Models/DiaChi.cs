using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBaoHiemNhanTho.Models
{
    public class DiaChi
    {
        public string SoNha { get; set; }
        public string Duong { get; set; }
        public string PhuongXa { get; set; }
        public string QuanHuyen { get; set; }
        public string TinhThanh { get; set; }

        public override string ToString()
        {
            return String.Format("{0} {1}, {2}, {3}, {4}", SoNha, Duong, PhuongXa, QuanHuyen, TinhThanh);
        }
    }
}
