namespace OnlineStore
{
    partial class adminPanel
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
            this.rRegisterBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rRegisterBtn
            // 
            this.rRegisterBtn.BackColor = System.Drawing.Color.LightCoral;
            this.rRegisterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rRegisterBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.rRegisterBtn.Location = new System.Drawing.Point(12, 12);
            this.rRegisterBtn.Name = "rRegisterBtn";
            this.rRegisterBtn.Size = new System.Drawing.Size(173, 25);
            this.rRegisterBtn.TabIndex = 15;
            this.rRegisterBtn.Text = "add product";
            this.rRegisterBtn.UseVisualStyleBackColor = false;
            this.rRegisterBtn.Click += new System.EventHandler(this.rRegisterBtn_Click);
            // 
            // adminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(471, 481);
            this.Controls.Add(this.rRegisterBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "adminPanel";
            this.Opacity = 0.9D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "admin CPanel";
            this.Load += new System.EventHandler(this.adminPanel_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button rRegisterBtn;
    }
}