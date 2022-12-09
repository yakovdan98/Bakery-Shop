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
      Pastry bread = new Bread(10);
      Assert.AreEqual(typeof(Pastry), bread.GetType());
    }
    [TestMethod]
    public void BreadConstructor_CreatesBreadObject_NumberOfBreadsBought()
    {
      // any necessary logic to prep for test; instantiating new classes, etc.
      // Template: ``` Assert.AreEqual(EXPECTED_RESULT, CODE_TO_TEST); ```
      Pastry bread = new Bread(10);
      Assert.AreEqual(10, bread.Cart());
    }
    [TestMethod]
    public void GetCost_ReturnsCost_Cost()
    {
      // any necessary logic to prep for test; instantiating new classes, etc.
      // Template: ``` Assert.AreEqual(EXPECTED_RESULT, CODE_TO_TEST); ```
      Pastry bread = new Bread(0);
      Assert.AreEqual(0, bread.GetCost());


    }
    [TestMethod]
    public void GetCostOne_ReturnsCost_Cost()
    {
      Pastry bread1 = new Bread(1);
      Assert.AreEqual(5, bread1.GetCost());
    }
    [TestMethod]
    public void GetCostTwo_ReturnsCost_Cost()
    {
      Pastry bread2 = new Bread(2);
      Assert.AreEqual(10, bread2.GetCost());
    }
    [TestMethod]
    public void GetCostDiscount_ReturnsCost_Cost()
    {
      Pastry bread3 = new Bread(3);
      Assert.AreEqual(10, bread3.GetCost());
    }
    [TestMethod]
    public void GetCostMore_ReturnsCost_Cost()
    {
      Pastry bread4 = new Bread(4);
      Assert.AreEqual(15, bread4.GetCost());
    }
  }

  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    // Test methods will go here
    public void PastryConstructor_CreatesPastryObject_PastryObject()
    {
      // any necessary logic to prep for test; instantiating new classes, etc.
      // Template: ``` Assert.AreEqual(EXPECTED_RESULT, CODE_TO_TEST); ```
      Pastry pastry = new Pastry(10);
      Assert.AreEqual(typeof(Pastry), bread.GetType());
    }
    [TestMethod]
    public void PastryConstructor_CreatesPastryObject_NumberOfPastriesBought()
    {
      // any necessary logic to prep for test; instantiating new classes, etc.
      // Template: ``` Assert.AreEqual(EXPECTED_RESULT, CODE_TO_TEST); ```
      Pastry pastry = new Pastry(10);
      Assert.AreEqual(10, pastry.Cart());
    }
    [TestMethod]
    public void GetCost_ReturnsCost_Cost()
    {
      // any necessary logic to prep for test; instantiating new classes, etc.
      // Template: ``` Assert.AreEqual(EXPECTED_RESULT, CODE_TO_TEST); ```
      Pastry pastry = new Pastry(0);
      Pastry pastry1 = new Pastry(1);
      Pastry pastry2 = new Pastry(2);
      Pastry pastry3 = new Pastry(3);
      Pastry pastry4 = new Pastry(4);
      Pastry pastry5 = new Pastry(5);
      Pastry pastry6 = new Pastry(6);
      Pastry pastry7 = new Pastry(7);
      Assert.AreEqual(0, pastry.GetCost());
      Assert.AreEqual(2, pastry1.GetCost());
      Assert.AreEqual(4, pastry2.GetCost());
      Assert.AreEqual(5, pastry3.GetCost());
      Assert.AreEqual(7, pastry4.GetCost());
      Assert.AreEqual(9, pastry5.GetCost());
      Assert.AreEqual(10, pastry6.GetCost());
      Assert.AreEqual(12, pastry7.GetCost());

    }
  }
}