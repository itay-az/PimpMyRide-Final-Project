using Garage.Models;
using Garage.Requests;
using Garage.Utils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Garage.Screens.AdminScreens
{
    public partial class MaintenanceForm : Form
    {
        public MaintenanceForm()
        {
            InitializeComponent();
            GetAllLabors();
        }

        private async void GetAllLabors()
        {
            try
            {

                HttpResponseMessage response = await Program.client.GetAsync("Tickets/getLabors");
                if (response.IsSuccessStatusCode)
                {
                    var responseResult = await response.Content.ReadAsStringAsync();
                    var jsonResult = JsonConvert.DeserializeObject<List<Labor>>(responseResult);
                    allLaborsDataGridView.DataSource = jsonResult;


                    allLaborsDataGridView.Columns["Id"].HeaderText = "Id";
                    allLaborsDataGridView.Columns["description"].HeaderText = "Description";
                    allLaborsDataGridView.Columns["price"].HeaderText = "Price";
                    allLaborsDataGridView.Columns["time"].HeaderText = "Time";
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

        private async void CreateNewLabor( string description, decimal price, decimal time)
        {
            Labor labor = new Labor(description, price, time);

            try
            {
                HttpResponseMessage response = await Program.client.PostAsJsonAsync("Tickets/createLabor",labor);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Added successfully", "Success", MessageBoxButtons.OK);
                    GetAllLabors();
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

        private void createLaborBtn_Click(object sender, EventArgs e)
        {
            if (ValidationTestsOnInput())
            {
                CreateNewLabor(laborDescriptionTxt.Text, Decimal.Parse(laborPriceTxt.Text), Decimal.Parse(laborTimeTxt.Text));
            }
        }

        private bool ValidationTestsOnInput()
        {
            if (Decimal.Parse(laborPriceTxt.Text) <= 0 || Decimal.Parse(laborTimeTxt.Text) <= 0)
            {
                MessageBox.Show("Price or Time cannot be less or equal to 0", "Error", MessageBoxButtons.OK);
                return false;
            }
            if(laborDescriptionTxt.Text == String.Empty )
            {
                MessageBox.Show("Description of labor cannot be empty", "Error", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }

        private async void UpdateLaborById(int Id, string description, decimal price, decimal time)
        {
            Labor labor = new Labor(Id, description, price, time);

            try
            {

                HttpResponseMessage response = await Program.client.PutAsJsonAsync("Tickets/updateLaborByid/" + Id, labor);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Labor updated successfully!", "Success", MessageBoxButtons.OK);
                    GetAllLabors();
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

        private void updateLaborBtn_Click(object sender, EventArgs e)
        {
            if (ValidationTestsOnInput())
            {
                UpdateLaborById(int.Parse(laborIdTxt.Text), laborDescriptionTxt.Text, Decimal.Parse(laborPriceTxt.Text), Decimal.Parse(laborTimeTxt.Text));
            }
        }

        private async void DeleteLaborById(int Id)
        {
            try
            {
                HttpResponseMessage response = await Program.client.DeleteAsync("Tickets/deleteLaborById/" + Id);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Labor deleted successfully!", "Success", MessageBoxButtons.OK);
                    GetAllLabors();
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

        private void deleteLaborBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DeleteLaborById(int.Parse(laborIdTxt.Text));

            }
            catch(Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void allLaborsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                laborIdTxt.Text = allLaborsDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                laborDescriptionTxt.Text = allLaborsDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                laborPriceTxt.Text = allLaborsDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                laborTimeTxt.Text = allLaborsDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
