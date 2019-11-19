namespace DedSecDns_Client.Pages
{
    partial class ManageDomainsPage
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
            this.xuiBanner1 = new XanderUI.XUIBanner();
            this.xuiCard1 = new XanderUI.XUICard();
            this.SuspendLayout();
            // 
            // xuiBanner1
            // 
            this.xuiBanner1.BackColor = System.Drawing.Color.Transparent;
            this.xuiBanner1.BannerColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(71)))), ((int)(((byte)(89)))));
            this.xuiBanner1.BorderColor = System.Drawing.Color.White;
            this.xuiBanner1.ForeColor = System.Drawing.Color.White;
            this.xuiBanner1.Location = new System.Drawing.Point(531, 104);
            this.xuiBanner1.Name = "xuiBanner1";
            this.xuiBanner1.Size = new System.Drawing.Size(100, 20);
            this.xuiBanner1.TabIndex = 0;
            this.xuiBanner1.Text = "xuiBanner1";
            // 
            // xuiCard1
            // 
            this.xuiCard1.BackColor = System.Drawing.Color.Transparent;
            this.xuiCard1.Color1 = System.Drawing.Color.DodgerBlue;
            this.xuiCard1.Color2 = System.Drawing.Color.LimeGreen;
            this.xuiCard1.ForeColor = System.Drawing.Color.White;
            this.xuiCard1.Location = new System.Drawing.Point(95, 90);
            this.xuiCard1.Name = "xuiCard1";
            this.xuiCard1.Size = new System.Drawing.Size(320, 170);
            this.xuiCard1.TabIndex = 1;
            this.xuiCard1.Text = "xuiCard1";
            this.xuiCard1.Text1 = "Savings Card";
            this.xuiCard1.Text2 = "1234 5678 9101 1121";
            this.xuiCard1.Text3 = "Exp: 01/02 - 03/04";
            // 
            // ManageDomainsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.xuiCard1);
            this.Controls.Add(this.xuiBanner1);
            this.Name = "ManageDomainsPage";
            this.Size = new System.Drawing.Size(908, 499);
            this.ResumeLayout(false);

        }

        #endregion

        private XanderUI.XUIBanner xuiBanner1;
        private XanderUI.XUICard xuiCard1;
    }
}
