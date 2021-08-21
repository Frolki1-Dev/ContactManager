
namespace Contact_Manager.Components
{
    partial class DashboardItem
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblTitleNumItems = new System.Windows.Forms.Label();
            this.LblNumItems = new System.Windows.Forms.Label();
            this.ImgIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImgIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTitleNumItems
            // 
            this.LblTitleNumItems.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LblTitleNumItems.Location = new System.Drawing.Point(111, 75);
            this.LblTitleNumItems.Name = "LblTitleNumItems";
            this.LblTitleNumItems.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.LblTitleNumItems.Size = new System.Drawing.Size(289, 25);
            this.LblTitleNumItems.TabIndex = 2;
            this.LblTitleNumItems.Text = "Anzahl Mitarbeiter";
            this.LblTitleNumItems.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblNumItems
            // 
            this.LblNumItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblNumItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumItems.Location = new System.Drawing.Point(111, 0);
            this.LblNumItems.Name = "LblNumItems";
            this.LblNumItems.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.LblNumItems.Size = new System.Drawing.Size(289, 75);
            this.LblNumItems.TabIndex = 3;
            this.LblNumItems.Text = "0";
            this.LblNumItems.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ImgIcon
            // 
            this.ImgIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.ImgIcon.Location = new System.Drawing.Point(0, 0);
            this.ImgIcon.Name = "ImgIcon";
            this.ImgIcon.Size = new System.Drawing.Size(111, 100);
            this.ImgIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ImgIcon.TabIndex = 0;
            this.ImgIcon.TabStop = false;
            // 
            // DashboardItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LblNumItems);
            this.Controls.Add(this.LblTitleNumItems);
            this.Controls.Add(this.ImgIcon);
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "DashboardItem";
            this.Size = new System.Drawing.Size(400, 100);
            ((System.ComponentModel.ISupportInitialize)(this.ImgIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ImgIcon;
        private System.Windows.Forms.Label LblTitleNumItems;
        private System.Windows.Forms.Label LblNumItems;
    }
}
