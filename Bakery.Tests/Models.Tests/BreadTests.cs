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
    }

    [TestMethod]
    public void BreadConstructor_AddToStaticList_True()
    {
      Bread loaf1 = new Bread("testInput");
      Assert.AreEqual(loaf1.GetType(), Bread.GetBread()[1].GetType());
      
    }
  }
} 
//  Assert.AreEqual(EXPECTED RESULT, CODE TO TEST);