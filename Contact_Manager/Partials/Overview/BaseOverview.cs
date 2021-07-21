using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Contact_Manager.Collections;

namespace Contact_Manager.Partials.Overview
{
    public abstract partial class FrmOverview : Form
    {
        protected BindingSource source;

        protected FrmOverview()
        {
            InitializeComponent();
        }

        protected void UpdateSource()
        {
            if (source == null)
            {
                // Build a new source
                source = new BindingSource();
                dynamic collection = GetCollectionList();
                source.DataSource = collection;
                DataView.DataSource = source;
            }
            else
            {
                // Only update the binding
                DataView.Update();
                DataView.Refresh();
            }
        }

        private void DataView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            OpenEditDialog(row);
        }


        private void DataView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Delete)
            {
                // No delete action
                return;
            }

            int rowId = GetSelectedRow();

            // Has any selected row?
            if (rowId == 0)
            {
                MessageBox.Show("Row konnte nicht gefunden werden. Bitte erneut auswählen.", "Kein Auswahl",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            dynamic obj = GetObjectFromIndex(rowId);

            // Check if the object is deleted
            if (obj.Deleted)
            {
                MessageBox.Show("Objekt wurde schon gelöscht.", "Gelöscht", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Ask the user if he is sure to do that
            DialogResult dialogResult = AskForConfirmation(obj);

            // Check if the user sad yes
            if (dialogResult == DialogResult.Yes)
            {
                // Delete the user
                DataContainer.Delete(obj);
                UpdateSource();
            }
        }

        protected int GetSelectedRow()
        {
            // Check first the row
            if (DataView.SelectedRows.Count == 1)
            {
                return DataView.SelectedRows[0].Index;
            }

            // Check now the cell
            if (DataView.SelectedCells.Count == 1)
            {
                return DataView.SelectedCells[0].RowIndex;
            }

            // Return 0
            return 0;
        }

        public void DialogClosing(object sender, FormClosingEventArgs e)
        {
            UpdateSource();
        }

        private void FrmOverview_Load(object sender, EventArgs e)
        {
            //UpdateSource();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            UpdateSource();
        }

        protected abstract dynamic GetCollectionList();
        protected abstract void OpenEditDialog(int row);
        protected abstract dynamic GetObjectFromIndex(int row);
        protected abstract DialogResult AskForConfirmation(dynamic obj);
    }
}
