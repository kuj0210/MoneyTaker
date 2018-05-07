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
    public partial class LoginForm : Form
    {
        int togMove, MvalX, MvalY;

        public LoginForm()
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

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.FormClosed += new FormClosedEventHandler(mainForm_FormClosed);
            this.Hide();
            mainForm.ShowDialog();
        }

        private void mainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            JoinUsPanel.Visible = true;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StartPanel.Visible = false;
        }

        private void JSPrevLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            JoinUsPanel.Visible = false;
        }

        private void JoinUsSignUpBtn_Click(object sender, EventArgs e)
        {
            if (true)
            {
                MessageBox.Show("아이디 생성이 완료되었습니다 !");
                JoinUsPanel.Visible = false;
            }
        }
    }

}
