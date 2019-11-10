namespace OnlineStore
{
    partial class action
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
            this.Approve = new System.Windows.Forms.Button();
            this.Decline = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Approve
            // 
            this.Approve.BackColor = System.Drawing.Color.LimeGreen;
            this.Approve.Location = new System.Drawing.Point(12, 50);
            this.Approve.Name = "Approve";
            this.Approve.Size = new System.Drawing.Size(129, 42);
            this.Approve.TabIndex = 0;
            this.Approve.Text = "Approve";
            this.Approve.UseVisualStyleBackColor = false;
            this.Approve.Click += new System.EventHandler(this.Approve_Click);
            // 
            // Decline
            // 
            this.Decline.BackColor = System.Drawing.Color.LightCoral;
            this.Decline.Location = new System.Drawing.Point(204, 50);
            this.Decline.Name = "Decline";
            this.Decline.Size = new System.Drawing.Size(129, 42);
            this.Decline.TabIndex = 1;
            this.Decline.Text = "Decline";
            this.Decline.UseVisualStyleBackColor = false;
            this.Decline.Click += new System.EventHandler(this.Decline_Click);
            // 
            // action
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 167);
            this.Controls.Add(this.Decline);
            this.Controls.Add(this.Approve);
            this.Name = "action";
            this.Text = "action";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Approve;
        private System.Windows.Forms.Button Decline;
    }
}