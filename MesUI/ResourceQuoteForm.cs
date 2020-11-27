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
    public partial class ResourceQuoteForm : Form
    {
        //public DateTime d1, d2;
        //MesEntities rq;
        public ResourceQuoteForm()
        {
            InitializeComponent();
            checkBox1.CheckedChanged += checkBox_CheckedChanged;
            checkBox2.CheckedChanged += checkBox_CheckedChanged;
            checkBox3.CheckedChanged += checkBox_CheckedChanged;
            checkBox4.CheckedChanged += checkBox_CheckedChanged;
            SetGridLayout();
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            { chart1.Series[0].Enabled = true; }
            else
            { chart1.Series[0].Enabled = false; }

            if (checkBox2.Checked)
            { chart1.Series[1].Enabled = true; }
            else
            { chart1.Series[1].Enabled = false; }

            if (checkBox3.Checked)
            { chart1.Series[2].Enabled = true; }
            else
            { chart1.Series[2].Enabled = false; }

            if (checkBox4.Checked)
            { chart1.Series[3].Enabled = true; }
            else
            { chart1.Series[3].Enabled = false; }
        }

        private void ResourceQuoteForm_Load(object sender, EventArgs e)
        {
            //List<Resource_Quote> list = Dao.Resource_Quote.GetAll();
            //resourceQuoteBindingSource.DataSource = list;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DisplayQuote();
            //string rscKey = "1";
            //Dao.ResourceQuote.GetQuote(rscKey, d1, d2);
        }
        private void SetGridLayout()
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void DisplayQuote()
        {
            List<Resource_Quote> list = Dao.Resource_Quote.GetAll();
            resourceQuoteBindingSource.DataSource = list;
        }
    }
}
