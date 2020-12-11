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

      // if (Cart is empty);
      // {
      //   Console.WriteLine("Your shopping cart is empty.");
      // }
      // else 
      // {
      //   CartReport();
      // }
    }  
    
    public static Order()
    {
     
      Console.WriteLine("To add Bread to your cart, please type 'Bread'.");
      Console.WriteLine("To add Pastry to your cart, please Type 'Pastry'.");
      Console.WriteLine("To puchase the items in your cart, please type 'Purchase'.");
      Console.WriteLine("To empty your cart, please type 'Restart'.");
      CartReport();
      string custInput = Console.ReadLine();
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
  }
}