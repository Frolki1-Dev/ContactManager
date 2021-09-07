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
    public partial class Trainees : Form, IDataSourceForm
    {
        private BindingSource _bindingSource;

        public Trainees()
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
                GridViewTrainees.DataSource = _bindingSource;
            }

            if (TxtSearch.Text.Length > 0)
            {
                // Search
                var trainees = from Trainee trainee in DataContainer.GetTraineeCollection()
                    where trainee.FirstName.Contains(TxtSearch.Text) || trainee.LastName.Contains(TxtSearch.Text) ||
                          trainee.Role.Contains(TxtSearch.Text) || trainee.Departement.Contains(TxtSearch.Text) ||
                          trainee.Ahv.Contains(TxtSearch.Text) || trainee.Address.Contains(TxtSearch.Text) ||
                          trainee.Mobile.Contains(TxtSearch.Text) || trainee.PhonePrivate.Contains(TxtSearch.Text) ||
                          trainee.PhoneCompany.Contains(TxtSearch.Text) || trainee.Fax.Contains(TxtSearch.Text) ||
                          trainee.Email.Contains(TxtSearch.Text) ||
                          trainee.ZipCode.ToString().Contains(TxtSearch.Text)
                    orderby trainee.Id
                    select new
                    {
                        ID = trainee.Id,
                        Vorname = trainee.FirstName,
                        Nachname = trainee.LastName,
                        Abteilung = trainee.Departement,
                        Position = trainee.Role,
                        Lehrjahr = trainee.CurrentTraineeYear
                    };

                if (!trainees.Any())
                {
                    trainees = null;
                }

                _bindingSource.DataSource = trainees;
            }
            else
            {
                // Output all active objects
                var trainees = from Trainee trainee in DataContainer.GetTraineeCollection()
                    orderby trainee.Id
                    select new
                    {
                        ID = trainee.Id,
                        Vorname = trainee.FirstName,
                        Nachname = trainee.LastName,
                        Abteilung = trainee.Departement,
                        Position = trainee.Role,
                        Lehrjahr = trainee.CurrentTraineeYear
                    };

                if (!trainees.Any())
                {
                    trainees = null;
                }

                _bindingSource.DataSource = trainees;
            }

            GridViewTrainees.Update();
        }

        /**
         * Get the selected row from the data grid view
         */
        public int GetSelectedRow()
        {
            // Check now the cell
            if (GridViewTrainees.SelectedCells.Count == 1)
            {
                return (int) GridViewTrainees.Rows[GridViewTrainees.SelectedCells[0].RowIndex].Cells[0].Value;
            }

            // Return -1
            return -1;
        }

        private void Trainees_Load(object sender, EventArgs e)
        {
            MainTheme.InitThemeForForm(this);
            PnlHeader.BackColor = Properties.Settings.Default.SecondaryColor;
            UpdateSource();
        }

        /**
         * If any changes are made in the search field THEN it should update the source
         */
        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            UpdateSource();
        }

        /**
         * Open the create mode of the dialog
         */
        private void CmdCreate_Click(object sender, EventArgs e)
        {
            TraineeDialog dialog = new TraineeDialog();
            dialog.FormClosing += (o, args) => { UpdateSource(); };
            dialog.Show();
        }

        /**
         * If no objects are in the DataContainer THEN it will show an information
         */
        private void GridViewTrainees_Paint(object sender, PaintEventArgs e)
        {
            if (GridViewTrainees.Rows.Count == 0)
            {
                using (var gfx = e.Graphics)
                {
                    gfx.DrawString("Keine Daten vorhanden", Font, Brushes.White,
                        new PointF((GridViewTrainees.Width - Font.Size * "Keine Daten vorhanden".Length) / 2,
                            GridViewTrainees.Height / 2));
                }
            }
        }

        /**
         * Trigger the edit mode in the dialog
         */
        private void GridViewTrainees_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = GetSelectedRow();

            if (row < 0)
            {
                MessageBox.Show("Row konnte nicht gefunden werden. Bitte erneut auswählen.", "Kein Auswahl",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Trainee trainee = DataContainer.GetTraineeCollection().GetById(row);

            if (trainee.Deleted)
            {
                return;
            }

            TraineeDialog dialog = new TraineeDialog(trainee);
            dialog.FormClosing += (o, args) => { UpdateSource(); };
            dialog.Show();
        }

        /**
         * Check if the delete key is pressed. WHEN TRUE THEN it should delete the resource
         */
        private void GridViewTrainees_KeyDown(object sender, KeyEventArgs e)
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

            Trainee trainee = DataContainer.GetTraineeCollection().GetById(row);

            if (trainee.Deleted)
            {
                return;
            }

            DialogResult result = MessageBox.Show(
                "Möchtest du wirklich den Lehrling " + trainee.FirstName + " " + trainee.LastName + " löschen?",
                "Bestätigung Löschvorgang",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Check if the user sad yes
            if (result == DialogResult.Yes)
            {
                // Delete the user
                DataContainer.Delete(trainee);
                MessageBox.Show(
                    "Lehrling " + trainee.FirstName + " " + trainee.LastName + " wurde erfolreich gelöscht.",
                    "Gelöscht",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateSource();
            }
        }

        /**
         * Start the csv import
         */
        private void cmdImportCsvTrainee_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialogCsv = new OpenFileDialog();
            openFileDialogCsv.ShowDialog();
            openFileDialogCsv.InitialDirectory = @"C:\";
            openFileDialogCsv.RestoreDirectory = true;
            openFileDialogCsv.Title = "CSV Dateien durchsuchen";
            openFileDialogCsv.DefaultExt = "csv";
            openFileDialogCsv.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";

            txtFile.Text = openFileDialogCsv.FileName;
            CsvFileImport.StartImport(DataContainer.Trainees, txtFile.Text);
            UpdateSource();
        }
    }
}