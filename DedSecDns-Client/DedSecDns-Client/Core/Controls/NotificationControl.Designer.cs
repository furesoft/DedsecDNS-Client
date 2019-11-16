namespace DedSecDns_Client.Core.Controls
{
    partial class NotificationControl
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
            this.components = new System.ComponentModel.Container();
            this.messageLbl = new System.Windows.Forms.Label();
            this.xuiObjectAnimator1 = new XanderUI.XUIObjectAnimator();
            this.borderPanel = new System.Windows.Forms.Panel();
            this.hideTimer = new System.Windows.Forms.Timer(this.components);
            this.borderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // messageLbl
            // 
            this.messageLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messageLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLbl.Location = new System.Drawing.Point(0, 0);
            this.messageLbl.Name = "messageLbl";
            this.messageLbl.Size = new System.Drawing.Size(352, 78);
            this.messageLbl.TabIndex = 0;
            this.messageLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // borderPanel
            // 
            this.borderPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.borderPanel.Controls.Add(this.messageLbl);
            this.borderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.borderPanel.Location = new System.Drawing.Point(0, 0);
            this.borderPanel.Name = "borderPanel";
            this.borderPanel.Size = new System.Drawing.Size(354, 80);
            this.borderPanel.TabIndex = 1;
            // 
            // hideTimer
            // 
            this.hideTimer.Interval = 5000;
            this.hideTimer.Tick += new System.EventHandler(this.hideTimer_Tick);
            // 
            // NotificationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.borderPanel);
            this.Name = "NotificationControl";
            this.Size = new System.Drawing.Size(354, 80);
            this.Load += new System.EventHandler(this.NotificationControl_Load);
            this.borderPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label messageLbl;
        private XanderUI.XUIObjectAnimator xuiObjectAnimator1;
        private System.Windows.Forms.Panel borderPanel;
        private System.Windows.Forms.Timer hideTimer;
    }
}
