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
    public partial class Exercise_5 : Form
    {
        public List<CheckBox> items = new List<CheckBox>();

        public Exercise_5()
        {
            InitializeComponent();
            items.AddRange(new CheckBox[] { checkBox1, checkBox2, checkBox3, checkBox4, checkBox5, checkBox6, checkBox7, checkBox8 });
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            string display = "";
            items.ForEach((item) =>
            {
                if (item.Checked)
                    display += item.Text + "\n";
            });
            MessageBox.Show(display, "Selected Items");
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            items.ForEach(x => x.Checked = false);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
