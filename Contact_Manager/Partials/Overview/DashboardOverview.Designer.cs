
namespace Contact_Manager.Partials.Overview
{
    partial class DashboardOverview
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
            this.PnlCustomers = new System.Windows.Forms.Panel();
            this.LblNumCustomers = new System.Windows.Forms.Label();
            this.PnlEmployees = new System.Windows.Forms.Panel();
            this.LblNumEmployees = new System.Windows.Forms.Label();
            this.PnlTrainees = new System.Windows.Forms.Panel();
            this.LblNumTrainees = new System.Windows.Forms.Label();
            this.PnlCustomers.SuspendLayout();
            this.PnlEmployees.SuspendLayout();
            this.PnlTrainees.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlCustomers
            // 
            this.PnlCustomers.Controls.Add(this.LblNumCustomers);
            this.PnlCustomers.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlCustomers.Location = new System.Drawing.Point(0, 0);
            this.PnlCustomers.Name = "PnlCustomers";
            this.PnlCustomers.Size = new System.Drawing.Size(267, 450);
            this.PnlCustomers.TabIndex = 0;
            // 
            // LblNumCustomers
            // 
            this.LblNumCustomers.AutoSize = true;
            this.LblNumCustomers.Location = new System.Drawing.Point(129, 125);
            this.LblNumCustomers.Name = "LblNumCustomers";
            this.LblNumCustomers.Size = new System.Drawing.Size(16, 17);
            this.LblNumCustomers.TabIndex = 0;
            this.LblNumCustomers.Text = "0";
            // 
            // PnlEmployees
            // 
            this.PnlEmployees.Controls.Add(this.LblNumEmployees);
            this.PnlEmployees.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlEmployees.Location = new System.Drawing.Point(267, 0);
            this.PnlEmployees.Name = "PnlEmployees";
            this.PnlEmployees.Size = new System.Drawing.Size(267, 450);
            this.PnlEmployees.TabIndex = 1;
            // 
            // LblNumEmployees
            // 
            this.LblNumEmployees.AutoSize = true;
            this.LblNumEmployees.Location = new System.Drawing.Point(120, 125);
            this.LblNumEmployees.Name = "LblNumEmployees";
            this.LblNumEmployees.Size = new System.Drawing.Size(16, 17);
            this.LblNumEmployees.TabIndex = 0;
            this.LblNumEmployees.Text = "0";
            // 
            // PnlTrainees
            // 
            this.PnlTrainees.Controls.Add(this.LblNumTrainees);
            this.PnlTrainees.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlTrainees.Location = new System.Drawing.Point(534, 0);
            this.PnlTrainees.Name = "PnlTrainees";
            this.PnlTrainees.Size = new System.Drawing.Size(267, 450);
            this.PnlTrainees.TabIndex = 2;
            // 
            // LblNumTrainees
            // 
            this.LblNumTrainees.AutoSize = true;
            this.LblNumTrainees.Location = new System.Drawing.Point(123, 125);
            this.LblNumTrainees.Name = "LblNumTrainees";
            this.LblNumTrainees.Size = new System.Drawing.Size(16, 17);
            this.LblNumTrainees.TabIndex = 0;
            this.LblNumTrainees.Text = "0";
            // 
            // DashboardOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PnlTrainees);
            this.Controls.Add(this.PnlEmployees);
            this.Controls.Add(this.PnlCustomers);
            this.Name = "DashboardOverview";
            this.Text = "DashboardOverview";
            this.PnlCustomers.ResumeLayout(false);
            this.PnlCustomers.PerformLayout();
            this.PnlEmployees.ResumeLayout(false);
            this.PnlEmployees.PerformLayout();
            this.PnlTrainees.ResumeLayout(false);
            this.PnlTrainees.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlCustomers;
        private System.Windows.Forms.Label LblNumCustomers;
        private System.Windows.Forms.Panel PnlEmployees;
        private System.Windows.Forms.Label LblNumEmployees;
        private System.Windows.Forms.Panel PnlTrainees;
        private System.Windows.Forms.Label LblNumTrainees;
    }
}