using Microsoft.Extensions.Options;
using MongoDB.Bson.IO;
using MongoDbAPI.Models;
using MongoDbAPI.Request;
using MongoDbAPI.Response;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JsonConvert = Newtonsoft.Json.JsonConvert;

namespace MongoDbAPI.Repository
{
    public class MongoRepo : IMongo
    {
        private readonly MongoContext _mongContext;

        public MongoRepo(IOptions<AppSetting> appSetting)
        {
            _mongContext = new MongoContext(appSetting);
        }

        public async Task AddStudent(Student request)
        {
           await _mongContext.StudentCollection.InsertOneAsync(request);
           
           

        }

        public int DeleteStudent(Student request)
        {
            throw new NotImplementedException();
        }

        public int EditStudent(Student request)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<MongoResponse>> ReadStudent(Student request)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<MongoResponse>> ReadWithKeyStudent(Student request)
        {
            /* var result = await _mongContext.StudentCollection.FindAsync(i => i.stud = request.stud);
             IEnumerable<MongoResponse> res;
             res = JsonConvert.DeserializeObject<IEnumerable<MongoResponse>>(result);*/
            throw new NotImplementedException();

        }
    }
}
