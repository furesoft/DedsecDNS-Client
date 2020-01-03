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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShopPage));
            this.htmlLabel1 = new TheArtOfDev.HtmlRenderer.WinForms.HtmlLabel();
            this.cartBtn = new XanderUI.XUIButton();
            this.addToCartButton1 = new DedSecDns_Client.Core.Controls.AddToCartButton();
            this.SuspendLayout();
            // 
            // htmlLabel1
            // 
            this.htmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.htmlLabel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.htmlLabel1.BaseStylesheet = null;
            this.htmlLabel1.Location = new System.Drawing.Point(0, 0);
            this.htmlLabel1.Name = "htmlLabel1";
            this.htmlLabel1.Size = new System.Drawing.Size(65, 65);
            this.htmlLabel1.TabIndex = 0;
            this.htmlLabel1.Text = "<h2>Shop</h2>";
            // 
            // cartBtn
            // 
            this.cartBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cartBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cartBtn.ButtonImage = ((System.Drawing.Image)(resources.GetObject("cartBtn.ButtonImage")));
            this.cartBtn.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.cartBtn.ButtonText = "Warenkorb";
            this.cartBtn.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.cartBtn.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.cartBtn.CornerRadius = 5;
            this.cartBtn.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.cartBtn.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.cartBtn.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.cartBtn.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.cartBtn.Location = new System.Drawing.Point(663, 3);
            this.cartBtn.Name = "cartBtn";
            this.cartBtn.Size = new System.Drawing.Size(200, 62);
            this.cartBtn.TabIndex = 1;
            this.cartBtn.TextColor = System.Drawing.Color.DodgerBlue;
            this.cartBtn.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.cartBtn.Click += new System.EventHandler(this.cartBtn_Click);
            // 
            // addToCartButton1
            // 
            this.addToCartButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(75)))));
            this.addToCartButton1.ButtonImage = ((System.Drawing.Image)(resources.GetObject("addToCartButton1.ButtonImage")));
            this.addToCartButton1.ButtonStyle = XanderUI.XUIButton.Style.Material;
            this.addToCartButton1.ButtonText = "Zum Warenkorb hinzufügen";
            this.addToCartButton1.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.addToCartButton1.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.addToCartButton1.CornerRadius = 5;
            this.addToCartButton1.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.addToCartButton1.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.addToCartButton1.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.addToCartButton1.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.addToCartButton1.Location = new System.Drawing.Point(510, 234);
            this.addToCartButton1.Name = "addToCartButton1";
            this.addToCartButton1.Size = new System.Drawing.Size(167, 50);
            this.addToCartButton1.TabIndex = 3;
            this.addToCartButton1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.addToCartButton1.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // ShopPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.addToCartButton1);
            this.Controls.Add(this.cartBtn);
            this.Controls.Add(this.htmlLabel1);
            this.Name = "ShopPage";
            this.Size = new System.Drawing.Size(863, 510);
            this.Load += new System.EventHandler(this.ShopPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TheArtOfDev.HtmlRenderer.WinForms.HtmlLabel htmlLabel1;
        private XanderUI.XUIButton cartBtn;
        private Core.Controls.AddToCartButton addToCartButton1;
    }
}
