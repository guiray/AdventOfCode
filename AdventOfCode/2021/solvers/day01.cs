using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2021.solvers
{
    public class day01
    {
        private string[] linesStr;
        private int[] lines;

        public day01()
        {
            linesStr = File.ReadAllLines(@"../../../2021/Inputs/input_day01.txt");

            lines = Array.ConvertAll(linesStr, int.Parse);
        }

        public void Part1()
        {
            int lastValue = 0;
            int currentValue = lines[0];

            int counter = 0;

            for (int i = 1; i<lines.Length; i++)
            {

                if (currentValue > lastValue)
                {
                    counter++;
                }

                lastValue = currentValue;
                currentValue = lines[i];

            }

            Console.WriteLine("Part 1 = " + counter);
        }

        public void Part2()
        {

            int lastValue = 0;
            int currentValue = lines[0] + lines[1] + lines[2];

            int counter = 0;

            for (int i = 2; i < lines.Length; i++)
            {

                if (currentValue > lastValue)
                {
                    counter++;
                }

                lastValue = currentValue;
                currentValue = lines[i] + lines[i - 1] + lines[i - 2];
            }

            Console.WriteLine("Part 2 = " + counter);
        }

    }
}
