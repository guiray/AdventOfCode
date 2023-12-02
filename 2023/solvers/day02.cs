using System;

namespace AdventOfCode2023;

public class Day02 : Base
{
    // day ID
    public override string CurrentDay => this.GetType().Name;

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


        Console.WriteLine("Part 2 = ");
    }

}

