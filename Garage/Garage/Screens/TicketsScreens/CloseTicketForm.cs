﻿using Garage.Models;
using Garage.Responses;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        private void cardDigitsTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cardDigitsTxt.Text.Length >= 3)
            {
                e.Handled = true;
            }
        }

        private void cardDateTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != '/' )
            {
                e.Handled = true;
            }
        }

        private void cardDateTxt_TextChanged(object sender, EventArgs e)
        {

            if (cardDateTxt.Text.Length == 2 && !cardDateTxt.Text.Contains("/"))
            {
                cardDateTxt.Text += "/";
                cardDateTxt.SelectionStart = cardDateTxt.Text.Length;
            }

            // Limit the total length to 7 characters
            if (cardDateTxt.Text.Length > 7)
            {
                cardDateTxt.Text = cardDateTxt.Text.Substring(0, 7);
                cardDateTxt.SelectionStart = cardDateTxt.Text.Length;
            }

        }

        private void cardDateTxt_Validating(object sender, CancelEventArgs e)
        {
            if (!IsValidDate(cardDateTxt.Text))
            {
                MessageBox.Show("Invalid date format. Please enter a valid date in mm/yyyy format.");
                cardDateTxt.Focus();
            }
        }

        private bool IsValidDate(string date)
        {
            return DateTime.TryParseExact(date, "MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out _);
        }

        private bool IsValidCreditCard(string creditCardNumber)
        {
            string strippedCreditCardNumber = creditCardNumber.Replace("-", "");

            return strippedCreditCardNumber.Length == 16 && long.TryParse(strippedCreditCardNumber, out _);
        }

        private void cardNumberTxt_Validating(object sender, CancelEventArgs e)
        {
            if (!IsValidCreditCard(cardNumberTxt.Text))
            {
                MessageBox.Show("Invalid credit card number. Please enter a valid credit card number.");
                cardNumberTxt.Focus();
            }
        }

        private void cardNumberTxt_TextChanged(object sender, EventArgs e)
        {
            if (cardNumberTxt.Text.Length == 4 || cardNumberTxt.Text.Length == 9 || cardNumberTxt.Text.Length == 14)
            {
                cardNumberTxt.Text += "-";
                cardNumberTxt.SelectionStart = cardNumberTxt.Text.Length;
            }

                if (cardNumberTxt.Text.Length > 19)
            {
                cardNumberTxt.Text = cardNumberTxt.Text.Substring(0, 19);
                cardNumberTxt.SelectionStart = cardNumberTxt.Text.Length;
            }
        }

        private void cardNumberTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8  && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }
    }
}
