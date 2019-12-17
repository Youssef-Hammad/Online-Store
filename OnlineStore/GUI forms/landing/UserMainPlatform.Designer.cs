namespace OnlineStore
{
    partial class UserMainPlatform
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
            this.ItemsComboBox = new System.Windows.Forms.ComboBox();
            this.ProductsLabel = new System.Windows.Forms.Label();
            this.PurchaseBtn = new System.Windows.Forms.Button();
            this.purchaseErrorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ItemsComboBox
            // 
            this.ItemsComboBox.FormattingEnabled = true;
            this.ItemsComboBox.Location = new System.Drawing.Point(12, 72);
            this.ItemsComboBox.Name = "ItemsComboBox";
            this.ItemsComboBox.Size = new System.Drawing.Size(121, 24);
            this.ItemsComboBox.TabIndex = 2;
            this.ItemsComboBox.SelectedIndexChanged += new System.EventHandler(this.ItemsComboBox_SelectedIndexChanged);
            // 
            // ProductsLabel
            // 
            this.ProductsLabel.AutoSize = true;
            this.ProductsLabel.Location = new System.Drawing.Point(13, 49);
            this.ProductsLabel.Name = "ProductsLabel";
            this.ProductsLabel.Size = new System.Drawing.Size(68, 17);
            this.ProductsLabel.TabIndex = 3;
            this.ProductsLabel.Text = "Products:";
            // 
            // PurchaseBtn
            // 
            this.PurchaseBtn.BackColor = System.Drawing.Color.LightCoral;
            this.PurchaseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PurchaseBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.PurchaseBtn.Location = new System.Drawing.Point(86, 219);
            this.PurchaseBtn.Margin = new System.Windows.Forms.Padding(4);
            this.PurchaseBtn.Name = "PurchaseBtn";
            this.PurchaseBtn.Size = new System.Drawing.Size(248, 31);
            this.PurchaseBtn.TabIndex = 30;
            this.PurchaseBtn.Text = "Purchase";
            this.PurchaseBtn.UseVisualStyleBackColor = false;
            this.PurchaseBtn.Click += new System.EventHandler(this.PurchaseBtn_Click);
            // 
            // purchaseErrorLabel
            // 
            this.purchaseErrorLabel.AutoSize = true;
            this.purchaseErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.purchaseErrorLabel.Location = new System.Drawing.Point(99, 198);
            this.purchaseErrorLabel.Name = "purchaseErrorLabel";
            this.purchaseErrorLabel.Size = new System.Drawing.Size(221, 17);
            this.purchaseErrorLabel.TabIndex = 31;
            this.purchaseErrorLabel.Text = "Please select an item to purchase";
            this.purchaseErrorLabel.Click += new System.EventHandler(this.purchaseErrorLabel_Click);
            // 
            // UserMainPlatform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 263);
            this.Controls.Add(this.purchaseErrorLabel);
            this.Controls.Add(this.PurchaseBtn);
            this.Controls.Add(this.ProductsLabel);
            this.Controls.Add(this.ItemsComboBox);
            this.Name = "UserMainPlatform";
            this.Text = "Market";
            this.Load += new System.EventHandler(this.UserMainPlatform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ItemsComboBox;
        private System.Windows.Forms.Label ProductsLabel;
        private System.Windows.Forms.Button PurchaseBtn;
        private System.Windows.Forms.Label purchaseErrorLabel;
    }
}