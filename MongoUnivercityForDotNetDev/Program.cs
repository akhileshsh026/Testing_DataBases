using MongoDB.Bson;
using MongoDB.Bson.IO;
using MongoDB.Bson.Serialization;
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


            var Person = new Person
            {
                Name = "Akhilesh Kumar Sahu",
                Age = 30,
                Colors = new List<string> { "blue", "red" },
                Pets = new List<Pet> { new Pet { Name = "Golden Retriier", Type = "Dog" } },
                ExtraElements = new BsonDocument("anotherName", "anothervalue")
            };

            using (var writer = new JsonWriter(Console.Out))
            {
                BsonSerializer.Serialize(writer,Person); 
            }
            

        }
    }
}
