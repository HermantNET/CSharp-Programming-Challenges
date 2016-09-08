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
    public partial class Exercise_7 : Form
    {
        public Exercise_7()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtPassword1.Text != "")
            {
                txtPassword2.Visible = true;
                btnCompare.Visible = true;
            }
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            lblContext.Text = (txtPassword1.Text == txtPassword2.Text) ? "Passwords match" : "Passwords do not match";
        }
    }
}
