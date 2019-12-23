namespace OnlineStore
{
    partial class PurchaseItemForm
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
            this.ItemPictureBtn = new System.Windows.Forms.Button();
            this.ItemNameLabel = new System.Windows.Forms.Label();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.QuantityTextBox = new System.Windows.Forms.TextBox();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.AgreementsCheckBox = new System.Windows.Forms.CheckBox();
            this.FetchedQuantityLabel = new System.Windows.Forms.Label();
            this.FetchedBrandNameLabel = new System.Windows.Forms.Label();
            this.PurchaseBtn = new System.Windows.Forms.Button();
            this.purchaseErrorLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ItemPictureBtn
            // 
            this.ItemPictureBtn.Location = new System.Drawing.Point(90, 12);
            this.ItemPictureBtn.Name = "ItemPictureBtn";
            this.ItemPictureBtn.Size = new System.Drawing.Size(150, 171);
            this.ItemPictureBtn.TabIndex = 0;
            this.ItemPictureBtn.Text = "button1";
            this.ItemPictureBtn.UseVisualStyleBackColor = true;
            this.ItemPictureBtn.Click += new System.EventHandler(this.ItemPictureBtn_Click);
            // 
            // ItemNameLabel
            // 
            this.ItemNameLabel.AutoSize = true;
            this.ItemNameLabel.Location = new System.Drawing.Point(87, 186);
            this.ItemNameLabel.Name = "ItemNameLabel";
            this.ItemNameLabel.Size = new System.Drawing.Size(46, 17);
            this.ItemNameLabel.TabIndex = 1;
            this.ItemNameLabel.Text = "label1";
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Location = new System.Drawing.Point(14, 307);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(69, 17);
            this.QuantityLabel.TabIndex = 2;
            this.QuantityLabel.Text = "Quantity: ";
            // 
            // QuantityTextBox
            // 
            this.QuantityTextBox.Location = new System.Drawing.Point(79, 307);
            this.QuantityTextBox.Name = "QuantityTextBox";
            this.QuantityTextBox.Size = new System.Drawing.Size(195, 22);
            this.QuantityTextBox.TabIndex = 3;
            this.QuantityTextBox.TextChanged += new System.EventHandler(this.QuantityTextBox_TextChanged);
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(14, 350);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(68, 17);
            this.AddressLabel.TabIndex = 4;
            this.AddressLabel.Text = "Address: ";
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(79, 347);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(195, 22);
            this.AddressTextBox.TabIndex = 5;
            // 
            // AgreementsCheckBox
            // 
            this.AgreementsCheckBox.AutoSize = true;
            this.AgreementsCheckBox.Location = new System.Drawing.Point(16, 385);
            this.AgreementsCheckBox.Name = "AgreementsCheckBox";
            this.AgreementsCheckBox.Size = new System.Drawing.Size(249, 21);
            this.AgreementsCheckBox.TabIndex = 6;
            this.AgreementsCheckBox.Text = "I agree to the terms and conditions";
            this.AgreementsCheckBox.UseVisualStyleBackColor = true;
            this.AgreementsCheckBox.CheckedChanged += new System.EventHandler(this.AgreementsCheckBox_CheckedChanged);
            // 
            // FetchedQuantityLabel
            // 
            this.FetchedQuantityLabel.AutoSize = true;
            this.FetchedQuantityLabel.Location = new System.Drawing.Point(87, 220);
            this.FetchedQuantityLabel.Name = "FetchedQuantityLabel";
            this.FetchedQuantityLabel.Size = new System.Drawing.Size(46, 17);
            this.FetchedQuantityLabel.TabIndex = 7;
            this.FetchedQuantityLabel.Text = "label1";
            // 
            // FetchedBrandNameLabel
            // 
            this.FetchedBrandNameLabel.AutoSize = true;
            this.FetchedBrandNameLabel.Location = new System.Drawing.Point(87, 203);
            this.FetchedBrandNameLabel.Name = "FetchedBrandNameLabel";
            this.FetchedBrandNameLabel.Size = new System.Drawing.Size(46, 17);
            this.FetchedBrandNameLabel.TabIndex = 8;
            this.FetchedBrandNameLabel.Text = "label1";
            // 
            // PurchaseBtn
            // 
            this.PurchaseBtn.BackColor = System.Drawing.Color.LightCoral;
            this.PurchaseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PurchaseBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.PurchaseBtn.Location = new System.Drawing.Point(53, 430);
            this.PurchaseBtn.Margin = new System.Windows.Forms.Padding(4);
            this.PurchaseBtn.Name = "PurchaseBtn";
            this.PurchaseBtn.Size = new System.Drawing.Size(248, 31);
            this.PurchaseBtn.TabIndex = 31;
            this.PurchaseBtn.Text = "Purchase";
            this.PurchaseBtn.UseVisualStyleBackColor = false;
            this.PurchaseBtn.Click += new System.EventHandler(this.PurchaseBtn_Click);
            // 
            // purchaseErrorLabel
            // 
            this.purchaseErrorLabel.AutoSize = true;
            this.purchaseErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.purchaseErrorLabel.Location = new System.Drawing.Point(13, 409);
            this.purchaseErrorLabel.Name = "purchaseErrorLabel";
            this.purchaseErrorLabel.Size = new System.Drawing.Size(342, 17);
            this.purchaseErrorLabel.TabIndex = 32;
            this.purchaseErrorLabel.Text = "Please Agree to the terms and conditions to continue";
            this.purchaseErrorLabel.Click += new System.EventHandler(this.purchaseErrorLabel_Click);
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(87, 237);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(46, 17);
            this.priceLabel.TabIndex = 33;
            this.priceLabel.Text = "label1";
            this.priceLabel.Click += new System.EventHandler(this.priceLabel_Click);
            // 
            // PurchaseItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 474);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.purchaseErrorLabel);
            this.Controls.Add(this.PurchaseBtn);
            this.Controls.Add(this.FetchedBrandNameLabel);
            this.Controls.Add(this.FetchedQuantityLabel);
            this.Controls.Add(this.AgreementsCheckBox);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.QuantityTextBox);
            this.Controls.Add(this.QuantityLabel);
            this.Controls.Add(this.ItemNameLabel);
            this.Controls.Add(this.ItemPictureBtn);
            this.Name = "PurchaseItemForm";
            this.Text = "PurchaseItemForm";
            this.Load += new System.EventHandler(this.PurchaseItemForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ItemPictureBtn;
        private System.Windows.Forms.Label ItemNameLabel;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.TextBox QuantityTextBox;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.CheckBox AgreementsCheckBox;
        private System.Windows.Forms.Label FetchedQuantityLabel;
        private System.Windows.Forms.Label FetchedBrandNameLabel;
        private System.Windows.Forms.Button PurchaseBtn;
        private System.Windows.Forms.Label purchaseErrorLabel;
        private System.Windows.Forms.Label priceLabel;
    }
}