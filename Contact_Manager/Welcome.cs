using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact_Manager
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();

            // Add default values to the text box
            TxtUsername.Text = Environment.UserName;
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
    }
}
