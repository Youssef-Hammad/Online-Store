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
            this.rRegisterBtn = new System.Windows.Forms.Button();
            this.pCategoryTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pPriceTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pNameTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rRegisterBtn
            // 
            this.rRegisterBtn.BackColor = System.Drawing.Color.LightCoral;
            this.rRegisterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rRegisterBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.rRegisterBtn.Location = new System.Drawing.Point(16, 303);
            this.rRegisterBtn.Margin = new System.Windows.Forms.Padding(4);
            this.rRegisterBtn.Name = "rRegisterBtn";
            this.rRegisterBtn.Size = new System.Drawing.Size(248, 31);
            this.rRegisterBtn.TabIndex = 27;
            this.rRegisterBtn.Text = "add product";
            this.rRegisterBtn.UseVisualStyleBackColor = false;
            this.rRegisterBtn.Click += new System.EventHandler(this.rRegisterBtn_Click);
            // 
            // pCategoryTxt
            // 
            this.pCategoryTxt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pCategoryTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pCategoryTxt.Location = new System.Drawing.Point(16, 211);
            this.pCategoryTxt.Margin = new System.Windows.Forms.Padding(4);
            this.pCategoryTxt.Name = "pCategoryTxt";
            this.pCategoryTxt.Size = new System.Drawing.Size(247, 22);
            this.pCategoryTxt.TabIndex = 20;
            this.pCategoryTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pCategoryTxt.TextChanged += new System.EventHandler(this.pCategoryTxt_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 189);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 18);
            this.label3.TabIndex = 19;
            this.label3.Text = "Product Category";
            // 
            // pPriceTxt
            // 
            this.pPriceTxt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pPriceTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pPriceTxt.Location = new System.Drawing.Point(16, 128);
            this.pPriceTxt.Margin = new System.Windows.Forms.Padding(4);
            this.pPriceTxt.Name = "pPriceTxt";
            this.pPriceTxt.Size = new System.Drawing.Size(247, 22);
            this.pPriceTxt.TabIndex = 18;
            this.pPriceTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "Product price";
            // 
            // pNameTxt
            // 
            this.pNameTxt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pNameTxt.Location = new System.Drawing.Point(16, 53);
            this.pNameTxt.Margin = new System.Windows.Forms.Padding(4);
            this.pNameTxt.Name = "pNameTxt";
            this.pNameTxt.Size = new System.Drawing.Size(247, 22);
            this.pNameTxt.TabIndex = 16;
            this.pNameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Product name";
            // 
            // addProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(281, 359);
            this.Controls.Add(this.rRegisterBtn);
            this.Controls.Add(this.pCategoryTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pPriceTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pNameTxt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
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

        private System.Windows.Forms.Button rRegisterBtn;
        private System.Windows.Forms.TextBox pCategoryTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pPriceTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pNameTxt;
        private System.Windows.Forms.Label label1;
    }
}