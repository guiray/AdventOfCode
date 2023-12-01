using System;
using System.Runtime.CompilerServices;

namespace AdventOfCode2023;

public class Day01 : Base
{
    // day ID
    public override string CurrentDay => this.GetType().Name;

    public Day01()
    {
        
    }

    public void Part1()
    {
        string firstDigit = "";
        string lastDigit = "";

        int total = 0;

        for (int i = 0; i < linesStr.Length; i++)
        {
            // current line in an char array
            char[] currentLine = linesStr[i].ToCharArray();
            
            for (int j = 0; j < currentLine.Length; j++)
            {
                char currentCharacter = currentLine[j];

                // check if current char is a number
                if (char.IsNumber(currentCharacter))
                {
                    if (firstDigit == "")
                    {
                        firstDigit = currentCharacter.ToString();
                    }
                    lastDigit = currentCharacter.ToString();
                }
            }
            total += Int32.Parse(firstDigit + lastDigit);
            firstDigit = "";
        }

        Console.WriteLine("Part 1 = " + total);
    }

    public void Part2()
    {


        Console.WriteLine("Part 2 = ");
    }

}

