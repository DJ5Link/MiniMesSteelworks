
namespace MesUI
{
    partial class StaffManagement
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textboxStaffName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textboxPhoneNumber = new System.Windows.Forms.TextBox();
            this.textboxAddress = new System.Windows.Forms.TextBox();
            this.buttonModifyEmployee = new System.Windows.Forms.Button();
            this.buttonRegisterEmployee = new System.Windows.Forms.Button();
            this.textboxStaffPosition = new System.Windows.Forms.TextBox();
            this.textBoxEmployeeId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonStaffSearch = new System.Windows.Forms.Button();
            this.textboxstaffId = new System.Windows.Forms.TextBox();
            this.treeViewEmployee = new System.Windows.Forms.TreeView();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(442, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 26;
            this.label3.Text = "직      책";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(442, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 27;
            this.label4.Text = "연  락 처";
            // 
            // textboxStaffName
            // 
            this.textboxStaffName.Location = new System.Drawing.Point(501, 79);
            this.textboxStaffName.Name = "textboxStaffName";
            this.textboxStaffName.Size = new System.Drawing.Size(113, 21);
            this.textboxStaffName.TabIndex = 2;
            this.textboxStaffName.Leave += new System.EventHandler(this.textboxStaffName_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(442, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 31;
            this.label8.Text = "주      소";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(442, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 23;
            this.label1.Text = "성      함";
            // 
            // textboxPhoneNumber
            // 
            this.textboxPhoneNumber.Location = new System.Drawing.Point(501, 138);
            this.textboxPhoneNumber.Name = "textboxPhoneNumber";
            this.textboxPhoneNumber.Size = new System.Drawing.Size(113, 21);
            this.textboxPhoneNumber.TabIndex = 4;
            this.textboxPhoneNumber.Leave += new System.EventHandler(this.textboxPhoneNumber_Leave);
            // 
            // textboxAddress
            // 
            this.textboxAddress.Location = new System.Drawing.Point(501, 165);
            this.textboxAddress.Name = "textboxAddress";
            this.textboxAddress.Size = new System.Drawing.Size(271, 21);
            this.textboxAddress.TabIndex = 5;
            this.textboxAddress.Leave += new System.EventHandler(this.textboxAddress_Leave);
            // 
            // buttonModifyEmployee
            // 
            this.buttonModifyEmployee.Location = new System.Drawing.Point(584, 263);
            this.buttonModifyEmployee.Name = "buttonModifyEmployee";
            this.buttonModifyEmployee.Size = new System.Drawing.Size(75, 23);
            this.buttonModifyEmployee.TabIndex = 8;
            this.buttonModifyEmployee.Text = "수정";
            this.buttonModifyEmployee.UseVisualStyleBackColor = true;
            this.buttonModifyEmployee.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonRegisterEmployee
            // 
            this.buttonRegisterEmployee.Location = new System.Drawing.Point(665, 263);
            this.buttonRegisterEmployee.Name = "buttonRegisterEmployee";
            this.buttonRegisterEmployee.Size = new System.Drawing.Size(75, 23);
            this.buttonRegisterEmployee.TabIndex = 9;
            this.buttonRegisterEmployee.Text = "등록";
            this.buttonRegisterEmployee.UseVisualStyleBackColor = true;
            this.buttonRegisterEmployee.Click += new System.EventHandler(this.button3_Click);
            // 
            // textboxStaffPosition
            // 
            this.textboxStaffPosition.Location = new System.Drawing.Point(501, 109);
            this.textboxStaffPosition.Name = "textboxStaffPosition";
            this.textboxStaffPosition.Size = new System.Drawing.Size(113, 21);
            this.textboxStaffPosition.TabIndex = 3;
            this.textboxStaffPosition.Leave += new System.EventHandler(this.textboxStaffPosition_Leave);
            // 
            // textBoxEmployeeId
            // 
            this.textBoxEmployeeId.Location = new System.Drawing.Point(503, 236);
            this.textBoxEmployeeId.Name = "textBoxEmployeeId";
            this.textBoxEmployeeId.Size = new System.Drawing.Size(111, 21);
            this.textBoxEmployeeId.TabIndex = 6;
            this.textBoxEmployeeId.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(442, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 12);
            this.label5.TabIndex = 45;
            this.label5.Text = "직원 ID";
            // 
            // buttonStaffSearch
            // 
            this.buttonStaffSearch.Location = new System.Drawing.Point(503, 263);
            this.buttonStaffSearch.Name = "buttonStaffSearch";
            this.buttonStaffSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonStaffSearch.TabIndex = 7;
            this.buttonStaffSearch.Text = "조회";
            this.buttonStaffSearch.UseVisualStyleBackColor = true;
            this.buttonStaffSearch.Click += new System.EventHandler(this.buttonStaffSearch_Click);
            // 
            // textboxstaffId
            // 
            this.textboxstaffId.Enabled = false;
            this.textboxstaffId.Location = new System.Drawing.Point(501, 52);
            this.textboxstaffId.Name = "textboxstaffId";
            this.textboxstaffId.Size = new System.Drawing.Size(113, 21);
            this.textboxstaffId.TabIndex = 1;
            this.textboxstaffId.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // treeViewEmployee
            // 
            this.treeViewEmployee.Font = new System.Drawing.Font("HYsupB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.treeViewEmployee.Location = new System.Drawing.Point(12, 12);
            this.treeViewEmployee.Name = "treeViewEmployee";
            this.treeViewEmployee.Size = new System.Drawing.Size(404, 531);
            this.treeViewEmployee.TabIndex = 11;
            this.treeViewEmployee.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewEmployee_AfterSelect);
            this.treeViewEmployee.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewEmployee_NodeMouseDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(442, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 12);
            this.label2.TabIndex = 47;
            this.label2.Text = "직원 ID";
            // 
            // StaffManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 577);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.treeViewEmployee);
            this.Controls.Add(this.textboxstaffId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonStaffSearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textboxStaffName);
            this.Controls.Add(this.textBoxEmployeeId);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textboxStaffPosition);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRegisterEmployee);
            this.Controls.Add(this.textboxPhoneNumber);
            this.Controls.Add(this.buttonModifyEmployee);
            this.Controls.Add(this.textboxAddress);
            this.Name = "StaffManagement";
            this.Text = "직원 관리 화면";
            this.Load += new System.EventHandler(this.StaffManagement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textboxStaffName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textboxPhoneNumber;
        private System.Windows.Forms.TextBox textboxAddress;
        private System.Windows.Forms.Button buttonModifyEmployee;
        private System.Windows.Forms.Button buttonRegisterEmployee;
        private System.Windows.Forms.TextBox textboxStaffPosition;
        private System.Windows.Forms.TextBox textBoxEmployeeId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonStaffSearch;
        private System.Windows.Forms.TextBox textboxstaffId;
        private System.Windows.Forms.TreeView treeViewEmployee;
        private System.Windows.Forms.Label label2;
    }
}