using System;

namespace AdventOfCode2023;

public class Day02 : Base
{
    public Day02()
    {
        
    }

    public void Part1()
    {
        int gameID;
        int isPossibleSum = 0;

        for (int i = 0; i < linesStr.Length; i++)
        {
            gameID = i+1;

            bool isPossible = true;

            // Split all sets of one game
            String[] separator = { "Game " + gameID + ": ", "; " }; 
            String[] gameSets = linesStr[i].Split(separator, StringSplitOptions.RemoveEmptyEntries);

            // for each set from one game
            for(int j = 0; j < gameSets.Length; j++)
            {
                String[] currentGameCubes = gameSets[j].Split(", ");

                // for each cube color in one set
                for (int k = 0; k < currentGameCubes.Length; k++)
                {
                    string[] currentCubeColor = currentGameCubes[k].Split(" ");
                    int currentCubeAmount = Int32.Parse(currentCubeColor[0]);

                    if ((currentCubeColor[1] == "blue" && currentCubeAmount > 14) || 
                        (currentCubeColor[1] == "red" && currentCubeAmount > 12) ||
                        (currentCubeColor[1] == "green" && currentCubeAmount > 13)) 
                    {
                        isPossible = false;
                    }
                }

            }

            if (isPossible)
            {
                isPossibleSum += gameID;
            }
            
        }

        Console.WriteLine("Part 1 = " + isPossibleSum);
    }

    public void Part2()
    {
        int gameID;
        int powerOfSetsSum = 0;

        for (int i = 0; i < linesStr.Length; i++)
        {
            gameID = i+1;

            // Split all sets of one game
            String[] separator = { "Game " + gameID + ": ", "; " }; 
            String[] gameSets = linesStr[i].Split(separator, StringSplitOptions.RemoveEmptyEntries);

            int minBlue = 0;
            int minRed = 0;
            int minGreen = 0;

            // for each set from one game
            for(int j = 0; j < gameSets.Length; j++)
            {
                String[] currentGameCubes = gameSets[j].Split(", ");

                // for each cube color in one set
                for (int k = 0; k < currentGameCubes.Length; k++)
                {
                    string[] currentCubeColor = currentGameCubes[k].Split(" ");
                    int currentCubeAmount = Int32.Parse(currentCubeColor[0]);

                    if (currentCubeColor[1] == "blue" && currentCubeAmount > minBlue)
                    {
                        minBlue = currentCubeAmount;
                    }
                    else if (currentCubeColor[1] == "red" && currentCubeAmount > minRed)
                    {
                        minRed = currentCubeAmount;
                    }
                    else if (currentCubeColor[1] == "green" && currentCubeAmount > minGreen)
                    {
                        minGreen = currentCubeAmount;
                    }
                    
                }

            }


            powerOfSetsSum += minBlue * minGreen * minRed;
            
        }

        Console.WriteLine("Part 2 = " + powerOfSetsSum);
    }

}

