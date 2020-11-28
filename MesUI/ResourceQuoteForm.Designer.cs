
namespace MesUI
{
    partial class ResourceQuoteForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.PeriodSerch = new System.Windows.Forms.Button();
            this.uiDt_EndTime = new System.Windows.Forms.DateTimePicker();
            this.uiDt_StartTime = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Reset = new System.Windows.Forms.Button();
            this.resourceQuoteFormBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nikelQuoteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aluminumQuoteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ironOreQuoteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.copperQuoteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resourceQuoteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transactionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.transactionBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourceQuoteFormBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourceQuoteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // PeriodSerch
            // 
            this.PeriodSerch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PeriodSerch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PeriodSerch.Location = new System.Drawing.Point(570, 121);
            this.PeriodSerch.Name = "PeriodSerch";
            this.PeriodSerch.Size = new System.Drawing.Size(82, 32);
            this.PeriodSerch.TabIndex = 15;
            this.PeriodSerch.Text = "조회";
            this.PeriodSerch.UseVisualStyleBackColor = true;
            this.PeriodSerch.Click += new System.EventHandler(this.PeriodSearch_Click);
            // 
            // uiDt_EndTime
            // 
            this.uiDt_EndTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiDt_EndTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiDt_EndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.uiDt_EndTime.Location = new System.Drawing.Point(562, 94);
            this.uiDt_EndTime.Name = "uiDt_EndTime";
            this.uiDt_EndTime.Size = new System.Drawing.Size(98, 21);
            this.uiDt_EndTime.TabIndex = 14;
            this.uiDt_EndTime.Value = new System.DateTime(2020, 11, 28, 21, 14, 20, 0);
            // 
            // uiDt_StartTime
            // 
            this.uiDt_StartTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiDt_StartTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiDt_StartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.uiDt_StartTime.Location = new System.Drawing.Point(562, 41);
            this.uiDt_StartTime.Name = "uiDt_StartTime";
            this.uiDt_StartTime.Size = new System.Drawing.Size(98, 21);
            this.uiDt_StartTime.TabIndex = 13;
            this.uiDt_StartTime.Value = new System.DateTime(2020, 11, 28, 21, 19, 49, 0);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn,
            this.nikelQuoteDataGridViewTextBoxColumn,
            this.aluminumQuoteDataGridViewTextBoxColumn,
            this.ironOreQuoteDataGridViewTextBoxColumn,
            this.copperQuoteDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.resourceQuoteBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(670, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(399, 506);
            this.dataGridView1.TabIndex = 12;
            // 
            // checkBox4
            // 
            this.checkBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox4.AutoSize = true;
            this.checkBox4.Checked = true;
            this.checkBox4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox4.Location = new System.Drawing.Point(562, 418);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(48, 16);
            this.checkBox4.TabIndex = 8;
            this.checkBox4.Text = "구리";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox3.Location = new System.Drawing.Point(562, 396);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(72, 16);
            this.checkBox3.TabIndex = 9;
            this.checkBox3.Text = "알루미늄";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox2.Location = new System.Drawing.Point(562, 374);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(48, 16);
            this.checkBox2.TabIndex = 10;
            this.checkBox2.Text = "니켈";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox1.Location = new System.Drawing.Point(562, 352);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(60, 16);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "철광석";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea3.AxisX.Interval = 5D;
            chartArea3.AxisX.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Days;
            chartArea3.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Days;
            chartArea3.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea3.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Rotated270;
            chartArea3.AxisY.Title = "($/Ton)";
            chartArea3.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea3.BorderWidth = 4;
            chartArea3.Name = "ChartArea1";
            chartArea3.Position.Auto = false;
            chartArea3.Position.Height = 94F;
            chartArea3.Position.Width = 75.79263F;
            chartArea3.Position.X = 3F;
            chartArea3.Position.Y = 3F;
            this.chart1.ChartAreas.Add(chartArea3);
            this.chart1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.chart1.DataSource = this.resourceQuoteBindingSource;
            legend3.Alignment = System.Drawing.StringAlignment.Center;
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            series9.BorderWidth = 4;
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series9.Legend = "Legend1";
            series9.MarkerBorderWidth = 4;
            series9.Name = "철광석";
            series9.XValueMember = "date";
            series9.YValueMembers = "Iron_Ore_Quote";
            series10.BorderWidth = 4;
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series10.Legend = "Legend1";
            series10.MarkerBorderWidth = 4;
            series10.Name = "니켈";
            series10.XValueMember = "date";
            series10.YValueMembers = "Nikel_Quote";
            series11.BorderWidth = 4;
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series11.Legend = "Legend1";
            series11.MarkerBorderWidth = 4;
            series11.Name = "알루미늄";
            series11.XValueMember = "date";
            series11.YValueMembers = "Aluminum_Quote";
            series12.BorderWidth = 4;
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series12.Legend = "Legend1";
            series12.MarkerBorderWidth = 4;
            series12.Name = "구리";
            series12.XValueMember = "date";
            series12.YValueMembers = "Copper_Quote";
            this.chart1.Series.Add(series9);
            this.chart1.Series.Add(series10);
            this.chart1.Series.Add(series11);
            this.chart1.Series.Add(series12);
            this.chart1.Size = new System.Drawing.Size(652, 506);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "chart1";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(584, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 16;
            this.label1.Text = "시작날짜";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(584, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 16;
            this.label2.Text = "종료날짜";
            // 
            // Reset
            // 
            this.Reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Reset.Location = new System.Drawing.Point(570, 467);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(82, 33);
            this.Reset.TabIndex = 17;
            this.Reset.Text = "초기화면";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // resourceQuoteFormBindingSource
            // 
            this.resourceQuoteFormBindingSource.DataSource = typeof(MesUI.ResourceQuoteForm);
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nikelQuoteDataGridViewTextBoxColumn
            // 
            this.nikelQuoteDataGridViewTextBoxColumn.DataPropertyName = "Nikel_Quote";
            this.nikelQuoteDataGridViewTextBoxColumn.HeaderText = "Nikel_Quote";
            this.nikelQuoteDataGridViewTextBoxColumn.Name = "nikelQuoteDataGridViewTextBoxColumn";
            this.nikelQuoteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aluminumQuoteDataGridViewTextBoxColumn
            // 
            this.aluminumQuoteDataGridViewTextBoxColumn.DataPropertyName = "Aluminum_Quote";
            this.aluminumQuoteDataGridViewTextBoxColumn.HeaderText = "Aluminum_Quote";
            this.aluminumQuoteDataGridViewTextBoxColumn.Name = "aluminumQuoteDataGridViewTextBoxColumn";
            this.aluminumQuoteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ironOreQuoteDataGridViewTextBoxColumn
            // 
            this.ironOreQuoteDataGridViewTextBoxColumn.DataPropertyName = "Iron_Ore_Quote";
            this.ironOreQuoteDataGridViewTextBoxColumn.HeaderText = "Iron_Ore_Quote";
            this.ironOreQuoteDataGridViewTextBoxColumn.Name = "ironOreQuoteDataGridViewTextBoxColumn";
            this.ironOreQuoteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // copperQuoteDataGridViewTextBoxColumn
            // 
            this.copperQuoteDataGridViewTextBoxColumn.DataPropertyName = "Copper_Quote";
            this.copperQuoteDataGridViewTextBoxColumn.HeaderText = "Copper_Quote";
            this.copperQuoteDataGridViewTextBoxColumn.Name = "copperQuoteDataGridViewTextBoxColumn";
            this.copperQuoteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // resourceQuoteBindingSource
            // 
            this.resourceQuoteBindingSource.DataSource = typeof(MiniSteelworksMES.Data.Resource_Quote);
            // 
            // transactionBindingSource
            // 
            this.transactionBindingSource.DataSource = typeof(MiniSteelworksMES.Data.Transaction);
            // 
            // transactionBindingSource1
            // 
            this.transactionBindingSource1.DataSource = typeof(MiniSteelworksMES.Data.Transaction);
            // 
            // transactionBindingSource2
            // 
            this.transactionBindingSource2.DataSource = typeof(MiniSteelworksMES.Data.Transaction);
            // 
            // ResourceQuoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 530);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PeriodSerch);
            this.Controls.Add(this.uiDt_EndTime);
            this.Controls.Add(this.uiDt_StartTime);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.chart1);
            this.Name = "ResourceQuoteForm";
            this.Text = "원자재 시세 조회";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourceQuoteFormBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourceQuoteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PeriodSerch;
        private System.Windows.Forms.DateTimePicker uiDt_EndTime;
        private System.Windows.Forms.DateTimePicker uiDt_StartTime;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.BindingSource transactionBindingSource;
        private System.Windows.Forms.BindingSource transactionBindingSource1;
        private System.Windows.Forms.BindingSource transactionBindingSource2;
        private System.Windows.Forms.BindingSource resourceQuoteBindingSource;
        private System.Windows.Forms.BindingSource resourceQuoteFormBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nikelQuoteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aluminumQuoteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ironOreQuoteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn copperQuoteDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Reset;
    }
}