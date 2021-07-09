﻿using System;
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

namespace Contact_Manager.Partials.Dialog
{
    public partial class UserDialog : Form
    {
        private User editUser;

        public UserDialog()
        {
            InitializeComponent();
        }

        public UserDialog(User user)
        {
            InitializeComponent();
            editUser = user;
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
                if (editUser == null)
                {
                    CreateUser();
                }
                else
                {
                    UpdateUser();
                }

                this.Close();
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
            editUser.Username = TxtUsername.Text;
            editUser.Active = ChkActive.Checked;
            editUser.IsAdmin = ChkIsAdmin.Checked;

            if (TxtPassword.Text.Length > 6)
            {
                editUser.Password = TxtPassword.Text;
            }

            DataContainer.Update(editUser);
        }
    }
}