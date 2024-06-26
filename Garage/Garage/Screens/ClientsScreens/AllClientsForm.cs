﻿using Garage.Models;
using Garage.Requests;
using Garage.Utils;
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
    // all clients form, used for viewing all clients
    public partial class AllClientsForm : Form
    {
        public AllClientsForm()
        {
            InitializeComponent();
            try
            {

                GetAllClients();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        // an http request method that for getting all clients
        public async void GetAllClients()
        {
            try
            {

                HttpResponseMessage response = await Program.client.GetAsync("client/");
                if (response.IsSuccessStatusCode)
                {

                    var responseResult = await response.Content.ReadAsStringAsync();
                    var jsonResult = JsonConvert.DeserializeObject<List<GetAllClientRequest>>(responseResult);

                    AllClientsGridView.DataSource = jsonResult;


                    AllClientsGridView.Columns["clientId"].HeaderText = "Id";
                    AllClientsGridView.Columns["name"].HeaderText = "Client Name";
                    AllClientsGridView.Columns["phone"].HeaderText = "Client Phone";
                    AllClientsGridView.Columns["email"].HeaderText = "Email";
                    AllClientsGridView.Columns["address"].HeaderText = "Client address";
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

    }
}
