namespace OnlineStore
{
    partial class addProduct
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
            this.rAddProductBtn = new System.Windows.Forms.Button();
            this.pCategoryTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pPriceTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pNameTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pBrandTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rAddProductBtn
            // 
            this.rAddProductBtn.BackColor = System.Drawing.Color.LightCoral;
            this.rAddProductBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rAddProductBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.rAddProductBtn.Location = new System.Drawing.Point(12, 273);
            this.rAddProductBtn.Name = "rAddProductBtn";
            this.rAddProductBtn.Size = new System.Drawing.Size(186, 25);
            this.rAddProductBtn.TabIndex = 27;
            this.rAddProductBtn.Text = "add product";
            this.rAddProductBtn.UseVisualStyleBackColor = false;
            this.rAddProductBtn.Click += new System.EventHandler(this.rAddProductBtn_Click);
            // 
            // pCategoryTxt
            // 
            this.pCategoryTxt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pCategoryTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pCategoryTxt.Location = new System.Drawing.Point(12, 171);
            this.pCategoryTxt.Name = "pCategoryTxt";
            this.pCategoryTxt.Size = new System.Drawing.Size(186, 20);
            this.pCategoryTxt.TabIndex = 20;
            this.pCategoryTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "Product Category";
            // 
            // pPriceTxt
            // 
            this.pPriceTxt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pPriceTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pPriceTxt.Location = new System.Drawing.Point(12, 104);
            this.pPriceTxt.Name = "pPriceTxt";
            this.pPriceTxt.Size = new System.Drawing.Size(186, 20);
            this.pPriceTxt.TabIndex = 18;
            this.pPriceTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "Product Price";
            // 
            // pNameTxt
            // 
            this.pNameTxt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pNameTxt.Location = new System.Drawing.Point(12, 43);
            this.pNameTxt.Name = "pNameTxt";
            this.pNameTxt.Size = new System.Drawing.Size(186, 20);
            this.pNameTxt.TabIndex = 16;
            this.pNameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Product Name";
            // 
            // pBrandTxt
            // 
            this.pBrandTxt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pBrandTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBrandTxt.Location = new System.Drawing.Point(12, 236);
            this.pBrandTxt.Name = "pBrandTxt";
            this.pBrandTxt.Size = new System.Drawing.Size(186, 20);
            this.pBrandTxt.TabIndex = 29;
            this.pBrandTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 15);
            this.label4.TabIndex = 28;
            this.label4.Text = "Product Brand Name";
            // 
            // addProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(211, 313);
            this.Controls.Add(this.pBrandTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rAddProductBtn);
            this.Controls.Add(this.pCategoryTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pPriceTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pNameTxt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "addProduct";
            this.Opacity = 0.9D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Product (admin)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rAddProductBtn;
        private System.Windows.Forms.TextBox pCategoryTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pPriceTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pNameTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pBrandTxt;
        private System.Windows.Forms.Label label4;
    }
}