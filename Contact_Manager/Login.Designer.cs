
namespace Contact_Manager
{
    partial class Login
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
            this.CmdLogin = new System.Windows.Forms.Button();
            this.TxtUsername = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblTitle
            // 
            this.LblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LblTitle.Location = new System.Drawing.Point(0, 0);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(238, 64);
            this.LblTitle.TabIndex = 3;
            this.LblTitle.Text = "Anmelden";
            this.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblUsername
            // 
            this.LblUsername.AutoSize = true;
            this.LblUsername.Location = new System.Drawing.Point(12, 3);
            this.LblUsername.Name = "LblUsername";
            this.LblUsername.Size = new System.Drawing.Size(75, 13);
            this.LblUsername.TabIndex = 4;
            this.LblUsername.Text = "Benutzername";
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Location = new System.Drawing.Point(12, 3);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(50, 13);
            this.LblPassword.TabIndex = 5;
            this.LblPassword.Text = "Passwort";
            // 
            // CmdLogin
            // 
            this.CmdLogin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CmdLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdLogin.Location = new System.Drawing.Point(0, 170);
            this.CmdLogin.Name = "CmdLogin";
            this.CmdLogin.Size = new System.Drawing.Size(238, 36);
            this.CmdLogin.TabIndex = 3;
            this.CmdLogin.Text = "Anmelden";
            this.CmdLogin.UseVisualStyleBackColor = true;
            this.CmdLogin.Click += new System.EventHandler(this.CmdLogin_Click);
            // 
            // TxtUsername
            // 
            this.TxtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtUsername.Location = new System.Drawing.Point(15, 19);
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(203, 20);
            this.TxtUsername.TabIndex = 1;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(15, 19);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '*';
            this.TxtPassword.Size = new System.Drawing.Size(203, 20);
            this.TxtPassword.TabIndex = 2;
            this.TxtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtPassword_KeyDown);
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.LblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 64);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.TxtUsername);
            this.panel2.Controls.Add(this.LblUsername);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 64);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.panel2.Size = new System.Drawing.Size(238, 52);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.Controls.Add(this.LblPassword);
            this.panel3.Controls.Add(this.TxtPassword);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 116);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.panel3.Size = new System.Drawing.Size(238, 52);
            this.panel3.TabIndex = 8;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 206);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CmdLogin);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anmelden";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Label LblUsername;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.Button CmdLogin;
        private System.Windows.Forms.TextBox TxtUsername;
        private System.Windows.Forms.MaskedTextBox TxtPassword;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}