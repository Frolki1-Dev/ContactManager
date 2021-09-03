using System.Drawing;
using System.Windows.Forms;

namespace Contact_Manager.Components
{
    /**
     * Define the dashboard item
     */
    public partial class DashboardItem : UserControl
    {
        public DashboardItem()
        {
            InitializeComponent();
            BackColor = Properties.Settings.Default.PrimaryColor;
        }

        /**
         * Set the icon
         */
        public void SetIcon(Image icon)
        {
            ImgIcon.Image = icon;
        }

        /**
         * Set the counter
         */
        public void SetCounter(int num)
        {
            LblNumItems.Text = num.ToString();
        }

        /**
         * Set title
         */
        public void SetTitle(string title)
        {
            LblTitleNumItems.Text = title;
        }
    }
}