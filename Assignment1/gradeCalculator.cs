using System;
namespace Assignment1
{
  public class GradeCalculator
  {
    public void Run()
    {
   
      Console.WriteLine("********************");
      Console.WriteLine("*                  *");
      Console.WriteLine("* Grade Calculator *");
      Console.WriteLine("*                  *");
      Console.WriteLine("********************");

      string? readGrade;
      string numericalGrade;
      bool validGrade = false;
      int grade = 0;
      string letterGrade = "";

      do
      {
        Console.WriteLine("Please enter your grade (0 - 100):");
        readGrade = Console.ReadLine();
        if (readGrade != null)
        {
          numericalGrade = readGrade.Trim();
          validGrade = int.TryParse(numericalGrade, out grade);
          if (validGrade && grade >= 0 && grade <= 100)
          {
            if (grade >= 90)
            {
              letterGrade = "A";
            }
            else if (grade >= 80)
            {
              letterGrade = "B";
            }
            else if (grade >= 70)
            {
              letterGrade = "C";
            }
            else if (grade >= 60)
            {
              letterGrade = "D";
            }
            else
            {
              letterGrade = "F";
            }
          }
          else
          {
            Console.WriteLine($"You entered {numericalGrade}. Please enter a valid numerical grade between 0 and 100.");
            validGrade = false;
          }
        }
        else
        {
          Console.WriteLine("Sorry, you entered an invalid grade. Please try again.");
        }
      } while (!validGrade);
      Console.WriteLine($"You entered {grade} and the corresponding letter grade is {letterGrade}.");
      Console.WriteLine();
      Console.WriteLine("Thank you for using the Grade Calculator!");
      Console.WriteLine("Press any key to exit.");
      Console.ReadKey();
    }
  }
}