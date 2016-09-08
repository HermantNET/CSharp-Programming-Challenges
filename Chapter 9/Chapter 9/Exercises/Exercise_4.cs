using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter_9
{
    public partial class Exercise_4 : Form
    {
        public Exercise_4()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            string operation = ((Button)sender).Tag.ToString();
            double num1, num2;

            if (txtNum1.Text == "" || txtNum2.Text == "")
                lblResult.Text = "Missing number";
            else if (!double.TryParse(txtNum1.Text, out num1) | !double.TryParse(txtNum2.Text, out num2))
                lblResult.Text = "Please enter a numeric value";
            else
            {
                lblResult.Text = MathOperations(operation, num1, num2).ToString();
            }
            lblResult.Visible = true;
        }

        private double MathOperations(string operation, double num1, double num2)
        {
            switch (operation)
            {
                case "add":
                    return num1 + num2;
                case "multiply":
                    return num1 * num2;
                default:
                    return 0;
            }
        }
    }
}
