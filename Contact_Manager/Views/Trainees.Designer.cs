﻿
namespace Contact_Manager.Views
{
    partial class Trainees
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
            this.navigation1 = new Contact_Manager.Components.Navigation();
            this.GridViewTrainees = new System.Windows.Forms.DataGridView();
            this.PnlHeader = new System.Windows.Forms.TableLayoutPanel();
            this.PnlSearch = new System.Windows.Forms.Panel();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.LblSearch = new System.Windows.Forms.Label();
            this.PnlActions = new System.Windows.Forms.Panel();
            this.cmdVcardImport = new System.Windows.Forms.Button();
            this.cmdImportCsv = new System.Windows.Forms.Button();
            this.CmdCreate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewTrainees)).BeginInit();
            this.PnlHeader.SuspendLayout();
            this.PnlSearch.SuspendLayout();
            this.PnlActions.SuspendLayout();
            this.SuspendLayout();
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
            // GridViewTrainees
            // 
            this.GridViewTrainees.AllowUserToAddRows = false;
            this.GridViewTrainees.AllowUserToDeleteRows = false;
            this.GridViewTrainees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewTrainees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewTrainees.Location = new System.Drawing.Point(0, 50);
            this.GridViewTrainees.Name = "GridViewTrainees";
            this.GridViewTrainees.ReadOnly = true;
            this.GridViewTrainees.Size = new System.Drawing.Size(800, 400);
            this.GridViewTrainees.TabIndex = 3;
            this.GridViewTrainees.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewTrainees_CellDoubleClick);
            this.GridViewTrainees.Paint += new System.Windows.Forms.PaintEventHandler(this.GridViewTrainees_Paint);
            this.GridViewTrainees.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GridViewTrainees_KeyDown);
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
            this.PnlHeader.TabIndex = 5;
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
            // 
            // CmdCreate
            // 
            this.CmdCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CmdCreate.Dock = System.Windows.Forms.DockStyle.Right;
            this.CmdCreate.Location = new System.Drawing.Point(257, 0);
            this.CmdCreate.Name = "CmdCreate";
            this.CmdCreate.Size = new System.Drawing.Size(129, 42);
            this.CmdCreate.TabIndex = 0;
            this.CmdCreate.Text = "Lehrling erstellen";
            this.CmdCreate.UseVisualStyleBackColor = true;
            this.CmdCreate.Click += new System.EventHandler(this.CmdCreate_Click);
            // 
            // Trainees
            // 
            this.AccessibleDescription = "mainWindow";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PnlHeader);
            this.Controls.Add(this.GridViewTrainees);
            this.Controls.Add(this.navigation1);
            this.Name = "Trainees";
            this.Text = "Lehrlinge";
            this.Load += new System.EventHandler(this.Trainees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewTrainees)).EndInit();
            this.PnlHeader.ResumeLayout(false);
            this.PnlSearch.ResumeLayout(false);
            this.PnlSearch.PerformLayout();
            this.PnlActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Components.Navigation navigation1;
        private System.Windows.Forms.DataGridView GridViewTrainees;
        private System.Windows.Forms.TableLayoutPanel PnlHeader;
        private System.Windows.Forms.Panel PnlSearch;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Label LblSearch;
        private System.Windows.Forms.Panel PnlActions;
        private System.Windows.Forms.Button cmdVcardImport;
        private System.Windows.Forms.Button cmdImportCsv;
        private System.Windows.Forms.Button CmdCreate;
    }
}