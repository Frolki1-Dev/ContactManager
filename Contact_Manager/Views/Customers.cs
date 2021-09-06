using System;
using System.Collections.Generic;
using System.Data;
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
                          customer.FirstName.Contains(TxtSearch.Text) || customer.LastName.Contains(TxtSearch.Text)
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
                var customers = from Customer customer in DataContainer.GetCustomerCollection()
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

        private void CmdCreate_Click(object sender, EventArgs e)
        {
            CustomerDialog dialog = new CustomerDialog();
            dialog.FormClosing += (o, args) => { UpdateSource(); };
            dialog.Show();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            UpdateSource();
        }

        private void GridViewCustomers_Paint(object sender, PaintEventArgs e)
        {
            if (GridViewCustomers.Rows.Count == 0)
            {
                using (var gfx = e.Graphics)
                {
                    gfx.DrawString("Keine Daten vorhanden", this.Font, Brushes.White,
                        new PointF((GridViewCustomers.Width - this.Font.Size * "Keine Daten vorhanden".Length) / 2,
                            GridViewCustomers.Height / 2));
                }
            }
        }

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

        private void cmdImportCsv_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialogCSV = new OpenFileDialog();
            openFileDialogCSV.ShowDialog();
            openFileDialogCSV.InitialDirectory = @"C:\";
            openFileDialogCSV.RestoreDirectory = true;
            openFileDialogCSV.Title = "CSV Dateien durchsuchen";
            openFileDialogCSV.DefaultExt = "csv";
            openFileDialogCSV.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";

            txtFile.Text = openFileDialogCSV.FileName;
            BindData(txtFile.Text);
        }

        private void BindData(string filePath)
        {
            DataTable dt = new DataTable();
            string[] lines = System.IO.File.ReadAllLines(filePath);
            if (lines.Length > 0)
            {
                //first line to create header
                string firstLine = lines[0];
                string[] headerLabels = firstLine.Split(',');
                foreach (string headerWord in headerLabels)
                {
                    dt.Columns.Add(new DataColumn(headerWord));
                }

                //For Data
                for (int i = 1; i < lines.Length; i++)
                {
                    string[] dataWords = lines[i].Split(',');
                    DataRow dr = dt.NewRow();
                    int columnIndex = 0;
                    foreach (string headerWord in headerLabels)
                    {
                        dr[headerWord] = dataWords[columnIndex++];
                    }

                    dt.Rows.Add(dr);
                }
            }

            foreach (DataRow row in dt.Rows)
            {
                dynamic dateofbirth = null;

                //if (row[3].ToString().Length > 0)
                //{
                //    dateofbirth = DateTime.ParseExact(row[3].ToString(), "dd.MM.yyyy", null);
                //}

                Customer customer = new Customer(
                    row[0].ToString(),
                    row[1].ToString(),
                    row[2].ToString(),
                    DateTime.Now,
                    Convert.ToInt32(row[4]),
                    row[5].ToString(),
                    row[6].ToString(),
                    false,
                    row[7].ToString(),
                    Convert.ToInt32(row[9]),
                    row[8].ToString(),
                    row[9].ToString(),
                    row[10].ToString(),
                    row[11].ToString(),
                    row[12].ToString(),
                    row[13].ToString(),
                    row[16].ToString(),
                    row[17].ToString(),
                    new List<CustomerNotes>()
                );
                DataContainer.AddModel(DataContainer.Customers, customer);

                UpdateSource();
            }
        }
    }
}