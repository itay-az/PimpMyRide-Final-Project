using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Garage.Screens.ServiceAdvisor
{
    public partial class ServiceAdvisorMenu : Form
    {
        public ServiceAdvisorMenu()
        {
            InitializeComponent();
        }

        private void allClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchClientForm searchClientForm = new SearchClientForm();
            searchClientForm.Show();
        }
    }
}
