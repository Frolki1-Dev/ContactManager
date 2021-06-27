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


    public partial class FormAddEmployee : Form
    {
        List<string> culturesList = new List<string>();
        CultureInfo[] cultures = CultureInfo.GetCultures(CultureTypes.SpecificCultures);
        RegionInfo region;
        public FormAddEmployee()
        {
            InitializeComponent();
        }

        private void addEmployeeForm_Load(object sender, EventArgs e)
        {
            cbCurrentApprenticeYear.Enabled = false;
            foreach (CultureInfo culture in cultures)
            {
                region = new RegionInfo(culture.LCID);
                if (!(culturesList.Contains(region.EnglishName)))
                {
                    culturesList.Add(region.EnglishName);
                    cbNationality.Items.Add(region.EnglishName + "(" + region.ISOCurrencySymbol + ")");
                }

            }
        }

        private void chckbxActive_CheckStateChanged(object sender, EventArgs e)
        {
            if (chckbxActive.Checked)
            {
                dtpWithdrawlDate.Enabled = false;
            }
            else
            {
                dtpWithdrawlDate.Enabled = true;
            }
        }

        private void chckbxApprentice_CheckedChanged(object sender, EventArgs e)
        {
            if (chckbxApprentice.Checked)
            {
                cbCurrentApprenticeYear.Enabled = true;
            }
            else
            {
                cbCurrentApprenticeYear.Enabled = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
