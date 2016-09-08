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
    public partial class Exercise_4 : Form
    {
        public Exercise_4()
        {
            InitializeComponent();
        }

        private void radBasketball_CheckedChanged(object sender, EventArgs e)
        {
            imgSport.Image = Image.FromFile(@"..\..\Exercises\images\basketball.jpg");
            lblSportDesc.Text = "Hope you brought your jordans.";
        }

        private void radFootball_CheckedChanged(object sender, EventArgs e)
        {
            imgSport.Image = Image.FromFile(@"..\..\Exercises\images\football.jpg");
            lblSportDesc.Text = "Silly Americans.";
        }

        private void radRugby_CheckedChanged(object sender, EventArgs e)
        {
            imgSport.Image = Image.FromFile(@"..\..\Exercises\images\rugby.jpg");
            lblSportDesc.Text = "A real mans sport.";
        }

        private void radMuayThai_CheckedChanged(object sender, EventArgs e)
        {
            imgSport.Image = Image.FromFile(@"..\..\Exercises\images\muaythai.jpg");
            lblSportDesc.Text = "Courage isn't enough.";
        }

        private void radGolf_CheckedChanged(object sender, EventArgs e)
        {
            imgSport.Image = Image.FromFile(@"..\..\Exercises\images\golf.jpg");
            lblSportDesc.Text = "Retirement isn't what it's cracked up to be.";
        }
    }
}
