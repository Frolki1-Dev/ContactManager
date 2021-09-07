using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Contact_Manager.Models;
using Contact_Manager.Themes;

namespace Contact_Manager.Partials.Dialog
{
    public partial class CustomerDialog : Form
    {
        private Customer _currentCustomer;
        private string _defaultCountry;
        private bool _noteInEditMode = false;
        private int _rowIndex = 0;
        private int _selectedGender;

        private BindingSource _source;
        private int _zipCodeFormatted;


        public CustomerDialog()

        {
            //open the customerdialog without the note fields
            InitializeComponent();
            DefaultValueCombobox();
            Width = 478;
            GrpBoxNotes.Visible = false;
        }

        public CustomerDialog(Customer customer)
        {
            //open an already created customer
            InitializeComponent();
            DefaultValueCombobox();
            _currentCustomer = customer;
            btnCompanyDelete.Visible = false;


            /* *****************************************************
             * check which gender is set and convert to gui element
             * male = 1 / female = 2 / other = 3
            ***************************************************** */
            switch (customer.Gender)
            {
                case 1 when customer.Gender == 1:
                    rbMale.Checked = true;
                    break;
                case 2 when customer.Gender == 2:
                    rbFemale.Checked = true;
                    break;
                case 3 when customer.Gender == 3:
                    rbOther.Checked = true;
                    break;
            }


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
            CmbCustomerType.Text = _currentCustomer.CustomerType;
            ChkStatus.Checked = _currentCustomer.Status;
            CmbTitle.Text = _currentCustomer.Title;
            CmbSalutation.Text = _currentCustomer.Salutation;
            customer.Gender = _currentCustomer.Gender;
            CmbNationality.Text = _currentCustomer.Country;
            DtpDateOfBirth.Value = _currentCustomer.DateOfBirth;

            // Build a new source
            UpdateNotesView();
        }

        public void DefaultValueCombobox()
        {
            /* *****************************
             * Set salutations
            ***************************** */
            foreach (string salutation in StaticData.Salutations)
            {
                CmbSalutation.Items.Add(salutation);
            }

            /* *****************************
             * Set titles
            ***************************** */
            foreach (string title in StaticData.Titles)
            {
                CmbTitle.Items.Add(title);
            }

            /* *****************************
             * Set country list
            ***************************** */
            foreach (string country in StaticData.Countries)
            {
                CmbNationality.Items.Add(country);
            }
        }


