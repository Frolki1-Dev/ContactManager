using System;
using System.IO;
using System.Windows.Forms;
using Contact_Manager.Models;
using Contact_Manager.Themes;

namespace Contact_Manager.Views
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();

            // Add default values to the text box
            TxtUsername.Text = Environment.UserName;
            TxtPath.Text = Helper.GetApplicationDataPath();
        }

        /**
         * Checks if the button should be enabled
         */
        private void KeyupEvent(object sender, EventArgs e)
        {
            if (IsFormValid())
            {
                CmdCreateDatabaseAndUser.Enabled = true;
                return;
            }

            CmdCreateDatabaseAndUser.Enabled = false;
        }

        /**
         * Checks if the form is valid
         */
        private bool IsFormValid()
        {
            // TODO make better check
            if (TxtUsername.TextLength < 1 || TxtPassword.TextLength < 6)
            {
                return false;
            }


            return true;
        }

        private void CmdCreateDatabaseAndUser_Click(object sender, EventArgs e)
        {
            CreateApplicationFiles();
        }

        /**
         * Create all files for the application in the directory
         */
        private void CreateApplicationFiles()
        {
            Directory.CreateDirectory(Helper.GetApplicationDataPath());

            // Create the binary data files
            File.Create(Helper.GetApplicationDataPath("users.dat")).Dispose();
            File.Create(Helper.GetApplicationDataPath("employees.dat")).Dispose();
            File.Create(Helper.GetApplicationDataPath("trainees.dat")).Dispose();
            File.Create(Helper.GetApplicationDataPath("customers.dat")).Dispose();

            // Add the user to the data container
            User user = new User(TxtUsername.Text, TxtPassword.Text, true, true);

            DataContainer.AddModel(DataContainer.Users, user);

            Hide();
            (new Login()).ShowDialog();
            Close();
        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            MainTheme.InitThemeForForm(this);
        }

        private void TxtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CreateApplicationFiles();
            }
        }
    }
}