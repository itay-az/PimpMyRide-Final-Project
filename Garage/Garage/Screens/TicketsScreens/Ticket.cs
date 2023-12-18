using Garage.Models;
using Garage.Responses;
using Garage.Utils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Windows.Forms;
using System.Xml.Linq;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using System.Security.Cryptography.Xml;
using iText.Layout.Properties;
using iText.IO.Image;

namespace Garage.Screens.TicketsScreens
{
    public partial class Ticket : Form
    {
        public Ticket()
        {
            InitializeComponent();
            exportToTicketBtn.Visible = false;

        }
        private static List<TicketPart> parts;
        private static List<Labor> labors;
        private string ticketId;
        private string partId;
        private int laborId;
        private double totalPartPrice;
        private double totalLaborPrice;
        private double totalPartDiscount;
        private double totalLaborDiscount;
        private TicketType state;

        public Ticket(string ticketId)
        {
            InitializeComponent();
            GetTicketById(ticketId);
            this.ticketId = ticketId;
            exportToTicketBtn.Visible = false;

        }

        private void refreshPartsDataGridView()
        {
            partsDataGridView.DataSource = parts;

            partsDataGridView.Columns["partId"].HeaderText = "Part Id";
            partsDataGridView.Columns["partName"].HeaderText = "Part Name";
            partsDataGridView.Columns["price"].HeaderText = "Price";
            partsDataGridView.Columns["quantity"].HeaderText = "Quantity";
            partsDataGridView.Columns["discount"].HeaderText = "Discount";
            partsDataGridView.Columns["unitPrice"].HeaderText = "Unit Price";

            partsDataGridView.Columns[0].ReadOnly = true;
            partsDataGridView.Columns[1].ReadOnly = true;
            partsDataGridView.Columns[5].ReadOnly = true;
        }

        private void refreshLaborsDataGridView()
        {
            laborDataGridView.DataSource = labors;

            laborDataGridView.Columns["Id"].HeaderText = "Labor Id";
            laborDataGridView.Columns["description"].HeaderText = "Description";
            laborDataGridView.Columns["price"].HeaderText = "Price";
            laborDataGridView.Columns["time"].HeaderText = "Time";
            laborDataGridView.Columns["discount"].HeaderText = "Discount";


            laborDataGridView.Columns[0].ReadOnly = true;
            laborDataGridView.Columns[1].ReadOnly = true;
            laborDataGridView.Columns[2].ReadOnly = true;
            laborDataGridView.Columns[3].ReadOnly = true;
        }

        private void partsDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Hello");
        }