        public void ContactHistory()
        {
            try
            {
                Validation.Required(txtAddNote, "Notizfeld muss ausgefüllt werden!");
                CustomerNotes customerNotes = new CustomerNotes(txtAddNote.Text);
                _currentCustomer.Notes.Insert(0, customerNotes);
                DataContainer.Update(_currentCustomer);
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

        public void CheckFieldInput()
        {
            /* *****************************
               * declare vars
              ***************************** */


            _defaultCountry = "Sitzerland";


            /* *****************************
             * formatting stuff
            ***************************** */
            _zipCodeFormatted = Convert.ToInt32(txtZipCode.Text);

            /* *****************************
             * compare date of birth
            ***************************** */

            var checkedBirthOfDate = DateTime.Compare(DtpDateOfBirth.Value, DateTime.Today);


            /* *****************************************************
             * check which gender is selected and store in variable
             * male = 1 / female = 2 / other = 3
            ***************************************************** */

            if (rbMale.Checked)
                _selectedGender = 1;
            else if (rbFemale.Checked)
                _selectedGender = 2;
            else
                _selectedGender = 3;

            /* *****************************
            * check input for invalid data
           ***************************** */

            // check if required fields are filled out
            Validation.Required(txtFirstName.Text, "Feld Vorname muss ausgefüllt werden.");
            Validation.Required(txtSurName.Text, "Feld Nachname muss ausgefüllt werden.");
            Validation.Required(txtAddress.Text, "Feld Adresse muss ausgefüllt werden.");
            Validation.Required(txtCompany.Text, "Feld Unternehmen muss ausgefüllt werden.");
            Validation.Required(CmbCustomerType.Text, "Kundentyp muss definiert werden.");
            Validation.Required(CmbSalutation.Text, "Anrede muss ausgefüllt werden.");


            // check if email is correct
            Validation.Required(txtCompanyContactEmail.Text, "E-Mail muss ausgefüllt sein.");
            Validation.ValidateEmail(txtCompanyContactEmail.Text);

            // check if zip code is valid for switzerland
            Validation.Required(txtZipCode.Text, "Feld PLZ muss ausgefüllt werden.");
            Validation.ValidateZipCode(_zipCodeFormatted);

            // check phone / fax / mobile number lengths and if required
            if (txtPhonePrivate.Text.Length == 0)
            {
                Validation.Required(txtPhonePrivate.Text, "Telefon (Privat) muss ausgefüllt werden.");
            }
            else
                Validation.ValidatePhone(txtPhonePrivate.Text, "Die Privatnummer ist nicht gültig!");

            if (txtFax.Text.Length > 0)
            {
                Validation.ValidatePhone(txtFax.Text, "Die Faxnummer ist nicht gültig!");
            }

            if (txtPhoneCompany.Text.Length == 0)
            {
                Validation.Required(txtPhoneCompany.Text, "Telefon (Geschäftlich) muss ausgefüllt werden.");
            }
            else
                Validation.ValidatePhone(txtPhoneCompany.Text, "Die Geschäftsnummer ist nicht gültig!");


            if (txtMobile.Text.Length > 0)
            {
                Validation.ValidatePhone(txtMobile.Text, "Die Handynummer ist nicht gültig!");
            }
        }

        private void CreateCustomer()
        {
            try
            {
                CheckFieldInput();

                /* *****************************
                * create customer object
               ***************************** */


                Customer customer = new Customer(
                    salutation: CmbSalutation.Text,
                    firstName: txtFirstName.Text,
                    lastName: txtSurName.Text,
                    dateOfBirth: DtpDateOfBirth.Value,
                    gender: _selectedGender,
                    title: CmbTitle.Text,
                    email: txtCompanyContactEmail.Text,
                    status: ChkStatus.Checked,
                    address: txtAddress.Text,
                    zipCode: _zipCodeFormatted,
                    phonePrivate: txtPhonePrivate.Text,
                    phoneCompany: txtPhoneCompany.Text,
                    fax: txtFax.Text,
                    mobile: txtMobile.Text,
                    city: txtCity.Text,
                    country: _defaultCountry,
                    companyName: txtCompany.Text,
                    customerType: CmbCustomerType.Text,
                    notes: new List<CustomerNotes>()
                );

                DataContainer.AddModel(DataContainer.Customers, customer);

                Close();
            }
            catch (ValidationException ex)
            {
                MessageBox.Show(ex.Message, "Validierungsfehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateCustomer()
        {
            CheckFieldInput();
            try
            {
                //set updated fields
                _currentCustomer.CompanyName = txtCompany.Text;
                _currentCustomer.Address = txtAddress.Text;
                _currentCustomer.ZipCode = _zipCodeFormatted;
                _currentCustomer.City = txtCity.Text;
                _currentCustomer.FirstName = txtFirstName.Text;
                _currentCustomer.LastName = txtSurName.Text;
                _currentCustomer.PhonePrivate = txtPhonePrivate.Text;
                _currentCustomer.PhoneCompany = txtPhoneCompany.Text;
                _currentCustomer.Mobile = txtMobile.Text;
                _currentCustomer.Fax = txtFax.Text;
                _currentCustomer.Email = txtCompanyContactEmail.Text;
                _currentCustomer.CustomerType = CmbCustomerType.Text;
                _currentCustomer.Status = ChkStatus.Checked;
                _currentCustomer.Title = CmbTitle.Text;
                _currentCustomer.Salutation = CmbSalutation.Text;
                _currentCustomer.Gender = _selectedGender;
                _currentCustomer.Country = CmbNationality.Text;
                _currentCustomer.DateOfBirth = DtpDateOfBirth.Value;

                DataContainer.Update(_currentCustomer);
                MessageBox.Show("Änderungen gespeichert.");
                Close();
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
            try
            {
                if (_currentCustomer == null)
                    CreateCustomer();
                else
                    UpdateCustomer();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void BtnAddNote_Click(object sender, EventArgs e)
        {
            if (_noteInEditMode)
            {
                try
                {
                    // Edit
                    Validation.Required(txtAddNote, "Notizfeld muss ausgefüllt werden!");
                    _currentCustomer.Notes[_rowIndex].Notes = txtAddNote.Text;
                    DataContainer.Update(_currentCustomer);
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
                    gfx.DrawString("Keine Notizen vorhanden", Font, Brushes.White,
                        new PointF((GrpBoxNotes.Width - Font.Size * "Keine Notizen vorhanden".Length) / 2,
                            GrpBoxNotes.Height / 3));
                }
            }
        }

        private void dataGridNotes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //load the double clicked note 
            _rowIndex = e.RowIndex;
            txtAddNote.Text = _currentCustomer.Notes[_rowIndex].Notes;
            _noteInEditMode = true;
            BtnAddNote.Text = "Notiz speichern";
            GrpBoxNotes.Text = "Notiz (bearbeiten)";
        }

        private void UpdateNotesView()

            //after editing a note, update the note list and the grid

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