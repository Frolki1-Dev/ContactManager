
namespace Contact_Manager
{
    partial class Template
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PnlNavigation = new System.Windows.Forms.Panel();
            this.CmdUsers = new System.Windows.Forms.Button();
            this.CmdLogout = new System.Windows.Forms.Button();
            this.CmdEmployees = new System.Windows.Forms.Button();
            this.CmdCustomers = new System.Windows.Forms.Button();
            this.CmdDashboard = new System.Windows.Forms.Button();
            this.PnlLogo = new System.Windows.Forms.Panel();
            this.LblWelcomeUser = new System.Windows.Forms.Label();
            this.PicLogo = new System.Windows.Forms.PictureBox();
            this.PnlPage = new System.Windows.Forms.Panel();
            this.PnlTitle = new System.Windows.Forms.Panel();
            this.LblPageTitle = new System.Windows.Forms.Label();
            this.PnlPageContent = new System.Windows.Forms.Panel();
            this.CmdCreateResource = new System.Windows.Forms.Button();
            this.PnlNavigation.SuspendLayout();
            this.PnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).BeginInit();
            this.PnlPage.SuspendLayout();
            this.PnlTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlNavigation
            // 
            this.PnlNavigation.BackColor = global::Contact_Manager.Properties.Settings.Default.PrimaryColor;
            this.PnlNavigation.Controls.Add(this.CmdUsers);
            this.PnlNavigation.Controls.Add(this.CmdLogout);
            this.PnlNavigation.Controls.Add(this.CmdEmployees);
            this.PnlNavigation.Controls.Add(this.CmdCustomers);
            this.PnlNavigation.Controls.Add(this.CmdDashboard);
            this.PnlNavigation.Controls.Add(this.PnlLogo);
            this.PnlNavigation.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlNavigation.Location = new System.Drawing.Point(0, 0);
            this.PnlNavigation.Name = "PnlNavigation";
            this.PnlNavigation.Size = new System.Drawing.Size(300, 935);
            this.PnlNavigation.TabIndex = 0;
            // 
            // CmdUsers
            // 
            this.CmdUsers.BackColor = System.Drawing.Color.Transparent;
            this.CmdUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.CmdUsers.FlatAppearance.BorderSize = 0;
            this.CmdUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdUsers.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdUsers.ForeColor = System.Drawing.Color.White;
            this.CmdUsers.Location = new System.Drawing.Point(0, 414);
            this.CmdUsers.Margin = new System.Windows.Forms.Padding(0);
            this.CmdUsers.Name = "CmdUsers";
            this.CmdUsers.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.CmdUsers.Size = new System.Drawing.Size(300, 70);
            this.CmdUsers.TabIndex = 5;
            this.CmdUsers.Text = "Benutzerstamm";
            this.CmdUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CmdUsers.UseVisualStyleBackColor = false;
            this.CmdUsers.Click += new System.EventHandler(this.CmdUsers_Click);
            // 
            // CmdLogout
            // 
            this.CmdLogout.BackColor = System.Drawing.Color.Transparent;
            this.CmdLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CmdLogout.FlatAppearance.BorderSize = 0;
            this.CmdLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdLogout.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdLogout.ForeColor = System.Drawing.Color.White;
            this.CmdLogout.Location = new System.Drawing.Point(0, 865);
            this.CmdLogout.Margin = new System.Windows.Forms.Padding(0);
            this.CmdLogout.Name = "CmdLogout";
            this.CmdLogout.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.CmdLogout.Size = new System.Drawing.Size(300, 70);
            this.CmdLogout.TabIndex = 4;
            this.CmdLogout.Text = "Abmelden";
            this.CmdLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CmdLogout.UseVisualStyleBackColor = false;
            this.CmdLogout.Click += new System.EventHandler(this.CmdLogout_Click);
            // 
            // CmdEmployees
            // 
            this.CmdEmployees.BackColor = System.Drawing.Color.Transparent;
            this.CmdEmployees.Dock = System.Windows.Forms.DockStyle.Top;
            this.CmdEmployees.FlatAppearance.BorderSize = 0;
            this.CmdEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdEmployees.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdEmployees.ForeColor = System.Drawing.Color.White;
            this.CmdEmployees.Location = new System.Drawing.Point(0, 344);
            this.CmdEmployees.Margin = new System.Windows.Forms.Padding(0);
            this.CmdEmployees.Name = "CmdEmployees";
            this.CmdEmployees.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.CmdEmployees.Size = new System.Drawing.Size(300, 70);
            this.CmdEmployees.TabIndex = 3;
            this.CmdEmployees.Text = "Mitarbeiterstamm";
            this.CmdEmployees.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CmdEmployees.UseVisualStyleBackColor = false;
            // 
            // CmdCustomers
            // 
            this.CmdCustomers.AutoSize = true;
            this.CmdCustomers.BackColor = System.Drawing.Color.Transparent;
            this.CmdCustomers.Dock = System.Windows.Forms.DockStyle.Top;
            this.CmdCustomers.FlatAppearance.BorderSize = 0;
            this.CmdCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdCustomers.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdCustomers.ForeColor = System.Drawing.Color.White;
            this.CmdCustomers.Location = new System.Drawing.Point(0, 274);
            this.CmdCustomers.Margin = new System.Windows.Forms.Padding(0);
            this.CmdCustomers.Name = "CmdCustomers";
            this.CmdCustomers.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.CmdCustomers.Size = new System.Drawing.Size(300, 70);
            this.CmdCustomers.TabIndex = 2;
            this.CmdCustomers.Text = "Kundenstamm";
            this.CmdCustomers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CmdCustomers.UseVisualStyleBackColor = false;
            // 
            // CmdDashboard
            // 
            this.CmdDashboard.AutoSize = true;
            this.CmdDashboard.BackColor = System.Drawing.Color.Transparent;
            this.CmdDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.CmdDashboard.FlatAppearance.BorderSize = 0;
            this.CmdDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdDashboard.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdDashboard.ForeColor = System.Drawing.Color.White;
            this.CmdDashboard.Location = new System.Drawing.Point(0, 204);
            this.CmdDashboard.Margin = new System.Windows.Forms.Padding(0);
            this.CmdDashboard.Name = "CmdDashboard";
            this.CmdDashboard.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.CmdDashboard.Size = new System.Drawing.Size(300, 70);
            this.CmdDashboard.TabIndex = 1;
            this.CmdDashboard.Text = "Dashboard";
            this.CmdDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CmdDashboard.UseVisualStyleBackColor = false;
            this.CmdDashboard.Click += new System.EventHandler(this.CmdDashboard_Click);
            // 
            // PnlLogo
            // 
            this.PnlLogo.AutoSize = true;
            this.PnlLogo.Controls.Add(this.LblWelcomeUser);
            this.PnlLogo.Controls.Add(this.PicLogo);
            this.PnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlLogo.Location = new System.Drawing.Point(0, 0);
            this.PnlLogo.Name = "PnlLogo";
            this.PnlLogo.Padding = new System.Windows.Forms.Padding(20);
            this.PnlLogo.Size = new System.Drawing.Size(300, 204);
            this.PnlLogo.TabIndex = 0;
            // 
            // LblWelcomeUser
            // 
            this.LblWelcomeUser.BackColor = System.Drawing.Color.Transparent;
            this.LblWelcomeUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblWelcomeUser.Font = new System.Drawing.Font("Nirmala UI", 14F);
            this.LblWelcomeUser.ForeColor = System.Drawing.Color.White;
            this.LblWelcomeUser.Location = new System.Drawing.Point(20, 134);
            this.LblWelcomeUser.Name = "LblWelcomeUser";
            this.LblWelcomeUser.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.LblWelcomeUser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblWelcomeUser.Size = new System.Drawing.Size(260, 50);
            this.LblWelcomeUser.TabIndex = 1;
            this.LblWelcomeUser.Text = "Hallo, USERNAME";
            this.LblWelcomeUser.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PicLogo
            // 
            this.PicLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PicLogo.Image = global::Contact_Manager.Properties.Resources.LogoWhiteWithoutBackground;
            this.PicLogo.Location = new System.Drawing.Point(20, 20);
            this.PicLogo.Name = "PicLogo";
            this.PicLogo.Size = new System.Drawing.Size(260, 114);
            this.PicLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicLogo.TabIndex = 0;
            this.PicLogo.TabStop = false;
            // 
            // PnlPage
            // 
            this.PnlPage.BackColor = System.Drawing.Color.Transparent;
            this.PnlPage.Controls.Add(this.PnlPageContent);
            this.PnlPage.Controls.Add(this.PnlTitle);
            this.PnlPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlPage.Location = new System.Drawing.Point(300, 0);
            this.PnlPage.Name = "PnlPage";
            this.PnlPage.Size = new System.Drawing.Size(954, 935);
            this.PnlPage.TabIndex = 1;
            // 
            // PnlTitle
            // 
            this.PnlTitle.Controls.Add(this.CmdCreateResource);
            this.PnlTitle.Controls.Add(this.LblPageTitle);
            this.PnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTitle.Location = new System.Drawing.Point(0, 0);
            this.PnlTitle.Name = "PnlTitle";
            this.PnlTitle.Size = new System.Drawing.Size(954, 100);
            this.PnlTitle.TabIndex = 0;
            // 
            // LblPageTitle
            // 
            this.LblPageTitle.BackColor = System.Drawing.Color.Transparent;
            this.LblPageTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblPageTitle.Font = new System.Drawing.Font("Nirmala UI", 20F, System.Drawing.FontStyle.Bold);
            this.LblPageTitle.ForeColor = global::Contact_Manager.Properties.Settings.Default.PrimaryColor;
            this.LblPageTitle.Location = new System.Drawing.Point(0, 0);
            this.LblPageTitle.Margin = new System.Windows.Forms.Padding(0);
            this.LblPageTitle.Name = "LblPageTitle";
            this.LblPageTitle.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.LblPageTitle.Size = new System.Drawing.Size(954, 100);
            this.LblPageTitle.TabIndex = 0;
            this.LblPageTitle.Text = "Page Title";
            this.LblPageTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PnlPageContent
            // 
            this.PnlPageContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlPageContent.Location = new System.Drawing.Point(0, 100);
            this.PnlPageContent.Name = "PnlPageContent";
            this.PnlPageContent.Size = new System.Drawing.Size(954, 835);
            this.PnlPageContent.TabIndex = 1;
            // 
            // CmdCreateResource
            // 
            this.CmdCreateResource.Location = new System.Drawing.Point(844, 40);
            this.CmdCreateResource.Name = "CmdCreateResource";
            this.CmdCreateResource.Size = new System.Drawing.Size(98, 32);
            this.CmdCreateResource.TabIndex = 1;
            this.CmdCreateResource.Text = "Erstellen";
            this.CmdCreateResource.UseVisualStyleBackColor = true;
            this.CmdCreateResource.Click += new System.EventHandler(this.CmdCreateResource_Click);
            // 
            // Template
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::Contact_Manager.Properties.Settings.Default.DefaultFormBackgroundColor;
            this.ClientSize = new System.Drawing.Size(1254, 935);
            this.Controls.Add(this.PnlPage);
            this.Controls.Add(this.PnlNavigation);
            this.DataBindings.Add(new System.Windows.Forms.Binding("StartPosition", global::Contact_Manager.Properties.Settings.Default, "DefaultStartPosition", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Font = global::Contact_Manager.Properties.Settings.Default.DefaultFormFont;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Template";
            this.ShowIcon = false;
            this.StartPosition = global::Contact_Manager.Properties.Settings.Default.DefaultStartPosition;
            this.Load += new System.EventHandler(this.Template_Load);
            this.PnlNavigation.ResumeLayout(false);
            this.PnlNavigation.PerformLayout();
            this.PnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).EndInit();
            this.PnlPage.ResumeLayout(false);
            this.PnlTitle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlNavigation;
        private System.Windows.Forms.Panel PnlLogo;
        private System.Windows.Forms.PictureBox PicLogo;
        private System.Windows.Forms.Button CmdLogout;
        private System.Windows.Forms.Button CmdEmployees;
        private System.Windows.Forms.Button CmdCustomers;
        private System.Windows.Forms.Button CmdDashboard;
        private System.Windows.Forms.Label LblWelcomeUser;
        private System.Windows.Forms.Panel PnlPage;
        private System.Windows.Forms.Panel PnlTitle;
        private System.Windows.Forms.Label LblPageTitle;
        private System.Windows.Forms.Button CmdUsers;
        private System.Windows.Forms.Panel PnlPageContent;
        private System.Windows.Forms.Button CmdCreateResource;
    }
}