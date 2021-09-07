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
    public partial class Employees : Form, IDataSourceForm
    {
        private BindingSource _bindingSource;

        public Employees()
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
                GridViewEmployee.DataSource = _bindingSource;
            }

            if (TxtSearch.Text.Length > 0)
            {
                // Search
                var employees = from Employee employee in DataContainer.GetEmployeeCollection()
                    where employee.FirstName.Contains(TxtSearch.Text) || employee.LastName.Contains(TxtSearch.Text) ||
                          employee.Role.Contains(TxtSearch.Text) || employee.Departement.Contains(TxtSearch.Text) ||
                          employee.Ahv.Contains(TxtSearch.Text) || employee.Address.Contains(TxtSearch.Text) ||
                          employee.Mobile.Contains(TxtSearch.Text) || employee.PhonePrivate.Contains(TxtSearch.Text) ||
                          employee.PhoneCompany.Contains(TxtSearch.Text) || employee.Fax.Contains(TxtSearch.Text) ||
                          employee.Email.Contains(TxtSearch.Text) ||
                          employee.ZipCode.ToString().Contains(TxtSearch.Text)
                    orderby employee.Id
                    select new
                    {
                        ID = employee.Id,
                        Vorname = employee.FirstName,
                        Nachname = employee.LastName,
                        Abteilung = employee.Departement,
                        Position = employee.Role
                    };

                if (!employees.Any())
                {
                    employees = null;
                }

                _bindingSource.DataSource = employees;
            }
            else
            {
                // Output all active objects
                var employees = from Employee employee in DataContainer.GetEmployeeCollection()
                    orderby employee.Id
                    select new
                    {
                        ID = employee.Id,
                        Vorname = employee.FirstName,
                        Nachname = employee.LastName,
                        Abteilung = employee.Departement,
                        Position = employee.Role
                    };

                if (!employees.Any())
                {
                    employees = null;
                }

                _bindingSource.DataSource = employees;
            }

            GridViewEmployee.Update();
        }

        /**
         * Get the selected row from the data grid view
         */
        public int GetSelectedRow()
        {
            // Check now the cell
            if (GridViewEmployee.SelectedCells.Count == 1)
            {
                return (int) GridViewEmployee.Rows[GridViewEmployee.SelectedCells[0].RowIndex].Cells[0].Value;
            }

            // Return -1
            return -1;
        }

        private void Employees_Load(object sender, EventArgs e)
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
            EmployeeDialog dialog = new EmployeeDialog();
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
        private void GridViewEmployee_Paint(object sender, PaintEventArgs e)
        {
            if (GridViewEmployee.Rows.Count == 0)
            {
                using (var gfx = e.Graphics)
                {
                    gfx.DrawString("Keine Daten vorhanden", Font, Brushes.White,
                        new PointF((GridViewEmployee.Width - Font.Size * "Keine Daten vorhanden".Length) / 2,
                            GridViewEmployee.Height / 2));
                }
            }
        }

        /**
         * Check if the delete key is pressed. WHEN TRUE THEN it should delete the resource
         */
        private void GridViewEmployee_KeyDown(object sender, KeyEventArgs e)
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

            Employee employee = DataContainer.GetEmployeeCollection().GetById(row);

            if (employee.Deleted)
            {
                return;
            }

            DialogResult result = MessageBox.Show(
                "Möchtest du wirklich den Mitarbeiter " + employee.FirstName + " " + employee.LastName + " löschen?",
                "Bestätigung Löschvorgang",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Check if the user sad yes
            if (result == DialogResult.Yes)
            {
                // Delete the user
                DataContainer.Delete(employee);
                MessageBox.Show(
                    "Mitarbeiter " + employee.FirstName + " " + employee.LastName + " wurde erfolreich gelöscht.",
                    "Gelöscht",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateSource();
            }
        }

        /**
         * Trigger the edit mode in the dialog
         */
        private void GridViewEmployee_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = GetSelectedRow();

            if (row < 0)
            {
                MessageBox.Show("Row konnte nicht gefunden werden. Bitte erneut auswählen.", "Kein Auswahl",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Employee employee = DataContainer.GetEmployeeCollection().GetById(row);

            if (employee.Deleted)
            {
                return;
            }

            EmployeeDialog dialog = new EmployeeDialog(employee);
            dialog.FormClosing += (o, args) => { UpdateSource(); };
            dialog.Show();
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
            CsvFileImport.StartImport(DataContainer.Employees, txtFile.Text);
            UpdateSource();
        }
    }
}