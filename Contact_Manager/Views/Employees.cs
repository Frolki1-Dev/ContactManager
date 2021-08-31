using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void Employees_Load(object sender, EventArgs e)
        {
            MainTheme.InitThemeForForm(this);
            PnlHeader.BackColor = Properties.Settings.Default.SecondaryColor;
            UpdateSource();
        }

        private void CmdCreate_Click(object sender, EventArgs e)
        {
            EmployeeDialog dialog = new EmployeeDialog();
            dialog.FormClosing += (o, args) =>
            {
                UpdateSource();
            };
            dialog.Show();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            UpdateSource();
        }

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
                    where employee.FirstName.Contains(TxtSearch.Text) || employee.LastName.Contains(TxtSearch.Text) || employee.Role.Contains(TxtSearch.Text)
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
                var employees = from Employee employee in DataContainer.GetEmployeeCollection()
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

        public int GetSelectedRow()
        {
            // Check now the cell
            if (GridViewEmployee.SelectedCells.Count == 1)
            {
                return (int)GridViewEmployee.Rows[GridViewEmployee.SelectedCells[0].RowIndex].Cells[0].Value;
            }

            // Return -1
            return -1;
        }

        private void GridViewEmployee_Paint(object sender, PaintEventArgs e)
        {
            if (GridViewEmployee.Rows.Count == 0)
            {
                using (var gfx = e.Graphics)
                {
                    gfx.DrawString("Keine Daten vorhanden", this.Font, Brushes.White,
                        new PointF((GridViewEmployee.Width - this.Font.Size * "Keine Daten vorhanden".Length) / 2, GridViewEmployee.Height / 2));
                }
            }
        }

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
                "Möchtest du wirklich den Mitarbeiter " + employee.FirstName + " " + employee.LastName + " löschen?", "Bestätigung Löschvorgang",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Check if the user sad yes
            if (result == DialogResult.Yes)
            {
                // Delete the user
                DataContainer.Delete(employee);
                MessageBox.Show("Mitarbeiter " + employee.FirstName + " " + employee.LastName + " wurde erfolreich gelöscht.", "Gelöscht",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateSource();
            }
        }

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
            dialog.FormClosing += (o, args) =>
            {
                UpdateSource();
            };
            dialog.Show();
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
            if (dt.Rows.Count > 0)
            {
                GridViewEmployee.DataSource = dt;
            }

            foreach (DataRow row in dt.Rows)
            {
                dynamic exitDate = null;

                if(row[20].ToString().Length > 0)
                {
                    exitDate = DateTime.ParseExact(row[20].ToString(), "dd.MM.yyyy", null);
                }

                Employee employee = new Employee(
                    salutation: row[0].ToString(),
                    title: row[1].ToString(),
                    firstName: row[3].ToString(),
                    lastName: row[4].ToString(),
                    gender: Convert.ToInt32(row[2]),
                    phonePrivate: row[5].ToString(),
                    phoneCompany: row[6].ToString(),
                    mobile: row[7].ToString(),
                    ahv: row[8].ToString(),
                    dateOfBirth: DateTime.Now,
                    address: row[10].ToString(),
                    zipCode: Convert.ToInt32(row[11]),
                    city: row[12].ToString(),
                    nationality: row[13].ToString(),
                    departement: row[14].ToString(),
                    fax: row[15].ToString(),
                    email: row[16].ToString(),
                    loe: Convert.ToInt32(row[17]),
                    role: row[18].ToString(),
                    entryDate: DateTime.Now,
                    exitDate: exitDate,
                    managementLevel: Convert.ToInt32(row[21]),
                    country: "None",
                    status: Convert.ToBoolean(exitDate != null)
                    );
                DataContainer.AddModel(DataContainer.Employees, employee);
            }
        }

    }
}

