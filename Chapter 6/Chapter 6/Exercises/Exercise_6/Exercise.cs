using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Chapter_6.Exercises.Exercise_6
{
    class Exercise : ConsoleMenu.Exercise
    {
        public override void Run()
        {
            Console.WriteLine("Phone Number Genie");
            string telNum = GetPhoneNum();
            Console.WriteLine("Alakazam!\n{0:(###) ###-####}", long.Parse(LetterToNumber(telNum)));
        }

        private string GetPhoneNum()
        {
            string result = "";
            for (int i = 0; i < 10; i++) 
            {
                Console.Write(result);
                var input = Console.ReadKey();
                Console.Clear();
                if (char.IsLetterOrDigit(input.KeyChar))
                    result += input.KeyChar;
                else if (result.Length > 0 && input.Key == ConsoleKey.Backspace) 
                {
                    result = result.Substring(0, result.Length - 1);
                    i -= 2;
                }
                else
                {
                    Console.WriteLine(" '{0}' is not valid.", input.KeyChar);
                    i--;
                }
            }
            return result;
        }

        private string LetterToNumber(string str)
        {
            str = str.ToUpper();
            StringBuilder result = new StringBuilder(str);
            for (int i = 0; i < result.Length; i++) 
            {
                if (char.IsLetter(result[i])) 
                {
                    result[i] = Letter(result[i]);
                }
            }
            return result.ToString();
        }

        private char Letter(char letter)
        {
            switch (letter) 
            {
                case 'A':
                case 'B':
                case 'C':
                    return '2';
                case 'D':
                case 'E':
                case 'F':
                    return '3';
                case 'G':
                case 'H':
                case 'I':
                    return '4';
                case 'J':
                case 'K':
                case 'L':
                    return '5';
                case 'M':
                case 'N':
                case 'O':
                    return '6';
                case 'P':
                case 'Q':
                case 'R':
                case 'S':
                    return '7';
                case 'T':
                case 'U':
                case 'V':
                    return '8';
                case 'W':
                case 'X':
                case 'Y':
                case 'Z':
                    return '9';
                default:
                    return letter;
            }
        }
    }
}
