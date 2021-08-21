﻿using Contact_Manager.Collections;
using Contact_Manager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Contact_Manager.Themes;

namespace Contact_Manager.Partials.Dialog
{
    public partial class CustomerDialog : Form
    {
        private Customer currentCustomer;

        private BindingSource _source;
        private bool noteInEditMode = false;
        private int rowIndex = 0;

        public CustomerDialog()
        {
            InitializeComponent();
            Width = 478;
            CmbNationality.DataSource = CountryList();
            GrpBoxNotes.Visible = false;
        }

        public CustomerDialog(Customer customer)
        {
             
            InitializeComponent();
            currentCustomer = customer;
            GrpBoxNotes.Visible = true;

            //load the customer to edit 
            txtCompany.Text = currentCustomer.CompanyName;
            txtAddress.Text = currentCustomer.Address;
            txtZipCode.Text = currentCustomer.ZipCode.ToString();
            txtCity.Text = currentCustomer.City;
            txtFirstName.Text = currentCustomer.FirstName;
            txtSurName.Text = currentCustomer.LastName;
            txtPhonePrivate.Text = currentCustomer.PhonePrivate;
            txtPhoneCompany.Text = currentCustomer.PhoneCompany;
            txtMobile.Text = currentCustomer.Mobile;
            txtFax.Text = currentCustomer.Fax;
            txtCompanyContactEmail.Text = currentCustomer.Email;

            // TODO: Missing Kundentyp, Aktiver Kunde, Anrede, Titel, Geschlecht, Nationalität, Geburtsdatum

            // Build a new source
            updateNotesView();
        }

       

        public static List<string> CountryList()
        {
            // Creating culture list
            List<string> CultureList = new List<string>();

            // getting the specific CultureInfo from CultureInfo class
            CultureInfo[] getCultureInfos = CultureInfo.GetCultures(CultureTypes.SpecificCultures);

            foreach (CultureInfo getCulture in getCultureInfos)
            {
                // creating the object of RegionInfo class
                RegionInfo getRegionInfo = new RegionInfo(getCulture.LCID);

                // adding each country name into the arraylist
                if (!(CultureList.Contains(getRegionInfo.EnglishName)))
                {
                    CultureList.Add(getRegionInfo.EnglishName);
                }
            }

            // sorting array
            CultureList.Sort();

            // returning country list
            return CultureList;
        }

        //creating contact list

        public void ContactHistory()
        {
            CustomerNotes customerNotes = new CustomerNotes(txtAddNote.Text);
            this.currentCustomer.Notes.Add(customerNotes);
            DataContainer.Update(this.currentCustomer);
            txtAddNote.Text = "";
            updateNotesView();
        }

