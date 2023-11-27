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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;
using System.Timers;

namespace Garage.Screens.AdminScreens
{
    public partial class AllUsersForm : Form
    {
        private System.Timers.Timer timer;
        private Dashboard dashboard;
        private User user;

        public AllUsersForm()
        {
            InitializeComponent();
            GetAllUsers();
        }

        public async void GetAllUsers()
        {
            HttpResponseMessage response = await Program.client.GetAsync("user/");
            if(response.IsSuccessStatusCode)
            {
                string result = await response.Content.ReadAsStringAsync();
                List<GetAllUsersRequest> list = JsonConvert.DeserializeObject<List<GetAllUsersRequest>>(result);

                AllUsersGridView.DataSource = list;
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void AllUsersForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'garageDataSet.User' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.garageDataSet.User);

        }

        private void AllUsersGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            useridLbl.Text = AllUsersGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            userNameTxt.Text =  AllUsersGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            passwordTxt.Text = AllUsersGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            emailTxt.Text = AllUsersGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            jobTitleTxt.Text = AllUsersGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            createUserRequest(userNameTxt.Text, passwordTxt.Text, emailTxt.Text, jobTitleTxt.Text);
            AllUsersForm allUsersForm = new AllUsersForm();
            
            refreshData();
        }



        private void updateUserBtn_Click(object sender, EventArgs e)
        {
            user = new User();
            user.Id = int.Parse(useridLbl.Text);
            user.UserName = userNameTxt.Text;
            user.Password = passwordTxt.Text;
            user.Email = emailTxt.Text;
            user.JobTitle = JobTitleClass.GetValue(jobTitleTxt.Text);
            UpdateUser(user);
            AllUsersForm allUsersForm = new AllUsersForm();

            refreshData();



        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            user = new User();
            user.Id = int.Parse(useridLbl.Text);
            user.UserName = userNameTxt.Text;
            user.Password = passwordTxt.Text;
            user.Email = emailTxt.Text;
            user.JobTitle = JobTitleClass.GetValue(jobTitleTxt.Text);
            DeleteUser(user);
            AllUsersForm allUsersForm = new AllUsersForm();

            refreshData();

        }


        private async void createUserRequest(string username, string password, string email, string jobTitle)
        {
            if (username == String.Empty || password == String.Empty || email == String.Empty || jobTitle == String.Empty)
            {
                MessageBox.Show("All inputs are required", "error");
            }
            else
            {
                CreateUserRequest createUserRequest = new CreateUserRequest
                {
                    UserName = username,
                    Password = password,
                    Email = email,
                    JobTitle = jobTitle == "Manager" ? JobTitleClass.JobTitle.Manager : jobTitle == "ServiceAdvisor" ? JobTitleClass.JobTitle.ServiceAdvisor : JobTitleClass.JobTitle.Warehouse
                };
                HttpResponseMessage response = await Program.client.PostAsJsonAsync(
                   "user/", createUserRequest);

                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    MessageBox.Show("user " + username + " Added successfully", "success");

                    this.Close();
                }
                else if (response.StatusCode.Equals(HttpStatusCode.Conflict))
                {
                    MessageBox.Show("user " + username + " Already exists", "conflict");

                }
                else
                {
                    MessageBox.Show(" Failed ", "Error");

                }
            }


        }

        public async void UpdateUser(User user)
        {
            HttpResponseMessage response = await Program.client.PutAsJsonAsync("user/" + user.Id, user);
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("User " + user.UserName + " updated succesfully");
            }
            else
            {
                MessageBox.Show("Error", " UserNotFound");
            }
            this.Refresh();
        }

        public async void DeleteUser(User user)
        {
            HttpResponseMessage response = await Program.client.DeleteAsync("user/" + user.Id);
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("User " + user.UserName + " deleted succesfully");
            }
            else
            {
                MessageBox.Show("Error", " UserNotFound");
            }

        }
        private void refreshData()
        {
            dashboard = new Dashboard();
            timer = new System.Timers.Timer();
            timer.Interval = 2000;
            timer.Enabled = true;
            dashboard.adminMenuBtnClick();

        }




    }
}
