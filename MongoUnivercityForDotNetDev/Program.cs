﻿using MongoDB.Bson;
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

            var col = db.GetCollection<BsonDocument>("People");

            var doc = new BsonDocument
            {
                { "Name","Akhilesh Kumar DBwala" }
                
            };
            Console.WriteLine(doc);
         
            await col.InsertOneAsync(doc);
            doc.Remove("_id");
            Console.WriteLine(doc);
        }
    }
}
