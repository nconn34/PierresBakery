using System;
using Bakery.Logic;

namespace PierresBakery
{
    public class Program
    {
          public static void Main()
     {
         Console.WriteLine("Welcome to Pierre's Bakery!");
         Console.Write("Which would you like today? Type 'b' for bread or 'p' for pastry: ");
         string choice = Console.ReadLine();
         string decision = choice.ToLower();
         if (decision == "b")
         {
             Console.WriteLine("How many loaves of bread would you like? ");
             int loafCount = int.Parse(Console.ReadLine());
             int total = Bread.costOfBread(loafCount);
             Console.WriteLine("Your total is: {0:C}\n", total);
         }
         else if (decision == "p")
         {
            Console.WriteLine("How many pastries would you like? ");
             int pastryCount = int.Parse(Console.ReadLine());
             int total = Pastry.costOfPastry(pastryCount);
             Console.WriteLine("Your total is: {0:C}\n", total);
         }
         else
         {
             Console.WriteLine("Goodbye!");
         }
     }
    }
}