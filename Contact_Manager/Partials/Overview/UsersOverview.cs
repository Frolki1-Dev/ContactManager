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
    public partial class UsersOverview : Form
    {
        private BindingSource _source;

        public UsersOverview()
        {
            InitializeComponent();
        }

        private void UpdateSource()
        {
            if (_source == null)
            {
                _source = new BindingSource();
                Collections.Users users = DataContainer.GetUserCollection();
                _source.DataSource = users;
                DataViewUsers.DataSource = _source;
            }
            else
            {
                Collections.Users users = DataContainer.GetUserCollection();
                _source.DataSource = users;
                DataViewUsers.Update();
                DataViewUsers.Refresh();
            }

        }

        private void DataViewUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;

            User res = (User)_source[row];

            // Open dialog
            UserDialog dialog = new UserDialog(res);
            // Listen on close
            dialog.FormClosing += DialogClosing;
            dialog.Show();
        }

        private void DataViewUsers_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Delete)
            {
                // No delete action
                return;
            }

            // Find the selected cell or row
            int rowId = 0;

            if (DataViewUsers.SelectedRows.Count == 1)
            {
                rowId = DataViewUsers.SelectedRows[0].Index;
            }

            if (rowId == 0 && DataViewUsers.SelectedCells.Count == 1)
            {
                rowId = DataViewUsers.SelectedCells[0].RowIndex;
            }

            // Check now if we have an row
            if (rowId == 0)
            {
                MessageBox.Show("Row konnte nicht gefunden werden. Bitte erneut versuchen.", "Kein Auswahl",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get user
            User user = (User)_source[rowId];

            // Check if the user is already deleted
            if (user.Deleted)
            {
                MessageBox.Show("Benutzer schon gelöscht.", "Bereits gelöscht", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            DialogResult dialogResult = MessageBox.Show(
                "Möchtest du wirklich den Benutzer " + user.Username + " löschen?", "Bestätigung Löschvorgang",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                // Delete the user
                DataContainer.Delete(user);
                UpdateSource();
            }
        }

        public void DialogClosing(object sender, FormClosingEventArgs e)
        {
            UpdateSource();
        }

        private void UsersOverview_Load(object sender, EventArgs e)
        {
            UpdateSource();
        }
    }
}
