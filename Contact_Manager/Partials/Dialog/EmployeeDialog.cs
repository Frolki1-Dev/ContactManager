using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Contact_Manager.Models;
using Contact_Manager.Themes;

namespace Contact_Manager.Partials.Dialog
{
    public partial class EmployeeDialog : Form
    {
        private readonly Employee _editEmployee;
        private string _defaultCountry;
        private int _loeFormatted;
        private int _managementLevelFormatted;

        /* *****************************************************
        * declare global vars
        ***************************************************** */
        private int _selectedGender;
        private int _zipCodeFormatted;

        public EmployeeDialog()
        {
            InitializeComponent();

            // load defaults into comboboxes
            DefaultValueCombobox();
        }

        public EmployeeDialog(Employee employee)
        {
            InitializeComponent();

            // load defaults into comboboxes
            DefaultValueCombobox();

            btnSave.Text = "Änderungen speichern";

            // set flag for edit
            _editEmployee = employee;

            // set values from loaded employee
            CmbSalutation.Text = employee.Salutation;
            txtFirstName.Text = employee.FirstName;
            txtSurName.Text = employee.LastName;
            DtpDateOfBirth.Value = employee.DateOfBirth;

            /* *****************************************************
             * check which gender is set and convert to gui element
             * male = 1 / female = 2 / other = 3
            ***************************************************** */
            switch (employee.Gender)
            {
                case 1 when employee.Gender == 1:
                    rbMale.Checked = true;
                    break;
                case 2 when employee.Gender == 2:
                    rbFemale.Checked = true;
                    break;
                case 3 when employee.Gender == 3:
                    rbOther.Checked = true;
                    break;
            }

            CmbTitle.Text = employee.Title;
            txtEmail.Text = employee.Email;
            ChkStatus.Checked = employee.Status;
            txtAddress.Text = employee.Address;
            txtZipCode.Text = Convert.ToString(employee.ZipCode);
            txtPhonePrivate.Text = employee.PhonePrivate;
            txtPhoneCompany.Text = employee.PhoneCompany;
            txtFax.Text = employee.Fax;
            txtMobile.Text = employee.Mobile;
            txtCity.Text = employee.City;
            txtAhv.Text = employee.Ahv;
            txtDepartement.Text = employee.Departement;
            CmbNationality.Text = employee.Nationality;
            DtpEntryDate.Value = employee.EntryDate;
            DtpExitDate.Value = employee.ExitDate;
            CmbLoe.Text = Convert.ToString(employee.Loe);
            txtRole.Text = employee.Role;
            CmbManagementLevel.Text = Convert.ToString(employee.ManagementLevel);
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

            /* *****************************
             * Set loe
            ***************************** */
            foreach (string loe in StaticData.Loes)
            {
                CmbLoe.Items.Add(loe);
            }

            /* *****************************
             * Set ManagementLevel
            ***************************** */
            foreach (string level in StaticData.ManagementLevels)
            {
                CmbManagementLevel.Items.Add(level);
            }
        }

        private void EmployeeDialog_Load(object sender, EventArgs e)
        {
            MainTheme.InitThemeForForm(this);
        }

        private void ChkStatus_CheckedChanged(object sender, EventArgs e)
        {
            // Make it simple
            DtpExitDate.Enabled = !ChkStatus.Checked;
        }

        private void CheckFieldInput()
        {
            /* *****************************
             * define vars
            ***************************** */

            _defaultCountry = "Schweiz";

            /* *****************************
             * formatting stuff
            ***************************** */

            _zipCodeFormatted = Convert.ToInt32(txtZipCode.Text);
            _loeFormatted = Convert.ToInt32(CmbLoe.SelectedItem.ToString());
            _managementLevelFormatted = Convert.ToInt32(CmbManagementLevel.SelectedItem.ToString());

            /* *****************************
             * compare entry and exit date only if user is deactivated
            ***************************** */
            if (ChkStatus.Checked == false)
            {
                var comparedDates = DateTime.Compare(DtpExitDate.Value, DtpEntryDate.Value);
                if (comparedDates < 0)
                    throw new ValidationException("Das Austrittsdatum kann nicht vor dem Eintrittsdatum liegen.");
            }

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
            Validation.Required(CmbSalutation.Text, "Anrede muss ausgefüllt werden.");

            Validation.Required(txtFirstName, "Vorname muss ausgefüllt werden.");

            Validation.Required(txtSurName, "Nachname muss ausgefüllt werden.");

            // check tel number lengths
            Validation.ValidatePhone(txtMobile.Text, "Mobilenummer ist nicht gültig.");

            // optional tel / fax numbers
            if (txtPhonePrivate.Text.Length > 0)
                Validation.ValidatePhone(txtPhonePrivate.Text, "Telefonnumer Privat ist nicht gültig.");

            if (txtPhoneCompany.Text.Length > 0)
                Validation.ValidatePhone(txtPhoneCompany.Text, "Telefonnumer Geschäft ist nicht gültig.");

            if (txtFax.Text.Length > 0)
                Validation.ValidatePhone(txtFax.Text, "Faxnummer ist nicht gültig.");

            // check ahv number
            Validation.Required(txtAhv.Text, "AHV Nummer wurde nicht hinterlegt.");
            Validation.ValidateAhv(txtAhv.Text, "AHV Nummer ist nicht gültig.");

            // check birth of date compare
            if (checkedBirthOfDate > 0)
                throw new ValidationException("Das Geburtsdatum kann nicht jünger als heute sein.");

            Validation.Required(txtAddress, "Adresse muss ausgefüllt werden.");
            Validation.Required(txtCity, "Ort muss ausgefüllt werden.");

            // check if zip code is valid for switzerland
            Validation.ValidateZipCode(_zipCodeFormatted);

            // check departement
            Validation.Required(txtDepartement, "Abteilung muss ausgefüllt sein.");

            // check if email is correct
            Validation.Required(txtEmail, "E-Mail muss ausgefüllt sein.");
            Validation.ValidateEmail(txtEmail.Text);

            // check loe
            if (_loeFormatted < 1 || _loeFormatted > 100)
                throw new ValidationException("Der Anstellungsgrad muss zwischen 1 und 100 liegen.");

            Validation.Required(txtRole, "Tätigkeit muss ausgefüllt sein.");

            // check managementLevel (0-5)
            if (_managementLevelFormatted < 0 || _managementLevelFormatted > 5)
                throw new ValidationException("Die Kaderstufe muss innerhalb 0 und 5 sein");
        }

