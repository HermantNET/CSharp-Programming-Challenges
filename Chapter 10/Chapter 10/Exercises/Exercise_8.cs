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
    public partial class Exercise_8 : Form
    {
        public Exercise_8()
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
            numQuantity.Value = 1;
            radOvernight.Checked = true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            decimal shippingChoice= ShippingCost();
            decimal bagCost = BagCost();
            decimal shippingTotal = shippingChoice * (bagCost * numQuantity.Value);

            MessageBox.Show(string.Format(
                    "Selected Bag: {0}\n" +
                    "Quantity: {1:N0}\n" +
                    "Shipping Charge: {2:C}\n" +
                    "Total: {3:C}",
                    lstBags.SelectedItem.ToString(), numQuantity.Value,
                    shippingTotal,
                    (bagCost * numQuantity.Value) + shippingTotal
                ));
        }

        public decimal ShippingCost()
        {
            // Shipping Rates
            const decimal OVERNIGHT = 0.1M;
            const decimal THREE_DAY = 0.07M;
            const decimal STANDARD = 0.05M;

            if (radOvernight.Checked)
                return OVERNIGHT;
            else if (radThreeDay.Checked)
                return THREE_DAY;
            else if (radStandard.Checked)
                return STANDARD;
            else
                return 1;
        }

        public decimal BagCost()
        {
            // Cost of Bags
            const decimal FULL_DECOR = 50M;
            const decimal BEADED = 45M;
            const decimal NEEDLEPOINT = 40M;
            const decimal FRINGED = 25M;
            const decimal FRINGED_BEADED = 30M;
            const decimal PLAIN = 20M;

            if (lstBags.SelectedItem == "full decorative")
                return FULL_DECOR;
            else if (lstBags.SelectedItem == "beaded")
                return BEADED;
            else if (lstBags.SelectedItem == "needlepoint design")
                return NEEDLEPOINT;
            else if (lstBags.SelectedItem == "fringed")
                return FRINGED;
            else if (lstBags.SelectedItem == "fringed beaded")
                return FRINGED_BEADED;
            else if (lstBags.SelectedItem == "plain")
                return PLAIN;
            else
                return 0;
        }
    }
}
