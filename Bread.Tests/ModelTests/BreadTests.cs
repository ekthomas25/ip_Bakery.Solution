using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreateInstanceOfBread_Bread()
    {
      Bread newBread = new Bread();
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }
    [TestMethod]
    public void GetBread_ReturnBreadType_String()
    {
      //Arrange - Gather, declate, create: necessary components for test
      string breadType = "Baguette";
      Bread newBread = new Bread(breadType);
      // Act - Invoke functionality: ie call method, retrieve property, etc
      string result = newBread.breadType;
      //Assert - Confirm functionality works: compare actual output to expected output
      Assert.AreEqual(breadType, result);
    }
  }
}