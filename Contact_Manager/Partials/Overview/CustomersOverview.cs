﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Contact_Manager.Models;

namespace Contact_Manager.Partials.Overview
{
    public partial class CustomersOverview : FrmOverview
    {
        public CustomersOverview()
        {
            InitializeComponent();
        }

        protected override dynamic GetCollectionList()
        {
            return DataContainer.GetCustomerCollection();
        }

        protected override void OpenEditDialog(int row)
        {
            
        }

        protected override dynamic GetObjectFromIndex(int row)
        {
            return (Customer) source[row];
        }

        protected override DialogResult AskForConfirmation(dynamic obj)
        {
            return MessageBox.Show("Möchstest du wirklich den Kunden " + obj.CompanyName + " löschen?",
                "Bestätigung Löschvorgang", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}