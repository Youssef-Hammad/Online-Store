namespace OnlineStore
{
    partial class login
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
            this.lLoginBtn = new System.Windows.Forms.Button();
            this.lRegisterBtn = new System.Windows.Forms.LinkLabel();
            this.lUsrnameTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lPwdTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lLoginBtn
            // 
            this.lLoginBtn.BackColor = System.Drawing.Color.LightCoral;
            this.lLoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lLoginBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lLoginBtn.Location = new System.Drawing.Point(13, 154);
            this.lLoginBtn.Margin = new System.Windows.Forms.Padding(4);
            this.lLoginBtn.Name = "lLoginBtn";
            this.lLoginBtn.Size = new System.Drawing.Size(391, 31);
            this.lLoginBtn.TabIndex = 0;
            this.lLoginBtn.Text = "login";
            this.lLoginBtn.UseVisualStyleBackColor = false;
            this.lLoginBtn.Click += new System.EventHandler(this.lLoginBtn_Click);
            // 
            // lRegisterBtn
            // 
            this.lRegisterBtn.ActiveLinkColor = System.Drawing.Color.LightCoral;
            this.lRegisterBtn.AutoSize = true;
            this.lRegisterBtn.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lRegisterBtn.LinkColor = System.Drawing.Color.Salmon;
            this.lRegisterBtn.Location = new System.Drawing.Point(173, 188);
            this.lRegisterBtn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lRegisterBtn.Name = "lRegisterBtn";
            this.lRegisterBtn.Size = new System.Drawing.Size(73, 17);
            this.lRegisterBtn.TabIndex = 1;
            this.lRegisterBtn.TabStop = true;
            this.lRegisterBtn.Text = "or register";
            this.lRegisterBtn.VisitedLinkColor = System.Drawing.Color.Salmon;
            this.lRegisterBtn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.registerBtn_LinkClicked);
            // 
            // lUsrnameTxt
            // 
            this.lUsrnameTxt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lUsrnameTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lUsrnameTxt.Location = new System.Drawing.Point(16, 37);
            this.lUsrnameTxt.Margin = new System.Windows.Forms.Padding(4);
            this.lUsrnameTxt.Name = "lUsrnameTxt";
            this.lUsrnameTxt.Size = new System.Drawing.Size(390, 22);
            this.lUsrnameTxt.TabIndex = 2;
            this.lUsrnameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lUsrnameTxt.TextChanged += new System.EventHandler(this.lUsrnameTxt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "username/email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(164, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "password";
            // 
            // lPwdTxt
            // 
            this.lPwdTxt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lPwdTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lPwdTxt.Location = new System.Drawing.Point(16, 110);
            this.lPwdTxt.Margin = new System.Windows.Forms.Padding(4);
            this.lPwdTxt.Name = "lPwdTxt";
            this.lPwdTxt.PasswordChar = '*';
            this.lPwdTxt.Size = new System.Drawing.Size(390, 22);
            this.lPwdTxt.TabIndex = 4;
            this.lPwdTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(423, 218);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lPwdTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lUsrnameTxt);
            this.Controls.Add(this.lRegisterBtn);
            this.Controls.Add(this.lLoginBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "login";
            this.Opacity = 0.9D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button lLoginBtn;
        private System.Windows.Forms.LinkLabel lRegisterBtn;
        private System.Windows.Forms.TextBox lUsrnameTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lPwdTxt;
    }
}

