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
                var trainees = from Trainee employee in DataContainer.GetTraineeCollection()
                    where employee.FirstName.Contains(TxtSearch.Text) || employee.LastName.Contains(TxtSearch.Text) || employee.Role.Contains(TxtSearch.Text)
                    select new
                    {
                        ID = employee.Id
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
            throw new NotImplementedException();
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
                        new PointF((this.Width - this.Font.Size * "Keine Daten vorhanden".Length) / 2, this.Height / 2));
                }
            }
        }
    }
}
