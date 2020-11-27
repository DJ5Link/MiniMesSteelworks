
namespace MesUI
{
    partial class TransactionStock
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.rscTransactionGrid = new System.Windows.Forms.DataGridView();
            this.resourceIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.originDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeTextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wareHouseIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdsTransaction = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.rscTransactionGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTransaction)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(0, 11);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(81, 11);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 1;
            this.btnModify.Text = "수정";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // rscTransactionGrid
            // 
            this.rscTransactionGrid.AllowUserToAddRows = false;
            this.rscTransactionGrid.AllowUserToDeleteRows = false;
            this.rscTransactionGrid.AutoGenerateColumns = false;
            this.rscTransactionGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rscTransactionGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.resourceIdDataGridViewTextBoxColumn,
            this.sellerNameDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.originDataGridViewTextBoxColumn,
            this.employeeIdDataGridViewTextBoxColumn,
            this.typeTextDataGridViewTextBoxColumn,
            this.wareHouseIdDataGridViewTextBoxColumn});
            this.rscTransactionGrid.DataSource = this.bdsTransaction;
            this.rscTransactionGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.rscTransactionGrid.Location = new System.Drawing.Point(0, 0);
            this.rscTransactionGrid.Name = "rscTransactionGrid";
            this.rscTransactionGrid.ReadOnly = true;
            this.rscTransactionGrid.RowTemplate.Height = 23;
            this.rscTransactionGrid.Size = new System.Drawing.Size(941, 519);
            this.rscTransactionGrid.TabIndex = 3;
            this.rscTransactionGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.rscTransactionGrid_CellContentClick);
            // 
            // resourceIdDataGridViewTextBoxColumn
            // 
            this.resourceIdDataGridViewTextBoxColumn.DataPropertyName = "ResourceId";
            this.resourceIdDataGridViewTextBoxColumn.HeaderText = "ResourceId";
            this.resourceIdDataGridViewTextBoxColumn.Name = "resourceIdDataGridViewTextBoxColumn";
            // 
            // sellerNameDataGridViewTextBoxColumn
            // 
            this.sellerNameDataGridViewTextBoxColumn.DataPropertyName = "SellerName";
            this.sellerNameDataGridViewTextBoxColumn.HeaderText = "SellerName";
            this.sellerNameDataGridViewTextBoxColumn.Name = "sellerNameDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // originDataGridViewTextBoxColumn
            // 
            this.originDataGridViewTextBoxColumn.DataPropertyName = "Origin";
            this.originDataGridViewTextBoxColumn.HeaderText = "Origin";
            this.originDataGridViewTextBoxColumn.Name = "originDataGridViewTextBoxColumn";
            // 
            // employeeIdDataGridViewTextBoxColumn
            // 
            this.employeeIdDataGridViewTextBoxColumn.DataPropertyName = "EmployeeId";
            this.employeeIdDataGridViewTextBoxColumn.HeaderText = "EmployeeId";
            this.employeeIdDataGridViewTextBoxColumn.Name = "employeeIdDataGridViewTextBoxColumn";
            // 
            // typeTextDataGridViewTextBoxColumn
            // 
            this.typeTextDataGridViewTextBoxColumn.DataPropertyName = "TypeText";
            this.typeTextDataGridViewTextBoxColumn.HeaderText = "TypeText";
            this.typeTextDataGridViewTextBoxColumn.Name = "typeTextDataGridViewTextBoxColumn";
            this.typeTextDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // wareHouseIdDataGridViewTextBoxColumn
            // 
            this.wareHouseIdDataGridViewTextBoxColumn.DataPropertyName = "WareHouseId";
            this.wareHouseIdDataGridViewTextBoxColumn.HeaderText = "WareHouseId";
            this.wareHouseIdDataGridViewTextBoxColumn.Name = "wareHouseIdDataGridViewTextBoxColumn";
            // 
            // bdsTransaction
            // 
            this.bdsTransaction.DataSource = typeof(MiniSteelworksMES.Data.Transaction);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.btnModify);
            this.groupBox1.Location = new System.Drawing.Point(734, 520);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(162, 40);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // TransactionStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 594);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rscTransactionGrid);
            this.Name = "TransactionStock";
            this.Text = "원자재 재고 입출고 조회";
            this.Load += new System.EventHandler(this.TransactionStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rscTransactionGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTransaction)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.DataGridView rscTransactionGrid;
        private System.Windows.Forms.BindingSource bdsTransaction;
        private System.Windows.Forms.DataGridViewTextBoxColumn resourceIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn originDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeTextDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wareHouseIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}