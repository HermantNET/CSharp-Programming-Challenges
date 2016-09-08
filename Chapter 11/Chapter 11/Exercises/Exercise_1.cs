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
    public partial class Exercise_1 : Form
    {
        Ex1.FootballTeam footballTeam = new Ex1.FootballTeam("McHenry");
        Ex1.VolleyballTeam volleyballTeam = new Ex1.VolleyballTeam("Stuart");

        public Exercise_1()
        {
            InitializeComponent();
        }

        private void Exercise_1_Load(object sender, EventArgs e)
        {
            lblFootballCoach.Text = footballTeam.Coach;
            lblFootball.Text = footballTeam.Sport;
            lblFootballMotto.Text = footballTeam.Motto();
            lblFootballFact.Text = footballTeam.Fact;
            lblFootballHomeAway.Text = "Next game home or away? " + ((footballTeam.HomeOrAway()) ? "Home" : "Away");

            lblVolleyCoach.Text = volleyballTeam.Coach;
            lblVolleyMotto.Text = volleyballTeam.Sport;
            lblVolley.Text = volleyballTeam.Motto();
            lblVolleyHasNet.Text =  "Does " + volleyballTeam.Sport + " have a net? " + ((volleyballTeam.HasNet) ? "Yes" : "No") ;
            lblVolleyHomeAway.Text = "Next game home or away? " + ((volleyballTeam.HomeOrAway()) ? "Home" : "Away" );
        }
    }
}
