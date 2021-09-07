using Microsoft.Extensions.Options;
using MongoDB.Driver;
using MongoDbAPI.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MongoDbAPI.Models
{
    public class MongoContext
    {
        private readonly IMongoDatabase _database=null;

        public MongoContext(IOptions<AppSetting> settings)
        {
            var client = new MongoClient(settings.Value.ConnectionString);

            if(client!=null)
            {
                _database = client.GetDatabase(settings.Value.Database);

            }


        }

        public IMongoCollection<Student> StudentCollection
        {
            get
            {
                return _database.GetCollection<Student>("student");
            }
        }

        
    }
}
