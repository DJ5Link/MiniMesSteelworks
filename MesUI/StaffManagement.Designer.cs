
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("경영팀");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("인사팀");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("물류팀");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("생산팀");
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.StaffSearchButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.StaffInfoButton = new System.Windows.Forms.Button();
            this.IDorNAME = new System.Windows.Forms.ComboBox();
            this.Address = new System.Windows.Forms.TextBox();
            this.PhoneNumber = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.StaffName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Position = new System.Windows.Forms.TextBox();
            this.StaffID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Font = new System.Drawing.Font("HY수평선B", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "경영팀";
            treeNode1.Text = "경영팀";
            treeNode2.Name = "인사팀";
            treeNode2.Text = "인사팀";
            treeNode3.Name = "물류팀";
            treeNode3.Text = "물류팀";
            treeNode4.Name = "생산팀";
            treeNode4.Text = "생산팀";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            this.treeView1.Size = new System.Drawing.Size(235, 235);
            this.treeView1.TabIndex = 0;
            // 
            // StaffSearchButton
            // 
            this.StaffSearchButton.Location = new System.Drawing.Point(466, 224);
            this.StaffSearchButton.Name = "StaffSearchButton";
            this.StaffSearchButton.Size = new System.Drawing.Size(75, 23);
            this.StaffSearchButton.TabIndex = 1;
            this.StaffSearchButton.Text = "조회";
            this.StaffSearchButton.UseVisualStyleBackColor = true;
            this.StaffSearchButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(360, 225);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // StaffInfoButton
            // 
            this.StaffInfoButton.Location = new System.Drawing.Point(547, 224);
            this.StaffInfoButton.Name = "StaffInfoButton";
            this.StaffInfoButton.Size = new System.Drawing.Size(75, 23);
            this.StaffInfoButton.TabIndex = 4;
            this.StaffInfoButton.Text = "수정/등록";
            this.StaffInfoButton.UseVisualStyleBackColor = true;
            this.StaffInfoButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // IDorNAME
            // 
            this.IDorNAME.FormattingEnabled = true;
            this.IDorNAME.Items.AddRange(new object[] {
            "ID",
            "성함"});
            this.IDorNAME.Location = new System.Drawing.Point(266, 225);
            this.IDorNAME.Name = "IDorNAME";
            this.IDorNAME.Size = new System.Drawing.Size(88, 20);
            this.IDorNAME.TabIndex = 5;
            this.IDorNAME.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(329, 142);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(113, 21);
            this.Address.TabIndex = 34;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.Location = new System.Drawing.Point(329, 115);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(113, 21);
            this.PhoneNumber.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(270, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 31;
            this.label8.Text = "주      소";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(270, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 27;
            this.label4.Text = "연  락 처";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(270, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 26;
            this.label3.Text = "직      책";
            // 
            // StaffName
            // 
            this.StaffName.Location = new System.Drawing.Point(329, 56);
            this.StaffName.Name = "StaffName";
            this.StaffName.Size = new System.Drawing.Size(113, 21);
            this.StaffName.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 23;
            this.label1.Text = "성      함";
            // 
            // Position
            // 
            this.Position.Location = new System.Drawing.Point(329, 86);
            this.Position.Name = "Position";
            this.Position.Size = new System.Drawing.Size(113, 21);
            this.Position.TabIndex = 44;
            // 
            // StaffID
            // 
            this.StaffID.Location = new System.Drawing.Point(329, 29);
            this.StaffID.Name = "StaffID";
            this.StaffID.Size = new System.Drawing.Size(113, 21);
            this.StaffID.TabIndex = 46;
            this.StaffID.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(307, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 12);
            this.label5.TabIndex = 45;
            this.label5.Text = "ID";
            // 
            // StaffManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 260);
            this.Controls.Add(this.StaffID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Position);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.PhoneNumber);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StaffName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IDorNAME);
            this.Controls.Add(this.StaffInfoButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.StaffSearchButton);
            this.Controls.Add(this.treeView1);
            this.Name = "StaffManagement";
            this.Text = "StaffManagement";
            this.Load += new System.EventHandler(this.StaffManagement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button StaffSearchButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button StaffInfoButton;
        private System.Windows.Forms.ComboBox IDorNAME;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.TextBox PhoneNumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox StaffName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Position;
        private System.Windows.Forms.TextBox StaffID;
        private System.Windows.Forms.Label label5;
    }
}