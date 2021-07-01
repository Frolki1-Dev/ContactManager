using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact_Manager
{
    public partial class FormAddCustomer : Form
    {
        public FormAddCustomer()
        {
            InitializeComponent();
        }

        private void btnCompanyDelete_Click(object sender, EventArgs e)
        {
            txtCompany.Text = "Firmenname";
            txtCompanyAdress.Text = "Adresse";
            txtCompanyZip.Text = "PLZ";
            txtCompanyCity.Text = "Ort";
            txtCompanyContactSurname.Text = "Nachname";
            txtCompanyContactName.Text = "Vorname";
            txtCompanyContactPhone.Text = "Telefon";
            txtCompanyContactEmail.Text = "Email";
        }
    }
}
