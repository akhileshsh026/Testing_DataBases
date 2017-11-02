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
            var client = new MongoClient("mongodb://52.187.19.241:27017");
            var db = client.GetDatabase("test");
            var col = db.GetCollection<BsonDocument>("widgets");

            await db.DropCollectionAsync("widgets");

            var docs = Enumerable.Range(0, 10).Select(i => new BsonDocument("_id",i).Add("x",i));
            await col.InsertManyAsync(docs);


            //Atomic Opertaions
            var result =await col.BulkWriteAsync(new WriteModel<BsonDocument>[]
                {
                    new DeleteOneModel<BsonDocument>("{x:5}"),
                    new DeleteOneModel<BsonDocument>("{x:7}"),
                    new UpdateManyModel<BsonDocument>("{x:{$lt:7}}","{$inc:{x:1}}")
                });

            Console.WriteLine(result);
            Console.WriteLine();
            await col.Find(new BsonDocument()).ForEachAsync(x => Console.WriteLine(x));

            
        }
        [BsonIgnoreExtraElements] // j is not preasent in Widget cm
        private class Widget
        {
            public int Id { get; set; }
            [BsonElement("X")]  
            public int x { get; set; }

            public override string ToString()
            {
                return string.Format("ID:{0} \t X:{1}", Id, x);
            }
        }


        
    }
}
