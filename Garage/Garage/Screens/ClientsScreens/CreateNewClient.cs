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

namespace Garage.Screens.ClientsScreens
{
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

        private async void getManufactures()
        {
            HttpResponseMessage response = await Program.client.GetAsync("StorageHandler/getManufactures");
            if (response.IsSuccessStatusCode)
            {
                string result = await response.Content.ReadAsStringAsync();
                manuList = JsonConvert.DeserializeObject<List<GetManufacturesRequest>>(result);
                inserManufacturesToComboBox();

            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private async Task<List<GetModelsByManufactureRequest>> getModels()
        {

                HttpResponseMessage response = await Program.client.GetAsync("StorageHandler/" + manufactureComboBox.Text);
                if (response.IsSuccessStatusCode)
                {
                    string result = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<List<GetModelsByManufactureRequest>>(result);
                }
                else
                {
                    MessageBox.Show("Error");
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

        public bool isNumeric(string toCheck)
        {
            int isNumber = 0;
            bool result = int.TryParse(toCheck, out isNumber);
            return !result;
        }
        public bool isNumeric(char toCheck)
        {
            int isNumber = 0;
            bool result = int.TryParse(toCheck.ToString(), out isNumber);
            return !result;
        }

        public bool isNegative(string toCheck)
        {
            if(isNumeric(toCheck))
            {
                int num = int.Parse(toCheck);
                if(num < 0) 
                {
                    return true;
                }
                return false;
            }
            return false;
        }

        private bool isNumInString(string toCheck)
        {
            foreach(char ch in toCheck)
            {
                if(!isNumeric(ch))
                {
                    return true;
                }
            }
            return false;
        }



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
                return false;
            
        }

        private void createNewClientBtn_Click(object sender, EventArgs e)
        {
            if(fieldCheck())
            {
                MessageBox.Show("One or more inputs is incorrect","Error");
            }
            else
            {
                car = new Car(carNumberTxt.Text, clientIdTxt.Text, manufactureComboBox.Text, modelsComboBox.Text,carEngineTxt.Text, int.Parse(carYearTxt.Text), vinNumberTxt.Text, int.Parse(carKMTxt.Text));
                client = new Client(clientIdTxt.Text, clientFullNameTxt.Text, clientPhoneTxt.Text,clientEmailTxt.Text, clientAddressTxt.Text,car);

                CreateClientRequest(client, car);
            }
        }


        private async void CreateClientRequest(Client client,Car car)
        {

            CreateClientRequest createClientRequest = new CreateClientRequest
            {
                id = client.id,
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

                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    MessageBox.Show("Client " + client.name + " Added successfully", "success");

                    this.Close();
                }
                else if (response.StatusCode.Equals(HttpStatusCode.Conflict))
                {
                    MessageBox.Show("Client " + client.name + " Already exists", "conflict");

                }
                else
                {
                    MessageBox.Show(" Failed ", "Error");
                }
        }

        public void initializeModels ()
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
