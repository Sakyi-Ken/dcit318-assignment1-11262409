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
int count = 0;

while (!validSide)
{
  bool done = false;
  int side;

  while (!done && count < 3) {
    count += 1;
    if (count == 1) 
    {
      Console.WriteLine("Enter the first side of the triangle");
    }
    else if (count == 2)
    {
      Console.WriteLine("Enter the second side of the triangle");
    }
    else
    {
      Console.WriteLine("Enter the third side of the triangle");
    }

    readSide = Console.ReadLine();
    if (readSide != null)
    {
      sideInput = readSide.Trim();
      validSide = int.TryParse(sideInput, out side);
    
      if (!validSide || side <= 0) 
      {
       Console.WriteLine($"You entered {sideInput} for side {count}. Please enter a number greater than 0");
       validSide = false;
       done = true;
       count -= 1;
      }
      else if (count == 1)
      {
        side1 = side;
      }
      else if (count == 2)
      {
        side2 = side;
      }
      else
      {
        side3 = side;
      }
    }
    else
    {
      Console.WriteLine("Sorry, you entered an invalid side. Please try again.");
      done = true;
      count -= 1;
    }
  }
  
}
if (side1 == side2 && side2 == side3)
{
  Console.WriteLine($"This is an Equilateral triangle - All three sides are equal ({side1}, {side2} and {side3})");
}
else if (side1 == side2 || side2 == side3 || side3 == side1)
{
  Console.WriteLine($"This is an Isosceles triangle - Two sides are equal ({side1}, {side2} and {side3})");
}
else 
{
  Console.WriteLine($"This is a Scalene triangle - None of the sides are equal ({side1}, {side2} and {side3})");
}
Console.WriteLine("Thank you for using the Triangle Type Identifier!");
Console.WriteLine("Press any Enter key to quit.");
readSide = Console.ReadLine();