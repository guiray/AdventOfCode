using System;

namespace AdventOfCode2023;

public abstract class Base 
{
    // get day ID
    //public abstract int CurrentDay { get; }
    public abstract string CurrentDay { get; }

    // input file access for other classes
    protected string[] linesStr;

    public Base()
    {
        // read input file from current day ID
        linesStr = File.ReadAllLines("../../../2023/inputs/input_" + CurrentDay + ".txt");
    }

}