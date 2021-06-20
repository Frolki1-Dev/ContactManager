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


namespace Contact_Manager
{
    public partial class Frm1 : Form
    {
        public Frm1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCreateEmployee_Click(object sender, EventArgs e)
        {
            FormAddEmployee formAddEmployeeForm = new FormAddEmployee();
            formAddEmployeeForm.Show();
        }

        private void btnCreateCustomer_Click(object sender, EventArgs e)
        {
            FormAddCustomer formAddCustomer = new FormAddCustomer();
            formAddCustomer.Show();
        }
    }
}

