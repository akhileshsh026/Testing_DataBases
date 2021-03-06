﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Testing_DataBases
{
    public class Student
    {
        public ObjectId ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string Age { get; set; }

    }
    


    class Program
    {
        protected static IMongoClient _client;
        protected static IMongoDatabase _database;

        public static Student GetStudent()
        {
            Console.WriteLine("Enter student 1st anme");
            string FNm = Console.ReadLine();

            Console.WriteLine("Please enter student last name : ");
            string LNm = Console.ReadLine();

            Console.WriteLine("Please enter student age : ");
            string StudentAge = Console.ReadLine();

            Console.WriteLine("Please enter city name : ");
            string StudentCity = Console.ReadLine();

            Student student = new Student()
            {
                FirstName = FNm,
                LastName = LNm,
                Age = StudentAge,
                City = StudentCity,

            };

            return student;
        }

        public void CRUDWithMongoDb()
        {
            _client = new MongoClient();
            _database = _client.GetDatabase("School");
            var _collection = _database.GetCollection<Student>("StudentDetails");

            Console.WriteLine("press 1,2,3,4");
            string userSelection = Console.ReadLine();

            switch (userSelection)
            {
                case "1":
                    //Insert  
                    _collection.InsertOne(GetStudent());
                    break;

                case "2":
                    //Update  
                    var obj1 = GetStudent();

                    _collection.FindOneAndUpdate<Student>
                        (Builders<Student>.Filter.Eq("FirstName", obj1.FirstName),
                            Builders<Students>.Update.Set("LastName", obj1.LastName).Set("City", obj1.City).Set("Age", obj1.Age));
                    break;

                case "3":
                    //Find and Delete  
                    Console.WriteLine("Please Enter the first name to delete the record(so called document) : ");
                    var deletefirstName = Console.ReadLine();
                    _collection.DeleteOne(s => s.FirstName == deletefirstName);

                    break;

                case "4":
                    //Read all existing document  
                    var all = _collection.Find(new BsonDocument());
                    Console.WriteLine();

                    foreach (var i in all.ToEnumerable())
                    {
                        Console.WriteLine(i.Id + "  " + i.FirstName + "\t" + i.LastName + "\t" + i.Age + "\t" + i.City);
                    }

                    break;

                default:
                    Console.WriteLine("Please choose a correct option");
                    break;
            }


        }

        static void Main(string[] args)
        {
            
        }
    }
}
