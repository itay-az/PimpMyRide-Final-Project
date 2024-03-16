using Garage.Models;
using Garage.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Net.Http;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Newtonsoft.Json;
using System.Threading;
using System.Data.Entity.Infrastructure;
using Garage.Utils;

namespace Garage.Screens.ClientsScreens
{
    // create new client screen, used for creating a new client
    public partial class CreateNewClient : Form
    {
        public Car car;
        public Client client;

        private List<GetManufacturesRequest> manuList;
        private List<GetModelsByManufactureRequest> modelList = new List<GetModelsByManufactureRequest>();

        public CreateNewClient()
        {
            InitializeComponent();
            getManufactures();
        }

        // an http request method that for getting all car manufactures
        private async void getManufactures()
        {
            HttpResponseMessage response = await Program.client.GetAsync("StorageHandler/getManufactures");
            try
            {
                if (response.IsSuccessStatusCode)
                {
                    string result = await response.Content.ReadAsStringAsync();
                    manuList = JsonConvert.DeserializeObject<List<GetManufacturesRequest>>(result);
                    inserManufacturesToComboBox();

                }
                else
                {
                    await ErrorHandling.HandleErrorResponse(response);
                }
            }
            catch (Exception ex)
            {
                await ErrorHandling.HandleErrorResponse(response);

            }
        }

        // an http request method that for getting all models
        private async Task<List<GetModelsByManufactureRequest>> getModels()
        {

            HttpResponseMessage response = await Program.client.GetAsync("StorageHandler/" + manufactureComboBox.Text);
            try
            {
                if (response.IsSuccessStatusCode)
                {
                    string result = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<List<GetModelsByManufactureRequest>>(result);
                }
                else
                {
                    await ErrorHandling.HandleErrorResponse(response);
                    return new List<GetModelsByManufactureRequest>();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<GetModelsByManufactureRequest>();

            }



        }

        private void inserManufacturesToComboBox()
        {
            foreach (GetManufacturesRequest manu in manuList)
            {
                manufactureComboBox.Items.Add(manu.manufacturerName);
            }
        }

        // a validation method for checking if a string contains only numbers
        public bool isNumeric(string toCheck)
        {
            int isNumber = 0;
            bool result = int.TryParse(toCheck, out isNumber);
            return !result;
        }
        // a validation method for checking if a character contains numbers
        public bool isNumeric(char toCheck)
        {
            int isNumber = 0;
            bool result = int.TryParse(toCheck.ToString(), out isNumber);
            return !result;
        }

        // a validation method for checking if a string contains only numbers and non negative
        public bool isNegative(string toCheck)
        {
            if (isNumeric(toCheck))
            {
                int num = int.Parse(toCheck);
                if (num < 0)
                {
                    return true;
                }
                return false;
            }
            return false;
        }

        // a validation method for checking if a string contains numbers
        private bool isNumInString(string toCheck)
        {
            foreach (char ch in toCheck)
            {
                if (!isNumeric(ch))
                {
                    return true;
                }
            }
            return false;
        }



        // validation tests
        private bool fieldCheck()
        {
            bool checkFiled;

            if (clientIdTxt.Text == String.Empty || clientFullNameTxt.Text == String.Empty ||
                clientPhoneTxt.Text == String.Empty || carNumberTxt.Text == String.Empty ||
                manufactureComboBox.Text == String.Empty || modelsComboBox.Text == String.Empty ||
                carYearTxt.Text == String.Empty || carEngineTxt.Text == String.Empty ||
                carKMTxt.Text == String.Empty || vinNumberTxt.Text == String.Empty)
            {
                MessageBox.Show("One or more fields is empty", "Error");
                return true;
            }
            else if (isNegative(clientIdTxt.Text) ||
                isNegative(clientPhoneTxt.Text) || isNegative(carNumberTxt.Text) ||
                isNegative(carYearTxt.Text) || isNegative(carEngineTxt.Text) ||
                isNegative(carKMTxt.Text))
            {
                MessageBox.Show("One or more fields is negative", "Error");
                return true;
            }
            else if (carNumberTxt.Text.Length < 7 || clientIdTxt.Text.Length != 9 ||
                carNumberTxt.Text.Length > 8 || clientPhoneTxt.Text.Length != 10 ||
                carYearTxt.Text.Length != 4)
            {
                MessageBox.Show("One or more fields length is incorrect", "Error");
                return true;
            }
            else if (isNumInString(clientFullNameTxt.Text))
            {
                MessageBox.Show("Client name cannot be a number", "Error");
                return true;
            }
            int.TryParse(carYearTxt.Text, out int year);
            if(year > DateTime.Now.Year)
            {
                MessageBox.Show("Car Year cannot be a higher than current year", "Error");
                return true;
            }
            return false;

        }

        private void createNewClientBtn_Click(object sender, EventArgs e)
        {
            if (fieldCheck())
            {
                MessageBox.Show("One or more inputs is incorrect", "Error");
            }
            else
            {
                car = new Car(carNumberTxt.Text, clientIdTxt.Text, manufactureComboBox.Text, modelsComboBox.Text, carEngineTxt.Text, int.Parse(carYearTxt.Text), vinNumberTxt.Text);
                client = new Client(clientIdTxt.Text, clientFullNameTxt.Text, clientPhoneTxt.Text, clientEmailTxt.Text, clientAddressTxt.Text, car);

                CreateClientRequest(client, car);
            }
        }

        // an http request method that for creating a new client
        private async void CreateClientRequest(Client client, Car car)
        {
            CreateClientRequest createClientRequest = new CreateClientRequest
            {
                id = client.clientId,
                name = client.name,
                phone = client.phone,
                email = client.email,
                address = client.address,
                carId = car.carId,
                carManufacture = car.carManufacture,
                carModel = car.carModel,
                carEngine = car.carEngine,
                carYear = car.carYear,
                carKilometer = car.carKilometer,
                vinNumber = car.vinNumber
            };

            HttpResponseMessage response = await Program.client.PostAsJsonAsync(
               "client/", createClientRequest);

            try
            {

                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    MessageBox.Show("Client " + client.name + " Added successfully", "success");

                    this.Hide();
                }
                else if (response.StatusCode.Equals(HttpStatusCode.Conflict))
                {
                    MessageBox.Show("Client " + client.name + " Already exists", "conflict");

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

        public void initializeModels()
        {

            modelsComboBox.Items.Clear();
            foreach (GetModelsByManufactureRequest model in modelList)
            {
                modelsComboBox.Items.Add(model.model);
            }

        }

        private async void manufactureComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            modelList = await getModels();
            initializeModels();
        }
    }
}
