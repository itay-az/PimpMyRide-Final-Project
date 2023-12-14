using Garage.Models;
using Garage.Requests;
using Garage.Responses;
using Garage.Utils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Garage.Screens.StorageScreens
{
    public partial class AllPartsForm : Form
    {
        public AllPartsForm()
        {
            InitializeComponent();
            GetAllParts();
        }

        private bool ValidationTestsOnInput()
        {
            if(Decimal.Parse(partPriceTxt.Text) <= 0 || Decimal.Parse(quantityTxt.Text) <= 0)
            {
                MessageBox.Show("Price or quantity cannot be less or equal to 0","Error", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }

        public async void GetAllParts()
        {
            try
            {
                HttpResponseMessage response = await Program.client.GetAsync("StorageHandler/getParts/");
                if (response.IsSuccessStatusCode)
                {
                    var responseResult = await response.Content.ReadAsStringAsync();
                    var jsonResult = JsonConvert.DeserializeObject<List<GetAllPartsRequest>>(responseResult);
                    allPartsDataGrid.DataSource = jsonResult;


                    allPartsDataGrid.Columns["partId"].HeaderText = "Id";
                    allPartsDataGrid.Columns["partName"].HeaderText = "Part Name";
                    allPartsDataGrid.Columns["price"].HeaderText = "Price";
                    allPartsDataGrid.Columns["quantity"].HeaderText = "Quantity";
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

            

        private void allPartsDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                partIdTxt.Text = allPartsDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                partNameTxt.Text = allPartsDataGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                partPriceTxt.Text = allPartsDataGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
                quantityTxt.Text = allPartsDataGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void createPartBtn_Click(object sender, EventArgs e)
        {
            if(ValidationTestsOnInput())
            {
                CreateNewPart();
            }
        }

        private async void CreateNewPart()
        {

            CreateNewPartRequest createNewPartRequest = new CreateNewPartRequest();
            createNewPartRequest.partId = partIdTxt.Text;
            createNewPartRequest.price = decimal.Parse(partPriceTxt.Text);
            createNewPartRequest.partName = partNameTxt.Text;
            createNewPartRequest.quantity = decimal.Parse(quantityTxt.Text);

            try
            {

                HttpResponseMessage response = await Program.client.PostAsJsonAsync("StorageHandler/createNewPart", createNewPartRequest);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Added successfully","Success",MessageBoxButtons.OK);
                    GetAllParts();
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

        private void updatePartBtn_Click(object sender, EventArgs e)
        {
            if (ValidationTestsOnInput())
            {
                UpdatePartById();
            }

        }

        private async void UpdatePartById()
        {
            CreateNewPartRequest createNewPartRequest = new CreateNewPartRequest();
            createNewPartRequest.partId = partIdTxt.Text;
            createNewPartRequest.price = decimal.Parse(partPriceTxt.Text);
            createNewPartRequest.partName = partNameTxt.Text;
            createNewPartRequest.quantity = decimal.Parse(quantityTxt.Text);

            try
            {

                HttpResponseMessage response = await Program.client.PutAsJsonAsync("StorageHandler/updatePart/" + partIdTxt.Text, createNewPartRequest);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Part updated successfully!", "Success", MessageBoxButtons.OK);
                    GetAllParts();
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

        private void deletePartBtn_Click(object sender, EventArgs e)
        {
            DeletePartById();
        }

        private async void DeletePartById()
        {
            try
            {

                HttpResponseMessage response = await Program.client.DeleteAsync("StorageHandler/deletePart/" + partIdTxt.Text);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Part deleted successfully!", "Success", MessageBoxButtons.OK);
                    GetAllParts();
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
