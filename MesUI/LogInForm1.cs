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
    public partial class LogInForm1 : Form
    {
        public LogInForm1()
        {
            InitializeComponent();
        }
        

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (Dao.Employee.VerifyIdPassword(usrIdText.Text, passwdText.Text))
            {
                MessageBox.Show(Dao.Employee.GetName(usrIdText.Text) + "님 안녕하세요!", "로그인 성공");
                ((Form1)(this.MdiParent)).loginState = true;
                ((Form1)(this.MdiParent)).ShowForm("loginForm2");
            }
            else
            {
                MessageBox.Show("ID 또는 암호가 틀렸습니다!", "로그인 실패");
                ((Form1)(this.MdiParent)).loginState = false;
            }
        }

        private void tealLogo_Click(object sender, EventArgs e)
        {

            //MessageBox.Show(usrNameText.Text + "님, 안녕하세요!");

            //if (Dao.Employee.VerifyIdPassword(usrNameText.Text, passwdText.Text))
            //    loginstate = true;// MessageBox.Show(usrNameText.Text + "인증 성공");
            ////LogInForm2 form1 = (LogInForm2)((Form1)(this.MdiParent)).dictForm["loginForm2"];
            //((Form1)(this.MdiParent)).ShowForm("loginForm2");
        }
    }
}
