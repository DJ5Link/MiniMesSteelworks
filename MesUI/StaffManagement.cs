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
            List<Employee> list = Dao.Employee.GetAll();
            
            List<string> strListEmployee = Dao.Employee.GetTeamNames();

            foreach (var x in strListEmployee)
            {
                treeViewEmployee.Nodes.Add(x);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

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
            List<Employee> list= Dao.Employee.GetEmployeeByTeam( e.Node.Text );
            
            foreach (var x in list)
            {
                e.Node.Nodes.Add(x.Name);
            }
            
        }
    }
}
