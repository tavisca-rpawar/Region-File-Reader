using MongoDB;
using System;
using System.Collections.Generic;
using MongoDB.Driver;
using MongoDB.Bson;
namespace File_Reader
{
    public class MongoDB
    {
        private IMongoDatabase db;
        FileOpeartion fileOperation = new FileOpeartion();
        public MongoDB(string database)
        {
            var client = new MongoClient();
            db = client.GetDatabase(database);
        }
        public void InsertRecord(string table, string[] lines)
        {
            var collection = db.GetCollection<BsonDocument>(table);
            List<BsonDocument> bsonDocuments = new List<BsonDocument>();
            BsonDocument bsonDocument = new BsonDocument { { table,new BsonDocument() } };
          
            foreach (var line in lines)
            {
                string[] entries = line.Split('|');
                bsonDocument = new BsonDocument() {
                    { "RegionID", entries[0] },
                    { "RegionName", entries[1]},
                    { "RegionNameLong",  entries[2]},
                    { "Latitude", entries[3]},
                    { "Longitude", entries[4]},
                    { "SubClassification ", entries[5]}
                };
                bsonDocuments.Add(bsonDocument);
            }
            collection.InsertMany(bsonDocuments);
            Console.WriteLine("Data Inserted Successfully");
        }
    }
}