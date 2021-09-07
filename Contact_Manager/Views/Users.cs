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

        private void CmdCreate_Click(object sender, EventArgs e)
        {
            UserDialog dialog = new UserDialog();
            dialog.FormClosing += (o, args) => { UpdateSource(); };
            dialog.Show();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            UpdateSource();
        }

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

        private void GridViewUsers_Paint(object sender, PaintEventArgs e)
        {
            if (GridViewUsers.Rows.Count == 0)
            {
                using (var gfx = e.Graphics)
                {
                    gfx.DrawString("Keine Daten vorhanden", this.Font, Brushes.White,
                        new PointF((GridViewUsers.Width - this.Font.Size * "Keine Daten vorhanden".Length) / 2,
                            GridViewUsers.Height / 2));
                }
            }
        }

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