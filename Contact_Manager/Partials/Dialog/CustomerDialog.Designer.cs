
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
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.ChkStatus = new System.Windows.Forms.CheckBox();
            this.BtnAddNote = new System.Windows.Forms.Button();
            this.txtAddNote = new System.Windows.Forms.TextBox();
            this.dataGridNotes = new System.Windows.Forms.DataGridView();
            this.GrpBoxCompanyData = new System.Windows.Forms.GroupBox();
            this.LblInfo = new System.Windows.Forms.Label();
            this.LblZip = new System.Windows.Forms.Label();
            this.LblCity = new System.Windows.Forms.Label();
            this.LblAddress = new System.Windows.Forms.Label();
            this.LblCustomerType = new System.Windows.Forms.Label();
            this.LblCompany = new System.Windows.Forms.Label();
            this.GrpBoxContactPerson = new System.Windows.Forms.GroupBox();
            this.LblDateOfBirth = new System.Windows.Forms.Label();
            this.LblEmail = new System.Windows.Forms.Label();
            this.LblNation = new System.Windows.Forms.Label();
            this.LblLastName = new System.Windows.Forms.Label();
            this.LblFirstName = new System.Windows.Forms.Label();
            this.LblFax = new System.Windows.Forms.Label();
            this.LblGender = new System.Windows.Forms.Label();
            this.LblMobilePhone = new System.Windows.Forms.Label();
            this.LblTitle = new System.Windows.Forms.Label();
            this.LblPhoneBusiness = new System.Windows.Forms.Label();
            this.LblSalutation = new System.Windows.Forms.Label();
            this.LblPhonePrivate = new System.Windows.Forms.Label();
            this.PnlMainData = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.GrpBoxNotes = new System.Windows.Forms.GroupBox();
            this.LblNote = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNotes)).BeginInit();
            this.GrpBoxCompanyData.SuspendLayout();
            this.GrpBoxContactPerson.SuspendLayout();
            this.PnlMainData.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.GrpBoxNotes.SuspendLayout();
            this.SuspendLayout();
            // 
            // DtpDateOfBirth
            // 
            this.DtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpDateOfBirth.Location = new System.Drawing.Point(273, 350);
            this.DtpDateOfBirth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DtpDateOfBirth.Name = "DtpDateOfBirth";
            this.DtpDateOfBirth.Size = new System.Drawing.Size(243, 22);
            this.DtpDateOfBirth.TabIndex = 20;
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
            this.CmbCustomerType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCustomerType.FormattingEnabled = true;
            this.CmbCustomerType.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E"});
            this.CmbCustomerType.Location = new System.Drawing.Point(273, 47);
            this.CmbCustomerType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CmbCustomerType.Name = "CmbCustomerType";
            this.CmbCustomerType.Size = new System.Drawing.Size(243, 24);
            this.CmbCustomerType.TabIndex = 2;
            // 
            // txtFax
            // 
            this.txtFax.Location = new System.Drawing.Point(273, 252);
            this.txtFax.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(243, 22);
            this.txtFax.TabIndex = 17;
            // 
            // txtPhoneCompany
            // 
            this.txtPhoneCompany.Location = new System.Drawing.Point(273, 204);
            this.txtPhoneCompany.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPhoneCompany.Name = "txtPhoneCompany";
            this.txtPhoneCompany.Size = new System.Drawing.Size(243, 22);
            this.txtPhoneCompany.TabIndex = 15;
            // 
            // CmbNationality
            // 
            this.CmbNationality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbNationality.FormattingEnabled = true;
            this.CmbNationality.Location = new System.Drawing.Point(21, 348);
            this.CmbNationality.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CmbNationality.Name = "CmbNationality";
            this.CmbNationality.Size = new System.Drawing.Size(243, 24);
            this.CmbNationality.TabIndex = 19;
            // 
            // txtZipCode
            // 
            this.txtZipCode.Location = new System.Drawing.Point(21, 144);
            this.txtZipCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(243, 22);
            this.txtZipCode.TabIndex = 4;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(273, 144);
            this.txtCity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(243, 22);
            this.txtCity.TabIndex = 5;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(21, 96);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(495, 22);
            this.txtAddress.TabIndex = 3;
            // 
            // txtPhonePrivate
            // 
            this.txtPhonePrivate.Location = new System.Drawing.Point(21, 204);
            this.txtPhonePrivate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPhonePrivate.Name = "txtPhonePrivate";
            this.txtPhonePrivate.Size = new System.Drawing.Size(243, 22);
            this.txtPhonePrivate.TabIndex = 14;
            // 
            // txtMobile
            // 
            this.txtMobile.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtMobile.Location = new System.Drawing.Point(21, 252);
            this.txtMobile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(243, 22);
            this.txtMobile.TabIndex = 16;
            // 
            // txtSurName
            // 
            this.txtSurName.Location = new System.Drawing.Point(273, 156);
            this.txtSurName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSurName.Name = "txtSurName";
            this.txtSurName.Size = new System.Drawing.Size(243, 22);
            this.txtSurName.TabIndex = 13;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(21, 156);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(243, 22);
            this.txtFirstName.TabIndex = 12;
            // 
            // rbOther
            // 
            this.rbOther.AutoSize = true;
            this.rbOther.Checked = true;
            this.rbOther.Location = new System.Drawing.Point(263, 107);
            this.rbOther.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbOther.Name = "rbOther";
            this.rbOther.Size = new System.Drawing.Size(82, 21);
            this.rbOther.TabIndex = 11;
            this.rbOther.TabStop = true;
            this.rbOther.Text = "Anderes";
            this.rbOther.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(136, 107);
            this.rbFemale.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(82, 21);
            this.rbFemale.TabIndex = 10;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Weiblich";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(21, 107);
            this.rbMale.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(85, 21);
            this.rbMale.TabIndex = 9;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Männlich";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // CmbTitle
            // 
            this.CmbTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.CmbTitle.Location = new System.Drawing.Point(273, 53);
            this.CmbTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CmbTitle.Name = "CmbTitle";
            this.CmbTitle.Size = new System.Drawing.Size(243, 24);
            this.CmbTitle.TabIndex = 8;
            // 
            // CmbSalutation
            // 
            this.CmbSalutation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbSalutation.FormattingEnabled = true;
            this.CmbSalutation.Items.AddRange(new object[] {
            "Herr",
            "Frau"});
            this.CmbSalutation.Location = new System.Drawing.Point(21, 53);
            this.CmbSalutation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CmbSalutation.Name = "CmbSalutation";
            this.CmbSalutation.Size = new System.Drawing.Size(243, 24);
            this.CmbSalutation.TabIndex = 7;
            // 
            // btnCompanyDelete
            // 
            this.btnCompanyDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCompanyDelete.Location = new System.Drawing.Point(276, 4);
            this.btnCompanyDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCompanyDelete.Name = "btnCompanyDelete";
            this.btnCompanyDelete.Size = new System.Drawing.Size(264, 30);
            this.btnCompanyDelete.TabIndex = 22;
            this.btnCompanyDelete.Text = "Eingaben löschen";
            this.btnCompanyDelete.UseVisualStyleBackColor = true;
            this.btnCompanyDelete.Click += new System.EventHandler(this.btnCompanyDelete_Click);
            // 
            // btnCompanySave
            // 
            this.btnCompanySave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCompanySave.Location = new System.Drawing.Point(4, 4);
            this.btnCompanySave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCompanySave.Name = "btnCompanySave";
            this.btnCompanySave.Size = new System.Drawing.Size(264, 30);
            this.btnCompanySave.TabIndex = 21;
            this.btnCompanySave.Text = "Speichern";
            this.btnCompanySave.UseVisualStyleBackColor = true;
            this.btnCompanySave.Click += new System.EventHandler(this.btnCompanySave_Click);
            // 
            // txtCompanyContactEmail
            // 
            this.txtCompanyContactEmail.Location = new System.Drawing.Point(21, 300);
            this.txtCompanyContactEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCompanyContactEmail.Name = "txtCompanyContactEmail";
            this.txtCompanyContactEmail.Size = new System.Drawing.Size(495, 22);
            this.txtCompanyContactEmail.TabIndex = 18;
            // 
            // txtCompany
            // 
            this.txtCompany.Location = new System.Drawing.Point(21, 48);
            this.txtCompany.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(243, 22);
            this.txtCompany.TabIndex = 1;
            // 
            // ChkStatus
            // 
            this.ChkStatus.AutoSize = true;
            this.ChkStatus.Checked = true;
            this.ChkStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkStatus.Location = new System.Drawing.Point(21, 176);
            this.ChkStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ChkStatus.Name = "ChkStatus";
            this.ChkStatus.Size = new System.Drawing.Size(118, 21);
            this.ChkStatus.TabIndex = 6;
            this.ChkStatus.Text = "Aktiver Kunde";
            this.ChkStatus.UseVisualStyleBackColor = true;
            // 
            // BtnAddNote
            // 
            this.BtnAddNote.Location = new System.Drawing.Point(645, 176);
            this.BtnAddNote.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnAddNote.Name = "BtnAddNote";
            this.BtnAddNote.Size = new System.Drawing.Size(157, 28);
            this.BtnAddNote.TabIndex = 80;
            this.BtnAddNote.Text = "Notiz hinzufügen";
            this.BtnAddNote.UseVisualStyleBackColor = true;
            this.BtnAddNote.Click += new System.EventHandler(this.BtnAddNote_Click);
            // 
            // txtAddNote
            // 
            this.txtAddNote.Location = new System.Drawing.Point(20, 50);
            this.txtAddNote.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAddNote.Multiline = true;
            this.txtAddNote.Name = "txtAddNote";
            this.txtAddNote.Size = new System.Drawing.Size(781, 117);
            this.txtAddNote.TabIndex = 82;
            // 
            // dataGridNotes
            // 
            this.dataGridNotes.AllowUserToAddRows = false;
            this.dataGridNotes.AllowUserToDeleteRows = false;
            this.dataGridNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridNotes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridNotes.Location = new System.Drawing.Point(20, 215);
            this.dataGridNotes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridNotes.Name = "dataGridNotes";
            this.dataGridNotes.ReadOnly = true;
            this.dataGridNotes.RowHeadersWidth = 51;
            this.dataGridNotes.Size = new System.Drawing.Size(781, 458);
            this.dataGridNotes.TabIndex = 83;
            this.dataGridNotes.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridNotes_CellContentDoubleClick);
            this.dataGridNotes.Paint += new System.Windows.Forms.PaintEventHandler(this.dataGridNotes_Paint);
            // 
            // GrpBoxCompanyData
            // 
            this.GrpBoxCompanyData.AutoSize = true;
            this.GrpBoxCompanyData.Controls.Add(this.LblInfo);
            this.GrpBoxCompanyData.Controls.Add(this.LblZip);
            this.GrpBoxCompanyData.Controls.Add(this.LblCity);
            this.GrpBoxCompanyData.Controls.Add(this.LblAddress);
            this.GrpBoxCompanyData.Controls.Add(this.ChkStatus);
            this.GrpBoxCompanyData.Controls.Add(this.LblCustomerType);
            this.GrpBoxCompanyData.Controls.Add(this.LblCompany);
            this.GrpBoxCompanyData.Controls.Add(this.txtCompany);
            this.GrpBoxCompanyData.Controls.Add(this.CmbCustomerType);
            this.GrpBoxCompanyData.Controls.Add(this.txtAddress);
            this.GrpBoxCompanyData.Controls.Add(this.txtZipCode);
            this.GrpBoxCompanyData.Controls.Add(this.txtCity);
            this.GrpBoxCompanyData.Dock = System.Windows.Forms.DockStyle.Top;
            this.GrpBoxCompanyData.Location = new System.Drawing.Point(0, 0);
            this.GrpBoxCompanyData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GrpBoxCompanyData.Name = "GrpBoxCompanyData";
            this.GrpBoxCompanyData.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.GrpBoxCompanyData.Size = new System.Drawing.Size(544, 228);
            this.GrpBoxCompanyData.TabIndex = 84;
            this.GrpBoxCompanyData.TabStop = false;
            this.GrpBoxCompanyData.Text = "Firmendaten";
            // 
            // LblInfo
            // 
            this.LblInfo.AutoSize = true;
            this.LblInfo.Location = new System.Drawing.Point(425, 16);
            this.LblInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblInfo.Name = "LblInfo";
            this.LblInfo.Size = new System.Drawing.Size(90, 17);
            this.LblInfo.TabIndex = 94;
            this.LblInfo.Text = "* = Pflichtfeld";
            // 
            // LblZip
            // 
            this.LblZip.AutoSize = true;
            this.LblZip.Location = new System.Drawing.Point(17, 124);
            this.LblZip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblZip.Name = "LblZip";
            this.LblZip.Size = new System.Drawing.Size(43, 17);
            this.LblZip.TabIndex = 80;
            this.LblZip.Text = "PLZ *";
            // 
            // LblCity
            // 
            this.LblCity.AutoSize = true;
            this.LblCity.Location = new System.Drawing.Point(269, 124);
            this.LblCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCity.Name = "LblCity";
            this.LblCity.Size = new System.Drawing.Size(37, 17);
            this.LblCity.TabIndex = 79;
            this.LblCity.Text = "Ort *";
            // 
            // LblAddress
            // 
            this.LblAddress.AutoSize = true;
            this.LblAddress.Location = new System.Drawing.Point(17, 76);
            this.LblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblAddress.Name = "LblAddress";
            this.LblAddress.Size = new System.Drawing.Size(100, 17);
            this.LblAddress.TabIndex = 78;
            this.LblAddress.Text = "Strasse + Nr. *";
            // 
            // LblCustomerType
            // 
            this.LblCustomerType.AutoSize = true;
            this.LblCustomerType.Location = new System.Drawing.Point(269, 28);
            this.LblCustomerType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCustomerType.Name = "LblCustomerType";
            this.LblCustomerType.Size = new System.Drawing.Size(85, 17);
            this.LblCustomerType.TabIndex = 55;
            this.LblCustomerType.Text = "Kundentyp *";
            // 
            // LblCompany
            // 
            this.LblCompany.AutoSize = true;
            this.LblCompany.Location = new System.Drawing.Point(17, 28);
            this.LblCompany.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCompany.Name = "LblCompany";
            this.LblCompany.Size = new System.Drawing.Size(103, 17);
            this.LblCompany.TabIndex = 0;
            this.LblCompany.Text = "Unternehmen *";
            // 
            // GrpBoxContactPerson
            // 
            this.GrpBoxContactPerson.AutoSize = true;
            this.GrpBoxContactPerson.Controls.Add(this.LblDateOfBirth);
            this.GrpBoxContactPerson.Controls.Add(this.LblEmail);
            this.GrpBoxContactPerson.Controls.Add(this.LblNation);
            this.GrpBoxContactPerson.Controls.Add(this.DtpDateOfBirth);
            this.GrpBoxContactPerson.Controls.Add(this.LblLastName);
            this.GrpBoxContactPerson.Controls.Add(this.LblFirstName);
            this.GrpBoxContactPerson.Controls.Add(this.LblFax);
            this.GrpBoxContactPerson.Controls.Add(this.CmbNationality);
            this.GrpBoxContactPerson.Controls.Add(this.LblGender);
            this.GrpBoxContactPerson.Controls.Add(this.LblMobilePhone);
            this.GrpBoxContactPerson.Controls.Add(this.LblTitle);
            this.GrpBoxContactPerson.Controls.Add(this.txtFax);
            this.GrpBoxContactPerson.Controls.Add(this.LblPhoneBusiness);
            this.GrpBoxContactPerson.Controls.Add(this.txtCompanyContactEmail);
            this.GrpBoxContactPerson.Controls.Add(this.LblSalutation);
            this.GrpBoxContactPerson.Controls.Add(this.txtMobile);
            this.GrpBoxContactPerson.Controls.Add(this.LblPhonePrivate);
            this.GrpBoxContactPerson.Controls.Add(this.CmbSalutation);
            this.GrpBoxContactPerson.Controls.Add(this.CmbTitle);
            this.GrpBoxContactPerson.Controls.Add(this.txtPhoneCompany);
            this.GrpBoxContactPerson.Controls.Add(this.rbMale);
            this.GrpBoxContactPerson.Controls.Add(this.rbFemale);
            this.GrpBoxContactPerson.Controls.Add(this.txtPhonePrivate);
            this.GrpBoxContactPerson.Controls.Add(this.rbOther);
            this.GrpBoxContactPerson.Controls.Add(this.txtFirstName);
            this.GrpBoxContactPerson.Controls.Add(this.txtSurName);
            this.GrpBoxContactPerson.Dock = System.Windows.Forms.DockStyle.Top;
            this.GrpBoxContactPerson.Location = new System.Drawing.Point(0, 228);
            this.GrpBoxContactPerson.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.GrpBoxContactPerson.Name = "GrpBoxContactPerson";
            this.GrpBoxContactPerson.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.GrpBoxContactPerson.Size = new System.Drawing.Size(544, 403);
            this.GrpBoxContactPerson.TabIndex = 85;
            this.GrpBoxContactPerson.TabStop = false;
            this.GrpBoxContactPerson.Text = "Kontaktperson";
            // 
            // LblDateOfBirth
            // 
            this.LblDateOfBirth.AutoSize = true;
            this.LblDateOfBirth.Location = new System.Drawing.Point(269, 329);
            this.LblDateOfBirth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblDateOfBirth.Name = "LblDateOfBirth";
            this.LblDateOfBirth.Size = new System.Drawing.Size(98, 17);
            this.LblDateOfBirth.TabIndex = 91;
            this.LblDateOfBirth.Text = "Geburtsdatum";
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Location = new System.Drawing.Point(19, 281);
            this.LblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(56, 17);
            this.LblEmail.TabIndex = 92;
            this.LblEmail.Text = "E-Mail *";
            // 
            // LblNation
            // 
            this.LblNation.AutoSize = true;
            this.LblNation.Location = new System.Drawing.Point(17, 329);
            this.LblNation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNation.Name = "LblNation";
            this.LblNation.Size = new System.Drawing.Size(79, 17);
            this.LblNation.TabIndex = 90;
            this.LblNation.Text = "Nationalität";
            // 
            // LblLastName
            // 
            this.LblLastName.AutoSize = true;
            this.LblLastName.Location = new System.Drawing.Point(269, 137);
            this.LblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblLastName.Name = "LblLastName";
            this.LblLastName.Size = new System.Drawing.Size(85, 17);
            this.LblLastName.TabIndex = 67;
            this.LblLastName.Text = "Nachname *";
            // 
            // LblFirstName
            // 
            this.LblFirstName.AutoSize = true;
            this.LblFirstName.Location = new System.Drawing.Point(17, 137);
            this.LblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblFirstName.Name = "LblFirstName";
            this.LblFirstName.Size = new System.Drawing.Size(74, 17);
            this.LblFirstName.TabIndex = 66;
            this.LblFirstName.Text = "Vorname *";
            // 
            // LblFax
            // 
            this.LblFax.AutoSize = true;
            this.LblFax.Location = new System.Drawing.Point(269, 233);
            this.LblFax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblFax.Name = "LblFax";
            this.LblFax.Size = new System.Drawing.Size(30, 17);
            this.LblFax.TabIndex = 89;
            this.LblFax.Text = "Fax";
            // 
            // LblGender
            // 
            this.LblGender.AutoSize = true;
            this.LblGender.Location = new System.Drawing.Point(23, 87);
            this.LblGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblGender.Name = "LblGender";
            this.LblGender.Size = new System.Drawing.Size(88, 17);
            this.LblGender.TabIndex = 64;
            this.LblGender.Text = "Geschlecht *";
            // 
            // LblMobilePhone
            // 
            this.LblMobilePhone.AutoSize = true;
            this.LblMobilePhone.Location = new System.Drawing.Point(17, 233);
            this.LblMobilePhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblMobilePhone.Name = "LblMobilePhone";
            this.LblMobilePhone.Size = new System.Drawing.Size(49, 17);
            this.LblMobilePhone.TabIndex = 88;
            this.LblMobilePhone.Text = "Handy";
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Location = new System.Drawing.Point(269, 32);
            this.LblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(35, 17);
            this.LblTitle.TabIndex = 63;
            this.LblTitle.Text = "Titel";
            // 
            // LblPhoneBusiness
            // 
            this.LblPhoneBusiness.AutoSize = true;
            this.LblPhoneBusiness.Location = new System.Drawing.Point(269, 185);
            this.LblPhoneBusiness.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPhoneBusiness.Name = "LblPhoneBusiness";
            this.LblPhoneBusiness.Size = new System.Drawing.Size(157, 17);
            this.LblPhoneBusiness.TabIndex = 87;
            this.LblPhoneBusiness.Text = "Telefon (Geschäftlich) *";
            // 
            // LblSalutation
            // 
            this.LblSalutation.AutoSize = true;
            this.LblSalutation.Location = new System.Drawing.Point(19, 33);
            this.LblSalutation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblSalutation.Name = "LblSalutation";
            this.LblSalutation.Size = new System.Drawing.Size(63, 17);
            this.LblSalutation.TabIndex = 0;
            this.LblSalutation.Text = "Anrede *";
            // 
            // LblPhonePrivate
            // 
            this.LblPhonePrivate.AutoSize = true;
            this.LblPhonePrivate.Location = new System.Drawing.Point(17, 185);
            this.LblPhonePrivate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPhonePrivate.Name = "LblPhonePrivate";
            this.LblPhonePrivate.Size = new System.Drawing.Size(115, 17);
            this.LblPhonePrivate.TabIndex = 86;
            this.LblPhonePrivate.Text = "Telefon (Privat) *";
            // 
            // PnlMainData
            // 
            this.PnlMainData.AutoScroll = true;
            this.PnlMainData.Controls.Add(this.tableLayoutPanel1);
            this.PnlMainData.Controls.Add(this.GrpBoxContactPerson);
            this.PnlMainData.Controls.Add(this.GrpBoxCompanyData);
            this.PnlMainData.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlMainData.Location = new System.Drawing.Point(20, 18);
            this.PnlMainData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PnlMainData.Name = "PnlMainData";
            this.PnlMainData.Size = new System.Drawing.Size(544, 691);
            this.PnlMainData.TabIndex = 86;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnCompanySave, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCompanyDelete, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 653);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(544, 38);
            this.tableLayoutPanel1.TabIndex = 86;
            // 
            // GrpBoxNotes
            // 
            this.GrpBoxNotes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GrpBoxNotes.Controls.Add(this.txtAddNote);
            this.GrpBoxNotes.Controls.Add(this.LblNote);
            this.GrpBoxNotes.Controls.Add(this.BtnAddNote);
            this.GrpBoxNotes.Controls.Add(this.dataGridNotes);
            this.GrpBoxNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrpBoxNotes.Location = new System.Drawing.Point(564, 18);
            this.GrpBoxNotes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GrpBoxNotes.Name = "GrpBoxNotes";
            this.GrpBoxNotes.Padding = new System.Windows.Forms.Padding(20, 18, 20, 18);
            this.GrpBoxNotes.Size = new System.Drawing.Size(821, 691);
            this.GrpBoxNotes.TabIndex = 87;
            this.GrpBoxNotes.TabStop = false;
            this.GrpBoxNotes.Text = "Notizen (erstellen)";
            // 
            // LblNote
            // 
            this.LblNote.AutoSize = true;
            this.LblNote.Location = new System.Drawing.Point(20, 31);
            this.LblNote.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNote.Name = "LblNote";
            this.LblNote.Size = new System.Drawing.Size(40, 17);
            this.LblNote.TabIndex = 84;
            this.LblNote.Text = "Notiz";
            // 
            // CustomerDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1405, 727);
            this.Controls.Add(this.GrpBoxNotes);
            this.Controls.Add(this.PnlMainData);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CustomerDialog";
            this.Padding = new System.Windows.Forms.Padding(20, 18, 20, 18);
            this.Text = "Kunden";
            this.Load += new System.EventHandler(this.CustomerDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNotes)).EndInit();
            this.GrpBoxCompanyData.ResumeLayout(false);
            this.GrpBoxCompanyData.PerformLayout();
            this.GrpBoxContactPerson.ResumeLayout(false);
            this.GrpBoxContactPerson.PerformLayout();
            this.PnlMainData.ResumeLayout(false);
            this.PnlMainData.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.GrpBoxNotes.ResumeLayout(false);
            this.GrpBoxNotes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker DtpDateOfBirth;
        private System.Windows.Forms.ComboBox CmbCustomerType;
        private System.Windows.Forms.TextBox txtFax;
        private System.Windows.Forms.TextBox txtPhoneCompany;
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
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.CheckBox ChkStatus;
        private System.Windows.Forms.Button BtnAddNote;
        private System.Windows.Forms.TextBox txtAddNote;
        private System.Windows.Forms.DataGridView dataGridNotes;
        private System.Windows.Forms.GroupBox GrpBoxCompanyData;
        private System.Windows.Forms.GroupBox GrpBoxContactPerson;
        private System.Windows.Forms.Label LblCompany;
        private System.Windows.Forms.Label LblCustomerType;
        private System.Windows.Forms.Label LblLastName;
        private System.Windows.Forms.Label LblFirstName;
        private System.Windows.Forms.Label LblGender;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Label LblSalutation;
        private System.Windows.Forms.Label LblZip;
        private System.Windows.Forms.Label LblCity;
        private System.Windows.Forms.Label LblAddress;
        private System.Windows.Forms.Label LblDateOfBirth;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.Label LblNation;
        private System.Windows.Forms.Label LblFax;
        private System.Windows.Forms.Label LblMobilePhone;
        private System.Windows.Forms.Label LblPhoneBusiness;
        private System.Windows.Forms.Label LblPhonePrivate;
        private System.Windows.Forms.Panel PnlMainData;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox GrpBoxNotes;
        private System.Windows.Forms.Label LblNote;
        private System.Windows.Forms.Label LblInfo;
    }
}