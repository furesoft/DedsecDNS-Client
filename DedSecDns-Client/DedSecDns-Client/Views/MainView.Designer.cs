﻿namespace DedSecDns_Client.Views
{
    partial class MainView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.menuPanel = new XanderUI.XUIWidgetPanel();
            this.shopBtn = new XanderUI.XUIButton();
            this.searchbarPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.notificationControl1 = new DedSecDns_Client.Core.Controls.NotificationControl();
            this.logoutBtn = new XanderUI.XUIButton();
            this.tldManageBtn = new XanderUI.XUIButton();
            this.domainMngBtn = new XanderUI.XUIButton();
            this.contentPanel = new XanderUI.XUIWidgetPanel();
            this.welcomePage1 = new DedSecDns_Client.Pages.WelcomePage();
            this.xuiObjectAnimator1 = new XanderUI.XUIObjectAnimator();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuPanel.SuspendLayout();
            this.searchbarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.menuPanel.Controls.Add(this.shopBtn);
            this.menuPanel.Controls.Add(this.searchbarPanel);
            this.menuPanel.Controls.Add(this.notificationControl1);
            this.menuPanel.Controls.Add(this.logoutBtn);
            this.menuPanel.Controls.Add(this.tldManageBtn);
            this.menuPanel.Controls.Add(this.domainMngBtn);
            this.menuPanel.ControlsAsWidgets = false;
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Margin = new System.Windows.Forms.Padding(5);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Padding = new System.Windows.Forms.Padding(5);
            this.menuPanel.Size = new System.Drawing.Size(1214, 59);
            this.menuPanel.TabIndex = 3;
            // 
            // shopBtn
            // 
            this.shopBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(75)))));
            this.shopBtn.ButtonImage = null;
            this.shopBtn.ButtonStyle = XanderUI.XUIButton.Style.Material;
            this.shopBtn.ButtonText = "Shop";
            this.shopBtn.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.shopBtn.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.shopBtn.CornerRadius = 5;
            this.shopBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.shopBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.shopBtn.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.shopBtn.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.shopBtn.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.shopBtn.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.shopBtn.Location = new System.Drawing.Point(248, 5);
            this.shopBtn.Name = "shopBtn";
            this.shopBtn.Size = new System.Drawing.Size(112, 49);
            this.shopBtn.TabIndex = 8;
            this.shopBtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.shopBtn.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.shopBtn.Click += new System.EventHandler(this.xuiButton1_Click);
            // 
            // searchbarPanel
            // 
            this.searchbarPanel.Controls.Add(this.pictureBox1);
            this.searchbarPanel.Location = new System.Drawing.Point(862, 13);
            this.searchbarPanel.Name = "searchbarPanel";
            this.searchbarPanel.Size = new System.Drawing.Size(141, 38);
            this.searchbarPanel.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(106, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // notificationControl1
            // 
            this.notificationControl1.Location = new System.Drawing.Point(467, 5);
            this.notificationControl1.Message = "";
            this.notificationControl1.Name = "notificationControl1";
            this.notificationControl1.Size = new System.Drawing.Size(354, 46);
            this.notificationControl1.TabIndex = 6;
            this.notificationControl1.Visible = false;
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(75)))));
            this.logoutBtn.ButtonImage = ((System.Drawing.Image)(resources.GetObject("logoutBtn.ButtonImage")));
            this.logoutBtn.ButtonStyle = XanderUI.XUIButton.Style.Material;
            this.logoutBtn.ButtonText = "Abmelden";
            this.logoutBtn.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.logoutBtn.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.logoutBtn.CornerRadius = 5;
            this.logoutBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.logoutBtn.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.logoutBtn.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.logoutBtn.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.logoutBtn.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.logoutBtn.Location = new System.Drawing.Point(1009, 5);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(200, 49);
            this.logoutBtn.TabIndex = 5;
            this.logoutBtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.logoutBtn.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // tldManageBtn
            // 
            this.tldManageBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(75)))));
            this.tldManageBtn.ButtonImage = null;
            this.tldManageBtn.ButtonStyle = XanderUI.XUIButton.Style.Material;
            this.tldManageBtn.ButtonText = "TLD\'s";
            this.tldManageBtn.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.tldManageBtn.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.tldManageBtn.CornerRadius = 5;
            this.tldManageBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.tldManageBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tldManageBtn.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.tldManageBtn.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.tldManageBtn.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.tldManageBtn.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.tldManageBtn.Location = new System.Drawing.Point(137, 5);
            this.tldManageBtn.Name = "tldManageBtn";
            this.tldManageBtn.Size = new System.Drawing.Size(111, 49);
            this.tldManageBtn.TabIndex = 4;
            this.tldManageBtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.tldManageBtn.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.tldManageBtn.Click += new System.EventHandler(this.tldManageBtn_Click);
            // 
            // domainMngBtn
            // 
            this.domainMngBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(75)))));
            this.domainMngBtn.ButtonImage = null;
            this.domainMngBtn.ButtonStyle = XanderUI.XUIButton.Style.Material;
            this.domainMngBtn.ButtonText = "Domains";
            this.domainMngBtn.ClickBackColor = System.Drawing.Color.FloralWhite;
            this.domainMngBtn.ClickTextColor = System.Drawing.Color.FloralWhite;
            this.domainMngBtn.CornerRadius = 5;
            this.domainMngBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.domainMngBtn.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.domainMngBtn.HoverBackgroundColor = System.Drawing.Color.DodgerBlue;
            this.domainMngBtn.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.domainMngBtn.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.domainMngBtn.Location = new System.Drawing.Point(5, 5);
            this.domainMngBtn.Name = "domainMngBtn";
            this.domainMngBtn.Size = new System.Drawing.Size(132, 49);
            this.domainMngBtn.TabIndex = 3;
            this.domainMngBtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.domainMngBtn.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.domainMngBtn.Click += new System.EventHandler(this.domainMngBtn_Click);
            // 
            // contentPanel
            // 
            this.contentPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.contentPanel.Controls.Add(this.welcomePage1);
            this.contentPanel.ControlsAsWidgets = false;
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 59);
            this.contentPanel.Margin = new System.Windows.Forms.Padding(5);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Padding = new System.Windows.Forms.Padding(5);
            this.contentPanel.Size = new System.Drawing.Size(1214, 533);
            this.contentPanel.TabIndex = 4;
            // 
            // welcomePage1
            // 
            this.welcomePage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.welcomePage1.Location = new System.Drawing.Point(5, 5);
            this.welcomePage1.Name = "welcomePage1";
            this.welcomePage1.Size = new System.Drawing.Size(1204, 523);
            this.welcomePage1.TabIndex = 0;
            this.welcomePage1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.welcomePage1_KeyDown);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1214, 533);
            this.panel1.TabIndex = 5;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 592);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainView";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Projekt TheGreenB -  DNS Manager";
            this.Load += new System.EventHandler(this.MainView_Load);
            this.menuPanel.ResumeLayout(false);
            this.searchbarPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contentPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private XanderUI.XUIWidgetPanel menuPanel;
        private XanderUI.XUIButton logoutBtn;
        private XanderUI.XUIButton tldManageBtn;
        private XanderUI.XUIButton domainMngBtn;
        private XanderUI.XUIWidgetPanel contentPanel;
        private Core.Controls.NotificationControl notificationControl1;
        private XanderUI.XUIObjectAnimator xuiObjectAnimator1;
        private System.Windows.Forms.Panel searchbarPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Pages.WelcomePage welcomePage1;
        private System.Windows.Forms.Panel panel1;
        private XanderUI.XUIButton shopBtn;
    }
}