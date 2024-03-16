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
using Garage.Utils;
using static Garage.Models.JobTitleClass;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Garage.Screens.AdminScreens
{
    // all users form, used to create, read, update and delete users via http requests
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

        // an http request method that for getting all the users

        public async void GetAllUsers()
        {
            HttpResponseMessage response = await Program.client.GetAsync("user/");
            try
            {

                if (response.IsSuccessStatusCode)
                {
                    string result = await response.Content.ReadAsStringAsync();
                    List<GetAllUsersRequest> list = JsonConvert.DeserializeObject<List<GetAllUsersRequest>>(result);

                    AllUsersGridView.DataSource = list;

                    AllUsersGridView.Columns["Id"].HeaderText = "Id";
                    AllUsersGridView.Columns["UserName"].HeaderText = "User Name";
                    AllUsersGridView.Columns["Password"].HeaderText = "Password";
                    AllUsersGridView.Columns["Email"].HeaderText = "Email";
                    AllUsersGridView.Columns["JobTitle"].HeaderText = "Job Title";
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


        private void AllUsersGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                useridLbl.Text = AllUsersGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                userNameTxt.Text = AllUsersGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                passwordTxt.Text = AllUsersGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                emailTxt.Text = AllUsersGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                jobTitleTxt.Text = AllUsersGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            if (userNameTxt.Text == String.Empty || passwordTxt.Text == String.Empty || emailTxt.Text == String.Empty || jobTitleTxt.Text == String.Empty)
            {
                MessageBox.Show("All inputs are required", "error");
            }
            else
            {
                createUserRequest(userNameTxt.Text, passwordTxt.Text, emailTxt.Text, jobTitleTxt.Text);
                AllUsersForm allUsersForm = new AllUsersForm();
            }
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

        // an http request method that for creating new user
        private async void createUserRequest(string username, string password, string email, string jobTitle)
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

            try
            {

                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    MessageBox.Show("user " + username + " Added successfully", "success");

                    this.Hide();
                }
                else if (response.StatusCode.Equals(HttpStatusCode.Conflict))
                {
                    MessageBox.Show("user " + username + " Already exists", "conflict");

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

        // an http request method that for updating an existing user
        public async void UpdateUser(User user)
        {
            HttpResponseMessage response = await Program.client.PutAsJsonAsync("user/" + user.Id, user);
            try
            {

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("User " + user.UserName + " updated succesfully");
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
            finally
            {

                this.Refresh();
            }
        }

        // an http request method that for deleting a specific user
        public async void DeleteUser(User user)
        {
            HttpResponseMessage response = await Program.client.DeleteAsync("user/" + user.Id);
            try
            {

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("User " + user.UserName + " deleted succesfully");
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
