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
    public partial class AddGroupsForm : Form
    {
        int togMove, MvalX, MvalY;

        public AddGroupsForm()
        {
            InitializeComponent();
        }
        #region TopBar and Exit tool
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void AddGroupYesBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddGroupCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }

}
