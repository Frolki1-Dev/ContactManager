using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Contact_Manager.Models;
using Contact_Manager.Partials.Dialog;
using Contact_Manager.Themes;

namespace Contact_Manager.Views
{
    public partial class Users : Form
    {
        private BindingSource bindingSource;
        public Users()
        {
            InitializeComponent();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            MainTheme.InitThemeForForm(this);
            PnlHeader.BackColor = Properties.Settings.Default.SecondaryColor;
            updateSource();
        }

        private void CmdCreate_Click(object sender, EventArgs e)
        {
            UserDialog dialog = new UserDialog();
            dialog.FormClosing += (o, args) =>
            {
                updateSource();
            };
            dialog.Show();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            updateSource();
        }

        private void updateSource()
        {
            if (bindingSource == null)
            {
                bindingSource = new BindingSource();
                GridViewUsers.DataSource = bindingSource;
            }

            if (TxtSearch.Text.Length > 0)
            {
                // Search
                var users = from User usr in DataContainer.GetUserCollection()
                            where usr.Username.Contains(TxtSearch.Text)
                    select new
                    {
                        ID = usr.Id,
                        Benutzername = usr.Username,
                        Admin = usr.IsAdmin
                    };
                bindingSource.DataSource = users;
            }
            else
            {
                var users = from User usr in DataContainer.GetUserCollection()
                    select new
                    {
                        ID = usr.Id,
                        Benutzername = usr.Username,
                        Admin = usr.IsAdmin
                    };
                bindingSource.DataSource = users;
            }
            GridViewUsers.Update();
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
        }

        protected int GetSelectedRow()
        {
            // Check first the row
            if (GridViewUsers.SelectedRows.Count == 1)
            {
                return GridViewUsers.SelectedRows[0].Index;
            }

            // Check now the cell
            if (GridViewUsers.SelectedCells.Count == 1)
            {
                return GridViewUsers.SelectedCells[0].RowIndex;
            }

            // Return -1
            return -1;
        }
    }
}
