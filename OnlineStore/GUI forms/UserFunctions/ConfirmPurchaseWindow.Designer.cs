namespace OnlineStore
{
    partial class ConfirmPurchaseWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.originalPriceLabel = new System.Windows.Forms.Label();
            this.discountOffersLabel = new System.Windows.Forms.Label();
            this.finalPriceLabel = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Original Price:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Discount Offers: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Final Price: ";
            // 
            // originalPriceLabel
            // 
            this.originalPriceLabel.AutoSize = true;
            this.originalPriceLabel.Location = new System.Drawing.Point(296, 36);
            this.originalPriceLabel.Name = "originalPriceLabel";
            this.originalPriceLabel.Size = new System.Drawing.Size(46, 17);
            this.originalPriceLabel.TabIndex = 3;
            this.originalPriceLabel.Text = "label4";
            // 
            // discountOffersLabel
            // 
            this.discountOffersLabel.AutoSize = true;
            this.discountOffersLabel.Location = new System.Drawing.Point(296, 72);
            this.discountOffersLabel.Name = "discountOffersLabel";
            this.discountOffersLabel.Size = new System.Drawing.Size(46, 17);
            this.discountOffersLabel.TabIndex = 4;
            this.discountOffersLabel.Text = "label5";
            // 
            // finalPriceLabel
            // 
            this.finalPriceLabel.AutoSize = true;
            this.finalPriceLabel.Location = new System.Drawing.Point(296, 144);
            this.finalPriceLabel.Name = "finalPriceLabel";
            this.finalPriceLabel.Size = new System.Drawing.Size(46, 17);
            this.finalPriceLabel.TabIndex = 5;
            this.finalPriceLabel.Text = "label6";
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.LightCoral;
            this.cancelBtn.Location = new System.Drawing.Point(241, 194);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(129, 42);
            this.cancelBtn.TabIndex = 7;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // confirmBtn
            // 
            this.confirmBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.confirmBtn.Location = new System.Drawing.Point(45, 194);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(129, 42);
            this.confirmBtn.TabIndex = 8;
            this.confirmBtn.Text = "Confirm";
            this.confirmBtn.UseVisualStyleBackColor = false;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // ConfirmPurchaseWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 248);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.finalPriceLabel);
            this.Controls.Add(this.discountOffersLabel);
            this.Controls.Add(this.originalPriceLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ConfirmPurchaseWindow";
            this.Text = "ConfirmPurchaseWindow";
            this.Load += new System.EventHandler(this.ConfirmPurchaseWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label originalPriceLabel;
        private System.Windows.Forms.Label discountOffersLabel;
        private System.Windows.Forms.Label finalPriceLabel;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button confirmBtn;
    }
}