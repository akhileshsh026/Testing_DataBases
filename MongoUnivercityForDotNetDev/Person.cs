using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoUnivercityForDotNetDev
{
    class Person
    {
        //Poco repeantation 1st way
        
        public ObjectId Id { get; set; }
        [BsonElement("name")]
        public string Name { get; set; }

        public int Age { get; set; }

        public List<string> Colors { get; set; }

        public List<Pet> Pets { get; set; }

        public BsonDocument ExtraElements { get; set; }
    }

    class Pet
    {
        public string Name { get; set; }
        public string Type { get; set; }
    }
}
