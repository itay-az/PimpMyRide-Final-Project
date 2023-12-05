using Garage.Screens.AdminScreens;
using Garage.Screens.ClientsScreens;
using Garage.Screens.StorageScreens;
using Garage.Screens.TicketsScreens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenTicketsForm = Garage.Screens.TicketsScreens.OpenTicketsForm;

namespace Garage
{
    public partial class Dashboard : Form
    {
        public static Form mainForm = null;
        public Dashboard()
        {
            InitializeComponent();
            HideMenus();
            timer1.Interval = 1000;
            timer1.Start();

            UpdateClock();

        }

        public Dashboard(string jobTitle,string userName)
        {
            InitializeComponent();
            helloLbl.Text += userName;

            if (jobTitle == "1" || jobTitle == "2")
            {
                this.adminMenuBtn.Visible = false;
            }
            else
            {
                this.adminMenuBtn.Visible = true;
            }
            HideMenus();

        }


        private void HideMenus()
        {
            ticketPanel.Visible = false;
            clientsPanel.Visible = false;
            suppliersPanel.Visible = false;
            adminPanel.Visible = false;

        }


        private void logoutBtn_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }

        private void ticketsMenuBtn_Click(object sender, EventArgs e)
        {
            ticketPanel.Visible = true;
            clientsPanel.Visible = false;
            suppliersPanel.Visible = false;
            adminPanel.Visible = false;

        }

        private void clientMenuBtn_Click(object sender, EventArgs e)
        {
            clientsPanel.Visible = true;
            ticketPanel.Visible = false;
            suppliersPanel.Visible = false;
            adminPanel.Visible = false;
        }

        private void suppliersMenuBtn_Click(object sender, EventArgs e)
        {
            suppliersPanel.Visible = true;
            clientsPanel.Visible = false;
            ticketPanel.Visible = false;
            adminPanel.Visible = false;
        }

        private void adminMenuBtn_Click(object sender, EventArgs e)
        {
            adminMenuBtnClick();
        }
        public void adminMenuBtnClick()
        {
            adminPanel.Visible = true;
            suppliersPanel.Visible = false;
            clientsPanel.Visible = false;
            ticketPanel.Visible = false;
        }

        private void adminUsersBtn_Click(object sender, EventArgs e)
        {
            AllUsersForm allUsersForm = new AllUsersForm();
            openForm(allUsersForm);
        }

        public void openForm(Form form)
        {
            mainForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            getAllPartsBtn.Controls.Add(form);
            getAllPartsBtn.Tag = form;
            form.BringToFront();
            form.Show();
        }

        private void createNewClientBtn_Click(object sender, EventArgs e)
        {
            CreateNewClient createNewClient = new CreateNewClient();
            openForm(createNewClient);
        }

        private void allClientsBtn_Click(object sender, EventArgs e)
        {
            AllClientsForm allClientsForm = new AllClientsForm();
            openForm(allClientsForm);
        }

        private void searchClientBtn_Click(object sender, EventArgs e)
        {
            SearchClientForm searchClientForm = new SearchClientForm();
            openForm(searchClientForm);
        }

        private void addNewManufactureBtn_Click(object sender, EventArgs e)
        {
            AddNewManufactureForm addNewManufactoreForm = new AddNewManufactureForm();
            openForm(addNewManufactoreForm);
        }

        private void createNewTicketBtn_Click(object sender, EventArgs e)
        {
            CreateNewTicketForm CreateNewTicketForm = new CreateNewTicketForm();
            openForm(CreateNewTicketForm);
        }

        private void allSuppliersBtn_Click(object sender, EventArgs e)
        {
            AllSuppliersForm allSuppliersForm = new AllSuppliersForm();
            openForm(allSuppliersForm);
        }

        private void createNewSupplierBtn_Click(object sender, EventArgs e)
        {
            CreateNewSupplierForm createNewSupplierForm = new CreateNewSupplierForm();
            openForm(createNewSupplierForm);
        }

        private void newOrderBtn_Click(object sender, EventArgs e)
        {
            NewOrderForm newOrderForm = new NewOrderForm();
            openForm(newOrderForm);
        }

        private void allPartsBtn_Click(object sender, EventArgs e)
        {
            AllPartsForm allPartsForm = new AllPartsForm();
            openForm(allPartsForm);
        }

        private void openTicketsBtn_Click(object sender, EventArgs e)
        {
            OpenTicketsForm openTicketsForm = new OpenTicketsForm();
            openForm(openTicketsForm);
        }

        private void allOrdersBtn_Click(object sender, EventArgs e)
        {
            OrderFromSupplierForm orderFromSupplierForm = new OrderFromSupplierForm();
            openForm(orderFromSupplierForm);
        }

        private void createNewOfferBtn_Click(object sender, EventArgs e)
        {
            CreateNewOfferForm createNewOfferForm = new CreateNewOfferForm();
            openForm(createNewOfferForm);
        }

        private void getAllOffersBtn_Click(object sender, EventArgs e)
        {
            OpenOffersForm openOffersForm = new OpenOffersForm();
            openForm(openOffersForm);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateClock();
        }
        private void UpdateClock()
        {
            timerLbl.Text = DateTime.Now.ToString("HH:mm:ss \n dd/MM/yyyy");
            
        }
    }
}
