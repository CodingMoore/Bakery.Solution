using System.Collections.Generic;
using System;

namespace BakeryUI
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery!");
      Order();
    }  
    
    public static Order()
    {
      Console.WriteLine("To add some bread to your cart, please type 'bread'.");
      Console.WriteLine("To add some pastry to your cart, please Type 'pastry'.");
      Console.WriteLine("To puchase the items in your cart, please type 'purchase'.");
      Console.WriteLine("To empty your cart, please type 'restart'.");
      CartReport();
      string custInput = Console.ReadLine();
      if (custInput == "bread")
      {
        BreadList();
      }
      else if (custInput == "pastry")
      {
        PastryList();
      }
      else if (custInput == "puchase")
      {
        Purchase();
      }
      else if (custInput == "restart")
      {
        Main();
      }
      else
      {
        Console.WriteLine("That is not a valid input.");
        Order();
      }
    } 

    public static CartReport()
    {
      if (Cart is empty)
      {
        Console.WriteLine("Your shopping cart is empty.");
      }
      else 
      {
        Console.WriteLine("Your shopping cart contains...");
        Console.WriteLine(Cart contents);
        Console.WriteLine("Your total comes to...");
        Console.WriteLine(Total Cost);
      }
    }

    public static BreadList()
    {
      // Console.WriteLine("We currently have the following bread options...");
      // Console.WriteLine(bread list contents);
      Console.WriteLine("To add Rye bread, type 'rye'.");
      Console.WriteLine("To add Wheat bread, type 'wheat'.");
      Console.WriteLine("To add Gluten Free bread, type 'gf'.");
      Console.WriteLine("To return to the previous menu, type 'back'.");
      string breadType = Console.ReadLine();
      if (breadType == 'rye' || breadType == 'wheat' breadType == 'gf')
      {
        Console.WriteLine("How many loaves would you like?")
        string breadCount = Console.ReadLine()
      }

    }

    public static Purchase()
    {
      Console.WriteLine("Are you sure you want to make this purchase?  Type 'y' for yes or 'n' for no.");
      string confirmPurch = Console.ReadLine();
      if (confirmPurch == "n")
      {
        Order();
      }
      else if (confirmPurch == "y")
      {
        Console.WriteLine("Your pretend bread order has been purchase with pretend money!");
        Console.WriteLine("We hope that you enjoy filling your pretend stomach!");
        Main();
      }
      else
      {
        Console.WriteLine("That is not a valid input.");
        Purchase();
      }
    } 
  }
}