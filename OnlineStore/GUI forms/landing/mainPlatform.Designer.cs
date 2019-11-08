namespace OnlineStore
{
    partial class mainPlatform
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
            this.mControlPanelBtn = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // mControlPanelBtn
            // 
            this.mControlPanelBtn.ActiveLinkColor = System.Drawing.Color.LightCoral;
            this.mControlPanelBtn.AutoSize = true;
            this.mControlPanelBtn.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.mControlPanelBtn.LinkColor = System.Drawing.Color.Salmon;
            this.mControlPanelBtn.Location = new System.Drawing.Point(12, 9);
            this.mControlPanelBtn.Name = "mControlPanelBtn";
            this.mControlPanelBtn.Size = new System.Drawing.Size(70, 13);
            this.mControlPanelBtn.TabIndex = 2;
            this.mControlPanelBtn.TabStop = true;
            this.mControlPanelBtn.Text = "Control Panel";
            this.mControlPanelBtn.VisitedLinkColor = System.Drawing.Color.Salmon;
            this.mControlPanelBtn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.mControlPanelBtn_LinkClicked);
            // 
            // mainPlatform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(874, 599);
            this.Controls.Add(this.mControlPanelBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mainPlatform";
            this.Opacity = 0.9D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Online store";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainPlatform_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel mControlPanelBtn;
    }
}