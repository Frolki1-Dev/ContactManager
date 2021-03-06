using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.Control;

namespace Contact_Manager.Themes
{
    /**
     * Style the application.
     */
    class MainTheme
    {
        /**
         * Get the form object and loop each control from the loop to apply the style
         */
        public static void InitThemeForForm(Form form)
        {
            MainTheme theme = new MainTheme();
            theme.SetFormStyle(form);
            theme.SetControlStyles(form.Controls);
        }

        /**
         * Set the global form window style
         */
        public void SetFormStyle(Form form)
        {
            form.BackColor = Properties.Settings.Default.DefaultFormBackgroundColor;
            form.Font = Properties.Settings.Default.DefaultFormFont;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Icon = Properties.Resources.AppIcon;
            //form.Padding = new Padding(25, 10, 25, 25);

            if (form.AccessibleDescription != null && form.AccessibleDescription.ToString() == "mainWindow")
            {
                form.MinimumSize = new Size(750, 600);
            }
        }

        /**
         * Set the style for the control items
         */
        public void SetControlStyles(ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                // Define for a custom style
                if (control.AccessibleDescription != null && control.AccessibleDescription.ToString() == "custom")
                {
                    continue;
                }

                // Define the global style now
                if (control is Label)
                {
                    SetLabelStyle((Label) control);
                }
                else if (control is Button)
                {
                    SetButtonStyle((Button) control);
                }
                else if (control is TextBox)
                {
                    SetTextBoxStyle((TextBox) control);
                }
                else if (control is Panel || control is UserControl || control is TableLayoutPanel)
                {
                    SetControlStyles(control.Controls);
                }
                else if (control is DataGridView)
                {
                    SetDataGridView((DataGridView) control);
                }
                else if (control is GroupBox)
                {
                    SetGroupBoxStyle((GroupBox) control);
                    SetControlStyles(control.Controls);
                }
                else if (control is RadioButton)
                {
                    control.ForeColor = Color.White;
                }
                else if (control is CheckBox)
                {
                    control.ForeColor = Color.White;
                }
            }
        }

        /**
         * Set label style
         */
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

        /**
         * Set button style
         */
        private void SetButtonStyle(Button control)
        {
            control.BackColor = Properties.Settings.Default.PrimaryColor;
            control.ForeColor = Properties.Settings.Default.FontColor;
            control.FlatStyle = FlatStyle.Flat;
            control.FlatAppearance.BorderColor = Properties.Settings.Default.PrimaryColor;
            control.FlatAppearance.MouseDownBackColor = Properties.Settings.Default.SecondaryColor;
            control.Font = new Font(Properties.Settings.Default.DefaultFormFont, System.Drawing.FontStyle.Bold);
        }

        /**
         * Set text box style
         */
        private void SetTextBoxStyle(TextBox control)
        {
            control.BorderStyle = BorderStyle.FixedSingle;
        }

        /**
         * Set data grid view style
         */
        private void SetDataGridView(DataGridView control)
        {
            control.BackgroundColor = Properties.Settings.Default.DefaultFormBackgroundColor;
            control.BorderStyle = BorderStyle.None;

            control.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            control.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            control.ColumnHeadersDefaultCellStyle.BackColor = Properties.Settings.Default.PrimaryColor;
            control.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            control.ColumnHeadersDefaultCellStyle.Padding = new Padding(3, 5, 3, 5);
            control.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            control.ColumnHeadersDefaultCellStyle.Font =
                new Font(Properties.Settings.Default.DefaultFormFont, FontStyle.Bold);
            control.EnableHeadersVisualStyles = false;
            control.GridColor = Color.White;
            control.RowHeadersVisible = false;

            control.DefaultCellStyle.BackColor = Color.White;
            control.DefaultCellStyle.Font = Properties.Settings.Default.DefaultFormFont;
            control.DefaultCellStyle.Padding = new Padding(3);
            control.DefaultCellStyle.ForeColor = Properties.Settings.Default.PrimaryColor;
        }

        /**
         * Set group box style
         */
        private void SetGroupBoxStyle(GroupBox control)
        {
            control.ForeColor = Color.White;
        }
    }
}