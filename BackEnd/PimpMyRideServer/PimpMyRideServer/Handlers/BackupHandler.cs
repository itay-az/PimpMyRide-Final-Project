using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.Entity;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using PimpMyRideServer.Data;
using PimpMyRideServer.Handlers.Interfaces;
using System;
using System.Runtime.CompilerServices;
using System.Threading.Channels;

namespace PimpMyRideServer.Handlers
{
    public class BackupHandler : Handler
    {
        public ActionResult PerformBackUp() 
        {
            using(GarageContext context = new GarageContext()) 
            {
                string dbName = context.Database.GetDbConnection().Database;
                string dbBackup = Path.Combine(Directory.GetCurrentDirectory(), $"GarageDbBackup_{DateTime.Now:yyyyMMddHHmm}.bak");

                string sqlCommand = $"BACKUP DATABASE [{dbName}] TO DISK = '{dbBackup}' WITH FORMAT, INIT, SKIP, NOREWIND, NOUNLOAD, STATS = 10";

                context.Database.ExecuteSqlRaw(sqlCommand);

                return new StatusCodeResult(200);

            }
        }

        static void PerformBackUpScheduled(object state)
        {
            using (GarageContext context = new GarageContext())
            {
                string dbName = context.Database.GetDbConnection().Database;
                string dbBackup = Path.Combine(Directory.GetCurrentDirectory(), $"GarageDbBackup_{DateTime.Now:yyyyMMddHHmm}.bak");

                string sqlCommand = $"BACKUP DATABASE [{dbName}] TO DISK = '{dbBackup}' WITH FORMAT, INIT, SKIP, NOREWIND, NOUNLOAD, STATS = 10";

                context.Database.ExecuteSqlRaw(sqlCommand);


            }
        }

        public static void ExecuteAtMidnight()
        {
            DateTime desiredTime = DateTime.Today.Add(new TimeSpan(00, 00, 0));

            TimeSpan timeUntilDesiredTime = desiredTime - DateTime.Now;
            if (timeUntilDesiredTime < TimeSpan.Zero)
            {
                timeUntilDesiredTime = timeUntilDesiredTime.Add(TimeSpan.FromDays(1));
            }

            TimerCallback callback = new TimerCallback(PerformBackUpScheduled);
            Timer timer = new Timer(callback, null, timeUntilDesiredTime, TimeSpan.FromDays(1));

        }
    }
}
