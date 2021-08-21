
namespace Contact_Manager.Partials.Dialog
{
    partial class CustomerDialog
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
            this.DtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.CmbCustomerType = new System.Windows.Forms.ComboBox();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.txtPhoneCompany = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CmbNationality = new System.Windows.Forms.ComboBox();
            this.txtZipCode = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhonePrivate = new System.Windows.Forms.TextBox();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.txtSurName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.rbOther = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.CmbTitle = new System.Windows.Forms.ComboBox();
            this.CmbSalutation = new System.Windows.Forms.ComboBox();
            this.btnCompanyDelete = new System.Windows.Forms.Button();
            this.btnCompanySave = new System.Windows.Forms.Button();
            this.txtCompanyContactEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCompanyHistoryData = new System.Windows.Forms.TextBox();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.ChkStatus = new System.Windows.Forms.CheckBox();
            this.BtnAddNote = new System.Windows.Forms.Button();
            this.btnDeleteNote = new System.Windows.Forms.Button();
            this.txtAddNote = new System.Windows.Forms.TextBox();
            this.PnlNotes = new System.Windows.Forms.Panel();
            this.dataGridNotes = new System.Windows.Forms.DataGridView();
            this.PnlNotes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNotes)).BeginInit();
            this.SuspendLayout();
            // 
            // DtpDateOfBirth
            // 
            this.DtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpDateOfBirth.Location = new System.Drawing.Point(142, 273);
            this.DtpDateOfBirth.Name = "DtpDateOfBirth";
            this.DtpDateOfBirth.Size = new System.Drawing.Size(121, 20);
            this.DtpDateOfBirth.TabIndex = 78;
            // 
            // CmbCustomerType
            // 
            this.CmbCustomerType.AutoCompleteCustomSource.AddRange(new string[] {
            "5%",
            "10%",
            "15%",
            "20%",
            "25%",
            "30%",
            "35%",
            "40%",
            "45%",
            "50%",
            "55%",
            "60%",
            "65%",
            "70%",
            "75%",
            "80%",
            "85%",
            "90%",
            "95%",
            "100%"});
            this.CmbCustomerType.FormattingEnabled = true;
            this.CmbCustomerType.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E"});
            this.CmbCustomerType.Location = new System.Drawing.Point(139, 48);
            this.CmbCustomerType.Name = "CmbCustomerType";
            this.CmbCustomerType.Size = new System.Drawing.Size(121, 21);
            this.CmbCustomerType.TabIndex = 77;
            this.CmbCustomerType.Text = "Kundentyp";
            // 
            // txtFax
            // 
            this.txtFax.Location = new System.Drawing.Point(139, 194);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(120, 20);
            this.txtFax.TabIndex = 76;
            this.txtFax.Text = "Fax Nummer";
            // 
            // txtPhoneCompany
            // 
            this.txtPhoneCompany.Location = new System.Drawing.Point(14, 194);
            this.txtPhoneCompany.Name = "txtPhoneCompany";
            this.txtPhoneCompany.Size = new System.Drawing.Size(118, 20);
            this.txtPhoneCompany.TabIndex = 75;
            this.txtPhoneCompany.Text = "Telefon Geschäft";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(277, 13);
            this.label2.TabIndex = 74;
            this.label2.Text = "___Notizen____________________________________";
            // 
            // CmbNationality
            // 
            this.CmbNationality.FormattingEnabled = true;
            this.CmbNationality.Location = new System.Drawing.Point(14, 271);
            this.CmbNationality.Name = "CmbNationality";
            this.CmbNationality.Size = new System.Drawing.Size(120, 21);
            this.CmbNationality.TabIndex = 73;
            this.CmbNationality.Text = "Nationalität";
            // 
            // txtZipCode
            // 
            this.txtZipCode.Location = new System.Drawing.Point(14, 246);
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(118, 20);
            this.txtZipCode.TabIndex = 72;
            this.txtZipCode.Text = "PLZ";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(140, 220);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(120, 20);
            this.txtCity.TabIndex = 71;
            this.txtCity.Text = "Ort";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(16, 220);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(118, 20);
            this.txtAddress.TabIndex = 70;
            this.txtAddress.Text = "Adresse";
            // 
            // txtPhonePrivate
            // 
            this.txtPhonePrivate.Location = new System.Drawing.Point(14, 168);
            this.txtPhonePrivate.Name = "txtPhonePrivate";
            this.txtPhonePrivate.Size = new System.Drawing.Size(118, 20);
            this.txtPhonePrivate.TabIndex = 69;
            this.txtPhonePrivate.Text = "Telefon Privat";
            // 
            // txtMobile
            // 
            this.txtMobile.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtMobile.Location = new System.Drawing.Point(138, 167);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(121, 20);
            this.txtMobile.TabIndex = 68;
            this.txtMobile.Text = "Handynummer";
            // 
            // txtSurName
            // 
            this.txtSurName.Location = new System.Drawing.Point(138, 141);
            this.txtSurName.Name = "txtSurName";
            this.txtSurName.Size = new System.Drawing.Size(121, 20);
            this.txtSurName.TabIndex = 67;
            this.txtSurName.Text = "Nachname";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(14, 142);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(118, 20);
            this.txtFirstName.TabIndex = 66;
            this.txtFirstName.Text = "Vorname";
            // 
            // rbOther
            // 
            this.rbOther.AutoSize = true;
            this.rbOther.Location = new System.Drawing.Point(195, 118);
            this.rbOther.Name = "rbOther";
            this.rbOther.Size = new System.Drawing.Size(64, 17);
            this.rbOther.TabIndex = 65;
            this.rbOther.TabStop = true;
            this.rbOther.Text = "Anderes";
            this.rbOther.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(103, 118);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(66, 17);
            this.rbFemale.TabIndex = 64;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Weiblich";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(14, 118);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(68, 17);
            this.rbMale.TabIndex = 63;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Männlich";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // CmbTitle
            // 
            this.CmbTitle.FormattingEnabled = true;
            this.CmbTitle.Items.AddRange(new object[] {
            "Dr.",
            "Dr. Dr.",
            "Dr. hc",
            "Dr.-Ing.",
            "Dr. med. dent.",
            "Dr. med. vet",
            "Dr. phil",
            "Ing.",
            "Notar",
            "Notarin",
            "Prof.",
            "Prof. Dr.",
            "Prof. Dr. med.",
            "Prof. Dr. med. vet",
            "Rechtsanwalt",
            "Rechtsanwältin",
            "Dr. rer. nat.",
            "Dr. jur.",
            "Prof. Dr. rer. nat.",
            "Dr. iur.",
            "Dr. phil. nat.",
            "Dr. rer. pol.",
            "Dr. oec."});
            this.CmbTitle.Location = new System.Drawing.Point(138, 91);
            this.CmbTitle.Name = "CmbTitle";
            this.CmbTitle.Size = new System.Drawing.Size(121, 21);
            this.CmbTitle.TabIndex = 62;
            this.CmbTitle.Text = "Titel";
            // 
            // CmbSalutation
            // 
            this.CmbSalutation.FormattingEnabled = true;
            this.CmbSalutation.Items.AddRange(new object[] {
            "Herr",
            "Frau"});
            this.CmbSalutation.Location = new System.Drawing.Point(15, 91);
            this.CmbSalutation.Name = "CmbSalutation";
            this.CmbSalutation.Size = new System.Drawing.Size(121, 21);
            this.CmbSalutation.TabIndex = 61;
            this.CmbSalutation.Text = "Anrede";
            // 
            // btnCompanyDelete
            // 
            this.btnCompanyDelete.Location = new System.Drawing.Point(145, 356);
            this.btnCompanyDelete.Name = "btnCompanyDelete";
            this.btnCompanyDelete.Size = new System.Drawing.Size(118, 23);
            this.btnCompanyDelete.TabIndex = 60;
            this.btnCompanyDelete.Text = "Eingaben löschen";
            this.btnCompanyDelete.UseVisualStyleBackColor = true;
            this.btnCompanyDelete.Click += new System.EventHandler(this.btnCompanyDelete_Click);
            // 
            // btnCompanySave
            // 
            this.btnCompanySave.Location = new System.Drawing.Point(14, 356);
            this.btnCompanySave.Name = "btnCompanySave";
            this.btnCompanySave.Size = new System.Drawing.Size(118, 23);
            this.btnCompanySave.TabIndex = 59;
            this.btnCompanySave.Text = "Speichern";
            this.btnCompanySave.UseVisualStyleBackColor = true;
            this.btnCompanySave.Click += new System.EventHandler(this.btnCompanySave_Click);
            // 
            // txtCompanyContactEmail
            // 
            this.txtCompanyContactEmail.Location = new System.Drawing.Point(142, 246);
            this.txtCompanyContactEmail.Name = "txtCompanyContactEmail";
            this.txtCompanyContactEmail.Size = new System.Drawing.Size(118, 20);
            this.txtCompanyContactEmail.TabIndex = 58;
            this.txtCompanyContactEmail.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 13);
            this.label1.TabIndex = 56;
            this.label1.Text = "___Firmenkontakt______________________________";
            // 
            // txtCompanyHistoryData
            // 
            this.txtCompanyHistoryData.Location = new System.Drawing.Point(322, 34);
            this.txtCompanyHistoryData.Multiline = true;
            this.txtCompanyHistoryData.Name = "txtCompanyHistoryData";
            this.txtCompanyHistoryData.Size = new System.Drawing.Size(261, 141);
            this.txtCompanyHistoryData.TabIndex = 55;
            // 
            // txtCompany
            // 
            this.txtCompany.Location = new System.Drawing.Point(15, 48);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(118, 20);
            this.txtCompany.TabIndex = 54;
            this.txtCompany.Text = "Firmenname";
            // 
            // ChkStatus
            // 
            this.ChkStatus.AutoSize = true;
            this.ChkStatus.Checked = true;
            this.ChkStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkStatus.Location = new System.Drawing.Point(16, 298);
            this.ChkStatus.Name = "ChkStatus";
            this.ChkStatus.Size = new System.Drawing.Size(93, 17);
            this.ChkStatus.TabIndex = 79;
            this.ChkStatus.Text = "Aktiver Kunde";
            this.ChkStatus.UseVisualStyleBackColor = true;
            // 
            // BtnAddNote
            // 
            this.BtnAddNote.Location = new System.Drawing.Point(13, 181);
            this.BtnAddNote.Name = "BtnAddNote";
            this.BtnAddNote.Size = new System.Drawing.Size(118, 23);
            this.BtnAddNote.TabIndex = 80;
            this.BtnAddNote.Text = "Notiz hinzufügen";
            this.BtnAddNote.UseVisualStyleBackColor = true;
            this.BtnAddNote.Click += new System.EventHandler(this.BtnAddNote_Click);
            // 
            // btnDeleteNote
            // 
            this.btnDeleteNote.Location = new System.Drawing.Point(322, 181);
            this.btnDeleteNote.Name = "btnDeleteNote";
            this.btnDeleteNote.Size = new System.Drawing.Size(118, 23);
            this.btnDeleteNote.TabIndex = 81;
            this.btnDeleteNote.Text = "Notiz löschen";
            this.btnDeleteNote.UseVisualStyleBackColor = true;
            this.btnDeleteNote.Click += new System.EventHandler(this.btnDeleteNote_Click);
            // 
            // txtAddNote
            // 
            this.txtAddNote.Location = new System.Drawing.Point(13, 34);
            this.txtAddNote.Multiline = true;
            this.txtAddNote.Name = "txtAddNote";
            this.txtAddNote.Size = new System.Drawing.Size(291, 141);
            this.txtAddNote.TabIndex = 82;
            this.txtAddNote.Text = "Notizen hier eintragen";
            // 
            // PnlNotes
            // 
            this.PnlNotes.Controls.Add(this.dataGridNotes);
            this.PnlNotes.Controls.Add(this.txtAddNote);
            this.PnlNotes.Controls.Add(this.btnDeleteNote);
            this.PnlNotes.Controls.Add(this.txtCompanyHistoryData);
            this.PnlNotes.Controls.Add(this.BtnAddNote);
            this.PnlNotes.Controls.Add(this.label2);
            this.PnlNotes.Location = new System.Drawing.Point(339, 12);
            this.PnlNotes.Name = "PnlNotes";
            this.PnlNotes.Size = new System.Drawing.Size(617, 449);
            this.PnlNotes.TabIndex = 83;
            // 
            // dataGridNotes
            // 
            this.dataGridNotes.AllowUserToAddRows = false;
            this.dataGridNotes.AllowUserToDeleteRows = false;
            this.dataGridNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridNotes.Location = new System.Drawing.Point(322, 234);
            this.dataGridNotes.Name = "dataGridNotes";
            this.dataGridNotes.ReadOnly = true;
            this.dataGridNotes.Size = new System.Drawing.Size(261, 158);
            this.dataGridNotes.TabIndex = 83;
            this.dataGridNotes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridNotes_CellClick);
            // 
            // CustomerDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 484);
            this.Controls.Add(this.PnlNotes);
            this.Controls.Add(this.ChkStatus);
            this.Controls.Add(this.DtpDateOfBirth);
            this.Controls.Add(this.CmbCustomerType);
            this.Controls.Add(this.txtFax);
            this.Controls.Add(this.txtPhoneCompany);
            this.Controls.Add(this.CmbNationality);
            this.Controls.Add(this.txtZipCode);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtPhonePrivate);
            this.Controls.Add(this.txtMobile);
            this.Controls.Add(this.txtSurName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.rbOther);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.CmbTitle);
            this.Controls.Add(this.CmbSalutation);
            this.Controls.Add(this.btnCompanyDelete);
            this.Controls.Add(this.btnCompanySave);
            this.Controls.Add(this.txtCompanyContactEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCompany);
            this.Name = "CustomerDialog";
            this.Text = "CustomerDialog";
            this.Load += new System.EventHandler(this.CustomerDialog_Load);
            this.PnlNotes.ResumeLayout(false);
            this.PnlNotes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNotes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker DtpDateOfBirth;
        private System.Windows.Forms.ComboBox CmbCustomerType;
        private System.Windows.Forms.TextBox txtFax;
        private System.Windows.Forms.TextBox txtPhoneCompany;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CmbNationality;
        private System.Windows.Forms.TextBox txtZipCode;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhonePrivate;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.TextBox txtSurName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.RadioButton rbOther;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.ComboBox CmbTitle;
        private System.Windows.Forms.ComboBox CmbSalutation;
        private System.Windows.Forms.Button btnCompanyDelete;
        private System.Windows.Forms.Button btnCompanySave;
        private System.Windows.Forms.TextBox txtCompanyContactEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCompanyHistoryData;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.CheckBox ChkStatus;
        private System.Windows.Forms.Button BtnAddNote;
        private System.Windows.Forms.Button btnDeleteNote;
        private System.Windows.Forms.TextBox txtAddNote;
        private System.Windows.Forms.Panel PnlNotes;
        private System.Windows.Forms.DataGridView dataGridNotes;
    }
}