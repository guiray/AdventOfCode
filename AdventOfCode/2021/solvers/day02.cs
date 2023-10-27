using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.solvers
{
    internal class day02
    {

        private string[] linesStr;
        private string[] commands;
        private int[] commandValues;

        public day02()
        {
            linesStr = File.ReadAllLines(@"../../../Inputs/input_day02.txt");

            commands = new string[linesStr.Length];
            commandValues = new int[linesStr.Length];

            for (int i = 0; i < linesStr.Length; i++)
            {
                var split = linesStr[i].Split(' ');
                commands[i] = split[0];
                commandValues[i] = int.Parse(split[1]);
            }

        }

        public void Part1()
        {
            int horizontalPos = 0;
            int depth = 0;

            for (int i = 0;i < linesStr.Length; i++)
            {
                if (commands[i] == "forward")
                {
                    horizontalPos += commandValues[i];
                }
                else if (commands[i] == "up")
                {
                    depth -= commandValues[i];
                }
                else if (commands[i] == "down")
                {
                    depth += commandValues[i];
                }
            }

            Console.WriteLine("depth = " + (depth));
            Console.WriteLine("horizontal position = " + (horizontalPos));
            Console.WriteLine("Part 1 = " + (depth * horizontalPos));

        }

        public void Part2()
        {
            int horizontalPos = 0;
            int depth = 0;
            int aim = 0;

            for (int i = 0; i < linesStr.Length; i++)
            {
                if (commands[i] == "forward")
                {
                    horizontalPos += commandValues[i];
                    depth += (aim * commandValues[i]);
                }
                else if (commands[i] == "up")
                {
                    aim -= commandValues[i];
                }
                else if (commands[i] == "down")
                {
                    aim += commandValues[i];
                }
            }

            Console.WriteLine("Part 2 = " + (depth * horizontalPos));

        }
    }
}
