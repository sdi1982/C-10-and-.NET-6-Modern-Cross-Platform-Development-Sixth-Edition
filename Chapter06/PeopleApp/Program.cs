// See https://aka.ms/new-console-template for more information

// Console.WriteLine("Hello, World!");

using System.Diagnostics;
using Packt.Shared;
using static System.Console;

Person harry = new() { Name = "Harry" };
Person mary = new() { Name = "Mary" };
Person jill = new() { Name = "Jill" };

Person baby1 = mary.ProcreateWith(harry);
baby1.Name = "Gary";

Person baby2 = Person.Procreate(harry, jill);
Person baby3 = harry * mary;
WriteLine($"{harry.Name} has {harry.Children.Count} children.");
WriteLine($"{mary.Name} has {mary.Children.Count} children.");
WriteLine($"{jill.Name} has {jill.Children.Count} children.");

WriteLine(
    format: "{0}'s first child is named \"{1}\".",
    arg0: harry.Name,
    arg1: harry.Children[0].Name);

WriteLine($"5! is {Person.Factorial(5)}");

// Raising and handling events
// Calling methods using delegates

// Person p1 = new();
// int answer = p1.MethodIWantToCall("Frog");
// WriteLine($"Answer is {answer}");

static void Harry_Shout(object? sender, EventArgs e)
{
    if (sender is null) return;
    Person p = (Person)sender;
    WriteLine($"{p.Name} is this angry: {p.AngerLevel}.");
}

harry.Shout += Harry_Shout;
harry.Poke();
harry.Poke();
harry.Poke();
harry.Poke();

// Making types safely reusable with generics
System.Collections.Hashtable lookupObject = new();
lookupObject.Add(key: 1, value: "Alpha");
lookupObject.Add(key: 2, value: "Beta");
lookupObject.Add(key: 3, value: "Gamma");
lookupObject.Add(key: harry, value: "Delta");

int key = 2;
WriteLine(format: "Key {0} has value: {1}",
    arg0: key,
    arg1: lookupObject[key]);

WriteLine(format: "Key {0} has value: {1}",
    arg0: harry,
    arg1: lookupObject[harry]);
    
// generic lookup collection
Dictionary<int, string> lookupIntString = new();
lookupIntString.Add(key: 1, value: "Alpha");
lookupIntString.Add(key: 2, value: "Beta");
lookupIntString.Add(key: 3, value: "Gamma");
lookupIntString.Add(key: 4, value: "Delta");

key = 3;
WriteLine(format: "Key {0} has value: {1}",
    arg0: key,
    arg1: lookupIntString[key]);
    
Person[] people =
{
    new() { Name = "Simon"},
    new() { Name = "Jenny"},
    new() { Name = "Adam"},
    new() { Name = "Richard"}
};

// Implementing interfaces
//// Comparing objects when sorting

WriteLine("Initial list of people");
foreach (Person p in people)
{
    WriteLine($"  {p.Name}");
}
WriteLine("Use Person's IComparable implementation to sort:");
Array.Sort(people);
foreach (Person p in people)
{
    WriteLine($"  {p.Name}");
}

//// Comparing objects using a separate class

WriteLine("Use PersonComparer's IComparer implementation to sort: ");
Array.Sort(people, new PersonComparer());
foreach (Person p in people)
{
    WriteLine($"  {p.Name}");
}

//// Defining struct types

DisplacementVector dv1 = new(3, 5);
DisplacementVector dv2 = new(-2, 7);
DisplacementVector dv3 = dv1 + dv2;
WriteLine($"({dv1.X}, {dv1.Y}) + ({dv2.X}, {dv2.Y}) = {dv3.X}, {dv3.Y}");

//// Inheriting from classes

Employee john = new()
{
    Name = "John Jones",
    DateOfBirth = new(year: 1990, month: 7, day: 28)
};

john.WriteToConsole();

//// Extending classes to add functionality
john.EmployeeCode = "JJ001";
john.HireDate = new(year: 2014, month: 11, day: 23);
WriteLine($"{john.Name} was hired on {john.HireDate:dd/MM/yy}");
