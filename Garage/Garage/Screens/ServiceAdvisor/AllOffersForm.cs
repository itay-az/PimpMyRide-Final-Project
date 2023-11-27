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

namespace Garage.Screens.ServiceAdvisor
{
    public partial class AllOffersForm : Form
    {
        public AllOffersForm()
        {
            InitializeComponent();
            GetAllOffers();
        }

        public async void GetAllOffers()
        {
            HttpResponseMessage response = await Program.client.GetAsync("user/");
            if (response.IsSuccessStatusCode)
            {
                string result = await response.Content.ReadAsStringAsync();
                List<GetAllOffersRequest> list = JsonConvert.DeserializeObject<List<GetAllOffersRequest>>(result);

                allOffersGridView.DataSource = list;
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void AllOffersForm_Load(object sender, EventArgs e)
        {

        }
    }
}
