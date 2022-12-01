using System;
using System.Collections.Generic;
using System.IO;

namespace AdventOfCode2022
{
    public class InputListGenerator
    {
        public static List<Int32> readInputFileAsInt32s(String filepath)
        {
            List<Int32> returnList = new List<Int32>();
            using (var sr = new StreamReader(filepath))
            {
                var inputFile = File.ReadAllLines(filepath);
                foreach (string line in inputFile)
                {
                    int number = 0;
                    if (int.TryParse(line, out number))
                    {
                        returnList.Add(number);
                    }
                    else
                    {
                        returnList.Add(0);
                    }

                }

            }

            return returnList;


        }
    }
}