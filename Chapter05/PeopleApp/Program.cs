﻿// See https://aka.ms/new-console-template for more information

// Console.WriteLine("Hello, World!");

using Packt.Shared;
using static System.Console;

Person bob = new();
WriteLine(bob.ToString());

bob.Name = "Bob Smith";
bob.DateOfBirth = new DateTime(1965, 12, 22);
WriteLine(format: "{0} was born on {1:dddd, d MMMM yyyy}",
    arg0: bob.Name,
    arg1: bob.DateOfBirth);
    
Person alice = new()
{
    Name = "Alice Jones",
    DateOfBirth = new(1998, 3, 7)
};

WriteLine(format: "{0} was born on {1:dd MMM yy}",
    arg0: alice.Name,
    arg1: alice.DateOfBirth);
    
bob.FavoriteAncientWonder = WondersOfTheAncientWorld.StatueOfZeusAtOlympia;
WriteLine(
    format: "{0}'s favorite wonder is {1}. Its integer is {2}.",
    arg0: bob.Name,
    arg1: bob.FavoriteAncientWonder,
    arg2: (int)bob.FavoriteAncientWonder);

bob.BucketList = WondersOfTheAncientWorld.HangingGardensOfBabylon
                 | WondersOfTheAncientWorld.MausoleumAtHalicarnassus;

WriteLine($"{bob.Name}'s bucket list is {bob.BucketList}");

// Storing multiple values using collections
bob.Children.Add(new Person { Name = "Alfred" });
bob.Children.Add(new Person { Name = "Zoe"});
WriteLine($"{bob.Name} has {bob.Children.Count} children:");

for (int childIndex = 0; childIndex < bob.Children.Count; childIndex++)
{
    WriteLine($" {bob.Children[childIndex].Name}");
}

BankAccount.interestRate = 0.012M;
BankAccount jonesAccount = new();
jonesAccount.AccountName = "Mrs. Jones";
jonesAccount.Balance = 2400;
WriteLine(format: "{0} earned {1:C} interest.",
    arg0: jonesAccount.AccountName,
    arg1: jonesAccount.Balance * BankAccount.interestRate);

BankAccount gerrierAccout = new();
gerrierAccout.AccountName = "Ms.Gerrier";
gerrierAccout.Balance = 98;
WriteLine(format: "{0} earned {1:C} interest.",
    gerrierAccout.AccountName,
    gerrierAccout.Balance * BankAccount.interestRate);

WriteLine($"{bob.Name} is a {Person.Species}");

WriteLine($"{bob.Name} was born on {bob.HomePlanet}");

Person blankPerson = new();
WriteLine(format: "{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}.",
    blankPerson.Name,
    blankPerson.HomePlanet,
    blankPerson.Instantiated);

Person gummy = new(initialName: "Gummy", homePlanet: "Mars");
WriteLine(format: "{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}.",
    gummy.Name,
    gummy.HomePlanet,
    gummy.Instantiated);

bob.WriteToConsole();
WriteLine(bob.GetOrigin());

(string, int) fruit = bob.GetFruit();
WriteLine($"{fruit.Item1}, {fruit.Item2} there are.");

var fruitNamed = bob.GetNamedFruit();
WriteLine($"There are {fruitNamed.Number} {fruitNamed.Name}");

// Inferring tuple names
var thing1 = ("Neville", 4);
WriteLine($"{thing1.Item1} has {thing1.Item2} children.");
var thing2 = (bob.Name, bob.Children.Count);
WriteLine($"{thing2.Name} has {thing2.Count} children.");

// Deconstructing tuples
(string fruitName, int fruitNumber) = bob.GetFruit();
WriteLine($"Deconstructed: {fruitName}, {fruitNumber}");

// Deconstructing types
// Deconstructing a Person
var (name1, dob1) = bob;
WriteLine($"Deconstructed: {name1}, {dob1}");
var (name2, dob2, fav2) = bob;
WriteLine($"Deconstructed: {name2}, {dob2}, {fav2}");

// Defining and passing parameters to methods
WriteLine(bob.SayHello());
WriteLine(bob.SayHello("Emily"));

// Passing optional and named parameters
WriteLine((bob.OptionalParameters()));
WriteLine(bob.OptionalParameters("Jump!", 98.5));
WriteLine(bob.OptionalParameters(number: 52.7, command: "Hide!"));
WriteLine(bob.OptionalParameters("Poke!", active: false));

// Controlling how parameters are passed
int a = 10;
int b = 20;
int c = 30;

WriteLine($"Before: a = {a}, b = {b}, c = {c}");
bob.PassingParameters(a, ref b, out c);
WriteLine($"After: a = {a}, b = {b}, c = {c}");

//Simplified out parameters
int d = 10;
int e = 20;
WriteLine($"Before: d = {d}, e = {e}, f doesn't exist yet!");
bob.PassingParameters(d, ref e, out int f);
WriteLine($"After: d = {d}, e = {e}, f = {f}");

// Defining read-only properties
Person sam = new()
{
    Name = "Sam",
    DateOfBirth = new(1972, 1, 27)
};
WriteLine(sam.Origin);
WriteLine(sam.Greeting);
WriteLine(sam.Age);

sam.FavoriteIceCream = "Chocalate Fudge";
WriteLine($"Sam's favorite ice-cream flavor is {sam.FavoriteIceCream}.");
sam.FavoritePrimaryColor = "red";
WriteLine($"Sam's favorite primary color is {sam.FavoritePrimaryColor}.");

sam.Children.Add(new() { Name = "Charlie"});
sam.Children.Add(new() { Name = "Ella"});

WriteLine($"Sam's first child is {sam.Children[0].Name}");
WriteLine($"Sam's second child is {sam.Children[1].Name}");
WriteLine($"Sam's first child is {sam[0].Name}");
WriteLine($"Sam's second child is {sam[1].Name}");

// Pattern matching with objects
// Creating and referencing a .NET 6 class library

object[] passengers =
{
    new FirstClassPassenger { AirMiles = 1_419 },
    new FirstClassPassenger { AirMiles = 16_562 },
    new BusinessClassPassenger(),
    new CoachClassPassenger { CarryOnKG = 25.7 },
    new CoachClassPassenger { CarryOnKG = 0},
};

foreach (object passenger in passengers)
{
    decimal flightCost = passenger switch
    {
        // FirstClassPassenger p when p.AirMiles > 35000 => 1500M,
        // FirstClassPassenger p when p.AirMiles > 15000 => 1750M,
        // FirstClassPassenger _ => 2000M,
        // FirstClassPassenger p => p.AirMiles switch
        // {
        //     > 35000 => 1500M,
        //     > 15000 => 1750M,
        //     _ => 2000M
        // },
        FirstClassPassenger { AirMiles: > 35000} => 1500M,
        FirstClassPassenger { AirMiles: > 15000} => 1750M,
        FirstClassPassenger => 2000M,
        BusinessClassPassenger _ => 1000M,
        CoachClassPassenger p when p.CarryOnKG < 10.0 => 500M,
        CoachClassPassenger _ => 650M,
        _ => 800M
    };
    WriteLine($"Flight costs {flightCost:C} for {passenger}");
}