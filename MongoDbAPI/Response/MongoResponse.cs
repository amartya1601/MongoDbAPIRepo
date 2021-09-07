using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MongoDbAPI.Response
{
    public class MongoResponse
    {
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        [JsonPropertyName("_id")]
        public string id { get; set; }


        [JsonPropertyName("firstName")]
        public string firstName { get; set; }

        [JsonPropertyName("lastName")]
        public string lastName { get; set; }

        [JsonPropertyName("age")]
        public double age { get; set; }

        [JsonPropertyName("stud")]
        public double stud { get; set; }
    }
}
