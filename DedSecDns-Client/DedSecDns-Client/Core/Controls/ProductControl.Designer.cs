namespace DedSecDns_Client.Core.Controls
{
    partial class ProductControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductControl));
            this.imagePb = new System.Windows.Forms.PictureBox();
            this.productNameLbl = new TheArtOfDev.HtmlRenderer.WinForms.HtmlLabel();
            this.priceLbl = new TheArtOfDev.HtmlRenderer.WinForms.HtmlLabel();
            this.addToCartButton1 = new DedSecDns_Client.Core.Controls.AddToCartButton();
            ((System.ComponentModel.ISupportInitialize)(this.imagePb)).BeginInit();
            this.SuspendLayout();
            // 
            // imagePb
            // 
            this.imagePb.Location = new System.Drawing.Point(19, 48);
            this.imagePb.Name = "imagePb";
            this.imagePb.Size = new System.Drawing.Size(153, 65);
            this.imagePb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagePb.TabIndex = 0;
            this.imagePb.TabStop = false;
            // 
            // productNameLbl
            // 
            this.productNameLbl.BackColor = System.Drawing.Color.Transparent;
            this.productNameLbl.BaseStylesheet = null;
            this.productNameLbl.Location = new System.Drawing.Point(38, 3);
            this.productNameLbl.Name = "productNameLbl";
            this.productNameLbl.Size = new System.Drawing.Size(117, 25);
            this.productNameLbl.TabIndex = 1;
            this.productNameLbl.Text = "{productname}";
            // 
            // priceLbl
            // 
            this.priceLbl.BackColor = System.Drawing.Color.Transparent;
            this.priceLbl.BaseStylesheet = null;
            this.priceLbl.Location = new System.Drawing.Point(19, 128);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Size = new System.Drawing.Size(94, 25);
            this.priceLbl.TabIndex = 2;
            this.priceLbl.Text = "Preis: {price}";
            // 
            // addToCartButton1
            // 
            this.addToCartButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.addToCartButton1.ButtonImage = ((System.Drawing.Image)(resources.GetObject("addToCartButton1.ButtonImage")));
            this.addToCartButton1.ButtonStyle = XanderUI.XUIButton.Style.Material;
            this.addToCartButton1.ButtonText = "Zum Warenkorb hinzufügen";
            this.addToCartButton1.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.addToCartButton1.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.addToCartButton1.CornerRadius = 5;
            this.addToCartButton1.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.addToCartButton1.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.addToCartButton1.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.addToCartButton1.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.addToCartButton1.Location = new System.Drawing.Point(1, 198);
            this.addToCartButton1.Name = "addToCartButton1";
            this.addToCartButton1.Size = new System.Drawing.Size(200, 50);
            this.addToCartButton1.TabIndex = 3;
            this.addToCartButton1.TextColor = System.Drawing.Color.DodgerBlue;
            this.addToCartButton1.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // ProductControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.addToCartButton1);
            this.Controls.Add(this.priceLbl);
            this.Controls.Add(this.productNameLbl);
            this.Controls.Add(this.imagePb);
            this.Name = "ProductControl";
            this.Size = new System.Drawing.Size(194, 249);
            ((System.ComponentModel.ISupportInitialize)(this.imagePb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imagePb;
        private TheArtOfDev.HtmlRenderer.WinForms.HtmlLabel productNameLbl;
        private TheArtOfDev.HtmlRenderer.WinForms.HtmlLabel priceLbl;
        private AddToCartButton addToCartButton1;
    }
}
