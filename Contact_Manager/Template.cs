using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact_Manager
{
    public partial class Template : Form
    {
        public Template()
        {
            InitializeComponent();
        }

        private void CmdDashboard_Click(object sender, EventArgs e)
        {
            SetPageTitle("Dashboard");
            /*this.Hide();
            (new FormDashboard()).ShowDialog();
            this.Close();*/
        }

        protected void SetPageTitle(string title)
        {
            LblPageTitle.Text = title;
        }

        private void CmdUsers_Click(object sender, EventArgs e)
        {
            SetPageTitle("Benutzerstamm");
            
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
    }
}