        private void generateErrorMessage(string errorMessage)
        {
           MessageBox.Show(errorMessage, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void cleanUpFields()
        {
            CmbSalutation.SelectedIndex = -1;
            txtFirstName.Clear();
            txtSurName.Clear();
            DtpDateOfBirth.Value = DateTime.Today;
            rbMale.Checked = false;
            rbFemale.Checked = false;
            rbOther.Checked = false;
            CmbTitle.SelectedIndex = -1;
            txtCompanyContactEmail.Clear();
            ChkStatus.Checked = true;
            txtAddress.Clear();
            txtZipCode.Clear();
            txtPhonePrivate.Clear();
            txtPhoneCompany.Clear();
            txtFax.Clear();
            txtMobile.Clear();
            txtCity.Clear();
            CmbNationality.SelectedIndex = -1;
            txtCompany.Clear();
            CmbCustomerType.SelectedIndex = -1;
        }

        private void createCustomer()
        {
            /* *****************************
            * declare vars
           ***************************** */

            int selectedGender;
            string defaultCountry = "Sitzerland";
            

            /* *****************************
             * formatting stuff
            ***************************** */
            int zipCodeFormatted = Convert.ToInt32(txtZipCode.Text);


            /* *****************************************************
             * check which gender is selected and store in variable
             * male = 1 / female = 2 / other = 3
            ***************************************************** */

            if (rbMale.Checked)
                selectedGender = 1;
            else if (rbFemale.Checked)
                selectedGender = 2;
            else
                selectedGender = 3;

            /* *****************************
            * check input for invalid data
           ***************************** */

            // check if required fields are filled out
            if (txtFirstName.Text.Length < 1 || txtSurName.Text.Length < 1 || txtAddress.Text.Length < 1 || txtCompany.Text.Length < 1)
                generateErrorMessage("Dieses Feld muss ausgefüllt werden.");

            // check if email is correct
            // source: https://stackoverflow.com/questions/5342375/regex-email-validation / https://docs.microsoft.com/en-us/dotnet/api/system.net.mail.mailaddress?redirectedfrom=MSDN&view=net-5.0
            try
            {
                MailAddress m = new MailAddress(txtCompanyContactEmail.Text);
            }
            catch (FormatException)
            {
                generateErrorMessage("Das Format der E-Mail Adresse ist ungültig.");
            }

            // check if zip code is valid for switzerland
            if (zipCodeFormatted < 1000 || zipCodeFormatted > 9999)
                generateErrorMessage("Die Postleitzahl ist zu klein / gross.");

            //Kundentypen wie ?



            // check phone / fax number lengths
            if (txtPhonePrivate.Text.Length < 1 || txtPhonePrivate.Text.Length > 12 || txtPhoneCompany.Text.Length < 1 ||
                txtPhoneCompany.Text.Length > 12 || txtMobile.Text.Length < 1 || txtMobile.Text.Length > 12 || txtFax.Text.Length < 1 ||
                txtFax.Text.Length > 12)
                generateErrorMessage("Bitte Telefon- / Fax-Nummer im folgenden Format angeben \"+41711234566\".");

            /* *****************************
            * create customer object
           ***************************** */


            Customer customer = new Customer(
                salutation: CmbSalutation.Text,
                firstName: txtFirstName.Text,
                lastName: txtSurName.Text,
                 dateOfBirth: DtpDateOfBirth.Value,
                gender: selectedGender,
                title: CmbTitle.Text,
                email: txtCompanyContactEmail.Text,
                status: ChkStatus.Checked,
                address: txtAddress.Text,
                zipCode: zipCodeFormatted,
                phonePrivate: txtPhonePrivate.Text,
                phoneCompany: txtPhoneCompany.Text,
                fax: txtFax.Text,
                mobile: txtMobile.Text,
                city: txtCity.Text,
                country: defaultCountry,
                companyName: txtCompany.Text,
                customerType: CmbCustomerType.Text,
                notes: new List<CustomerNotes>()
            );

            DataContainer.AddModel(DataContainer.Customers, customer);
        }

        private void btnCompanySave_Click(object sender, EventArgs e)
        {
            /* *********************************
             * call function to create employee
            ********************************* */
            createCustomer();
            MessageBox.Show("Kunde wurde erfolgreich erstellt.");
            cleanUpFields();
        }

        private void BtnAddNote_Click(object sender, EventArgs e)
        {
            if(this.noteInEditMode)
            {
                // Edit
                this.currentCustomer.Notes[rowIndex].Notes = txtAddNote.Text;
                DataContainer.Update(this.currentCustomer);
                rowIndex = 0;
                noteInEditMode = false;
                txtAddNote.Text = "";
                BtnAddNote.Text = "Notiz hinzufügen";
                GrpBoxNotes.Text = "Notiz (erstellen)";
                return;
            }

            // Create
            ContactHistory();
        }

        private void btnCompanyDelete_Click(object sender, EventArgs e)
        {
            cleanUpFields();
        }

        private void CustomerDialog_Load(object sender, EventArgs e)
        {
            MainTheme.InitThemeForForm(this);
        }

        private void dataGridNotes_Paint(object sender, PaintEventArgs e)
        {
            if (dataGridNotes.Rows.Count == 0)
            {
                using (var gfx = e.Graphics)
                {
                    gfx.DrawString("Keine Notizen vorhanden", this.Font, Brushes.White,
                        new PointF((GrpBoxNotes.Width - Font.Size * "Keine Notizen vorhanden".Length) / 2, GrpBoxNotes.Height / 3));
                }
            }
        }

        private void dataGridNotes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
            txtAddNote.Text = this.currentCustomer.Notes[rowIndex].Notes;
            this.noteInEditMode = true;
            BtnAddNote.Text = "Notiz speichern";
            GrpBoxNotes.Text = "Notiz (bearbeiten)";
        }

        private void updateNotesView()
        {
            if (_source == null)
            {
                _source = new BindingSource();
                dataGridNotes.DataSource = _source;
            }

            var notes = from CustomerNotes n in currentCustomer.Notes
                orderby n.CreatedAt descending 
                select new
                {
                    Notiz = n.Notes,
                    Angelegt = n.CreatedAt.ToString("dd.MM.yyyy HH:mm"),
                    Ersteller = n.CreatedFrom
                };

            if (!notes.Any())
            {
                notes = null;
            }

            _source.DataSource = notes;
            dataGridNotes.Update();
        }
    }
}
