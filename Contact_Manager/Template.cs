using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Contact_Manager.Partials.Dialog;
using Contact_Manager.Partials.Overview;
using Contact_Manager.Views;

namespace Contact_Manager
{
    public partial class Template : Form
    {
        private string _activeSection = "Dashboard";
        private Form _activeForm;

        public Template()
        {
            InitializeComponent();
            /*DataContainer.LoadAll(DataContainer.Customers);
            DataContainer.LoadAll(DataContainer.Employees);
            DataContainer.LoadAll(DataContainer.Trainees);*/

            SetPageTitle("Dashboard");
            LoadFormIntoPanel(new DashboardOverview());
            CmdCreateResource.Visible = false;
        }

        private void CmdDashboard_Click(object sender, EventArgs e)
        {
            ClearPageContentPanel();
            SetPageTitle("Dashboard");
            LoadFormIntoPanel(new DashboardOverview());
            CmdCreateResource.Visible = false;
        }

        protected void SetPageTitle(string title)
        {
            LblPageTitle.Text = title;
        }

        private void CmdUsers_Click(object sender, EventArgs e)
        {
            _activeSection = "Users";
            SetPageTitle("Benutzerstamm");
            LoadFormIntoPanel(new UsersOverview());
        }

        private void CmdLogout_Click(object sender, EventArgs e)
        {
            Authentication.Authentication.Logout();
            this.Hide();
            (new Login()).ShowDialog();
            this.Close();
        }

        private void Template_Load(object sender, EventArgs e)
        {
            LblWelcomeUser.Text = "Hallo, " + Authentication.Authentication.GetUser().Username;
        }

        private void CmdCreateResource_Click(object sender, EventArgs e)
        {
            Form dialog = null;

            switch (_activeSection)
            {
                case "Users":
                    dialog = new UserDialog();
                    break;
                case "Customers":
                    dialog = new CustomerDialog();
                    break;
                case "Employees":
                    dialog = new EmployeeDialog();
                    break;
                case "Trainees":
                    dialog = new TraineeDialog();
                    break;
                default:
                    return;
            }

            dialog.FormClosing += DialogClosing;
            dialog.Show();
        }

        private void LoadFormIntoPanel(Form form)
        {
            // Fix the issue #25
            ClearPageContentPanel();

            _activeForm = form;
            _activeForm.TopLevel = false;
            _activeForm.AutoScroll = true;
            PnlPageContent.Controls.Add(_activeForm);
            _activeForm.Dock = DockStyle.Fill;
            _activeForm.Dock = DockStyle.Fill;
            _activeForm.FormBorderStyle = FormBorderStyle.None;
            CmdCreateResource.Visible = true;
            _activeForm.Show();
        }

        private void ClearPageContentPanel()
        {
            if (_activeForm == null)
            {
                return;
            }

            _activeForm.Close();
            _activeForm = null;
            CmdCreateResource.Visible = false;
        }

        private void DialogClosing(object sender, FormClosingEventArgs e)
        {
            if (typeof(UserDialog) == sender.GetType())
            {
                ClearPageContentPanel();
                LoadFormIntoPanel(new UsersOverview());
            }
        }

        private void CmdCustomers_Click(object sender, EventArgs e)
        {
            _activeSection = "Customers";
            SetPageTitle("Kundenstamm");
            LoadFormIntoPanel(new CustomersOverview());
        }

        private void CmdEmployees_Click(object sender, EventArgs e)
        {
            _activeSection = "Employees";
            SetPageTitle("Mitarbeiterstamm");
            LoadFormIntoPanel(new EmployeesOverview());
        }

        private void CmdTrainees_Click(object sender, EventArgs e)
        {
            _activeSection = "Trainees";
            SetPageTitle("Lehrlingsstamm");
            LoadFormIntoPanel(new TraineesOverview());
        }
    }
}
