using System;
using System.IO;
using System.Windows.Forms;
using Contact_Manager.Models;
using Contact_Manager.Themes;

namespace Contact_Manager.Partials.Dialog
{
    public partial class UserDialog : Form
    {
        private User _editUser;

        public UserDialog()
        {
            InitializeComponent();
        }

        public UserDialog(User user)
        {
            InitializeComponent();
            _editUser = user;
            TxtUsername.Text = user.Username;
            ChkActive.Checked = user.Active;
            ChkIsAdmin.Checked = user.IsAdmin;
            CmdCreateUser.Text = "Benutzer anpassen";

            if (user.Deleted)
            {
                CmdCreateUser.Enabled = false;
                CmdCreateUser.Text = "Benutzer kann nicht mehr bearbeitet werden!";
            }
        }

        private void CmdCreateUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (_editUser == null)
                {
                    CreateUser();
                }
                else
                {
                    UpdateUser();
                }

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CreateUser()
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
        }

        private void UpdateUser()
        {
            // Set the new properties
            _editUser.Username = TxtUsername.Text;

            if (Authentication.Authentication.GetUser().Id != _editUser.Id)
            {
                _editUser.Active = ChkActive.Checked;
                _editUser.IsAdmin = ChkIsAdmin.Checked;
            }

            // Change password only if the password is valid
            if (TxtPassword.Text.Length >= 6)
            {
                _editUser.Password = TxtPassword.Text;
            }

            DataContainer.Update(_editUser);
        }

        private void UserDialog_Load(object sender, EventArgs e)
        {
            MainTheme.InitThemeForForm(this);
        }
    }
}