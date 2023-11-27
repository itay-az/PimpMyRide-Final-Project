using Garage.Models;
using Garage.Requests;
using Garage.Responses;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Garage.Screens.TicketsScreens
{
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

        public async void GetAllParts()
        {
            HttpResponseMessage response = await Program.client.GetAsync("StorageHandler/getParts/");
            if (response.IsSuccessStatusCode)
            {
                var responseResult = await response.Content.ReadAsStringAsync();
                var jsonResult = JsonConvert.DeserializeObject<List<GetAllPartsRequest>>(responseResult);
                allPartsDataGridView.DataSource = jsonResult;
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void searchPartBtn_Click(object sender, EventArgs e)
        {
            searchForPartByFreeText(searchPartTxt.Text);
        }

        private async void  searchForPartByFreeText(string text)
        {
            HttpResponseMessage response = await Program.client.GetAsync("StorageHandler/searchPart/" + text);
            if (response.IsSuccessStatusCode)
            {

                var responseResult = await response.Content.ReadAsStringAsync();
                var jsonResult = JsonConvert.DeserializeObject<List<Parts>>(responseResult);



                allPartsDataGridView.DataSource = jsonResult;
            }
            else
            {
                GetAllParts();
            }
        }


        private async void AddPartToTicketAsync(AddPartToTicketRequest part)
        {
            if(part.partId == null)
            {
                MessageBox.Show("Error");
            }
            else
            {
                HttpResponseMessage response = await Program.client.PutAsJsonAsync("Tickets/addPartToTicket/" + ticketId, part);
                if (response.IsSuccessStatusCode)
                {

                    Ticket ticket = new Ticket(ticketId.ToString());
                    this.Close();
                    ticket.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            
        }


        private void allPartsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void addPartToTicketBtn_Click(object sender, EventArgs e)
        {
            if(isValid(partAmountTxt.Text))
            {
                part.quantity = decimal.Parse(partAmountTxt.Text);
                part.price *= part.quantity;
                AddPartToTicketAsync(part);
            }
            else
                MessageBox.Show("All inputs are required!");

        }

        private bool isValid(string partAmountTxt)
        {
            try
            {
                decimal check = decimal.Parse(partAmountTxt);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

        }
    }
}
