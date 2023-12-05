using System;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using System.Text;
using Garage.Models;
using System.Drawing;

namespace Garage
{
    public partial class LoginForm : Form
    {
        public static Dashboard dashboardForm;
        public LoginForm()
        {
            InitializeComponent();

            Loginbtn.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Loginbtn.Width, Loginbtn.Height, 15, 15));
        }

        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            LoginRequest(UserNametxt.Text, Passwordtxt.Text);
            
        }

        public async void LoginRequest(string username, string password)
        {
            if(username == String.Empty || password == String.Empty)
            {
                MessageBox.Show("All fields are required", "Error");
                return;
            }

            LoginRequest payload = new LoginRequest(username, password);

            HttpResponseMessage response = await Program.client.PostAsJsonAsync(
                "login/", payload);

            await Console.Out.WriteLineAsync(response.ToString());
            if(response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();

                dashboardForm = new Dashboard(result, UserNametxt.Text);
                dashboardForm.Show();

            }
            else
            {

                MessageBox.Show("UserName or password incorrect", "Error");
            }
        }

        private void Loginbtn_Click_1(object sender, EventArgs e)
        {
            LoginRequest(UserNametxt.Text,Passwordtxt.Text);
        }
    }
}
