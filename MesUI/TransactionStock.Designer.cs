
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
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.rscTransactionGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTransaction)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(536, 14);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(617, 14);
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
            this.rscTransactionGrid.Size = new System.Drawing.Size(941, 514);
            this.rscTransactionGrid.TabIndex = 3;
            this.rscTransactionGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.rscTransactionGrid_CellContentClick);
            // 
            // resourceIdDataGridViewTextBoxColumn
            // 
            this.resourceIdDataGridViewTextBoxColumn.DataPropertyName = "ResourceId";
            this.resourceIdDataGridViewTextBoxColumn.HeaderText = "원자재 ID";
            this.resourceIdDataGridViewTextBoxColumn.Name = "resourceIdDataGridViewTextBoxColumn";
            this.resourceIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sellerNameDataGridViewTextBoxColumn
            // 
            this.sellerNameDataGridViewTextBoxColumn.DataPropertyName = "SellerName";
            this.sellerNameDataGridViewTextBoxColumn.HeaderText = "수입처";
            this.sellerNameDataGridViewTextBoxColumn.Name = "sellerNameDataGridViewTextBoxColumn";
            this.sellerNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "시각";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // originDataGridViewTextBoxColumn
            // 
            this.originDataGridViewTextBoxColumn.DataPropertyName = "Origin";
            this.originDataGridViewTextBoxColumn.HeaderText = "원산지";
            this.originDataGridViewTextBoxColumn.Name = "originDataGridViewTextBoxColumn";
            this.originDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeIdDataGridViewTextBoxColumn
            // 
            this.employeeIdDataGridViewTextBoxColumn.DataPropertyName = "EmployeeId";
            this.employeeIdDataGridViewTextBoxColumn.HeaderText = "담당자 ID";
            this.employeeIdDataGridViewTextBoxColumn.Name = "employeeIdDataGridViewTextBoxColumn";
            this.employeeIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeTextDataGridViewTextBoxColumn
            // 
            this.typeTextDataGridViewTextBoxColumn.DataPropertyName = "TypeText";
            this.typeTextDataGridViewTextBoxColumn.HeaderText = "입출고 구분";
            this.typeTextDataGridViewTextBoxColumn.Name = "typeTextDataGridViewTextBoxColumn";
            this.typeTextDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // wareHouseIdDataGridViewTextBoxColumn
            // 
            this.wareHouseIdDataGridViewTextBoxColumn.DataPropertyName = "WareHouseId";
            this.wareHouseIdDataGridViewTextBoxColumn.HeaderText = "창고 번호";
            this.wareHouseIdDataGridViewTextBoxColumn.Name = "wareHouseIdDataGridViewTextBoxColumn";
            this.wareHouseIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bdsTransaction
            // 
            this.bdsTransaction.DataSource = typeof(MiniSteelworksMES.Data.Transaction);
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Location = new System.Drawing.Point(64, 14);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(200, 21);
            this.dateTimePickerStart.TabIndex = 5;
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Location = new System.Drawing.Point(329, 14);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(200, 21);
            this.dateTimePickerEnd.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "시작날짜";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "종료날짜";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.dateTimePickerStart);
            this.groupBox2.Controls.Add(this.btnModify);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dateTimePickerEnd);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(243, 514);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(698, 80);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // TransactionStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 594);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.rscTransactionGrid);
            this.Name = "TransactionStock";
            this.Text = "원자재 재고 입출고 조회";
            this.Load += new System.EventHandler(this.TransactionStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rscTransactionGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTransaction)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}