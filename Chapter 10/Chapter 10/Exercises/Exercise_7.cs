using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter_10.Exercises
{
    public partial class Exercise_7 : Form
    {
        public Exercise_7()
        {
            InitializeComponent();
        }

        private void lstBags_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBags.SelectedIndex != -1)
                lblSelected.Text = lstBags.SelectedItem.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstBags.ClearSelected();
            lblSelected.Text = "NA";
        }
    }
}
