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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                MessageBox.Show("Error");
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
