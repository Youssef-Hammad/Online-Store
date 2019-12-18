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
            this.LiveStatistics = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rAddStoreBtn
            // 
            this.rAddStoreBtn.BackColor = System.Drawing.Color.LightCoral;
            this.rAddStoreBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rAddStoreBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.rAddStoreBtn.Location = new System.Drawing.Point(25, 80);
            this.rAddStoreBtn.Name = "rAddStoreBtn";
            this.rAddStoreBtn.Size = new System.Drawing.Size(186, 25);
            this.rAddStoreBtn.TabIndex = 28;
            this.rAddStoreBtn.Text = "Add Store";
            this.rAddStoreBtn.UseVisualStyleBackColor = false;
            this.rAddStoreBtn.Click += new System.EventHandler(this.rAddStoreBtn_Click);
            // 
            // LiveStatistics
            // 
            this.LiveStatistics.BackColor = System.Drawing.Color.LightCoral;
            this.LiveStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LiveStatistics.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.LiveStatistics.Location = new System.Drawing.Point(25, 184);
            this.LiveStatistics.Name = "LiveStatistics";
            this.LiveStatistics.Size = new System.Drawing.Size(186, 25);
            this.LiveStatistics.TabIndex = 29;
            this.LiveStatistics.Text = "Live Statistics";
            this.LiveStatistics.UseVisualStyleBackColor = false;
            this.LiveStatistics.Click += new System.EventHandler(this.LiveStatisticsBtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCoral;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(25, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 25);
            this.button1.TabIndex = 30;
            this.button1.Text = "Make a new collaborator";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // merchantPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(237, 330);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LiveStatistics);
            this.Controls.Add(this.rAddStoreBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "merchantPanel";
            this.Opacity = 0.9D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Merchant CPanel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button rAddStoreBtn;
        private System.Windows.Forms.Button LiveStatistics;
        private System.Windows.Forms.Button button1;
    }
}