using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.Entity;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using PimpMyRideServer.Data;
using PimpMyRideServer.Handlers.Interfaces;
using PimpMyRideServer.Models;
using PimpMyRideServer.Server.Responses;
using System;
using System.Runtime.CompilerServices;
using System.Threading.Channels;

namespace PimpMyRideServer.Handlers
{
    // others handler that inherits from handler interface
    public class OthersHandler : Handler
    {
        // the backup handler for the get request from the controller that performs immiediate backup file - returns status 200 (OK)  and creates a backup file in the server directory
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

        // a function for a timed backup without returning any parameters
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

        // a function for scheduled time backup - currently set for midnight
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

        // function that handles the get monthly statistics http request, routing from the controller,
        // it checks if there are any statistics to retrive
        // if everything checks out it creates a statistics response and retrive it with the status code 200,
        // otherwise it returns a customized failure response
        public ActionResult GetStatistics()
        {
            DateTime today = DateTime.Today;
            DateTime startOfWeek = today.AddDays(-(int)today.DayOfWeek);
            DateTime startOfMonth = new DateTime(today.Year, today.Month, 1);
            DateTime startOfYear = new DateTime(today.Year, 1, 1);

            var todayPrice = GetTotalPriceForDateRange(today, today.AddDays(1));
            var weekPrice = GetTotalPriceForDateRange(startOfWeek, today.AddDays(1));
            var monthPrice = GetTotalPriceForDateRange(startOfMonth, today.AddDays(1));
            var yearPrice = GetTotalPriceForDateRange(startOfYear, today.AddDays(1));

            StatisticsResponse statisticsResponse = new StatisticsResponse
            {
                todaysIncome = todayPrice,
                thisWeeksIncome = weekPrice,
                thisMonthIncome = monthPrice,
                thisYearIncome = yearPrice
            };
            if(statisticsResponse == null)
            {
                return ErrorHandler.onFailure("No statistics found", "Not found");
            }

            JsonResult jsonResults = new JsonResult(statisticsResponse);
            jsonResults.StatusCode = StatusCodes.Status200OK;
            return jsonResults;
        }


        // function that handles the get yearly statistics http request, routing from the controller,
        // it checks if there are any statistics to retrive
        // if everything checks out it creates a statistics response and retrive it with the status code 200,
        // otherwise it returns a customized failure response
        public ActionResult GetStatisticsYearly()
        {
            DateTime today = DateTime.Today;
            int currentYear = today.Year;

            DateTime startOfJanuary = new DateTime(currentYear, 1, 1);
            DateTime endOfJanuary = startOfJanuary.AddMonths(1).AddDays(-1);

            DateTime startOfFebruary = new DateTime(currentYear, 2, 1);
            DateTime endOfFebruary = startOfFebruary.AddMonths(1).AddDays(-1);

            DateTime startOfMarch = new DateTime(currentYear, 3, 1);
            DateTime endOfMarch = startOfMarch.AddMonths(1).AddDays(-1);

            DateTime startOfApril = new DateTime(currentYear, 4, 1);
            DateTime endOfApril = startOfApril.AddMonths(1).AddDays(-1);

            DateTime startOfMay = new DateTime(currentYear, 5, 1);
            DateTime endOfMay = startOfMay.AddMonths(1).AddDays(-1);

            DateTime startOfJune = new DateTime(currentYear, 6, 1);
            DateTime endOfJune = startOfJune.AddMonths(1).AddDays(-1);

            DateTime startOfJuly = new DateTime(currentYear, 7, 1);
            DateTime endOfJuly = startOfJuly.AddMonths(1).AddDays(-1);

            DateTime startOfAugust = new DateTime(currentYear, 8, 1);
            DateTime endOfAugust = startOfAugust.AddMonths(1).AddDays(-1);

            DateTime startOfSeptember = new DateTime(currentYear, 9, 1);
            DateTime endOfSeptember = startOfSeptember.AddMonths(1).AddDays(-1);

            DateTime startOfOctober = new DateTime(currentYear, 10, 1);
            DateTime endOfOctober = startOfOctober.AddMonths(1).AddDays(-1);

            DateTime startOfNovember = new DateTime(currentYear, 11, 1);
            DateTime endOfNovember = startOfNovember.AddMonths(1).AddDays(-1);

            DateTime startOfDecember = new DateTime(currentYear, 12, 1);
            DateTime endOfDecember = startOfDecember.AddMonths(1).AddDays(-1);




            YearlyStatisticsResponse yearlyStatisticsResponse = new YearlyStatisticsResponse
            {
                januaryIncome = GetTotalPriceForDateRange(startOfJanuary, endOfJanuary),
                februaryIncome = GetTotalPriceForDateRange(startOfFebruary, endOfFebruary),
                marchIncome = GetTotalPriceForDateRange(startOfMarch, endOfMarch),
                aprilIncome = GetTotalPriceForDateRange(startOfApril, endOfApril),
                mayIncome = GetTotalPriceForDateRange(startOfMay, endOfMay),
                juneIncome = GetTotalPriceForDateRange(startOfJune, endOfJune),
                julyIncome = GetTotalPriceForDateRange(startOfJuly, endOfJuly),
                augustIncome = GetTotalPriceForDateRange(startOfAugust, endOfAugust),
                septemberIncome = GetTotalPriceForDateRange(startOfSeptember, endOfSeptember),
                octoberIncome = GetTotalPriceForDateRange(startOfOctober, endOfOctober),
                novemberIncome = GetTotalPriceForDateRange(startOfNovember, endOfNovember),
                decemberIncome = GetTotalPriceForDateRange(startOfDecember, endOfDecember),
            };

            if (yearlyStatisticsResponse == null)
            {
                return ErrorHandler.onFailure("No statistics found", "Not found");
            }

            JsonResult jsonResults = new JsonResult(yearlyStatisticsResponse);
            jsonResults.StatusCode = StatusCodes.Status200OK;
            return jsonResults;

        }

        // a function that helps calculate the income range between two periods of time
        private double GetTotalPriceForDateRange(DateTime startDate, DateTime endDate)
        {
            var tickets = Server.Server.context.Ticket.Where(t => t.state == TicketType.IS_CLOSED);
            double price = tickets.Where(t => t.dateTime >= startDate && t.dateTime < endDate).Sum(t => t.price);
            return price;
        }
    }
}
