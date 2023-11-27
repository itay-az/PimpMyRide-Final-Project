using Garage.Models;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Garage.Screens.ServiceAdvisor
{
    public partial class SearchClientForm : Form
    {
        private string url = "client/client";
        private string searchParams = "clientId";
        public SearchClientForm()
        {
            InitializeComponent();
        }



        private void searchClientBtn_Click(object sender, EventArgs e)
        {
            if(inputTxt.Text == String.Empty)
            {
                MessageBox.Show("Error", "Please enter value");
            }
            GetCarById(inputTxt.Text);
        }

        private async void GetCarById(string id )
        {
            HttpResponseMessage response = await Program.client.GetAsync(url + id);
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                Client client = JsonConvert.DeserializeObject<Client>(result);
                Console.WriteLine(client.name);
            }
            else
            {
                MessageBox.Show("Error", " UserNotFound");
            }
        }

        private void clientIdRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if(clientIdRadioBtn.Checked == true)
            {
                searchParams = "clientId";
                url = "client/client/";
            }
            
        }

        private void carIdRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (clientIdRadioBtn.Checked == true)
            {
                searchParams = "carId";
                url = "client/car/";
            }
        }
    }
}
