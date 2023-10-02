using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBaoHiemNhanTho.Models
{
    public class LoaiHD
    {
        [BsonId]
        public string _id { get; set; }
        public string TenLHD { get; set; }
    }
}
