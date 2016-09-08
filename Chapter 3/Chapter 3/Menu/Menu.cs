using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMenu
{
    class Menu
    {
        private int currentSelection = 0;

        // Public properties to keep the Menu a hands off object, set the properties via an instantiated Menu object, not here
        List<string> options = new List<string>();
        public List<string> Options { get { return options; } set { options = value; } }

        private string title = "Default Title";
        public string Title { get { return title; } set { title = value; } }

        public void MenuLoad() 
        {
            DrawMenuOptions();

            // This is where the menu selection is handled.
            switch (Console.ReadKey().Key) 
            {
                case ConsoleKey.S:
                case ConsoleKey.DownArrow:
                    currentSelection++;
                    Console.Clear();
                    MenuLoad();
                    break;
                case ConsoleKey.W:
                case ConsoleKey.UpArrow:
                    currentSelection--;
                    Console.Clear();
                    MenuLoad();
                    break;
                case ConsoleKey.Spacebar:
                case ConsoleKey.Enter:
                    // Passes the current selections value
                    ExercisesHandler.ExerciseHandler(Options[currentSelection]);
                    break;
                default:
                    Console.Clear();
                    MenuLoad();
                    break;
            }
        }

        void DrawMenuOptions() 
        {
            int borderLargest = 0;

            if (currentSelection >= Options.Count) currentSelection = 0;
            else if (currentSelection < 0) currentSelection = Options.Count - 1;

            foreach (string option in Options) 
            {
                if (borderLargest < option.Length) borderLargest = option.Length + 2;
            };

            // Draw starts here
            TextWhiteOneBlue(Title);
            TextWhiteOneBlue("");

            BorderTopBottom(borderLargest);

            for (int i = 0; i < Options.Count; i++)
            {
                if (i == currentSelection)
                {
                    SelectedBox(Options[i], borderLargest);
                }
                else
                {
                    UnselectedBox(Options[i], borderLargest);
                }
            }

            BorderTopBottom(borderLargest);
        }

        void TextWhiteOneBlue(string value)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(value.PadRight(Console.WindowWidth - 1));
            Console.ResetColor();
        }

        void UnselectedBox(string value, int border)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("# {0}",value.PadRight(border).PadRight(border + 1, '#').PadRight(Console.WindowWidth - 3));
            Console.ResetColor();
        }

        void BorderTopBottom(int border)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("".PadRight(border + 3, '#').PadRight(Console.WindowWidth - 1));
            Console.ResetColor();
        }

        void SelectedBox(string value, int border)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("  ");

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(value);

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("".PadRight(Console.WindowWidth - value.Length - 3));
            Console.Write("\n");
            Console.ResetColor();
        }
    }
}
