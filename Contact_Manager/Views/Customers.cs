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
    public partial class Customers : Form, IDataSourceForm
    {
        private BindingSource _bindingSource;

        public Customers()
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
                GridViewCustomers.DataSource = _bindingSource;
            }

            if (TxtSearch.Text.Length > 0)
            {
                // Search
                var customers = from Customer customer in DataContainer.GetCustomerCollection()
                    where customer.CompanyName.Contains(TxtSearch.Text) ||
                          customer.FirstName.Contains(TxtSearch.Text) || customer.LastName.Contains(TxtSearch.Text) ||
                          customer.City.Contains(TxtSearch.Text) || customer.Address.Contains(TxtSearch.Text) ||
                          customer.Email.Contains(TxtSearch.Text) || customer.PhonePrivate.Contains(TxtSearch.Text) ||
                          customer.PhoneCompany.Contains(TxtSearch.Text) || customer.Mobile.Contains(TxtSearch.Text) ||
                          customer.Fax.Contains(TxtSearch.Text) ||
                          customer.ZipCode.ToString().Contains(TxtSearch.Text)
                    orderby customer.Id
                    select new
                    {
                        ID = customer.Id,
                        Firma = customer.CompanyName,
                        Strasse = customer.Address,
                        PLZ = customer.ZipCode,
                        Ort = customer.City,
                        Vorname = customer.FirstName,
                        Nachname = customer.LastName,
                    };

                if (!customers.Any())
                {
                    customers = null;
                }

                _bindingSource.DataSource = customers;
            }
            else
            {
                // Output all active objects
                var customers = from Customer customer in DataContainer.GetCustomerCollection()
                    orderby customer.Id
                    select new
                    {
                        ID = customer.Id,
                        Firma = customer.CompanyName,
                        Strasse = customer.Address,
                        PLZ = customer.ZipCode,
                        Ort = customer.City,
                        Vorname = customer.FirstName,
                        Nachname = customer.LastName,
                    };

                if (!customers.Any())
                {
                    customers = null;
                }

                _bindingSource.DataSource = customers;
            }

            GridViewCustomers.Update();
        }

        /**
         * Get the selected row from the data grid view
         */
        public int GetSelectedRow()
        {
            // Check now the cell
            if (GridViewCustomers.SelectedCells.Count == 1)
            {
                return (int) GridViewCustomers.Rows[GridViewCustomers.SelectedCells[0].RowIndex].Cells[0].Value;
            }

            // Return -1
            return -1;
        }

        private void Customers_Load(object sender, EventArgs e)
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
            CustomerDialog dialog = new CustomerDialog();
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
         * If no objects are in the DataContainer THEN it will show an information
         */
        private void GridViewCustomers_Paint(object sender, PaintEventArgs e)
        {
            if (GridViewCustomers.Rows.Count == 0)
            {
                using (var gfx = e.Graphics)
                {
                    gfx.DrawString("Keine Daten vorhanden", Font, Brushes.White,
                        new PointF((GridViewCustomers.Width - Font.Size * "Keine Daten vorhanden".Length) / 2,
                            GridViewCustomers.Height / 2));
                }
            }
        }

        /**
         * Trigger the edit mode in the dialog
         */
        private void GridViewCustomers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = GetSelectedRow();

            if (row < 0)
            {
                MessageBox.Show("Row konnte nicht gefunden werden. Bitte erneut auswählen.", "Kein Auswahl",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Customer customer = DataContainer.GetCustomerCollection().GetById(row);

            if (customer.Deleted)
            {
                return;
            }

            CustomerDialog dialog = new CustomerDialog(customer);
            dialog.FormClosing += (o, args) => { UpdateSource(); };
            dialog.Show();
        }

        /**
         * Check if the delete key is pressed. WHEN TRUE THEN it should delete the resource
         */
        private void GridViewCustomers_KeyDown(object sender, KeyEventArgs e)
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

            Customer customer = DataContainer.GetCustomerCollection().GetById(row);

            if (customer.Deleted)
            {
                return;
            }

            DialogResult result = MessageBox.Show(
                "Möchtest du wirklich den Kunden " + customer.CompanyName + " löschen?", "Bestätigung Löschvorgang",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Check if the user sad yes
            if (result == DialogResult.Yes)
            {
                // Delete the user
                DataContainer.Delete(customer);
                MessageBox.Show("Kunde " + customer.CompanyName + " wurde erfolreich gelöscht.", "Gelöscht",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateSource();
            }
        }

        /**
         * Start the csv import
         */
        private void cmdImportCsv_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialogCsv = new OpenFileDialog();
            openFileDialogCsv.ShowDialog();
            openFileDialogCsv.InitialDirectory = @"C:\";
            openFileDialogCsv.RestoreDirectory = true;
            openFileDialogCsv.Title = "CSV Dateien durchsuchen";
            openFileDialogCsv.DefaultExt = "csv";
            openFileDialogCsv.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";

            txtFile.Text = openFileDialogCsv.FileName;
            CsvFileImport.StartImport(DataContainer.Customers, txtFile.Text);
            UpdateSource();
        }
    }
}