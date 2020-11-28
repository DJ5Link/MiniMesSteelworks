using MiniSteelworksMES.Data;
using MiniSteelworksMES.Data.Dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MesUI
{
    public partial class StaffManagement : Form
    {
        public StaffManagement()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 폼이 로드될 때 호출된다.  DB에서 직원 정보를 가져온 후 폼에 출력해야 한다
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StaffManagement_Load(object sender, EventArgs e)
        {
            AddTeamNames();
        }

        private void AddTeamNames()
        {
            List<Employee> list = Dao.Employee.GetAll();

            List<string> strListTeamNames = Dao.Employee.GetTeamNames();

            foreach (var x in strListTeamNames)
            {
                treeViewEmployee.Nodes.Add(x);
            }

            foreach (var y in list)
            {
                for (int i = 0; i < strListTeamNames.Count; i++)
                {
                    if (y.Team == "경영팀")
                    {
                        if (treeViewEmployee.Nodes[i].Text == y.Team && y.Position == "사장")
                        {
                            treeViewEmployee.Nodes[i].Nodes.Add("사장 " + y.Name).Tag = y.EmployeeId.ToString();
                        }
                    }
                    else
                    {
                        if (treeViewEmployee.Nodes[i].Text == y.Team && y.Position == "부장")
                        {
                            treeViewEmployee.Nodes[i].Nodes.Add("팀장 " + y.Name).Tag = y.EmployeeId.ToString();
                        }
                    }
                }
            }

            foreach (var y in list)
            {
                for (int i = 0; i < strListTeamNames.Count; i++)
                {
                    if (treeViewEmployee.Nodes[i].Text == y.Team && y.Position != "부장" && y.Position != "사장")
                    {
                        treeViewEmployee.Nodes[i].Nodes[0].Nodes.Add(y.Position + " " + y.Name).Tag = y.EmployeeId.ToString();
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            StaffResisterORModify staffResisterORModifyForm = new StaffResisterORModify();
            staffResisterORModifyForm.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void treeViewEmployee_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //MessageBox.Show(e.Node.Name +"선택했음");
            
            
        }

        private void treeViewEmployee_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            List<Employee> list = Dao.Employee.GetByPK(Convert.ToInt32(((string)e.Node.Tag)));

            if (list.Count ==1 )
            {
                textboxstaffId.Text = list[0].EmployeeId.ToString();
                textboxStaffName.Text = list[0].Name;
                textboxStaffPosition.Text = list[0].Position;
                textboxPhoneNumber.Text = list[0].PhoneNumber;
                textboxAddress.Text = list[0].Address;
            }
        }

        private void buttonStaffSearch_Click(object sender, EventArgs e)
        {
            List<Employee> list = Dao.Employee.GetByPK( Convert.ToInt32(textBoxEmployeeId.Text ));

            if (list.Count == 1)
            {
                textboxstaffId.Text = list[0].EmployeeId.ToString();
                textboxStaffName.Text = list[0].Name;
                textboxStaffPosition.Text = list[0].Position;
                textboxPhoneNumber.Text = list[0].PhoneNumber;
                textboxAddress.Text = list[0].Address;
            }
        }

        private void textboxStaffName_Leave(object sender, EventArgs e)
        {
            if (MesRegEx.HasNumber(textboxStaffName.Text))
            {
                MessageBox.Show("문자만 입력 가능합니다", "입력 데이터 오류");
                textboxStaffName.Focus();
            }
        }

        private void textboxStaffPosition_Leave(object sender, EventArgs e)
        {
            if (MesRegEx.HasNumber(textboxStaffPosition.Text))
            {
                MessageBox.Show("문자만 입력 가능합니다", "입력 데이터 오류");
                textboxStaffPosition.Focus();
            }
        }

        private void textboxPhoneNumber_Leave(object sender, EventArgs e)
        {
            if (!MesRegEx.IsNumber(textboxPhoneNumber.Text))
            {
                MessageBox.Show("숫자만 입력 가능합니다", "입력 데이터 오류");
                textboxPhoneNumber.Focus();
            }
        }

        private void textboxAddress_Leave(object sender, EventArgs e)
        {
            if (MesRegEx.HasNumber(textboxAddress.Text))
            {
                MessageBox.Show("문자만 입력 가능합니다", "입력 데이터 오류");
                textboxAddress.Focus();
            }
        }
    }
}
