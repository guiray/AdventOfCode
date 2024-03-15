using System;

namespace AdventOfCode2023;

public class Day10 : Base
{

    public Day10()
    {
        // simply to test
        Console.WriteLine(linesStr.Length);
    }

    public void Part1()
    {
        /*
        | is a vertical pipe connecting north and south.
        - is a horizontal pipe connecting east and west.
        L is a 90-degree bend connecting north and east.
        J is a 90-degree bend connecting north and west.
        7 is a 90-degree bend connecting south and west.
        F is a 90-degree bend connecting south and east.
        . is ground; there is no pipe in this tile.
        S is the starting position of the animal; there is a pipe on this tile, but your sketch doesn't show what shape the pipe has.
        */

        private string NORTH_SOUTH = "|";
        private string EAST_WEST = "-";
        private string NORTH_EAST = "L";
        private string NORTH_WEST = "J";
        private string SOUTH_WEST = "7";
        private string SOUTH_EAST = "F";
        private string GROUND = ".";
        private string STARTING_POS = "S";

        Console.WriteLine("Part 1 = ");
    }

    public void Part2()
    {


        Console.WriteLine("Part 2 = ");
    }

}

