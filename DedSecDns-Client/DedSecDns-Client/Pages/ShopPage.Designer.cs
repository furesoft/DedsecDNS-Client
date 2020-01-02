namespace DedSecDns_Client.Pages
{
    partial class ShopPage
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
            this.htmlLabel1 = new TheArtOfDev.HtmlRenderer.WinForms.HtmlLabel();
            this.SuspendLayout();
            // 
            // htmlLabel1
            // 
            this.htmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.htmlLabel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.htmlLabel1.BaseStylesheet = null;
            this.htmlLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.htmlLabel1.Location = new System.Drawing.Point(0, 0);
            this.htmlLabel1.Name = "htmlLabel1";
            this.htmlLabel1.Size = new System.Drawing.Size(863, 65);
            this.htmlLabel1.TabIndex = 0;
            this.htmlLabel1.Text = "<h2>Shop</h2>";
            // 
            // ShopPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.htmlLabel1);
            this.Name = "ShopPage";
            this.Size = new System.Drawing.Size(863, 510);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TheArtOfDev.HtmlRenderer.WinForms.HtmlLabel htmlLabel1;
    }
}
