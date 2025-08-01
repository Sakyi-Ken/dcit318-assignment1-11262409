Console.WriteLine("***************************");
Console.WriteLine("*                         *");
Console.WriteLine("* Ticket Price Calculator *");
Console.WriteLine("*                         *");
Console.WriteLine("***************************");

string? readAge;
int age = 0;
bool validAge = false;
int ticketPrice = 10;
string ageInput;
string message = "";

do {
  Console.WriteLine("Please enter your age:");
  readAge = Console.ReadLine();
  if (readAge != null) 
  {
    ageInput = readAge.Trim();
    validAge = int.TryParse(ageInput, out age);
    if (validAge && age >= 0) 
    {
      if (age >= 65 || age <= 12)
      {
        ticketPrice = 7;
        message = $"You deserve a discounted ticket price of GHC{ticketPrice}";
     }
      else
      {
        message = $"You need to pay the full ticket price of GHC{ticketPrice}";
      }
    }
    else 
    {
      Console.WriteLine($"You entered {ageInput}. Please enter a valid age (0 or older).");
      validAge = false;
    }
  }
  else 
  {
    Console.WriteLine("Sorry, you entered an invalid age. Please try again.");
  }
} while (!validAge);
Console.WriteLine($"You entered {age} years and {message}.");
Console.WriteLine();
Console.WriteLine("Thank you for using the Ticket Price Calculator!");
Console.WriteLine("Press any key to exit.");
Console.ReadKey();