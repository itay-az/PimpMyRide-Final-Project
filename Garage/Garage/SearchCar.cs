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

namespace Garage
{
    public partial class SearchCar : Form
    {
        private string searchParam = "carId";
        public SearchCar()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true)
            {
                searchParam = "carId";
                searchLbl.Text = "Enter car number:";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                searchLbl.Text = "Enter client id:";
                searchParam = "clients.id";
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                searchLbl.Text = "Enter Client phone number:";
                searchParam = "clients.phone";
            }
        }

        private async void searchBtn_Click(object sender, EventArgs e)
        {
            if (searchInputTxt.Text == String.Empty )
            {
                MessageBox.Show("No input", "Error");
                return;
            }
            string payload = JsonConvert.SerializeObject(new
            {
                param = searchParam,
                queryString = searchInputTxt.Text
            });

            StringContent content = new StringContent(payload, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await Program.client.PostAsync(Program.url + "searchCar", content);

            if (!response.IsSuccessStatusCode)
            {
                MessageBox.Show(response.ReasonPhrase.ToString(), "Error");
                return;
            }

            MessageBox.Show("success");
        
        }
    }
}
