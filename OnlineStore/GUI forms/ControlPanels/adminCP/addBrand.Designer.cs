namespace OnlineStore
{
    partial class addBrand
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rAddProductBtn
            // 
            this.rAddProductBtn.BackColor = System.Drawing.Color.LightCoral;
            this.rAddProductBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rAddProductBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.rAddProductBtn.Location = new System.Drawing.Point(20, 341);
            this.rAddProductBtn.Margin = new System.Windows.Forms.Padding(4);
            this.rAddProductBtn.Name = "rAddProductBtn";
            this.rAddProductBtn.Size = new System.Drawing.Size(248, 31);
            this.rAddProductBtn.TabIndex = 30;
            this.rAddProductBtn.Text = "add product";
            this.rAddProductBtn.UseVisualStyleBackColor = false;
            this.rAddProductBtn.Click += new System.EventHandler(this.rAddProductBtn_Click);
            // 
            // pCategoryTxt
            // 
            this.pCategoryTxt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pCategoryTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pCategoryTxt.Location = new System.Drawing.Point(20, 113);
            this.pCategoryTxt.Margin = new System.Windows.Forms.Padding(4);
            this.pCategoryTxt.Name = "pCategoryTxt";
            this.pCategoryTxt.Size = new System.Drawing.Size(247, 22);
            this.pCategoryTxt.TabIndex = 29;
            this.pCategoryTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pCategoryTxt.TextChanged += new System.EventHandler(this.pCategoryTxt_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 91);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 18);
            this.label3.TabIndex = 28;
            this.label3.Text = "Brand Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(20, 196);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(247, 22);
            this.textBox1.TabIndex = 31;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 174);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 18);
            this.label1.TabIndex = 32;
            this.label1.Text = "Brand Category";
            // 
            // addBrand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 385);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.rAddProductBtn);
            this.Controls.Add(this.pCategoryTxt);
            this.Controls.Add(this.label3);
            this.Name = "addBrand";
            this.Text = "add brand (admin)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rAddProductBtn;
        private System.Windows.Forms.TextBox pCategoryTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}