using System;
using System.Windows.Forms;

namespace Contact_Manager
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void CmdLogin_Click(object sender, EventArgs e)
        {
            // Check first all inputs
            if(TxtUsername.TextLength < 1 || TxtPassword.TextLength < 1)
            {
                MessageBox.Show("Leider wurden nicht alle Felder ausgefüllt.", "Eingabe fehlerhaft", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Try to authenticate the user
            if (!Authentication.Authentication.authenticate(TxtUsername.Text, TxtPassword.Text))
            {
                MessageBox.Show("Leider wurde die Kombination nicht gefunden.", "Anmeldedaten fehlerhaft", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // You did it!
            this.Hide();
            (new Frm1()).ShowDialog();
            this.Close();
        }
    }
}
