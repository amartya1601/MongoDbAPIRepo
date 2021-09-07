using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using MongoDB.Driver.Core.Configuration;
using MongoDbAPI.Models;
using MongoDbAPI.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MongoDbAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IMongo _mongo;

        public StudentController(IMongo mongo)
        {
            _mongo = mongo;
        }

        // IMongoClient mc = new MongoClient("mongodb://localhost:27017");
        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<Student> Get()
        {
            throw new NotImplementedException();
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public IEnumerable<Student> Get(int id)
        {
            /* var db = mc.GetDatabase("studentdb");
             var collection = db.GetCollection<Student>("student");
             var res = (IEnumerable<Student>)collection.Find<Student>(x => x.stud == id ).ToList();
             return res;*/
            throw new NotImplementedException();
        }

        // POST api/<ValuesController>
        [HttpPost]
        public async Task Post([FromBody] Student value)
        {
             await _mongo.AddStudent(value);
            

        }

        // PUT api/<ValuesController>/5
        [HttpPut]
        public IEnumerable<Student> Put([FromBody] Student value)
        {
            /* var db = mc.GetDatabase("studentdb");
             var collection = db.GetCollection<Student>("student");
             try
             {
                 var update = (IEnumerable<Student>)collection.UpdateOne((x => x.stud == value.stud), Builders<Student>.Update.Set("firstName", value.firstName).Set("lastName", value.lastName).Set("age", value.age));
                 //var update = collection.FindOneAndUpdateAsync(Builders<Employee>.Filter.Eq("Id", objVM.Id), Builders<Employee>.Update.Set("Name", objVM.Name).Set("Department", objVM.Department).Set("Address", objVM.Address).Set("City", objVM.City).Set("Country", objVM.Country));

             }
             catch(Exception e) { }
             var res = (IEnumerable<Student>)collection.Find<Student>(x => true).ToList();
             return res;*/
            throw new NotImplementedException();
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public IEnumerable<Student> Delete(int id)
        {
            /*var db = mc.GetDatabase("studentdb");
            var collection = db.GetCollection<Student>("student");
            collection.DeleteOne<Student>(x => x.stud == id);
            var res = (IEnumerable<Student>)collection.Find<Student>(x => true).ToList();
            return res;*/
            throw new NotImplementedException();
        }
    }
}
