using Garage.Models;
using Garage.Requests;
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

namespace Garage.Screens.StorageScreens
{
    public partial class AllSuppliersForm : Form
    {
        public AllSuppliersForm()
        {
            InitializeComponent();
            GetAllSuppliers();
        }

        private async void GetAllSuppliers()
        {
            HttpResponseMessage response = await Program.client.GetAsync("StorageHandler/getAllSuppliers/");
            if (response.IsSuccessStatusCode)
            {
                var responseResult = await response.Content.ReadAsStringAsync();
                var jsonResult = JsonConvert.DeserializeObject<List<GetAllSuppliersRequest>>(responseResult);
                allSuppliersDataGrid.DataSource = jsonResult;
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void updateSupplierBtn_Click(object sender, EventArgs e)
        {
            UpdateSupplierById();
        }

        private async void UpdateSupplierById()
        {
            GetAllSuppliersRequest getAllSuppliersRequest = new GetAllSuppliersRequest();
            getAllSuppliersRequest.supplierId = supplierIdTxt.Text;
            getAllSuppliersRequest.supplierName = supplierNameTxt.Text;
            getAllSuppliersRequest.supplierAddress = supplierAddressTxt.Text;
            getAllSuppliersRequest.supplierPhone = supplierPhoneTxt.Text;
            getAllSuppliersRequest.supplierEmail = supplierEmailTxt.Text;
            getAllSuppliersRequest.orders = new List<Order>();

            HttpResponseMessage response = await Program.client.PutAsJsonAsync("StorageHandler/updateSupplier/" + supplierIdTxt.Text, getAllSuppliersRequest);
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Supplier updated successfully!", "Success", MessageBoxButtons.OK);
                GetAllSuppliers();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void allSuppliersDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            supplierIdTxt.Text = allSuppliersDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString();

            supplierNameTxt.Text = allSuppliersDataGrid.Rows[e.RowIndex].Cells[1].Value.ToString();

            if(allSuppliersDataGrid.Rows[e.RowIndex].Cells[2].Value != null)
                supplierAddressTxt.Text = allSuppliersDataGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
            else
                supplierAddressTxt.Text = "";
            if (allSuppliersDataGrid.Rows[e.RowIndex].Cells[3].Value != null)
                supplierPhoneTxt.Text = allSuppliersDataGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
            else
                supplierPhoneTxt.Text = "";
            if (allSuppliersDataGrid.Rows[e.RowIndex].Cells[4].Value != null)
                supplierEmailTxt.Text = allSuppliersDataGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
            else
                supplierEmailTxt.Text = "";
            //supplierListComboBox.Text = allSuppliersDataGrid.Rows[e.RowIndex].Cells[5].Value.ToString();

        }

        private void deletePartBtn_Click(object sender, EventArgs e)
        {
            DeleteSupplierById();
        }

        private async void DeleteSupplierById()
        {
            HttpResponseMessage response = await Program.client.DeleteAsync("StorageHandler/deleteSupplierById/" + supplierIdTxt.Text);
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Supplier deleted successfully!", "Success", MessageBoxButtons.OK);
                GetAllSuppliers();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
