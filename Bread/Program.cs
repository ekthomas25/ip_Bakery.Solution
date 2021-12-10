using System;
using Bakery.Models;

class Program
{
  static void Main()
  {
    Bread baguette = new Bread("baguette", 5);
    Console.WriteLine("Enter how many you'd like");
    string stringQuantity = Console.ReadLine();
    int quantity = int.Parse(stringQuantity);
  }
}



      // Console.WriteLine("Enter maximum price");
      // string stringMaxPrice = Console.ReadLine();
      // int maxPrice = int.Parse(stringMaxPrice);

      // List<Car> CarsMatchingSearch = new List<Car>(0);

      // foreach (Car automobile in Cars)
      // {
      //   if (automobile.WorthBuying(maxPrice))
      //   {
      //     CarsMatchingSearch.Add(automobile);
      //   }
      // }

      // foreach(Car automobile in CarsMatchingSearch)
      // {
      //   Console.WriteLine("----------------------");
      //   Console.WriteLine(automobile.GetMakeModel());
      //   Console.WriteLine(automobile.GetMiles() + " miles");
      //   Console.WriteLine("$" + automobile.GetPrice());