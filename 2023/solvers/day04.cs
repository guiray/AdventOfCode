using System;

namespace AdventOfCode2023;

public class Day04 : Base
{

    public Day04()
    {
        // simply to test
        Console.WriteLine(linesStr.Length);
    }

    public void Part1()
    {
        String[] separator = { ": ", " | " };

        for (int i = 0; i < linesStr.Length; i++)
        {
            //String[] gameSets = linesStr[i].Split(separator);
            String[] winningNumbersStr = linesStr[i].Split(" ", StringSplitOptions.TrimEntries);

            //int[] winningNumbers = Int32.Parse();
        }

        Console.WriteLine("Part 1 = ");
    }

    public void Part2()
    {


        Console.WriteLine("Part 2 = ");
    }

}

