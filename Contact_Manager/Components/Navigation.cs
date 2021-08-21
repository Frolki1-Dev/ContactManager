using System;
using System.Windows.Forms;
using Contact_Manager.Views;

namespace Contact_Manager.Components
{
    public partial class Navigation : UserControl
    {
        public Navigation()
        {
            InitializeComponent();
        }

        private void Navigation_Load(object sender, EventArgs e)
        {
            BackColor = Properties.Settings.Default.NavigationColor;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Good now sign out and close the window
            Form parent = GetParentForm();
            Form login = new Login();

            Authentication.Authentication.Logout();

            parent.Hide();
            login.ShowDialog();
            parent.Close();
        }

        private void LblDashboard_Click(object sender, EventArgs e)
        {
            // Open new view only if the parent is not the type
            if (!(GetParentForm() is Dashboard))
            {
                OpenNewView(new Dashboard());
            }
        }

        private void LblCustomers_Click(object sender, EventArgs e)
        {
            // Open new view only if the parent is not the type
            if (!(GetParentForm() is Customers))
            {
                OpenNewView(new Customers());
            }
        }

        private void LblEmployees_Click(object sender, EventArgs e)
        {
            // Open new view only if the parent is not the type
            if (!(GetParentForm() is Employees))
            {
                OpenNewView(new Employees());
            }
        }

        private void LblTrainees_Click(object sender, EventArgs e)
        {
            // Open new view only if the parent is not the type
            if (!(GetParentForm() is Trainees))
            {
                OpenNewView(new Trainees());
            }
        }

        private void LblUsers_Click(object sender, EventArgs e)
        {
            // Open new view only if the parent is not the type
            if (!(GetParentForm() is Users))
            {
                OpenNewView(new Users());
            }
        }

        private Form GetParentForm()
        {
            if (Parent == null || !(Parent is Form))
            {
                throw new Exception("Parent ist nicht definiert!");
            }

            return (Form) Parent;
        }

        private void OpenNewView(Form form)
        {
            Helper.openNewFormAndCloseOld(form, GetParentForm());
        }
    }
}
