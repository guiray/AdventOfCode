using System;
using System.Runtime.CompilerServices;

namespace AdventOfCode2023;

public class Day01 : Base
{
    public Day01()
    {
        
    }

    public void Part1()
    {
        int firstDigit = 0;
        int lastDigit = 0;

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
                    if (firstDigit == 0)
                    {
                        firstDigit = (int)Char.GetNumericValue(currentCharacter);
                    }
                    lastDigit = (int)Char.GetNumericValue(currentCharacter);
                }
            }
            total += (firstDigit * 10) + lastDigit;
            firstDigit = 0;
        }

        Console.WriteLine("Part 1 = " + total);
    }


    public void Part2()
    {
        string firstDigit = "";
        string lastDigit = "";
        int total = 0;

        string[] wordNumbers = { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "1", "2", "3", "4", "5", "6", "7", "8", "9" };

        for (int i = 0; i < linesStr.Length; i++)
        {
            string currentLine = linesStr[i];

            foreach (char s in currentLine)
            {
                Console.WriteLine(currentLine[3]);
            }

            int firstIndex = -1;
            int lastIndex = -1;

            /*for (int j = 0; j < wordNumbers.Length; j++)
            {
                int currentIndex = -1;

                if (currentLine.Contains(wordNumbers[j]))
                {
                    currentIndex = currentLine.IndexOf(wordNumbers[j]);
                    if (firstIndex < 0)
                    {
                        firstIndex = currentIndex;
                    }
                    if (lastIndex < 0)
                    {
                        lastIndex = currentIndex;
                    }
                }
                else if (currentLine.Contains((j + 1).ToString()))
                {
                    currentIndex = currentLine.IndexOf((j + 1).ToString());
                    if (firstIndex < 0)
                    {
                        firstIndex = currentIndex;
                        if (firstIndex < 0)
                        {
                            firstIndex = currentIndex;
                        }
                        if (lastIndex < 0)
                        {
                            lastIndex = currentIndex;
                        }
                    }
                }

                if (currentIndex < firstIndex)
                {
                    firstIndex = currentIndex;
                    firstDigit = (j+1).ToString();
                }
                else if (currentIndex > lastIndex)
                {
                    lastIndex = currentIndex;
                    lastDigit = (j+1).ToString();
                }
                
                

                Console.WriteLine("current word " + wordNumbers[j] +" first: " + firstDigit + " Last: "+ lastDigit);
            }
            


            total += Int32.Parse(firstDigit + lastDigit);
            firstDigit = "";*/
        }


        Console.WriteLine("Part 2 = " + total);
    }

}

