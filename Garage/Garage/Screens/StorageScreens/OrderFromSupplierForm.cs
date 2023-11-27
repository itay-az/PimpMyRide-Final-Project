using Garage.Models;
using Garage.Requests;
using Garage.Responses;
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

        private async void GetAllOrders()
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

            }
            else
            {
                MessageBox.Show("Error");
            }
        }



        private async void GetOrderDetails(int orderId)
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
                MessageBox.Show("Error");
            }
        }

        public void FillDTV(Order order)
        {

        }

        private void showDetailsBtn_Click(object sender, EventArgs e)
        {
            GetOrderDetails(orderId);
        }

        private void allOrdersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            orderId = int.Parse(allOrdersDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
        }
    }
}
