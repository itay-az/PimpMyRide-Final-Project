using Garage.Responses;
using Garage.Screens.TicketsScreens;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Garage.Screens.ClientsScreens
{
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
                }

                else
                {
                    await HandleErrorResponse(response);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private async Task HandleErrorResponse(HttpResponseMessage response)
        {
            string content = await response.Content.ReadAsStringAsync();

            try
            {
                ErrorResponse errorResponse = JsonConvert.DeserializeObject<ErrorResponse>(content);

                MessageBox.Show($"Error: {errorResponse.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (JsonException)
            {
                MessageBox.Show("Invalid response format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (carHistoryDataGridView.Rows.Count == 0)
            {
                MessageBox.Show("No open tickets");
            }
            else
            {
                this.ticketId = carHistoryDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }
    }
}