        private async void GetTicketById(string ticketId)
        {
            try
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
                    totalPartPrice = jsonResult.totalPartsPrice;
                    totalPartDiscountTxt.Text = jsonResult.totalPartsDiscount.ToString();
                    totalPartDiscount = jsonResult.totalPartsDiscount;
                    totalLaborPriceTxt.Text = jsonResult.totalLaborPrice.ToString();
                    totalLaborPrice = jsonResult.totalLaborPrice;
                    totalLaborDiscountTxt.Text = jsonResult.totalLaborDiscount.ToString();
                    totalLaborDiscount = jsonResult.totalLaborDiscount;
                    totalPartPriceAfterDiscountTxt.Text = (jsonResult.totalPartsPrice - jsonResult.totalPartsDiscount).ToString();
                    totalLaborPriceAfterDiscountTxt.Text = (jsonResult.totalLaborPrice - jsonResult.totalLaborDiscount).ToString();
                    totalTicketPriceTxt.Text = jsonResult.price.ToString();
                    refreshPartsDataGridView();
                    refreshLaborsDataGridView();
                    state = jsonResult.state;
                    if (jsonResult.parts.Count > 0)
                    {
                        partId = partsDataGridView.Rows[0].Cells[0].Value.ToString();
                    }
                    if (jsonResult.labors.Count > 0)
                    {
                        laborId = int.Parse(laborDataGridView.Rows[0].Cells[0].Value.ToString());
                    }
                    if (jsonResult.state == TicketType.IS_OFFER)
                    {
                        exportToTicketBtn.Visible = true;
                    }
                    if (jsonResult.state == TicketType.IS_CLOSED)
                    {
                        partsDataGridView.Columns[2].ReadOnly = true;
                        partsDataGridView.Columns[3].ReadOnly = true;
                        partsDataGridView.Columns[4].ReadOnly = true;
                        laborDataGridView.Columns[4].ReadOnly = true;

                        deleteTicketBtn.Visible = false;
                        closeTicketBtn.Visible = false;
                    }
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

        private void addPartToTicketBtn_Click(object sender, EventArgs e)
        {
            AddPartToTicketForm addPartToTicketForm = new AddPartToTicketForm(int.Parse(ticketId));
            addPartToTicketForm.FormClosed += (s, args) => { GetTicketById(ticketId); this.Show(); };
            this.Hide();
            addPartToTicketForm.ShowDialog();
        }

        private void deletePartBtn_Click(object sender, EventArgs e)
        {
            deletePartFromTicket();
        }

        private async void deletePartFromTicket()
        {
            try
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
                    await ErrorHandling.HandleErrorResponse(response);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void partsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                partId = partsDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void deleteTicketBtn_Click(object sender, EventArgs e)
        {
            deleteTicket(ticketId);
        }

        private async void deleteTicket(string ticketId)
        {
            try
            {

                HttpResponseMessage response = await Program.client.DeleteAsync("Tickets/deleteTicket/" + ticketId);

                if (response.IsSuccessStatusCode)
                {
                    this.Close();
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
            bool IsOkToUpdate = true;
            List<TicketPart> newPartsList = new List<TicketPart>();

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

                    if (part.quantity <= 0)
                    {
                        MessageBox.Show("Quantity value cannot be equal or less than 0");
                        IsOkToUpdate = false;
                        break;
                    }
                    if (part.discount < 0)
                    {
                        MessageBox.Show("Discount value cannot be less than 0");
                        IsOkToUpdate = false;
                        break;
                    }
                    if (part.price <= 0)
                    {
                        MessageBox.Show("Price value cannot be equal or less than 0");
                        IsOkToUpdate = false;
                        break;
                    }
                    newPartsList.Add(part);
                }
            }

            if (IsOkToUpdate)
            {
                updatePartsOnTicket(newPartsList);
            }
        }

        private async void updatePartsOnTicket(List<TicketPart> parts)
        {
            try
            {

                HttpResponseMessage response = await Program.client.PutAsJsonAsync("Tickets/updatePartsOnTicket/" + ticketId, parts);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Parts Updated");
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

        private void addLaborBtn_Click(object sender, EventArgs e)
        {
            AddLaborToTicketForm addLaborToTicketForm = new AddLaborToTicketForm(int.Parse(ticketId));
            addLaborToTicketForm.FormClosed += (s, args) => { GetTicketById(ticketId); this.Show(); };
            this.Hide();
            addLaborToTicketForm.ShowDialog();
        }

        private void updateLaborBtn_Click(object sender, EventArgs e)
        {
            List<Labor> labors = new List<Labor>();

            foreach (DataGridViewRow row in laborDataGridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    Labor labor = new Labor
                    {
                        Id = int.Parse(row.Cells["Id"].Value.ToString()),
                        description = row.Cells["description"].Value.ToString(),
                        price = decimal.Parse(row.Cells["price"].Value.ToString()),
                        time = decimal.Parse(row.Cells["time"].Value.ToString()),
                        discount = decimal.Parse(row.Cells["discount"].Value.ToString())
                    };

                    labors.Add(labor);
                }
            }

            updateLaborsOnTicket(labors);
        }

        private async void updateLaborsOnTicket(List<Labor> labors)
        {
            try
            {

                HttpResponseMessage response = await Program.client.PutAsJsonAsync("Tickets/updateLaborsOnTicket/" + ticketId, labors);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Labors Updated");
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

        private void closeTicketBtn_Click(object sender, EventArgs e)
        {
            CloseTicketForm closeTicketForm = new CloseTicketForm(double.Parse(totalTicketPriceTxt.Text), ticketId);
            closeTicketForm.ShowDialog();

        }



        private void partsDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if ((e.ColumnIndex == 2 || e.ColumnIndex == 3) && e.RowIndex >= 0)
            {
                string newValue = e.FormattedValue.ToString();

                string oldValue = partsDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                if (!decimal.TryParse(newValue, out decimal parsedValue) || parsedValue <= 0)
                {
                    MessageBox.Show("Value must be a valid positive decimal.", "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    partsDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = oldValue;

                    e.Cancel = true;
                }
            }
            if (e.ColumnIndex == 4 && e.RowIndex >= 0)
            {
                string newValue = e.FormattedValue.ToString();

                string oldValue = partsDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                if (!decimal.TryParse(newValue, out decimal parsedValue) || parsedValue < 0)
                {
                    MessageBox.Show("Value must be a valid positive decimal.", "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    partsDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = oldValue;

                    e.Cancel = true;
                }
            }
        }

        private void laborDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 4 && e.RowIndex >= 0)
            {
                string newValue = e.FormattedValue.ToString();

                string oldValue = laborDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                if (!decimal.TryParse(newValue, out decimal parsedValue) || parsedValue <= 0)
                {
                    MessageBox.Show("Value must be a valid positive decimal.", "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    laborDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = oldValue;

                    e.Cancel = true;
                }
            }
        }

        private void deleteLaborBtn_Click(object sender, EventArgs e)
        {
            RemoveLaborFromTicket();
        }

        private async void RemoveLaborFromTicket()
        {
            try
            {

                HttpResponseMessage response = await Program.client.DeleteAsync("Tickets/removeLaborFromTicket/" + ticketId + "/" + laborId);

                if (response.IsSuccessStatusCode)
                {
                    var responseResult = await response.Content.ReadAsStringAsync();
                    var jsonResult = JsonConvert.DeserializeObject<Models.Ticket>(responseResult);

                    GetTicketById(jsonResult.ticketId.ToString());

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

        private void laborDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                laborId = int.Parse(laborDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void exportToTicketBtn_Click(object sender, EventArgs e)
        {
            changeStateToOpenTicket(ticketId);
        }

        private async void changeStateToOpenTicket(string ticketId)
        {
            try
            {

                HttpResponseMessage response = await Program.client.PutAsync("Tickets/updateOfferToTicket/" + ticketId, null);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Offer Updated");
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

        private void exportToPdfBtn_Click(object sender, EventArgs e)
        {
            string projectDirectory = AppDomain.CurrentDomain.BaseDirectory;

            string outputPath = Path.Combine(projectDirectory, "report.pdf");



            using (PdfWriter writer = new PdfWriter(new FileStream(outputPath, FileMode.Create)))
            {
                using (PdfDocument pdf = new PdfDocument(writer))
                {
                    Document document = new Document(pdf);


                    Paragraph dateParagraph = new Paragraph(DateTime.Now.ToString("yyyy-MM-dd"))
                        .SetFontSize(12)
                        .SetBold()
                        .SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.LEFT);

                    document.Add(dateParagraph);
                    if(state == TicketType.IS_OPEN)
                    {
                        document.Add(new Paragraph("Ticket id: " + ticketId)
                            .SetTextAlignment(TextAlignment.CENTER)
                            .SetFontSize(24)
                            .SetBold()
                            .SetMarginBottom(20));

                    }
                    else
                    {
                        document.Add(new Paragraph("Offer id: " + ticketId)
                            .SetTextAlignment(TextAlignment.CENTER)
                            .SetFontSize(24)
                            .SetBold()
                            .SetMarginBottom(20));
                    }

                    Table laborTable = new Table(5).UseAllAvailableWidth();
                    laborTable.AddCell(CreateCell("Labor id", 14));
                    laborTable.AddCell(CreateCell("Labor description", 14));
                    laborTable.AddCell(CreateCell("Labor price", 14));
                    laborTable.AddCell(CreateCell("Labor Time", (14)));
                    laborTable.AddCell(CreateCell("Labor discount", 14));

                    foreach (Labor labor in labors)
                    {
                        laborTable.AddCell(CreateCell(labor.Id.ToString()));
                        laborTable.AddCell(CreateCell(labor.description));
                        laborTable.AddCell(CreateCell(labor.price.ToString()));
                        laborTable.AddCell(CreateCell(labor.time.ToString()));
                        laborTable.AddCell(CreateCell(labor.discount.ToString()));
                    }


                    document.Add(laborTable);

                    Paragraph laborsParagraph = new Paragraph()
                   .AddTabStops(new TabStop(100f, iText.Layout.Properties.TabAlignment.LEFT))
                   .AddTabStops(new TabStop(500f, iText.Layout.Properties.TabAlignment.RIGHT))
                   .Add(new Text($"Total labors price : {totalLaborPrice} "))
                   .Add(new Tab())
                   .Add(new Text($"Total labors discount: {totalLaborDiscount} "))
                   .SetBold()
                   .SetFontSize(12)
                   .SetMarginTop(20)
                   .SetMarginBottom(20);

                    document.Add(laborsParagraph);


                    Table partsTable = new Table(5).UseAllAvailableWidth();
                    partsTable.AddCell(CreateCell("Part id", 14));
                    partsTable.AddCell(CreateCell("Part name", 14));
                    partsTable.AddCell(CreateCell("Part price", 14));
                    partsTable.AddCell(CreateCell("Quantity", (14)));
                    partsTable.AddCell(CreateCell("Part discount", 14));

                    foreach (TicketPart part in parts)
                    {
                        partsTable.AddCell(CreateCell(part.partId));
                        partsTable.AddCell(CreateCell(part.partName));
                        partsTable.AddCell(CreateCell(part.price.ToString()));
                        partsTable.AddCell(CreateCell(part.quantity.ToString()));
                        partsTable.AddCell(CreateCell(part.discount.ToString()));
                    }

                    document.Add(partsTable);


                    Paragraph partsParagraph = new Paragraph()
                   .AddTabStops(new TabStop(100f, iText.Layout.Properties.TabAlignment.LEFT))
                   .AddTabStops(new TabStop(500f, iText.Layout.Properties.TabAlignment.RIGHT))
                   .Add(new Text($"Total parts price : {totalPartPrice} "))
                   .Add(new Tab())
                   .Add(new Text($"Total parts discount : {totalPartDiscount} "))
                   .SetBold()
                   .SetFontSize(12)
                   .SetMarginTop(20)
                   .SetMarginBottom(20);

                    document.Add(partsParagraph);

                    Paragraph totalParagraph = new Paragraph($"Total to pay : {totalLaborPrice + totalPartPrice} ")
                        .SetTextAlignment(TextAlignment.RIGHT)
                        .SetBold()
                        .SetFontSize(12)
                        .SetMarginTop(20)
                        .SetMarginBottom(20);

                    document.Add(totalParagraph);




                    Paragraph signParagraph = new Paragraph()
                                       .AddTabStops(new TabStop(100f, iText.Layout.Properties.TabAlignment.LEFT))
                                       .AddTabStops(new TabStop(500f, iText.Layout.Properties.TabAlignment.RIGHT))
                                       .Add(new Text("Customer signature: ______________"))
                                       .Add(new Tab())
                                       .Add(new Text("Buisness signature: ______________"))
                                       .SetBold()
                                       .SetFontSize(12);

                    document.Add(signParagraph);


                    document.Close();
                }
                OpenPdfWithDefaultViewer(outputPath);
            }



            static Cell CreateCell(string text, int fontSize = 12)
            {
                return new Cell()
                    .Add(new Paragraph(text))
                    .SetPadding(8)
                    .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER)
                    .SetFontSize(fontSize)
                    .SetBold();
            }


            static void OpenPdfWithDefaultViewer(string filePath)
            {
                try
                {
                    // Start the default PDF viewer
                    Process.Start(filePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}


