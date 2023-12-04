using Garage.Models;
using Garage.Requests;
using Garage.Responses;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Garage.Screens.TicketsScreens
{
    public partial class AddLaborToTicketForm : Form
    {
        private int ticketId;
        private Labor labor = new Labor();

        public AddLaborToTicketForm()
        {
            InitializeComponent();
        }

        public AddLaborToTicketForm(int ticketId)
        {
            InitializeComponent();
            this.ticketId = ticketId;
            GetAllLabors();
        }

        public async void GetAllLabors()
        {
            try
            {

                HttpResponseMessage response = await Program.client.GetAsync("Tickets/getLabors");
                if (response.IsSuccessStatusCode)
                {
                    var responseResult = await response.Content.ReadAsStringAsync();
                    var jsonResult = JsonConvert.DeserializeObject<List<Labor>>(responseResult);
                    allLaborsDataGridView.DataSource = jsonResult;
                }
                else
                {
                    await HandleErrorResponse(response);                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void searchForPartByFreeText(string text)
        {
            try
            {

                HttpResponseMessage response = await Program.client.GetAsync("Tickets/searchLabor/" + text);
                if (response.IsSuccessStatusCode)
                {

                    var responseResult = await response.Content.ReadAsStringAsync();
                    var jsonResult = JsonConvert.DeserializeObject<List<Labor>>(responseResult);



                    allLaborsDataGridView.DataSource = jsonResult;
                }
                else
                {
                    GetAllLabors();
                    await HandleErrorResponse(response);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void searchPartBtn_Click(object sender, EventArgs e)
        {
            searchForPartByFreeText(searchLaborTxt.Text);
        }

        private void addPartToTicketBtn_Click(object sender, EventArgs e)
        {
            AddLaorToTicketAsync(labor);
        }

        private async void AddLaorToTicketAsync(Labor labor)
        {
            try
            {
                HttpResponseMessage response = await Program.client.PutAsJsonAsync("Tickets/addLaborToTicket/" + ticketId, labor);
                if (response.IsSuccessStatusCode)
                {
                    Ticket ticket = new Ticket(ticketId.ToString());
                    this.Close();
                    ticket.ShowDialog();

                }
                else
                {
                    await HandleErrorResponse(response);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void allLaborsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            labor.Id = int.Parse(allLaborsDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            labor.description = allLaborsDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            labor.price = decimal.Parse(allLaborsDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString());
            labor.time = decimal.Parse(allLaborsDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString());
            labor.discount = 0;
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
    }
}
