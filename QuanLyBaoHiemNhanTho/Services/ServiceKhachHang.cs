using MongoDB.Driver;
using QuanLyBaoHiemNhanTho.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBaoHiemNhanTho.Services
{
    public class ServiceKhachHang : ServiceBHNT
    {
        public ServiceKhachHang()
        {
            
        }

        public List<KhachHang> XemKhachHang()
        {
            return GetCollection<KhachHang>("KhachHang").Find(_ => true).ToList();
        }

        public async Task<String> ThemKhachHang(KhachHang kh)
        {
            string MaKH = GetCollection<KhachHang>("KhachHang").Find(_ => true).ToList().Last()._id;
            int stt = Convert.ToInt32(MaKH.Substring(2)) + 1;
            kh._id = $"KH{stt:000000000}";
            await GetCollection<KhachHang>("KhachHang").InsertOneAsync(kh);
            return kh._id;
        }
    }
}
