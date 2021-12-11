using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System.Collections.Generic;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreateInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry(1, 2);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void GetPastry_ReturnPastryQuantity_Int()
    {
      int pastryQty = 1;
      int pastryPrice = 2;
      Pastry newPastry = new Pastry(pastryQty, pastryPrice);

      int result = newPastry.PastryQty;

      Assert.AreEqual(pastryQty, result); 
    }
  }
}