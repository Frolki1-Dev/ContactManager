
namespace Contact_Manager
{
    partial class Frm1
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
            this.tabMitarbeiter = new System.Windows.Forms.TabPage();
            this.tabKunden = new System.Windows.Forms.TabPage();
            this.tabDatenerfassung = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabEmployees = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabCustomers = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabUsers = new System.Windows.Forms.TabPage();
            this.GridViewUsers = new System.Windows.Forms.DataGridView();
            this.tabInsertData = new System.Windows.Forms.TabPage();
            this.CmdCreateUser = new System.Windows.Forms.Button();
            this.btnCreateCustomer = new System.Windows.Forms.Button();
            this.btnCreateEmployee = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabControl1.SuspendLayout();
            this.tabEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewUsers)).BeginInit();
            this.tabInsertData.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMitarbeiter
            // 
            this.tabMitarbeiter.Location = new System.Drawing.Point(4, 22);
            this.tabMitarbeiter.Name = "tabMitarbeiter";
            this.tabMitarbeiter.Padding = new System.Windows.Forms.Padding(3);
            this.tabMitarbeiter.Size = new System.Drawing.Size(768, 306);
            this.tabMitarbeiter.TabIndex = 0;
            this.tabMitarbeiter.Text = "Mitarbeiter";
            this.tabMitarbeiter.UseVisualStyleBackColor = true;
            // 
            // tabKunden
            // 
            this.tabKunden.Location = new System.Drawing.Point(4, 22);
            this.tabKunden.Name = "tabKunden";
            this.tabKunden.Padding = new System.Windows.Forms.Padding(3);
            this.tabKunden.Size = new System.Drawing.Size(768, 306);
            this.tabKunden.TabIndex = 1;
            this.tabKunden.Text = "Kunden";
            this.tabKunden.UseVisualStyleBackColor = true;
            // 
            // tabDatenerfassung
            // 
            this.tabDatenerfassung.Location = new System.Drawing.Point(4, 22);
            this.tabDatenerfassung.Name = "tabDatenerfassung";
            this.tabDatenerfassung.Size = new System.Drawing.Size(768, 306);
            this.tabDatenerfassung.TabIndex = 2;
            this.tabDatenerfassung.Text = "Daten erfassen";
            this.tabDatenerfassung.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabEmployees);
            this.tabControl1.Controls.Add(this.tabCustomers);
            this.tabControl1.Controls.Add(this.tabUsers);
            this.tabControl1.Controls.Add(this.tabInsertData);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabEmployees
            // 
            this.tabEmployees.Controls.Add(this.dataGridView1);
            this.tabEmployees.Location = new System.Drawing.Point(4, 22);
            this.tabEmployees.Name = "tabEmployees";
            this.tabEmployees.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabEmployees.Size = new System.Drawing.Size(768, 400);
            this.tabEmployees.TabIndex = 0;
            this.tabEmployees.Text = "Mitarbeiter";
            this.tabEmployees.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(756, 388);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabCustomers
            // 
            this.tabCustomers.Controls.Add(this.dataGridView2);
            this.tabCustomers.Location = new System.Drawing.Point(4, 22);
            this.tabCustomers.Name = "tabCustomers";
            this.tabCustomers.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabCustomers.Size = new System.Drawing.Size(768, 400);
            this.tabCustomers.TabIndex = 1;
            this.tabCustomers.Text = "Kunden";
            this.tabCustomers.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(756, 388);
            this.dataGridView2.TabIndex = 1;
            // 
            // tabUsers
            // 
            this.tabUsers.Controls.Add(this.GridViewUsers);
            this.tabUsers.Location = new System.Drawing.Point(4, 22);
            this.tabUsers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabUsers.Name = "tabUsers";
            this.tabUsers.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabUsers.Size = new System.Drawing.Size(768, 400);
            this.tabUsers.TabIndex = 3;
            this.tabUsers.Text = "Benutzer";
            this.tabUsers.UseVisualStyleBackColor = true;
            // 
            // GridViewUsers
            // 
            this.GridViewUsers.AllowUserToAddRows = false;
            this.GridViewUsers.AllowUserToDeleteRows = false;
            this.GridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewUsers.Location = new System.Drawing.Point(0, 0);
            this.GridViewUsers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GridViewUsers.Name = "GridViewUsers";
            this.GridViewUsers.RowTemplate.Height = 24;
            this.GridViewUsers.Size = new System.Drawing.Size(770, 402);
            this.GridViewUsers.TabIndex = 0;
            // 
            // tabInsertData
            // 
            this.tabInsertData.Controls.Add(this.CmdCreateUser);
            this.tabInsertData.Controls.Add(this.btnCreateCustomer);
            this.tabInsertData.Controls.Add(this.btnCreateEmployee);
            this.tabInsertData.Location = new System.Drawing.Point(4, 22);
            this.tabInsertData.Name = "tabInsertData";
            this.tabInsertData.Size = new System.Drawing.Size(768, 400);
            this.tabInsertData.TabIndex = 2;
            this.tabInsertData.Text = "Daten erfassen";
            this.tabInsertData.UseVisualStyleBackColor = true;
            // 
            // CmdCreateUser
            // 
            this.CmdCreateUser.Location = new System.Drawing.Point(3, 210);
            this.CmdCreateUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CmdCreateUser.Name = "CmdCreateUser";
            this.CmdCreateUser.Size = new System.Drawing.Size(376, 187);
            this.CmdCreateUser.TabIndex = 2;
            this.CmdCreateUser.Text = "Benutzer erstellen";
            this.CmdCreateUser.UseVisualStyleBackColor = true;
            this.CmdCreateUser.Click += new System.EventHandler(this.CmdCreateUser_Click);
            // 
            // btnCreateCustomer
            // 
            this.btnCreateCustomer.Image = global::Contact_Manager.Properties.Resources.outline_location_city_black_48dp;
            this.btnCreateCustomer.Location = new System.Drawing.Point(384, 3);
            this.btnCreateCustomer.Name = "btnCreateCustomer";
            this.btnCreateCustomer.Size = new System.Drawing.Size(384, 394);
            this.btnCreateCustomer.TabIndex = 1;
            this.btnCreateCustomer.UseVisualStyleBackColor = true;
            this.btnCreateCustomer.Click += new System.EventHandler(this.btnCreateCustomer_Click);
            // 
            // btnCreateEmployee
            // 
            this.btnCreateEmployee.Image = global::Contact_Manager.Properties.Resources.outline_person_add_black_48dp;
            this.btnCreateEmployee.Location = new System.Drawing.Point(3, 3);
            this.btnCreateEmployee.Name = "btnCreateEmployee";
            this.btnCreateEmployee.Size = new System.Drawing.Size(384, 202);
            this.btnCreateEmployee.TabIndex = 0;
            this.btnCreateEmployee.UseVisualStyleBackColor = true;
            this.btnCreateEmployee.Click += new System.EventHandler(this.btnCreateEmployee_Click);
            // 
            // Frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Frm1";
            this.Text = "Contact Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabEmployees.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabCustomers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewUsers)).EndInit();
            this.tabInsertData.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        
        private System.Windows.Forms.TabPage tabKunden;
        private System.Windows.Forms.TabPage tabMitarbeiter;
        private System.Windows.Forms.TabPage tabDatenerfassung;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabEmployees;
        private System.Windows.Forms.TabPage tabCustomers;
        private System.Windows.Forms.TabPage tabInsertData;
        private System.Windows.Forms.Button btnCreateCustomer;
        private System.Windows.Forms.Button btnCreateEmployee;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage tabUsers;
        private System.Windows.Forms.Button CmdCreateUser;
        private System.Windows.Forms.DataGridView GridViewUsers;
    }
}

