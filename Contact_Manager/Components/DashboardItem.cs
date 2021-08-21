using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact_Manager.Components
{
    public partial class DashboardItem : UserControl
    {
        public DashboardItem()
        {
            InitializeComponent();
            BackColor = Properties.Settings.Default.PrimaryColor;
        }

        public void setIcon(Image icon)
        {
            ImgIcon.Image = icon;
        }

        public void setCounter(int num)
        {
            LblNumItems.Text = num.ToString();
        }

        public void setTitle(string title)
        {
            LblTitleNumItems.Text = title;
        }
    }
}
