using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Contact_Manager.Models;
using Contact_Manager.Partials.Dialog;

namespace Contact_Manager.Partials.Overview
{
    public partial class UsersOverview : FrmOverview
    {
        public UsersOverview()
        {
            InitializeComponent();
        }

        protected override dynamic GetCollectionList()
        {
            return DataContainer.GetUserCollection();
        }

        protected override void OpenEditDialog(int row)
        {
            UserDialog dialog = new UserDialog(GetObjectFromIndex(row));
            dialog.FormClosing += DialogClosing;
            dialog.Show();


        }

        protected override dynamic GetObjectFromIndex(int row)
        {
            return (User) source[row];
        }

        protected override DialogResult AskForConfirmation(dynamic obj)
        {
            return MessageBox.Show(
                "Möchtest du wirklich den Benutzer " + obj.Username + " löschen?", "Bestätigung Löschvorgang",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}
