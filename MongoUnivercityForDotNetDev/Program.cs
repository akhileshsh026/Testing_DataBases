using MongoDB.Bson;
using MongoDB.Bson.IO;
using MongoDB.Bson.Serialization;
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

            var col = db.GetCollection<Person>("People");


            var builder = Builders<BsonDocument>.Filter;
            var filter = builder.And(builder.Lt("Age", 30), builder.Eq("Name", "Akhilesh Kumar"));
            //  var filter = new BsonDocument("$and", new BsonArray
            //{
            //    new BsonDocument("Age", new BsonDocument("$lt", 40)),
            //    new BsonDocument("Name","Akhilesh Kumar")
            //}
            // );
            var list = await col.Find(filter).ToListAsync();

            foreach (var item in list)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", item.Name, item.Age, item.Profession, item.Id);
            }
        }

        
    }
}
