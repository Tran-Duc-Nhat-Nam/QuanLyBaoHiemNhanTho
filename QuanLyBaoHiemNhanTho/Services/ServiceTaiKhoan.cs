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
        public async Task<NhanVien> KiemTraTaiKhoan(string cccd, string mk)
        {
            IMongoCollection<HopDong> collection = GetCollection<HopDong>("HopDong");
            IAsyncCursor<HopDong> result = await collection
                .FindAsync(hd => hd.NhanVien.CCCD == cccd && hd.NhanVien.MatKhau == mk);

            List<HopDong> dsHD = result.ToList();
            if (dsHD.Count > 0)
            {
                return dsHD[0].NhanVien;
            }
            else
            {
                return null;
            }
        }

        public Task CapNhatTaiKhoan(string cccd, string mk)
        {
            var filter = Builders<HopDong>.Filter
                .Eq(e => e.NhanVien.CCCD, cccd);
            var update = Builders<HopDong>.Update
                .Set(e => e.NhanVien.MatKhau, mk);

            IMongoCollection<HopDong> collection = GetCollection<HopDong>("HopDong");
            return collection.UpdateOneAsync(filter, update);
        }
    }
}
