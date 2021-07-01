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
        List<string> _culturesList = new List<string>();
        CultureInfo[] _cultures = CultureInfo.GetCultures(CultureTypes.SpecificCultures);
        RegionInfo _region;
        public FormAddEmployee()
        {
            InitializeComponent();
        }

        private void addEmployeeForm_Load(object sender, EventArgs e)
        {
            cbCurrentApprenticeYear.Enabled = false;
            foreach (CultureInfo culture in _cultures)
            {
                _region = new RegionInfo(culture.LCID);
                if (!(_culturesList.Contains(_region.EnglishName)))
                {
                    _culturesList.Add(_region.EnglishName);
                    cbNationality.Items.Add(_region.EnglishName + "(" + _region.ISOCurrencySymbol + ")");
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
