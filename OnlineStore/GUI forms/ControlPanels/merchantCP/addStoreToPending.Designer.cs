namespace OnlineStore
{
    partial class addStoreToPending
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
            this.sNameTxt = new System.Windows.Forms.TextBox();
            this.storeNameLabel = new System.Windows.Forms.Label();
            this.storeLocationLabel = new System.Windows.Forms.Label();
            this.sLocationTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.storeTypesMenu = new System.Windows.Forms.ComboBox();
            this.rAddStoreBtn = new System.Windows.Forms.Button();
            this.storeErrorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sNameTxt
            // 
            this.sNameTxt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sNameTxt.Location = new System.Drawing.Point(13, 54);
            this.sNameTxt.Margin = new System.Windows.Forms.Padding(4);
            this.sNameTxt.Name = "sNameTxt";
            this.sNameTxt.Size = new System.Drawing.Size(247, 22);
            this.sNameTxt.TabIndex = 17;
            this.sNameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sNameTxt.TextChanged += new System.EventHandler(this.sNameTxt_TextChanged);
            // 
            // storeNameLabel
            // 
            this.storeNameLabel.AutoSize = true;
            this.storeNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeNameLabel.Location = new System.Drawing.Point(13, 32);
            this.storeNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.storeNameLabel.Name = "storeNameLabel";
            this.storeNameLabel.Size = new System.Drawing.Size(88, 18);
            this.storeNameLabel.TabIndex = 18;
            this.storeNameLabel.Text = "Store Name";
            // 
            // storeLocationLabel
            // 
            this.storeLocationLabel.AutoSize = true;
            this.storeLocationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeLocationLabel.Location = new System.Drawing.Point(13, 108);
            this.storeLocationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.storeLocationLabel.Name = "storeLocationLabel";
            this.storeLocationLabel.Size = new System.Drawing.Size(102, 18);
            this.storeLocationLabel.TabIndex = 19;
            this.storeLocationLabel.Text = "Store Locaton";
            this.storeLocationLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // sLocationTxt
            // 
            this.sLocationTxt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sLocationTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sLocationTxt.Location = new System.Drawing.Point(13, 128);
            this.sLocationTxt.Margin = new System.Windows.Forms.Padding(4);
            this.sLocationTxt.Name = "sLocationTxt";
            this.sLocationTxt.Size = new System.Drawing.Size(247, 22);
            this.sLocationTxt.TabIndex = 20;
            this.sLocationTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sLocationTxt.TextChanged += new System.EventHandler(this.sLocationTxt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 181);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 21;
            this.label2.Text = "Store Type";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // storeTypesMenu
            // 
            this.storeTypesMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.storeTypesMenu.FormattingEnabled = true;
            this.storeTypesMenu.Items.AddRange(new object[] {
            "Clothes",
            "Entertainment",
            "Sports",
            "Technology"});
            this.storeTypesMenu.Location = new System.Drawing.Point(13, 204);
            this.storeTypesMenu.Name = "storeTypesMenu";
            this.storeTypesMenu.Size = new System.Drawing.Size(247, 24);
            this.storeTypesMenu.TabIndex = 22;
            this.storeTypesMenu.SelectedIndexChanged += new System.EventHandler(this.storeTypesMenu_SelectedIndexChanged);
            // 
            // rAddStoreBtn
            // 
            this.rAddStoreBtn.BackColor = System.Drawing.Color.LightCoral;
            this.rAddStoreBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rAddStoreBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.rAddStoreBtn.Location = new System.Drawing.Point(12, 304);
            this.rAddStoreBtn.Margin = new System.Windows.Forms.Padding(4);
            this.rAddStoreBtn.Name = "rAddStoreBtn";
            this.rAddStoreBtn.Size = new System.Drawing.Size(248, 31);
            this.rAddStoreBtn.TabIndex = 28;
            this.rAddStoreBtn.Text = "Add Store";
            this.rAddStoreBtn.UseVisualStyleBackColor = false;
            this.rAddStoreBtn.Click += new System.EventHandler(this.rAddStoreBtn_Click);
            // 
            // storeErrorLabel
            // 
            this.storeErrorLabel.AutoSize = true;
            this.storeErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.storeErrorLabel.Location = new System.Drawing.Point(46, 283);
            this.storeErrorLabel.Name = "storeErrorLabel";
            this.storeErrorLabel.Size = new System.Drawing.Size(182, 17);
            this.storeErrorLabel.TabIndex = 29;
            this.storeErrorLabel.Text = "Store Name can\'t be empty!";
            this.storeErrorLabel.Click += new System.EventHandler(this.storeNameEmpty_Click_1);
            // 
            // addStoreToPending
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 366);
            this.Controls.Add(this.storeErrorLabel);
            this.Controls.Add(this.rAddStoreBtn);
            this.Controls.Add(this.storeTypesMenu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sLocationTxt);
            this.Controls.Add(this.storeLocationLabel);
            this.Controls.Add(this.storeNameLabel);
            this.Controls.Add(this.sNameTxt);
            this.Name = "addStoreToPending";
            this.Text = "Add Store";
            this.Load += new System.EventHandler(this.addStoreToPending_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sNameTxt;
        private System.Windows.Forms.Label storeNameLabel;
        private System.Windows.Forms.Label storeLocationLabel;
        private System.Windows.Forms.TextBox sLocationTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox storeTypesMenu;
        private System.Windows.Forms.Button rAddStoreBtn;
        private System.Windows.Forms.Label storeErrorLabel;
    }
}