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
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Garage.Screens.StorageScreens
{
    // order from supplier screen, used for viewing orders that were made
    public partial class OrderFromSupplierForm : Form
    {
        public int orderId;

        public int GetOrderId()
        {
            return orderId;
        }

        public void SetOrderId(int orderId)
        {
            this.orderId = orderId;
        }

        public OrderFromSupplierForm()
        {
            InitializeComponent();
            GetAllOrders();
        }

        // an http request method for getting all orders
        private async void GetAllOrders()
        {
            try
            {

                HttpResponseMessage response = await Program.client.GetAsync("StorageHandler/getAllOrders/");
                if (response.IsSuccessStatusCode)
                {
                    var responseResult = await response.Content.ReadAsStringAsync();
                    var jsonResult = JsonConvert.DeserializeObject<List<GetAllOrdersResponse>>(responseResult);

                    List<AllOrder> allOrders = new List<AllOrder>();
                    foreach (var order in jsonResult)
                    {
                        allOrders.Add(new AllOrder
                        {
                            orderId = order.orderId,
                            supplierName = order.supplierName,
                            date = order.dateTime.ToString(),
                            price = order.price
                        });
                    }
                    allOrdersDataGridView.DataSource = allOrders;


                    allOrdersDataGridView.Columns["orderId"].HeaderText = "Order Id";
                    allOrdersDataGridView.Columns["supplierName"].HeaderText = "Supplier Name";
                    allOrdersDataGridView.Columns["price"].HeaderText = "Price";
                    allOrdersDataGridView.Columns["date"].HeaderText = "Date";


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


        // an http request method for getting information on specific order
        private async void GetOrderDetails(int orderId)
        {
            try
            {

                HttpResponseMessage response = await Program.client.GetAsync("StorageHandler/getOrderById/" + orderId);
                if (response.IsSuccessStatusCode)
                {
                    var responseResult = await response.Content.ReadAsStringAsync();
                    var jsonResult = JsonConvert.DeserializeObject<Order>(responseResult);
                    orderDetailsDataGridView.DataSource = jsonResult.parts;
                    orderDetailsDataGridView.Visible = true;
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


        private void showDetailsBtn_Click(object sender, EventArgs e)
        {
            GetOrderDetails(orderId);
        }

        private void allOrdersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                orderId = int.Parse(allOrdersDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


    }
}
