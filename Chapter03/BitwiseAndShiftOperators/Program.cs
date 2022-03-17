// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using static System.Console;

int a = 10;
int b = 6;

WriteLine($"a = {a}");
WriteLine($"b = {b}");
WriteLine($"a & b = {a & b}");
WriteLine($"a | b = {a | b}");
WriteLine($"a ^ b = {a ^ b}");

WriteLine($"a << 3 = {a << 3}");
WriteLine($"a * 8 = {a * 3}");
WriteLine($"b >> 1 = {b >> 1}");

WriteLine();
WriteLine("Outputing integers as binary");
WriteLine($"a =     {ToBinaryString(a)}");
WriteLine($"b =     {ToBinaryString(b)}");
WriteLine($"a & b = {ToBinaryString(a & b)}");
WriteLine($"a | b = {ToBinaryString(a | b)}");
WriteLine($"a ^ b = {ToBinaryString(a ^ b)}");

int age = 47;
char firstDisit = age.ToString()[0];

WriteLine($"FirstDisit of age is {firstDisit}");

static string ToBinaryString(int value)
{
  return Convert.ToString(value, toBase: 2).PadLeft(8, '0');
}