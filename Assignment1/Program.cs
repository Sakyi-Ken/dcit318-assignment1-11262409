using System;
namespace Assignment1
{
  class Program
  {
    static void Main()
    {
      GradeCalculator gradeCalculator = new GradeCalculator();
      TicketPriceCalculator ticketPrice = new TicketPriceCalculator();
      TriangleTypeIdentifier triangleIdentifier = new TriangleTypeIdentifier();

      while (true)
      {
        Console.WriteLine("\n====Assignment 1 Menu =====");
        Console.WriteLine("1. Grade Calculator");
        Console.WriteLine("2. Ticket Price Calculator");
        Console.WriteLine("3. Triangle Type Identifier");
        Console.WriteLine("4. Exit");
        Console.WriteLine("Choose an option: ");

        string? choice = Console.ReadLine();

        switch (choice)
        {
          case "1":
            gradeCalculator.Run();
            break;
          case "2":
            ticketPrice.Run();
            break;
          case "3":
            triangleIdentifier.Run();
            break;
          case "4":
            return;
          default:
            Console.WriteLine("Invalid choice. Please try again");
            break;
        }
      }
    }
  }
}