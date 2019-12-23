namespace OnlineStore
{
    partial class undoAction
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
            this.lLoginBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lLoginBtn
            // 
            this.lLoginBtn.BackColor = System.Drawing.Color.LightCoral;
            this.lLoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lLoginBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lLoginBtn.Location = new System.Drawing.Point(14, 46);
            this.lLoginBtn.Margin = new System.Windows.Forms.Padding(4);
            this.lLoginBtn.Name = "lLoginBtn";
            this.lLoginBtn.Size = new System.Drawing.Size(239, 37);
            this.lLoginBtn.TabIndex = 1;
            this.lLoginBtn.Text = "Undo Action";
            this.lLoginBtn.UseVisualStyleBackColor = false;
            // 
            // undoAction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 123);
            this.Controls.Add(this.lLoginBtn);
            this.Name = "undoAction";
            this.Text = "undoAction";
            this.Load += new System.EventHandler(this.undoAction_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button lLoginBtn;
    }
}