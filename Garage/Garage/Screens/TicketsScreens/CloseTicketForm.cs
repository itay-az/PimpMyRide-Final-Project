using Garage.Models;
using Garage.Responses;
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

namespace Garage.Screens.TicketsScreens
{
    public partial class CloseTicketForm : Form
    {
        private string ticketId;

        public CloseTicketForm()
        {

            InitializeComponent();
            closeTicketBtn.Enabled = false;
            setComboBoxItems();
        }
        public CloseTicketForm(double price,string ticketId)
        {

            InitializeComponent();
            closeTicketBtn.Enabled = false;
            setComboBoxItems();
            ticketPriceTxt.Text = price.ToString();
            this.ticketId = ticketId;
        }
        private void setComboBoxItems()
        {
            paymentMethodComboBox.Items.Add("Cash");
            paymentMethodComboBox.Items.Add("Credit card");
        }

        private void paymentMethodComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(paymentMethodComboBox.SelectedIndex == 0)
            {
                closeTicketBtn.Enabled = true;
                changeVisibilityToFalse();
            }
            else
            {
                changeVisibilityToTrue();
            }
        }

        private void changeVisibilityToFalse()
        {
            cardNumberTxt.Visible = false;
            cardDigitsTxt.Visible = false;
            cardDateTxt.Visible = false;

            cardNumberLbl.Visible = false;
            cardDateLbl.Visible = false;
            cardDigitsLbl.Visible = false;



            amountOfPaymentsLbl.Visible = false;
            amountOfPaymentsComboBox.Visible = false;
        }

        private void changeVisibilityToTrue()
        {
            cardNumberTxt.Visible = true;
            cardDigitsTxt.Visible = true;
            cardDateTxt.Visible = true;

            cardNumberLbl.Visible = true;
            cardDateLbl.Visible = true;
            cardDigitsLbl.Visible = true;


            amountOfPaymentsLbl.Visible = true;
            amountOfPaymentsComboBox.Visible = true;    
        }

        private async void CloseTicketById(string ticketId)
        {
            try
            {
                HttpResponseMessage response = await Program.client.DeleteAsync("Tickets/closeTicket/" + ticketId);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Ticket closed!");
                    this.Close();
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void closeTicketBtn_Click(object sender, EventArgs e)
        {
            CloseTicketById(this.ticketId);
        }
    }
}
