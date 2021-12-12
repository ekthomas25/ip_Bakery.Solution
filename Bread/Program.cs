using System;
using Bakery.Models;

class Program
{
  static void Main()
  {
    Console.WriteLine("Welcome to Pierre's Bakery! We sell Baguettes and Pains au chocolat!");
    Console.WriteLine("Baguettes are $5.00 and pains au chocolate are $2.00");
    Console.WriteLine("We're currently offering a 3 for 2 deal on baguettes and a buy 2 get 1 half off deal on pains au chocolat.");
    Console.WriteLine("");
    Console.WriteLine("How many baguettes would you like?");
    string stringBreadQty = Console.ReadLine();
    int breadQty = int.Parse(stringBreadQty);

    if (breadQty >= 0)
    {
      Console.WriteLine("How many pains au chocolat would you like?");
      string stringPastryQty = Console.ReadLine();
      int pastryQty = int.Parse(stringPastryQty);
      if (pastryQty == 0 && breadQty == 0)
      {
        Console.WriteLine("Why are you wasting my time?! Please order something!");
        Console.WriteLine("");
        Console.WriteLine("-------------------");
        Console.WriteLine("");
        Main();
      }
      else if (pastryQty > 0)
      {
        Bread newBread = new Bread(breadQty, 5);
        Pastry newPastry = new Pastry(pastryQty, 2);
        Console.WriteLine("Thank you so much for your business, here is your order and receipt");
        Console.WriteLine("-------------------");
        Console.WriteLine("Receipt:");
        Console.WriteLine("Baguettes:");
        Console.WriteLine($"Qty: {breadQty} = ${newBread.GetBreadCost()}.00");
        Console.WriteLine($"Pains au chocolat:");
        Console.WriteLine($"Qty: {pastryQty} = ${newPastry.GetPastryCost()}.00");
        Console.WriteLine($"Total: ${newPastry.GetPastryCost() + newBread.GetBreadCost()}.00");
        Console.WriteLine("-------------------");
      // Main();
      }
      else 
      {
        Console.WriteLine("Sorry, we don't accept orders less than 0.");
        Console.WriteLine("");
        Console.WriteLine("-------------------");
        Console.WriteLine("");
        Main();
      }
    }
    else
    {
      Console.WriteLine("Sorry, we don't accept orders less than 0.");
      Console.WriteLine("");
      Console.WriteLine("-------------------");
      Console.WriteLine("");
      Main();
    }
  }
}