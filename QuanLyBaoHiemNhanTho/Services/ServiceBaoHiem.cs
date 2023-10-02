using MongoDB.Bson;
using MongoDB.Driver;
using QuanLyBaoHiemNhanTho.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBaoHiemNhanTho.Services
{
    public class ServiceBaoHiem : ServiceBHNT
    {
        public async Task<List<HopDong>> XemHopDong(string text)
        {
            return GetCollection<HopDong>("HopDong").Find(
                                hd => hd.MaHD.Contains(text) || hd.LoaiHD.TenLHD.Contains(text) ||
                                hd.KhachHang.HoTen.Contains(text) || hd.KhachHang.CCCD.Contains(text) ||
                                hd.KhachHang._id.Contains(text) || hd.NhanVien._id.Contains(text) ||
                                hd.NhanVien.HoTen.Contains(text) || hd.NhanVien.CCCD.Contains(text)).ToList();
        }
    }
}
