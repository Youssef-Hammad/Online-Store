namespace OnlineStore
{
    partial class merchantPanel
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
            this.rAddStoreBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rAddStoreBtn
            // 
            this.rAddStoreBtn.BackColor = System.Drawing.Color.LightCoral;
            this.rAddStoreBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rAddStoreBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.rAddStoreBtn.Location = new System.Drawing.Point(368, 197);
            this.rAddStoreBtn.Margin = new System.Windows.Forms.Padding(4);
            this.rAddStoreBtn.Name = "rAddStoreBtn";
            this.rAddStoreBtn.Size = new System.Drawing.Size(248, 31);
            this.rAddStoreBtn.TabIndex = 28;
            this.rAddStoreBtn.Text = "Add Store";
            this.rAddStoreBtn.UseVisualStyleBackColor = false;
            this.rAddStoreBtn.Click += new System.EventHandler(this.rAddStoreBtn_Click);
            // 
            // merchantPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1043, 553);
            this.Controls.Add(this.rAddStoreBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "merchantPanel";
            this.Opacity = 0.9D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "merchant CPanel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button rAddStoreBtn;
    }
}