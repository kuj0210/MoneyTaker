using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyTaker
{
    public partial class MainForm : Form
    {
        int togMove, MvalX, MvalY;
        MainStartForm mainstartform = new MainStartForm();
        ProfileForm profile = new ProfileForm();
        FriendsForm friends = new FriendsForm();
        DealForm deal = new DealForm();

        void MainPanelClear()
        {
            MainPanel.Controls.Clear();
        }

        public MainForm()
        {
            InitializeComponent();
        }
        
        #region TopBar and Exit tool
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TopBar_MouseDown(object sender, MouseEventArgs e)
        {
            togMove = 1;
            MvalX = e.X;
            MvalY = e.Y;
        }

        private void TopBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (togMove == 1)
                this.SetDesktopLocation(MousePosition.X - MvalX, MousePosition.Y - MvalY);
        }

        private void TopBar_MouseUp(object sender, MouseEventArgs e)
        {
            togMove = 0;
        }
        #endregion

        private void ProfileBtn_Click(object sender, EventArgs e)
        {
            MainPanelClear();
            profile.TopLevel = false;
            MainPanel.Controls.Add(profile);
            profile.Show();
            ProfileBtn.BackColor = Color.FromArgb(239, 216, 216);
            friendsbtn.BackColor = Color.FromArgb(246, 233, 233);
            dealbtn.BackColor = Color.FromArgb(246, 233, 233);
        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            MainPanelClear();
            MainPanel.Visible = true;
            this.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            MainPanelClear();
            mainstartform.TopLevel = false;
            MainPanel.Controls.Add(mainstartform);
            mainstartform.Show();
        }

        private void dealbtn_Click(object sender, EventArgs e)
        {
            MainPanelClear();
            deal.TopLevel = false;
            MainPanel.Controls.Add(deal);
            deal.Show();
            ProfileBtn.BackColor = Color.FromArgb(246, 233, 233);
            friendsbtn.BackColor = Color.FromArgb(246, 233, 233);
            dealbtn.BackColor = Color.FromArgb(239, 216, 216);
        }

        private void friendsbtn_Click(object sender, EventArgs e)
        {
            MainPanelClear();
            friends.TopLevel = false;
            MainPanel.Controls.Add(friends);
            friends.Show();
            ProfileBtn.BackColor = Color.FromArgb(246, 233, 233);
            dealbtn.BackColor = Color.FromArgb(246, 233, 233);
            friendsbtn.BackColor = Color.FromArgb(239, 216, 216);
        }

        private void ComeBackMain_Click(object sender, EventArgs e)
        {
            MainPanelClear();
            mainstartform.TopLevel = false;
            MainPanel.Controls.Add(mainstartform);
            mainstartform.Show();
            ProfileBtn.BackColor = Color.FromArgb(246, 233, 233);
            friendsbtn.BackColor = Color.FromArgb(246, 233, 233);
            dealbtn.BackColor = Color.FromArgb(246, 233, 233);
        }

    }
}
