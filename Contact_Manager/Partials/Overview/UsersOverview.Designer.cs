
namespace Contact_Manager.Partials.Overview
{
    partial class UsersOverview
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.DataViewUsers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataViewUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // DataViewUsers
            // 
            this.DataViewUsers.AllowUserToAddRows = false;
            this.DataViewUsers.AllowUserToDeleteRows = false;
            this.DataViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataViewUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataViewUsers.Location = new System.Drawing.Point(0, 0);
            this.DataViewUsers.Name = "DataViewUsers";
            this.DataViewUsers.ReadOnly = true;
            this.DataViewUsers.Size = new System.Drawing.Size(452, 269);
            this.DataViewUsers.TabIndex = 1;
            this.DataViewUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataViewUsers_CellClick);
            this.DataViewUsers.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DataViewUsers_KeyDown);
            // 
            // UsersOverview
            // 
            this.ClientSize = new System.Drawing.Size(452, 269);
            this.Controls.Add(this.DataViewUsers);
            this.Name = "UsersOverview";
            this.Load += new System.EventHandler(this.UsersOverview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataViewUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataViewUsers;
    }
}
