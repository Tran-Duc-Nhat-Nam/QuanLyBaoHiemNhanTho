using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace QuanLyBaoHienNhanTho.CodeNhanVien.Module
{
    public class KhachHang
    {
        public KhachHang() { }
        public KhachHang(string id, string hoTen, string cCCD, string sdt, string email, string gioiTinh, string quocTich, DateTime? ngaySinh, DiaChi diaChi)
        {
            Id = id;
            HoTen = hoTen;
            CCCD = cCCD;
            SDT = sdt;
            Email = email;
            GioiTinh = gioiTinh;
            QuocTich = quocTich;
            NgaySinh = ngaySinh;
            DiaChi = diaChi;
        }

        [BsonId]
        //[BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string HoTen { get; set; }
        public string SDT { get; set; }
        public string Email { get; set; }
        public string CCCD { get; set; }
        public string GioiTinh { get; set; }
        public string QuocTich { get; set; }
        public DateTime? NgaySinh { get; set; }
        public DiaChi DiaChi { get; set; }
    }
}
