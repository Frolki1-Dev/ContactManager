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
        public static void initThemeForForm(Form form)
        {
            MainTheme theme = new MainTheme();
            theme.setFormStyle(form);
            theme.setControlStyles(form.Controls);
        }

        public void setFormStyle(Form form)
        {
            form.BackColor = Properties.Settings.Default.DefaultFormBackgroundColor;
            form.Font = Properties.Settings.Default.DefaultFormFont;
            //form.Padding = new Padding(25, 10, 25, 25);
        }

        public void setControlStyles(ControlCollection controls)
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
                    setLabelStyle((Label)control);
                } else if (control is Button)
                {
                    setButtonStyle((Button)control);
                } else if(control is TextBox)
                {
                    setTextBoxStyle((TextBox)control);
                } else if(control is Panel)
                {
                    setControlStyles(control.Controls);
                }
            }
        }

        private void setLabelStyle(Label control)
        {
            control.ForeColor = Properties.Settings.Default.FontColor;
        }

        private void setButtonStyle(Button control)
        {
            control.BackColor = Properties.Settings.Default.PrimaryColor;
            control.ForeColor = Properties.Settings.Default.FontColor;
            control.FlatStyle = FlatStyle.Flat;
            control.FlatAppearance.BorderColor = Properties.Settings.Default.PrimaryColor;
            control.FlatAppearance.MouseDownBackColor = Properties.Settings.Default.SecondaryColor;
            control.Font = new System.Drawing.Font(Properties.Settings.Default.DefaultFormFont, System.Drawing.FontStyle.Bold);
        }

        private void setTextBoxStyle(TextBox control)
        {
            control.BorderStyle = BorderStyle.FixedSingle;
        }
    }
}
