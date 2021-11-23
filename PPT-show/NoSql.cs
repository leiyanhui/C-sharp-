using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPT_show
{

    class Database_Connect {

        protected static IMongoDatabase _database;
        protected static IMongoClient _client;


        static IMongoClient connect_mongo() {

            // 定义要查询的集合名称
            const string collectionName = "User";
            // 读取连接字符串
            string strCon = "mongodb://127.0.0.1:27017/user";
            var mongoUrl = new MongoUrlBuilder(strCon);
            // 获取数据库名称
            string databaseName = mongoUrl.DatabaseName;
             // 创建并实例化客户端
            _client = new MongoClient(mongoUrl.ToMongoUrl());
            //  根据数据库名称实例化数据库
            _database = _client.GetDatabase(databaseName);
            // 根据集合名称获取集合
            var collection = _database.GetCollection<BsonDocument>(collectionName);
            var filter = new BsonDocument();
            // 查询集合中的文档
            var list = Task.Run(async () => await collection.Find(filter).ToListAsync()).Result;

            return _client ?? (_client = new MongoClient());
        }

    }
}
