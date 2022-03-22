// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using static System.Console;
using static System.Convert;

// Casting numbers implicitly and explicitly
int a = 10;
double b = a;
WriteLine(b);

double c = 9.8;
//You must explicitly cast a double variable into an int variable
int d = (int)c;
WriteLine(d);

long e = 10;
int f = (int)e;
WriteLine($"e is {e:N0} and f is {f:N0}");
// e = long.MaxValue;
e = 5_000_000_000;
f = (int)e;
WriteLine($"e is {e:N0} and f is {f:N0}");

// Converting with the System.Convert type
double g = 9.8;
int h = ToInt32(g);
WriteLine($"g is {g} and h is {h}");

// Rounding numbers
double[] doubles = new[] { 9.49, 9.5, 9.51, 10.49, 10.5, 10.51 };
foreach (double n in doubles)
{
  WriteLine($"ToInt32({n}) is {ToInt32(n)}");
}

foreach (double n in doubles)
{
  WriteLine(format:
    "Math.Round({0}, 0, MidpointRounding.AwayFromZero) is {1}",
    arg0: n,
    arg1: Math.Round(value: n, digits: 0, mode: MidpointRounding.AwayFromZero));
}

// Converting from any type to a string
int number = 12;
WriteLine(number.ToString());

bool boolean = true;
WriteLine(boolean.ToString());

DateTime now = DateTime.Now;
WriteLine(now.ToString());

object me = new();
WriteLine(me.ToString());

// Converting from a binary object to a string
byte[] binaryObject = new byte[128];
(new Random()).NextBytes(binaryObject);
WriteLine("Binary Object as bytes:");
for (int index = 0; index < binaryObject.Length; index++)
{
  Write($"{binaryObject[index]:X} ");
}
WriteLine();
string encoded = ToBase64String(binaryObject);
WriteLine($"Binary Object as Base64: {encoded}");

// Parsing from strings to numbers or dates and times
int age = int.Parse("27");
DateTime birthday = DateTime.Parse("4 July 1980");
WriteLine($"I was born {age} years ago.");
WriteLine($"My birthday is {birthday}.");
WriteLine($"My birthday is {birthday:D}.");
WriteLine($"My birthday is {birthday:F}.");
WriteLine($"My birthday is {birthday:G}.");

// Errors using Parse
// int count = int.Parse("abc");

Write("How many eggs are there? ");
string? input = ReadLine();
if (int.TryParse(input, out int count))
{
  WriteLine($"There are {count} eggs.");
}
else
{
  WriteLine("I could not parse the input.");
}
