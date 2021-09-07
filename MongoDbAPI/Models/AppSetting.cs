using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MongoDbAPI.Models
{
    public class AppSetting
    {
        public const string mongoSection = "MongoConnection";
        public string Database { get; set; }
        public string ConnectionString { get; set; }

    }
}
