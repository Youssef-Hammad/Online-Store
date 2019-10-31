namespace OnlineStore
{
    partial class registerForm
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
            this.rUsrnameTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rEmailTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rPwdTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rVerifyPwdTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rRegisterBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rUsrnameTxt
            // 
            this.rUsrnameTxt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rUsrnameTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rUsrnameTxt.Location = new System.Drawing.Point(43, 45);
            this.rUsrnameTxt.Margin = new System.Windows.Forms.Padding(4);
            this.rUsrnameTxt.Name = "rUsrnameTxt";
            this.rUsrnameTxt.Size = new System.Drawing.Size(247, 22);
            this.rUsrnameTxt.TabIndex = 7;
            this.rUsrnameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.rUsrnameTxt.TextChanged += new System.EventHandler(this.rUsrnameTxt_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Desired username";
            // 
            // rEmailTxt
            // 
            this.rEmailTxt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rEmailTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rEmailTxt.Location = new System.Drawing.Point(43, 116);
            this.rEmailTxt.Margin = new System.Windows.Forms.Padding(4);
            this.rEmailTxt.Name = "rEmailTxt";
            this.rEmailTxt.Size = new System.Drawing.Size(247, 22);
            this.rEmailTxt.TabIndex = 9;
            this.rEmailTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.rEmailTxt.TextChanged += new System.EventHandler(this.rEmailTxt_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 94);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "E-mail";
            // 
            // rPwdTxt
            // 
            this.rPwdTxt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rPwdTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rPwdTxt.Location = new System.Drawing.Point(42, 189);
            this.rPwdTxt.Margin = new System.Windows.Forms.Padding(4);
            this.rPwdTxt.Name = "rPwdTxt";
            this.rPwdTxt.PasswordChar = '*';
            this.rPwdTxt.Size = new System.Drawing.Size(247, 22);
            this.rPwdTxt.TabIndex = 11;
            this.rPwdTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.rPwdTxt.TextChanged += new System.EventHandler(this.rPwdTxt_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 167);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Password";
            // 
            // rVerifyPwdTxt
            // 
            this.rVerifyPwdTxt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rVerifyPwdTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rVerifyPwdTxt.Location = new System.Drawing.Point(42, 266);
            this.rVerifyPwdTxt.Margin = new System.Windows.Forms.Padding(4);
            this.rVerifyPwdTxt.Name = "rVerifyPwdTxt";
            this.rVerifyPwdTxt.PasswordChar = '*';
            this.rVerifyPwdTxt.Size = new System.Drawing.Size(247, 22);
            this.rVerifyPwdTxt.TabIndex = 13;
            this.rVerifyPwdTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.rVerifyPwdTxt.TextChanged += new System.EventHandler(this.rVerifyPwdTxt_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(47, 244);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Verify password";
            // 
            // rRegisterBtn
            // 
            this.rRegisterBtn.BackColor = System.Drawing.Color.LightCoral;
            this.rRegisterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rRegisterBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.rRegisterBtn.Location = new System.Drawing.Point(43, 377);
            this.rRegisterBtn.Margin = new System.Windows.Forms.Padding(4);
            this.rRegisterBtn.Name = "rRegisterBtn";
            this.rRegisterBtn.Size = new System.Drawing.Size(248, 31);
            this.rRegisterBtn.TabIndex = 14;
            this.rRegisterBtn.Text = "register";
            this.rRegisterBtn.UseVisualStyleBackColor = false;
            this.rRegisterBtn.Click += new System.EventHandler(this.rRegisterBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox1.Location = new System.Drawing.Point(42, 337);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(247, 22);
            this.textBox1.TabIndex = 15;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // registerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(347, 422);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.rRegisterBtn);
            this.Controls.Add(this.rVerifyPwdTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rPwdTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rEmailTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rUsrnameTxt);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "registerForm";
            this.Opacity = 0.9D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox rUsrnameTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox rEmailTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox rPwdTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox rVerifyPwdTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button rRegisterBtn;
        private System.Windows.Forms.TextBox textBox1;
    }
}