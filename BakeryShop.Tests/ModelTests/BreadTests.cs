using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryShop.Models;

namespace BakeryShop.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesBreadObject_BreadObject()
    {
      // any necessary logic to prep for test; instantiating new classes, etc.
      // Template: ``` Assert.AreEqual(EXPECTED_RESULT, CODE_TO_TEST); ```
      Bread bread = new Bread(10);
      Assert.AreEqual(typeof(Bread), bread.GetType());
    }
    [TestMethod]
    public void BreadConstructor_CreatesBreadObject_NumberOfBreadsBought()
    {
      // any necessary logic to prep for test; instantiating new classes, etc.
      // Template: ``` Assert.AreEqual(EXPECTED_RESULT, CODE_TO_TEST); ```
      Bread bread = new Bread(10);
      Assert.AreEqual(10, bread.Cart());
    }
    [TestMethod]
    public void GetCost_ReturnsCost_Cost()
    {
      // any necessary logic to prep for test; instantiating new classes, etc.
      // Template: ``` Assert.AreEqual(EXPECTED_RESULT, CODE_TO_TEST); ```
      Bread bread = new Bread(0);
      Bread bread1 = new Bread(1);
      Bread bread2 = new Bread(2);
      Bread bread3 = new Bread(3);
      Bread bread4 = new Bread(4);
      Assert.AreEqual(0, bread.GetCost());
      Assert.AreEqual(5, bread1.GetCost());
      Assert.AreEqual(10, bread2.GetCost());
      Assert.AreEqual(10, bread3.GetCost());
      Assert.AreEqual(15, bread4.GetCost());

    }
  }

  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    // Test methods will go here
    public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()
    {
      // any necessary logic to prep for test; instantiating new classes, etc.
      // Template: ``` Assert.AreEqual(EXPECTED_RESULT, CODE_TO_TEST); ```
    }
  }
}