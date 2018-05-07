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
    public partial class FriendsForm : Form
    {
        public FriendsForm()
        {
            InitializeComponent();
        }

        private void FriendsForm_Load(object sender, EventArgs e)
        {
            int n = 0;
            for (int i = 0; i < 4; i++)
            {
                n = FriendsData.Rows.Add();
                FriendsData.Rows[n].Cells[0].Value = "선배";
                FriendsData.Rows[n].Cells[1].Value = "김우진";
                FriendsData.Rows[n].Cells[2].Value = "999%";
                FriendsData.Rows[n].Cells[3].Value = "GINIPIGLOVE@D134.kumoh.ac.kr";
                n = FriendsData.Rows.Add();
                FriendsData.Rows[n].Cells[0].Value = "선배";
                FriendsData.Rows[n].Cells[1].Value = "유호균";
                FriendsData.Rows[n].Cells[2].Value = "10%";
                FriendsData.Rows[n].Cells[3].Value = "ImHaRin@kyosang.stone";
                n = FriendsData.Rows.Add();
                FriendsData.Rows[n].Cells[0].Value = "친구";
                FriendsData.Rows[n].Cells[1].Value = "현진혁";
                FriendsData.Rows[n].Cells[2].Value = "4.5%";
                FriendsData.Rows[n].Cells[3].Value = "Ilike4and5number@itmakesme.happy";
                n = FriendsData.Rows.Add();
                FriendsData.Rows[n].Cells[0].Value = "선배";
                FriendsData.Rows[n].Cells[1].Value = "고대석";
                FriendsData.Rows[n].Cells[2].Value = "100%";
                FriendsData.Rows[n].Cells[3].Value = "FUCKtongHak@Busisnotarrive.yet";
            }

            FriendsData.BorderStyle = BorderStyle.None;
            FriendsData.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            FriendsData.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            FriendsData.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 213, 214);
            FriendsData.DefaultCellStyle.SelectionForeColor = Color.Black;
            FriendsData.BackgroundColor = Color.FromArgb(252, 248, 248);

            FriendsData.EnableHeadersVisualStyles = false;
            FriendsData.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            FriendsData.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            FriendsData.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

        }

        private void AddFriendsBtn_Click(object sender, EventArgs e)
        {
            AddFriendsForm addfriends = new AddFriendsForm();
            addfriends.ShowDialog();
        }

        private void AddGroupBtn_Click(object sender, EventArgs e)
        {
            AddGroupsForm addgroups = new AddGroupsForm();
            addgroups.ShowDialog();
        }
    }
}

