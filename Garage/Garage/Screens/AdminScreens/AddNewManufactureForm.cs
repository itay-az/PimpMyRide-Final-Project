﻿using Garage.Models;
using Garage.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Net.Http;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Garage.Screens.AdminScreens
{
    public partial class AddNewManufactureForm : Form
    {
        public AddNewManufactureForm()
        {
            InitializeComponent();
        }

        private void addManufactureWithModelBtn_Click(object sender, EventArgs e)
        {
            CreateManufactureWithModel(addManufactureNameTxt.Text,addModelNameTxt.Text);
        }

        private async void CreateManufactureWithModel(string manufactureName, string modelName)
        {

            CreateManufactureWithModelRequest createManufactureWithModelRequest = new CreateManufactureWithModelRequest(manufactureName, modelName);

            HttpResponseMessage response = await Program.client.PostAsJsonAsync(
               "StorageHandler/", createManufactureWithModelRequest);

            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                MessageBox.Show("Manufacture " + createManufactureWithModelRequest.manufacturerName + " model " + createManufactureWithModelRequest.modelName + " added successfully", "success");

                this.Close();
            }
            else if (response.StatusCode.Equals(HttpStatusCode.Conflict))
            {
                MessageBox.Show("Manufacture " + createManufactureWithModelRequest.manufacturerName + " model " + createManufactureWithModelRequest.modelName + " Already exists", "conflict");

            }
            else
            {
                MessageBox.Show(" Failed ", "Error");
            }
        }

        private void deleteModelBtn_Click(object sender, EventArgs e)
        {
            DeleteManufactureAndModel(addManufactureNameTxt.Text, addModelNameTxt.Text);
        }

        private async void DeleteManufactureAndModel(string manufactureName, string modelName)
        {
            HttpResponseMessage response = await Program.client.DeleteAsync("StorageHandler/removeModel/" + manufactureName + "/" + modelName);
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Deleted successfully", "success");
                this.Close();
            }
            else
            {
                MessageBox.Show(" Failed ", "Error");
            }
        }
    }
}
