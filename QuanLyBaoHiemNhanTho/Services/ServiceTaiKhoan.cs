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

        public void CapNhatTaiKhoan(string id, string mk)
        {
            var filter = Builders<NhanVien>.Filter
                .Eq(e => e._id, id);
            var update = Builders<NhanVien>.Update
                .Set(e => e.MatKhau, mk);

            GetCollection<NhanVien>("NhanVien").UpdateOne(filter, update);


            var filterHD = Builders<HopDong>.Filter
                .Eq(e => e.NhanVien._id, id);
            var updateHD = Builders<HopDong>.Update
                .Set(e => e.NhanVien.MatKhau, mk);

            GetCollection<HopDong>("HopDong").UpdateMany(filterHD, updateHD);
        }
    }
}
