using System;

namespace AdventOfCode2022
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                switch (args[0])
                {
                    case "day1_1":
                        Day1.SolveDay_Puzzle1();
                        break;
                    case "day1_2":
                        Day1.SolveDay_Puzzle2();
                        break;
                    default:
                        System.Console.WriteLine("Command not recognized");
                        break;
                }
            }
            else
            {
                System.Console.WriteLine("No commands entered");
            }
        }
    }
}
