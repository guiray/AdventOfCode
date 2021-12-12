using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.solvers
{
    internal class day03
    {
        private string[] linesStr;

        public day03()
        {
            linesStr = File.ReadAllLines(@"../../../Inputs/input_day03.txt");
        }

        public void Part1()
        {
            int counter;

            char[] averageBitgamma = new char[linesStr[0].Length];
            char[] averageBitepsilon = new char[linesStr[0].Length];

            string gamma;
            string epsilon;

            for (int i = 0; i < linesStr[0].Length; i++)
            {
                counter = 0;
                
                for (int j = 0; j < linesStr.Length; j++)
                {
                    char[] currentString = linesStr[j].ToCharArray();

                    if (currentString[i] == '1')
                    {
                        counter++;
                    }
                }

                if (counter > (linesStr.Length / 2))
                {
                    averageBitgamma[i] = '1';
                    averageBitepsilon[i] = '0';
                }
                else
                {
                    averageBitgamma[i] = '0';
                    averageBitepsilon[i] = '1';
                }
            }

            gamma = new string(averageBitgamma);
            epsilon = new string(averageBitepsilon);

            Console.WriteLine(Convert.ToInt32(gamma, 2) * Convert.ToInt32(epsilon, 2));

        }

        public void Part2()
        {
            Console.WriteLine("Part 2 = ");
        }


    }
}
