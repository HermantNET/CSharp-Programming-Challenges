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
    public partial class Exercise_1 : Form
    {
        public Exercise_1()
        {
            InitializeComponent();
        }

        private void displayToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format(
                txtAddress.Text + "\n" +
                txtEmail.Text + "\n" +
                txtPhone.Text + "\n"
                ), "Personal Info");
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtEmail.Clear();
            txtAddress.Clear();
            txtPhone.Clear();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
