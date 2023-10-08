using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace QuanLyBaoHienNhanTho.CodeKhachHang.Module
{
    public class NhanVien
    {
        public NhanVien() { }

        public NhanVien(string id, string hoTen)
        {
            Id = id;
            HoTen = hoTen;
        }

        public NhanVien(string id, string hoTen, string cCCD, string matKhau, string trangThai, string gioiTinh, string sdt, string email, string quocTich, DateTime? ngaySinh, DiaChi diaChi)
        {
            Id = id;
            HoTen = hoTen;
            CCCD = cCCD;
            MatKhau = matKhau;
            TrangThai = trangThai;
            GioiTinh = gioiTinh;
            SDT = sdt;
            Email = email;
            QuocTich = quocTich;
            NgaySinh = ngaySinh;
            DiaChi = diaChi;
        }

        [BsonId]
        //[BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string HoTen { get; set; }
        public string MatKhau { get; set; }
        public string TrangThai { get; set; }
        public string CCCD { get; set; }
        public string GioiTinh { get; set; }
        public string SDT { get; set; }
        public string Email { get; set; }
        public string QuocTich { get; set; }
        public DateTime? NgaySinh { get; set; }
        public DiaChi DiaChi { get; set; }
    }

}