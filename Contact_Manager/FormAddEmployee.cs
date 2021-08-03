using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.IO;
using System.Net.Mail;
using System.Text.RegularExpressions;
using Contact_Manager.Models;

namespace Contact_Manager
{


    public partial class FormAddEmployee : Form
    {
        List<string> _culturesList = new List<string>();
        CultureInfo[] _cultures = CultureInfo.GetCultures(CultureTypes.SpecificCultures);
        RegionInfo _region;
        public FormAddEmployee()
        {
            InitializeComponent();
        }

        private void addEmployeeForm_Load(object sender, EventArgs e)
        {
            CmbCurrentApprenticeYear.Enabled = false;
            foreach (CultureInfo culture in _cultures)
            {
                _region = new RegionInfo(culture.LCID);
                if (!(_culturesList.Contains(_region.EnglishName)))
                {
                    _culturesList.Add(_region.EnglishName);
                    CmbNationality.Items.Add(_region.EnglishName + "(" + _region.ISOCurrencySymbol + ")");
                }

            }
        }

        private void chckbxActive_CheckStateChanged(object sender, EventArgs e)
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

        private void chckbxApprentice_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkApprentice.Checked)
            {
                CmbCurrentApprenticeYear.Enabled = true;
            }
            else
            {
                CmbCurrentApprenticeYear.Enabled = false;
            }
        }

        private void generateErrorMessage(string errorMessage)
        {
            throw new InvalidDataException(errorMessage);
        }

        private void createEmployee()
        {
            /* *****************************
             * declare vars
            ***************************** */

            int selectedGender;
            string defaultCountry = "Schweiz";

            /* *****************************
             * formatting stuff
            ***************************** */

            int zipCodeFormatted = int.Parse(txtZipCode.Text);
            int loeFormatted = int.Parse(CmbLoe.Text);
            int managementLevelFormatted = int.Parse(CmbManagementLevel.Text);

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
            if (txtFirstName.Text.Length < 1 || txtSurName.Text.Length < 1 || txtAddress.Text.Length < 1)
                generateErrorMessage("Dieses Feld muss ausgefüllt werden.");

            // check if birthdate is newer than today
            if (DtpDateOfBirth.Value > DateTime.Today)
                generateErrorMessage("Das Geburtsdatum kann nicht jünger als heute sein.");

            // check if email is correct
            // source: https://stackoverflow.com/questions/5342375/regex-email-validation / https://docs.microsoft.com/en-us/dotnet/api/system.net.mail.mailaddress?redirectedfrom=MSDN&view=net-5.0
            try
            {
                MailAddress m = new MailAddress(txtEmail.Text);
            }
            catch (FormatException)
            {
                generateErrorMessage("Das Format der E-Mail Adresse ist ungültig.");
            }

            // check if zip code is valid for switzerland
            if (zipCodeFormatted < 1000 || zipCodeFormatted > 9999)
                generateErrorMessage("Die Postleitzahl ist zu klein / gross.");

            // check phone / fax number lengths
            if (txtPhonePrivate.Text.Length < 1 || txtPhonePrivate.Text.Length > 12 || txtPhoneCompany.Text.Length < 1 ||
                txtPhoneCompany.Text.Length > 12 || txtMobile.Text.Length < 1 || txtMobile.Text.Length > 12 || txtFax.Text.Length < 1 ||
                txtFax.Text.Length > 12)
                generateErrorMessage("Bitte Telefon- / Fax-Nummer im folgenden Format angeben \"+41711234566\".");

            // check ahv format
            if (txtAhv.Text.Length < 1 || txtAhv.Text.Length > 16)
                generateErrorMessage("Format der AHV-Nr. ist ungültig -> 756.XXXX.XXXX.XX");
            // REGEX MASTER - I NEED YOU - this internet solution isn't working...
            // Regex ahvNumber = new Regex("[7][5][6][.]\\d{4}[.]\\d{4}[.]\\d{2}")

            // check entryDate
            if (DtpEntryDate.Value > DateTime.Today)
                generateErrorMessage("Das Eintrittsdatum kann nicht neuer als heute sein.");

            // check exitDate
            if (DtpExitDate.Value < DtpEntryDate.Value)
                generateErrorMessage("Das Austrittsdatum kann nicht vor dem Eintrittsdatum liegen.");

            // check loe
            if (loeFormatted < 0 || loeFormatted > 100)
                generateErrorMessage("Der Beschäftigungsgrad muss zwischen 1 und 100 liegen.");

            // check managementLevel (0-5)
            if (managementLevelFormatted < 0 || managementLevelFormatted > 5)
                generateErrorMessage("Die Kaderstufe muss innerhalb 0 und 5 sein");

            /* *****************************
             * create employee object
            ***************************** */
            Employee e1 = new Employee(
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
                employeeNumber: 0,
                departement: txtDepartement.Text,
                nationality: CmbNationality.Text,
                entryDate: DtpEntryDate.Value,
                exitDate: DtpExitDate.Value,
                loe: loeFormatted,
                role: txtRole.Text,
                managementLevel: managementLevelFormatted
            );
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            /* *********************************
             * call function to create employee
            ********************************* */
            createEmployee();

        }
    }
}
