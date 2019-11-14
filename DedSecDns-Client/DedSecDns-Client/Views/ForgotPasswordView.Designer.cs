namespace DedSecDns_Client.Views
{
    partial class ForgotPasswordView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPasswordView));
            this.resetBtn = new XanderUI.XUIButton();
            this.cancelBtn = new XanderUI.XUIButton();
            this.usernameTb = new System.Windows.Forms.TextBox();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // resetBtn
            // 
            this.resetBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(75)))));
            this.resetBtn.ButtonImage = ((System.Drawing.Image)(resources.GetObject("resetBtn.ButtonImage")));
            this.resetBtn.ButtonStyle = XanderUI.XUIButton.Style.Material;
            this.resetBtn.ButtonText = "Passwort zurücksetzen";
            this.resetBtn.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.resetBtn.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.resetBtn.CornerRadius = 5;
            this.resetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.resetBtn.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.resetBtn.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.resetBtn.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.resetBtn.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.resetBtn.Location = new System.Drawing.Point(226, 243);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(228, 50);
            this.resetBtn.TabIndex = 1;
            this.resetBtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.resetBtn.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(75)))));
            this.cancelBtn.ButtonImage = ((System.Drawing.Image)(resources.GetObject("cancelBtn.ButtonImage")));
            this.cancelBtn.ButtonStyle = XanderUI.XUIButton.Style.Material;
            this.cancelBtn.ButtonText = "Abbrechen";
            this.cancelBtn.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.cancelBtn.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.cancelBtn.CornerRadius = 5;
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cancelBtn.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.cancelBtn.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.cancelBtn.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.cancelBtn.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.cancelBtn.Location = new System.Drawing.Point(18, 243);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(200, 50);
            this.cancelBtn.TabIndex = 2;
            this.cancelBtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.cancelBtn.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // usernameTb
            // 
            this.usernameTb.Location = new System.Drawing.Point(191, 23);
            this.usernameTb.Name = "usernameTb";
            this.usernameTb.Size = new System.Drawing.Size(248, 22);
            this.usernameTb.TabIndex = 7;
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLbl.Location = new System.Drawing.Point(15, 21);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(139, 25);
            this.usernameLbl.TabIndex = 6;
            this.usernameLbl.Text = "Benutzername";
            // 
            // ForgotPasswordView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(482, 305);
            this.Controls.Add(this.usernameTb);
            this.Controls.Add(this.usernameLbl);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.resetBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ForgotPasswordView";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgotPasswordView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private XanderUI.XUIButton resetBtn;
        private XanderUI.XUIButton cancelBtn;
        private System.Windows.Forms.TextBox usernameTb;
        private System.Windows.Forms.Label usernameLbl;
    }
}