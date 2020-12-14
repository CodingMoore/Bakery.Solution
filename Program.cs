using System.Collections.Generic;
using System;
using Bakery.Models;
using Pastry.Models;

namespace BakeryUI
{
  public class Program
  {
    public static void Main()
    {
      Bread.BreadDefault();
      Pastry.PastryDefault();
      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.WriteLine("Bread is $5 per loaf (Buy on get one FREE!)");
      Console.WriteLine("Pastry is $2 each, or 3 for $5");
      Order();
    }

    public static CartReport()
    {
      if (Bread.BreadCount == 0 && Pastry.PastryCount == 0)
      {
        EmptyCart();
      }
      else 
      {
        Console.WriteLine("Your shopping cart contains...");
        Bread.DisplayBreadList();
        Pastry.DisplayPastryList();
        Console.WriteLine("Your total comes to...");
        Console.WriteLine(Bread.BreadPrice + Pastry.PastryPrice);
      }
    }
    
    public static Purchase()
    {
      if (Bread.BreadCount == 0 && Pastry.PastryCount == 0)
      {
        EmptyCart();
        Order();
      }
      else
      {
        if (((Bread.BreadCount + 1) % 3) == 0 )
        {
          Console.WriteLine("The buy 2, get 1 Free sale qualifies you for a free loaf of bread!  Feel free to go back and add your free loaf of bread to your order. The free loaf must be in your cart at the time of purchase.")
        }
        Console.WriteLine("Are you sure you want to make this purchase?  Type 'y' for yes or 'n' for no.");
        string confirmPurch = Console.ReadLine();
        if (confirmPurch == "y")
        {
          Console.WriteLine("Your pretend bread order has been purchase with pretend money!");
          Console.WriteLine("We hope that you enjoy filling your pretend stomach!");
          Main();
        }
        else if (confirmPurch == "n")
        {
          Order();
        }
        else
        {
          Invalid();
          Purchase();
        }
      }
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
        Restart();
      }
      else
      {
        Invalid();
        Order();
      }
    } 

    public static BreadList()
    {
      Console.WriteLine("To add Rye bread, type 'rye'.");
      Console.WriteLine("To add Wheat bread, type 'wheat'.");
      Console.WriteLine("To add Gluten Free bread, type 'gf'.");
      Back();
      string breadType = Console.ReadLine();
      if (breadType == 'rye' || breadType == 'wheat' || breadType == 'gf')
      {
        BreadNumber();
      }
      else if (breadType == 'back')
      {
        Order();
      }
      else 
      {
        Invalid();
        BreadList();
      }
    }

    public static BreadNumber()
    {
      Console.WriteLine("How many loaves of this bread would you like in total?")
      Limit10();
      Back();
      string breadCount = Console.ReadLine();
      if (breadCount.All(Char.IsDigit) == true && int.Parse(breadCount) >= 0 && int.Parse(breadCount) <= 10)
      {
        Bread.GetBread()[Bread.GetBread().FindIndex(x => x.Contains(breadType))].Quantity = int.Parse(breadCount);
        Console.WriteLine("Your shopping cart has been updated.");
        Order();
      }
      else if (breadCount == "back")
      {
        BreadList();
      }
      else
      {
        Invalid();
        BreadNumber();
      }
    }

    public static PastryList()
    {
      Console.WriteLine("To add Crossants, type 'crossant'.");
      Console.WriteLine("To add Baklava, type 'baklava'.");
      Console.WriteLine("To add Danishes, type 'danish'.");
      Back();
      string pastryType = Console.ReadLine();
      if (pastryType == 'Crossant' || pastryType == 'baklava' || pastryType == '')
      {
        PastryNumber();
      }
      else if (pastryType == 'back')
      {
        Order();
      }
      else 
      {
        Invalid();
        PastryList();
      }
    }

    public static PastryNumber()
    {
      Console.WriteLine("How many pastries of this type would you like in total?")
      Limit10();
      Back();
      string pastryCount = Console.ReadLine();
      if (pastryCount.All(Char.IsDigit) == true && int.Parse(pastryCount) >= 0 && int.Parse(pastryCount) <= 10)
      {
        Pastry.GetPastry()[Pastry.GetPastry().FindIndex(x => x.Contains(pastryType))].Quantity = int.Parse(pastryCount);
        Console.WriteLine("Your shopping cart has been updated.");
        Order();
      }
      else if (pastryCount == "back")
      {
        PastryList();
      }
      else
      {
        Invalid();
        PastryNumber();
      }
    }

    public static Restart()
    {
      Console.WriteLine("Are you sure you want to empty your cart and start over?  Type 'y' for yes or 'n' for no.");
      string confirmRestart = console.Readline();
      if (confirmRestart == "y")
      {
        Main();
      }
      else if (confirmRestart == "n")
      {
        Order();
      }
      else
      {
        Invalid();
        Restart();
      }
    }

    public static Invalid()
    {
      Console.WriteLine("That is not a valid input.");
    }

    public static Limit10()
    {
      Console.WriteLine("There is a limit of 10 of each item per person, per order. Please input only whole numbers between 0 and 10");
    }

    public static EmptyCart()
    {
      Console.WriteLine("Your shopping cart is empty.");
    }

    public static Back()
    {
      Console.WriteLine("To return to the previous menu, type 'back'.");
    }
  }
}