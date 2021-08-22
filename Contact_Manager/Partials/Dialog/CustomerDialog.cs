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
        private Customer _currentCustomer;

        private BindingSource _source;
        private bool _noteInEditMode = false;
        private int _rowIndex = 0;

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
            CmbNationality.DataSource = CountryList();
            _currentCustomer = customer;
            btnCompanyDelete.Visible = false;
            

            //load the customer to edit 
            txtCompany.Text = _currentCustomer.CompanyName;
            txtAddress.Text = _currentCustomer.Address;
            txtZipCode.Text = _currentCustomer.ZipCode.ToString();
            txtCity.Text = _currentCustomer.City;
            txtFirstName.Text = _currentCustomer.FirstName;
            txtSurName.Text = _currentCustomer.LastName;
            txtPhonePrivate.Text = _currentCustomer.PhonePrivate;
            txtPhoneCompany.Text = _currentCustomer.PhoneCompany;
            txtMobile.Text = _currentCustomer.Mobile;
            txtFax.Text = _currentCustomer.Fax;
            txtCompanyContactEmail.Text = _currentCustomer.Email;

            // TODO: Missing Kundentyp, Aktiver Kunde, Anrede, Titel, Geschlecht, Nationalität, Geburtsdatum

            // Build a new source
            UpdateNotesView();
        }

       

        public static List<string> CountryList()
        {
            // Creating culture list
            List<string> cultureList = new List<string>();

            // getting the specific CultureInfo from CultureInfo class
            CultureInfo[] getCultureInfos = CultureInfo.GetCultures(CultureTypes.SpecificCultures);

            foreach (CultureInfo getCulture in getCultureInfos)
            {
                // creating the object of RegionInfo class
                RegionInfo getRegionInfo = new RegionInfo(getCulture.LCID);

                // adding each country name into the arraylist
                if (!(cultureList.Contains(getRegionInfo.EnglishName)))
                {
                    cultureList.Add(getRegionInfo.EnglishName);
                }
            }

            // sorting array
            cultureList.Sort();

            // returning country list
            return cultureList;
        }

        //creating contact list

        public void ContactHistory()
        {
            try
            {
                Validation.Required(txtAddNote, "Notizfeld muss ausgefüllt werden!");
                CustomerNotes customerNotes = new CustomerNotes(txtAddNote.Text);
                this._currentCustomer.Notes.Insert(0, customerNotes);
                DataContainer.Update(this._currentCustomer);
                txtAddNote.Text = "";
                UpdateNotesView();
            }
            catch (ValidationException ex)
            {
                MessageBox.Show(ex.Message, "Validierungsfehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CleanUpFields()
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

        private void CreateCustomer()
        {
            try
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
                Validation.Required(txtFirstName.Text, "Feld Vorname muss ausgefüllt werden.");
                Validation.Required(txtSurName.Text, "Feld Nachname muss ausgefüllt werden.");
                Validation.Required(txtAddress.Text, "Feld Adresse muss ausgefüllt werden.");
                Validation.Required(txtCompany.Text, "Feld Unternehmen muss ausgefüllt werden.");

                // check if email is correct
                Validation.ValidateEmail(txtCompanyContactEmail.Text);

                // check if zip code is valid for switzerland
                Validation.ValidateZipCode(zipCodeFormatted);

                // TODO: Kundentypen wie ?


                // check phone / fax number lengths
                Validation.ValidatePhone(txtPhonePrivate.Text, "Die Privatnummer ist nicht gültig!");
                if (txtFax.Text.Length > 0)
                {
                    Validation.ValidatePhone(txtFax.Text, "Die Faxnummer ist nicht gültig!");
                }

                Validation.ValidatePhone(txtPhoneCompany.Text, "Die Geschäftsnummer ist nicht gültig!");
                if (txtMobile.Text.Length > 0)
                {
                    Validation.ValidatePhone(txtMobile.Text, "Die Handynummer ist nicht gültig!");
                }

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
            catch (ValidationException ex)
            {
                MessageBox.Show(ex.Message, "Validierungsfehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCompanySave_Click(object sender, EventArgs e)
        {
            /* *********************************
             * call function to create employee
            ********************************* */
            CreateCustomer();
            MessageBox.Show("Kunde wurde erfolgreich erstellt.", "Erfolgreich", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void BtnAddNote_Click(object sender, EventArgs e)
        {
            if(this._noteInEditMode)
            {
                try
                {
                    // Edit
                    Validation.Required(txtAddNote, "Notizfeld muss ausgefüllt werden!");
                    this._currentCustomer.Notes[_rowIndex].Notes = txtAddNote.Text;
                    DataContainer.Update(this._currentCustomer);
                    _rowIndex = 0;
                    _noteInEditMode = false;
                    txtAddNote.Text = "";
                    BtnAddNote.Text = "Notiz hinzufügen";
                    GrpBoxNotes.Text = "Notiz (erstellen)";
                    UpdateNotesView();
                }
                catch (ValidationException ex)
                {
                    MessageBox.Show(ex.Message, "Validierungsfehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return;
            }

            // Create
            ContactHistory();
        }

        private void btnCompanyDelete_Click(object sender, EventArgs e)
        {
            CleanUpFields();
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
            _rowIndex = e.RowIndex;
            txtAddNote.Text = this._currentCustomer.Notes[_rowIndex].Notes;
            this._noteInEditMode = true;
            BtnAddNote.Text = "Notiz speichern";
            GrpBoxNotes.Text = "Notiz (bearbeiten)";
        }

        private void UpdateNotesView()
        {
            if (_source == null)
            {
                _source = new BindingSource();
                dataGridNotes.DataSource = _source;
            }

            var notes = from CustomerNotes n in _currentCustomer.Notes
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
