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
    public partial class StatisticsForm : Form
    {
        private double todaysIncome;
        private double thisWeeksIncome;
        private double thisMonthIncome;
        private double thisYearIncome;

        public StatisticsForm()
        {
            InitializeComponent();

        }

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

                    // Set custom labels for the X-axis
                    for (int i = 1; i <= 12; i++)
                    {
                        yearlyIncomeChart.Series["Income"].Points[i - 1].AxisLabel = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(i);
                    }

                    // Set the minimum and maximum values for the X-axis
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

        private double GetIncomeForMonth(YearlyStatisticsResponse jsonResult, int month)
{
    switch (month)
    {
        case 1: return jsonResult.januaryIncome;
        case 2: return jsonResult.februaryIncome;
        case 3: return jsonResult.marchIncome;
        case 4: return jsonResult.aprilIncome;
        case 5: return jsonResult.mayIncome;
        case 6: return jsonResult.juneIncome;
        case 7: return jsonResult.julyIncome;
        case 8: return jsonResult.augustIncome;
        case 9: return jsonResult.septemberIncome;
        case 10: return jsonResult.octoberIncome;
        case 11: return jsonResult.novemberIncome;
        case 12: return jsonResult.decemberIncome;
        default: return 0; // Default to 0 if month is out of range
    }
}

    }
}
