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
      Bread newBread = new Bread("Baguette", 5);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }
    [TestMethod]
    public void GetBread_ReturnBreadType_String()
    {
      //Arrange - Gather, declate, create: necessary components for test
      string breadType = "Baguette";
      int breadPrice = 5;
      Bread newBread = new Bread(breadType, breadPrice);
      // Act - Invoke functionality: ie call method, retrieve property, etc
      string result = newBread.BreadType;
      //Assert - Confirm functionality works: compare actual output to expected output
      Assert.AreEqual(breadType, result);
    }

    [TestMethod]
    public void GetBread_ReturnBreadPrice_Int()
    {
      //Arrange - Gather, declate, create: necessary components for test
      string breadType = "Baguette";
      int breadPrice = 5;
      Bread newBread = new Bread(breadType, breadPrice);
      // Act - Invoke functionality: ie call method, retrieve property, etc
      int resultPrice = newBread.BreadPrice;
      //Assert - Confirm functionality works: compare actual output to expected output
      Assert.AreEqual(breadPrice, resultPrice);
    }
    [TestMethod]
    public void GetBreadCost_CostOfNoBread_IntZero()
    {
      //Arrange - Gather, declate, create: necessary components for test
      string breadType = "Baguette";
      int breadPrice = 5;
      int expectedCost = 0;
      int quantity = 0;
      Bread newBread = new Bread(breadType, breadPrice);
      // Act - Invoke functionality: ie call method, retrieve property, etc
      int actualCost = newBread.GetBreadCost();
      //Assert - Confirm functionality works: compare actual output to expected output
      Assert.AreEqual(expectedCost, actualCost);
    }
  }
}