using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBaoHiemNhanTho.Models;

namespace QuanLyBaoHiemNhanTho.Services
{
    public class ServiceTaiKhoan : ServiceBHNT
    {
        public NhanVien? KiemTraTaiKhoan(string id, string mk)
        {
            IAsyncCursor<NhanVien> result = GetCollection<NhanVien>("NhanVien")
                .FindAsync(nv => nv._id == id && nv.MatKhau == mk).Result;

            List<NhanVien> dsHD = result.ToList();

            if (dsHD.Count > 0)
            {
                return dsHD[0];
            }
            else
            {
                return null;
            }
        }

        public void CapNhatTaiKhoan(NhanVien nv)
        {
            var filter = Builders<NhanVien>.Filter
                .Eq(e => e._id, nv._id);
            var update = Builders<NhanVien>.Update
                .Set(e => e.HoTen, nv.HoTen)
                .Set(e => e.GioiTinh, nv.GioiTinh)
                .Set(e => e.QuocTich, nv.QuocTich)
                .Set(e => e.NgaySinh, nv.NgaySinh)
                .Set(e => e.DiaChi, nv.DiaChi)
                .Set(e => e.CCCD, nv.CCCD)
                .Set(e => e.SDT, nv.SDT)
                .Set(e => e.MatKhau, nv.MatKhau)
                .Set(e => e.Email, nv.Email);

            GetCollection<NhanVien>("NhanVien").UpdateOne(filter, update);


            var filterHD = Builders<HopDong>.Filter
                .Eq(e => e.NhanVien._id, nv._id);
            var updateHD = Builders<HopDong>.Update
                .Set(e => e.NhanVien.HoTen, nv.HoTen)
                .Set(e => e.NhanVien.GioiTinh, nv.GioiTinh)
                .Set(e => e.NhanVien.QuocTich, nv.QuocTich)
                .Set(e => e.NhanVien.NgaySinh, nv.NgaySinh)
                .Set(e => e.NhanVien.DiaChi, nv.DiaChi)
                .Set(e => e.NhanVien.CCCD, nv.CCCD)
                .Set(e => e.NhanVien.SDT, nv.SDT)
                .Set(e => e.NhanVien.MatKhau, nv.MatKhau)
                .Set(e => e.NhanVien.Email, nv.Email);

            GetCollection<HopDong>("HopDong").UpdateMany(filterHD, updateHD);
        }
    }
}
