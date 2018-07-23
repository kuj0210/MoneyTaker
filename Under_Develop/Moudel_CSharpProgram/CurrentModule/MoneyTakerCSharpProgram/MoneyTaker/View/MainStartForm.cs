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
    public partial class MainStartForm : Form
    {
        public MainStartForm()
        {
            InitializeComponent();
        }

        private void MainStartForm_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            for (int i = 1; i < 31; i++)
                MyRatingChart.Series["rating"].Points.AddXY(i,rnd.Next(1,101));
        }
    }
}
