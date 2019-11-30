namespace DedSecDns_Client
{
    partial class SplashView
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

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashView));
            this.xuiSplashScreen1 = new XanderUI.XUISplashScreen();
            this.SuspendLayout();
            // 
            // xuiSplashScreen1
            // 
            this.xuiSplashScreen1.AllowDragging = true;
            this.xuiSplashScreen1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.xuiSplashScreen1.BottomText = "DNS Manager";
            this.xuiSplashScreen1.BottomTextColor = System.Drawing.Color.White;
            this.xuiSplashScreen1.BottomTextSize = 16;
            this.xuiSplashScreen1.EllipseCornerRadius = 15;
            this.xuiSplashScreen1.IsEllipse = true;
            this.xuiSplashScreen1.LoadedColor = System.Drawing.Color.DodgerBlue;
            this.xuiSplashScreen1.ProgressBarStyle = XanderUI.XUIFlatProgressBar.Style.Flat;
            this.xuiSplashScreen1.SecondsDisplayed = 3000;
            this.xuiSplashScreen1.ShowProgressBar = true;
            this.xuiSplashScreen1.SplashSize = new System.Drawing.Size(450, 280);
            this.xuiSplashScreen1.TopText = "Projekt TheGreenB";
            this.xuiSplashScreen1.TopTextColor = System.Drawing.Color.White;
            this.xuiSplashScreen1.TopTextSize = 36;
            this.xuiSplashScreen1.UnloadedColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            // 
            // SplashView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 237);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SplashView";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.SplashView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public XanderUI.XUISplashScreen xuiSplashScreen1;
    }
}

