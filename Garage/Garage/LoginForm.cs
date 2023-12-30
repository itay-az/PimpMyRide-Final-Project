using System;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using System.Text;
using Garage.Models;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Garage.Utils;

namespace Garage
{
    // the login screen for the users
    public partial class LoginForm : Form
    {
        public static Dashboard dashboardForm;
        public LoginForm()
        {
            InitializeComponent();

            Loginbtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Loginbtn.Width, Loginbtn.Height, 15, 15));

        }



        // formatting the login button round
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            LoginRequest(UserNametxt.Text, Passwordtxt.Text);
            
        }

        // an http request method that for login
        public async void LoginRequest(string username, string password)
        {
            if(username == String.Empty || password == String.Empty)
            {
                MessageBox.Show("All fields are required", "Error");
                return;
            }

            LoginRequest loginRequest = new LoginRequest(username, password);

            
            try
            {
                HttpResponseMessage response = await Program.client.PostAsJsonAsync(
                "login/", loginRequest);

                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();

                    dashboardForm = new Dashboard(result, UserNametxt.Text);
                    dashboardForm.Show();
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

        private void Loginbtn_Click_1(object sender, EventArgs e)
        {
            LoginRequest(UserNametxt.Text,Passwordtxt.Text);
        }
    }
}
