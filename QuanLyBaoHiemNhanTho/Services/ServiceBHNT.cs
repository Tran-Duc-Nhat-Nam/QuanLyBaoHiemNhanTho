using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBaoHiemNhanTho.Services
{
    public class ServiceBHNT
    {
        private static string connectionString = "mongodb+srv://tranducnhatnam27:FmY2PQOeg4PEjWnp@cluster0.r7r0dc8.mongodb.net/";
        private static string databaseName = "BaoHiem";

        protected static IMongoCollection<T> GetCollection<T>(string collectionName)
        {
            MongoClient client = new MongoClient(connectionString);
            IMongoDatabase database = client.GetDatabase(databaseName);
            IMongoCollection<T> collection = database.GetCollection<T>(collectionName);
            return collection;
        }
    }
}
