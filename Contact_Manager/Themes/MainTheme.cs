using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.Control;

namespace Contact_Manager.Themes
{
    class MainTheme
    {
        public static void InitThemeForForm(Form form)
        {
            MainTheme theme = new MainTheme();
            theme.SetFormStyle(form);
            theme.SetControlStyles(form.Controls);
        }

        public void SetFormStyle(Form form)
        {
            form.BackColor = Properties.Settings.Default.DefaultFormBackgroundColor;
            form.Font = Properties.Settings.Default.DefaultFormFont;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Icon = Properties.Resources.AppIcon;
            //form.Padding = new Padding(25, 10, 25, 25);

            if (form.AccessibleDescription != null && form.AccessibleDescription.ToString() == "mainWindow")
            {
                form.MinimumSize = new Size(1000, 600);
            }
        }

        public void SetControlStyles(ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                // Define for a custom style
                if(control.AccessibleDescription != null && control.AccessibleDescription.ToString() == "custom")
                {
                    continue;
                }

                // Define the global style now
                if (control is Label)
                {
                    SetLabelStyle((Label)control);
                } else if (control is Button)
                {
                    SetButtonStyle((Button)control);
                } else if(control is TextBox)
                {
                    SetTextBoxStyle((TextBox)control);
                } else if(control is Panel || control is UserControl || control is TableLayoutPanel)
                {
                    SetControlStyles(control.Controls);
                }
            }
        }

        private void SetLabelStyle(Label control)
        {
            control.ForeColor = Properties.Settings.Default.FontColor;

            if (control.AccessibleDescription != null && control.AccessibleDescription.ToString() == "navItem")
            {
                // Special navigation style
                control.ForeColor = Color.White;
                control.BackColor = Color.Transparent;
                control.Width = 125;
                control.Cursor = Cursors.Hand;
                control.Font = new Font(Properties.Settings.Default.DefaultFormFont, System.Drawing.FontStyle.Bold);
                control.Padding = new Padding(8, 0, 8, 0);
                control.MouseEnter += (sender, args) =>
                {
                    control.BackColor = Color.White;
                    control.ForeColor = Properties.Settings.Default.NavigationColor;
                };
                control.MouseLeave += (sender, args) =>
                {
                    control.ForeColor = Color.White;
                    control.BackColor = Color.Transparent;
                };
            }
        }

        private void SetButtonStyle(Button control)
        {
            control.BackColor = Properties.Settings.Default.PrimaryColor;
            control.ForeColor = Properties.Settings.Default.FontColor;
            control.FlatStyle = FlatStyle.Flat;
            control.FlatAppearance.BorderColor = Properties.Settings.Default.PrimaryColor;
            control.FlatAppearance.MouseDownBackColor = Properties.Settings.Default.SecondaryColor;
            control.Font = new Font(Properties.Settings.Default.DefaultFormFont, System.Drawing.FontStyle.Bold);
        }

        private void SetTextBoxStyle(TextBox control)
        {
            control.BorderStyle = BorderStyle.FixedSingle;
        }
    }
}
