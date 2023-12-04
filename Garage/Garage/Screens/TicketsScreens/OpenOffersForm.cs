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
    public partial class OpenOffersForm : Form
    {
        private string ticketId;

        public OpenOffersForm()
        {
            InitializeComponent();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (searchCarNumberTxt.Text == String.Empty)
            {
                MessageBox.Show("Please enter car number");
            }
            else
                SearchOfferByCarNumber(searchCarNumberTxt.Text);
        }

        private async void SearchOfferByCarNumber(string carNumber)
        {
            HttpResponseMessage response = await Program.client.GetAsync("Tickets/searchOfferByCarNumber/" + carNumber);
            if (response.IsSuccessStatusCode)
            {
                var responseResult = await response.Content.ReadAsStringAsync();
                var jsonResult = JsonConvert.DeserializeObject<List<GetAllTicketsResponse>>(responseResult);

                if (jsonResult.Count == 0)
                {
                    MessageBox.Show("Not found");
                    return;
                }
                
                AllOffersDataGridView.DataSource = jsonResult;
                ticketId = AllOffersDataGridView.Rows[0].Cells[0].Value.ToString();


            }

        }

        private void selectTicketBtn_Click(object sender, EventArgs e)
        {
            Ticket ticket = new Ticket(ticketId);
            ticket.FormClosed += (s, args) => this.Show();
            ticket.ShowDialog();
        }
    }
}
