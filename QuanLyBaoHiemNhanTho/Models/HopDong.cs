using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBaoHiemNhanTho.Models
{
    public class HopDong
    {
        [BsonId]
        public string _id { get; set; }
        public string MaHD { get; set; }
        public LoaiHD LoaiHD { get; set; }
        public DateTime NgayLapHD { get; set; }
        public DateTime NgayHetHan { get; set; }
        public long PhiHopDong { get; set; }
        public double PhanTramLoiNhuan { get; set; }
        public long PhiThanhToan { get; set; }
        public string TinhTrang { get; set; }
        public KhachHang KhachHang { get; set; }
        public NhanVien NhanVien { get; set; }

        public HopDong()
        {
            this.LoaiHD = new LoaiHD();
            this.KhachHang = new KhachHang();
            this.NhanVien = new NhanVien();
        }

        public override string ToString()
        {
            return $"{LoaiHD.TenLHD} mã số {_id} của khách hàng {KhachHang.HoTen} được lập ngày {NgayLapHD.ToShortDateString()} bởi nhân viên {NhanVien._id}";
        }
    }
}
