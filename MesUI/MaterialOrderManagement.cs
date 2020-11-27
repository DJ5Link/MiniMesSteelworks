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
    public partial class MaterialOrderManagement : Form
    {
        public MaterialOrderManagement()
        {
            InitializeComponent();
        }
        private void MaterialOrderManagement_Load(object sender, EventArgs e)
        {
            DisplayAllItem();
        }
        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (searchConditionComboBox.SelectedIndex == 1)
            {
                List<Order> list = Dao.Order.GetByPK(searchConditionTextBox.Text);
                orderBindingSource.DataSource = list;

            }
            else if (searchConditionComboBox.SelectedIndex == 2)
            {
                List<Order> list = Dao.Order.GetBySellerName(searchConditionTextBox.Text);
                orderBindingSource.DataSource = list;
            }
            else
                DisplayAllItem();
        }

        public void DisplayAllItem()
        {
            List<Order> list = Dao.Order.GetAll();
            orderBindingSource.DataSource = list;
        }

       
    }
}
