using Garage.Models;
using Garage.Requests;
using Garage.Responses;
using Garage.Screens.AdminScreens;
using Garage.Screens.ClientsScreens;
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
using System.Web.Mvc;
using System.Windows.Forms;

namespace Garage.Screens.TicketsScreens
{
    public partial class CreateNewTicketForm : Form
    {
        private string clientId;
        private List<CauseOfArrival> causesOfArrival = new List<CauseOfArrival>();
        public CreateNewTicketForm()
        {
            InitializeComponent();
            clientManufactureTxt.ReadOnly = true;
            clientModelTxt.ReadOnly = true;
            clientYearTxt.ReadOnly = true;
            clientEngineTxt.ReadOnly = true;
            clientVinNumberTxt.ReadOnly = true;
        }

        private void searchClientBtn_Click(object sender, EventArgs e)
        {
            if(carNumberTxt.Text != String.Empty)
            {
                searchClientByCarId(carNumberTxt.Text);
            }
        }

        public async void searchClientByCarId(string id)
        {
            HttpResponseMessage response = await Program.client.GetAsync("client/getCarByCarId/" + id);

            if (response.IsSuccessStatusCode)
            {
                var responseResult = await response.Content.ReadAsStringAsync();
                var jsonResult = JsonConvert.DeserializeObject<GetCarByCarIdResponse>(responseResult);

                this.clientId = jsonResult.clientId;
                clientFullNameTxt.Text = jsonResult.clientFullName;
                clientPhoneNumberTxt.Text = jsonResult.clientPhoneNumber;
                clientEmailTxt.Text = jsonResult.clientEmail;
                clientManufactureTxt.Text = jsonResult.carManufacture;
                clientModelTxt.Text = jsonResult.carModel;
                clientYearTxt.Text = jsonResult.carYear.ToString();
                clientEngineTxt.Text = jsonResult.carEngine;
                clientVinNumberTxt.Text = jsonResult.vinNumber;
                clientKmTxt.Text = jsonResult.carKilometer.ToString();
            }
            else if((int)response.StatusCode == 404)
            {
                MessageBox.Show("Car not found, Create new?","Error",MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if(MessageBoxButtons.YesNo != 0)
                {
                    SearchClientForm searchClientForm = new SearchClientForm();
                    LoginForm.dashboardForm.openForm(searchClientForm);
                }

            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        public async void createNewTicket()
        {
            CreateNewTicketRequest createNewTicketRequest = new CreateNewTicketRequest(carNumberTxt.Text,clientManufactureTxt.Text,clientModelTxt.Text,clientEngineTxt.Text,int.Parse(clientYearTxt.Text),int.Parse(clientKmTxt.Text),clientVinNumberTxt.Text,clientId,clientFullNameTxt.Text,clientPhoneNumberTxt.Text,clientEmailTxt.Text, cuaseOfArrivalTxt.Text);
            HttpResponseMessage response = await Program.client.PostAsJsonAsync("Tickets/", createNewTicketRequest);
            if(response.IsSuccessStatusCode)
            {
                MessageBox.Show("Ticket Created!");

            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void createTicketbtn_Click(object sender, EventArgs e)
        {
            if(cuaseOfArrivalTxt.Text != String.Empty)
            {
                causesOfArrival.Add(new CauseOfArrival(0,cuaseOfArrivalTxt.Text));
            }

            createNewTicket();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void vinNumberTxt_Enter(object sender, EventArgs e)
        {

        }

        private void carNumberTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void carNumberLbl_Click(object sender, EventArgs e)
        {

        }

        private void clientFullNameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void clientVinNumberTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void clientKmTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void clientEngineTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void clientYearTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void clientModelTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void clientManufactureTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void clientEmailTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void clientPhoneNumberTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cuaseOfArrivalTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
