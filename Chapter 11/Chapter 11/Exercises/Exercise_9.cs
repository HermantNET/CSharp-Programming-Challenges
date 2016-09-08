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
    public partial class Exercise_9 : Form
    {
        public Exercise_9()
        {
            InitializeComponent();

            Ex9.MovieTicket spookStreet = new Ex9.MovieTicket(DateTime.Today, DateTime.Today, "Spooky Street", DateTime.Now, "SS251", "MOVIE", "Regal Theatres", 14.99M);
            Ex9.HockeyTicket lghtVsSharks = new Ex9.HockeyTicket(DateTime.Today, DateTime.Today, "Lightning", "Sharks", "B44", DateTime.Now, "#111", "Grand Puck", "Tampa Ice", 18.50M);
            Ex9.ConcertTicket bts = new Ex9.ConcertTicket(DateTime.Today, DateTime.Today, "Bangtan Boys", 2, "BTS123", "Korea Worldwide", "Tampa Live", 22.99M);
            label1.Text = spookStreet.PrintTicket();
            label2.Text = lghtVsSharks.PrintTicket();
            label3.Text = bts.PrintTicket();
        }
    }
}
