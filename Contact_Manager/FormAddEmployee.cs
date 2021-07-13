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

        private void btnSave_Click(object sender, EventArgs e)
        {
            // declare vars
            int selectedGender;
            string defaultCountry = "Schweiz";

            // formatting stuff
            int zipCodeFormatted = int.Parse(txtZipCode.Text);
            int loeFormatted = int.Parse(CmbLoe.Text);
            int managementLevelFormatted = int.Parse(CmbManagementLevel.Text);

            // check which gender is selected and store in variable
            // male = 1 / female = 2 / other = 3
            if (rbMale.Checked)
                selectedGender = 1;
            else if (rbFemale.Checked)
                selectedGender = 2;
            else
                selectedGender = 3;

            // create employee object
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
    }
}
