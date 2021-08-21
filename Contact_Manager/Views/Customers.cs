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
    public partial class Customers : Form, IDataSourceForm
    {
        private BindingSource _bindingSource;
        public Customers()
        {
            InitializeComponent();
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            MainTheme.InitThemeForForm(this);
            PnlHeader.BackColor = Properties.Settings.Default.SecondaryColor;
            UpdateSource();
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
                            where customer.CompanyName.Contains(TxtSearch.Text) || customer.FirstName.Contains(TxtSearch.Text) || customer.LastName.Contains(TxtSearch.Text)
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
            throw new NotImplementedException();
        }

        private void CmdCreate_Click(object sender, EventArgs e)
        {
            CustomerDialog dialog = new CustomerDialog();
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

        private void GridViewCustomers_Paint(object sender, PaintEventArgs e)
        {
            if (GridViewCustomers.Rows.Count == 0)
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
