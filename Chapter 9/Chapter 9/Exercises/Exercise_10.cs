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
    public partial class Exercise_10 : Form
    {
        Random rand = new Random();
        private int answer { get; set; }
        public int GuessCount { get; set; }

        public Exercise_10()
        {
            InitializeComponent();
            answer = rand.Next(0, 101);
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            if (numGuess.Value < answer)
            {
                Exercise_10.ActiveForm.BackColor = Color.Red;
                lblGuessCount.Text = (++GuessCount).ToString();
            }
            else if (numGuess.Value > answer)
            {
                Exercise_10.ActiveForm.BackColor = Color.Blue;
                lblGuessCount.Text = (++GuessCount).ToString();
            }
            else
            {
                Exercise_10.ActiveForm.BackColor = Color.Green;
                MessageBox.Show("Guesses taken: " + GuessCount);
            }
        }
    }
}
