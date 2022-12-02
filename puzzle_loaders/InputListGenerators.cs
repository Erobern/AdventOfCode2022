using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode2022
{
    public class InputListGenerators
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

        public static List<KeyValuePair<String, String>> readInputFileAsStringStringKVPList(String filepath)
        {
            List<KeyValuePair<String, String>> returnList = new List<KeyValuePair<string, string>>();
            using (var sr = new StreamReader(filepath))
            {
                var inputFile = File.ReadAllLines(filepath);
                foreach (string line in inputFile)
                {
                    var split = line.Split(" ");
                    returnList.Add(new KeyValuePair<string, string>(split[0], split[1]));
                }
            }

            return returnList;
        }
    }
}