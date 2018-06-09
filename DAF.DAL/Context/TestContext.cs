using System;
using System.Collections.Generic;
using System.Text;
using DAF.DAL.Entities;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace DAF.DAL.Context
{
    public class TestContext
    {
        private readonly IMongoDatabase _database = null;

        public TestContext(IOptionsSnapshot<DatabaseSetting> settings)
        {
            var client = new MongoClient(settings.Value.ConnectionString);
            if (client != null)
                _database = client.GetDatabase(settings.Value.Database);
        }

        //public IMongoCollection<Note> Notes
        //{
        //    get
        //    {
        //        return _database.GetCollection<Note>("Note");
        //    }
        //}
    }
}
