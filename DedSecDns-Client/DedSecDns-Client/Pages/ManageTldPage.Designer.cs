namespace DedSecDns_Client.Pages
{
    partial class ManageTldPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageTldPage));
            this.xuiGauge1 = new XanderUI.XUIGauge();
            this.xuiLineGraph1 = new XanderUI.XUILineGraph();
            this.SuspendLayout();
            // 
            // xuiGauge1
            // 
            this.xuiGauge1.DialColor = System.Drawing.Color.Gray;
            this.xuiGauge1.DialThickness = 5;
            this.xuiGauge1.FilledColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(250)))));
            this.xuiGauge1.GaugeStyle = XanderUI.XUIGauge.Style.Material;
            this.xuiGauge1.Location = new System.Drawing.Point(496, 163);
            this.xuiGauge1.Name = "xuiGauge1";
            this.xuiGauge1.Percentage = 75;
            this.xuiGauge1.Size = new System.Drawing.Size(140, 70);
            this.xuiGauge1.TabIndex = 0;
            this.xuiGauge1.Text = "xuiGauge1";
            this.xuiGauge1.Thickness = 8;
            this.xuiGauge1.UnfilledColor = System.Drawing.Color.Gray;
            // 
            // xuiLineGraph1
            // 
            this.xuiLineGraph1.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174)))));
            this.xuiLineGraph1.BelowLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(202)))), ((int)(((byte)(142)))));
            this.xuiLineGraph1.BorderColor = System.Drawing.Color.White;
            this.xuiLineGraph1.GraphStyle = XanderUI.XUILineGraph.Style.Material;
            this.xuiLineGraph1.GraphTitle = "XUI LineGraph";
            this.xuiLineGraph1.GraphTitleColor = System.Drawing.Color.Gray;
            this.xuiLineGraph1.Items = ((System.Collections.Generic.List<int>)(resources.GetObject("xuiLineGraph1.Items")));
            this.xuiLineGraph1.LineColor = System.Drawing.Color.White;
            this.xuiLineGraph1.Location = new System.Drawing.Point(223, 221);
            this.xuiLineGraph1.Name = "xuiLineGraph1";
            this.xuiLineGraph1.PointSize = 7;
            this.xuiLineGraph1.ShowBorder = false;
            this.xuiLineGraph1.ShowPoints = true;
            this.xuiLineGraph1.ShowTitle = false;
            this.xuiLineGraph1.ShowVerticalLines = false;
            this.xuiLineGraph1.Size = new System.Drawing.Size(200, 100);
            this.xuiLineGraph1.TabIndex = 1;
            this.xuiLineGraph1.Text = "xuiLineGraph1";
            this.xuiLineGraph1.TitleAlignment = System.Drawing.StringAlignment.Near;
            this.xuiLineGraph1.VerticalLineColor = System.Drawing.Color.DimGray;
            // 
            // ManageTldPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.xuiLineGraph1);
            this.Controls.Add(this.xuiGauge1);
            this.Name = "ManageTldPage";
            this.Size = new System.Drawing.Size(896, 418);
            this.ResumeLayout(false);

        }

        #endregion

        private XanderUI.XUIGauge xuiGauge1;
        private XanderUI.XUILineGraph xuiLineGraph1;
    }
}
