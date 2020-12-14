using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System;
using System.Collections.Generic;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests : IDisposable
  {
    public void Dispose()
    {
      Bread.ClearBreadCart();
    }
    [TestMethod]

    // public void BreadCart_CreateStaticCart_True()
    // {
    //   Console.WriteLine(Bread.GetBread()[0].Name);
    //   Assert.AreEqual("rye", "ry");
    // }
    public void BreadConstructor_InstantiateBreadObject_True()
    {
      // any necessary logic to prep for test; instantiating new classes, etc.
      Bread loaf1 = new Bread("rye");
      Assert.AreEqual(typeof(Bread), loaf1.GetType());
    }

    [TestMethod]
    public void BreadConstructor_AddToStaticList_True()
    {
      Bread loaf1 = new Bread("testInput");
      Assert.AreEqual(loaf1.GetType(), Bread.GetBread()[0].GetType());
      
    }

    [TestMethod]

    public void ClearBreadCart_EmptyTheList_True()
    {
      Bread loaf1 = new Bread("testInput");
      Assert.AreEqual(1, Bread.GetBread().Count);
    }

    [TestMethod]
    public void DisplayBreadList_ShowListContents_True()
    {
      Bread loaf1 = new Bread("Bread Name1");
      Bread.DisplayBreadList();
      Assert.AreEqual("Bread Name1", Bread.GetBread()[0].Name);
      Assert.AreEqual(5, Bread.GetBread()[0].Price);
    }
  }
} 
//  Assert.AreEqual(EXPECTED RESULT, CODE TO TEST);