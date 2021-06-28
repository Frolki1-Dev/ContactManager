using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Contact_Manager
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            /*Models.User u = new Models.User();

            List<string> columns = new List<string>();
            columns.Add("username");
            columns.Add("password");
            columns.Add("active");
            columns.Add("is_admin");

            Dictionary<string, dynamic> values = new Dictionary<string, dynamic>();
            values.Add("@username", "admin");
            values.Add("@password", "123");
            values.Add("@active", 1);
            values.Add("@is_admin", 0);

            u.insert(columns, values);*/
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
