using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.solvers
{
    public class day01
    {

        string[] lines = File.ReadAllLines(@"../../../Inputs/input_day01.txt");

        

        public void Part1()
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

        public void Part2()
        {

            int lastValue = 0;
            int currentValue = int.Parse(lines[0]) + int.Parse(lines[1]) + int.Parse(lines[2]);

            int value1;
            int value2;
            int value3;

            int counter = 0;


            for (int i = 2; i < lines.Length; i++)
            {

                if (currentValue > lastValue)
                {
                    counter++;
                }

                value1 = int.Parse(lines[i]);
                value2 = int.Parse(lines[i-1]);
                value3 = int.Parse(lines[i-2]);

                lastValue = currentValue;
                currentValue = value1 + value2 + value3;
                //Console.WriteLine("Part 2 = " + currentValue);
            }


            Console.WriteLine("Part 2 = " + counter);
        }


    }
}
