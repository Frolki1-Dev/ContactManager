using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            DashboardItemEmployee.setCounter(5);
            DashboardItemEmployee.setIcon(Properties.Resources.user_hard_hat);
            DashboardItemEmployee.setTitle("Anzahl Mitarbeiter");

            // Set customer data
            DashboardItemCustomers.setCounter(5);
            DashboardItemCustomers.setIcon(Properties.Resources.users_crown);
            DashboardItemCustomers.setTitle("Anzahl Kunden");

            // Set trainees data
            DashboardItemTrainees.setCounter(5);
            DashboardItemTrainees.setIcon(Properties.Resources.user_graduate);
            DashboardItemTrainees.setTitle("Anzahl Lehrlinge");

            // Set users data
            DashboardItemUsers.setCounter(5);
            DashboardItemUsers.setIcon(Properties.Resources.user_shield);
            DashboardItemUsers.setTitle("Anzahl Benutzer");
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
