
using System;
using System.Collections.Generic;

namespace AdventOfCode2022
{
    public class Day1_1
    {
        public static void SolveDay()
        {
            const string input = "puzzle_inputs/day1_1";

            var puzzleInput = InputListGenerator.readInputFileAsInt32s(input);

            var calorieList = new List<Int32>();

            int holder = 0;

            foreach (int i in puzzleInput)
            {
                if (i != 0)
                {
                    holder += i;
                }
                else
                {
                    calorieList.Add(holder);
                    holder = 0;
                }
            }

            calorieList.Sort();
            calorieList.Reverse();

            System.Console.WriteLine(calorieList[0].ToString());
        }
    }
}