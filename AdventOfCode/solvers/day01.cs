using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.solvers
{
    public class day01
    {

        static string[] lines = File.ReadAllLines(@"../../../Inputs/input_day01.txt");

        

        public static void Part1()
        {
            int lastValue = 0;
            int currentValue = int.Parse(lines[0]);

            int counter = 0;
            for (int i = 1; i<lines.Length; i++)
            {

                if (currentValue > lastValue)
                {
                    counter++;
                }

                lastValue = currentValue;
                currentValue = int.Parse(lines[i]);

            }

            Console.WriteLine("Part 1 = " + counter);
        }

        public static void Part2()
        {

            Console.WriteLine("Part 2 = ");
        }


    }
}
