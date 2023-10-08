using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace QuanLyBaoHienNhanTho.CodeKhachHang.Module

{
    public class HopDong
    {
        public HopDong() { }


        public HopDong(string id, LoaiHD loaiHD, DateTime? ngayLapHD, DateTime? ngayHetHan, long phiHopDong, long phiThanhToan, double phanTramLoiNhuan, string tinhTrang, KhachHang khachHang, NhanVien nhanVien)
        {
            Id = id;
            LoaiHD = loaiHD;
            NgayLapHD = ngayLapHD;
            NgayHetHan = ngayHetHan;
            PhiHopDong = phiHopDong;
            PhiThanhToan = phiThanhToan;
            PhanTramLoiNhuan = phanTramLoiNhuan;
            TinhTrang = tinhTrang;
            KhachHang = khachHang;
            NhanVien = nhanVien;
        }
        public HopDong(string id, LoaiHD loaiHD, DateTime? ngayLapHD, DateTime? ngayHetHan, long phiHopDong, long phiThanhToan, double phanTramLoiNhuan, string tinhTrang)
        {

            Id = id;
            LoaiHD = loaiHD;
            NgayLapHD = ngayLapHD;
            NgayHetHan = ngayHetHan;
            PhiHopDong = phiHopDong;
            PhiThanhToan = phiThanhToan;
            PhanTramLoiNhuan = phanTramLoiNhuan;
            TinhTrang = tinhTrang;
        }

        [BsonId]
        //[BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public LoaiHD LoaiHD { get; set; }
        public DateTime? NgayLapHD { get; set; }
        public DateTime? NgayHetHan { get; set; }
        public long PhiHopDong { get; set; }
        public long PhiThanhToan { get; set; }
        public double PhanTramLoiNhuan { get; set; }
        public string TinhTrang { get; set; }
        public KhachHang KhachHang { get; set; }
        public NhanVien NhanVien { get; set; }
    }
}
