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
            this.sTORENAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oWNERNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTORELOCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTYPEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pENDINGSTORESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.onlineStoreDataSet = new OnlineStore.OnlineStoreDataSet();
            this.pENDINGSTORESTableAdapter = new OnlineStore.OnlineStoreDataSetTableAdapters.PENDINGSTORESTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pENDINGSTORESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onlineStoreDataSet)).BeginInit();
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
            this.sTORENAMEDataGridViewTextBoxColumn,
            this.oWNERNAMEDataGridViewTextBoxColumn,
            this.sTORELOCDataGridViewTextBoxColumn,
            this.sTYPEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pENDINGSTORESBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(443, 450);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // sTORENAMEDataGridViewTextBoxColumn
            // 
            this.sTORENAMEDataGridViewTextBoxColumn.DataPropertyName = "STORENAME";
            this.sTORENAMEDataGridViewTextBoxColumn.HeaderText = "STORENAME";
            this.sTORENAMEDataGridViewTextBoxColumn.Name = "sTORENAMEDataGridViewTextBoxColumn";
            // 
            // oWNERNAMEDataGridViewTextBoxColumn
            // 
            this.oWNERNAMEDataGridViewTextBoxColumn.DataPropertyName = "OWNERNAME";
            this.oWNERNAMEDataGridViewTextBoxColumn.HeaderText = "OWNERNAME";
            this.oWNERNAMEDataGridViewTextBoxColumn.Name = "oWNERNAMEDataGridViewTextBoxColumn";
            // 
            // sTORELOCDataGridViewTextBoxColumn
            // 
            this.sTORELOCDataGridViewTextBoxColumn.DataPropertyName = "STORELOC";
            this.sTORELOCDataGridViewTextBoxColumn.HeaderText = "STORELOC";
            this.sTORELOCDataGridViewTextBoxColumn.Name = "sTORELOCDataGridViewTextBoxColumn";
            // 
            // sTYPEDataGridViewTextBoxColumn
            // 
            this.sTYPEDataGridViewTextBoxColumn.DataPropertyName = "STYPE";
            this.sTYPEDataGridViewTextBoxColumn.HeaderText = "STYPE";
            this.sTYPEDataGridViewTextBoxColumn.Name = "sTYPEDataGridViewTextBoxColumn";
            // 
            // pENDINGSTORESBindingSource
            // 
            this.pENDINGSTORESBindingSource.DataMember = "PENDINGSTORES";
            this.pENDINGSTORESBindingSource.DataSource = this.onlineStoreDataSet;
            // 
            // onlineStoreDataSet
            // 
            this.onlineStoreDataSet.DataSetName = "OnlineStoreDataSet";
            this.onlineStoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pENDINGSTORESTableAdapter
            // 
            this.pENDINGSTORESTableAdapter.ClearBeforeFill = true;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private OnlineStoreDataSet onlineStoreDataSet;
        private System.Windows.Forms.BindingSource pENDINGSTORESBindingSource;
        private OnlineStoreDataSetTableAdapters.PENDINGSTORESTableAdapter pENDINGSTORESTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTORENAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oWNERNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTORELOCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTYPEDataGridViewTextBoxColumn;
    }
}