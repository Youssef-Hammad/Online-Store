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
            this.label1 = new System.Windows.Forms.Label();
            this.MrB = new System.Windows.Forms.RadioButton();
            this.CrB = new System.Windows.Forms.RadioButton();
            this.errMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rUsrnameTxt
            // 
            this.rUsrnameTxt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rUsrnameTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rUsrnameTxt.Location = new System.Drawing.Point(32, 37);
            this.rUsrnameTxt.Name = "rUsrnameTxt";
            this.rUsrnameTxt.Size = new System.Drawing.Size(186, 20);
            this.rUsrnameTxt.TabIndex = 7;
            this.rUsrnameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.rUsrnameTxt.TextChanged += new System.EventHandler(this.rUsrnameTxt_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Desired username";
            // 
            // rEmailTxt
            // 
            this.rEmailTxt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rEmailTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rEmailTxt.Location = new System.Drawing.Point(32, 94);
            this.rEmailTxt.Name = "rEmailTxt";
            this.rEmailTxt.Size = new System.Drawing.Size(186, 20);
            this.rEmailTxt.TabIndex = 9;
            this.rEmailTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.rEmailTxt.TextChanged += new System.EventHandler(this.rEmailTxt_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "E-mail";
            // 
            // rPwdTxt
            // 
            this.rPwdTxt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rPwdTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rPwdTxt.Location = new System.Drawing.Point(32, 154);
            this.rPwdTxt.Name = "rPwdTxt";
            this.rPwdTxt.PasswordChar = '*';
            this.rPwdTxt.Size = new System.Drawing.Size(186, 20);
            this.rPwdTxt.TabIndex = 11;
            this.rPwdTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.rPwdTxt.TextChanged += new System.EventHandler(this.rPwdTxt_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Password";
            // 
            // rVerifyPwdTxt
            // 
            this.rVerifyPwdTxt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rVerifyPwdTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rVerifyPwdTxt.Location = new System.Drawing.Point(32, 216);
            this.rVerifyPwdTxt.Name = "rVerifyPwdTxt";
            this.rVerifyPwdTxt.PasswordChar = '*';
            this.rVerifyPwdTxt.Size = new System.Drawing.Size(186, 20);
            this.rVerifyPwdTxt.TabIndex = 13;
            this.rVerifyPwdTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.rVerifyPwdTxt.TextChanged += new System.EventHandler(this.rVerifyPwdTxt_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Verify password";
            // 
            // rRegisterBtn
            // 
            this.rRegisterBtn.BackColor = System.Drawing.Color.LightCoral;
            this.rRegisterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rRegisterBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.rRegisterBtn.Location = new System.Drawing.Point(32, 334);
            this.rRegisterBtn.Name = "rRegisterBtn";
            this.rRegisterBtn.Size = new System.Drawing.Size(186, 25);
            this.rRegisterBtn.TabIndex = 14;
            this.rRegisterBtn.Text = "register";
            this.rRegisterBtn.UseVisualStyleBackColor = false;
            this.rRegisterBtn.Click += new System.EventHandler(this.rRegisterBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Account Type";
            // 
            // MrB
            // 
            this.MrB.AutoSize = true;
            this.MrB.Location = new System.Drawing.Point(32, 278);
            this.MrB.Name = "MrB";
            this.MrB.Size = new System.Drawing.Size(70, 17);
            this.MrB.TabIndex = 18;
            this.MrB.TabStop = true;
            this.MrB.Text = "Merchant";
            this.MrB.UseVisualStyleBackColor = true;
            // 
            // CrB
            // 
            this.CrB.AutoSize = true;
            this.CrB.Location = new System.Drawing.Point(148, 278);
            this.CrB.Name = "CrB";
            this.CrB.Size = new System.Drawing.Size(72, 17);
            this.CrB.TabIndex = 19;
            this.CrB.TabStop = true;
            this.CrB.Text = "Consumer";
            this.CrB.UseVisualStyleBackColor = true;
            // 
            // errMsg
            // 
            this.errMsg.AutoSize = true;
            this.errMsg.ForeColor = System.Drawing.Color.DarkRed;
            this.errMsg.Location = new System.Drawing.Point(51, 318);
            this.errMsg.Name = "errMsg";
            this.errMsg.Size = new System.Drawing.Size(0, 13);
            this.errMsg.TabIndex = 20;
            // 
            // registerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(260, 370);
            this.Controls.Add(this.errMsg);
            this.Controls.Add(this.CrB);
            this.Controls.Add(this.MrB);
            this.Controls.Add(this.label1);
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
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "registerForm";
            this.Opacity = 0.9D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "register";
            this.Load += new System.EventHandler(this.registerForm_Load);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton MrB;
        private System.Windows.Forms.RadioButton CrB;
        private System.Windows.Forms.Label errMsg;
    }
}