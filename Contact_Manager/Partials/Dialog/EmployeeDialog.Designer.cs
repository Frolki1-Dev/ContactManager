
namespace Contact_Manager.Partials.Dialog
{
    partial class EmployeeDialog
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

            this.btnSave = new System.Windows.Forms.Button();
            this.ChkApprentice = new System.Windows.Forms.CheckBox();
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
            this.LblSalutation = new System.Windows.Forms.Label();
            this.LblTitle = new System.Windows.Forms.Label();
            this.LblGender = new System.Windows.Forms.Label();
            this.LblFirstName = new System.Windows.Forms.Label();
            this.LblSurName = new System.Windows.Forms.Label();
            this.LblPhonePrivate = new System.Windows.Forms.Label();
            this.LblMobile = new System.Windows.Forms.Label();
            this.txtEmployeeNumber = new System.Windows.Forms.TextBox();
            this.LblCity = new System.Windows.Forms.Label();
            this.LblAddress = new System.Windows.Forms.Label();
            this.LblDateOfBirth = new System.Windows.Forms.Label();
            this.LblAhv = new System.Windows.Forms.Label();
            this.LblDepartement = new System.Windows.Forms.Label();
            this.LblEmployeeNumber = new System.Windows.Forms.Label();
            this.LblNationailty = new System.Windows.Forms.Label();
            this.LblZipCode = new System.Windows.Forms.Label();
            this.LblLoe = new System.Windows.Forms.Label();
            this.LblEmail = new System.Windows.Forms.Label();
            this.LblFax = new System.Windows.Forms.Label();
            this.LblPhoneCompany = new System.Windows.Forms.Label();
            this.LblManagementLevel = new System.Windows.Forms.Label();
            this.LblRole = new System.Windows.Forms.Label();
            this.LblExitDate = new System.Windows.Forms.Label();
            this.LblEntryDate = new System.Windows.Forms.Label();
            this.LblCurrentApprenticeYear = new System.Windows.Forms.Label();
            this.LblApprenticeYears = new System.Windows.Forms.Label();
            this.LblPrivate = new System.Windows.Forms.Label();
            this.LblCompany = new System.Windows.Forms.Label();
            this.employeeDialogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LblInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDialogBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 417);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(117, 23);
            this.btnSave.TabIndex = 64;
            this.btnSave.Text = "Speichern";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ChkApprentice
            // 
            this.ChkApprentice.AutoSize = true;
            this.ChkApprentice.Location = new System.Drawing.Point(519, 364);
            this.ChkApprentice.Name = "ChkApprentice";
            this.ChkApprentice.Size = new System.Drawing.Size(74, 17);
            this.ChkApprentice.TabIndex = 63;
            this.ChkApprentice.Text = "Lernender";
            this.ChkApprentice.UseVisualStyleBackColor = true;
            this.ChkApprentice.CheckedChanged += new System.EventHandler(this.ChkApprentice_CheckedChanged);
            // 
            // ChkStatus
            // 
            this.ChkStatus.AutoSize = true;
            this.ChkStatus.Checked = true;
            this.ChkStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkStatus.Location = new System.Drawing.Point(402, 364);
            this.ChkStatus.Name = "ChkStatus";
            this.ChkStatus.Size = new System.Drawing.Size(111, 17);
            this.ChkStatus.TabIndex = 62;
            this.ChkStatus.Text = "Aktiver Mitarbeiter";
            this.ChkStatus.UseVisualStyleBackColor = true;
            this.ChkStatus.CheckedChanged += new System.EventHandler(this.ChkStatus_CheckedChanged);
            // 
            // CmbCurrentApprenticeYear
            // 
            this.CmbCurrentApprenticeYear.Enabled = false;
            this.CmbCurrentApprenticeYear.FormattingEnabled = true;
            this.CmbCurrentApprenticeYear.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.CmbCurrentApprenticeYear.Location = new System.Drawing.Point(519, 336);
            this.CmbCurrentApprenticeYear.Name = "CmbCurrentApprenticeYear";
            this.CmbCurrentApprenticeYear.Size = new System.Drawing.Size(175, 21);
            this.CmbCurrentApprenticeYear.TabIndex = 61;
            // 
            // CmbApprenticeYears
            // 
            this.CmbApprenticeYears.Enabled = false;
            this.CmbApprenticeYears.FormattingEnabled = true;
            this.CmbApprenticeYears.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.CmbApprenticeYears.Location = new System.Drawing.Point(519, 309);
            this.CmbApprenticeYears.Name = "CmbApprenticeYears";
            this.CmbApprenticeYears.Size = new System.Drawing.Size(175, 21);
            this.CmbApprenticeYears.TabIndex = 60;
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
            this.CmbManagementLevel.Location = new System.Drawing.Point(519, 282);
            this.CmbManagementLevel.Name = "CmbManagementLevel";
            this.CmbManagementLevel.Size = new System.Drawing.Size(175, 21);
            this.CmbManagementLevel.TabIndex = 59;
            // 
            // txtRole
            // 
            this.txtRole.Location = new System.Drawing.Point(519, 256);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(175, 20);
            this.txtRole.TabIndex = 58;
            // 
            // DtpExitDate
            // 
            this.DtpExitDate.Enabled = false;
            this.DtpExitDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpExitDate.Location = new System.Drawing.Point(519, 230);
            this.DtpExitDate.Name = "DtpExitDate";
            this.DtpExitDate.Size = new System.Drawing.Size(175, 20);
            this.DtpExitDate.TabIndex = 57;
            // 
            // DtpEntryDate
            // 
            this.DtpEntryDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpEntryDate.Location = new System.Drawing.Point(519, 204);
            this.DtpEntryDate.Name = "DtpEntryDate";
            this.DtpEntryDate.Size = new System.Drawing.Size(175, 20);
            this.DtpEntryDate.TabIndex = 56;
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
            this.CmbLoe.Location = new System.Drawing.Point(519, 177);
            this.CmbLoe.Name = "CmbLoe";
            this.CmbLoe.Size = new System.Drawing.Size(175, 21);
            this.CmbLoe.TabIndex = 55;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(519, 151);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(175, 20);
            this.txtEmail.TabIndex = 54;
            // 
            // txtFax
            // 
            this.txtFax.Location = new System.Drawing.Point(519, 125);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(175, 20);
            this.txtFax.TabIndex = 53;
            // 
            // txtPhoneCompany
            // 
            this.txtPhoneCompany.Location = new System.Drawing.Point(519, 99);
            this.txtPhoneCompany.Name = "txtPhoneCompany";
            this.txtPhoneCompany.Size = new System.Drawing.Size(175, 20);
            this.txtPhoneCompany.TabIndex = 52;
            // 
            // txtDepartement
            // 
            this.txtDepartement.Location = new System.Drawing.Point(519, 73);
            this.txtDepartement.Name = "txtDepartement";
            this.txtDepartement.Size = new System.Drawing.Size(175, 20);
            this.txtDepartement.TabIndex = 51;
            // 
            // CmbNationality
            // 
            this.CmbNationality.FormattingEnabled = true;
            this.CmbNationality.Location = new System.Drawing.Point(103, 358);
            this.CmbNationality.Name = "CmbNationality";
            this.CmbNationality.Size = new System.Drawing.Size(249, 21);
            this.CmbNationality.Sorted = true;
            this.CmbNationality.TabIndex = 47;
            // 
            // txtZipCode
            // 
            this.txtZipCode.Location = new System.Drawing.Point(103, 332);
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(249, 20);
            this.txtZipCode.TabIndex = 46;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(103, 306);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(249, 20);
            this.txtCity.TabIndex = 45;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(103, 280);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(249, 20);
            this.txtAddress.TabIndex = 44;
            // 
            // txtPhonePrivate
            // 
            this.txtPhonePrivate.Location = new System.Drawing.Point(103, 176);
            this.txtPhonePrivate.Name = "txtPhonePrivate";
            this.txtPhonePrivate.Size = new System.Drawing.Size(249, 20);
            this.txtPhonePrivate.TabIndex = 40;
            // 
            // txtAhv
            // 
            this.txtAhv.Location = new System.Drawing.Point(103, 228);
            this.txtAhv.Name = "txtAhv";
            this.txtAhv.Size = new System.Drawing.Size(249, 20);
            this.txtAhv.TabIndex = 42;
            // 
            // txtMobile
            // 
            this.txtMobile.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtMobile.Location = new System.Drawing.Point(103, 202);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(249, 20);
            this.txtMobile.TabIndex = 41;
            // 
            // DtpDateOfBirth
            // 
            this.DtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpDateOfBirth.Location = new System.Drawing.Point(103, 254);
            this.DtpDateOfBirth.Name = "DtpDateOfBirth";
            this.DtpDateOfBirth.Size = new System.Drawing.Size(249, 20);
            this.DtpDateOfBirth.TabIndex = 43;
            // 
            // txtSurName
            // 
            this.txtSurName.Location = new System.Drawing.Point(103, 150);
            this.txtSurName.Name = "txtSurName";
            this.txtSurName.Size = new System.Drawing.Size(249, 20);
            this.txtSurName.TabIndex = 39;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(103, 124);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(249, 20);
            this.txtFirstName.TabIndex = 38;
            // 
            // rbOther
            // 
            this.rbOther.AutoSize = true;
            this.rbOther.Location = new System.Drawing.Point(287, 101);
            this.rbOther.Name = "rbOther";
            this.rbOther.Size = new System.Drawing.Size(64, 17);
            this.rbOther.TabIndex = 37;
            this.rbOther.TabStop = true;
            this.rbOther.Text = "Anderes";
            this.rbOther.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(195, 101);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(66, 17);
            this.rbFemale.TabIndex = 36;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Weiblich";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(103, 101);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(68, 17);
            this.rbMale.TabIndex = 35;
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
            this.CmbTitle.Location = new System.Drawing.Point(103, 74);
            this.CmbTitle.Name = "CmbTitle";
            this.CmbTitle.Size = new System.Drawing.Size(249, 21);
            this.CmbTitle.TabIndex = 34;
            // 
            // CmbSalutation
            // 
            this.CmbSalutation.FormattingEnabled = true;
            this.CmbSalutation.Items.AddRange(new object[] {
            "Herr",
            "Frau"});
            this.CmbSalutation.Location = new System.Drawing.Point(103, 47);
            this.CmbSalutation.Name = "CmbSalutation";
            this.CmbSalutation.Size = new System.Drawing.Size(249, 21);
            this.CmbSalutation.TabIndex = 33;
            // 
            // LblSalutation
            // 
            this.LblSalutation.AutoSize = true;
            this.LblSalutation.Location = new System.Drawing.Point(13, 50);
            this.LblSalutation.Name = "LblSalutation";
            this.LblSalutation.Size = new System.Drawing.Size(48, 13);
            this.LblSalutation.TabIndex = 66;
            this.LblSalutation.Text = "Anrede *";
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Location = new System.Drawing.Point(13, 77);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(27, 13);
            this.LblTitle.TabIndex = 67;
            this.LblTitle.Text = "Titel";
            // 
            // LblGender
            // 
            this.LblGender.AutoSize = true;
            this.LblGender.Location = new System.Drawing.Point(13, 103);
            this.LblGender.Name = "LblGender";
            this.LblGender.Size = new System.Drawing.Size(68, 13);
            this.LblGender.TabIndex = 68;
            this.LblGender.Text = "Geschlecht *";
            // 
            // LblFirstName
            // 
            this.LblFirstName.AutoSize = true;
            this.LblFirstName.Location = new System.Drawing.Point(13, 127);
            this.LblFirstName.Name = "LblFirstName";
            this.LblFirstName.Size = new System.Drawing.Size(56, 13);
            this.LblFirstName.TabIndex = 69;
            this.LblFirstName.Text = "Vorname *";
            // 
            // LblSurName
            // 
            this.LblSurName.AutoSize = true;
            this.LblSurName.Location = new System.Drawing.Point(13, 153);
            this.LblSurName.Name = "LblSurName";
            this.LblSurName.Size = new System.Drawing.Size(66, 13);
            this.LblSurName.TabIndex = 70;
            this.LblSurName.Text = "Nachname *";
            // 
            // LblPhonePrivate
            // 
            this.LblPhonePrivate.AutoSize = true;
            this.LblPhonePrivate.Location = new System.Drawing.Point(13, 179);
            this.LblPhonePrivate.Name = "LblPhonePrivate";
            this.LblPhonePrivate.Size = new System.Drawing.Size(73, 13);
            this.LblPhonePrivate.TabIndex = 71;
            this.LblPhonePrivate.Text = "Telefon Privat";
            // 
            // LblMobile
            // 
            this.LblMobile.AutoSize = true;
            this.LblMobile.Location = new System.Drawing.Point(13, 205);
            this.LblMobile.Name = "LblMobile";
            this.LblMobile.Size = new System.Drawing.Size(45, 13);
            this.LblMobile.TabIndex = 72;
            this.LblMobile.Text = "Mobile *";
            // 
            // txtEmployeeNumber
            // 
            this.txtEmployeeNumber.Location = new System.Drawing.Point(519, 47);
            this.txtEmployeeNumber.Name = "txtEmployeeNumber";
            this.txtEmployeeNumber.ReadOnly = true;
            this.txtEmployeeNumber.Size = new System.Drawing.Size(175, 20);
            this.txtEmployeeNumber.TabIndex = 50;
            // 
            // LblCity
            // 
            this.LblCity.AutoSize = true;
            this.LblCity.Location = new System.Drawing.Point(13, 309);
            this.LblCity.Name = "LblCity";
            this.LblCity.Size = new System.Drawing.Size(28, 13);
            this.LblCity.TabIndex = 76;
            this.LblCity.Text = "Ort *";
            // 
            // LblAddress
            // 
            this.LblAddress.AutoSize = true;
            this.LblAddress.Location = new System.Drawing.Point(13, 283);
            this.LblAddress.Name = "LblAddress";
            this.LblAddress.Size = new System.Drawing.Size(74, 13);
            this.LblAddress.TabIndex = 75;
            this.LblAddress.Text = "Strasse / Nr. *";
            // 
            // LblDateOfBirth
            // 
            this.LblDateOfBirth.AutoSize = true;
            this.LblDateOfBirth.Location = new System.Drawing.Point(13, 257);
            this.LblDateOfBirth.Name = "LblDateOfBirth";
            this.LblDateOfBirth.Size = new System.Drawing.Size(80, 13);
            this.LblDateOfBirth.TabIndex = 74;
            this.LblDateOfBirth.Text = "Geburtsdatum *";
            // 
            // LblAhv
            // 
            this.LblAhv.AutoSize = true;
            this.LblAhv.Location = new System.Drawing.Point(13, 231);
            this.LblAhv.Name = "LblAhv";
            this.LblAhv.Size = new System.Drawing.Size(46, 13);
            this.LblAhv.TabIndex = 73;
            this.LblAhv.Text = "AHV Nr.";
            // 
            // LblDepartement
            // 
            this.LblDepartement.AutoSize = true;
            this.LblDepartement.Location = new System.Drawing.Point(399, 76);
            this.LblDepartement.Name = "LblDepartement";
            this.LblDepartement.Size = new System.Drawing.Size(58, 13);
            this.LblDepartement.TabIndex = 80;
            this.LblDepartement.Text = "Abteilung *";
            // 
            // LblEmployeeNumber
            // 
            this.LblEmployeeNumber.AutoSize = true;
            this.LblEmployeeNumber.Location = new System.Drawing.Point(399, 50);
            this.LblEmployeeNumber.Name = "LblEmployeeNumber";
            this.LblEmployeeNumber.Size = new System.Drawing.Size(73, 13);
            this.LblEmployeeNumber.TabIndex = 79;
            this.LblEmployeeNumber.Text = "Mitarbeiter Nr.";
            // 
            // LblNationailty
            // 
            this.LblNationailty.AutoSize = true;
            this.LblNationailty.Location = new System.Drawing.Point(13, 361);
            this.LblNationailty.Name = "LblNationailty";
            this.LblNationailty.Size = new System.Drawing.Size(60, 13);
            this.LblNationailty.TabIndex = 78;
            this.LblNationailty.Text = "Nationalität";
            // 
            // LblZipCode
            // 
            this.LblZipCode.AutoSize = true;
            this.LblZipCode.Location = new System.Drawing.Point(13, 335);
            this.LblZipCode.Name = "LblZipCode";
            this.LblZipCode.Size = new System.Drawing.Size(34, 13);
            this.LblZipCode.TabIndex = 77;
            this.LblZipCode.Text = "PLZ *";
            // 
            // LblLoe
            // 
            this.LblLoe.AutoSize = true;
            this.LblLoe.Location = new System.Drawing.Point(399, 181);
            this.LblLoe.Name = "LblLoe";
            this.LblLoe.Size = new System.Drawing.Size(106, 13);
            this.LblLoe.TabIndex = 84;
            this.LblLoe.Text = "Anstellungsgrad (%) *";
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Location = new System.Drawing.Point(399, 155);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(43, 13);
            this.LblEmail.TabIndex = 83;
            this.LblEmail.Text = "E-Mail *";
            // 
            // LblFax
            // 
            this.LblFax.AutoSize = true;
            this.LblFax.Location = new System.Drawing.Point(399, 129);
            this.LblFax.Name = "LblFax";
            this.LblFax.Size = new System.Drawing.Size(41, 13);
            this.LblFax.TabIndex = 82;
            this.LblFax.Text = "Fax Nr.";
            // 
            // LblPhoneCompany
            // 
            this.LblPhoneCompany.AutoSize = true;
            this.LblPhoneCompany.Location = new System.Drawing.Point(399, 103);
            this.LblPhoneCompany.Name = "LblPhoneCompany";
            this.LblPhoneCompany.Size = new System.Drawing.Size(89, 13);
            this.LblPhoneCompany.TabIndex = 81;
            this.LblPhoneCompany.Text = "Telefon Geschäft";
            // 
            // LblManagementLevel
            // 
            this.LblManagementLevel.AutoSize = true;
            this.LblManagementLevel.Location = new System.Drawing.Point(399, 289);
            this.LblManagementLevel.Name = "LblManagementLevel";
            this.LblManagementLevel.Size = new System.Drawing.Size(65, 13);
            this.LblManagementLevel.TabIndex = 88;
            this.LblManagementLevel.Text = "Kaderstufe *";
            // 
            // LblRole
            // 
            this.LblRole.AutoSize = true;
            this.LblRole.Location = new System.Drawing.Point(399, 263);
            this.LblRole.Name = "LblRole";
            this.LblRole.Size = new System.Drawing.Size(55, 13);
            this.LblRole.TabIndex = 87;
            this.LblRole.Text = "Tätigkeit *";
            // 
            // LblExitDate
            // 
            this.LblExitDate.AutoSize = true;
            this.LblExitDate.Location = new System.Drawing.Point(399, 237);
            this.LblExitDate.Name = "LblExitDate";
            this.LblExitDate.Size = new System.Drawing.Size(39, 13);
            this.LblExitDate.TabIndex = 86;
            this.LblExitDate.Text = "Austritt";
            // 
            // LblEntryDate
            // 
            this.LblEntryDate.AutoSize = true;
            this.LblEntryDate.Location = new System.Drawing.Point(399, 211);
            this.LblEntryDate.Name = "LblEntryDate";
            this.LblEntryDate.Size = new System.Drawing.Size(43, 13);
            this.LblEntryDate.TabIndex = 85;
            this.LblEntryDate.Text = "Eintritt *";
            // 
            // LblCurrentApprenticeYear
            // 
            this.LblCurrentApprenticeYear.AutoSize = true;
            this.LblCurrentApprenticeYear.Location = new System.Drawing.Point(399, 339);
            this.LblCurrentApprenticeYear.Name = "LblCurrentApprenticeYear";
            this.LblCurrentApprenticeYear.Size = new System.Drawing.Size(91, 13);
            this.LblCurrentApprenticeYear.TabIndex = 90;
            this.LblCurrentApprenticeYear.Text = "Aktuelles Lehrjahr";
            // 
            // LblApprenticeYears
            // 
            this.LblApprenticeYears.AutoSize = true;
            this.LblApprenticeYears.Location = new System.Drawing.Point(399, 313);
            this.LblApprenticeYears.Name = "LblApprenticeYears";
            this.LblApprenticeYears.Size = new System.Drawing.Size(86, 13);
            this.LblApprenticeYears.TabIndex = 89;
            this.LblApprenticeYears.Text = "Anzahl Lehrjahre";
            // 
            // LblPrivate
            // 
            this.LblPrivate.AutoSize = true;
            this.LblPrivate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrivate.Location = new System.Drawing.Point(13, 13);
            this.LblPrivate.Name = "LblPrivate";
            this.LblPrivate.Size = new System.Drawing.Size(51, 18);
            this.LblPrivate.TabIndex = 91;
            this.LblPrivate.Text = "Privat";
            // 
            // LblCompany
            // 
            this.LblCompany.AutoSize = true;
            this.LblCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCompany.Location = new System.Drawing.Point(399, 13);
            this.LblCompany.Name = "LblCompany";
            this.LblCompany.Size = new System.Drawing.Size(102, 18);
            this.LblCompany.TabIndex = 92;
            this.LblCompany.Text = "Geschäftlich";
            // 
            // employeeDialogBindingSource
            // 
            this.employeeDialogBindingSource.DataSource = typeof(Contact_Manager.Partials.Dialog.EmployeeDialog);
            // 
            // LblInfo
            // 
            this.LblInfo.AutoSize = true;
            this.LblInfo.Location = new System.Drawing.Point(282, 13);
            this.LblInfo.Name = "LblInfo";
            this.LblInfo.Size = new System.Drawing.Size(69, 13);
            this.LblInfo.TabIndex = 93;
            this.LblInfo.Text = "* = Pflichtfeld";
            // 
            // EmployeeDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 453);
            this.Controls.Add(this.LblInfo);
            this.Controls.Add(this.LblCompany);
            this.Controls.Add(this.LblPrivate);
            this.Controls.Add(this.LblCurrentApprenticeYear);
            this.Controls.Add(this.LblApprenticeYears);
            this.Controls.Add(this.LblManagementLevel);
            this.Controls.Add(this.LblRole);
            this.Controls.Add(this.LblExitDate);
            this.Controls.Add(this.LblEntryDate);
            this.Controls.Add(this.LblLoe);
            this.Controls.Add(this.LblEmail);
            this.Controls.Add(this.LblFax);
            this.Controls.Add(this.LblPhoneCompany);
            this.Controls.Add(this.LblDepartement);
            this.Controls.Add(this.LblEmployeeNumber);
            this.Controls.Add(this.LblNationailty);
            this.Controls.Add(this.LblZipCode);
            this.Controls.Add(this.LblCity);
            this.Controls.Add(this.LblAddress);
            this.Controls.Add(this.LblDateOfBirth);
            this.Controls.Add(this.LblAhv);
            this.Controls.Add(this.LblMobile);
            this.Controls.Add(this.LblPhonePrivate);
            this.Controls.Add(this.LblSurName);
            this.Controls.Add(this.LblFirstName);
            this.Controls.Add(this.LblGender);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.LblSalutation);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.ChkApprentice);
            this.Controls.Add(this.ChkStatus);
            this.Controls.Add(this.CmbCurrentApprenticeYear);
            this.Controls.Add(this.CmbApprenticeYears);
            this.Controls.Add(this.CmbManagementLevel);
            this.Controls.Add(this.txtRole);
            this.Controls.Add(this.DtpExitDate);
            this.Controls.Add(this.DtpEntryDate);
            this.Controls.Add(this.CmbLoe);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtFax);
            this.Controls.Add(this.txtPhoneCompany);
            this.Controls.Add(this.txtDepartement);
            this.Controls.Add(this.txtEmployeeNumber);
            this.Controls.Add(this.CmbNationality);
            this.Controls.Add(this.txtZipCode);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtPhonePrivate);
            this.Controls.Add(this.txtAhv);
            this.Controls.Add(this.txtMobile);
            this.Controls.Add(this.DtpDateOfBirth);
            this.Controls.Add(this.txtSurName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.rbOther);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.CmbTitle);
            this.Controls.Add(this.CmbSalutation);
            this.Name = "EmployeeDialog";
            this.Text = "EmployeeDialog";
            this.Load += new System.EventHandler(this.EmployeeDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeDialogBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "EmployeeDialog";

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox ChkApprentice;
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
        private System.Windows.Forms.Label LblSalutation;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Label LblGender;
        private System.Windows.Forms.Label LblFirstName;
        private System.Windows.Forms.Label LblSurName;
        private System.Windows.Forms.Label LblPhonePrivate;
        private System.Windows.Forms.Label LblMobile;
        private System.Windows.Forms.TextBox txtEmployeeNumber;
        private System.Windows.Forms.Label LblCity;
        private System.Windows.Forms.Label LblAddress;
        private System.Windows.Forms.Label LblDateOfBirth;
        private System.Windows.Forms.Label LblAhv;
        private System.Windows.Forms.Label LblDepartement;
        private System.Windows.Forms.Label LblEmployeeNumber;
        private System.Windows.Forms.Label LblNationailty;
        private System.Windows.Forms.Label LblZipCode;
        private System.Windows.Forms.Label LblLoe;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.Label LblFax;
        private System.Windows.Forms.Label LblPhoneCompany;
        private System.Windows.Forms.Label LblManagementLevel;
        private System.Windows.Forms.Label LblRole;
        private System.Windows.Forms.Label LblExitDate;
        private System.Windows.Forms.Label LblEntryDate;
        private System.Windows.Forms.Label LblCurrentApprenticeYear;
        private System.Windows.Forms.Label LblApprenticeYears;
        private System.Windows.Forms.Label LblPrivate;
        private System.Windows.Forms.Label LblCompany;
        private System.Windows.Forms.BindingSource employeeDialogBindingSource;
        private System.Windows.Forms.Label LblInfo;
    }
}