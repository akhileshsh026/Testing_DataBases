using MongoDB.Bson;
using MongoDB.Bson.IO;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.Conventions;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoUnivercityForDotNetDev
{
    class Program
    {
        static void Main(string[] args)
        {
            MainAsync(args).GetAwaiter().GetResult();
            Console.WriteLine();
            Console.WriteLine("press enter");
            Console.ReadLine();
        }

        static async Task MainAsync(string[] args)
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var db = client.GetDatabase("test");
            var col = db.GetCollection<BsonDocument>("widgets");

            await db.DropCollectionAsync("widgets");

            var docs = Enumerable.Range(0, 10).Select(i => new BsonDocument("_id", i).Add("x", i));
            await col.InsertManyAsync(docs);

            var result = await col.ReplaceOneAsync(
                new BsonDocument("_id", 5),
                new BsonDocument("_id",5).Add("x",56)
                );
            await col.Find(new BsonDocument()).ForEachAsync(x => Console.WriteLine(x));

            
        }

        private class Widget
        {
            public int Id { get; set; }
            [BsonElement("X")]  
            public int x { get; set; }
        }


        
    }
}
