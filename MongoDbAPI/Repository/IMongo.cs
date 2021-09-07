using MongoDbAPI.Models;
using MongoDbAPI.Request;
using MongoDbAPI.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MongoDbAPI.Repository
{
   public interface IMongo
    {
        public Task AddStudent(Student request);
        public Task<IEnumerable<MongoResponse>> ReadStudent(Student request);
        public Task<IEnumerable<MongoResponse>> ReadWithKeyStudent(Student request);
        public int DeleteStudent(Student request);
        public int EditStudent(Student request);

    }
}
