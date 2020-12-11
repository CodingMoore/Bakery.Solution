using System.Collections.Generic;
using System;

namespace BakeryUI
{
  public class Program
  {
    // public static void Main()
    // {
    //   //code to empty cart
    //   Console.WriteLine("Welcome to Pierre's Bakery!");
    //   Order();
    // }

    // public static CartReport()
    // {
    //   if (Cart is empty)
    //   {
    //     EmptyCart();
    //   }
    //   else 
    //   {
    //     Console.WriteLine("Your shopping cart contains...");
    //     Console.WriteLine(Cart contents);
    //     Console.WriteLine("Your total comes to...");
    //     Console.WriteLine(Total Cost);
    //   }
    // }
    
    // public static Purchase()
    // {
    //   if (cart it empty)
    //   {
    //     EmptyCart();
    //     Order();
    //   }
    //   else
    //   {
    //     Console.WriteLine("Are you sure you want to make this purchase?  Type 'y' for yes or 'n' for no.");
    //     string confirmPurch = Console.ReadLine();
    //     if (confirmPurch == "y")
    //     {
    //       Console.WriteLine("Your pretend bread order has been purchase with pretend money!");
    //       Console.WriteLine("We hope that you enjoy filling your pretend stomach!");
    //       Main();
    //     }
    //     else if (confirmPurch == "n")
    //     {
    //       Order();
    //     }
    //     else
    //     {
    //       Invalid();
    //       Purchase();
    //     }
    //   }
    // }

    // public static Order()
    // {
    //   Console.WriteLine("To add some bread to your cart, please type 'bread'.");
    //   Console.WriteLine("To add some pastry to your cart, please Type 'pastry'.");
    //   Console.WriteLine("To puchase the items in your cart, please type 'purchase'.");
    //   Console.WriteLine("To empty your cart, please type 'restart'.");
    //   CartReport();
    //   string custInput = Console.ReadLine();
    //   if (custInput == "bread")
    //   {
    //     BreadList();
    //   }
    //   else if (custInput == "pastry")
    //   {
    //     PastryList();
    //   }
    //   else if (custInput == "puchase")
    //   {
    //     Purchase();
    //   }
    //   else if (custInput == "restart")
    //   {
    //     Restart();
    //   }
    //   else
    //   {
    //     Invalid();
    //     Order();
    //   }
    // } 

    // public static BreadList()
    // {
    //   Console.WriteLine("To add Rye bread, type 'rye'.");
    //   Console.WriteLine("To add Wheat bread, type 'wheat'.");
    //   Console.WriteLine("To add Gluten Free bread, type 'gf'.");
    //   Back();
    //   string breadType = Console.ReadLine();
    //   if (breadType == 'rye' || breadType == 'wheat' || breadType == 'gf')
    //   {
    //     BreadNumber();
    //   }
    //   else if (breadType == 'back')
    //   {
    //     Order();
    //   }
    //   else 
    //   {
    //     Invalid();
    //     BreadList();
    //   }
    // }

    // public static BreadNumber()
    // {
    //   Console.WriteLine("How many loaves would you like?")
    //   Limit10();
    //   Back();
    //   string breadCount = Console.ReadLine();
    //   if (breadCount.All(Char.IsDigit) == true && int.Parse(breadCount) >= 1 && int.Parse(breadCount) <= 10)
    //   {
    //     // add bread to cart (breadCount and breadType from BreadList) - add total limit logic
    //     Console.WriteLine("{breadCount} loves of {breadType from Breadlist} have been added to your cart");
    //     Order();
    //   }
    //   else if (breadCount == "back")
    //   {
    //     BreadList();
    //   }
    //   else
    //   {
    //     Invalid();
    //     BreadNumber();
    //   }
    // }

    // public static PastryList()
    // {
    //   Console.WriteLine("To add Crossants, type 'crossant'.");
    //   Console.WriteLine("To add Baklava, type 'baklava'.");
    //   Console.WriteLine("To add Danishes, type 'danish'.");
    //   Back();
    //   string pastryType = Console.ReadLine();
    //   if (pastryType == 'Crossant' || pastryType == 'baklava' || pastryType == '')
    //   {
    //     PastryNumber();
    //   }
    //   else if (pastryType == 'back')
    //   {
    //     Order();
    //   }
    //   else 
    //   {
    //     Invalid();
    //     PastryList();
    //   }
    // }

    // public static PastryNumber()
    // {
    //   Console.WriteLine("How many pastries would you like?")
    //   Limit10();
    //   Back();
    //   string pastryCount = Console.ReadLine();
    //   if (pastryCount.All(Char.IsDigit) == true && int.Parse(pastryCount) >= 1 && int.Parse(pastryCount) <= 10)
    //   {
    //     // add pastry to cart (pastryCount and pastryType from PastryList) - add total limit logic
    //     Console.WriteLine("{pastryCount} loves of {pastryType from Pastrylist} have been added to your cart");
    //     Order();
    //   }
    //   else if (pastryCount == "back")
    //   {
    //     PastryList();
    //   }
    //   else
    //   {
    //     Invalid();
    //     PastryNumber();
    //   }
    // }

    // public static Restart()
    // {
    //   Console.WriteLine("Are you sure you want to empty your cart and start over?  Type 'y' for yes or 'n' for no.");
    //   string confirmRestart = console.Readline();
    //   if (confirmRestart == "y")
    //   {
    //     Main();
    //   }
    //   else if (confirmRestart == "n")
    //   {
    //     Order();
    //   }
    //   else
    //   {
    //     Invalid();
    //     Restart();
    //   }
    // }

    // public static Invalid()
    // {
    //   Console.WriteLine("That is not a valid input.");
    // }

    // public static Limit10()
    // {
    //   Console.WriteLine("please input only whole numbers between 1 and 10");
    // }

    // public static EmptyCart()
    // {
    //   Console.WriteLine("Your shopping cart is empty.");
    // }

    // public static Back()
    // {
    //   Console.WriteLine("To return to the previous menu, type 'back'.");
    // }
  }
}