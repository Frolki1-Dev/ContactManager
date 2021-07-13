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
using Contact_Manager.Collections;


namespace Contact_Manager
{
    public partial class Frm1 : Form
    {
        private Users users;
        public Frm1()
        {
            InitializeComponent();

            // Load all data
            users = DataContainer.GetUserCollection();

            // Bind the data to the datasource
            var sourceUsers = new BindingSource();
            sourceUsers.DataSource = users;
            GridViewUsers.DataSource = sourceUsers;
            GridViewUsers.Columns["Id"].ReadOnly = true;
            GridViewUsers.Columns["Password"].ReadOnly = true;
            GridViewUsers.Columns["Deleted"].ReadOnly = true;
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

        private void CmdCreateUser_Click(object sender, EventArgs e)
        {
            FormAddUser fromAddUser = new FormAddUser();
            fromAddUser.Show();
        }
    }
}

