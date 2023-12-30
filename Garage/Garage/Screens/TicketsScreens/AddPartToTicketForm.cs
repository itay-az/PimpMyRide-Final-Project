using Garage.Models;
using Garage.Requests;
using Garage.Responses;
using Garage.Utils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Garage.Screens.TicketsScreens
{
    // add part to ticket form, used for viewing and adding parts to ticket
    public partial class AddPartToTicketForm : Form
    {
        private int ticketId;
        private AddPartToTicketRequest part = new AddPartToTicketRequest();
        public AddPartToTicketForm()
        {
            InitializeComponent();
            GetAllParts();
        }

        public AddPartToTicketForm(int ticketId)
        {
            InitializeComponent();
            GetAllParts();
            this.ticketId = ticketId;
        }

        // an http request method for getting all parts
        public async void GetAllParts()
        {
            try
            {
                HttpResponseMessage response = await Program.client.GetAsync("StorageHandler/getParts/");
                if (response.IsSuccessStatusCode)
                {
                    var responseResult = await response.Content.ReadAsStringAsync();
                    var jsonResult = JsonConvert.DeserializeObject<List<GetAllPartsRequest>>(responseResult);
                    allPartsDataGridView.DataSource = jsonResult;

                    allPartsDataGridView.Columns["partId"].HeaderText = "Part Id";
                    allPartsDataGridView.Columns["partName"].HeaderText = "Part Name";
                    allPartsDataGridView.Columns["price"].HeaderText = "Price";
                    allPartsDataGridView.Columns["quantity"].HeaderText = "Quantity";
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

        private void searchPartBtn_Click(object sender, EventArgs e)
        {
            searchForPartByFreeText(searchPartTxt.Text);
        }

        // an http request method that searches a part with free text
        private async void  searchForPartByFreeText(string text)
        {
            try
            {
                HttpResponseMessage response = await Program.client.GetAsync("StorageHandler/searchPart/" + text);
                if (response.IsSuccessStatusCode)
                {
                    var responseResult = await response.Content.ReadAsStringAsync();
                    var jsonResult = JsonConvert.DeserializeObject<List<Parts>>(responseResult);

                    allPartsDataGridView.DataSource = jsonResult;

                    allPartsDataGridView.Columns["partId"].HeaderText = "Part Id";
                    allPartsDataGridView.Columns["partName"].HeaderText = "Part Name";
                    allPartsDataGridView.Columns["price"].HeaderText = "Price";
                    allPartsDataGridView.Columns["quantity"].HeaderText = "Quantity";
                }
                else
                {
                    GetAllParts();
                    await ErrorHandling.HandleErrorResponse(response);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // an http request method for adding a part to a ticket
        private async void AddPartToTicketAsync(AddPartToTicketRequest part)
        {
            if(part.partId == null)
            {
                MessageBox.Show("Error");
            }
            else
            {
                try
                {
                    HttpResponseMessage response = await Program.client.PutAsJsonAsync("Tickets/addPartToTicket/" + ticketId, part);
                    if (response.IsSuccessStatusCode)
                    {
                        this.Close();
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
            
        }


        private void allPartsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                part = new AddPartToTicketRequest
                {
                    partId = allPartsDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString(),
                    partName = allPartsDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString(),
                    price = decimal.Parse(allPartsDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString()),
                    quantity = 0,
                    discount = 0
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void addPartToTicketBtn_Click(object sender, EventArgs e)
        {
            if(isValid(partAmountTxt.Text))
            {
                part.quantity = decimal.Parse(partAmountTxt.Text);
                part.unitPrice = part.price;
                part.price *= part.quantity;
                AddPartToTicketAsync(part);
            }
            else
                MessageBox.Show("Please select from the list", "Error", MessageBoxButtons.OK);

        }

        // an input validation method
        private bool isValid(string partAmountTxt)
        {
            try
            {
                decimal check = decimal.Parse(partAmountTxt);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error");
                return false;
            }
        }

    }
}
