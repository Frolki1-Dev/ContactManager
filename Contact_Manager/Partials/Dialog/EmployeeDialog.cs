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
using Contact_Manager.Models;
using Contact_Manager.Themes;

namespace Contact_Manager.Partials.Dialog
{
    public partial class EmployeeDialog : Form
    {
        /* List<string> _culturesList = new List<string>();
        CultureInfo[] _cultures = CultureInfo.GetCultures(CultureTypes.SpecificCultures);
        RegionInfo _region; */

        /* *****************************************************
        * declare global vars
        ***************************************************** */
        private int selectedGender;
        private string defaultCountry;
        private int zipCodeFormatted;
        private int loeFormatted;
        private int managementLevelFormatted;

        private bool errorFound = false;
        private Employee editEmployee;

        public EmployeeDialog()
        {
            InitializeComponent();
        }

        public EmployeeDialog(Employee employee)
        {
            InitializeComponent();

            // set flag for edit
            editEmployee = employee;

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

        private void EmployeeDialog_Load(object sender, EventArgs e)
        {
            MainTheme.InitThemeForForm(this);
            /* 
                CmbApprenticeYears.Enabled = false;
                CmbCurrentApprenticeYear.Enabled = false;
            */

            CmbNationality.DataSource = CountryList();

            /*
            foreach (CultureInfo culture in _cultures)
            {
                _region = new RegionInfo(culture.LCID);
                if (!(_culturesList.Contains(_region.EnglishName)))
                {
                    _culturesList.Add(_region.EnglishName);
                    CmbNationality.Items.Add(_region.EnglishName + "(" + _region.ISOCurrencySymbol + ")");
                }

            }
            */
        }

        private void ChkStatus_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkStatus.Checked)
            {
                DtpExitDate.Enabled = false;
            }
            else
            {
                DtpExitDate.Enabled = true;
            }
        }

        private void generateErrorMessage(string errorMessage)
        {
            // throw new InvalidDataException(errorMessage);
            MessageBox.Show(errorMessage);

            // error found - set global var to true
            errorFound = true;
        }

        private void cleanUpFields()
        {
            // unset everything to default / null
            CmbSalutation.SelectedIndex = -1;
            txtFirstName.Clear();
            txtSurName.Clear();
            DtpDateOfBirth.Value = DateTime.Today;
            rbMale.Checked = false;
            rbFemale.Checked = false;
            rbOther.Checked = false;
            CmbTitle.SelectedIndex = -1;
            txtEmail.Clear();
            ChkStatus.Checked = true;
            txtAddress.Clear();
            txtZipCode.Clear();
            txtPhonePrivate.Clear();
            txtPhoneCompany.Clear();
            txtFax.Clear();
            txtMobile.Clear();
            txtCity.Clear();
            txtAhv.Clear();
            txtDepartement.Clear();
            CmbNationality.SelectedIndex = -1;
            DtpEntryDate.Value = DateTime.Today;
            DtpExitDate.Value = DateTime.Today;
            CmbLoe.SelectedIndex = -1;
            txtRole.Clear();
            CmbManagementLevel.SelectedIndex = -1;
        }

        private void checkFieldInput()
        {
            /* *****************************
             * define vars
            ***************************** */

            defaultCountry = "Schweiz";

            /* *****************************
             * formatting stuff
            ***************************** */

            zipCodeFormatted = Convert.ToInt32(txtZipCode.Text);
            loeFormatted = Convert.ToInt32(CmbLoe.SelectedItem.ToString());
            managementLevelFormatted = Convert.ToInt32(CmbManagementLevel.SelectedItem.ToString());

            /* *****************************
             * compare entry and exit date only if user is deactivated
            ***************************** */
            if (ChkStatus.Checked == false)
            {
                int comparedDates = DateTime.Compare(DtpExitDate.Value, DtpEntryDate.Value);
                if (comparedDates < 0)
                    generateErrorMessage("Das Austrittsdatum kann nicht vor dem Eintrittsdatum liegen.");
            }

            /* *****************************
             * compare date of birth
            ***************************** */

            int checkedBirthOfDate = DateTime.Compare(DtpDateOfBirth.Value, DateTime.Today);

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
            if (CmbSalutation.SelectedItem.ToString().Length < 1)
                generateErrorMessage("Anrede muss ausgefüllt werden.");

            if (txtFirstName.Text.Length < 1)
                generateErrorMessage("Vorname muss ausgefüllt werden.");

            if (txtSurName.Text.Length < 1)
                generateErrorMessage("Nachname muss ausgefüllt werden.");

            // check mobile number length
            if (txtMobile.Text.Length != 12)
                generateErrorMessage("Bitte Telefon-Nummer im folgenden Format angeben \"+41711234567\".");

            // check birth of date compare
            if (checkedBirthOfDate > 0)
                generateErrorMessage("Das Geburtsdatum kann nicht jünger als heute sein.");

            if (txtAddress.Text.Length < 1)
                generateErrorMessage("Adresse muss ausgefüllt werden.");

            if (txtCity.Text.Length < 1)
                generateErrorMessage("Ort muss ausgefüllt werden.");

            // check if zip code is valid for switzerland
            if (zipCodeFormatted < 1000 || zipCodeFormatted > 9999)
                generateErrorMessage("Die Postleitzahl ist zu klein / gross.");

            // check departement
            if (txtDepartement.Text.Length < 0)
                generateErrorMessage("Abteilung muss ausgefüllt sein.");

            // check if email is correct
            // source: https://stackoverflow.com/questions/5342375/regex-email-validation / https://docs.microsoft.com/en-us/dotnet/api/system.net.mail.mailaddress?redirectedfrom=MSDN&view=net-5.0
            if (txtEmail.Text.Length > 0)
                try
                {
                    MailAddress m = new MailAddress(txtEmail.Text);
                }
                catch (FormatException)
                {
                    generateErrorMessage("Das Format der E-Mail Adresse ist ungültig.");
                }
            else
            {
                generateErrorMessage("E-Mail muss ausgefüllt sein.");
            }

            // check loe
            if (loeFormatted < 1 || loeFormatted > 100)
                generateErrorMessage("Der Anstellungsgrad muss zwischen 1 und 100 liegen.");

            if (txtRole.Text.Length < 1)
                generateErrorMessage("Tätigkeit muss ausgefüllt sein.");

            // check managementLevel (0-5)
            if (managementLevelFormatted < 0 || managementLevelFormatted > 5)
                generateErrorMessage("Die Kaderstufe muss innerhalb 0 und 5 sein");
        }

