using MongoDB.Driver;
using QuanLyBaoHiemNhanTho.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBaoHiemNhanTho.Services
{
    public class ServiceLoaiHD : ServiceBHNT
    {
        public ServiceLoaiHD()
        {
            
        }

        public List<LoaiHD> XemLoaiHD()
        {
            return GetCollection<LoaiHD>("LoaiHopDong").Find(_ => true).ToList();
        }
    }
}
