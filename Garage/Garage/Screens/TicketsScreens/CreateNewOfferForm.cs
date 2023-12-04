﻿using Garage.Models;
using Garage.Requests;
using Garage.Responses;
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
using System.Windows.Forms;

namespace Garage.Screens.TicketsScreens
{
    public partial class CreateNewOfferForm : Form
    {
        private string clientId;

        public CreateNewOfferForm()
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
            if (carNumberTxt.Text != String.Empty)
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
            }
            else if ((int)response.StatusCode == 404)
            {
                MessageBox.Show("Car not found, Create new?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (MessageBoxButtons.YesNo != 0)
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

        private void createOfferBtn_Click(object sender, EventArgs e)
        {
            if (offerDetailsTxt.Text == String.Empty)
            {
                MessageBox.Show("Details are required");
            }

            createNewOffer();
        }

        public async void createNewOffer()
        {
            CreateNewTicketRequest createNewTicketRequest = new CreateNewTicketRequest(carNumberTxt.Text, clientManufactureTxt.Text, clientModelTxt.Text, clientEngineTxt.Text, int.Parse(clientYearTxt.Text), clientVinNumberTxt.Text, clientId, clientFullNameTxt.Text, clientPhoneNumberTxt.Text, clientEmailTxt.Text, offerDetailsTxt.Text);
            HttpResponseMessage response = await Program.client.PostAsJsonAsync("Tickets/createOffer", createNewTicketRequest);
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Ticket Created!");

            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
