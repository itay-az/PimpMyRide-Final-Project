﻿using Garage.Models;
using Garage.Requests;
using Newtonsoft.Json;
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
    public partial class NewOrderForm : Form
    {
        private BindingList<Parts> parts = new BindingList<Parts>();
        private List<string> suppliersName = new List<string>();

        private double sumPrice;
        public NewOrderForm()
        {
            InitializeComponent();
            GetSuppliers();
        }

        private async void GetSuppliers()
        {
            HttpResponseMessage response = await Program.client.GetAsync("StorageHandler/getAllSuppliers/");
            if (response.IsSuccessStatusCode)
            {

                var responseResult = await response.Content.ReadAsStringAsync();
                var jsonResult = JsonConvert.DeserializeObject<List<Supplier>>(responseResult);

                foreach( Supplier supplier in jsonResult)
                {
                    suppliersName.Add(supplier.supplierName);

                }
                chooseSupplierComboBox.DataSource = suppliersName;
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void morePartsBtn_Click(object sender, EventArgs e)
        {
            Parts part = new Parts();

            if (partIdTxt.Text == String.Empty || partQuantityTxt.Text == String.Empty || partNameTxt.Text == String.Empty)
            {
                MessageBox.Show("All Inputs are Required", "Error");
            }
            else
            {
                part.partName = partNameTxt.Text;
                try
                {
                    part.price = decimal.Parse(partPriceTxt.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                try
                {
                    part.quantity = decimal.Parse(partQuantityTxt.Text);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                try
                {
                    part.partId = partIdTxt.Text;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                parts.Add(part);
                FillOrderDetailsGridView();

                double sum = 0;
                foreach (Parts p in parts)
                {
                    sum += Decimal.ToDouble(p.price) * Decimal.ToDouble(p.quantity);
                }
                sumPrice = sum;

                sumPriceLbl.Text = sumPrice.ToString();

                partIdTxt.Text = "";
                partNameTxt.Text = "";
                partPriceTxt.Text = "";
                partQuantityTxt.Text = "";
            }




        }

        private void FillOrderDetailsGridView()
        {
            orderDetailsGridView.DataSource = parts;
            orderDetailsGridView.Refresh();
            orderDetailsGridView.Visible = true;
        }

        private void placeOrderbtn_Click(object sender, EventArgs e)
        {
            if(parts.Count == 0)
            {
                MessageBox.Show("Cannot create empty order ", "Error");

            }
            else
                createNewOrder();
        }

        private async void createNewOrder()
        {

            CreateNewOrderRequest createNewOrderRequest = new CreateNewOrderRequest
            {
                parts = parts.ToList(),
                supplierName = suppliersName[chooseSupplierComboBox.SelectedIndex],
                price = sumPrice
            };

            HttpResponseMessage response = await Program.client.PostAsJsonAsync(
               "StorageHandler/newOrder", createNewOrderRequest);

            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                MessageBox.Show("Order Added successfully", "success");

                this.Close();
            }
            else if (response.StatusCode.Equals(HttpStatusCode.Conflict))
            {
                MessageBox.Show("Order Already exists", "conflict");

            }
            else
            {
                MessageBox.Show(" Failed ", "Error");
            }
        }
    }
}
