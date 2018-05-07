using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyTakerUI
{
    public partial class DealForm : Form
    {
        public DealForm()
        {
            InitializeComponent();
        }


        private void BorrowBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OOO 님께 돈을 빌렸습니다. 기간안에 갚지 못하면 신용도가 낮아집니다.");
        }

        private void LendBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OOO님께 돈을 빌렸습니다. 현재 OOO님의 신용도는 XX%입니다. 신용도에 따라 돈을 못 받을 수도 있습니다.");
        }

        private void BorrowMondyBtn_Click(object sender, EventArgs e)
        {
            LendMoneyPanel.Visible = false;
            DealListPanel.Visible = false;
        }

        private void LendMoneyBtn_Click(object sender, EventArgs e)
        {
            LendMoneyPanel.Visible = true;
            DealListPanel.Visible = false;
        }

        private void DealListBtn_Click(object sender, EventArgs e)
        {
            LendMoneyPanel.Visible = true;
            DealListPanel.Visible = true;
        }

        private void DealForm_Load(object sender, EventArgs e)
        {
            int n = 0;
            String today = DateTime.Today.ToString();
            n = DealListData.Rows.Add();
            DealListData.Rows[n].Cells[0].Value = "선배";
            DealListData.Rows[n].Cells[1].Value = "유호균";
            DealListData.Rows[n].Cells[2].Value = "134134";
            DealListData.Rows[n].Cells[3].Value = "받아야함";
            DealListData.Rows[n].Cells[4].Value = "10";
            DealListData.Rows[n].Cells[5].Value = 3;

            DealListData.BorderStyle = BorderStyle.None;
            DealListData.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            DealListData.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DealListData.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 213, 214);
            DealListData.DefaultCellStyle.SelectionForeColor = Color.Black;
            DealListData.BackgroundColor = Color.FromArgb(252, 248, 248);

            DealListData.EnableHeadersVisualStyles = false;
            DealListData.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DealListData.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            DealListData.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
        }
    }
}
