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
      Bread newBread = new Bread("Baguette");
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }
    [TestMethod]
    public void GetBread_ReturnBreadType_String()
    {
      //Arrange - Gather, declate, create: necessary components for test
      string breadType = "Baguette";
      Bread newBread = new Bread(breadType);
      // Act - Invoke functionality: ie call method, retrieve property, etc
      string result = newBread.BreadType;
      //Assert - Confirm functionality works: compare actual output to expected output
      Assert.AreEqual(breadType, result);
    }
  }
}