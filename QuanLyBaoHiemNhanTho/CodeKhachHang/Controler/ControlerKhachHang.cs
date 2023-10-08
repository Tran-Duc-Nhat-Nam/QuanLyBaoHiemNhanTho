using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver.Core.Connections;
using MongoDB.Bson;
using QuanLyBaoHienNhanTho.CodeKhachHang.Connect;
using QuanLyBaoHienNhanTho.CodeKhachHang.Module;

namespace QuanLyBaoHienNhanTho.CodeKhachHang.Controler
{
    public class ControlerKhachHang
    {
        ConnnectDB con = new ConnnectDB();
        IMongoCollection<HopDong> collectionHD;
        IMongoCollection<KhachHang> collectionKH;

        public ControlerKhachHang()
        {
            collectionKH = con.db.GetCollection<KhachHang>("KhachHang");
            collectionHD = con.db.GetCollection<HopDong>("HopDong");


        }

        // Cho ds các khách hàng
        public List<KhachHang> DsKhachHang()
        {
            //var user = await colection.FindAsync(_ => true);
            var filter = Builders<KhachHang>.Filter.Empty;
            var user = collectionKH.Find(filter).ToListAsync();
            user.Wait();
            return user.Result;
        }

        // Thêm 1 khách hàng
        public void createKhachHang(KhachHang kh)
        {
            collectionKH.InsertOneAsync(kh);
        }

        // Check ID khách hàng
        public bool checkID(string ID)
        {
            var filter = Builders<KhachHang>.Filter.Eq("_id", ID);
            var existID = collectionKH.Find(filter).FirstOrDefault();
            if (existID != null)
                return false;
            return true;
        }

        // Xóa 1 khách hàng
        public void deleteKhachHang(string ID)
        {
            var filter = Builders<KhachHang>.Filter.Eq("_id", ID);
            collectionKH.DeleteOneAsync(filter);
        }

        // Sửa 1 khách hàng
        public void updateKhachHang(string ID, KhachHang kh)
        {
            var filter = Builders<KhachHang>.Filter.Eq("_id", ID);
            var update = Builders<KhachHang>.Update
                    .Set("HoTen", kh.HoTen)
                    .Set("CCCD", kh.CCCD)
                    .Set("GioiTinh", kh.GioiTinh)
                    .Set("SDT", kh.SDT)
                    .Set("Email", kh.Email)
                    .Set("QuocTich", kh.QuocTich)
                    .Set("NgaySinh", kh.NgaySinh)
                    .Set("DiaChi.SoNha", kh.DiaChi.SoNha)
                    .Set("DiaChi.Duong", kh.DiaChi.Duong)
                    .Set("DiaChi.PhuongXa", kh.DiaChi.PhuongXa)
                    .Set("DiaChi.QuanHuyen", kh.DiaChi.QuanHuyen)
                    .Set("DiaChi.TinhThanh", kh.DiaChi.TinhThanh);

            collectionKH.UpdateOne(filter, update);
        }

        // Tìm khách hàng 
        public KhachHang findKhachHangID(string ID)
        {
            var filter = Builders<KhachHang>.Filter.Eq("_id", ID);
            var user = collectionKH.Find(filter).ToList();
            KhachHang kh = user[0];
            return kh;
        }

        // Tìm khách hàng 
        public List<KhachHang> findKhachHang(string hoTen)
        {

            var filter = Builders<KhachHang>.Filter.Regex("HoTen", new BsonRegularExpression(hoTen, "i")); // "i" để không phân biệt chữ hoa/chữ thường
            var user = collectionKH.Find(filter).ToListAsync();
            user.Wait();
            return user.Result;

        }

        // Ds hợp đồng có  khách hàng (id)
        public List<HopDong> dsHDisKH(string ID)
        {
            var filter = Builders<HopDong>.Filter.Eq("KhachHang._id", ID);
            var user = collectionHD.Find(filter).ToList();
            return user;
        }

        // Chỉnh sửa khách hàng trong 1 hợp đồng
        public void updateOneKHinHD(string ID, KhachHang kh)
        {
            var filter = Builders<HopDong>.Filter.Eq("_id", ID);
            var update = Builders<HopDong>.Update
                    .Set("KhachHang.HoTen", kh.HoTen)
                    .Set("KhachHang.CCCD", kh.CCCD)
                    .Set("KhachHang.GioiTinh", kh.GioiTinh)
                    .Set("KhachHang.SDT", kh.SDT)
                    .Set("KhachHang.Email", kh.Email)
                    .Set("KhachHang.QuocTich", kh.QuocTich)
                    .Set("KhachHang.NgaySinh", kh.NgaySinh)
                    .Set("KhachHang.DiaChi.SoNha", kh.DiaChi.SoNha)
                    .Set("KhachHang.DiaChi.Duong", kh.DiaChi.Duong)
                    .Set("KhachHang.DiaChi.PhuongXa", kh.DiaChi.PhuongXa)
                    .Set("KhachHang.DiaChi.QuanHuyen", kh.DiaChi.QuanHuyen)
                    .Set("KhachHang.DiaChi.TinhThanh", kh.DiaChi.TinhThanh);

            collectionHD.UpdateOne(filter, update);
        }

        // Xóa 1 hợp đồng
        public void deleteHopDong(string ID)
        {
            var filter = Builders<HopDong>.Filter.Eq("_id", ID);
            collectionHD.DeleteOneAsync(filter);
        }


    }
}
