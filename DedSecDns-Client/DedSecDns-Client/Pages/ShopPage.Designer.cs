﻿namespace DedSecDns_Client.Pages
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
            this.button1 = new System.Windows.Forms.Button();
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
            // cartBtn
            // 
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(384, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ShopPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
    }
}