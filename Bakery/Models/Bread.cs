using System.Collections.Generic;
using System;
//using System.Collections.Generic; -- use for lists

namespace Bakery.Models
{
  public class Bread
  {
    //fields are hidden
    private static List<Bread> _breadCart = new List<Bread> {};
    
    public string Name { get; set; } //this is a property

    public int Quantity { get; set; }
    public int Price { get; private set; }
    public Bread(string name, int num)
    {
      Name = name;
      Quantity = num;
      Price = 5;
      // _breadCart.Add(this);
    }

    public static void BreadDefault()
    {
      Bread rye = new Bread("rye", 0);
      Bread wheat = new Bread("wheat", 0);
      Bread gf = new Bread("gf", 0);
      _breadCart.Add(rye);
      _breadCart.Add(wheat);
      _breadCart.Add(gf);
    }
    public static List<Bread> GetBread()
    {
      return _breadCart;
    }

    public static void ClearBreadCart()
    {
      _breadCart.Clear();
    }

    public static void DisplayBreadList()
    {
      foreach (Bread thingy in Bread._breadCart)
      {
        Console.Write(thingy.Name + " " + "$" + thingy.Price + ", ");
      }
    }
  }
}

