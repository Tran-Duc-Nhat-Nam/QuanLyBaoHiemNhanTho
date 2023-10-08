using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBaoHiemNhanTho.CodeNhanVien.DbConnect
{
    public class Connect
    {
        public MongoClient dbClient;
        public IMongoDatabase db;

        public Connect()
        {
            dbClient = new MongoClient("mongodb+srv://tranducnhatnam27:FmY2PQOeg4PEjWnp@cluster0.r7r0dc8.mongodb.net/");
            db = dbClient.GetDatabase("BaoHiem");
        }

    }
}
