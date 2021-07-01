
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
            this.tabCustomers = new System.Windows.Forms.TabPage();
            this.tabInsertData = new System.Windows.Forms.TabPage();
            this.btnCreateCustomer = new System.Windows.Forms.Button();
            this.btnCreateEmployee = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabEmployees.SuspendLayout();
            this.tabCustomers.SuspendLayout();
            this.tabInsertData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
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
            this.tabEmployees.Padding = new System.Windows.Forms.Padding(3);
            this.tabEmployees.Size = new System.Drawing.Size(768, 400);
            this.tabEmployees.TabIndex = 0;
            this.tabEmployees.Text = "Mitarbeiter";
            this.tabEmployees.UseVisualStyleBackColor = true;
            // 
            // tabCustomers
            // 
            this.tabCustomers.Controls.Add(this.dataGridView2);
            this.tabCustomers.Location = new System.Drawing.Point(4, 22);
            this.tabCustomers.Name = "tabCustomers";
            this.tabCustomers.Padding = new System.Windows.Forms.Padding(3);
            this.tabCustomers.Size = new System.Drawing.Size(768, 400);
            this.tabCustomers.TabIndex = 1;
            this.tabCustomers.Text = "Kunden";
            this.tabCustomers.UseVisualStyleBackColor = true;
            // 
            // tabInsertData
            // 
            this.tabInsertData.Controls.Add(this.btnCreateCustomer);
            this.tabInsertData.Controls.Add(this.btnCreateEmployee);
            this.tabInsertData.Location = new System.Drawing.Point(4, 22);
            this.tabInsertData.Name = "tabInsertData";
            this.tabInsertData.Size = new System.Drawing.Size(768, 400);
            this.tabInsertData.TabIndex = 2;
            this.tabInsertData.Text = "Daten erfassen";
            this.tabInsertData.UseVisualStyleBackColor = true;
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
            this.btnCreateEmployee.Size = new System.Drawing.Size(384, 394);
            this.btnCreateEmployee.TabIndex = 0;
            this.btnCreateEmployee.UseVisualStyleBackColor = true;
            this.btnCreateEmployee.Click += new System.EventHandler(this.btnCreateEmployee_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(756, 388);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(756, 388);
            this.dataGridView2.TabIndex = 1;
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
            this.tabCustomers.ResumeLayout(false);
            this.tabInsertData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
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
    }
}

