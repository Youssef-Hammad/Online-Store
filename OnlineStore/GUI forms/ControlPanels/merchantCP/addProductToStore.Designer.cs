namespace OnlineStore
{
    partial class addProductToStore
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
            this.productComboBox = new System.Windows.Forms.ComboBox();
            this.productLabel = new System.Windows.Forms.Label();
            this.storeLabel = new System.Windows.Forms.Label();
            this.storeComboBox = new System.Windows.Forms.ComboBox();
            this.rAddProductBtn = new System.Windows.Forms.Button();
            this.stockLabel = new System.Windows.Forms.Label();
            this.stockTextBox = new System.Windows.Forms.TextBox();
            this.AddProductErrorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // productComboBox
            // 
            this.productComboBox.FormattingEnabled = true;
            this.productComboBox.Location = new System.Drawing.Point(128, 48);
            this.productComboBox.Name = "productComboBox";
            this.productComboBox.Size = new System.Drawing.Size(167, 24);
            this.productComboBox.TabIndex = 0;
            this.productComboBox.SelectedIndexChanged += new System.EventHandler(this.productComboBox_SelectedIndexChanged);
            // 
            // productLabel
            // 
            this.productLabel.AutoSize = true;
            this.productLabel.Location = new System.Drawing.Point(44, 51);
            this.productLabel.Name = "productLabel";
            this.productLabel.Size = new System.Drawing.Size(65, 17);
            this.productLabel.TabIndex = 1;
            this.productLabel.Text = "Product: ";
            // 
            // storeLabel
            // 
            this.storeLabel.AutoSize = true;
            this.storeLabel.Location = new System.Drawing.Point(44, 101);
            this.storeLabel.Name = "storeLabel";
            this.storeLabel.Size = new System.Drawing.Size(50, 17);
            this.storeLabel.TabIndex = 2;
            this.storeLabel.Text = "Store: ";
            // 
            // storeComboBox
            // 
            this.storeComboBox.FormattingEnabled = true;
            this.storeComboBox.Location = new System.Drawing.Point(128, 101);
            this.storeComboBox.Name = "storeComboBox";
            this.storeComboBox.Size = new System.Drawing.Size(167, 24);
            this.storeComboBox.TabIndex = 3;
            // 
            // rAddProductBtn
            // 
            this.rAddProductBtn.BackColor = System.Drawing.Color.LightCoral;
            this.rAddProductBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rAddProductBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.rAddProductBtn.Location = new System.Drawing.Point(47, 218);
            this.rAddProductBtn.Margin = new System.Windows.Forms.Padding(4);
            this.rAddProductBtn.Name = "rAddProductBtn";
            this.rAddProductBtn.Size = new System.Drawing.Size(248, 31);
            this.rAddProductBtn.TabIndex = 29;
            this.rAddProductBtn.Text = "Add Product";
            this.rAddProductBtn.UseVisualStyleBackColor = false;
            this.rAddProductBtn.Click += new System.EventHandler(this.rAddProductBtn_Click);
            // 
            // stockLabel
            // 
            this.stockLabel.AutoSize = true;
            this.stockLabel.Location = new System.Drawing.Point(44, 154);
            this.stockLabel.Name = "stockLabel";
            this.stockLabel.Size = new System.Drawing.Size(51, 17);
            this.stockLabel.TabIndex = 30;
            this.stockLabel.Text = "Stock: ";
            this.stockLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // stockTextBox
            // 
            this.stockTextBox.Location = new System.Drawing.Point(128, 154);
            this.stockTextBox.Name = "stockTextBox";
            this.stockTextBox.Size = new System.Drawing.Size(167, 22);
            this.stockTextBox.TabIndex = 31;
            // 
            // AddProductErrorLabel
            // 
            this.AddProductErrorLabel.AutoSize = true;
            this.AddProductErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.AddProductErrorLabel.Location = new System.Drawing.Point(59, 197);
            this.AddProductErrorLabel.Name = "AddProductErrorLabel";
            this.AddProductErrorLabel.Size = new System.Drawing.Size(221, 17);
            this.AddProductErrorLabel.TabIndex = 32;
            this.AddProductErrorLabel.Text = "Please select an item to purchase";
            // 
            // addProductToStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 262);
            this.Controls.Add(this.AddProductErrorLabel);
            this.Controls.Add(this.stockTextBox);
            this.Controls.Add(this.stockLabel);
            this.Controls.Add(this.rAddProductBtn);
            this.Controls.Add(this.storeComboBox);
            this.Controls.Add(this.storeLabel);
            this.Controls.Add(this.productLabel);
            this.Controls.Add(this.productComboBox);
            this.Name = "addProductToStore";
            this.Text = "addProductToStore";
            this.Load += new System.EventHandler(this.addProductToStore_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox productComboBox;
        private System.Windows.Forms.Label productLabel;
        private System.Windows.Forms.Label storeLabel;
        private System.Windows.Forms.ComboBox storeComboBox;
        private System.Windows.Forms.Button rAddProductBtn;
        private System.Windows.Forms.Label stockLabel;
        private System.Windows.Forms.TextBox stockTextBox;
        private System.Windows.Forms.Label AddProductErrorLabel;
    }
}