
namespace Contact_Manager.Views
{
    partial class Customers
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
            this.PnlHeader = new System.Windows.Forms.TableLayoutPanel();
            this.PnlSearch = new System.Windows.Forms.Panel();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.LblSearch = new System.Windows.Forms.Label();
            this.PnlActions = new System.Windows.Forms.Panel();
            this.cmdVcardImport = new System.Windows.Forms.Button();
            this.cmdImportCsv = new System.Windows.Forms.Button();
            this.CmdCreate = new System.Windows.Forms.Button();
            this.GridViewCustomers = new System.Windows.Forms.DataGridView();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.navigation1 = new Contact_Manager.Components.Navigation();
            this.PnlHeader.SuspendLayout();
            this.PnlSearch.SuspendLayout();
            this.PnlActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlHeader
            // 
            this.PnlHeader.ColumnCount = 2;
            this.PnlHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PnlHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PnlHeader.Controls.Add(this.PnlSearch, 0, 0);
            this.PnlHeader.Controls.Add(this.PnlActions, 1, 0);
            this.PnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlHeader.Location = new System.Drawing.Point(0, 50);
            this.PnlHeader.Name = "PnlHeader";
            this.PnlHeader.RowCount = 1;
            this.PnlHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PnlHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PnlHeader.Size = new System.Drawing.Size(800, 56);
            this.PnlHeader.TabIndex = 2;
            // 
            // PnlSearch
            // 
            this.PnlSearch.Controls.Add(this.TxtSearch);
            this.PnlSearch.Controls.Add(this.LblSearch);
            this.PnlSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlSearch.Location = new System.Drawing.Point(7, 7);
            this.PnlSearch.Margin = new System.Windows.Forms.Padding(7);
            this.PnlSearch.Name = "PnlSearch";
            this.PnlSearch.Size = new System.Drawing.Size(386, 42);
            this.PnlSearch.TabIndex = 0;
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(7, 21);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(284, 20);
            this.TxtSearch.TabIndex = 1;
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // LblSearch
            // 
            this.LblSearch.AutoSize = true;
            this.LblSearch.Location = new System.Drawing.Point(4, 4);
            this.LblSearch.Name = "LblSearch";
            this.LblSearch.Size = new System.Drawing.Size(65, 13);
            this.LblSearch.TabIndex = 0;
            this.LblSearch.Text = "Suche nach";
            // 
            // PnlActions
            // 
            this.PnlActions.Controls.Add(this.cmdVcardImport);
            this.PnlActions.Controls.Add(this.cmdImportCsv);
            this.PnlActions.Controls.Add(this.CmdCreate);
            this.PnlActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlActions.Location = new System.Drawing.Point(407, 7);
            this.PnlActions.Margin = new System.Windows.Forms.Padding(7);
            this.PnlActions.Name = "PnlActions";
            this.PnlActions.Size = new System.Drawing.Size(386, 42);
            this.PnlActions.TabIndex = 1;
            // 
            // cmdVcardImport
            // 
            this.cmdVcardImport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdVcardImport.Dock = System.Windows.Forms.DockStyle.Right;
            this.cmdVcardImport.Location = new System.Drawing.Point(-1, 0);
            this.cmdVcardImport.Name = "cmdVcardImport";
            this.cmdVcardImport.Size = new System.Drawing.Size(129, 42);
            this.cmdVcardImport.TabIndex = 2;
            this.cmdVcardImport.Text = "vCard Import";
            this.cmdVcardImport.UseVisualStyleBackColor = true;
            // 
            // cmdImportCsv
            // 
            this.cmdImportCsv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdImportCsv.Dock = System.Windows.Forms.DockStyle.Right;
            this.cmdImportCsv.Location = new System.Drawing.Point(128, 0);
            this.cmdImportCsv.Name = "cmdImportCsv";
            this.cmdImportCsv.Size = new System.Drawing.Size(129, 42);
            this.cmdImportCsv.TabIndex = 1;
            this.cmdImportCsv.Text = "CSV Import";
            this.cmdImportCsv.UseVisualStyleBackColor = true;
            this.cmdImportCsv.Click += new System.EventHandler(this.cmdImportCsv_Click);
            // 
            // CmdCreate
            // 
            this.CmdCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CmdCreate.Dock = System.Windows.Forms.DockStyle.Right;
            this.CmdCreate.Location = new System.Drawing.Point(257, 0);
            this.CmdCreate.Name = "CmdCreate";
            this.CmdCreate.Size = new System.Drawing.Size(129, 42);
            this.CmdCreate.TabIndex = 0;
            this.CmdCreate.Text = "Kunde erstellen";
            this.CmdCreate.UseVisualStyleBackColor = true;
            this.CmdCreate.Click += new System.EventHandler(this.CmdCreate_Click);
            // 
            // GridViewCustomers
            // 
            this.GridViewCustomers.AllowUserToAddRows = false;
            this.GridViewCustomers.AllowUserToDeleteRows = false;
            this.GridViewCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewCustomers.Location = new System.Drawing.Point(0, 106);
            this.GridViewCustomers.Name = "GridViewCustomers";
            this.GridViewCustomers.ReadOnly = true;
            this.GridViewCustomers.Size = new System.Drawing.Size(800, 344);
            this.GridViewCustomers.TabIndex = 3;
            this.GridViewCustomers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewCustomers_CellDoubleClick);
            this.GridViewCustomers.Paint += new System.Windows.Forms.PaintEventHandler(this.GridViewCustomers_Paint);
            this.GridViewCustomers.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GridViewCustomers_KeyDown);
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(0, 430);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(100, 20);
            this.txtFile.TabIndex = 7;
            // 
            // navigation1
            // 
            this.navigation1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(119)))), ((int)(((byte)(241)))));
            this.navigation1.Dock = System.Windows.Forms.DockStyle.Top;
            this.navigation1.Location = new System.Drawing.Point(0, 0);
            this.navigation1.Name = "navigation1";
            this.navigation1.Size = new System.Drawing.Size(800, 50);
            this.navigation1.TabIndex = 0;
            // 
            // Customers
            // 
            this.AccessibleDescription = "mainWindow";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GridViewCustomers);
            this.Controls.Add(this.PnlHeader);
            this.Controls.Add(this.navigation1);
            this.Controls.Add(this.txtFile);
            this.Name = "Customers";
            this.Text = "Kundenstamm";
            this.Load += new System.EventHandler(this.Customers_Load);
            this.PnlHeader.ResumeLayout(false);
            this.PnlSearch.ResumeLayout(false);
            this.PnlSearch.PerformLayout();
            this.PnlActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Components.Navigation navigation1;
        private System.Windows.Forms.TableLayoutPanel PnlHeader;
        private System.Windows.Forms.Panel PnlSearch;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Label LblSearch;
        private System.Windows.Forms.Panel PnlActions;
        private System.Windows.Forms.Button CmdCreate;
        private System.Windows.Forms.DataGridView GridViewCustomers;
        private System.Windows.Forms.Button cmdVcardImport;
        private System.Windows.Forms.Button cmdImportCsv;
        private System.Windows.Forms.TextBox txtFile;
    }
}