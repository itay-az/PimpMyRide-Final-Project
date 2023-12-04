using Garage.Models;
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
using System.Web.Helpers;
using System.Web.Mvc;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Garage.Screens.ClientsScreens
{
    public partial class SearchClientForm : Form
    {

        Client jsonResult;
        public SearchClientForm()
        {
            InitializeComponent();
            changeVisibilityToFalse();
        }

        private void searchClientBtn_Click(object sender, EventArgs e)
        {
            if(searchClientIdTxt.Text == String.Empty && carNumberComboBox.Text == String.Empty)
            {
                MessageBox.Show("Please fill one field");
            }
            else if (!(searchClientIdTxt.Text == String.Empty) && !(carNumberComboBox.Text == String.Empty))
            {
                MessageBox.Show("Cannot search by 2 fields");
            }
            else if(!(searchClientIdTxt.Text == String.Empty) && carNumberComboBox.Text == String.Empty)
            {
                searchClientById(searchClientIdTxt.Text);
            }
            else
            {
                searchClientByCarId(carNumberComboBox.Text);
            }
        }


        public async void searchClientById(string id)
        {
            HttpResponseMessage response = await Program.client.GetAsync("client/getClientByClientId/" + id);

            if (response.IsSuccessStatusCode)
            {
                var responseResult = await response.Content.ReadAsStringAsync();
                jsonResult = JsonConvert.DeserializeObject<Client>(responseResult);
                changeVisibilityToTrue();

                searchClientFullNameTxt.Text = jsonResult.name;
                searchClientEmailTxt.Text = jsonResult.email;
                searchClientAddressTxt.Text = jsonResult.address;
                searchClientPhoneTxt.Text = jsonResult.phone;
                carNumberComboBox.Text = jsonResult.cars[0].carId.ToString();
                searchCarManuTxt.Text = jsonResult.cars[0].carManufacture.ToString();
                searchCarModelTxt.Text = jsonResult.cars[0].carModel.ToString();
                searchCarYearTxt.Text = jsonResult.cars[0].carYear.ToString();
                searchCarEngineTxt.Text = jsonResult.cars[0].carEngine.ToString();
                searchVinNumberTxt.Text = jsonResult.cars[0].vinNumber.ToString();
                foreach(Car c in jsonResult.cars)
                {
                    carNumberComboBox.Items.Add(c.carId.ToString());
                }
            }
            else
            {
                MessageBox.Show("Client not found, Please create new client", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChosenCar(Client client, int index)
        {


            carNumberComboBox.Text = client.cars[index].carId.ToString();
            searchCarManuTxt.Text = client.cars[index].carManufacture.ToString();
            searchCarModelTxt.Text = client.cars[index].carModel.ToString();
            searchCarYearTxt.Text = client.cars[index].carYear.ToString();
            searchCarEngineTxt.Text = client.cars[index].carEngine.ToString();
            searchVinNumberTxt.Text = client.cars[index].vinNumber.ToString();
        }

        public async void searchClientByCarId(string id)
        {
            HttpResponseMessage response = await Program.client.GetAsync("client/getClientByCarId/" + id);

            if (response.IsSuccessStatusCode)
            {
                var responseResult = await response.Content.ReadAsStringAsync();
                var jsonResult = JsonConvert.DeserializeObject<Client>(responseResult);
                changeVisibilityToTrue();

                searchClientIdTxt.Text = jsonResult.clientId;
                searchClientFullNameTxt.Text = jsonResult.name;
                searchClientEmailTxt.Text = jsonResult.email;
                searchClientAddressTxt.Text = jsonResult.address;
                searchClientPhoneTxt.Text = jsonResult.phone;
                carNumberComboBox.Text = jsonResult.cars[0].carId.ToString();
                searchCarManuTxt.Text = jsonResult.cars[0].carManufacture.ToString();
                searchCarModelTxt.Text = jsonResult.cars[0].carModel.ToString();
                searchCarYearTxt.Text = jsonResult.cars[0].carYear.ToString();
                searchCarEngineTxt.Text = jsonResult.cars[0].carEngine.ToString();
                searchVinNumberTxt.Text = jsonResult.cars[0].vinNumber.ToString();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void changeVisibilityToTrue()
        {
            clientNameLbl.Visible = true;
            clientAddressLbl.Visible = true;
            clientEmailLbl.Visible = true;
            clientPhoneLbl.Visible = true;
            carManufactureLbl.Visible = true;
            carModelLbl.Visible = true;
            carYearLbl.Visible = true;
            carEngineLbl.Visible = true;
            vinNumberLbl.Visible = true;
            carKilometerLbl.Visible = true;

            searchClientFullNameTxt.Visible = true;
            searchClientEmailTxt.Visible = true;
            searchClientAddressTxt.Visible = true;
            searchClientPhoneTxt.Visible = true;
            searchCarManuTxt.Visible = true;
            searchCarModelTxt.Visible = true;
            searchCarYearTxt.Visible = true;
            searchCarEngineTxt.Visible = true;
            searchVinNumberTxt.Visible = true;
            carKilometerTxt.Visible = true;

            clientHistoryBtn.Visible = true;

        }

        private void changeVisibilityToFalse()
        {
            clientNameLbl.Visible = false;
            clientAddressLbl.Visible = false;
            clientEmailLbl.Visible = false;
            clientPhoneLbl.Visible = false;
            carManufactureLbl.Visible = false;
            carModelLbl.Visible = false;
            carYearLbl.Visible = false;
            carEngineLbl.Visible = false;
            vinNumberLbl.Visible = false;
            carKilometerLbl.Visible = false;

            searchClientFullNameTxt.Visible = false;
            searchClientEmailTxt.Visible = false;
            searchClientAddressTxt.Visible = false;
            searchClientPhoneTxt.Visible = false;
            searchCarManuTxt.Visible = false;
            searchCarModelTxt.Visible = false;
            searchCarYearTxt.Visible = false;
            searchCarEngineTxt.Visible = false;
            searchVinNumberTxt.Visible = false;
            carKilometerTxt.Visible = false;

            clientHistoryBtn.Visible = false;

        }

        private void carNumberComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChosenCar(jsonResult, carNumberComboBox.SelectedIndex);
        }

        private void updateClientBtn_Click(object sender, EventArgs e)
        {
            Client client = new Client(searchClientIdTxt.Text, searchClientFullNameTxt.Text, searchClientPhoneTxt.Text, searchClientEmailTxt.Text, searchClientAddressTxt.Text, jsonResult.cars);
            Car car = new Car(carNumberComboBox.Text, searchClientIdTxt.Text, searchCarManuTxt.Text, searchCarModelTxt.Text, searchCarEngineTxt.Text, int.Parse(searchCarYearTxt.Text), searchVinNumberTxt.Text);
            UpdateClient(client, car);
        }


        private async void UpdateClient(Client client, Car car)
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

            HttpResponseMessage response = await Program.client.PutAsJsonAsync(
               "client/" + client.clientId, createClientRequest);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Client " + client.name + " Updated successfully", "success");

                this.Close();
            }
            else if (response.StatusCode.Equals(HttpStatusCode.Conflict))
            {
                MessageBox.Show($"Client {client.name} or car {car.carManufacture} {car.carModel} already exist");

            }
            else
            {
                MessageBox.Show(" Failed ", "Error");
            }
        }

        private void addCarToClientBtn_Click(object sender, EventArgs e)
        {
            addCarToClient();
        }

        private async void addCarToClient()
        {
            AddCarToClientRequest addCarToClientRequest = new AddCarToClientRequest
            {
                carId = carNumberComboBox.Text,
                clientId = searchClientIdTxt.Text,
                carManufacture = searchCarManuTxt.Text,
                carModel = searchCarModelTxt.Text,
                carEngine = searchCarEngineTxt.Text,
                carYear = int.Parse(searchCarYearTxt.Text),
                vinNumber = searchVinNumberTxt.Text,
                dateTime =DateTime.Now,

            };

            HttpResponseMessage response = await Program.client.PutAsJsonAsync("client/client/addCar/" + addCarToClientRequest.clientId, addCarToClientRequest);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show($"Car {addCarToClientRequest.carManufacture} {addCarToClientRequest.carModel} has been added successfully to client {searchClientFullNameTxt.Text}", "success");

                this.Close();
            }
            else if (response.StatusCode.Equals(HttpStatusCode.Conflict))
            {
                MessageBox.Show($"Client {searchClientFullNameTxt.Text} or car {addCarToClientRequest.carManufacture} {addCarToClientRequest.carModel} already exist");

            }
            else
            {
                MessageBox.Show(" Failed ", "Error");
            }
        }

        private void clientHistoryBtn_Click(object sender, EventArgs e)
        {
            CarHistoryForm carHistoryForm = new CarHistoryForm(carNumberComboBox.Text);
            carHistoryForm.ShowDialog();
        }
    }
}
