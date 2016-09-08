using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformsMenu
{
    public partial class Title : Form
    {
        static Form exercise = null;

        public Title()
        {
            InitializeComponent();
        }

        #region Exercise Button(s)
        private void ExerciseInstanceHandler(string ex) 
        {
            if (exercise == null)
            {
                ExerciseExecute(ex);
                exercise.Show();
            }
            else
            {
                exercise.Focus();
            }
        }

        private static void exercise_FormClosed(object sender, FormClosedEventArgs e)
        {
            exercise = null;
        }

        FormClosedEventHandler SetExerciseNull = exercise_FormClosed;

        private void ExerciseExecute(string ex)
        {
            switch (ex)
            {
                case "btnEx4":
                    exercise = new Chapter_9.Exercise_4();
                    break;
                case "btnEx5":
                    exercise = new Chapter_9.Exercises.Exercise_5();
                    break;
                case "btnEx7":
                    exercise = new Chapter_9.Exercises.Exercise_7();
                    break;
                case "btnEx10":
                    exercise = new Chapter_9.Exercises.Exercise_10();
                    break;
                default:
                    Environment.Exit(0);
                    break;
            }

            exercise.FormClosed += SetExerciseNull;
        }

        private void Exercise_Button_Click(object sender, EventArgs e)
        {
            ExerciseInstanceHandler(((Button)sender).Name);
        }
        #endregion
    }
}