        private void CreateEmployee()
        {
            try
            {
                CheckFieldInput();

                /* *****************************
                 * create employee object
                ***************************** */
                var employee = new Employee(
                    CmbSalutation.Text,
                    txtFirstName.Text,
                    txtSurName.Text,
                    DtpDateOfBirth.Value,
                    _selectedGender,
                    CmbTitle.Text,
                    txtEmail.Text,
                    ChkStatus.Checked,
                    txtAddress.Text,
                    _zipCodeFormatted,
                    txtPhonePrivate.Text,
                    txtPhoneCompany.Text,
                    txtFax.Text,
                    txtMobile.Text,
                    txtCity.Text,
                    ahv: txtAhv.Text,
                    country: _defaultCountry,
                    departement: txtDepartement.Text,
                    nationality: CmbNationality.Text,
                    entryDate: DtpEntryDate.Value,
                    exitDate: DtpExitDate.Value,
                    loe: _loeFormatted,
                    role: txtRole.Text,
                    managementLevel: _managementLevelFormatted
                );

                if (ChkStatus.Checked == false) employee.Status = false;

                DataContainer.AddModel(DataContainer.Employees, employee);

                MessageBox.Show("Mitarbeiter wurde erfolgreich erstellt.");

                Close();
            }
            catch (ValidationException ex)
            {
                MessageBox.Show(ex.Message, "Validierungsfehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateEmployee()
        {
            try
            {
                // check input
                CheckFieldInput();

                // set updated fields
                _editEmployee.Salutation = CmbSalutation.Text;
                _editEmployee.FirstName = txtFirstName.Text;
                _editEmployee.LastName = txtSurName.Text;
                _editEmployee.DateOfBirth = DtpDateOfBirth.Value;
                _editEmployee.Gender = _selectedGender;
                _editEmployee.Title = CmbTitle.Text;
                _editEmployee.Email = txtEmail.Text;
                _editEmployee.Status = ChkStatus.Checked;
                _editEmployee.Address = txtAddress.Text;
                _editEmployee.ZipCode = _zipCodeFormatted;
                _editEmployee.PhonePrivate = txtPhonePrivate.Text;
                _editEmployee.PhoneCompany = txtPhoneCompany.Text;
                _editEmployee.Fax = txtFax.Text;
                _editEmployee.Mobile = txtMobile.Text;
                _editEmployee.City = txtCity.Text;
                _editEmployee.Ahv = txtAhv.Text;
                _editEmployee.Country = _defaultCountry;
                _editEmployee.Departement = txtDepartement.Text;
                _editEmployee.Nationality = CmbNationality.Text;
                _editEmployee.EntryDate = DtpEntryDate.Value;

                // if employee is acitive - dont update exitDate
                if (ChkStatus.Checked == false)
                    _editEmployee.ExitDate = DtpExitDate.Value;

                _editEmployee.Loe = _loeFormatted;
                _editEmployee.Role = txtRole.Text;
                _editEmployee.ManagementLevel = _managementLevelFormatted;


                MessageBox.Show("Änderungen gespeichert.");

                Close();
            }
            catch (ValidationException ex)
            {
                MessageBox.Show(ex.Message, "Validierungsfehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            /* *********************************
             * call function to create employee
            ********************************* */
            try
            {
                if (_editEmployee == null)
                    CreateEmployee();
                else
                    UpdateEmployee();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}