using Microsoft.VisualBasic;
using MongoDB.Bson;
using MongoDB.Driver;
using QuanLyBaoHiemNhanTho.CodeNhanVien.DbConnect;
using QuanLyBaoHienNhanTho.CodeNhanVien.Module;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBaoHiemNhanTho.CodeNhanVien.Controler
{
    public class ServiceNhanVien
    {
        Connect con = new Connect();
        IMongoCollection<HopDong> collectionHD;
        IMongoCollection<NhanVien> collectionNV;
        public ServiceNhanVien()
        {
            collectionNV = con.db.GetCollection<NhanVien>("NhanVien");
            collectionHD = con.db.GetCollection<HopDong>("HopDong");


        }
        public List<NhanVien> dsNhanVien()
        {
            //var user = await colection.FindAsync(_ => true);
            var filter = Builders<NhanVien>.Filter.Empty;
            var user = collectionNV.Find(filter).ToListAsync();
            user.Wait();
            return user.Result;
        }
        //kiểm tra trùng mã
        public bool checkID(string ID)
        {
            var filter = Builders<NhanVien>.Filter.Eq("_id", ID);
            var existID = collectionNV.Find(filter).FirstOrDefault();
            if (existID != null)
            {
                return false;
            }
            return true;
        }
        //danh sách hợp đồng có nhân viên 
        public List<HopDong> dsHDisNV(string ID)
        {
            var filter = Builders<HopDong>.Filter.Eq("NhanVien._id", ID);
            var user = collectionHD.Find(filter).ToList();
            return user;
        }

        //cập nhật nhân viên trong hợp đồng
        public void updateOneNVinHD(string ID, NhanVien nv)
        {
            var filter = Builders<HopDong>.Filter.Eq("_id", ID);
            var update = Builders<HopDong>.Update
                    .Set("NhanVien.HoTen", nv.HoTen)
                    .Set("NhanVien.CCCD", nv.CCCD)
                    .Set("NhanVien.GioiTinh", nv.GioiTinh)
                    .Set("NhanVien.SDT", nv.SDT)
                    .Set("NhanVien.MatKhau", nv.MatKhau)
                    .Set("NhanVien.TrangThai", nv.TrangThai)
                    .Set("NhanVien.GioiTinh", nv.GioiTinh)
                    .Set("NhanVien.Email", nv.Email)
                    .Set("NhanVien.QuocTich", nv.QuocTich)
                    .Set("NhanVien.NgaySinh", nv.NgaySinh)
                    .Set("NhanVien.DiaChi.SoNha", nv.DiaChi.SoNha)
                    .Set("NhanVien.DiaChi.Duong", nv.DiaChi.Duong)
                    .Set("NhanVien.DiaChi.PhuongXa", nv.DiaChi.PhuongXa)
                    .Set("NhanVien.DiaChi.QuanHuyen", nv.DiaChi.QuanHuyen)
                    .Set("NhanVien.DiaChi.TinhThanh", nv.DiaChi.TinhThanh);
            collectionHD.UpdateOne(filter, update);
        }
        //Thêm 1 nhân viên
        public void themNhanVien(NhanVien nv)
        {
            collectionNV.InsertOneAsync(nv);
        }

        //Xóa 1 nhân viên
        public void xoaNhanVien(string ID)
        {
            var filter = Builders<NhanVien>.Filter.Eq("_id", ID);
            collectionNV.DeleteOneAsync(filter);
        }

        //Update nhân viên
        public void updateNhanVien(string ID, NhanVien nv)
        {
            var filter = Builders<NhanVien>.Filter.Eq("_id", ID);
            var update = Builders<NhanVien>.Update
                    .Set("HoTen", nv.HoTen)
                    .Set("CCCD", nv.CCCD)
                    .Set("TrangThai", nv.TrangThai)
                    .Set("MatKhau", nv.MatKhau)
                    .Set("GioiTinh", nv.GioiTinh)
                    .Set("QuocTich", nv.QuocTich)
                    .Set("SDT", nv.SDT)
                    .Set("Email", nv.Email)
                    .Set("NgaySinh", nv.NgaySinh)
                    .Set("DiaChi.SoNha", nv.DiaChi.SoNha)
                    .Set("DiaChi.Duong", nv.DiaChi.Duong)
                    .Set("DiaChi.PhuongXa", nv.DiaChi.PhuongXa)
                    .Set("DiaChi.QuanHuyen", nv.DiaChi.QuanHuyen)
                    .Set("DiaChi.TinhThanh", nv.DiaChi.TinhThanh);
            collectionNV.UpdateOne(filter, update);
        }
        //Tim nhan vien
        public NhanVien findNhanVienID(string ID)
        {
            var filter = Builders<NhanVien>.Filter.Eq("_id", ID);
            var user = collectionNV.Find(filter).ToList();
            NhanVien nv = user[0];
            return nv;
        }
        //Tìm nhân viên
        public List<NhanVien> findNhanVien(string ten)
        {
            var filter = Builders<NhanVien>.Filter.Regex("HoTen", new BsonRegularExpression(ten, "i"));
            var result = collectionNV.Find(filter).ToList();
            return result;
        }
    }
}
