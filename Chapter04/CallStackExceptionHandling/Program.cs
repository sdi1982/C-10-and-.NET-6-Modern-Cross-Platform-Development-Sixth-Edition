// See https://aka.ms/new-console-template for more information

// Console.WriteLine("Hello, World!");

using Packt;
using static System.Console;

WriteLine("In Main");
Alpha();

static void Alpha()
{
    WriteLine("In Alpha");
    Beta();
}

static void Beta()
{
    WriteLine("In Beta");
    try
    {
        Calculator.Gamma();
    }
    catch (Exception ex)
    {
        WriteLine($"Caught this: {ex.Message}");
        // throw ex;
        throw;
        // throw new InvalidOperationException(
        //     message: "Calculation had invalid values. See inner exception for why.",
        //     innerException: ex);
    }
}