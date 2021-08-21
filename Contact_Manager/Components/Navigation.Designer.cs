
namespace Contact_Manager.Components
{
    partial class Navigation
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

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.PnlNavigation = new System.Windows.Forms.Panel();
            this.PnlRight = new System.Windows.Forms.Panel();
            this.LblUsername = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LblDashboard = new System.Windows.Forms.Label();
            this.LblCustomers = new System.Windows.Forms.Label();
            this.LblEmployees = new System.Windows.Forms.Label();
            this.LblTrainees = new System.Windows.Forms.Label();
            this.LblUsers = new System.Windows.Forms.Label();
            this.PnlNavigation.SuspendLayout();
            this.PnlRight.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlNavigation
            // 
            this.PnlNavigation.AutoSize = true;
            this.PnlNavigation.Controls.Add(this.LblUsers);
            this.PnlNavigation.Controls.Add(this.LblTrainees);
            this.PnlNavigation.Controls.Add(this.LblEmployees);
            this.PnlNavigation.Controls.Add(this.LblCustomers);
            this.PnlNavigation.Controls.Add(this.LblDashboard);
            this.PnlNavigation.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlNavigation.Location = new System.Drawing.Point(0, 0);
            this.PnlNavigation.Name = "PnlNavigation";
            this.PnlNavigation.Size = new System.Drawing.Size(375, 50);
            this.PnlNavigation.TabIndex = 0;
            // 
            // PnlRight
            // 
            this.PnlRight.Controls.Add(this.panel1);
            this.PnlRight.Controls.Add(this.LblUsername);
            this.PnlRight.Controls.Add(this.pictureBox1);
            this.PnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.PnlRight.Location = new System.Drawing.Point(426, 0);
            this.PnlRight.Name = "PnlRight";
            this.PnlRight.Size = new System.Drawing.Size(209, 50);
            this.PnlRight.TabIndex = 1;
            // 
            // LblUsername
            // 
            this.LblUsername.AccessibleDescription = "custom";
            this.LblUsername.BackColor = System.Drawing.Color.Transparent;
            this.LblUsername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblUsername.ForeColor = System.Drawing.Color.White;
            this.LblUsername.Location = new System.Drawing.Point(50, 0);
            this.LblUsername.Name = "LblUsername";
            this.LblUsername.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.LblUsername.Size = new System.Drawing.Size(159, 50);
            this.LblUsername.TabIndex = 1;
            this.LblUsername.Text = "USERNAME";
            this.LblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(159, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(50, 50);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::Contact_Manager.Properties.Resources.sign_out;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Padding = new System.Windows.Forms.Padding(14, 17, 17, 17);
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::Contact_Manager.Properties.Resources.User1;
            this.pictureBox1.InitialImage = global::Contact_Manager.Properties.Resources.User;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(7, 10, 7, 10);
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LblDashboard
            // 
            this.LblDashboard.AccessibleDescription = "navItem";
            this.LblDashboard.Dock = System.Windows.Forms.DockStyle.Left;
            this.LblDashboard.Location = new System.Drawing.Point(0, 0);
            this.LblDashboard.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblDashboard.Name = "LblDashboard";
            this.LblDashboard.Size = new System.Drawing.Size(75, 50);
            this.LblDashboard.TabIndex = 0;
            this.LblDashboard.Text = "Dashboard";
            this.LblDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblDashboard.Click += new System.EventHandler(this.LblDashboard_Click);
            // 
            // LblCustomers
            // 
            this.LblCustomers.AccessibleDescription = "navItem";
            this.LblCustomers.Dock = System.Windows.Forms.DockStyle.Left;
            this.LblCustomers.Location = new System.Drawing.Point(75, 0);
            this.LblCustomers.Name = "LblCustomers";
            this.LblCustomers.Size = new System.Drawing.Size(75, 50);
            this.LblCustomers.TabIndex = 1;
            this.LblCustomers.Text = "Kunden";
            this.LblCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblCustomers.Click += new System.EventHandler(this.LblCustomers_Click);
            // 
            // LblEmployees
            // 
            this.LblEmployees.AccessibleDescription = "navItem";
            this.LblEmployees.Dock = System.Windows.Forms.DockStyle.Left;
            this.LblEmployees.Location = new System.Drawing.Point(150, 0);
            this.LblEmployees.Name = "LblEmployees";
            this.LblEmployees.Size = new System.Drawing.Size(75, 50);
            this.LblEmployees.TabIndex = 2;
            this.LblEmployees.Text = "Mitarbeiter";
            this.LblEmployees.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblEmployees.Click += new System.EventHandler(this.LblEmployees_Click);
            // 
            // LblTrainees
            // 
            this.LblTrainees.AccessibleDescription = "navItem";
            this.LblTrainees.Dock = System.Windows.Forms.DockStyle.Left;
            this.LblTrainees.Location = new System.Drawing.Point(225, 0);
            this.LblTrainees.Name = "LblTrainees";
            this.LblTrainees.Size = new System.Drawing.Size(75, 50);
            this.LblTrainees.TabIndex = 3;
            this.LblTrainees.Text = "Lehrlinge";
            this.LblTrainees.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblTrainees.Click += new System.EventHandler(this.LblTrainees_Click);
            // 
            // LblUsers
            // 
            this.LblUsers.AccessibleDescription = "navItem";
            this.LblUsers.Dock = System.Windows.Forms.DockStyle.Left;
            this.LblUsers.Location = new System.Drawing.Point(300, 0);
            this.LblUsers.Name = "LblUsers";
            this.LblUsers.Size = new System.Drawing.Size(75, 50);
            this.LblUsers.TabIndex = 4;
            this.LblUsers.Text = "Benutzer";
            this.LblUsers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblUsers.Click += new System.EventHandler(this.LblUsers_Click);
            // 
            // Navigation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PnlRight);
            this.Controls.Add(this.PnlNavigation);
            this.Name = "Navigation";
            this.Size = new System.Drawing.Size(635, 50);
            this.Load += new System.EventHandler(this.Navigation_Load);
            this.PnlNavigation.ResumeLayout(false);
            this.PnlRight.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlNavigation;
        private System.Windows.Forms.Panel PnlRight;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LblUsername;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label LblDashboard;
        private System.Windows.Forms.Label LblUsers;
        private System.Windows.Forms.Label LblTrainees;
        private System.Windows.Forms.Label LblEmployees;
        private System.Windows.Forms.Label LblCustomers;
    }
}
