using Garage.Models;
using Garage.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Garage.Screens.StorageScreens
{
    public partial class CreateNewSupplierForm : Form
    {
        public CreateNewSupplierForm()
        {
            InitializeComponent();
        }

        private void createNewSupplierBtn_Click(object sender, EventArgs e)
        {
            if(supplierIdTxt.Text == String.Empty || supplierFullNameTxt.Text == String.Empty || supplierPhoneTxt.Text == String.Empty)
            {
                MessageBox.Show("One or more inputs is incorrect", "Error");
            }
            CreateNewSupplierRequest(supplierIdTxt.Text, supplierFullNameTxt.Text, supplierAddressTxt.Text, supplierPhoneTxt.Text,supplierEmailTxt.Text);
        }

        private async void CreateNewSupplierRequest(string supplierId, string supplierName, string supplierAddress, string supplierPhone, string supplierEmail)
        {
            CreateSupplierRequest createSupplierRequest = new CreateSupplierRequest();
            if (supplierAddress == String.Empty)
            {
                createSupplierRequest.supplierId = supplierId;
                createSupplierRequest.supplierPhone = supplierPhone;
                createSupplierRequest.supplierName = supplierName;
                if (supplierEmail != String.Empty)
                {
                    createSupplierRequest.supplierEmail = supplierEmail;
                }
            }
            else
            {
                createSupplierRequest.supplierId = supplierId;
                createSupplierRequest.supplierPhone = supplierPhone;
                createSupplierRequest.supplierName = supplierName;
                createSupplierRequest.supplierAddress = supplierAddress;
                if (supplierEmail != String.Empty)
                {
                    createSupplierRequest.supplierEmail = supplierEmail;
                }

            }

            HttpResponseMessage response = await Program.client.PostAsJsonAsync(
                   "StorageHandler/newSupplier/", createSupplierRequest);

            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                MessageBox.Show("Supplier " + supplierName + " Added successfully", "success");

                this.Close();
            }
            else if (response.StatusCode.Equals(HttpStatusCode.Conflict))
            {
                MessageBox.Show("Supplier " + supplierName + " Already exists", "conflict");

            }
            else
            {
                MessageBox.Show(" Failed ", "Error");
            }


        }
    }
}
