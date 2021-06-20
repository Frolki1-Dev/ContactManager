namespace Contact_Manager
{
    partial class FormAddCustomer
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
            this.lblPrivate = new System.Windows.Forms.Label();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.txtCompanyAdress = new System.Windows.Forms.TextBox();
            this.txtCompanyZip = new System.Windows.Forms.TextBox();
            this.txtCompanyCity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCompanyContactSurname = new System.Windows.Forms.TextBox();
            this.txtCompanyContactName = new System.Windows.Forms.TextBox();
            this.txtCompanyContactPhone = new System.Windows.Forms.TextBox();
            this.txtCompanyContactEmail = new System.Windows.Forms.TextBox();
            this.btnCompanySave = new System.Windows.Forms.Button();
            this.btnCompanyDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPrivate
            // 
            this.lblPrivate.AutoSize = true;
            this.lblPrivate.Location = new System.Drawing.Point(-3, 0);
            this.lblPrivate.Name = "lblPrivate";
            this.lblPrivate.Size = new System.Drawing.Size(278, 13);
            this.lblPrivate.TabIndex = 17;
            this.lblPrivate.Text = "___Firma______________________________________";
            // 
            // txtCompany
            // 
            this.txtCompany.Location = new System.Drawing.Point(12, 26);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(118, 20);
            this.txtCompany.TabIndex = 18;
            this.txtCompany.Text = "Firmenname";
            // 
            // txtCompanyAdress
            // 
            this.txtCompanyAdress.Location = new System.Drawing.Point(139, 26);
            this.txtCompanyAdress.Name = "txtCompanyAdress";
            this.txtCompanyAdress.Size = new System.Drawing.Size(118, 20);
            this.txtCompanyAdress.TabIndex = 19;
            this.txtCompanyAdress.Text = "Adresse";
            // 
            // txtCompanyZip
            // 
            this.txtCompanyZip.Location = new System.Drawing.Point(12, 52);
            this.txtCompanyZip.Name = "txtCompanyZip";
            this.txtCompanyZip.Size = new System.Drawing.Size(118, 20);
            this.txtCompanyZip.TabIndex = 20;
            this.txtCompanyZip.Text = "PLZ";
            // 
            // txtCompanyCity
            // 
            this.txtCompanyCity.Location = new System.Drawing.Point(139, 52);
            this.txtCompanyCity.Name = "txtCompanyCity";
            this.txtCompanyCity.Size = new System.Drawing.Size(117, 20);
            this.txtCompanyCity.TabIndex = 21;
            this.txtCompanyCity.Text = "Ort";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-3, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "___Firmenkontakt______________________________";
            // 
            // txtCompanyContactSurname
            // 
            this.txtCompanyContactSurname.Location = new System.Drawing.Point(12, 92);
            this.txtCompanyContactSurname.Name = "txtCompanyContactSurname";
            this.txtCompanyContactSurname.Size = new System.Drawing.Size(118, 20);
            this.txtCompanyContactSurname.TabIndex = 23;
            this.txtCompanyContactSurname.Text = "Name";
            // 
            // txtCompanyContactName
            // 
            this.txtCompanyContactName.Location = new System.Drawing.Point(139, 92);
            this.txtCompanyContactName.Name = "txtCompanyContactName";
            this.txtCompanyContactName.Size = new System.Drawing.Size(117, 20);
            this.txtCompanyContactName.TabIndex = 24;
            this.txtCompanyContactName.Text = "Vorname";
            // 
            // txtCompanyContactPhone
            // 
            this.txtCompanyContactPhone.Location = new System.Drawing.Point(12, 118);
            this.txtCompanyContactPhone.Name = "txtCompanyContactPhone";
            this.txtCompanyContactPhone.Size = new System.Drawing.Size(118, 20);
            this.txtCompanyContactPhone.TabIndex = 25;
            this.txtCompanyContactPhone.Text = "Telefonnummer";
            // 
            // txtCompanyContactEmail
            // 
            this.txtCompanyContactEmail.Location = new System.Drawing.Point(139, 118);
            this.txtCompanyContactEmail.Name = "txtCompanyContactEmail";
            this.txtCompanyContactEmail.Size = new System.Drawing.Size(118, 20);
            this.txtCompanyContactEmail.TabIndex = 26;
            this.txtCompanyContactEmail.Text = "Email";
            // 
            // btnCompanySave
            // 
            this.btnCompanySave.Location = new System.Drawing.Point(12, 144);
            this.btnCompanySave.Name = "btnCompanySave";
            this.btnCompanySave.Size = new System.Drawing.Size(118, 23);
            this.btnCompanySave.TabIndex = 27;
            this.btnCompanySave.Text = "Speichern";
            this.btnCompanySave.UseVisualStyleBackColor = true;
            // 
            // btnCompanyDelete
            // 
            this.btnCompanyDelete.Location = new System.Drawing.Point(139, 144);
            this.btnCompanyDelete.Name = "btnCompanyDelete";
            this.btnCompanyDelete.Size = new System.Drawing.Size(118, 23);
            this.btnCompanyDelete.TabIndex = 28;
            this.btnCompanyDelete.Text = "Eingaben löschen";
            this.btnCompanyDelete.UseVisualStyleBackColor = true;
            this.btnCompanyDelete.Click += new System.EventHandler(this.btnCompanyDelete_Click);
            // 
            // FormAddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 195);
            this.Controls.Add(this.btnCompanyDelete);
            this.Controls.Add(this.btnCompanySave);
            this.Controls.Add(this.txtCompanyContactEmail);
            this.Controls.Add(this.txtCompanyContactPhone);
            this.Controls.Add(this.txtCompanyContactName);
            this.Controls.Add(this.txtCompanyContactSurname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCompanyCity);
            this.Controls.Add(this.txtCompanyZip);
            this.Controls.Add(this.txtCompanyAdress);
            this.Controls.Add(this.txtCompany);
            this.Controls.Add(this.lblPrivate);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddCustomer";
            this.Text = "addCustomer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrivate;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.TextBox txtCompanyAdress;
        private System.Windows.Forms.TextBox txtCompanyZip;
        private System.Windows.Forms.TextBox txtCompanyCity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCompanyContactSurname;
        private System.Windows.Forms.TextBox txtCompanyContactName;
        private System.Windows.Forms.TextBox txtCompanyContactPhone;
        private System.Windows.Forms.TextBox txtCompanyContactEmail;
        private System.Windows.Forms.Button btnCompanySave;
        private System.Windows.Forms.Button btnCompanyDelete;
    }
}