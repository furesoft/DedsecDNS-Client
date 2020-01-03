namespace DedSecDns_Client.Core.Controls
{
    partial class CartLineControl
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
            this.nameLbl = new System.Windows.Forms.Label();
            this.priceLbl = new System.Windows.Forms.Label();
            this.removeLink = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Dock = System.Windows.Forms.DockStyle.Left;
            this.nameLbl.Location = new System.Drawing.Point(0, 0);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(46, 17);
            this.nameLbl.TabIndex = 0;
            this.nameLbl.Text = "label1";
            // 
            // priceLbl
            // 
            this.priceLbl.AutoSize = true;
            this.priceLbl.Dock = System.Windows.Forms.DockStyle.Right;
            this.priceLbl.Location = new System.Drawing.Point(336, 0);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Size = new System.Drawing.Size(46, 17);
            this.priceLbl.TabIndex = 1;
            this.priceLbl.Text = "label1";
            // 
            // removeLink
            // 
            this.removeLink.AutoSize = true;
            this.removeLink.Location = new System.Drawing.Point(55, 27);
            this.removeLink.Name = "removeLink";
            this.removeLink.Size = new System.Drawing.Size(70, 17);
            this.removeLink.TabIndex = 2;
            this.removeLink.TabStop = true;
            this.removeLink.Text = "Entfernen";
            this.removeLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.removeLink_LinkClicked);
            // 
            // CartLineControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.removeLink);
            this.Controls.Add(this.priceLbl);
            this.Controls.Add(this.nameLbl);
            this.Name = "CartLineControl";
            this.Size = new System.Drawing.Size(382, 44);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label priceLbl;
        private System.Windows.Forms.LinkLabel removeLink;
    }
}
