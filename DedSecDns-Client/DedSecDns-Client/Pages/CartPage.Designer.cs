namespace DedSecDns_Client.Pages
{
    partial class CartPage
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
            this.xuiButton1 = new XanderUI.XUIButton();
            this.productlList = new System.Windows.Forms.FlowLayoutPanel();
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
            this.htmlLabel1.Size = new System.Drawing.Size(876, 65);
            this.htmlLabel1.TabIndex = 1;
            this.htmlLabel1.Text = "<h2>Warenkorb</h2>";
            // 
            // xuiButton1
            // 
            this.xuiButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xuiButton1.ButtonImage = global::DedSecDns_Client.Properties.Resources.shopping_cart;
            this.xuiButton1.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuiButton1.ButtonText = "Bezahlen";
            this.xuiButton1.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.xuiButton1.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton1.CornerRadius = 5;
            this.xuiButton1.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton1.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.xuiButton1.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton1.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton1.Location = new System.Drawing.Point(660, 436);
            this.xuiButton1.Name = "xuiButton1";
            this.xuiButton1.Size = new System.Drawing.Size(200, 50);
            this.xuiButton1.TabIndex = 3;
            this.xuiButton1.TextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton1.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // productlList
            // 
            this.productlList.AutoScroll = true;
            this.productlList.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.productlList.Location = new System.Drawing.Point(32, 101);
            this.productlList.Name = "productlList";
            this.productlList.Size = new System.Drawing.Size(801, 307);
            this.productlList.TabIndex = 4;
            this.productlList.WrapContents = false;
            // 
            // CartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.productlList);
            this.Controls.Add(this.xuiButton1);
            this.Controls.Add(this.htmlLabel1);
            this.Name = "CartPage";
            this.Size = new System.Drawing.Size(876, 500);
            this.Load += new System.EventHandler(this.CartPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TheArtOfDev.HtmlRenderer.WinForms.HtmlLabel htmlLabel1;
        private XanderUI.XUIButton xuiButton1;
        private System.Windows.Forms.FlowLayoutPanel productlList;
    }
}
