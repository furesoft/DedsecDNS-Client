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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageDomainsPage));
            this.label1 = new System.Windows.Forms.Label();
            this.addDomainBtn = new XanderUI.XUIButton();
            this.removeDomainBtn = new XanderUI.XUIButton();
            this.domainNamesCb = new DedSecDns_Client.Core.Popup.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Domains";
            // 
            // addDomainBtn
            // 
            this.addDomainBtn.BackgroundColor = System.Drawing.Color.Transparent;
            this.addDomainBtn.ButtonImage = ((System.Drawing.Image)(resources.GetObject("addDomainBtn.ButtonImage")));
            this.addDomainBtn.ButtonStyle = XanderUI.XUIButton.Style.Material;
            this.addDomainBtn.ButtonText = "";
            this.addDomainBtn.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.addDomainBtn.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.addDomainBtn.CornerRadius = 5;
            this.addDomainBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.addDomainBtn.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.addDomainBtn.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.addDomainBtn.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.addDomainBtn.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.addDomainBtn.Location = new System.Drawing.Point(322, 3);
            this.addDomainBtn.Name = "addDomainBtn";
            this.addDomainBtn.Size = new System.Drawing.Size(54, 50);
            this.addDomainBtn.TabIndex = 2;
            this.addDomainBtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.addDomainBtn.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // removeDomainBtn
            // 
            this.removeDomainBtn.BackgroundColor = System.Drawing.Color.Transparent;
            this.removeDomainBtn.ButtonImage = ((System.Drawing.Image)(resources.GetObject("removeDomainBtn.ButtonImage")));
            this.removeDomainBtn.ButtonStyle = XanderUI.XUIButton.Style.Material;
            this.removeDomainBtn.ButtonText = "";
            this.removeDomainBtn.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.removeDomainBtn.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.removeDomainBtn.CornerRadius = 5;
            this.removeDomainBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.removeDomainBtn.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.removeDomainBtn.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.removeDomainBtn.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.removeDomainBtn.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.removeDomainBtn.Location = new System.Drawing.Point(392, 3);
            this.removeDomainBtn.Name = "removeDomainBtn";
            this.removeDomainBtn.Size = new System.Drawing.Size(54, 50);
            this.removeDomainBtn.TabIndex = 3;
            this.removeDomainBtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.removeDomainBtn.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // domainNamesCb
            // 
            this.domainNamesCb.FormattingEnabled = true;
            this.domainNamesCb.Location = new System.Drawing.Point(73, 12);
            this.domainNamesCb.Name = "domainNamesCb";
            this.domainNamesCb.Size = new System.Drawing.Size(243, 24);
            this.domainNamesCb.TabIndex = 0;
            // 
            // ManageDomainsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.removeDomainBtn);
            this.Controls.Add(this.addDomainBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.domainNamesCb);
            this.Name = "ManageDomainsPage";
            this.Size = new System.Drawing.Size(908, 499);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Core.Popup.ComboBox domainNamesCb;
        private System.Windows.Forms.Label label1;
        private XanderUI.XUIButton addDomainBtn;
        private XanderUI.XUIButton removeDomainBtn;
    }
}
