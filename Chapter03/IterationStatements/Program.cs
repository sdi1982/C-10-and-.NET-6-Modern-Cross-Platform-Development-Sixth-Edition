// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using static System.Console;

//// Looping with the while statement
// int x = 0;
// while (x < 10)
// {
//   WriteLine(x);
//   x++;
// }

//// Looping with the do statement
// string? password;
// do
// {
//   Write("Enter your password: ");
//   password = ReadLine();
// }
// while (password != "Pa$$w0rd");
// WriteLine("Correct!");

//Looping with the for statement
for (int y = 1; y <= 10; y++)
{
  WriteLine(y);
}

// Looping with the foreach statement
string[] names = { "Adam", "Barry", "Charlie" };
foreach (string name in names)
{
  WriteLine($"{name} has {name.Length} characters.");
}

