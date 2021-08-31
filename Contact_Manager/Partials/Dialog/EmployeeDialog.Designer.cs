
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
            this.ChkStatus = new System.Windows.Forms.CheckBox();
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
            this.LblCity = new System.Windows.Forms.Label();
            this.LblAddress = new System.Windows.Forms.Label();
            this.LblDateOfBirth = new System.Windows.Forms.Label();
            this.LblAhv = new System.Windows.Forms.Label();
            this.LblDepartement = new System.Windows.Forms.Label();
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
            this.LblInfo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.employeeDialogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDialogBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSave.Location = new System.Drawing.Point(13, 735);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(539, 28);
            this.btnSave.TabIndex = 64;
            this.btnSave.Text = "Speichern";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ChkStatus
            // 
            this.ChkStatus.AutoSize = true;
            this.ChkStatus.Checked = true;
            this.ChkStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkStatus.Location = new System.Drawing.Point(365, 249);
            this.ChkStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ChkStatus.Name = "ChkStatus";
            this.ChkStatus.Size = new System.Drawing.Size(144, 21);
            this.ChkStatus.TabIndex = 62;
            this.ChkStatus.Text = "Aktiver Mitarbeiter";
            this.ChkStatus.UseVisualStyleBackColor = true;
            this.ChkStatus.CheckedChanged += new System.EventHandler(this.ChkStatus_CheckedChanged);
            // 
            // CmbManagementLevel
            // 
            this.CmbManagementLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbManagementLevel.FormattingEnabled = true;
            this.CmbManagementLevel.Location = new System.Drawing.Point(28, 246);
            this.CmbManagementLevel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CmbManagementLevel.Name = "CmbManagementLevel";
            this.CmbManagementLevel.Size = new System.Drawing.Size(243, 24);
            this.CmbManagementLevel.TabIndex = 59;
            // 
            // txtRole
            // 
            this.txtRole.Location = new System.Drawing.Point(280, 150);
            this.txtRole.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(232, 22);
            this.txtRole.TabIndex = 58;
            // 
            // DtpExitDate
            // 
            this.DtpExitDate.Enabled = false;
            this.DtpExitDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpExitDate.Location = new System.Drawing.Point(280, 198);
            this.DtpExitDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DtpExitDate.Name = "DtpExitDate";
            this.DtpExitDate.Size = new System.Drawing.Size(232, 22);
            this.DtpExitDate.TabIndex = 57;
            // 
            // DtpEntryDate
            // 
            this.DtpEntryDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpEntryDate.Location = new System.Drawing.Point(28, 198);
            this.DtpEntryDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DtpEntryDate.Name = "DtpEntryDate";
            this.DtpEntryDate.Size = new System.Drawing.Size(243, 22);
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
            this.CmbLoe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbLoe.FormattingEnabled = true;
            this.CmbLoe.Location = new System.Drawing.Point(28, 149);
            this.CmbLoe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CmbLoe.Name = "CmbLoe";
            this.CmbLoe.Size = new System.Drawing.Size(243, 24);
            this.CmbLoe.TabIndex = 55;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(280, 102);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(232, 22);
            this.txtEmail.TabIndex = 54;
            // 
            // txtFax
            // 
            this.txtFax.Location = new System.Drawing.Point(28, 102);
            this.txtFax.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(243, 22);
            this.txtFax.TabIndex = 53;
            // 
            // txtPhoneCompany
            // 
            this.txtPhoneCompany.Location = new System.Drawing.Point(280, 54);
            this.txtPhoneCompany.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPhoneCompany.Name = "txtPhoneCompany";
            this.txtPhoneCompany.Size = new System.Drawing.Size(232, 22);
            this.txtPhoneCompany.TabIndex = 52;
            // 
            // txtDepartement
            // 
            this.txtDepartement.Location = new System.Drawing.Point(28, 54);
            this.txtDepartement.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDepartement.Name = "txtDepartement";
            this.txtDepartement.Size = new System.Drawing.Size(243, 22);
            this.txtDepartement.TabIndex = 51;
            // 
            // CmbNationality
            // 
            this.CmbNationality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbNationality.FormattingEnabled = true;
            this.CmbNationality.Location = new System.Drawing.Point(280, 338);
            this.CmbNationality.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CmbNationality.Name = "CmbNationality";
            this.CmbNationality.Size = new System.Drawing.Size(232, 24);
            this.CmbNationality.Sorted = true;
            this.CmbNationality.TabIndex = 47;
            // 
            // txtZipCode
            // 
            this.txtZipCode.Location = new System.Drawing.Point(28, 340);
            this.txtZipCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(243, 22);
            this.txtZipCode.TabIndex = 46;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(280, 292);
            this.txtCity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(232, 22);
            this.txtCity.TabIndex = 45;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(28, 292);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(243, 22);
            this.txtAddress.TabIndex = 44;
            // 
            // txtPhonePrivate
            // 
            this.txtPhonePrivate.Location = new System.Drawing.Point(28, 196);
            this.txtPhonePrivate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPhonePrivate.Name = "txtPhonePrivate";
            this.txtPhonePrivate.Size = new System.Drawing.Size(243, 22);
            this.txtPhonePrivate.TabIndex = 40;
            // 
            // txtAhv
            // 
            this.txtAhv.Location = new System.Drawing.Point(28, 244);
            this.txtAhv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAhv.Name = "txtAhv";
            this.txtAhv.Size = new System.Drawing.Size(243, 22);
            this.txtAhv.TabIndex = 42;
            // 
            // txtMobile
            // 
            this.txtMobile.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtMobile.Location = new System.Drawing.Point(280, 196);
            this.txtMobile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(232, 22);
            this.txtMobile.TabIndex = 41;
            // 
            // DtpDateOfBirth
            // 
            this.DtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpDateOfBirth.Location = new System.Drawing.Point(280, 244);
            this.DtpDateOfBirth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DtpDateOfBirth.Name = "DtpDateOfBirth";
            this.DtpDateOfBirth.Size = new System.Drawing.Size(232, 22);
            this.DtpDateOfBirth.TabIndex = 43;
            // 
            // txtSurName
            // 
            this.txtSurName.Location = new System.Drawing.Point(280, 148);
            this.txtSurName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSurName.Name = "txtSurName";
            this.txtSurName.Size = new System.Drawing.Size(232, 22);
            this.txtSurName.TabIndex = 39;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(28, 148);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(243, 22);
            this.txtFirstName.TabIndex = 38;
            // 
            // rbOther
            // 
            this.rbOther.AutoSize = true;
            this.rbOther.Checked = true;
            this.rbOther.Location = new System.Drawing.Point(273, 103);
            this.rbOther.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbOther.Name = "rbOther";
            this.rbOther.Size = new System.Drawing.Size(82, 21);
            this.rbOther.TabIndex = 37;
            this.rbOther.TabStop = true;
            this.rbOther.Text = "Anderes";
            this.rbOther.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(151, 103);
            this.rbFemale.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(82, 21);
            this.rbFemale.TabIndex = 36;
            this.rbFemale.Text = "Weiblich";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(28, 103);
            this.rbMale.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(85, 21);
            this.rbMale.TabIndex = 35;
            this.rbMale.Text = "Männlich";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // CmbTitle
            // 
            this.CmbTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTitle.FormattingEnabled = true;
            this.CmbTitle.Location = new System.Drawing.Point(280, 54);
            this.CmbTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CmbTitle.Name = "CmbTitle";
            this.CmbTitle.Size = new System.Drawing.Size(232, 24);
            this.CmbTitle.TabIndex = 34;
            // 
            // CmbSalutation
            // 
            this.CmbSalutation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbSalutation.FormattingEnabled = true;
            this.CmbSalutation.Location = new System.Drawing.Point(28, 54);
            this.CmbSalutation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CmbSalutation.Name = "CmbSalutation";
            this.CmbSalutation.Size = new System.Drawing.Size(243, 24);
            this.CmbSalutation.TabIndex = 33;
            // 
            // LblSalutation
            // 
            this.LblSalutation.AutoSize = true;
            this.LblSalutation.Location = new System.Drawing.Point(24, 34);
            this.LblSalutation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblSalutation.Name = "LblSalutation";
            this.LblSalutation.Size = new System.Drawing.Size(63, 17);
            this.LblSalutation.TabIndex = 66;
            this.LblSalutation.Text = "Anrede *";
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Location = new System.Drawing.Point(276, 34);
            this.LblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(35, 17);
            this.LblTitle.TabIndex = 67;
            this.LblTitle.Text = "Titel";
            // 
            // LblGender
            // 
            this.LblGender.AutoSize = true;
            this.LblGender.Location = new System.Drawing.Point(24, 84);
            this.LblGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblGender.Name = "LblGender";
            this.LblGender.Size = new System.Drawing.Size(88, 17);
            this.LblGender.TabIndex = 68;
            this.LblGender.Text = "Geschlecht *";
            // 
            // LblFirstName
            // 
            this.LblFirstName.AutoSize = true;
            this.LblFirstName.Location = new System.Drawing.Point(24, 128);
            this.LblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblFirstName.Name = "LblFirstName";
            this.LblFirstName.Size = new System.Drawing.Size(74, 17);
            this.LblFirstName.TabIndex = 69;
            this.LblFirstName.Text = "Vorname *";
            // 
            // LblSurName
            // 
            this.LblSurName.AutoSize = true;
            this.LblSurName.Location = new System.Drawing.Point(276, 128);
            this.LblSurName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblSurName.Name = "LblSurName";
            this.LblSurName.Size = new System.Drawing.Size(85, 17);
            this.LblSurName.TabIndex = 70;
            this.LblSurName.Text = "Nachname *";
            // 
            // LblPhonePrivate
            // 
            this.LblPhonePrivate.AutoSize = true;
            this.LblPhonePrivate.Location = new System.Drawing.Point(24, 176);
            this.LblPhonePrivate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPhonePrivate.Name = "LblPhonePrivate";
            this.LblPhonePrivate.Size = new System.Drawing.Size(96, 17);
            this.LblPhonePrivate.TabIndex = 71;
            this.LblPhonePrivate.Text = "Telefon Privat";
            // 
            // LblMobile
            // 
            this.LblMobile.AutoSize = true;
            this.LblMobile.Location = new System.Drawing.Point(276, 176);
            this.LblMobile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblMobile.Name = "LblMobile";
            this.LblMobile.Size = new System.Drawing.Size(58, 17);
            this.LblMobile.TabIndex = 72;
            this.LblMobile.Text = "Mobile *";
            // 
            // LblCity
            // 
            this.LblCity.AutoSize = true;
            this.LblCity.Location = new System.Drawing.Point(276, 272);
            this.LblCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCity.Name = "LblCity";
            this.LblCity.Size = new System.Drawing.Size(37, 17);
            this.LblCity.TabIndex = 76;
            this.LblCity.Text = "Ort *";
            // 
            // LblAddress
            // 
            this.LblAddress.AutoSize = true;
            this.LblAddress.Location = new System.Drawing.Point(24, 272);
            this.LblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblAddress.Name = "LblAddress";
            this.LblAddress.Size = new System.Drawing.Size(96, 17);
            this.LblAddress.TabIndex = 75;
            this.LblAddress.Text = "Strasse / Nr. *";
            // 
            // LblDateOfBirth
            // 
            this.LblDateOfBirth.AutoSize = true;
            this.LblDateOfBirth.Location = new System.Drawing.Point(276, 224);
            this.LblDateOfBirth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblDateOfBirth.Name = "LblDateOfBirth";
            this.LblDateOfBirth.Size = new System.Drawing.Size(107, 17);
            this.LblDateOfBirth.TabIndex = 74;
            this.LblDateOfBirth.Text = "Geburtsdatum *";
            // 
            // LblAhv
            // 
            this.LblAhv.AutoSize = true;
            this.LblAhv.Location = new System.Drawing.Point(27, 224);
            this.LblAhv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblAhv.Name = "LblAhv";
            this.LblAhv.Size = new System.Drawing.Size(59, 17);
            this.LblAhv.TabIndex = 73;
            this.LblAhv.Text = "AHV Nr.";
            // 
            // LblDepartement
            // 
            this.LblDepartement.AutoSize = true;
            this.LblDepartement.Location = new System.Drawing.Point(24, 34);
            this.LblDepartement.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblDepartement.Name = "LblDepartement";
            this.LblDepartement.Size = new System.Drawing.Size(76, 17);
            this.LblDepartement.TabIndex = 80;
            this.LblDepartement.Text = "Abteilung *";
            // 
            // LblNationailty
            // 
            this.LblNationailty.AutoSize = true;
            this.LblNationailty.Location = new System.Drawing.Point(276, 320);
            this.LblNationailty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNationailty.Name = "LblNationailty";
            this.LblNationailty.Size = new System.Drawing.Size(79, 17);
            this.LblNationailty.TabIndex = 78;
            this.LblNationailty.Text = "Nationalität";
            // 
            // LblZipCode
            // 
            this.LblZipCode.AutoSize = true;
            this.LblZipCode.Location = new System.Drawing.Point(24, 320);
            this.LblZipCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblZipCode.Name = "LblZipCode";
            this.LblZipCode.Size = new System.Drawing.Size(43, 17);
            this.LblZipCode.TabIndex = 77;
            this.LblZipCode.Text = "PLZ *";
            // 
            // LblLoe
            // 
            this.LblLoe.AutoSize = true;
            this.LblLoe.Location = new System.Drawing.Point(24, 130);
            this.LblLoe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblLoe.Name = "LblLoe";
            this.LblLoe.Size = new System.Drawing.Size(145, 17);
            this.LblLoe.TabIndex = 84;
            this.LblLoe.Text = "Anstellungsgrad (%) *";
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Location = new System.Drawing.Point(280, 82);
            this.LblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(56, 17);
            this.LblEmail.TabIndex = 83;
            this.LblEmail.Text = "E-Mail *";
            // 
            // LblFax
            // 
            this.LblFax.AutoSize = true;
            this.LblFax.Location = new System.Drawing.Point(24, 82);
            this.LblFax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblFax.Name = "LblFax";
            this.LblFax.Size = new System.Drawing.Size(53, 17);
            this.LblFax.TabIndex = 82;
            this.LblFax.Text = "Fax Nr.";
            // 
            // LblPhoneCompany
            // 
            this.LblPhoneCompany.AutoSize = true;
            this.LblPhoneCompany.Location = new System.Drawing.Point(276, 34);
            this.LblPhoneCompany.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPhoneCompany.Name = "LblPhoneCompany";
            this.LblPhoneCompany.Size = new System.Drawing.Size(117, 17);
            this.LblPhoneCompany.TabIndex = 81;
            this.LblPhoneCompany.Text = "Telefon Geschäft";
            // 
            // LblManagementLevel
            // 
            this.LblManagementLevel.AutoSize = true;
            this.LblManagementLevel.Location = new System.Drawing.Point(24, 226);
            this.LblManagementLevel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblManagementLevel.Name = "LblManagementLevel";
            this.LblManagementLevel.Size = new System.Drawing.Size(86, 17);
            this.LblManagementLevel.TabIndex = 88;
            this.LblManagementLevel.Text = "Kaderstufe *";
            // 
            // LblRole
            // 
            this.LblRole.AutoSize = true;
            this.LblRole.Location = new System.Drawing.Point(276, 130);
            this.LblRole.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblRole.Name = "LblRole";
            this.LblRole.Size = new System.Drawing.Size(71, 17);
            this.LblRole.TabIndex = 87;
            this.LblRole.Text = "Tätigkeit *";
            // 
            // LblExitDate
            // 
            this.LblExitDate.AutoSize = true;
            this.LblExitDate.Location = new System.Drawing.Point(276, 178);
            this.LblExitDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblExitDate.Name = "LblExitDate";
            this.LblExitDate.Size = new System.Drawing.Size(52, 17);
            this.LblExitDate.TabIndex = 86;
            this.LblExitDate.Text = "Austritt";
            // 
            // LblEntryDate
            // 
            this.LblEntryDate.AutoSize = true;
            this.LblEntryDate.Location = new System.Drawing.Point(24, 178);
            this.LblEntryDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblEntryDate.Name = "LblEntryDate";
            this.LblEntryDate.Size = new System.Drawing.Size(57, 17);
            this.LblEntryDate.TabIndex = 85;
            this.LblEntryDate.Text = "Eintritt *";
            // 
            // LblInfo
            // 
            this.LblInfo.AutoSize = true;
            this.LblInfo.Location = new System.Drawing.Point(423, 20);
            this.LblInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblInfo.Name = "LblInfo";
            this.LblInfo.Size = new System.Drawing.Size(90, 17);
            this.LblInfo.TabIndex = 93;
            this.LblInfo.Text = "* = Pflichtfeld";
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
            this.groupBox1.Controls.Add(this.LblNationailty);
            this.groupBox1.Controls.Add(this.CmbNationality);
            this.groupBox1.Controls.Add(this.rbOther);
            this.groupBox1.Controls.Add(this.LblZipCode);
            this.groupBox1.Controls.Add(this.rbMale);
            this.groupBox1.Controls.Add(this.txtZipCode);
            this.groupBox1.Controls.Add(this.LblCity);
            this.groupBox1.Controls.Add(this.rbFemale);
            this.groupBox1.Controls.Add(this.LblAddress);
            this.groupBox1.Controls.Add(this.LblFirstName);
            this.groupBox1.Controls.Add(this.LblDateOfBirth);
            this.groupBox1.Controls.Add(this.txtCity);
            this.groupBox1.Controls.Add(this.txtFirstName);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.LblAhv);
            this.groupBox1.Controls.Add(this.txtSurName);
            this.groupBox1.Controls.Add(this.LblMobile);
            this.groupBox1.Controls.Add(this.DtpDateOfBirth);
            this.groupBox1.Controls.Add(this.LblSurName);
            this.groupBox1.Controls.Add(this.LblPhonePrivate);
            this.groupBox1.Controls.Add(this.txtAhv);
            this.groupBox1.Controls.Add(this.txtPhonePrivate);
            this.groupBox1.Controls.Add(this.txtMobile);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(20, 18, 20, 18);
            this.groupBox1.Size = new System.Drawing.Size(539, 399);
            this.groupBox1.TabIndex = 94;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Privat";
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.LblDepartement);
            this.groupBox2.Controls.Add(this.txtDepartement);
            this.groupBox2.Controls.Add(this.txtPhoneCompany);
            this.groupBox2.Controls.Add(this.LblPhoneCompany);
            this.groupBox2.Controls.Add(this.LblFax);
            this.groupBox2.Controls.Add(this.LblManagementLevel);
            this.groupBox2.Controls.Add(this.txtFax);
            this.groupBox2.Controls.Add(this.LblExitDate);
            this.groupBox2.Controls.Add(this.LblRole);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.LblEmail);
            this.groupBox2.Controls.Add(this.LblEntryDate);
            this.groupBox2.Controls.Add(this.LblLoe);
            this.groupBox2.Controls.Add(this.CmbLoe);
            this.groupBox2.Controls.Add(this.DtpEntryDate);
            this.groupBox2.Controls.Add(this.txtRole);
            this.groupBox2.Controls.Add(this.DtpExitDate);
            this.groupBox2.Controls.Add(this.CmbManagementLevel);
            this.groupBox2.Controls.Add(this.ChkStatus);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(13, 411);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(20, 18, 20, 18);
            this.groupBox2.Size = new System.Drawing.Size(539, 307);
            this.groupBox2.TabIndex = 95;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Geschäftlich";
            // 
            // employeeDialogBindingSource
            // 
            this.employeeDialogBindingSource.DataSource = typeof(Contact_Manager.Partials.Dialog.EmployeeDialog);
            // 
            // EmployeeDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(565, 775);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSave);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EmployeeDialog";
            this.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.Text = "Mitarbeiter";
            this.Load += new System.EventHandler(this.EmployeeDialog_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDialogBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox ChkStatus;
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
        private System.Windows.Forms.Label LblCity;
        private System.Windows.Forms.Label LblAddress;
        private System.Windows.Forms.Label LblDateOfBirth;
        private System.Windows.Forms.Label LblAhv;
        private System.Windows.Forms.Label LblDepartement;
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
        private System.Windows.Forms.BindingSource employeeDialogBindingSource;
        private System.Windows.Forms.Label LblInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}