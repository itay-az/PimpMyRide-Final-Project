using Garage.Responses;
using Garage.Utils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Garage.Screens.TicketsScreens
{
    // open tickets screen, used for viewing open tickets 
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
            try
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
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        // an http request method that gets all open tickets
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

                    AllTicketsDataGridView.Columns["ticketId"].HeaderText = "Ticket Id";
                    AllTicketsDataGridView.Columns["carId"].HeaderText = "Car Id";
                    AllTicketsDataGridView.Columns["clientId"].HeaderText = "Client Id";
                    AllTicketsDataGridView.Columns["problems"].HeaderText = "Problems";
                    AllTicketsDataGridView.Columns["dateTime"].HeaderText = "Date";
                    AllTicketsDataGridView.Columns["price"].HeaderText = "Price";
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
                    await ErrorHandling.HandleErrorResponse(response);
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
            this.Hide();
            ticket.ShowDialog();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (searchCarNumberTxt.Text == String.Empty)
            {
                MessageBox.Show("Please enter car number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                SearchTicketByCarNumber(searchCarNumberTxt.Text);
        }

        // an http request method that searches for a ticket with the clients car number
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
                    await ErrorHandling.HandleErrorResponse(response);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // an input validation method
        private bool IsValidCarNumber(string carNumber)
        {
            return carNumber.Length <= 8 && IsDigitsOnly(carNumber);
        }

        // an input validation method
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
