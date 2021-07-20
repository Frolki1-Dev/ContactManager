
namespace Contact_Manager.Partials.Dialog
{
    partial class UserDialog
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ChkIsAdmin = new System.Windows.Forms.CheckBox();
            this.ChkActive = new System.Windows.Forms.CheckBox();
            this.LblIsAdmin = new System.Windows.Forms.Label();
            this.LblActive = new System.Windows.Forms.Label();
            this.LblPassword = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.MaskedTextBox();
            this.TxtUsername = new System.Windows.Forms.TextBox();
            this.LblUsername = new System.Windows.Forms.Label();
            this.CmdCreateUser = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ChkIsAdmin);
            this.groupBox1.Controls.Add(this.ChkActive);
            this.groupBox1.Controls.Add(this.LblIsAdmin);
            this.groupBox1.Controls.Add(this.LblActive);
            this.groupBox1.Controls.Add(this.LblPassword);
            this.groupBox1.Controls.Add(this.TxtPassword);
            this.groupBox1.Controls.Add(this.TxtUsername);
            this.groupBox1.Controls.Add(this.LblUsername);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(621, 142);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Benutzerinformationen";
            // 
            // ChkIsAdmin
            // 
            this.ChkIsAdmin.AutoSize = true;
            this.ChkIsAdmin.Location = new System.Drawing.Point(324, 110);
            this.ChkIsAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChkIsAdmin.Name = "ChkIsAdmin";
            this.ChkIsAdmin.Size = new System.Drawing.Size(15, 14);
            this.ChkIsAdmin.TabIndex = 7;
            this.ChkIsAdmin.UseVisualStyleBackColor = true;
            // 
            // ChkActive
            // 
            this.ChkActive.AutoSize = true;
            this.ChkActive.Location = new System.Drawing.Point(16, 110);
            this.ChkActive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChkActive.Name = "ChkActive";
            this.ChkActive.Size = new System.Drawing.Size(15, 14);
            this.ChkActive.TabIndex = 6;
            this.ChkActive.UseVisualStyleBackColor = true;
            // 
            // LblIsAdmin
            // 
            this.LblIsAdmin.AutoSize = true;
            this.LblIsAdmin.Location = new System.Drawing.Point(321, 90);
            this.LblIsAdmin.Name = "LblIsAdmin";
            this.LblIsAdmin.Size = new System.Drawing.Size(83, 16);
            this.LblIsAdmin.TabIndex = 5;
            this.LblIsAdmin.Text = "Ist ein Admin";
            // 
            // LblActive
            // 
            this.LblActive.AutoSize = true;
            this.LblActive.Location = new System.Drawing.Point(13, 90);
            this.LblActive.Name = "LblActive";
            this.LblActive.Size = new System.Drawing.Size(37, 16);
            this.LblActive.TabIndex = 4;
            this.LblActive.Text = "Aktiv";
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Location = new System.Drawing.Point(317, 22);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(63, 16);
            this.LblPassword.TabIndex = 3;
            this.LblPassword.Text = "Passwort";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(317, 41);
            this.TxtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '*';
            this.TxtPassword.Size = new System.Drawing.Size(284, 22);
            this.TxtPassword.TabIndex = 2;
            // 
            // TxtUsername
            // 
            this.TxtUsername.Location = new System.Drawing.Point(13, 42);
            this.TxtUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(256, 22);
            this.TxtUsername.TabIndex = 1;
            // 
            // LblUsername
            // 
            this.LblUsername.AutoSize = true;
            this.LblUsername.Location = new System.Drawing.Point(7, 22);
            this.LblUsername.Name = "LblUsername";
            this.LblUsername.Size = new System.Drawing.Size(94, 16);
            this.LblUsername.TabIndex = 0;
            this.LblUsername.Text = "Benutzername";
            // 
            // CmdCreateUser
            // 
            this.CmdCreateUser.Location = new System.Drawing.Point(13, 332);
            this.CmdCreateUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmdCreateUser.Name = "CmdCreateUser";
            this.CmdCreateUser.Size = new System.Drawing.Size(589, 38);
            this.CmdCreateUser.TabIndex = 3;
            this.CmdCreateUser.Text = "Benutzer anlegen";
            this.CmdCreateUser.UseVisualStyleBackColor = true;
            this.CmdCreateUser.Click += new System.EventHandler(this.CmdCreateUser_Click);
            // 
            // UserDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 394);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CmdCreateUser);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UserDialog";
            this.Text = "UserDialog";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ChkIsAdmin;
        private System.Windows.Forms.CheckBox ChkActive;
        private System.Windows.Forms.Label LblIsAdmin;
        private System.Windows.Forms.Label LblActive;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.MaskedTextBox TxtPassword;
        private System.Windows.Forms.TextBox TxtUsername;
        private System.Windows.Forms.Label LblUsername;
        private System.Windows.Forms.Button CmdCreateUser;
    }
}