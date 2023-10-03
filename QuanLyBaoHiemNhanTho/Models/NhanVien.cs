using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.IdGenerators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBaoHiemNhanTho.Models
{
    public class NhanVien
    {
        [BsonId]
        public string _id { get; set; }
        public string HoTen { get; set; }
        public string CCCD { get; set; }
        public string GioiTinh { get; set; }
        public string QuocTich { get; set; }
        public DateTime NgaySinh { get; set; }
        public string TrangThai { get; set; }
        public DiaChi DiaChi { get; set; }
        public string Email { get; set; }
        public string SDT { get; set; }
        public string MatKhau { get; set; }

        public NhanVien()
        {
            this.DiaChi = new DiaChi();
        }
    }
}
