using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Contact_Manager.Models;
using Contact_Manager.Themes;

namespace Contact_Manager.Partials.Dialog
{
    public partial class TraineeDialog : Form
    {
        /* *****************************************************
        * declare global vars
        ***************************************************** */
        private int _selectedGender;
        private int _zipCodeFormatted;
        private string _defaultCountry;
        private readonly Trainee _editTrainee;
        private int _loeFormatted;
        private int _managementLevelFormatted;
        private int _currentTraineeYearFormatted;
        private int _maxTraineeYearFormatted;
        public TraineeDialog()
        {
            InitializeComponent();
        }

        public TraineeDialog(Trainee trainee)
        {
            InitializeComponent();

            // load default values for comboboxes
            defaultValueCombobox();

            _editTrainee = trainee;
            btnSave.Text = "Änderungen speichern";

            // set values from loaded employee
            CmbSalutation.Text = trainee.Salutation;
            txtFirstName.Text = trainee.FirstName;
            txtSurName.Text = trainee.LastName;
            DtpDateOfBirth.Value = trainee.DateOfBirth;

            /* *****************************************************
             * check which gender is set and convert to gui element
             * male = 1 / female = 2 / other = 3
            ***************************************************** */
            switch (trainee.Gender)
            {
                case 1 when trainee.Gender == 1:
                    rbMale.Checked = true;
                    break;
                case 2 when trainee.Gender == 2:
                    rbFemale.Checked = true;
                    break;
                case 3 when trainee.Gender == 3:
                    rbOther.Checked = true;
                    break;
            }

            txtEmail.Text = trainee.Email;
            ChkStatus.Checked = trainee.Status;
            txtAddress.Text = trainee.Address;
            txtZipCode.Text = Convert.ToString(trainee.ZipCode);
            txtPhonePrivate.Text = trainee.PhonePrivate;
            txtPhoneCompany.Text = trainee.PhoneCompany;
            txtFax.Text = trainee.Fax;
            txtMobile.Text = trainee.Mobile;
            txtCity.Text = trainee.City;
            txtAhv.Text = trainee.Ahv;
            txtDepartement.Text = trainee.Departement;
            CmbNationality.Text = trainee.Nationality;
            DtpEntryDate.Value = trainee.EntryDate;
            DtpExitDate.Value = trainee.ExitDate;
            CmbLoe.Text = Convert.ToString(trainee.Loe);
            txtRole.Text = trainee.Role;
            CmbManagementLevel.Text = Convert.ToString(trainee.ManagementLevel);
            CmbCurrentApprenticeYear.Text = Convert.ToString(trainee.CurrentTraineeYear);
            CmbApprenticeYears.Text = Convert.ToString(trainee.MaxTraineeYear);
        }

        public void defaultValueCombobox()
        {
            /* *****************************
             * default salutations
            ***************************** */
            string[] salutations = new string[]
            {
                "Herr",
                "Frau"
            };

            foreach (var salutation in salutations)
            {
                CmbSalutation.Items.Add(salutation);
            }

            /* *****************************
             * default country list
            ***************************** */
            string[] countries = new string[]
            {
                "Schweiz",
                "Deutschland",
                "Liechtenstein",
                "Frankreich",
                "Österreich",
                "Italien"
            };

            foreach (var country in countries)
            {
                CmbNationality.Items.Add(country);
            }

            /* *****************************
             * default loe
            ***************************** */
            string[] loes = new string[]
            {
                "5",
                "10",
                "15",
                "20",
                "25",
                "30",
                "35",
                "40",
                "45",
                "50",
                "55",
                "60",
                "65",
                "70",
                "75",
                "80",
                "85",
                "90",
                "100"
            };

            foreach (var loe in loes)
            {
                CmbLoe.Items.Add(loe);
            }

            /* *****************************
             * default ManagementLevel
            ***************************** */
            string[] levels = new string[]
            {
                "0",
                "1",
                "2",
                "3",
                "4",
                "5"
            };

            foreach (var level in levels)
            {
                CmbManagementLevel.Items.Add(level);
            }

            /* *****************************
             * default trainee years
            ***************************** */
            string[] traineeYears = new string[]
            {
                "1",
                "2",
                "3",
                "4"
            };

            foreach (var traineeYear in traineeYears)
            {
                CmbApprenticeYears.Items.Add(traineeYear);
                CmbCurrentApprenticeYear.Items.Add(traineeYear);
            }
        }

