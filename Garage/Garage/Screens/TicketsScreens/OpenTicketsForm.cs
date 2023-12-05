using Garage.Responses;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Garage.Screens.TicketsScreens
{
    public partial class OpenTicketsForm : Form
    {
        private string ticketId;
        public OpenTicketsForm()
        {
            InitializeComponent();
            GetAllTickets();
        }

        private void AllTicketsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (AllTicketsDataGridView.Rows.Count == 0)
            {
                MessageBox.Show("No open tickets");
            }
            else 
            {
                ticketId = AllTicketsDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }

        public async void GetAllTickets()
        {
            try
            {

                HttpResponseMessage response = await Program.client.GetAsync("Tickets/");
                if (response.IsSuccessStatusCode)
                {

                    var responseResult = await response.Content.ReadAsStringAsync();
                    var jsonResult = JsonConvert.DeserializeObject<List<GetAllTicketsResponse>>(responseResult);

                    AllTicketsDataGridView.DataSource = jsonResult;
                    try
                    {
                        ticketId = AllTicketsDataGridView.Rows[0].Cells[0].Value.ToString();
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("No open tickets");
                    }
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

        private void selectTicketBtn_Click(object sender, EventArgs e)
        {
            Ticket ticket = new Ticket(ticketId);
            ticket.FormClosed += (s, args) => this.Show();
            ticket.ShowDialog();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (searchCarNumberTxt.Text == String.Empty)
            {
                MessageBox.Show("Please enter car number");
            }
            else
                SearchTicketByCarNumber(searchCarNumberTxt.Text);
        }

        private async void SearchTicketByCarNumber(string carNumber)
        {
            try
            {

                HttpResponseMessage response = await Program.client.GetAsync("Tickets/searchTicketByCarNumber/" + carNumber);
                if (response.IsSuccessStatusCode)
                {
                    var responseResult = await response.Content.ReadAsStringAsync();
                    var jsonResult = JsonConvert.DeserializeObject<List<GetAllTicketsResponse>>(responseResult);

                    if(jsonResult.Count == 0)
                    {
                        MessageBox.Show("Not found");
                        GetAllTickets();
                    }
                    else 
                        AllTicketsDataGridView.DataSource = jsonResult;
                
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

        private bool IsValidCarNumber(string carNumber)
        {
            return carNumber.Length <= 8 && IsDigitsOnly(carNumber);
        }

        private bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        private void searchCarNumberTxt_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!IsValidCarNumber(searchCarNumberTxt.Text))
            {
                MessageBox.Show("Invalid car number. Please enter a valid car number with digits and a maximum length of 8 characters.");
                searchCarNumberTxt.Focus();
            }
        }

        private void searchCarNumberTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 )
            {
                e.Handled = true;
            }
        }
    }
}
