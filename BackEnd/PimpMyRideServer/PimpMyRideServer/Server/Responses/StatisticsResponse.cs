namespace PimpMyRideServer.Server.Responses
{
    public class StatisticsResponse
    {
        public double todaysIncome { get; set; }
        public double thisWeeksIncome { get; set; }
        public double thisMonthIncome { get; set; }
        public double thisYearIncome { get; set; }
    }

    public class YearlyStatisticsResponse
    {
        public double januaryIncome { get; set; }
        public double februaryIncome { get; set; }
        public double marchIncome { get; set; }
        public double aprilIncome { get; set; }
        public double mayIncome { get; set; }
        public double juneIncome { get; set; }
        public double julyIncome { get; set; }
        public double augustIncome { get; set; }
        public double septemberIncome { get; set; }
        public double octoberIncome { get; set; }
        public double novemberIncome { get; set; }
        public double decemberIncome { get; set; }

    }
}
