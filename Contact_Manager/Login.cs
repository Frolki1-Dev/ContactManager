using System;
using System.Windows.Forms;
using System.Collections.Generic;
using Contact_Manager.Themes;

namespace Contact_Manager
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            DataContainer.LoadAll(DataContainer.Users);
        }

        private void CmdLogin_Click(object sender, EventArgs e)
        {
            authenticate();
        }

        private void TxtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Execute login
                authenticate();
            }
        }

        private void authenticate()
        {
            // Check first all inputs
            if (TxtUsername.TextLength < 1 || TxtPassword.TextLength < 1)
            {
                MessageBox.Show("Leider wurden nicht alle Felder ausgefüllt.", "Eingabe fehlerhaft", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Try to authenticate the user
            if (!Authentication.Authentication.Authenticate(TxtUsername.Text, TxtPassword.Text))
            {
                MessageBox.Show("Leider wurde die Kombination nicht gefunden.", "Anmeldedaten fehlerhaft", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // You did it!
            this.Hide();
            (new Template()).ShowDialog();
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            MainTheme.initThemeForForm(this);
        }
    }
}
