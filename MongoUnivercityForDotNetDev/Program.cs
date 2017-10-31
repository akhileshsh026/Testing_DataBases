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
               var ConnectionString ="mongodb://localhost:27017";
               var client = new MongoClient(ConnectionString);

            // getting the databases schema commands with the help of clients.
            var db =client.GetDatabase("test");
            var col = db.GetCollection<Person>("movies");

        }
    }
}
