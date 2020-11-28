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
    public partial class TransactionStock : Form
    {
        TransactionModify modForm = null;

        public TransactionStock()
        {
            InitializeComponent();

            SetGridLayout();
        }

        private void TransactionStock_Load(object sender, EventArgs e)
        {
            //TransactionStock trStockForm = new TransactionStock();
            //formList.Add(trStockForm);
            //trStockForm.MdiParent = this;

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            List<Transaction> list = Dao.Transaction.GetAll();
            bdsTransaction.DataSource = list;

                //foreach (var x in list)
                //{
                //    string[] row = { x.Date.ToString(), x.WareHouseId.ToString()
                //            , x.EmployeeId.ToString(), x.Type == false ? "입고" : "출고"
                //    , x.Origin, x.SellerName };

            //    rscTransactionGrid.Rows.Add(row);
            //}
        }

        private void SetGridLayout()
        {
            //rscTransactionGrid.ColumnCount = 7;

            rscTransactionGrid.Columns[2].Width = 160;

            //rscTransactionGrid.Columns[0].Name = "시각";
            //rscTransactionGrid.Columns[1].Name = "창고";
            //rscTransactionGrid.Columns[2].Name = "담당자";
            //rscTransactionGrid.Columns[3].Name = "원자재명";
            //rscTransactionGrid.Columns[4].Name = "구분";
            //rscTransactionGrid.Columns[5].Name = "원산지";
            //rscTransactionGrid.Columns[6].Name = "수입처";
            
            rscTransactionGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void rscTransactionGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if( rscTransactionGrid.RowCount < 1 )
            {
                MessageBox.Show("조회 후 수정 가능합니다", "수정");
                return;
            }

            string[] gridRow = new string[7];

            for (int i = 0; i < rscTransactionGrid.SelectedRows[0].Cells.Count; i++)
            {
                gridRow[i] = rscTransactionGrid.SelectedRows[0].Cells[i].Value.ToString();
            }

            modForm = new TransactionModify(gridRow);
            modForm.parentForm = this;

            modForm.Show();
        }

        public void DisplayAllItem()
        {
            List<Transaction> list = Dao.Transaction.GetAll();
            bdsTransaction.DataSource = list;
        }
    }
}
