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

            // var list = await col.Find(new BsonDocument()).Project("{Name:1,_id:0}").ToListAsync(); 
            // or 
            // var list = await col.Find(new BsonDocument()).Project(new BsonDocument("Name", 1).Add("_id", 0)).ToListAsync();
            // or
            // var list = await col.Find(new BsonDocument()).Project(Builders<BsonDocument>.Projection.Include("Name").Exclude("_id")).ToListAsync(); cahnge t0 BsonDocument in col.
            // also you can do a Person specific Doc Projection as follows but also the BsonDocument above ,
            // var list = await col.Find(new BsonDocument()).Project(Builders<Person>.Projection.Include("Name").Exclude("_id")).ToListAsync();
            // so , to make this a person that only a person can use  
            // var list = await col.Find(new BsonDocument()).Project<Person>(Builders<Person>.Projection.Include(x=>x.Name).Exclude(x=>x.Id)).ToListAsync();  //Expression lets make you Type Safe.
            // and as the Person class is static so we didn't get the correct data for that class needs to static. 

            var list = await col.Find(new BsonDocument())
                        .Project(x => x.Name)
                        .ToListAsync();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        
    }
}
