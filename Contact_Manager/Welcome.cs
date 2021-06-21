using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact_Manager
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        /**
         * Only for dev
         */
        private void btnCreateDatabase_Click(object sender, EventArgs e)
        {
            string databaseFile = Path.GetTempPath() + "dev_db.sqlite";

            try
            {
                DatabaseConnection.buildDatabase(databaseFile);

                if(DatabaseConnection.hasActiveConnection())
                {
                    (new Frm1()).Show();
                    this.Hide();
                } else
                {
                    MessageBox.Show("Fehler", "Erstellungsfehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erstellungsfehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
