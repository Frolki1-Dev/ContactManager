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

namespace Contact_Manager
{
    public partial class Template : Form
    {
        private string activeSection = "Dashboard";
        private Form activeForm;

        public Template()
        {
            InitializeComponent();
            CmdCreateResource.Visible = false;
        }

        private void CmdDashboard_Click(object sender, EventArgs e)
        {
            ClearPageContentPanel();
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
            activeSection = "Users";
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
            switch (activeSection)
            {
                case "Users":
                    UserDialog dialog = new UserDialog();
                    dialog.FormClosing += DialogClosing;
                    dialog.Show();
                    break;
            }
        }

        private void LoadFormIntoPanel(Form form)
        {
            activeForm = form;
            activeForm.TopLevel = false;
            activeForm.AutoScroll = true;
            PnlPageContent.Controls.Add(activeForm);
            activeForm.Dock = DockStyle.Fill;
            activeForm.Dock = DockStyle.Fill;
            activeForm.FormBorderStyle = FormBorderStyle.None;
            CmdCreateResource.Visible = true;
            activeForm.Show();
        }

        private void ClearPageContentPanel()
        {
            if (activeForm == null)
            {
                return;
            }

            activeForm.Close();
            activeForm = null;
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
    }
}
