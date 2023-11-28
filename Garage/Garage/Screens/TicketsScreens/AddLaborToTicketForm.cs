using Garage.Models;
using Garage.Requests;
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
using static System.Net.Mime.MediaTypeNames;

namespace Garage.Screens.TicketsScreens
{
    public partial class AddLaborToTicketForm : Form
    {
        private int ticketId;


        public AddLaborToTicketForm()
        {
            InitializeComponent();
        }

        public AddLaborToTicketForm(int ticketId)
        {
            InitializeComponent();
            GetAllLabors();
        }

        public async void GetAllLabors()
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
                MessageBox.Show("Error");
            }
        }

        private async void searchForPartByFreeText(string text)
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
            }
        }

        private void searchPartBtn_Click(object sender, EventArgs e)
        {
            searchForPartByFreeText(searchLaborTxt.Text);
        }
    }
}
