
namespace Contact_Manager.Partials.Dialog
{
    partial class TraineeDialog
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
            this.components = new System.ComponentModel.Container();
            this.LblInfo = new System.Windows.Forms.Label();
            this.LblCurrentApprenticeYear = new System.Windows.Forms.Label();
            this.LblApprenticeYears = new System.Windows.Forms.Label();
            this.LblManagementLevel = new System.Windows.Forms.Label();
            this.LblRole = new System.Windows.Forms.Label();
            this.LblExitDate = new System.Windows.Forms.Label();
            this.LblEntryDate = new System.Windows.Forms.Label();
            this.LblLoe = new System.Windows.Forms.Label();
            this.LblEmail = new System.Windows.Forms.Label();
            this.LblFax = new System.Windows.Forms.Label();
            this.LblPhoneCompany = new System.Windows.Forms.Label();
            this.LblDepartement = new System.Windows.Forms.Label();
            this.LblNationailty = new System.Windows.Forms.Label();
            this.LblZipCode = new System.Windows.Forms.Label();
            this.LblCity = new System.Windows.Forms.Label();
            this.LblAddress = new System.Windows.Forms.Label();
            this.LblDateOfBirth = new System.Windows.Forms.Label();
            this.LblAhv = new System.Windows.Forms.Label();
            this.LblMobile = new System.Windows.Forms.Label();
            this.LblPhonePrivate = new System.Windows.Forms.Label();
            this.LblSurName = new System.Windows.Forms.Label();
            this.LblFirstName = new System.Windows.Forms.Label();
            this.LblGender = new System.Windows.Forms.Label();
            this.LblTitle = new System.Windows.Forms.Label();
            this.LblSalutation = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.ChkStatus = new System.Windows.Forms.CheckBox();
            this.CmbCurrentApprenticeYear = new System.Windows.Forms.ComboBox();
            this.CmbApprenticeYears = new System.Windows.Forms.ComboBox();
            this.CmbManagementLevel = new System.Windows.Forms.ComboBox();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.DtpExitDate = new System.Windows.Forms.DateTimePicker();
            this.DtpEntryDate = new System.Windows.Forms.DateTimePicker();
            this.CmbLoe = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.txtPhoneCompany = new System.Windows.Forms.TextBox();
            this.txtDepartement = new System.Windows.Forms.TextBox();
            this.CmbNationality = new System.Windows.Forms.ComboBox();
            this.txtZipCode = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhonePrivate = new System.Windows.Forms.TextBox();
            this.txtAhv = new System.Windows.Forms.TextBox();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.DtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.txtSurName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.rbOther = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.CmbTitle = new System.Windows.Forms.ComboBox();
            this.CmbSalutation = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.employeeDialogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDialogBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // LblInfo
            // 
            this.LblInfo.AutoSize = true;
            this.LblInfo.Location = new System.Drawing.Point(321, 17);
            this.LblInfo.Name = "LblInfo";
            this.LblInfo.Size = new System.Drawing.Size(69, 13);
            this.LblInfo.TabIndex = 149;
            this.LblInfo.Text = "* = Pflichtfeld";
            // 
            // LblCurrentApprenticeYear
            // 
            this.LblCurrentApprenticeYear.AutoSize = true;
            this.LblCurrentApprenticeYear.Location = new System.Drawing.Point(204, 225);
            this.LblCurrentApprenticeYear.Name = "LblCurrentApprenticeYear";
            this.LblCurrentApprenticeYear.Size = new System.Drawing.Size(91, 13);
            this.LblCurrentApprenticeYear.TabIndex = 146;
            this.LblCurrentApprenticeYear.Text = "Aktuelles Lehrjahr";
            // 
            // LblApprenticeYears
            // 
            this.LblApprenticeYears.AutoSize = true;
            this.LblApprenticeYears.Location = new System.Drawing.Point(15, 225);
            this.LblApprenticeYears.Name = "LblApprenticeYears";
            this.LblApprenticeYears.Size = new System.Drawing.Size(86, 13);
            this.LblApprenticeYears.TabIndex = 145;
            this.LblApprenticeYears.Text = "Anzahl Lehrjahre";
            // 
            // LblManagementLevel
            // 
            this.LblManagementLevel.AutoSize = true;
            this.LblManagementLevel.Location = new System.Drawing.Point(15, 185);
            this.LblManagementLevel.Name = "LblManagementLevel";
            this.LblManagementLevel.Size = new System.Drawing.Size(65, 13);
            this.LblManagementLevel.TabIndex = 144;
            this.LblManagementLevel.Text = "Kaderstufe *";
            // 
            // LblRole
            // 
            this.LblRole.AutoSize = true;
            this.LblRole.Location = new System.Drawing.Point(204, 146);
            this.LblRole.Name = "LblRole";
            this.LblRole.Size = new System.Drawing.Size(55, 13);
            this.LblRole.TabIndex = 143;
            this.LblRole.Text = "Tätigkeit *";
            // 
            // LblExitDate
            // 
            this.LblExitDate.AutoSize = true;
            this.LblExitDate.Location = new System.Drawing.Point(15, 146);
            this.LblExitDate.Name = "LblExitDate";
            this.LblExitDate.Size = new System.Drawing.Size(39, 13);
            this.LblExitDate.TabIndex = 142;
            this.LblExitDate.Text = "Austritt";
            // 
            // LblEntryDate
            // 
            this.LblEntryDate.AutoSize = true;
            this.LblEntryDate.Location = new System.Drawing.Point(204, 106);
            this.LblEntryDate.Name = "LblEntryDate";
            this.LblEntryDate.Size = new System.Drawing.Size(43, 13);
            this.LblEntryDate.TabIndex = 141;
            this.LblEntryDate.Text = "Eintritt *";
            // 
            // LblLoe
            // 
            this.LblLoe.AutoSize = true;
            this.LblLoe.Location = new System.Drawing.Point(15, 106);
            this.LblLoe.Name = "LblLoe";
            this.LblLoe.Size = new System.Drawing.Size(106, 13);
            this.LblLoe.TabIndex = 140;
            this.LblLoe.Text = "Anstellungsgrad (%) *";
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Location = new System.Drawing.Point(204, 67);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(43, 13);
            this.LblEmail.TabIndex = 139;
            this.LblEmail.Text = "E-Mail *";
            // 
            // LblFax
            // 
            this.LblFax.AutoSize = true;
            this.LblFax.Location = new System.Drawing.Point(15, 67);
            this.LblFax.Name = "LblFax";
            this.LblFax.Size = new System.Drawing.Size(41, 13);
            this.LblFax.TabIndex = 138;
            this.LblFax.Text = "Fax Nr.";
            // 
            // LblPhoneCompany
            // 
            this.LblPhoneCompany.AutoSize = true;
            this.LblPhoneCompany.Location = new System.Drawing.Point(204, 28);
            this.LblPhoneCompany.Name = "LblPhoneCompany";
            this.LblPhoneCompany.Size = new System.Drawing.Size(89, 13);
            this.LblPhoneCompany.TabIndex = 137;
            this.LblPhoneCompany.Text = "Telefon Geschäft";
            // 
            // LblDepartement
            // 
            this.LblDepartement.AutoSize = true;
            this.LblDepartement.Location = new System.Drawing.Point(15, 28);
            this.LblDepartement.Name = "LblDepartement";
            this.LblDepartement.Size = new System.Drawing.Size(58, 13);
            this.LblDepartement.TabIndex = 136;
            this.LblDepartement.Text = "Abteilung *";
            // 
            // LblNationailty
            // 
            this.LblNationailty.AutoSize = true;
            this.LblNationailty.Location = new System.Drawing.Point(204, 260);
            this.LblNationailty.Name = "LblNationailty";
            this.LblNationailty.Size = new System.Drawing.Size(60, 13);
            this.LblNationailty.TabIndex = 135;
            this.LblNationailty.Text = "Nationalität";
            // 
            // LblZipCode
            // 
            this.LblZipCode.AutoSize = true;
            this.LblZipCode.Location = new System.Drawing.Point(15, 260);
            this.LblZipCode.Name = "LblZipCode";
            this.LblZipCode.Size = new System.Drawing.Size(34, 13);
            this.LblZipCode.TabIndex = 134;
            this.LblZipCode.Text = "PLZ *";
            // 
            // LblCity
            // 
            this.LblCity.AutoSize = true;
            this.LblCity.Location = new System.Drawing.Point(204, 221);
            this.LblCity.Name = "LblCity";
            this.LblCity.Size = new System.Drawing.Size(28, 13);
            this.LblCity.TabIndex = 133;
            this.LblCity.Text = "Ort *";
            // 
            // LblAddress
            // 
            this.LblAddress.AutoSize = true;
            this.LblAddress.Location = new System.Drawing.Point(15, 221);
            this.LblAddress.Name = "LblAddress";
            this.LblAddress.Size = new System.Drawing.Size(74, 13);
            this.LblAddress.TabIndex = 132;
            this.LblAddress.Text = "Strasse / Nr. *";
            // 
            // LblDateOfBirth
            // 
            this.LblDateOfBirth.AutoSize = true;
            this.LblDateOfBirth.Location = new System.Drawing.Point(204, 182);
            this.LblDateOfBirth.Name = "LblDateOfBirth";
            this.LblDateOfBirth.Size = new System.Drawing.Size(80, 13);
            this.LblDateOfBirth.TabIndex = 131;
            this.LblDateOfBirth.Text = "Geburtsdatum *";
            // 
            // LblAhv
            // 
            this.LblAhv.AutoSize = true;
            this.LblAhv.Location = new System.Drawing.Point(15, 182);
            this.LblAhv.Name = "LblAhv";
            this.LblAhv.Size = new System.Drawing.Size(46, 13);
            this.LblAhv.TabIndex = 130;
            this.LblAhv.Text = "AHV Nr.";
            // 
            // LblMobile
            // 
            this.LblMobile.AutoSize = true;
            this.LblMobile.Location = new System.Drawing.Point(204, 143);
            this.LblMobile.Name = "LblMobile";
            this.LblMobile.Size = new System.Drawing.Size(45, 13);
            this.LblMobile.TabIndex = 129;
            this.LblMobile.Text = "Mobile *";
            // 
            // LblPhonePrivate
            // 
            this.LblPhonePrivate.AutoSize = true;
            this.LblPhonePrivate.Location = new System.Drawing.Point(15, 143);
            this.LblPhonePrivate.Name = "LblPhonePrivate";
            this.LblPhonePrivate.Size = new System.Drawing.Size(73, 13);
            this.LblPhonePrivate.TabIndex = 128;
            this.LblPhonePrivate.Text = "Telefon Privat";
            // 
            // LblSurName
            // 
            this.LblSurName.AutoSize = true;
            this.LblSurName.Location = new System.Drawing.Point(204, 104);
            this.LblSurName.Name = "LblSurName";
            this.LblSurName.Size = new System.Drawing.Size(66, 13);
            this.LblSurName.TabIndex = 127;
            this.LblSurName.Text = "Nachname *";
            // 
            // LblFirstName
            // 
            this.LblFirstName.AutoSize = true;
            this.LblFirstName.Location = new System.Drawing.Point(15, 104);
            this.LblFirstName.Name = "LblFirstName";
            this.LblFirstName.Size = new System.Drawing.Size(56, 13);
            this.LblFirstName.TabIndex = 126;
            this.LblFirstName.Text = "Vorname *";
            // 
            // LblGender
            // 
            this.LblGender.AutoSize = true;
            this.LblGender.Location = new System.Drawing.Point(15, 68);
            this.LblGender.Name = "LblGender";
            this.LblGender.Size = new System.Drawing.Size(68, 13);
            this.LblGender.TabIndex = 125;
            this.LblGender.Text = "Geschlecht *";
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Location = new System.Drawing.Point(204, 28);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(27, 13);
            this.LblTitle.TabIndex = 124;
            this.LblTitle.Text = "Titel";
            // 
            // LblSalutation
            // 
            this.LblSalutation.AutoSize = true;
            this.LblSalutation.Location = new System.Drawing.Point(15, 28);
            this.LblSalutation.Name = "LblSalutation";
            this.LblSalutation.Size = new System.Drawing.Size(48, 13);
            this.LblSalutation.TabIndex = 123;
            this.LblSalutation.Text = "Anrede *";
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSave.Location = new System.Drawing.Point(10, 631);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(405, 23);
            this.btnSave.TabIndex = 122;
            this.btnSave.Text = "Speichern";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ChkStatus
            // 
            this.ChkStatus.AutoSize = true;
            this.ChkStatus.Checked = true;
            this.ChkStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkStatus.Location = new System.Drawing.Point(279, 201);
            this.ChkStatus.Name = "ChkStatus";
            this.ChkStatus.Size = new System.Drawing.Size(111, 17);
            this.ChkStatus.TabIndex = 120;
            this.ChkStatus.Text = "Aktiver Mitarbeiter";
            this.ChkStatus.UseVisualStyleBackColor = true;
            this.ChkStatus.CheckedChanged += new System.EventHandler(this.ChkStatus_CheckedChanged);
            // 
            // CmbCurrentApprenticeYear
            // 
            this.CmbCurrentApprenticeYear.FormattingEnabled = true;
            this.CmbCurrentApprenticeYear.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.CmbCurrentApprenticeYear.Location = new System.Drawing.Point(207, 241);
            this.CmbCurrentApprenticeYear.Name = "CmbCurrentApprenticeYear";
            this.CmbCurrentApprenticeYear.Size = new System.Drawing.Size(183, 21);
            this.CmbCurrentApprenticeYear.TabIndex = 119;
            // 
            // CmbApprenticeYears
            // 
            this.CmbApprenticeYears.FormattingEnabled = true;
            this.CmbApprenticeYears.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.CmbApprenticeYears.Location = new System.Drawing.Point(18, 241);
            this.CmbApprenticeYears.Name = "CmbApprenticeYears";
            this.CmbApprenticeYears.Size = new System.Drawing.Size(183, 21);
            this.CmbApprenticeYears.TabIndex = 118;
            // 
            // CmbManagementLevel
            // 
            this.CmbManagementLevel.FormattingEnabled = true;
            this.CmbManagementLevel.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.CmbManagementLevel.Location = new System.Drawing.Point(18, 201);
            this.CmbManagementLevel.Name = "CmbManagementLevel";
            this.CmbManagementLevel.Size = new System.Drawing.Size(183, 21);
            this.CmbManagementLevel.TabIndex = 117;
            // 
            // txtRole
            // 
            this.txtRole.Location = new System.Drawing.Point(207, 162);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(183, 20);
            this.txtRole.TabIndex = 116;
            // 
            // DtpExitDate
            // 
            this.DtpExitDate.Enabled = false;
            this.DtpExitDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpExitDate.Location = new System.Drawing.Point(18, 162);
            this.DtpExitDate.Name = "DtpExitDate";
            this.DtpExitDate.Size = new System.Drawing.Size(183, 20);
            this.DtpExitDate.TabIndex = 115;
            // 
            // DtpEntryDate
            // 
            this.DtpEntryDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpEntryDate.Location = new System.Drawing.Point(207, 123);
            this.DtpEntryDate.Name = "DtpEntryDate";
            this.DtpEntryDate.Size = new System.Drawing.Size(183, 20);
            this.DtpEntryDate.TabIndex = 114;
            // 
            // CmbLoe
            // 
            this.CmbLoe.AutoCompleteCustomSource.AddRange(new string[] {
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
            this.CmbLoe.FormattingEnabled = true;
            this.CmbLoe.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55",
            "60",
            "65",
            "70",
            "75",
            "80",
            "85",
            "90",
            "100"});
            this.CmbLoe.Location = new System.Drawing.Point(18, 122);
            this.CmbLoe.Name = "CmbLoe";
            this.CmbLoe.Size = new System.Drawing.Size(183, 21);
            this.CmbLoe.TabIndex = 113;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(207, 83);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(183, 20);
            this.txtEmail.TabIndex = 112;
            // 
            // txtFax
            // 
            this.txtFax.Location = new System.Drawing.Point(18, 83);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(183, 20);
            this.txtFax.TabIndex = 111;
            // 
            // txtPhoneCompany
            // 
            this.txtPhoneCompany.Location = new System.Drawing.Point(207, 44);
            this.txtPhoneCompany.Name = "txtPhoneCompany";
            this.txtPhoneCompany.Size = new System.Drawing.Size(183, 20);
            this.txtPhoneCompany.TabIndex = 110;
            // 
            // txtDepartement
            // 
            this.txtDepartement.Location = new System.Drawing.Point(18, 44);
            this.txtDepartement.Name = "txtDepartement";
            this.txtDepartement.Size = new System.Drawing.Size(183, 20);
            this.txtDepartement.TabIndex = 109;
            // 
            // CmbNationality
            // 
            this.CmbNationality.FormattingEnabled = true;
            this.CmbNationality.Location = new System.Drawing.Point(207, 276);
            this.CmbNationality.Name = "CmbNationality";
            this.CmbNationality.Size = new System.Drawing.Size(183, 21);
            this.CmbNationality.Sorted = true;
            this.CmbNationality.TabIndex = 108;
            // 
            // txtZipCode
            // 
            this.txtZipCode.Location = new System.Drawing.Point(18, 276);
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(183, 20);
            this.txtZipCode.TabIndex = 107;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(207, 237);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(183, 20);
            this.txtCity.TabIndex = 106;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(18, 237);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(183, 20);
            this.txtAddress.TabIndex = 105;
            // 
            // txtPhonePrivate
            // 
            this.txtPhonePrivate.Location = new System.Drawing.Point(18, 159);
            this.txtPhonePrivate.Name = "txtPhonePrivate";
            this.txtPhonePrivate.Size = new System.Drawing.Size(183, 20);
            this.txtPhonePrivate.TabIndex = 101;
            // 
            // txtAhv
            // 
            this.txtAhv.Location = new System.Drawing.Point(18, 198);
            this.txtAhv.Name = "txtAhv";
            this.txtAhv.Size = new System.Drawing.Size(183, 20);
            this.txtAhv.TabIndex = 103;
            // 
            // txtMobile
            // 
            this.txtMobile.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtMobile.Location = new System.Drawing.Point(207, 159);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(183, 20);
            this.txtMobile.TabIndex = 102;
            // 
            // DtpDateOfBirth
            // 
            this.DtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpDateOfBirth.Location = new System.Drawing.Point(207, 198);
            this.DtpDateOfBirth.Name = "DtpDateOfBirth";
            this.DtpDateOfBirth.Size = new System.Drawing.Size(183, 20);
            this.DtpDateOfBirth.TabIndex = 104;
            // 
            // txtSurName
            // 
            this.txtSurName.Location = new System.Drawing.Point(207, 120);
            this.txtSurName.Name = "txtSurName";
            this.txtSurName.Size = new System.Drawing.Size(183, 20);
            this.txtSurName.TabIndex = 100;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(18, 120);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(183, 20);
            this.txtFirstName.TabIndex = 99;
            // 
            // rbOther
            // 
            this.rbOther.AutoSize = true;
            this.rbOther.Location = new System.Drawing.Point(202, 84);
            this.rbOther.Name = "rbOther";
            this.rbOther.Size = new System.Drawing.Size(64, 17);
            this.rbOther.TabIndex = 98;
            this.rbOther.TabStop = true;
            this.rbOther.Text = "Anderes";
            this.rbOther.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(110, 84);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(66, 17);
            this.rbFemale.TabIndex = 97;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Weiblich";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(18, 84);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(68, 17);
            this.rbMale.TabIndex = 96;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Männlich";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // CmbTitle
            // 
            this.CmbTitle.FormattingEnabled = true;
            this.CmbTitle.Items.AddRange(new object[] {
            "",
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
            this.CmbTitle.Location = new System.Drawing.Point(207, 44);
            this.CmbTitle.Name = "CmbTitle";
            this.CmbTitle.Size = new System.Drawing.Size(183, 21);
            this.CmbTitle.TabIndex = 95;
            // 
            // CmbSalutation
            // 
            this.CmbSalutation.FormattingEnabled = true;
            this.CmbSalutation.Items.AddRange(new object[] {
            "Herr",
            "Frau"});
            this.CmbSalutation.Location = new System.Drawing.Point(18, 44);
            this.CmbSalutation.Name = "CmbSalutation";
            this.CmbSalutation.Size = new System.Drawing.Size(183, 21);
            this.CmbSalutation.TabIndex = 94;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.LblSalutation);
            this.groupBox1.Controls.Add(this.CmbSalutation);
            this.groupBox1.Controls.Add(this.LblInfo);
            this.groupBox1.Controls.Add(this.CmbTitle);
            this.groupBox1.Controls.Add(this.LblTitle);
            this.groupBox1.Controls.Add(this.LblGender);
            this.groupBox1.Controls.Add(this.rbMale);
            this.groupBox1.Controls.Add(this.rbFemale);
            this.groupBox1.Controls.Add(this.rbOther);
            this.groupBox1.Controls.Add(this.LblFirstName);
            this.groupBox1.Controls.Add(this.txtFirstName);
            this.groupBox1.Controls.Add(this.LblSurName);
            this.groupBox1.Controls.Add(this.txtSurName);
            this.groupBox1.Controls.Add(this.LblPhonePrivate);
            this.groupBox1.Controls.Add(this.txtPhonePrivate);
            this.groupBox1.Controls.Add(this.txtMobile);
            this.groupBox1.Controls.Add(this.LblMobile);
            this.groupBox1.Controls.Add(this.LblNationailty);
            this.groupBox1.Controls.Add(this.LblAhv);
            this.groupBox1.Controls.Add(this.LblZipCode);
            this.groupBox1.Controls.Add(this.txtAhv);
            this.groupBox1.Controls.Add(this.LblCity);
            this.groupBox1.Controls.Add(this.LblDateOfBirth);
            this.groupBox1.Controls.Add(this.LblAddress);
            this.groupBox1.Controls.Add(this.DtpDateOfBirth);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.txtCity);
            this.groupBox1.Controls.Add(this.txtZipCode);
            this.groupBox1.Controls.Add(this.CmbNationality);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(15);
            this.groupBox1.Size = new System.Drawing.Size(405, 328);
            this.groupBox1.TabIndex = 150;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Privat";
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.LblDepartement);
            this.groupBox2.Controls.Add(this.txtDepartement);
            this.groupBox2.Controls.Add(this.LblPhoneCompany);
            this.groupBox2.Controls.Add(this.txtPhoneCompany);
            this.groupBox2.Controls.Add(this.LblCurrentApprenticeYear);
            this.groupBox2.Controls.Add(this.LblFax);
            this.groupBox2.Controls.Add(this.ChkStatus);
            this.groupBox2.Controls.Add(this.LblApprenticeYears);
            this.groupBox2.Controls.Add(this.CmbCurrentApprenticeYear);
            this.groupBox2.Controls.Add(this.txtFax);
            this.groupBox2.Controls.Add(this.LblManagementLevel);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.CmbApprenticeYears);
            this.groupBox2.Controls.Add(this.LblRole);
            this.groupBox2.Controls.Add(this.LblEmail);
            this.groupBox2.Controls.Add(this.LblExitDate);
            this.groupBox2.Controls.Add(this.CmbManagementLevel);
            this.groupBox2.Controls.Add(this.CmbLoe);
            this.groupBox2.Controls.Add(this.LblEntryDate);
            this.groupBox2.Controls.Add(this.LblLoe);
            this.groupBox2.Controls.Add(this.DtpEntryDate);
            this.groupBox2.Controls.Add(this.DtpExitDate);
            this.groupBox2.Controls.Add(this.txtRole);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(10, 338);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(15);
            this.groupBox2.Size = new System.Drawing.Size(405, 293);
            this.groupBox2.TabIndex = 151;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Geschäftlich";
            // 
            // employeeDialogBindingSource
            // 
            this.employeeDialogBindingSource.DataSource = typeof(Contact_Manager.Partials.Dialog.EmployeeDialog);
            // 
            // TraineeDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 663);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "TraineeDialog";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Lehrling";
            this.Load += new System.EventHandler(this.TraineeDialog_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDialogBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource employeeDialogBindingSource;
        private System.Windows.Forms.Label LblInfo;
        private System.Windows.Forms.Label LblCurrentApprenticeYear;
        private System.Windows.Forms.Label LblApprenticeYears;
        private System.Windows.Forms.Label LblManagementLevel;
        private System.Windows.Forms.Label LblRole;
        private System.Windows.Forms.Label LblExitDate;
        private System.Windows.Forms.Label LblEntryDate;
        private System.Windows.Forms.Label LblLoe;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.Label LblFax;
        private System.Windows.Forms.Label LblPhoneCompany;
        private System.Windows.Forms.Label LblDepartement;
        private System.Windows.Forms.Label LblNationailty;
        private System.Windows.Forms.Label LblZipCode;
        private System.Windows.Forms.Label LblCity;
        private System.Windows.Forms.Label LblAddress;
        private System.Windows.Forms.Label LblDateOfBirth;
        private System.Windows.Forms.Label LblAhv;
        private System.Windows.Forms.Label LblMobile;
        private System.Windows.Forms.Label LblPhonePrivate;
        private System.Windows.Forms.Label LblSurName;
        private System.Windows.Forms.Label LblFirstName;
        private System.Windows.Forms.Label LblGender;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Label LblSalutation;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox ChkStatus;
        private System.Windows.Forms.ComboBox CmbCurrentApprenticeYear;
        private System.Windows.Forms.ComboBox CmbApprenticeYears;
        public System.Windows.Forms.ComboBox CmbManagementLevel;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.DateTimePicker DtpExitDate;
        private System.Windows.Forms.DateTimePicker DtpEntryDate;
        private System.Windows.Forms.ComboBox CmbLoe;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtFax;
        private System.Windows.Forms.TextBox txtPhoneCompany;
        private System.Windows.Forms.TextBox txtDepartement;
        private System.Windows.Forms.ComboBox CmbNationality;
        private System.Windows.Forms.TextBox txtZipCode;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhonePrivate;
        private System.Windows.Forms.TextBox txtAhv;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.DateTimePicker DtpDateOfBirth;
        private System.Windows.Forms.TextBox txtSurName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.RadioButton rbOther;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.ComboBox CmbTitle;
        private System.Windows.Forms.ComboBox CmbSalutation;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}