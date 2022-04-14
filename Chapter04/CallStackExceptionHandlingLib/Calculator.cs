using System.Diagnostics;
using static System.Console;

// namespace CallStackExceptionHandlingLib;
namespace Packt;

public class Calculator
{
    public static void Gamma()
    {
        WriteLine("In Gamma");
        Delta();
    }

    private static void Delta()
    {
        WriteLine("In Delta");
        File.OpenText("bad file path");
    }
}