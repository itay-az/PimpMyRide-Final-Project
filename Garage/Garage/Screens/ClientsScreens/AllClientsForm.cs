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

namespace Garage.Screens.ClientsScreens
{
    public partial class AllClientsForm : Form
    {
        public AllClientsForm()
        {
            InitializeComponent();
            GetAllClients();
        }

        public async void GetAllClients()
        {
            HttpResponseMessage response = await Program.client.GetAsync("client/");
            if (response.IsSuccessStatusCode)
            {

                var responseResult = await response.Content.ReadAsStringAsync();
                var jsonResult = JsonConvert.DeserializeObject<List<GetAllClientRequest>>(responseResult);



                AllClientsGridView.DataSource = jsonResult;
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void AllClientsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'garageDataSet1.Clients' table. You can move, or remove it, as needed.
            this.clientsTableAdapter.Fill(this.garageDataSet1.Clients);

        }
    }
}
