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
            this.pNameTxt = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rAddProductBtn
            // 
            this.rAddProductBtn.BackColor = System.Drawing.Color.LightCoral;
            this.rAddProductBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rAddProductBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.rAddProductBtn.Location = new System.Drawing.Point(13, 328);
            this.rAddProductBtn.Margin = new System.Windows.Forms.Padding(4);
            this.rAddProductBtn.Name = "rAddProductBtn";
            this.rAddProductBtn.Size = new System.Drawing.Size(248, 31);
            this.rAddProductBtn.TabIndex = 28;
            this.rAddProductBtn.Text = "add brand";
            this.rAddProductBtn.UseVisualStyleBackColor = false;
            this.rAddProductBtn.Click += new System.EventHandler(this.rAddProductBtn_Click);
            // 
            // pNameTxt
            // 
            this.pNameTxt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pNameTxt.Location = new System.Drawing.Point(17, 218);
            this.pNameTxt.Margin = new System.Windows.Forms.Padding(4);
            this.pNameTxt.Name = "pNameTxt";
            this.pNameTxt.Size = new System.Drawing.Size(247, 22);
            this.pNameTxt.TabIndex = 29;
            this.pNameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pNameTxt.TextChanged += new System.EventHandler(this.pNameTxt_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(17, 114);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(247, 22);
            this.textBox1.TabIndex = 30;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 196);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 18);
            this.label1.TabIndex = 31;
            this.label1.Text = "Brand Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 18);
            this.label2.TabIndex = 32;
            this.label2.Text = "Brand Name";
            // 
            // addBrand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(281, 385);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pNameTxt);
            this.Controls.Add(this.rAddProductBtn);
            this.Name = "addBrand";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Brand (Admin)";
            this.Load += new System.EventHandler(this.addBrand_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button rAddProductBtn;
        private System.Windows.Forms.TextBox pNameTxt;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}