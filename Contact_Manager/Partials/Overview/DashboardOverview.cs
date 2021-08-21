using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact_Manager.Partials.Overview
{
    public partial class DashboardOverview : Form
    {
        public DashboardOverview()
        {
            InitializeComponent();

            LblNumCustomers.Text = DataContainer.GetCustomerCollection().Count.ToString();
            LblNumEmployees.Text = DataContainer.GetEmployeeCollection().Count.ToString();
            LblNumTrainees.Text = DataContainer.GetTraineeCollection().Count.ToString();
        }
    }
}
