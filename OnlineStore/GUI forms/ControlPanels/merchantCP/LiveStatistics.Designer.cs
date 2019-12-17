namespace OnlineStore
{
    partial class LiveStatistics
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
            this.NumberOfViewsLabel = new System.Windows.Forms.Label();
            this.NumberOfPurchasesLabel = new System.Windows.Forms.Label();
            this.SoldoutLabel = new System.Windows.Forms.Label();
            this.showViewsCheckBox = new System.Windows.Forms.CheckBox();
            this.showPurchasesCheckBox = new System.Windows.Forms.CheckBox();
            this.ShowStatisticsBtn = new System.Windows.Forms.Button();
            this.SoldOutListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // NumberOfViewsLabel
            // 
            this.NumberOfViewsLabel.AutoSize = true;
            this.NumberOfViewsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberOfViewsLabel.Location = new System.Drawing.Point(26, 36);
            this.NumberOfViewsLabel.Name = "NumberOfViewsLabel";
            this.NumberOfViewsLabel.Size = new System.Drawing.Size(205, 29);
            this.NumberOfViewsLabel.TabIndex = 0;
            this.NumberOfViewsLabel.Text = "Number of views: ";
            this.NumberOfViewsLabel.Click += new System.EventHandler(this.NumberOfViewsLabel_Click);
            // 
            // NumberOfPurchasesLabel
            // 
            this.NumberOfPurchasesLabel.AutoSize = true;
            this.NumberOfPurchasesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberOfPurchasesLabel.Location = new System.Drawing.Point(26, 93);
            this.NumberOfPurchasesLabel.Name = "NumberOfPurchasesLabel";
            this.NumberOfPurchasesLabel.Size = new System.Drawing.Size(257, 29);
            this.NumberOfPurchasesLabel.TabIndex = 1;
            this.NumberOfPurchasesLabel.Text = "Number of Purchases: ";
            // 
            // SoldoutLabel
            // 
            this.SoldoutLabel.AutoSize = true;
            this.SoldoutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoldoutLabel.Location = new System.Drawing.Point(26, 162);
            this.SoldoutLabel.Name = "SoldoutLabel";
            this.SoldoutLabel.Size = new System.Drawing.Size(203, 29);
            this.SoldoutLabel.TabIndex = 3;
            this.SoldoutLabel.Text = "Soldout Products:";
            // 
            // showViewsCheckBox
            // 
            this.showViewsCheckBox.AutoSize = true;
            this.showViewsCheckBox.Checked = true;
            this.showViewsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showViewsCheckBox.Location = new System.Drawing.Point(405, 44);
            this.showViewsCheckBox.Name = "showViewsCheckBox";
            this.showViewsCheckBox.Size = new System.Drawing.Size(104, 21);
            this.showViewsCheckBox.TabIndex = 4;
            this.showViewsCheckBox.Text = "Show Views";
            this.showViewsCheckBox.UseVisualStyleBackColor = true;
            this.showViewsCheckBox.CheckedChanged += new System.EventHandler(this.showViewsCheckBox_CheckedChanged);
            // 
            // showPurchasesCheckBox
            // 
            this.showPurchasesCheckBox.AutoSize = true;
            this.showPurchasesCheckBox.Checked = true;
            this.showPurchasesCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showPurchasesCheckBox.Location = new System.Drawing.Point(405, 71);
            this.showPurchasesCheckBox.Name = "showPurchasesCheckBox";
            this.showPurchasesCheckBox.Size = new System.Drawing.Size(135, 21);
            this.showPurchasesCheckBox.TabIndex = 5;
            this.showPurchasesCheckBox.Text = "Show Purchases";
            this.showPurchasesCheckBox.UseVisualStyleBackColor = true;
            this.showPurchasesCheckBox.CheckedChanged += new System.EventHandler(this.showPurchasesCheckBox_CheckedChanged);
            // 
            // ShowStatisticsBtn
            // 
            this.ShowStatisticsBtn.BackColor = System.Drawing.Color.LightCoral;
            this.ShowStatisticsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowStatisticsBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ShowStatisticsBtn.Location = new System.Drawing.Point(554, 156);
            this.ShowStatisticsBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ShowStatisticsBtn.Name = "ShowStatisticsBtn";
            this.ShowStatisticsBtn.Size = new System.Drawing.Size(248, 31);
            this.ShowStatisticsBtn.TabIndex = 29;
            this.ShowStatisticsBtn.Text = "Show";
            this.ShowStatisticsBtn.UseVisualStyleBackColor = false;
            this.ShowStatisticsBtn.Click += new System.EventHandler(this.ShowStatisticsBtn_Click);
            // 
            // SoldOutListView
            // 
            this.SoldOutListView.HideSelection = false;
            this.SoldOutListView.Location = new System.Drawing.Point(31, 194);
            this.SoldOutListView.Name = "SoldOutListView";
            this.SoldOutListView.Size = new System.Drawing.Size(771, 367);
            this.SoldOutListView.TabIndex = 30;
            this.SoldOutListView.UseCompatibleStateImageBehavior = false;
            this.SoldOutListView.SelectedIndexChanged += new System.EventHandler(this.SoldOutListView_SelectedIndexChanged);
            // 
            // LiveStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 587);
            this.Controls.Add(this.SoldOutListView);
            this.Controls.Add(this.ShowStatisticsBtn);
            this.Controls.Add(this.showPurchasesCheckBox);
            this.Controls.Add(this.showViewsCheckBox);
            this.Controls.Add(this.SoldoutLabel);
            this.Controls.Add(this.NumberOfPurchasesLabel);
            this.Controls.Add(this.NumberOfViewsLabel);
            this.Name = "LiveStatistics";
            this.Text = "Live Statistics";
            this.Load += new System.EventHandler(this.LiveStatistics_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NumberOfViewsLabel;
        private System.Windows.Forms.Label NumberOfPurchasesLabel;
        private System.Windows.Forms.Label SoldoutLabel;
        private System.Windows.Forms.CheckBox showViewsCheckBox;
        private System.Windows.Forms.CheckBox showPurchasesCheckBox;
        private System.Windows.Forms.Button ShowStatisticsBtn;
        private System.Windows.Forms.ListView SoldOutListView;
    }
}