using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Contact_Manager.Models;
using Contact_Manager.Themes;

namespace Contact_Manager.Partials.Dialog
{
    public partial class TraineeDialog : Form
    {
        public TraineeDialog()
        {
            InitializeComponent();
        }

        public TraineeDialog(Trainee tainree)
        {
            InitializeComponent();
        }

        private void TraineeDialog_Load(object sender, EventArgs e)
        {
            MainTheme.InitThemeForForm(this);
        }
    }
}
