using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MongoDbAPI.Models
{
    public class Student
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id {
            
            get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int Stud { get; set; }

        public int Age { get; set; }
    }
}
