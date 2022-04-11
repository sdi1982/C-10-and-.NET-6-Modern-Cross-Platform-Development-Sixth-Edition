// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using static System.Console;

// TimeTable(10);
// decimal taxToPay = CalculateTax(amount: 149, twoLetterRegionCode: "FR");
// WriteLine($"You must pay {taxToPay:C} in tax.");
// RunCardinalToOrdinal();
RunFactorial();

static void TimeTable(byte number)
{
  WriteLine($"This is the {number} times table:");
  for (int row = 1; row <= 12; row++)
  {
    WriteLine($"{row} x {number} = {row * number}");
  }
  WriteLine();
}

static decimal CalculateTax(
  decimal amount, string twoLetterRegionCode)
{
  decimal rate = 0.0M;
  switch (twoLetterRegionCode)
  {
    case "CH":
      rate = 0.08M;
      break;
    case "DK":
    case "NO":
      rate = 0.25M;
      break;
    case "GB":
    case "FR":
      rate = 0.2M;
      break;
    case "HU":
      rate = 0.27M;
      break;
    case "OR":
    case "AK":
    case "MT":
      rate = 0.0M;
      break;
    case "ND":
    case "WI":
    case "ME":
    case "VA":
      rate = 0.05M;
      break;
    case "CA":
      rate = 0.0825M;
      break;
    default:
      rate = 0.06M;
      break;
  }
  return amount * rate;
}

static void RunCardinalToOrdinal()
{
  for (int number = 1; number <= 40; number++)
  {
    Write($"{CardinalToOrdinal(number)} ");
  }
  WriteLine();
}

/// <summary>
/// Pass a 32-bit integer and it will be converted int its ordinary equivalent.
/// </summary>
/// <param name="number">Number is a cardinal value e.g. 1, 2, 3, and so on.</param>
/// <returns>Number as an ordinal value e.g. 1st, 2nd, 3rd, and so on.</returns>
///
static string CardinalToOrdinal(int number)
{
  switch (number)
  {
    case 11:
    case 12:
    case 13:
      return $"{number}th";
    default:
      int lastDisit = number % 10;
      string suffix = lastDisit switch
      {
        1 => "st",
        2 => "nd",
        3 => "rd",
        _ => "th"
      };
      return $"{number}{suffix}";
  }
}

// Calculating factorials with recursion

static void RunFactorial()
{
  for (int i = 1; i < 15; i++)
    try
    {
      WriteLine($"{i}! = {Factorial(i):N0}");
    }
    catch (System.OverflowException)
    {
      WriteLine($"{i}! is too big for a 32-bit integer.");
    }
}

static int Factorial(int number)
{
  if (number < 1)
  {
    return 0;
  }
  else if (number == 1)
  {
    return 1;
  }
  else
    checked
    {
      return number * Factorial(number - 1);
    }
}
