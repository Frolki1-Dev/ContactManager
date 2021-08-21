
namespace Contact_Manager.Views
{
    partial class Dashboard
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
            this.PnlHeader = new System.Windows.Forms.Panel();
            this.LblGreeting = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.DashboardItemEmployee = new Contact_Manager.Components.DashboardItem();
            this.navigation1 = new Contact_Manager.Components.Navigation();
            this.DashboardItemCustomers = new Contact_Manager.Components.DashboardItem();
            this.DashboardItemTrainees = new Contact_Manager.Components.DashboardItem();
            this.DashboardItemUsers = new Contact_Manager.Components.DashboardItem();
            this.PnlHeader.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlHeader
            // 
            this.PnlHeader.Controls.Add(this.LblGreeting);
            this.PnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlHeader.Location = new System.Drawing.Point(0, 50);
            this.PnlHeader.Name = "PnlHeader";
            this.PnlHeader.Size = new System.Drawing.Size(800, 46);
            this.PnlHeader.TabIndex = 1;
            // 
            // LblGreeting
            // 
            this.LblGreeting.AccessibleDescription = "custom";
            this.LblGreeting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblGreeting.Location = new System.Drawing.Point(0, 0);
            this.LblGreeting.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.LblGreeting.Name = "LblGreeting";
            this.LblGreeting.Padding = new System.Windows.Forms.Padding(10);
            this.LblGreeting.Size = new System.Drawing.Size(800, 46);
            this.LblGreeting.TabIndex = 0;
            this.LblGreeting.Text = "Grüezi USERNAME";
            this.LblGreeting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.DashboardItemEmployee, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.DashboardItemCustomers, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.DashboardItemTrainees, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.DashboardItemUsers, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 96);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 354);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // DashboardItemEmployee
            // 
            this.DashboardItemEmployee.AutoSize = true;
            this.DashboardItemEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(119)))), ((int)(((byte)(241)))));
            this.DashboardItemEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DashboardItemEmployee.Location = new System.Drawing.Point(410, 10);
            this.DashboardItemEmployee.Margin = new System.Windows.Forms.Padding(10);
            this.DashboardItemEmployee.Name = "DashboardItemEmployee";
            this.DashboardItemEmployee.Padding = new System.Windows.Forms.Padding(10);
            this.DashboardItemEmployee.Size = new System.Drawing.Size(380, 100);
            this.DashboardItemEmployee.TabIndex = 1;
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
            // DashboardItemCustomers
            // 
            this.DashboardItemCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(119)))), ((int)(((byte)(241)))));
            this.DashboardItemCustomers.Location = new System.Drawing.Point(10, 10);
            this.DashboardItemCustomers.Margin = new System.Windows.Forms.Padding(10);
            this.DashboardItemCustomers.Name = "DashboardItemCustomers";
            this.DashboardItemCustomers.Size = new System.Drawing.Size(380, 100);
            this.DashboardItemCustomers.TabIndex = 2;
            // 
            // DashboardItemTrainees
            // 
            this.DashboardItemTrainees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(119)))), ((int)(((byte)(241)))));
            this.DashboardItemTrainees.Location = new System.Drawing.Point(10, 130);
            this.DashboardItemTrainees.Margin = new System.Windows.Forms.Padding(10);
            this.DashboardItemTrainees.Name = "DashboardItemTrainees";
            this.DashboardItemTrainees.Size = new System.Drawing.Size(380, 100);
            this.DashboardItemTrainees.TabIndex = 3;
            // 
            // DashboardItemUsers
            // 
            this.DashboardItemUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(119)))), ((int)(((byte)(241)))));
            this.DashboardItemUsers.Location = new System.Drawing.Point(410, 130);
            this.DashboardItemUsers.Margin = new System.Windows.Forms.Padding(10);
            this.DashboardItemUsers.Name = "DashboardItemUsers";
            this.DashboardItemUsers.Size = new System.Drawing.Size(380, 100);
            this.DashboardItemUsers.TabIndex = 4;
            // 
            // Dashboard
            // 
            this.AccessibleDescription = "mainWindow";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.PnlHeader);
            this.Controls.Add(this.navigation1);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.PnlHeader.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Components.Navigation navigation1;
        private System.Windows.Forms.Panel PnlHeader;
        private System.Windows.Forms.Label LblGreeting;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Components.DashboardItem DashboardItemEmployee;
        private Components.DashboardItem DashboardItemCustomers;
        private Components.DashboardItem DashboardItemTrainees;
        private Components.DashboardItem DashboardItemUsers;
    }
}