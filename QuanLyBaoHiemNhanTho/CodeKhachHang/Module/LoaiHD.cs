using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBaoHienNhanTho.CodeKhachHang.Module
{
    public class LoaiHD
    {
        public LoaiHD() { }
        public LoaiHD(string id, string tenLHD)
        {
            Id = id;
            TenLHD = tenLHD;
        }

        [BsonId]
        //[BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string TenLHD { get; set; }
    }
}
