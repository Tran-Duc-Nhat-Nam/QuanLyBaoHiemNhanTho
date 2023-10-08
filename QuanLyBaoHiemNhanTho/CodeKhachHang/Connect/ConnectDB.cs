using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Core.Configuration;

namespace QuanLyBaoHienNhanTho.CodeKhachHang.Connect
{
    public class ConnnectDB
    {
        public MongoClient dbClient;
        public IMongoDatabase db;

        public ConnnectDB()
        {
            dbClient = new MongoClient("mongodb+srv://tranducnhatnam27:FmY2PQOeg4PEjWnp@cluster0.r7r0dc8.mongodb.net/");
            db = dbClient.GetDatabase("BaoHiem");
        }

    }
}
