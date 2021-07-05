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
using Contact_Manager.Models;

namespace Contact_Manager
{
    public partial class FormAddUser : Form
    {
        public FormAddUser()
        {
            InitializeComponent();
        }

        private void CmdCreateUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtUsername.Text.Length < 1)
                {
                    throw new InvalidDataException("Ein Benutzername muss angegeben sein!");
                }

                if (DataContainer.GetUserCollection().UsernameExists(TxtUsername.Text))
                {
                    throw new InvalidDataException("Der Benutzername " + TxtUsername + " existiert schon!");
                }

                if (TxtPassword.Text.Length < 6)
                {
                    throw new InvalidDataException("Das Passwort muss mind. 6 Zeichen haben!");
                }

                // create the user
                User user = new User(TxtUsername.Text, TxtPassword.Text, ChkActive.Checked, ChkIsAdmin.Checked);

                DataContainer.AddModel(DataContainer.Users, user);

                MessageBox.Show("Benutzer " + user.Username + " erfolgreich erstellt.", "Erfolgreich",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (InvalidDataException ex)
            {
                MessageBox.Show(ex.Message, "Fehlerhafte Eingabe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
