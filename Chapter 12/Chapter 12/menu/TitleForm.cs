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
                if (exercise != null)
                {
                    exercise.FormClosed += SetExerciseNull;
                    exercise.Show();
                }
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
                case "btnEx1":
                    //exercise = new Chapter_11.Exercises.Exercise_1();
                    break;
                case "btnEx9":
                    //exercise = new Chapter_11.Exercises.Exercise_9();
                    break;
                case "btnEx10":
                    //exercise = new Chapter_11.Exercises.Exercise_10();
                    break;
                default:
                    Environment.Exit(0);
                    break;
            }
        }

        private void Exercise_Button_Click(object sender, EventArgs e)
        {
            ExerciseInstanceHandler(((Button)sender).Name);
        }
        #endregion
    }
}
