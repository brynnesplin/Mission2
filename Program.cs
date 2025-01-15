

// See https://aka.ms/new-console-template for more information
// Brynn Esplin
// Section 001

using System;
using Mission2;

Console.WriteLine("Welcome to the dice throwing simulator!\nHow many dice rolls would you like to simulate?");

Rolls roll = new Rolls();
int numRolls = 0;
int[] rollResults;
int[] rollSum = new int[11];
int[] rollPct = new int[11];

numRolls = int.Parse(Console.ReadLine());

rollResults = roll.Roll(numRolls);

foreach (int rollResult in rollResults)
{
    if (rollResult == 2)
    {
        rollSum[0]++;
    }
    else if (rollResult == 3)
    {
        rollSum[1]++;
    }
    else if (rollResult == 4)
    {
        rollSum[2]++;
    }
    else if (rollResult == 5)
    {
        rollSum[3]++;
    }
    else if (rollResult == 6)
    {
        rollSum[4]++;
    }
    else if (rollResult == 7)
    {
        rollSum[5]++;
    }
    else if (rollResult == 8)
    {
        rollSum[6]++;
    }
    else if (rollResult == 9)
    {
        rollSum[7]++;
    }
    else if (rollResult == 10)
    {
        rollSum[8]++;
    }
    else if (rollResult == 11)
    {
        rollSum[9]++;
    }
    else if (rollResult == 12)
    {
        rollSum[10]++;
    }
}

for (int i = 0; i < rollSum.Length; i++)
{
    rollPct[i] = (int)(((double)rollSum[i]/numRolls) * 100);
}

Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS\nEach \"*\" represents 1% of the total number of rolls.\r\nTotal number of rolls = 1000.\n");
for (int i = 0;i < rollPct.Length; i++)
{
    int count = rollPct[i];
    string stars = new string('*', count);
    Console.WriteLine($"{i + 2}: {stars}");
}
Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
