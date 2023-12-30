using Garage.Models;
using Garage.Responses;
using Garage.Utils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static iText.StyledXmlParser.Jsoup.Select.Evaluator;

namespace Garage.Screens.AdminScreens
{
    // statistics form, used for viewing the income statistics both yearly and monthly
    public partial class StatisticsForm : Form
    {

        public StatisticsForm()
        {
            InitializeComponent();

        }

        // an http request method that for getting the monthly statistics
        private async void GetIncome()
        {
            try
            {
                HttpResponseMessage response = await Program.client.GetAsync("statistics");
                if (response.IsSuccessStatusCode)
                {
                    var responseResult = await response.Content.ReadAsStringAsync();
                    var jsonResult = JsonConvert.DeserializeObject<StatisticsResponse>(responseResult);


                    statisticsChart.Series["Income"].Points.AddXY("Today", jsonResult.todaysIncome);
                    statisticsChart.Series["Income"].Points.AddXY("This Week", jsonResult.thisWeeksIncome);
                    statisticsChart.Series["Income"].Points.AddXY("This Month", jsonResult.thisMonthIncome);
                    statisticsChart.Series["Income"].Points.AddXY("This Year", jsonResult.thisYearIncome);
                }
                else
                {
                    await ErrorHandling.HandleErrorResponse(response);
                }
                try
                {
                    GetYearlyIncome();

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void StatisticsForm_Load(object sender, EventArgs e)
        {
            try
            {
                GetIncome();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // an http request method that for getting the yearly statistics
        private async void GetYearlyIncome()
        {
            try
            {
                HttpResponseMessage response = await Program.client.GetAsync("statistics/yearly");
                if (response.IsSuccessStatusCode)
                {
                    var responseResult = await response.Content.ReadAsStringAsync();
                    var jsonResult = JsonConvert.DeserializeObject<YearlyStatisticsResponse>(responseResult);

                    yearlyIncomeChart.Series.Clear();
                    Series series = new Series("Income");

                    for (int month = 1; month <= 12; month++)
                    {
                        double income = GetIncomeForMonth(jsonResult, month);
                        series.Points.AddXY(month, income);
                    }

                    yearlyIncomeChart.Series.Add(series);

                    for (int i = 1; i <= 12; i++)
                    {
                        yearlyIncomeChart.Series["Income"].Points[i - 1].AxisLabel = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(i);
                    }

                    yearlyIncomeChart.ChartAreas[0].AxisX.Minimum = 1;
                    yearlyIncomeChart.ChartAreas[0].AxisX.Maximum = 12;
                }
                else
                {
                    await ErrorHandling.HandleErrorResponse(response);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // a method for getting statistics per month
        private double GetIncomeForMonth(YearlyStatisticsResponse statistics, int month)
        {
            switch (month)
            {
                case 1: return statistics.januaryIncome;
                case 2: return statistics.februaryIncome;
                case 3: return statistics.marchIncome;
                case 4: return statistics.aprilIncome;
                case 5: return statistics.mayIncome;
                case 6: return statistics.juneIncome;
                case 7: return statistics.julyIncome;
                case 8: return statistics.augustIncome;
                case 9: return statistics.septemberIncome;
                case 10: return statistics.octoberIncome;
                case 11: return statistics.novemberIncome;
                case 12: return statistics.decemberIncome;
                default: return 0;
            }
        }

    }
}
