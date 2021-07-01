namespace Contact_Manager
{
    partial class FormAddEmployee
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
            this.cmbSalutation = new System.Windows.Forms.ComboBox();
            this.cmbTitle = new System.Windows.Forms.ComboBox();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbOther = new System.Windows.Forms.RadioButton();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtHandy = new System.Windows.Forms.TextBox();
            this.txtAhv = new System.Windows.Forms.TextBox();
            this.txtPrivatePhone = new System.Windows.Forms.TextBox();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtZipCode = new System.Windows.Forms.TextBox();
            this.cbNationality = new System.Windows.Forms.ComboBox();
            this.lblBusiness = new System.Windows.Forms.Label();
            this.lblPrivate = new System.Windows.Forms.Label();
            this.txtEmployeeNumber = new System.Windows.Forms.TextBox();
            this.txtDepartement = new System.Windows.Forms.TextBox();
            this.txtBusinessPhone = new System.Windows.Forms.TextBox();
            this.txtBusinessFax = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.cbWorkTimePercentage = new System.Windows.Forms.ComboBox();
            this.dtpEntryDate = new System.Windows.Forms.DateTimePicker();
            this.dtpWithdrawlDate = new System.Windows.Forms.DateTimePicker();
            this.txtWork = new System.Windows.Forms.TextBox();
            this.cbManagementLevel = new System.Windows.Forms.ComboBox();
            this.cbApprenticeYears = new System.Windows.Forms.ComboBox();
            this.cbCurrentApprenticeYear = new System.Windows.Forms.ComboBox();
            this.chckbxActive = new System.Windows.Forms.CheckBox();
            this.chckbxApprentice = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbSalutation
            // 
            this.cmbSalutation.FormattingEnabled = true;
            this.cmbSalutation.Items.AddRange(new object[] {
            "Herr",
            "Frau"});
            this.cmbSalutation.Location = new System.Drawing.Point(9, 16);
            this.cmbSalutation.Name = "cmbSalutation";
            this.cmbSalutation.Size = new System.Drawing.Size(121, 21);
            this.cmbSalutation.TabIndex = 0;
            this.cmbSalutation.Text = "Anrede";
            // 
            // cmbTitle
            // 
            this.cmbTitle.FormattingEnabled = true;
            this.cmbTitle.Items.AddRange(new object[] {
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
            this.cmbTitle.Location = new System.Drawing.Point(132, 16);
            this.cmbTitle.Name = "cmbTitle";
            this.cmbTitle.Size = new System.Drawing.Size(121, 21);
            this.cmbTitle.TabIndex = 1;
            this.cmbTitle.Text = "Titel";
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(5, 43);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(68, 17);
            this.rbMale.TabIndex = 2;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Männlich";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(97, 43);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(66, 17);
            this.rbFemale.TabIndex = 3;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Weiblich";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbOther
            // 
            this.rbOther.AutoSize = true;
            this.rbOther.Location = new System.Drawing.Point(189, 43);
            this.rbOther.Name = "rbOther";
            this.rbOther.Size = new System.Drawing.Size(64, 17);
            this.rbOther.TabIndex = 4;
            this.rbOther.TabStop = true;
            this.rbOther.Text = "Anderes";
            this.rbOther.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(8, 66);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(118, 20);
            this.txtName.TabIndex = 5;
            this.txtName.Text = "Vorname";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(132, 66);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(121, 20);
            this.txtSurname.TabIndex = 6;
            this.txtSurname.Text = "Nachname";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(132, 119);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // txtHandy
            // 
            this.txtHandy.Location = new System.Drawing.Point(132, 92);
            this.txtHandy.Name = "txtHandy";
            this.txtHandy.Size = new System.Drawing.Size(121, 20);
            this.txtHandy.TabIndex = 8;
            this.txtHandy.Text = "Handynummer";
            // 
            // txtAhv
            // 
            this.txtAhv.Location = new System.Drawing.Point(9, 119);
            this.txtAhv.Name = "txtAhv";
            this.txtAhv.Size = new System.Drawing.Size(117, 20);
            this.txtAhv.TabIndex = 9;
            this.txtAhv.Text = "AHV Nummer";
            // 
            // txtPrivatePhone
            // 
            this.txtPrivatePhone.Location = new System.Drawing.Point(8, 93);
            this.txtPrivatePhone.Name = "txtPrivatePhone";
            this.txtPrivatePhone.Size = new System.Drawing.Size(118, 20);
            this.txtPrivatePhone.TabIndex = 10;
            this.txtPrivatePhone.Text = "Telefon Privat";
            // 
            // txtAdress
            // 
            this.txtAdress.Location = new System.Drawing.Point(8, 145);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(118, 20);
            this.txtAdress.TabIndex = 11;
            this.txtAdress.Text = "Adresse";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(133, 146);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(120, 20);
            this.txtCity.TabIndex = 12;
            this.txtCity.Text = "Ort";
            // 
            // txtZipCode
            // 
            this.txtZipCode.Location = new System.Drawing.Point(8, 172);
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(118, 20);
            this.txtZipCode.TabIndex = 13;
            this.txtZipCode.Text = "PLZ";
            // 
            // cbNationality
            // 
            this.cbNationality.FormattingEnabled = true;
            this.cbNationality.Location = new System.Drawing.Point(133, 172);
            this.cbNationality.Name = "cbNationality";
            this.cbNationality.Size = new System.Drawing.Size(120, 21);
            this.cbNationality.TabIndex = 14;
            this.cbNationality.Text = "Nationalität";
            // 
            // lblBusiness
            // 
            this.lblBusiness.AutoSize = true;
            this.lblBusiness.Location = new System.Drawing.Point(-5, 196);
            this.lblBusiness.Name = "lblBusiness";
            this.lblBusiness.Size = new System.Drawing.Size(282, 13);
            this.lblBusiness.TabIndex = 15;
            this.lblBusiness.Text = "___Geschäftlich_________________________________";
            // 
            // lblPrivate
            // 
            this.lblPrivate.AutoSize = true;
            this.lblPrivate.Location = new System.Drawing.Point(-5, 0);
            this.lblPrivate.Name = "lblPrivate";
            this.lblPrivate.Size = new System.Drawing.Size(280, 13);
            this.lblPrivate.TabIndex = 16;
            this.lblPrivate.Text = "___Privat______________________________________";
            // 
            // txtEmployeeNumber
            // 
            this.txtEmployeeNumber.Location = new System.Drawing.Point(8, 212);
            this.txtEmployeeNumber.Name = "txtEmployeeNumber";
            this.txtEmployeeNumber.Size = new System.Drawing.Size(118, 20);
            this.txtEmployeeNumber.TabIndex = 17;
            this.txtEmployeeNumber.Text = "MA Nummer";
            // 
            // txtDepartement
            // 
            this.txtDepartement.Location = new System.Drawing.Point(132, 211);
            this.txtDepartement.Name = "txtDepartement";
            this.txtDepartement.Size = new System.Drawing.Size(121, 20);
            this.txtDepartement.TabIndex = 18;
            this.txtDepartement.Text = "Abteilung";
            // 
            // txtBusinessPhone
            // 
            this.txtBusinessPhone.Location = new System.Drawing.Point(8, 239);
            this.txtBusinessPhone.Name = "txtBusinessPhone";
            this.txtBusinessPhone.Size = new System.Drawing.Size(118, 20);
            this.txtBusinessPhone.TabIndex = 19;
            this.txtBusinessPhone.Text = "Telefon Geschäft";
            // 
            // txtBusinessFax
            // 
            this.txtBusinessFax.Location = new System.Drawing.Point(133, 238);
            this.txtBusinessFax.Name = "txtBusinessFax";
            this.txtBusinessFax.Size = new System.Drawing.Size(120, 20);
            this.txtBusinessFax.TabIndex = 20;
            this.txtBusinessFax.Text = "Fax Nummer";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(8, 266);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(118, 20);
            this.txtEmail.TabIndex = 21;
            this.txtEmail.Text = "Email Adresse";
            // 
            // cbWorkTimePercentage
            // 
            this.cbWorkTimePercentage.AutoCompleteCustomSource.AddRange(new string[] {
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
            this.cbWorkTimePercentage.FormattingEnabled = true;
            this.cbWorkTimePercentage.Items.AddRange(new object[] {
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
            "100%"});
            this.cbWorkTimePercentage.Location = new System.Drawing.Point(132, 265);
            this.cbWorkTimePercentage.Name = "cbWorkTimePercentage";
            this.cbWorkTimePercentage.Size = new System.Drawing.Size(121, 21);
            this.cbWorkTimePercentage.TabIndex = 22;
            this.cbWorkTimePercentage.Text = "Anstellungsgrad";
            // 
            // dtpEntryDate
            // 
            this.dtpEntryDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEntryDate.Location = new System.Drawing.Point(9, 292);
            this.dtpEntryDate.Name = "dtpEntryDate";
            this.dtpEntryDate.Size = new System.Drawing.Size(117, 20);
            this.dtpEntryDate.TabIndex = 23;
            // 
            // dtpWithdrawlDate
            // 
            this.dtpWithdrawlDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpWithdrawlDate.Location = new System.Drawing.Point(133, 292);
            this.dtpWithdrawlDate.Name = "dtpWithdrawlDate";
            this.dtpWithdrawlDate.Size = new System.Drawing.Size(120, 20);
            this.dtpWithdrawlDate.TabIndex = 24;
            // 
            // txtWork
            // 
            this.txtWork.Location = new System.Drawing.Point(8, 318);
            this.txtWork.Name = "txtWork";
            this.txtWork.Size = new System.Drawing.Size(118, 20);
            this.txtWork.TabIndex = 25;
            this.txtWork.Text = "Tätigkeit";
            // 
            // cbManagementLevel
            // 
            this.cbManagementLevel.FormattingEnabled = true;
            this.cbManagementLevel.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbManagementLevel.Location = new System.Drawing.Point(133, 318);
            this.cbManagementLevel.Name = "cbManagementLevel";
            this.cbManagementLevel.Size = new System.Drawing.Size(120, 21);
            this.cbManagementLevel.TabIndex = 26;
            this.cbManagementLevel.Text = "Kaderstufe";
            // 
            // cbApprenticeYears
            // 
            this.cbApprenticeYears.FormattingEnabled = true;
            this.cbApprenticeYears.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbApprenticeYears.Location = new System.Drawing.Point(8, 345);
            this.cbApprenticeYears.Name = "cbApprenticeYears";
            this.cbApprenticeYears.Size = new System.Drawing.Size(118, 21);
            this.cbApprenticeYears.TabIndex = 27;
            this.cbApprenticeYears.Text = "Anzahl Lehrjahre";
            // 
            // cbCurrentApprenticeYear
            // 
            this.cbCurrentApprenticeYear.FormattingEnabled = true;
            this.cbCurrentApprenticeYear.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbCurrentApprenticeYear.Location = new System.Drawing.Point(133, 345);
            this.cbCurrentApprenticeYear.Name = "cbCurrentApprenticeYear";
            this.cbCurrentApprenticeYear.Size = new System.Drawing.Size(120, 21);
            this.cbCurrentApprenticeYear.TabIndex = 28;
            this.cbCurrentApprenticeYear.Text = "Aktuelles Lehrjahr";
            // 
            // chckbxActive
            // 
            this.chckbxActive.AutoSize = true;
            this.chckbxActive.Location = new System.Drawing.Point(8, 372);
            this.chckbxActive.Name = "chckbxActive";
            this.chckbxActive.Size = new System.Drawing.Size(111, 17);
            this.chckbxActive.TabIndex = 29;
            this.chckbxActive.Text = "Aktiver Mitarbeiter";
            this.chckbxActive.UseVisualStyleBackColor = true;
            this.chckbxActive.CheckStateChanged += new System.EventHandler(this.chckbxActive_CheckStateChanged);
            // 
            // chckbxApprentice
            // 
            this.chckbxApprentice.AutoSize = true;
            this.chckbxApprentice.Location = new System.Drawing.Point(133, 372);
            this.chckbxApprentice.Name = "chckbxApprentice";
            this.chckbxApprentice.Size = new System.Drawing.Size(74, 17);
            this.chckbxApprentice.TabIndex = 30;
            this.chckbxApprentice.Text = "Lernender";
            this.chckbxApprentice.UseVisualStyleBackColor = true;
            this.chckbxApprentice.CheckedChanged += new System.EventHandler(this.chckbxApprentice_CheckedChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(9, 407);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(117, 23);
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "Speichern";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(132, 407);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(121, 23);
            this.btnDelete.TabIndex = 32;
            this.btnDelete.Text = "Eingabe Löschen";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // FormAddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 512);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.chckbxApprentice);
            this.Controls.Add(this.chckbxActive);
            this.Controls.Add(this.cbCurrentApprenticeYear);
            this.Controls.Add(this.cbApprenticeYears);
            this.Controls.Add(this.cbManagementLevel);
            this.Controls.Add(this.txtWork);
            this.Controls.Add(this.dtpWithdrawlDate);
            this.Controls.Add(this.dtpEntryDate);
            this.Controls.Add(this.cbWorkTimePercentage);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtBusinessFax);
            this.Controls.Add(this.txtBusinessPhone);
            this.Controls.Add(this.txtDepartement);
            this.Controls.Add(this.txtEmployeeNumber);
            this.Controls.Add(this.lblPrivate);
            this.Controls.Add(this.lblBusiness);
            this.Controls.Add(this.cbNationality);
            this.Controls.Add(this.txtZipCode);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtAdress);
            this.Controls.Add(this.txtPrivatePhone);
            this.Controls.Add(this.txtAhv);
            this.Controls.Add(this.txtHandy);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.rbOther);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.cmbTitle);
            this.Controls.Add(this.cmbSalutation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddEmployee";
            this.Text = "addEmployeeForm";
            this.Load += new System.EventHandler(this.addEmployeeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSalutation;
        private System.Windows.Forms.ComboBox cmbTitle;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbOther;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtHandy;
        private System.Windows.Forms.TextBox txtAhv;
        private System.Windows.Forms.TextBox txtPrivatePhone;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtZipCode;
        private System.Windows.Forms.ComboBox cbNationality;
        private System.Windows.Forms.Label lblBusiness;
        private System.Windows.Forms.Label lblPrivate;
        private System.Windows.Forms.TextBox txtEmployeeNumber;
        private System.Windows.Forms.TextBox txtDepartement;
        private System.Windows.Forms.TextBox txtBusinessPhone;
        private System.Windows.Forms.TextBox txtBusinessFax;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ComboBox cbWorkTimePercentage;
        private System.Windows.Forms.DateTimePicker dtpEntryDate;
        private System.Windows.Forms.DateTimePicker dtpWithdrawlDate;
        private System.Windows.Forms.TextBox txtWork;
        public System.Windows.Forms.ComboBox cbManagementLevel;
        private System.Windows.Forms.ComboBox cbApprenticeYears;
        private System.Windows.Forms.ComboBox cbCurrentApprenticeYear;
        private System.Windows.Forms.CheckBox chckbxActive;
        private System.Windows.Forms.CheckBox chckbxApprentice;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
    }
}