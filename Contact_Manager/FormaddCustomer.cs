﻿using Contact_Manager.Models;
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
           
        }

        private void btnCompanySave_Click(object sender, EventArgs e)
        {

            // declare vars
            int selectedGender;
            string defaultCountry = "Schweiz";

            // formatting stuff
            int zipCodeFormatted = int.Parse(txtZipCode.Text);
         

            // check which gender is selected and store in variable
            // male = 1 / female = 2 / other = 3
            if (rbMale.Checked)
                selectedGender = 1;
            else if (rbFemale.Checked)
                selectedGender = 2;
            else
                selectedGender = 3;





            // create customer object
            Customer c1 = new Customer(
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
                customerType: CmbCustomerType.Text
                


                );

        }


      

        private void txtCompanyContactSurname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtCompanyCity_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCompanyZip_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCompanyAdress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCompany_TextChanged(object sender, EventArgs e)
        {

        }

        private void CmbCustomerType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DtpDateOfBirth_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtFax_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhoneCompany_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CmbNationality_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtZipCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCity_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhonePrivate_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMobile_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSurName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbOther_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CmbTitle_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CmbSalutation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ChkStatus_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtCompanyContactEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
