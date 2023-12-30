using Garage.Responses;
using Garage.Screens.TicketsScreens;
using Garage.Utils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;

using System.Windows.Forms;

namespace Garage.Screens.ClientsScreens
{
    // car history, used for viewing the car history
    public partial class CarHistoryForm : Form
    {
        private string ticketId;

        public CarHistoryForm()
        {
            InitializeComponent();
        }
        public CarHistoryForm(string carId)
        {
            InitializeComponent();
            GetCarHistoryByCarId(carId);
        }

        // an http request method that for getting the car history
        private async void GetCarHistoryByCarId(string carId)
        {
            try
            {
                HttpResponseMessage response = await Program.client.GetAsync("client/getHistory/" + carId);

                if (response.IsSuccessStatusCode)
                {
                    var responseResult = await response.Content.ReadAsStringAsync();
                    var jsonResult = JsonConvert.DeserializeObject<List<Models.Ticket>>(responseResult);

                    carHistoryDataGridView.DataSource = jsonResult;
                    ticketId = carHistoryDataGridView.Rows[0].Cells[0].Value.ToString();

                    
                    carHistoryDataGridView.Columns["ticketId"].HeaderText = "Ticket Id";
                    carHistoryDataGridView.Columns["carId"].HeaderText = "Car Number";
                    carHistoryDataGridView.Columns["clientId"].HeaderText = "Client Id";
                    carHistoryDataGridView.Columns["dateTime"].HeaderText = "Date";
                    carHistoryDataGridView.Columns["price"].HeaderText = "Total price";
                    carHistoryDataGridView.Columns["state"].HeaderText = "State";

                }

                else
                {
                    await ErrorHandling.HandleErrorResponse(response);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void selectTicketBtn_Click(object sender, EventArgs e)
        {
            Ticket ticket = new Ticket(ticketId);
            ticket.FormClosed += (s, args) => this.Show();
            ticket.ShowDialog();
        }

        private void carHistoryDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (carHistoryDataGridView.Rows.Count == 0)
                {
                    MessageBox.Show("No history");
                }
                else
                {
                    this.ticketId = carHistoryDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
