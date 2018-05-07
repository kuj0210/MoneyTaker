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
    public partial class ProfileForm : Form
    {
        public ProfileForm()
        {
            InitializeComponent();
        }

        private void ModifyInformationBtn_Click(object sender, EventArgs e)
        {
            ModifyPanel.Visible = true;
        }

        private void SaveInformationBtn_Click(object sender, EventArgs e)
        {
            ModifyPanel.Visible = false;
        }

    }
}
