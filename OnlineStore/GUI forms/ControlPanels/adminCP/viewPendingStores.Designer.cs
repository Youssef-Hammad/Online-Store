namespace OnlineStore
{
    partial class viewPendindStores
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pENDINGSTORESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.onlineStoreDataSet = new OnlineStore.OnlineStoreDataSet();
            this.pENDINGSTORESBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pENDINGSTORESTableAdapter = new OnlineStore.OnlineStoreDataSetTableAdapters.PENDINGSTORESTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pENDINGSTORESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onlineStoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pENDINGSTORESBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridView1.DataSource = this.pENDINGSTORESBindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(443, 450);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // pENDINGSTORESBindingSource
            // 
            this.pENDINGSTORESBindingSource.DataMember = "PENDINGSTORES";
            // 
            // onlineStoreDataSet
            // 
            this.onlineStoreDataSet.DataSetName = "OnlineStoreDataSet";
            this.onlineStoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pENDINGSTORESBindingSource1
            // 
            this.pENDINGSTORESBindingSource1.DataMember = "PENDINGSTORES";
            this.pENDINGSTORESBindingSource1.DataSource = this.onlineStoreDataSet;
            // 
            // pENDINGSTORESTableAdapter
            // 
            this.pENDINGSTORESTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "STORENAME";
            this.dataGridViewTextBoxColumn1.HeaderText = "STORENAME";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "OWNERNAME";
            this.dataGridViewTextBoxColumn2.HeaderText = "OWNERNAME";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "STORELOC";
            this.dataGridViewTextBoxColumn3.HeaderText = "STORELOC";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "STYPE";
            this.dataGridViewTextBoxColumn4.HeaderText = "STYPE";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // viewPendindStores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "viewPendindStores";
            this.Text = "viewPendindStores";
            this.Load += new System.EventHandler(this.viewPendindStores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pENDINGSTORESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onlineStoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pENDINGSTORESBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        //private OnlineStoreDataSet onlineStoreDataSet;
        private System.Windows.Forms.BindingSource pENDINGSTORESBindingSource;
        //private OnlineStoreDataSetTableAdapters.PENDINGSTORESTableAdapter pENDINGSTORESTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTORENAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oWNERNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTORELOCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTYPEDataGridViewTextBoxColumn;
        private OnlineStoreDataSet onlineStoreDataSet;
        private System.Windows.Forms.BindingSource pENDINGSTORESBindingSource1;
        private OnlineStoreDataSetTableAdapters.PENDINGSTORESTableAdapter pENDINGSTORESTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}