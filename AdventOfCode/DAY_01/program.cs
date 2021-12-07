string[] lines = File.ReadAllLines(@"D:\Documents\Github\AdventOfCode\AdventOfCode\DAY_01\input.txt");



foreach (string line in lines)
{
    // Use a tab to indent each line of the file.
    Console.WriteLine("\t" + line);
}


