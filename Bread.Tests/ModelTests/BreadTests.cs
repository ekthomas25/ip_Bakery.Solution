using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System.Collections.Generic;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreateInstanceOfBread_Bread()
    {
      Bread newBread = new Bread(1, 5);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }
    [TestMethod]
    public void GetBread_ReturnBreadQuantity_Int()
    {
      int breadQuantity = 8;
      int breadPrice = 5;
      Bread newBread = new Bread(breadQuantity, breadPrice);

      int result = newBread.BreadQuantity;
      
      Assert.AreEqual(breadQuantity, result);
    }

    [TestMethod]
    public void GetBread_ReturnBreadPrice_Int()
    {
      int breadQuantity = 8;
      int breadPrice = 5;
      Bread newBread = new Bread(breadQuantity, breadPrice);

      int resultPrice = newBread.BreadPrice;

      Assert.AreEqual(breadPrice, resultPrice);
    }
    [TestMethod]
    public void GetBreadCost_CostOfNoBread_IntZero()
    {
      int breadQuantity = 0;
      int breadPrice = 5;
      Bread newBread = new Bread(breadQuantity, breadPrice);
      int expectedCost = 0;

    int actualCost = newBread.GetBreadCost();

      Assert.AreEqual(expectedCost, actualCost);
    }

    [TestMethod]
    public void GetBreadCost_CostOfOneLoaf_IntFive()
    {
      int breadQuantity = 1;
      int breadPrice = 5;
      Bread newBread = new Bread(breadQuantity, breadPrice);
      int expectedCost = 5;

    int actualCost = newBread.GetBreadCost();
    
      Assert.AreEqual(expectedCost, actualCost);
    }

    [TestMethod]
    public void GetBreadCost_CostOfThreeLoaves_IntTen()
    {
      int breadQuantity = 3;
      int breadPrice = 5;
      Bread newBread = new Bread(breadQuantity, breadPrice);
      int expectedCost = 10;

    int actualCost = newBread.GetBreadCost();
    
      Assert.AreEqual(expectedCost, actualCost);
    }

    [TestMethod]
    public void GetBreadCost_CostOfFourLoaves_IntFifteen()
    {
      int breadQuantity = 4;
      int breadPrice = 5;
      Bread newBread = new Bread(breadQuantity, breadPrice);
      int expectedCost = 15;

      int actualCost = newBread.GetBreadCost();
      
      Assert.AreEqual(expectedCost, actualCost);
    }
  }
}