        private void TraineeDialog_Load(object sender, EventArgs e)
        {
            MainTheme.InitThemeForForm(this);
            defaultValueCombobox();

            /* *****************************
             * define default values for trainee
             * and lock gui elements
            ***************************** */
            CmbLoe.SelectedItem = "100";
            CmbLoe.Enabled = false;

            CmbManagementLevel.SelectedItem = "5";
            CmbManagementLevel.Enabled = false;
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
            _maxTraineeYearFormatted = Convert.ToInt32(CmbApprenticeYears.SelectedItem.ToString());
            _currentTraineeYearFormatted = Convert.ToInt32(CmbCurrentApprenticeYear.SelectedItem.ToString());

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
            Validation.Required(CmbSalutation.SelectedItem.ToString(), "Anrede muss ausgefüllt werden.");

            Validation.Required(txtFirstName, "Vorname muss ausgefüllt werden.");

            Validation.Required(txtSurName, "Nachname muss ausgefüllt werden.");

            // check mobile number length
            Validation.ValidatePhone(txtMobile.Text, "Mobilenummer ist nicht gültig.");

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

            // check trainee years
            if(_maxTraineeYearFormatted < 1 || _maxTraineeYearFormatted > 4)
                throw new ValidationException("Anzahl Lehrjahre muss zwischen 1 Jahr und 4 Jahre sein");

            if(_currentTraineeYearFormatted < 1 || _currentTraineeYearFormatted > 4)
                throw new ValidationException("Aktulles Lehrjahr muss zwischen 1 und 4 sein");

            if(_currentTraineeYearFormatted > _maxTraineeYearFormatted)
                throw new ValidationException("Aktuelles Lehrjahr ist grösser als die Anzahl Lehrjahre");
        }

        private void CreateTrainee()
        {
            try
            {
                CheckFieldInput();

                /* *****************************
                 * create employee object
                ***************************** */
                Trainee trainee = new Trainee(
                    CmbSalutation.Text,
                    txtFirstName.Text,
                    txtSurName.Text,
                    DtpDateOfBirth.Value,
                    _selectedGender,
                    "",
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
                    managementLevel: _managementLevelFormatted,
                    currentTraineeYear: _currentTraineeYearFormatted,
                    maxTraineeYear: _maxTraineeYearFormatted
                );

                if (ChkStatus.Checked == false) trainee.Status = false;

                DataContainer.AddModel(DataContainer.Trainees, trainee);

                MessageBox.Show("Lehrling wurde erfolgreich erstellt.");

                Close();
            }
            catch (ValidationException ex)
            {
                MessageBox.Show(ex.Message, "Validierungsfehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateTrainee()
        {
            try
            {
                // check input
                CheckFieldInput();

                // set updated fields
                _editTrainee.Salutation = CmbSalutation.Text;
                _editTrainee.FirstName = txtFirstName.Text;
                _editTrainee.LastName = txtSurName.Text;
                _editTrainee.DateOfBirth = DtpDateOfBirth.Value;
                _editTrainee.Gender = _selectedGender;
                _editTrainee.Title = "";
                _editTrainee.Email = txtEmail.Text;
                _editTrainee.Status = ChkStatus.Checked;
                _editTrainee.Address = txtAddress.Text;
                _editTrainee.ZipCode = _zipCodeFormatted;
                _editTrainee.PhonePrivate = txtPhonePrivate.Text;
                _editTrainee.PhoneCompany = txtPhoneCompany.Text;
                _editTrainee.Fax = txtFax.Text;
                _editTrainee.Mobile = txtMobile.Text;
                _editTrainee.City = txtCity.Text;
                _editTrainee.Ahv = txtAhv.Text;
                _editTrainee.Country = _defaultCountry;
                _editTrainee.Departement = txtDepartement.Text;
                _editTrainee.Nationality = CmbNationality.Text;
                _editTrainee.EntryDate = DtpEntryDate.Value;

                // if employee is acitive - dont update exitDate
                if (ChkStatus.Checked == false)
                    _editTrainee.ExitDate = DtpExitDate.Value;

                _editTrainee.Loe = _loeFormatted;
                _editTrainee.Role = txtRole.Text;
                _editTrainee.ManagementLevel = _managementLevelFormatted;
                _editTrainee.MaxTraineeYear = _maxTraineeYearFormatted;
                _editTrainee.CurrentTraineeYear = _currentTraineeYearFormatted;

                DataContainer.Update(_editTrainee);
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
            try
            {
                if (_editTrainee == null)
                    CreateTrainee();
                else
                    UpdateTrainee();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChkStatus_CheckedChanged(object sender, EventArgs e)
        {
            // Make it simple
            DtpExitDate.Enabled = !ChkStatus.Checked;
        }
    }
}