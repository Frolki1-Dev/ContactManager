﻿using System;
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
using Contact_Manager;


namespace Contact_Manager.Views
{
    public partial class Trainees : Form, IDataSourceForm
    {
        private BindingSource _bindingSource;
        public Trainees()
        {
            InitializeComponent();
        }

        private void Trainees_Load(object sender, EventArgs e)
        {
            MainTheme.InitThemeForForm(this);
            PnlHeader.BackColor = Properties.Settings.Default.SecondaryColor;
            UpdateSource();
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
                GridViewTrainees.DataSource = _bindingSource;
            }

            if (TxtSearch.Text.Length > 0)
            {
                // Search
                var trainees = from Trainee trainee in DataContainer.GetTraineeCollection()
                    where trainee.FirstName.Contains(TxtSearch.Text) || trainee.LastName.Contains(TxtSearch.Text) || trainee.Role.Contains(TxtSearch.Text)
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
                var trainees = from Trainee trainee in DataContainer.GetTraineeCollection()
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

        public int GetSelectedRow()
        {
            // Check now the cell
            if (GridViewTrainees.SelectedCells.Count == 1)
            {
                return (int)GridViewTrainees.Rows[GridViewTrainees.SelectedCells[0].RowIndex].Cells[0].Value;
            }

            // Return -1
            return -1;
        }

        private void CmdCreate_Click(object sender, EventArgs e)
        {
            TraineeDialog dialog = new TraineeDialog();
            dialog.FormClosing += (o, args) =>
            {
                UpdateSource();
            };
            dialog.Show();
        }

        private void GridViewTrainees_Paint(object sender, PaintEventArgs e)
        {
            if (GridViewTrainees.Rows.Count == 0)
            {
                using (var gfx = e.Graphics)
                {
                    gfx.DrawString("Keine Daten vorhanden", this.Font, Brushes.White,
                        new PointF((GridViewTrainees.Width - this.Font.Size * "Keine Daten vorhanden".Length) / 2, GridViewTrainees.Height / 2));
                }
            }
        }

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
            dialog.FormClosing += (o, args) =>
            {
                UpdateSource();
            };
            dialog.Show();
        }

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
                "Möchtest du wirklich den Lehrling " + trainee.FirstName + " " + trainee.LastName + " löschen?", "Bestätigung Löschvorgang",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Check if the user sad yes
            if (result == DialogResult.Yes)
            {
                // Delete the user
                DataContainer.Delete(trainee);
                MessageBox.Show("Lehrling " + trainee.FirstName + " " + trainee.LastName + " wurde erfolreich gelöscht.", "Gelöscht",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateSource();
            }
        }

        private void cmdImportCsvTrainee_Click(object sender, EventArgs e)
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
                GridViewTrainees.DataSource = dt;
            }

            foreach(DataRow row in dt.Rows)
            {
                Trainees trainee = new Trainees();
                DataContainer.AddModel(DataContainer.Trainees, trainee);
            }
            
        }
    }
}
