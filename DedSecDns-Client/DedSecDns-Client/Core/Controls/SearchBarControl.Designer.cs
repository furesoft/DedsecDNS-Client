namespace DedSecDns_Client.Core.Controls
{
    partial class SearchBarControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchBarControl));
            this.searchBtn = new System.Windows.Forms.PictureBox();
            this.waterMarkTextBox1 = new DedSecDns_Client.Core.Controls.WaterMarkTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.searchBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // searchBtn
            // 
            this.searchBtn.Image = ((System.Drawing.Image)(resources.GetObject("searchBtn.Image")));
            this.searchBtn.Location = new System.Drawing.Point(220, 5);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(20, 22);
            this.searchBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.searchBtn.TabIndex = 1;
            this.searchBtn.TabStop = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // waterMarkTextBox1
            // 
            this.waterMarkTextBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.waterMarkTextBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.waterMarkTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.waterMarkTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.waterMarkTextBox1.Location = new System.Drawing.Point(6, 9);
            this.waterMarkTextBox1.Name = "waterMarkTextBox1";
            this.waterMarkTextBox1.Size = new System.Drawing.Size(211, 15);
            this.waterMarkTextBox1.TabIndex = 2;
            this.waterMarkTextBox1.WaterMarkColor = System.Drawing.Color.Gray;
            this.waterMarkTextBox1.WaterMarkText = "Aktion suchen";
            this.waterMarkTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.waterMarkTextBox1_KeyDown);
            // 
            // SearchBarControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.waterMarkTextBox1);
            this.Controls.Add(this.searchBtn);
            this.Name = "SearchBarControl";
            this.Size = new System.Drawing.Size(244, 32);
            this.Tag = "Aktion suchen";
            this.Load += new System.EventHandler(this.SearchBarControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.searchBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox searchBtn;
        private WaterMarkTextBox waterMarkTextBox1;
    }
}
