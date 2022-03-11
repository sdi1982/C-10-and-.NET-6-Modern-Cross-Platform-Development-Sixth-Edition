// See https://aka.ms/new-console-template for more information

object height = 1.88;
object name = "Amir";

Console.WriteLine($"{name} is {height} metres tall.");

// int length1 = name.Length;
int length2 = ((string)name).Length;

Console.WriteLine($"{name} has {length2} characters.");

dynamic something = "Ahmed";
Console.WriteLine($"Length is {something.Length}");

something = new[] { 3, 5, 7 };
Console.WriteLine($"Length is {something.Length}");

Console.WriteLine($"default(int) = {default(int)}");
Console.WriteLine($"default(bool) = {default(bool)}");
Console.WriteLine($"default(DateTime) = {default(DateTime)}");
Console.WriteLine($"default(string) = {default(string)}");

int number = 13;
Console.WriteLine($"number has been set to: {number}");
number = default;
Console.WriteLine($"number has been reset to its default: {number}");

string[] names;
names = new string[4];

names[0] = "Kate";
names[1] = "Jack";
names[2] = "Rebecca";
names[3] = "Tom";

string[] names2 = new[] { "Kenji", "Ayako", "Lisa", "Maco" };

for (int i = 0; i < names.Length; i++)
{
  Console.WriteLine(names[i]);
  Console.WriteLine(names2[i]);
}


