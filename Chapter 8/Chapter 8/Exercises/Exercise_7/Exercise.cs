using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_8.Exercises.Exercise_7
{
    class Exercise : ConsoleMenu.Exercise
    {
        // [ Location , Time ]
        private List<double>[,] locationDepthTime = new List<double>[5,4];

        public override void Run()
        {
            Console.Clear();
            Console.WriteLine("Depth Recorder\n");
            Console.WriteLine(
                "Options\n" +
                "---------------------------\n" +
                " 0 - Surf City\n" +
                " 1 - Solomons\n" +
                " 2 - Hilton Head\n" +
                " 3 - Miami\n" +
                " 4 - Savannah\n\n" +
                " calc - Calculate Averages\n" +
                " done - exit Depth Recorder\n" +
                "---------------------------");
            Input();
        }

        private void Input()
        {
            Console.Write("Location: ");
            string input = Console.ReadLine();
            Console.Clear();
            if (input == "calc") 
            {
                AverageDepth();
                Console.WriteLine("Press 'ENTER' to return to menu.");
                Console.ReadLine();
                Run();
            }
            else if (input == "done") 
            {

            }
            else
            {
                int location = int.Parse(input);

                Console.WriteLine(WaterDepthLocation(location));
                Console.WriteLine("Time\n" +
                                  "------------------\n" +
                                  " 0 - 0700 (7 a.m.)\n" +
                                  " 1 - 1200 (noon)\n" +
                                  " 2 - 1700 (5 p.m.)\n" +
                                  " 3 - 2100 (9 p.m.)\n" +
                                  "------------------\n");
                Console.Write("Time: \t");
                int time = int.Parse(Console.ReadLine());
                Console.Clear();

                Console.WriteLine(WaterDepthLocation(location));
                Console.WriteLine(WaterDepthTime(time));
                Console.Write("Depth: ");
                if (locationDepthTime[location, time] == null) locationDepthTime[location, time] = new List<double>();
                locationDepthTime[location, time].Add(double.Parse(Console.ReadLine()));
                Run();
            }
        }

        private void AverageDepth()
        {
            for (int location = 0; location < 5; location++) 
            {
                List<double> totalAverageDepth =  new List<double>();
                Console.WriteLine("{0}\n-------------------------------", WaterDepthLocation(location).ToUpper());
                for (int time = 0; time < 4; time++) 
                {
                    if (locationDepthTime[location, time] == null) 
                        Console.WriteLine("{0,-13} - No Input", WaterDepthTime(time));
                    else 
                    {
                        double avg = locationDepthTime[location, time].Average();
                        Console.WriteLine("{0,-13} - {1}", WaterDepthTime(time), avg);
                        totalAverageDepth.Add(avg);
                    }
                }
                Console.WriteLine();
                if (totalAverageDepth.Count == 0) Console.WriteLine("Total Average Depth - No Data");
                else Console.WriteLine("Total Average Depth - {0}", totalAverageDepth.Average());
                Console.WriteLine("-------------------------------");
            }
        }

        private string WaterDepthLocation(int input)
        {
            switch (input) 
            {
                case 0:
                    return "Surf City";
                case 1:
                    return "Solomons";
                case 2:
                    return "Hilton Head";
                case 3:
                    return "Miami";
                case 4:
                    return "Savannah";
                default:
                    return "Invalid input.";
            }
        }

        private string WaterDepthTime(int input)
        {
            switch (input)
            {
                case 0:
                    return "0700 (7 a.m.)";
                case 1:
                    return "1200 (noon)";
                case 2:
                    return "1700 (5 p.m.)";
                case 3:
                    return "2100 (9 p.m.)";
                default:
                    return "Invalid input.";
            }
        }
    }
}
