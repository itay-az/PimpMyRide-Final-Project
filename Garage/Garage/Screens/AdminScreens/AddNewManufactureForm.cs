using Garage.Models;
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
using Garage.Utils;

namespace Garage.Screens.AdminScreens
{
    // add manufacture screen, used to add new manufacture and model to the database
    public partial class AddNewManufactureForm : Form
    {
        public AddNewManufactureForm()
        {
            InitializeComponent();
        }

        private void addManufactureWithModelBtn_Click(object sender, EventArgs e)
        {
            CreateManufactureWithModel(addManufactureNameTxt.Text, addModelNameTxt.Text);
        }

        // an http request method that for adding the manufacture and model
        private async void CreateManufactureWithModel(string manufactureName, string modelName)
        {

            CreateManufactureWithModelRequest createManufactureWithModelRequest = new CreateManufactureWithModelRequest(manufactureName, modelName);

            HttpResponseMessage response = await Program.client.PostAsJsonAsync(
               "StorageHandler/", createManufactureWithModelRequest);

            try
            {

                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    MessageBox.Show("Manufacture " + createManufactureWithModelRequest.manufacturerName + " model " + createManufactureWithModelRequest.modelName + " added successfully", "success");

                    this.Hide();
                }
                else if (response.StatusCode.Equals(HttpStatusCode.Conflict))
                {
                    MessageBox.Show("Manufacture " + createManufactureWithModelRequest.manufacturerName + " model " + createManufactureWithModelRequest.modelName + " Already exists", "conflict");

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

        private void deleteModelBtn_Click(object sender, EventArgs e)
        {
            DeleteManufactureAndModel(addManufactureNameTxt.Text, addModelNameTxt.Text);
        }

        // an http request method that for deleting the manufacture and model

        private async void DeleteManufactureAndModel(string manufactureName, string modelName)
        {
            HttpResponseMessage response = await Program.client.DeleteAsync("StorageHandler/removeModel/" + manufactureName + "/" + modelName);
            try
            {

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Deleted successfully", "success");
                    this.Hide();
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