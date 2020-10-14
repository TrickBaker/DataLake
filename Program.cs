using System;
using MongoDB.Driver;
using CronNET;
using System.Threading;


// namespace MongoDBConnection
// {
//     class Program
//     {
//         // static void Main(string[] args)
//         // {
//         //     var sql = new SqlConnect();
//         //     sql.Connection();
//         //     // MongoClient dbClient = Connection.Connecting();
//         //     // var insert = new InsertDB();
//         //     // insert.Insert(dbClient, Connection.dbName);
//         //     //var dbList = dbClient.ListDatabases().ToList();
//         //     // Console.WriteLine("The list of databases on this server is: ");
//         //     // foreach (var db in dbList)
//         //     // {
//         //     //     Console.WriteLine(db);
//         //     // }

//         // }


//     }
// }

namespace CronNETExample
{
    class Program
    {
        private static readonly CronDaemon cron_daemon = new CronDaemon();            

        static void Main(string[] args)
        {
            cron_daemon.AddJob("* * * * *", task);
            cron_daemon.Start();

            // Wait and sleep forever. Let the cron daemon run.
            while(true) Thread.Sleep(10000);
        }
        static void task()
        {
          Console.WriteLine("Hello world.");
        }
    }
}
