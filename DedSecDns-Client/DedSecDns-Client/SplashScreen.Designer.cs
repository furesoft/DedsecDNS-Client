namespace DedSecDns_Client
{
    partial class SplashScreen
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
            this.xuiCircleProgressBar1 = new XanderUI.XUICircleProgressBar();
            this.xuiSplashScreen1 = new XanderUI.XUISplashScreen();
            this.xuiObjectAnimator1 = new XanderUI.XUIObjectAnimator();
            this.SuspendLayout();
            // 
            // xuiCircleProgressBar1
            // 
            this.xuiCircleProgressBar1.AnimationSpeed = 5;
            this.xuiCircleProgressBar1.FilledColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(220)))), ((int)(((byte)(210)))));
            this.xuiCircleProgressBar1.FilledColorAlpha = 130;
            this.xuiCircleProgressBar1.FilledThickness = 40;
            this.xuiCircleProgressBar1.IsAnimated = false;
            this.xuiCircleProgressBar1.Location = new System.Drawing.Point(504, 196);
            this.xuiCircleProgressBar1.Name = "xuiCircleProgressBar1";
            this.xuiCircleProgressBar1.Percentage = 63;
            this.xuiCircleProgressBar1.ShowText = true;
            this.xuiCircleProgressBar1.Size = new System.Drawing.Size(200, 200);
            this.xuiCircleProgressBar1.TabIndex = 0;
            this.xuiCircleProgressBar1.TextColor = System.Drawing.Color.Gray;
            this.xuiCircleProgressBar1.TextSize = 25;
            this.xuiCircleProgressBar1.UnFilledColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            this.xuiCircleProgressBar1.UnfilledThickness = 24;
            // 
            // xuiSplashScreen1
            // 
            this.xuiSplashScreen1.AllowDragging = true;
            this.xuiSplashScreen1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.xuiSplashScreen1.BottomText = "Community edition";
            this.xuiSplashScreen1.BottomTextColor = System.Drawing.Color.White;
            this.xuiSplashScreen1.BottomTextSize = 16;
            this.xuiSplashScreen1.EllipseCornerRadius = 10;
            this.xuiSplashScreen1.IsEllipse = false;
            this.xuiSplashScreen1.LoadedColor = System.Drawing.Color.DodgerBlue;
            this.xuiSplashScreen1.ProgressBarStyle = XanderUI.XUIFlatProgressBar.Style.Material;
            this.xuiSplashScreen1.SecondsDisplayed = 3000;
            this.xuiSplashScreen1.ShowProgressBar = true;
            this.xuiSplashScreen1.SplashSize = new System.Drawing.Size(450, 280);
            this.xuiSplashScreen1.TopText = "VisualStudio";
            this.xuiSplashScreen1.TopTextColor = System.Drawing.Color.White;
            this.xuiSplashScreen1.TopTextSize = 36;
            this.xuiSplashScreen1.UnloadedColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 539);
            this.Controls.Add(this.xuiCircleProgressBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private XanderUI.XUICircleProgressBar xuiCircleProgressBar1;
        private XanderUI.XUISplashScreen xuiSplashScreen1;
        private XanderUI.XUIObjectAnimator xuiObjectAnimator1;
    }
}