        private void createEmployee()
        {
            checkFieldInput();

            /* *****************************
             * create employee object
            ***************************** */
            if (errorFound == false)
            {
                Employee employee = new Employee(
                    salutation: CmbSalutation.Text,
                    firstName: txtFirstName.Text,
                    lastName: txtSurName.Text,
                    dateOfBirth: DtpDateOfBirth.Value,
                    gender: selectedGender,
                    title: CmbTitle.Text,
                    email: txtEmail.Text,
                    status: ChkStatus.Checked,
                    address: txtAddress.Text,
                    zipCode: zipCodeFormatted,
                    phonePrivate: txtPhonePrivate.Text,
                    phoneCompany: txtPhoneCompany.Text,
                    fax: txtFax.Text,
                    mobile: txtMobile.Text,
                    city: txtCity.Text,
                    ahv: txtAhv.Text,
                    country: defaultCountry,
                    departement: txtDepartement.Text,
                    nationality: CmbNationality.Text,
                    entryDate: DtpEntryDate.Value,
                    exitDate: DtpExitDate.Value,
                    loe: loeFormatted,
                    role: txtRole.Text,
                    managementLevel: managementLevelFormatted
                );

                if(ChkStatus.Checked == false)
                {
                    employee.Status = false;
                }

                DataContainer.AddModel(DataContainer.Employees, employee);
                DataContainer.SaveList(DataContainer.Employees);

                MessageBox.Show("Mitarbeiter wurde erfolgreich erstellt.");
            }
        }

        private void updateEmployee()
        {
            // check input
            checkFieldInput();

            if(errorFound == false)
            {
                // set updated fields
                editEmployee.Salutation = CmbSalutation.Text;
                editEmployee.FirstName = txtFirstName.Text;
                editEmployee.LastName = txtSurName.Text;
                editEmployee.DateOfBirth = DtpDateOfBirth.Value;
                editEmployee.Gender = selectedGender;
                editEmployee.Title = CmbTitle.Text;
                editEmployee.Email = txtEmail.Text;
                editEmployee.Status = ChkStatus.Checked;
                editEmployee.Address = txtAddress.Text;
                editEmployee.ZipCode = zipCodeFormatted;
                editEmployee.PhonePrivate = txtPhonePrivate.Text;
                editEmployee.PhoneCompany = txtPhoneCompany.Text;
                editEmployee.Fax = txtFax.Text;
                editEmployee.Mobile = txtMobile.Text;
                editEmployee.City = txtCity.Text;
                editEmployee.Ahv = txtAhv.Text;
                editEmployee.Country = defaultCountry;
                editEmployee.Departement = txtDepartement.Text;
                editEmployee.Nationality = CmbNationality.Text;
                editEmployee.EntryDate = DtpEntryDate.Value;

                // if employee is acitive - dont update exitDate
                if (ChkStatus.Checked == false)
                    editEmployee.ExitDate = DtpExitDate.Value;

                editEmployee.Loe = loeFormatted;
                editEmployee.Role = txtRole.Text;
                editEmployee.ManagementLevel = managementLevelFormatted;

                DataContainer.Update(editEmployee);
                MessageBox.Show("Änderungen gespeichert.");
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            /* *********************************
             * call function to create employee
            ********************************* */
            try
            {
                if (editEmployee == null)
                {
                    createEmployee();
                    // cleanUpFields();
                }
                else
                {
                    updateEmployee();
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
