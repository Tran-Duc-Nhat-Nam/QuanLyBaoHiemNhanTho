using MongoDB.Bson;
using MongoDB.Driver;
using QuanLyBaoHiemNhanTho.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBaoHiemNhanTho.Services
{
    public class ServiceHopDong : ServiceBHNT
    {
        public List<HopDong> XemHopDong()
        {
            return GetCollection<HopDong>("HopDong").Find(_ => true).ToList();
        }
        public DataTable XemHopDong(string text)
        {
            List<HopDong> dsHD = GetCollection<HopDong>("HopDong").Find(
                hd => hd._id.Contains(text) ||
                    hd.LoaiHD.TenLHD.Contains(text) ||
                    hd.TinhTrang.Contains(text) ||
                    hd.KhachHang._id.Contains(text) ||
                    hd.KhachHang.HoTen.Contains(text) ||
                    hd.KhachHang.CCCD.Contains(text) ||
                    hd.NhanVien._id.Contains(text) ||
                    hd.NhanVien.HoTen.Contains(text) ||
                    hd.NhanVien.CCCD.Contains(text)).ToList();

            DataTable dt = new DataTable();
            dt.Columns.Add("MaHopDong");
            dt.Columns.Add("LoaiHopDong");
            dt.Columns.Add("NgayLap");
            dt.Columns.Add("NgayHetHan");
            dt.Columns.Add("PhiHopDong");
            dt.Columns.Add("PhiThanhToan");
            dt.Columns.Add("PhanTramLoiNhuan");
            dt.Columns.Add("TinhTrang");
            dt.Columns.Add("NhanVienLap");
            dt.Columns.Add("KhachHang");

            foreach (HopDong hd in dsHD)
            {
                DataRow row = dt.NewRow();
                row["MaHopDong"] = hd._id;
                row["LoaiHopDong"] = hd.LoaiHD.TenLHD;
                row["NgayLap"] = hd.NgayLapHD;
                row["NgayHetHan"] = hd.NgayHetHan;
                row["PhiHopDong"] = hd.PhiHopDong;
                row["PhiThanhToan"] = hd.PhiThanhToan;
                row["PhanTramLoiNhuan"] = hd.PhanTramLoiNhuan;
                row["TinhTrang"] = hd.TinhTrang;
                row["NhanVienLap"] = hd.NhanVien._id;
                row["KhachHang"] = hd.KhachHang._id;
                dt.Rows.Add(row);
            }

            return dt;
        }

        public HopDong XemChiTietHopDong(string MaHD)
        {
            return GetCollection<HopDong>("HopDong").Find(hd => hd._id == MaHD).First();
        }

        public DataTable XemBangHopDong()
        {
            List<HopDong> dsHD = GetCollection<HopDong>("HopDong").Find(_ => true).ToList();
            DataTable dt = new DataTable();
            dt.Columns.Add("MaHopDong");
            dt.Columns.Add("LoaiHopDong");
            dt.Columns.Add("NgayLap");
            dt.Columns.Add("NgayHetHan");
            dt.Columns.Add("PhiHopDong");
            dt.Columns.Add("PhiThanhToan");
            dt.Columns.Add("PhanTramLoiNhuan");
            dt.Columns.Add("TinhTrang");
            dt.Columns.Add("NhanVienLap");
            dt.Columns.Add("KhachHang");

            foreach (HopDong hd in dsHD)
            {
                DataRow row = dt.NewRow();
                row["MaHopDong"] = hd._id;
                row["LoaiHopDong"] = hd.LoaiHD.TenLHD;
                row["NgayLap"] = hd.NgayLapHD;
                row["NgayHetHan"] = hd.NgayHetHan;
                row["PhiHopDong"] = hd.PhiHopDong;
                row["PhiThanhToan"] = hd.PhiThanhToan;
                row["PhanTramLoiNhuan"] = hd.PhanTramLoiNhuan;
                row["TinhTrang"] = hd.TinhTrang;
                row["NhanVienLap"] = hd.NhanVien._id;
                row["KhachHang"] = hd.KhachHang._id;
                dt.Rows.Add(row);
            }

            return dt;
        }

        public async Task ThemHopDong(HopDong hd)
        {
            string MaHD = GetCollection<HopDong>("HopDong").Find(_ => true).ToList().Last()._id;
            int stt = Convert.ToInt32(MaHD.Substring(2)) + 1;
            hd._id = $"HD{stt:000000000}";
            await GetCollection<HopDong>("HopDong").InsertOneAsync(hd);
        }

        public async Task CapNhatHopDong(HopDong hd)
        {
            await GetCollection<HopDong>("HopDong").ReplaceOneAsync(e => e._id == hd._id, hd);
        }

        public async Task XoaHopDong(string MaHD)
        {
            await GetCollection<HopDong>("HopDong").DeleteOneAsync(hd => hd._id == MaHD);
        }

        public async Task HuyHopDong(string MaHD)
        {
            var filter = Builders<HopDong>.Filter
                .Eq(e => e._id, MaHD);
            var update = Builders<HopDong>.Update
                .Set(e => e.TinhTrang, "Đã hủy");

            await GetCollection<HopDong>("HopDong").UpdateOneAsync(filter, update);
        }
    }
}
