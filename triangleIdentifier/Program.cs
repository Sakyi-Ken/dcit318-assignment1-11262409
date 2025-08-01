Console.WriteLine("****************************");
Console.WriteLine("*                          *");
Console.WriteLine("* Triangle Type Identifier *");
Console.WriteLine("*                          *");
Console.WriteLine("****************************");

string? readSide;
int side1 = 0;
int side2 = 0;
int side3 = 0;
bool validSide = false;
string sideInput;

while (!validSide)
{
  Console.WriteLine("Enter the first side of the triangle");
  readSide = Console.ReadLine();
  if (readSide != null)
  {
    sideInput = readSide.Trim();
    validSide = int.TryParse(sideInput, out side1);
  }

  Console.WriteLine("Enter the second side of the triangle");
  readSide = Console.ReadLine();
  if (readSide != null)
  {
    sideInput = readSide.Trim();
    validSide = int.TryParse(sideInput, out side2);
  }

  Console.WriteLine("Enter the third side of the triangle");
  readSide = Console.ReadLine();
  if (readSide != null)
  {
    sideInput = readSide.Trim();
    validSide = int.TryParse(sideInput, out side3);

    if ((validSide) && (side1 <= 0 || side2 <= 0 || side3 <= 0))
    {
      Console.WriteLine($"None of the sides should be less than or equal to zero");
      validSide = false;
    }
    if (side1 == side2 && side2 == side3)
    {
      Console.WriteLine($"Equilateral - All three sides are equal");
    }
    else if (side1 == side2 || side2 == side3 || side3 == side1)
    {
      Console.WriteLine($"Isosceles - Two sides are equal");
    }
    else 
    {
      Console.WriteLine("Scalene - None of the sides are equal");
    }
  } 
  else
  {
    Console.WriteLine("Sorry, You punched an invalid side. Please try again.");
  }
}