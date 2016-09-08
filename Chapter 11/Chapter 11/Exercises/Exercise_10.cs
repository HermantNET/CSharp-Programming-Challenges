using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter_11.Exercises
{
    public partial class Exercise_10 : Form
    {
        public Exercise_10()
        {
            InitializeComponent();
            label1.Text = Ex10.Presentation.MultiUnit();
            label2.Text = Ex10.Presentation.SingleFamily();
        }
    }
}
