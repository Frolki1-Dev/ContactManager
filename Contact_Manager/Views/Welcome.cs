﻿using System;
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
            if(IsFormValid())
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
            if(TxtUsername.TextLength < 1 || TxtPassword.TextLength < 6)
            {
                return false;
            }

            
            return true;
        }

        /**
         * Create the database and insert the user
         */
        private void CmdCreateDatabaseAndUser_Click(object sender, EventArgs e)
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

            this.Hide();
            (new Login()).ShowDialog();
            this.Close();

            /*string databaseFile = Helper.GetUserProfilePath("crm.db");

            try
            {
                DatabaseConnection.buildDatabase(databaseFile, TxtUsername.Text, TxtPassword.Text);

                if (DatabaseConnection.hasActiveConnection())
                {
                    this.Hide();
                    (new Login()).ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Fehler", "Erstellungsfehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erstellungsfehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            MainTheme.InitThemeForForm(this);
        }
    }
}