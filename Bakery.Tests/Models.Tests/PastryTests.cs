using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System;
using System.Collections.Generic;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests : IDisposable
  {
    public void Dispose()
    {
      Pastry.ClearPastryCart();
    }

    [TestMethod]
    public void PastryConstructor_InstantiatePastryObject_True()
    {
      Pastry loaf1 = new Pastry("crossant", 3);
      Assert.AreEqual(typeof(Pastry), loaf1.GetType());
    }

    [TestMethod]
    public void DisplayPastryList_ShowListContents_True()
    {
      Pastry.PastryDefault();
      Pastry.DisplayPastryList();
      Assert.AreEqual("crossant", Pastry.GetPastry()[0].Name);
      Assert.AreEqual(0, Pastry.GetPastry()[0].Quantity);
      Assert.AreEqual(5, Pastry.GetPastry()[0].Price);
    }

    [TestMethod]
    public void UpdatePastry_ChangeListObjectValues_True()
    {
      Pastry.PastryDefault();
      Pastry.GetPastry()[0].Quantity = 3;
      Assert.AreEqual(3 , Pastry.GetPastry()[0].Quantity);
    }

    [TestMethod]
    public void PastryCount_CountNumberOfTotalLoaves_True()
    {
      Pastry.PastryDefault();
      Pastry.GetPastry()[0].Quantity = 6;
      Assert.AreEqual(6, Pastry.PastryCount());
    }

    [TestMethod]
    public void PastryPrice_CalculatePastrySubtotalForMultipleOf3_True()
    {
      Pastry.PastryDefault();
      Pastry.GetPastry()[0].Quantity = 1;
      Pastry.GetPastry()[1].Quantity = 1;
      Pastry.GetPastry()[2].Quantity = 1;
      Assert.AreEqual(5, Pastry.PastryPrice());
    }

    [TestMethod]
    public void PastryPrice_CalculatePastrySubtotalForSinglePastry_True()
    {
      Pastry.PastryDefault();
      Pastry.GetPastry()[0].Quantity = 1;
      
      Assert.AreEqual(2, Pastry.PastryPrice());
    }

    [TestMethod]
    public void PastryIndex_FindIndexByName_True()
    {
      Pastry.PastryDefault();
      Assert.AreEqual(0, Pastry.PastryIndex("crossant"));
    }
  }
} 