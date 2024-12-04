using System;

namespace AdventOfCode2023;

public class Day03 : Base
{

    public Day03()
    {
        
    }

    public void Part1()
    {
        int total = 0;

        for (int i = 0; i < linesStr.Length; i++)
        {
            
            //char[] lineAbove = linesStr[i-1].ToCharArray();
            char[] lineCurrent = linesStr[i].ToCharArray();
            //char[] lineBellow = linesStr[i+1].ToCharArray();

            int firstNumberIndex = -1;
            int numberLength = 1;

            bool isNumber = false;

            for (int j = 0; j < lineCurrent.Length; j++)
            {
                char currentCharacter = lineCurrent[j];
                
                // check if current char is a number
                if (char.IsNumber(currentCharacter) && !isNumber)
                {
                    isNumber = true;
                    firstNumberIndex = j;
                    numberLength = 1;
                }
                else if (!char.IsNumber(currentCharacter) && isNumber)
                {
                    isNumber = false;

                    total += Int32.Parse( linesStr[i].Substring(firstNumberIndex, numberLength));

                    lookAround(i, firstNumberIndex, numberLength);
                }
                else if (isNumber) 
                {
                    numberLength++;
                }
            }
            


        }

        Console.WriteLine("Part 1 = " + total);
    }

    public void lookAround(int currentLine, int numberPosition, int numberLength)
    {
        char[] lineCurrent = linesStr[currentLine].ToCharArray();

        int firstLine = currentLine - 1;
        int lastLine = currentLine + 1;

        if (currentLine > 0)
        {
            firstLine = currentLine;
            //char[] lineAbove = linesStr[currentLine-1].ToCharArray();
        }
        if (currentLine < linesStr.Length -1)
        {
            lastLine = currentLine;
            //char[] lineBellow = linesStr[currentLine+1].ToCharArray();
        }

        for (int x = numberPosition; x < numberPosition + numberLength; x++)
        {
            for (int y = firstLine; y <= lastLine; y++)
            {
                Console.WriteLine();
            }
        }

        
    }

    public void Part2()
    {


        Console.WriteLine("Part 2 = ");
    }

}

