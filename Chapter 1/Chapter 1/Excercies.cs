using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter_1
{
    class Exercises
    {
        internal static void Exercise(int num)
        {
            switch (num) { 
                case 1: 
                    Console.WriteLine("Enter your name: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Hello, {0}", name);
                    break;
                case 2:
                    Console.WriteLine("CCCCCCCCCCCC      ##   ##\n" +
                                      "CCC             ############\n" +
                                      "CCC               ##   ##\n" +
                                      "CCC             ###########\n" +
                                      "CCCCCCCCCCCC      ##   ##\n");
                    break;
                case 3:
                    Console.WriteLine("   (^;^)\n" +
                                      "  \\  |  / \n" +
                                      "   \\ | / \n" +
                                      "    \\|/ \n" +
                                      "     | \n" +
                                      "     | \n" +
                                      "    / \\ \n" +
                                      "   /   \\ \n");
                    break;
                case 4:
                    Console.WriteLine("***********************************\n" +
                                      "*    Programming Assignment 4     *\n" +
                                      "* Developer:        Thomas Herman *\n" +
                                      "* Date Submitted:          Aug 22 *\n" +
                                      "* Purpose: Internal Documentation *\n" +
                                      "***********************************\n");
                    break;
                case 5:
                    Console.WriteLine("********-----------\n" +
                                      "********-----------\n" +
                                      "********-----------\n" +
                                      "-------------------\n" +
                                      "-------------------\n" +
                                      "-------------------\n");
                    break;
                case 8:
                    Console.WriteLine("Enter your birth year");
                    var year = Console.ReadLine();
                    Console.WriteLine("\n{0}\n{1}\n{2}\n{3}", year[0], year[1], year[2], year[3]);
                    break;
                case 9:
                        Console.WriteLine("*********           *               *\n" +
                                          "*********          ***             ***\n" +
                                          "*********         ******          *****\n" +
                                          "*********       **********       *******\n" +
                                          "*********      ************     *********\n" +
                                          "*********     **************     *******\n" +
                                          "*********    ****************     *****\n" +
                                          "*********   ******************     ***\n" +
                                          "*********  ********************     *\n");
                    break;
            }     
        }

        // Options available when an exercise is run
        internal static void Options()
        {
            switch (Console.ReadLine())
            {
                case "menu":
                    Program.Menu();
                    break;
                case "exit":
                    Environment.Exit(0);
                    break;
                case "help":
                    Console.WriteLine("menu - return to menu" +
                                      "exit - exit application");
                    break;
                default:
                    Console.WriteLine("Invalid Input.");
                    Options();
                    break;
            }
        }
    }
}
