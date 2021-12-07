
string[] lines = File.ReadAllLines(@"D:\Documents\Github\AdventOfCode\AdventOfCode\DAY_01\input.txt");

int lastValue = 0;
int currentValue = int.Parse(lines[0]);

int counter = 0;


for (int i = 1; i < lines.Length; i++)
{

    if (currentValue > lastValue)
    {
        counter++;
    }

    lastValue = currentValue;
    currentValue = int.Parse(lines[i]);

}

Console.WriteLine("Part 1 = " + counter);
