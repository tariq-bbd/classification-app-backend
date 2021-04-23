using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using System;

namespace ClassificationAppBackend.Controllers
{
    public class MongoController : ControllerBase
    {
        public void Setup() {
            MongoClient dbClient = new MongoClient(Configuration["DB-Mongo-ConnString"]);

            var dbList = dbClient.ListDatabases().ToList();

            Console.WriteLine("The list of databases on this server is: ");
            foreach (var db in dbList)
            {
                Console.WriteLine(db);
            }
        }
    }
}