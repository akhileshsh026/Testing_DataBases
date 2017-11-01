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
            var col = db.GetCollection<Widget>("widgets");

            await db.DropCollectionAsync("widgets");

            var docs = Enumerable.Range(0, 10).Select(i => new Widget { Id=i,x=i });
            await col.InsertManyAsync(docs);

             
            var result = await col.DeleteManyAsync(X => X.x > 5);
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
