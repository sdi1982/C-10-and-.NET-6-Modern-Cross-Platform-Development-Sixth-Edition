// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using static System.Console;

TimeTable(10);

static void TimeTable(byte number)
{
  WriteLine($"This is the {number} times table:");
  for (int row = 1; row <= 12; row++)
  {
    WriteLine($"{row} x {number} = {row * number}");
  }
  WriteLine();
}
