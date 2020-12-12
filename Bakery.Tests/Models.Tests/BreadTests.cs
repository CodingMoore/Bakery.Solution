using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System;
using System.Collections.Generic;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_InstantiateBreadObject_True()
    {
      // any necessary logic to prep for test; instantiating new classes, etc.
      Bread loaf1 = new Bread("rye");
      Assert.AreEqual(typeof(Bread), loaf1.GetType());
      Console.WriteLine(loaf1);
    }

    [TestMethod]
    public void BreadConstructor_AddToStaticList_True()
    {
      Bread loaf1 = new Bread("testInput");
      Assert.AreEqual(loaf1.Name, cart[0].Name);
      Console.WriteLine(loaf1.Name);
    }
  }
}
//  Assert.AreEqual(EXPECTED RESULT, CODE TO TEST);