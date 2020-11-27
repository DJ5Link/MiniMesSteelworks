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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Dictionary<string, Form> dictForm = new Dictionary<string, Form>();

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                for (int i = 0; i < dictForm.Count; i++)
                {
                    Form[] forms = this.MdiChildren;
                    foreach (var item in forms)
                    {
                        ((Form)item).Hide();
                    }
                }
                StaffManagement form = (StaffManagement)dictForm["staffManagementForm"];
                form.Show();
            }

            else if (tabControl1.SelectedIndex == 1)
            {
                for (int i = 0; i < dictForm.Count; i++)
                {
                    Form[] forms = this.MdiChildren;
                    foreach (var item in forms)
                    {
                        ((Form)item).Hide();
                    }
                }
                TransactionStock form = (TransactionStock) dictForm["transactionStockForm"];
                form.Show();
            }

            else if (tabControl1.SelectedIndex == 2)
            {
                for (int i = 0; i < dictForm.Count; i++)
                {
                    Form[] forms = this.MdiChildren;
                    foreach (var item in forms)
                    {
                        ((Form)item).Hide();
                    }
                }
                MaterialOrderManagement form = (MaterialOrderManagement)dictForm["materialOrderForm"];
                form.Show();
            }


            else if (tabControl1.SelectedIndex == 3)
            {
                for (int i = 0; i < dictForm.Count; i++)
                {
                    Form[] forms = this.MdiChildren;
                    foreach (var item in forms)
                    {
                        ((Form)item).Hide();
                    }
                }
                WarehouseManagement form = (WarehouseManagement)dictForm["warehouseManagementForm"];
                form.Show();
            }




            else if (tabControl1.SelectedIndex == 4)
            {
                for(int i=0; i<dictForm.Count; i++)
                {
                    Form[] forms = this.MdiChildren;
                    foreach (var item in forms)
                    {
                        ((Form)item).Hide();
                    }
                }
                ResourceQuoteForm form = (ResourceQuoteForm)dictForm["resourceQuoteForm"];
                form.Show();
                form.DisplayQuote();
            }
            else
            {
                TransactionStock form = (TransactionStock)dictForm["transactionStockForm"];
                form.Hide();
            }
        }

        public void ShowForm(int index = 0)
        {
            for (int i = 0; i < dictForm.Count; i++)
            {
                Form[] forms = this.MdiChildren;
                foreach (var item in forms)
                {
                    ((Form)item).Hide();
                }
            }

            if (index == 10)
            {
                LogInForm2 form = (LogInForm2)dictForm["loginForm2"];
                form.Show();
            }
            
        }

        private void tabControl1_TabIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StaffManagement staffManagementForm = new StaffManagement();
            staffManagementForm.MdiParent = this;
            dictForm.Add("staffManagementForm", staffManagementForm);
            staffManagementForm.Dock = DockStyle.Fill;

            TransactionStock trStockForm = new TransactionStock();
            trStockForm.MdiParent = this;
            dictForm.Add("transactionStockForm", trStockForm);
            trStockForm.Dock = DockStyle.Fill;

            WarehouseManagement warehouseManagementForm = new WarehouseManagement();
            warehouseManagementForm.MdiParent = this;
            dictForm.Add("warehouseManagementForm", warehouseManagementForm);
            warehouseManagementForm.Dock = DockStyle.Fill;

            ResourceQuoteForm rscQuoteForm = new ResourceQuoteForm();
            rscQuoteForm.MdiParent = this;
            dictForm.Add("resourceQuoteForm", rscQuoteForm);
            rscQuoteForm.Dock = DockStyle.Fill;

            LogInForm1 loginForm = new LogInForm1();
            loginForm.MdiParent = this;
            dictForm.Add("loginForm", loginForm);
            loginForm.Dock = DockStyle.Fill;

            MaterialOrderManagement materialOrderForm = new MaterialOrderManagement();
            materialOrderForm.MdiParent = this;
            dictForm.Add("materialOrderForm", materialOrderForm);
            materialOrderForm.Dock = DockStyle.Fill;

            loginForm.Width = 900;
            loginForm.Height = 600;
            loginForm.Dock = DockStyle.Fill;

            LogInForm2 login2Form = new LogInForm2();
            login2Form.MdiParent = this;
            dictForm.Add("loginForm2", login2Form);
            login2Form.Dock = DockStyle.Fill;

            loginForm.Show();
        }

        public void ShowForm(string formName)
        {
            for (int i = 0; i < dictForm.Count; i++)
            {
                Form[] forms = this.MdiChildren;
                foreach (var item in forms)
                {
                    ((Form)item).Hide();
                }
            }

            Form form = (Form)dictForm[formName];
            if( form != null )
                form.Show();
        }
    }
}
