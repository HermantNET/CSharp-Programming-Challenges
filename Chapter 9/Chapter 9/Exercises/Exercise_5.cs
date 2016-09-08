using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter_9.Exercises
{
    public partial class Exercise_5 : Form
    {
        public Exercise_5()
        {
            InitializeComponent();
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            int x, y;
            if (!int.TryParse(txtX.Text, out x) | !int.TryParse(txtY.Text, out y))
                MessageBox.Show("Please enter an Integer.");
            else
            {
                this.Location = new Point(x, y);
            }
        }
    }
}
