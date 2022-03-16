// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using static System.Console;

int a = 3;
int b = a++;

WriteLine($"a is {a}, b is {b}");

int c = 3;
int d = ++c;

WriteLine($"c is {c}, d is {d}");

// Exploring binary arithmetic operators
int e = 11;
int f = 3;

WriteLine($"e is {e}, f is {f}");
WriteLine($"e + f = {e + f}");
WriteLine($"e - f = {e - f}");
WriteLine($"e * f = {e * f}");
WriteLine($"e / f = {e / f}");
WriteLine($"e % f = {e % f}");

double g = 11.0;
WriteLine($"g is {g}, f is {f}");
WriteLine($"g / f = {g / f}");

//Assignment operators
int p = 6;
WriteLine($"p is {p}");
WriteLine($"p + 3 = {p += 3}, p is {p}");
WriteLine($"p - 3 = {p -= 3}, p is {p}");
WriteLine($"p * 3 = {p *= 3}, p is {p}");
WriteLine($"p / 3 = {p /= 3}, p is {p}");
