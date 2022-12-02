
using System;
using System.Collections.Generic;

namespace AdventOfCode2022
{
    public class Day2
    {
        public static void SolveDay_Puzzle1()
        {
            const string input = "puzzle_inputs/day2";

            var puzzleInput = InputListGenerators.readInputFileAsStringStringKVPList(input);

            // x = rock, y = paper, z = scissors
            // a = rock, b = paper, c = scissors
            int score = 0;

            foreach (var kvp in puzzleInput)
            {
                score += kvp.Value == "X" ? 1 : kvp.Value == "Y" ? 2 : 3;
                if (kvp.Key == "A" && kvp.Value == "X" ||
                kvp.Key == "B" && kvp.Value == "Y" ||
                kvp.Key == "C" && kvp.Value == "Z")
                {
                    score += 3;
                }
                else if (kvp.Key == "A" && kvp.Value == "Y" ||
                kvp.Key == "B" && kvp.Value == "Z" ||
                kvp.Key == "C" && kvp.Value == "X")
                {
                    score += 6;
                }
            }

            System.Console.WriteLine(score);


        }

        public static void SolveDay_Puzzle2()
        {
            const string input = "puzzle_inputs/day2";

            var puzzleInput = InputListGenerators.readInputFileAsStringStringKVPList(input);

            // X means you need to lose, Y means you need to end the round in a draw, and Z means you need to win.
            // a = rock, b = paper, c = scissors
            // 1 for Rock, 2 for Paper, and 3 for Scissors

            int score = 0;

            foreach (var kvp in puzzleInput)
            {
                // add score for match result
                score += kvp.Value == "Y" ? 3 : (kvp.Value == "Z" ? 6 : 0);

                // add score for object played
                if (kvp.Value == "X")
                {
                    // we lose
                    if (kvp.Key == "A")
                    {
                        score += 3;
                    }
                    else if (kvp.Key == "B")
                    {
                        score += 1;
                    }
                    else
                    {
                        score += 2;
                    }
                }
                else if (kvp.Value == "Y")
                {
                    // we draw
                    if (kvp.Key == "A")
                    {
                        score += 1;
                    }
                    else if (kvp.Key == "B")
                    {
                        score += 2;
                    }
                    else
                    {
                        score += 3;
                    }
                }
                else
                {
                    // we win
                    if (kvp.Key == "A")
                    {
                        score += 2;
                    }
                    else if (kvp.Key == "B")
                    {
                        score += 3;
                    }
                    else
                    {
                        score += 1;
                    }
                }
            }

            System.Console.WriteLine(score);


        }
    }
}