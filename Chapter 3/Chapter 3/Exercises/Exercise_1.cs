using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleMenu;

namespace Chapter_3.Exercises
{
    class Exercise_1 : Exercise
    {
        private string name = "School";
        public string schoolName { get { return name; } set { name = value; } }

        private string desc = "Description about the school.";
        public string schoolDesc { get { return desc; } set { desc = value; } }

        private List<string> colors = new List<string>();
        public List<string> schoolColors { get { return colors; } set { colors = value; } }

        private int size = 40;
        public int messageSize { get { return size; } set { size = value; } }

        internal void Print()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine((schoolName + "\n").PadLeft(30));
            Console.ResetColor();

            Console.WriteLine("{0}\n\nSchool Colors:", Wrap(schoolDesc, messageSize));
            if (schoolColors.Count != 0)
            {
                foreach (string color in schoolColors)
                {
                    ColorSwitch(color);
                    Console.WriteLine(color.ToUpper().PadLeft(messageSize));
                }
                Console.ResetColor();
            }
        }

        public override void Run()
        {
            Print();
        }

        string Wrap(string str, int wrapEveryNumChar)
        {
            StringBuilder sb = new StringBuilder(str);
            for (int i = wrapEveryNumChar; i < sb.Length; i += wrapEveryNumChar)
            {
                if (sb[i] == ' ')
                {
                    sb[i] = '\n';
                }
                else
                {
                    int j = 0;
                    for (; sb[i + j] != ' '; j--) { }
                    sb[i + j] = '\n';
                }

            }
            return sb.ToString();
        }

        void ColorSwitch(string color)
        {
            switch (color.ToLower())
            {
                case "blue":
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case "white":
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
            }
        }
    }
}
