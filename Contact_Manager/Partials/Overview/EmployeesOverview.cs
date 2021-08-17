using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Contact_Manager.Models;
using Contact_Manager.Partials.Dialog;

namespace Contact_Manager.Partials.Overview
{
    public partial class EmployeesOverview : FrmOverview
    {
        public EmployeesOverview()
        {
            InitializeComponent();
        }

        protected override dynamic GetCollectionList()
        {
            return DataContainer.GetEmployeeCollection();
        }

        protected override void OpenEditDialog(int row)
        {
            EmployeeDialog dialog = new EmployeeDialog(GetObjectFromIndex(row));
            dialog.FormClosing += DialogClosing;
            dialog.Show();
        }

        protected override dynamic GetObjectFromIndex(int row)
        {
            return (Employee)source[row];
        }

        protected override DialogResult AskForConfirmation(dynamic obj)
        {
            throw new NotImplementedException();
        }
    }
}
