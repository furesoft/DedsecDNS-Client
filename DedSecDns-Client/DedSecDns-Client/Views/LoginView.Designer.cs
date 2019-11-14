namespace DedSecDns_Client.Views
{
    partial class LoginView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginView));
            this.formDropShadow1 = new XanderUI.FormDropShadow();
            this.loginBtn = new XanderUI.XUIButton();
            this.registerBtn = new XanderUI.XUIButton();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.PasswordLbl = new System.Windows.Forms.Label();
            this.forgotPasswordLink = new System.Windows.Forms.LinkLabel();
            this.usernameTb = new System.Windows.Forms.TextBox();
            this.passwordTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // formDropShadow1
            // 
            this.formDropShadow1.EffectedForm = this;
            this.formDropShadow1.ShadowAngle = 2;
            // 
            // loginBtn
            // 
            this.loginBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(75)))));
            this.loginBtn.ButtonImage = ((System.Drawing.Image)(resources.GetObject("loginBtn.ButtonImage")));
            this.loginBtn.ButtonStyle = XanderUI.XUIButton.Style.Material;
            this.loginBtn.ButtonText = "Anmelden";
            this.loginBtn.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.loginBtn.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.loginBtn.CornerRadius = 5;
            this.loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.loginBtn.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.loginBtn.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.loginBtn.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.loginBtn.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.loginBtn.Location = new System.Drawing.Point(276, 243);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(200, 50);
            this.loginBtn.TabIndex = 0;
            this.loginBtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.loginBtn.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // registerBtn
            // 
            this.registerBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(75)))));
            this.registerBtn.ButtonImage = ((System.Drawing.Image)(resources.GetObject("registerBtn.ButtonImage")));
            this.registerBtn.ButtonStyle = XanderUI.XUIButton.Style.Material;
            this.registerBtn.ButtonText = "Registrieren";
            this.registerBtn.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.registerBtn.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.registerBtn.CornerRadius = 5;
            this.registerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.registerBtn.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.registerBtn.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.registerBtn.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.registerBtn.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.registerBtn.Location = new System.Drawing.Point(12, 243);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(216, 50);
            this.registerBtn.TabIndex = 1;
            this.registerBtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.registerBtn.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLbl.Location = new System.Drawing.Point(25, 119);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(139, 25);
            this.usernameLbl.TabIndex = 2;
            this.usernameLbl.Text = "Benutzername";
            // 
            // PasswordLbl
            // 
            this.PasswordLbl.AutoSize = true;
            this.PasswordLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLbl.Location = new System.Drawing.Point(25, 159);
            this.PasswordLbl.Name = "PasswordLbl";
            this.PasswordLbl.Size = new System.Drawing.Size(92, 25);
            this.PasswordLbl.TabIndex = 3;
            this.PasswordLbl.Text = "Passwort";
            // 
            // forgotPasswordLink
            // 
            this.forgotPasswordLink.AutoSize = true;
            this.forgotPasswordLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgotPasswordLink.Location = new System.Drawing.Point(197, 201);
            this.forgotPasswordLink.Name = "forgotPasswordLink";
            this.forgotPasswordLink.Size = new System.Drawing.Size(161, 20);
            this.forgotPasswordLink.TabIndex = 4;
            this.forgotPasswordLink.TabStop = true;
            this.forgotPasswordLink.Text = "Passwort vergessen";
            this.forgotPasswordLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.forgotPasswordLink_LinkClicked);
            // 
            // usernameTb
            // 
            this.usernameTb.Location = new System.Drawing.Point(201, 121);
            this.usernameTb.Name = "usernameTb";
            this.usernameTb.Size = new System.Drawing.Size(248, 22);
            this.usernameTb.TabIndex = 5;
            // 
            // passwordTb
            // 
            this.passwordTb.Location = new System.Drawing.Point(201, 163);
            this.passwordTb.Name = "passwordTb";
            this.passwordTb.Size = new System.Drawing.Size(248, 22);
            this.passwordTb.TabIndex = 6;
            this.passwordTb.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Dedsec DNS Manager";
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(488, 316);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordTb);
            this.Controls.Add(this.usernameTb);
            this.Controls.Add(this.forgotPasswordLink);
            this.Controls.Add(this.PasswordLbl);
            this.Controls.Add(this.usernameLbl);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.loginBtn);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DedSec DNS - Anmelden";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private XanderUI.FormDropShadow formDropShadow1;
        private XanderUI.XUIButton loginBtn;
        private XanderUI.XUIButton registerBtn;
        private System.Windows.Forms.Label PasswordLbl;
        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.TextBox passwordTb;
        private System.Windows.Forms.TextBox usernameTb;
        private System.Windows.Forms.LinkLabel forgotPasswordLink;
        private System.Windows.Forms.Label label1;
    }
}