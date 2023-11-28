using Garage.Models;
using Garage.Responses;
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
using System.Web.Mvc;
using System.Windows.Forms;

namespace Garage.Screens.TicketsScreens
{
    public partial class Ticket : Form
    {
        public Ticket()
        {
            InitializeComponent();
        }
        private static List<TicketPart> parts;
        private static List<Labor> labors;
        private string ticketId;
        private string partId;

        public Ticket(string ticketId)
        {
            InitializeComponent();
            GetTicketById(ticketId);
            this.ticketId = ticketId;
        }

        private void refreshPartsDataGridView()
        {
            partsDataGridView.DataSource = parts;

        }

        private void refreshLaborsDataGridView()
        {
            laborDataGridView.DataSource = labors;
        }

        private void partsDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Hello");
        }

        private async void GetTicketById(string ticketId)
        {
            HttpResponseMessage response = await Program.client.GetAsync("Tickets/getTicket/" + ticketId);

            if (response.IsSuccessStatusCode)
            {
                var responseResult = await response.Content.ReadAsStringAsync();
                var jsonResult = JsonConvert.DeserializeObject<GetTicketByIdResponse>(responseResult);

                clientFullNameTxt.Text = jsonResult.clientFullName;
                clientEmailTxt.Text = jsonResult.clientEmail;
                clientPhoneNumberTxt.Text = jsonResult.clientPhoneNumber;
                clientManufactureTxt.Text = jsonResult.carManufacture;
                clientModelTxt.Text = jsonResult.carModel;
                clientYearTxt.Text = jsonResult.carYear.ToString();
                clientEngineTxt.Text = jsonResult.carEngine;
                clientVinNumberTxt.Text = jsonResult.vinNumber;
                clientKmTxt.Text = jsonResult.carKilometer.ToString();
                cuaseOfArrivalTxt.Text = jsonResult.causeOfArrival;
                parts = jsonResult.parts;
                labors = jsonResult.labors;
                totalPartPriceTxt.Text = jsonResult.totalPartsPrice.ToString();
                totalPartDiscountTxt.Text = jsonResult.totalPartsDiscount.ToString();
                totalLaborPriceTxt.Text = jsonResult.totalLaborPrice.ToString();
                totalLaborDiscountTxt.Text = jsonResult.totalLaborDiscount.ToString();

                refreshPartsDataGridView();
                refreshLaborsDataGridView();
            }
            else
            {
                MessageBox.Show("Client not found, Please create new client", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addPartToTicketBtn_Click(object sender, EventArgs e)
        {
            AddPartToTicketForm addPartToTicketForm = new AddPartToTicketForm(int.Parse(ticketId));
            this.Close();
            addPartToTicketForm.ShowDialog();
        }

        private void deletePartBtn_Click(object sender, EventArgs e)
        {
            deletePartFromTicket();
        }

        private async void deletePartFromTicket()
        {
            HttpResponseMessage response = await Program.client.DeleteAsync("Tickets/removePartFromTicket/" + ticketId + "/" + partId);

            if (response.IsSuccessStatusCode)
            {
                var responseResult = await response.Content.ReadAsStringAsync();
                var jsonResult = JsonConvert.DeserializeObject<Garage.Models.Ticket>(responseResult);

                GetTicketById(jsonResult.ticketId.ToString());

            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void partsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            partId = partsDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void deleteTicketBtn_Click(object sender, EventArgs e)
        {
            deleteTicket(ticketId);
        }

        private async void deleteTicket(string ticketId)
        {
            HttpResponseMessage response = await Program.client.DeleteAsync("Tickets/deleteTicket/" + ticketId);

            if (response.IsSuccessStatusCode)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void updatePartBtn_Click(object sender, EventArgs e)
        {
            List<TicketPart> parts = new List<TicketPart>();

            foreach (DataGridViewRow row in partsDataGridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    TicketPart part = new TicketPart
                    {
                        partId = row.Cells["partId"].Value.ToString(),
                        partName = row.Cells["partName"].Value.ToString(),
                        price = decimal.Parse(row.Cells["price"].Value.ToString()),
                        quantity = decimal.Parse(row.Cells["quantity"].Value.ToString()),
                        discount = decimal.Parse(row.Cells["discount"].Value.ToString())
                    };

                    parts.Add(part);
                }
            }

            updatePartsOnTicket(parts);
        }

        private async void updatePartsOnTicket(List<TicketPart> parts)
        {
            HttpResponseMessage response = await Program.client.PutAsJsonAsync("Tickets/updatePartsOnTicket/" + ticketId, parts);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Parts Updated");
            }

            else { MessageBox.Show("Error"); }

        }
    }
}
