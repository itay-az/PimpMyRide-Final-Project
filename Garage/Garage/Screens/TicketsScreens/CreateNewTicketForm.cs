using Garage.Models;
using Garage.Requests;
using Garage.Responses;
using Garage.Screens.AdminScreens;
using Garage.Screens.ClientsScreens;
using Garage.Utils;
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
    // create new ticket scree, used for creating a new ticket to clients
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

        // an http request method that searches a client with his car number
        public async void searchClientByCarId(string id)
        {
            try
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
                    await ErrorHandling.HandleErrorResponse(response);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        // an http request method that creates a new ticket
        public async void createNewTicket()
        {
            try
            {
                CreateNewTicketRequest createNewTicketRequest = new CreateNewTicketRequest(carNumberTxt.Text,clientManufactureTxt.Text,clientModelTxt.Text,clientEngineTxt.Text
                    ,int.Parse(clientYearTxt.Text),int.Parse(clientKmTxt.Text),clientVinNumberTxt.Text,clientId,clientFullNameTxt.Text,
                    clientPhoneNumberTxt.Text,clientEmailTxt.Text, cuaseOfArrivalTxt.Text);
                HttpResponseMessage response = await Program.client.PostAsJsonAsync("Tickets/", createNewTicketRequest);
                if(response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Ticket Created!");
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

        private void createTicketbtn_Click(object sender, EventArgs e)
        {
            if(cuaseOfArrivalTxt.Text != String.Empty)
            {
                causesOfArrival.Add(new CauseOfArrival(0,cuaseOfArrivalTxt.Text));
            }

            createNewTicket();
        }

        
    }
}
