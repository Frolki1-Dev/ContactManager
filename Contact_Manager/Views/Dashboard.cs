using System;
using System.Drawing;
using System.Windows.Forms;
using Contact_Manager.Themes;

namespace Contact_Manager.Views
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();

            // Set employee data
            DashboardItemEmployee.SetCounter(DataContainer.GetEmployeeCollection().Count);
            DashboardItemEmployee.SetIcon(Properties.Resources.user_hard_hat);
            DashboardItemEmployee.SetTitle("Anzahl Mitarbeiter");

            // Set customer data
            DashboardItemCustomers.SetCounter(DataContainer.GetCustomerCollection().Count);
            DashboardItemCustomers.SetIcon(Properties.Resources.users_crown);
            DashboardItemCustomers.SetTitle("Anzahl Kunden");

            // Set trainees data
            DashboardItemTrainees.SetCounter(DataContainer.GetTraineeCollection().Count);
            DashboardItemTrainees.SetIcon(Properties.Resources.user_graduate);
            DashboardItemTrainees.SetTitle("Anzahl Lehrlinge");

            // Set users data
            DashboardItemUsers.SetCounter(DataContainer.GetUserCollection().Count);
            DashboardItemUsers.SetIcon(Properties.Resources.user_shield);
            DashboardItemUsers.SetTitle("Anzahl Benutzer");
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            MainTheme.InitThemeForForm(this);
            LblGreeting.Font = new Font(Properties.Settings.Default.TitleFont, FontStyle.Bold);
            LblGreeting.ForeColor = Color.White;
            LblGreeting.Text = LblGreeting.Text.Replace("USERNAME", Authentication.Authentication.GetUser().Username);
            PnlHeader.BackColor = Properties.Settings.Default.SecondaryColor;
        }
    }
}