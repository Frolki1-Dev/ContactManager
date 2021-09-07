using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Contact_Manager.Interfaces;
using Contact_Manager.Models;
using Contact_Manager.Partials.Dialog;
using Contact_Manager.Themes;

namespace Contact_Manager.Views
{
    public partial class Users : Form, IDataSourceForm
    {
        private BindingSource _bindingSource;

        public Users()
        {
            InitializeComponent();
        }

        /**
         * Update the data grid view
         */
        public void UpdateSource()
        {
            if (_bindingSource == null)
            {
                _bindingSource = new BindingSource();
                GridViewUsers.DataSource = _bindingSource;
            }

            if (TxtSearch.Text.Length > 0)
            {
                // Search
                var users = from User usr in DataContainer.GetUserCollection()
                    where usr.Username.Contains(TxtSearch.Text)
                    orderby usr.Id
                    select new
                    {
                        ID = usr.Id,
                        Benutzername = usr.Username,
                        Admin = usr.IsAdmin,
                        Aktiv = usr.Active
                    };

                if (!users.Any())
                {
                    users = null;
                }

                _bindingSource.DataSource = users;
            }
            else
            {
                // Output all active objects
                var users = from User usr in DataContainer.GetUserCollection()
                    orderby usr.Id
                    select new
                    {
                        ID = usr.Id,
                        Benutzername = usr.Username,
                        Admin = usr.IsAdmin,
                        Aktiv = usr.Active
                    };

                if (!users.Any())
                {
                    users = null;
                }

                _bindingSource.DataSource = users;
            }

            GridViewUsers.Update();
        }

        /**
         * Get the selected row from the data grid view
         */
        public int GetSelectedRow()
        {
            // Check now the cell
            if (GridViewUsers.SelectedCells.Count == 1)
            {
                return (int) GridViewUsers.Rows[GridViewUsers.SelectedCells[0].RowIndex].Cells[0].Value;
            }

            // Return -1
            return -1;
        }

        private void Users_Load(object sender, EventArgs e)
        {
            MainTheme.InitThemeForForm(this);
            PnlHeader.BackColor = Properties.Settings.Default.SecondaryColor;
            UpdateSource();
        }

        /**
         * Open the create mode of the dialog
         */
        private void CmdCreate_Click(object sender, EventArgs e)
        {
            UserDialog dialog = new UserDialog();
            dialog.FormClosing += (o, args) => { UpdateSource(); };
            dialog.Show();
        }

        /**
         * If any changes are made in the search field THEN it should update the source
         */
        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            UpdateSource();
        }

        /**
         * Check if the delete key is pressed. WHEN TRUE THEN it should delete the resource
         */
        private void GridViewUsers_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Delete)
            {
                // No delete action
                return;
            }

            int row = GetSelectedRow();

            if (row < 0)
            {
                MessageBox.Show("Row konnte nicht gefunden werden. Bitte erneut auswählen.", "Kein Auswahl",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            User user = DataContainer.GetUserCollection().GetById(row);

            if (user.Deleted)
            {
                return;
            }

            if (user.Id == Authentication.Authentication.GetUser().Id)
            {
                MessageBox.Show("Du kannst dich nicht selbst löschen.", "Shame",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Möchtest du wirklich den Benutzer " + user.Username + " löschen?", "Bestätigung Löschvorgang",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Check if the user sad yes
            if (result == DialogResult.Yes)
            {
                // Delete the user
                DataContainer.Delete(user);
                MessageBox.Show("Benutzer " + user.Username + " wurde erfolreich gelöscht.", "Gelöscht",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateSource();
            }
        }

        /**
         * If no objects are in the DataContainer THEN it will show an information
         */
        private void GridViewUsers_Paint(object sender, PaintEventArgs e)
        {
            if (GridViewUsers.Rows.Count == 0)
            {
                using (var gfx = e.Graphics)
                {
                    gfx.DrawString("Keine Daten vorhanden", Font, Brushes.White,
                        new PointF((GridViewUsers.Width - Font.Size * "Keine Daten vorhanden".Length) / 2,
                            GridViewUsers.Height / 2));
                }
            }
        }

        /**
         * Trigger the edit mode in the dialog
         */
        private void GridViewUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = GetSelectedRow();

            if (row < 0)
            {
                MessageBox.Show("Row konnte nicht gefunden werden. Bitte erneut auswählen.", "Kein Auswahl",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            User user = DataContainer.GetUserCollection().GetById(row);

            if (user.Deleted)
            {
                return;
            }

            UserDialog dialog = new UserDialog(user);
            dialog.FormClosing += (o, args) => { UpdateSource(); };
            dialog.Show();
        }
    }
}