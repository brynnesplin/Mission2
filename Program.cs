

// See https://aka.ms/new-console-template for more information
// Brynn Esplin
// Section 001

using System;
using Mission2;

// print welcome message
Console.WriteLine("Welcome to the dice throwing simulator!\nHow many dice rolls would you like to simulate?");

// create a new instance of the class Rolls
Rolls roll = new Rolls();
int numRolls = 0;
// create an empty list that will contain the sums of each roll
int[] rollResults;
// create two empty lists that will contain information about each of the possible 11 sums
int[] rollSum = new int[11];
int[] rollPct = new int[11];

// save the user input for the number of rolls as an integer numRolls
numRolls = int.Parse(Console.ReadLine());

// call the Roll class and save the result to rollResults
rollResults = roll.Roll(numRolls);

// loop through the rolls in rollResults and tally how many times each sum appears, save these tallies to the array rollSum
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

// calculate the percent of times each sum occurs and save to the array rollPct
for (int i = 0; i < rollSum.Length; i++)
{
    rollPct[i] = (int)(((double)rollSum[i]/numRolls) * 100);
}

// print the resulting histogram
Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS\nEach \"*\" represents 1% of the total number of rolls.\r\nTotal number of rolls = 1000.\n");

// for every percent saved in rollPct, save the value of that percent to the int count
// create a new string that is the character * repeated count times
for (int i = 0;i < rollPct.Length; i++)
{
    int count = rollPct[i];
    string stars = new string('*', count);
    Console.WriteLine($"{i + 2}: {stars}");
}
Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
