
namespace Contact_Manager
{
    partial class Welcome
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
            this.LblTitle = new System.Windows.Forms.Label();
            this.LblUsername = new System.Windows.Forms.Label();
            this.LblPassword = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.MaskedTextBox();
            this.TxtUsername = new System.Windows.Forms.TextBox();
            this.LblDatabaseLocation = new System.Windows.Forms.Label();
            this.TxtDatabaseLocation = new System.Windows.Forms.TextBox();
            this.CmdCreateDatabaseAndUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LblTitle.Location = new System.Drawing.Point(9, 9);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(538, 36);
            this.LblTitle.TabIndex = 2;
            this.LblTitle.Text = "Einrichtung Datenbank und Benutzer";
            // 
            // LblUsername
            // 
            this.LblUsername.AutoSize = true;
            this.LblUsername.Location = new System.Drawing.Point(12, 77);
            this.LblUsername.Name = "LblUsername";
            this.LblUsername.Size = new System.Drawing.Size(75, 13);
            this.LblUsername.TabIndex = 3;
            this.LblUsername.Text = "Benutzername";
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Location = new System.Drawing.Point(12, 100);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(50, 13);
            this.LblPassword.TabIndex = 4;
            this.LblPassword.Text = "Passwort";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(106, 100);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '*';
            this.TxtPassword.Size = new System.Drawing.Size(314, 20);
            this.TxtPassword.TabIndex = 2;
            this.TxtPassword.TextChanged += new System.EventHandler(this.keyupEvent);
            // 
            // TxtUsername
            // 
            this.TxtUsername.Location = new System.Drawing.Point(106, 77);
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(314, 20);
            this.TxtUsername.TabIndex = 1;
            this.TxtUsername.TextChanged += new System.EventHandler(this.keyupEvent);
            // 
            // LblDatabaseLocation
            // 
            this.LblDatabaseLocation.AutoSize = true;
            this.LblDatabaseLocation.Location = new System.Drawing.Point(15, 138);
            this.LblDatabaseLocation.Name = "LblDatabaseLocation";
            this.LblDatabaseLocation.Size = new System.Drawing.Size(60, 13);
            this.LblDatabaseLocation.TabIndex = 7;
            this.LblDatabaseLocation.Text = "Datenbank";
            // 
            // TxtDatabaseLocation
            // 
            this.TxtDatabaseLocation.Location = new System.Drawing.Point(106, 138);
            this.TxtDatabaseLocation.Name = "TxtDatabaseLocation";
            this.TxtDatabaseLocation.ReadOnly = true;
            this.TxtDatabaseLocation.Size = new System.Drawing.Size(314, 20);
            this.TxtDatabaseLocation.TabIndex = 8;
            // 
            // CmdCreateDatabaseAndUser
            // 
            this.CmdCreateDatabaseAndUser.Enabled = false;
            this.CmdCreateDatabaseAndUser.Location = new System.Drawing.Point(18, 196);
            this.CmdCreateDatabaseAndUser.Name = "CmdCreateDatabaseAndUser";
            this.CmdCreateDatabaseAndUser.Size = new System.Drawing.Size(523, 34);
            this.CmdCreateDatabaseAndUser.TabIndex = 3;
            this.CmdCreateDatabaseAndUser.Text = "Datenbank und Benutzer erstellen";
            this.CmdCreateDatabaseAndUser.UseVisualStyleBackColor = true;
            this.CmdCreateDatabaseAndUser.Click += new System.EventHandler(this.CmdCreateDatabaseAndUser_Click);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 242);
            this.Controls.Add(this.CmdCreateDatabaseAndUser);
            this.Controls.Add(this.TxtDatabaseLocation);
            this.Controls.Add(this.LblDatabaseLocation);
            this.Controls.Add(this.TxtUsername);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.LblUsername);
            this.Controls.Add(this.LblTitle);
            this.Name = "Welcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Willkommen - Setup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Label LblUsername;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.MaskedTextBox TxtPassword;
        private System.Windows.Forms.TextBox TxtUsername;
        private System.Windows.Forms.Label LblDatabaseLocation;
        private System.Windows.Forms.TextBox TxtDatabaseLocation;
        private System.Windows.Forms.Button CmdCreateDatabaseAndUser;
    }
}