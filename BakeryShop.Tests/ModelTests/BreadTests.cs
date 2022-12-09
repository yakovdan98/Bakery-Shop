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
      Assert.AreEqual(10, bread.Count);
    }
    [TestMethod]
    public void BreadGetCost_ReturnsCost_Cost()
    {
      // any necessary logic to prep for test; instantiating new classes, etc.
      // Template: ``` Assert.AreEqual(EXPECTED_RESULT, CODE_TO_TEST); ```
      Pastry bread = new Bread(0);
      Assert.AreEqual(0, bread.GetCost());
    }
    [TestMethod]
    public void BreadGetCostOne_ReturnsCost_Cost()
    {
      Pastry bread1 = new Bread(1);
      Assert.AreEqual(5, bread1.GetCost());
    }
    [TestMethod]
    public void BreadGetCostTwo_ReturnsCost_Cost()
    {
      Pastry bread2 = new Bread(2);
      Assert.AreEqual(10, bread2.GetCost());
    }
    [TestMethod]
    public void BreadGetCostDiscount_ReturnsCost_Cost()
    {
      Pastry bread3 = new Bread(3);
      Assert.AreEqual(10, bread3.GetCost());
    }
    [TestMethod]
    public void BreadGetCostMore_ReturnsCost_Cost()
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
      Assert.AreEqual(10, pastry.Count);
    }
    [TestMethod]
    public void PastryGetCost_ReturnsCost_Cost()
    {
      // any necessary logic to prep for test; instantiating new classes, etc.
      // Template: ``` Assert.AreEqual(EXPECTED_RESULT, CODE_TO_TEST); ```
      Pastry pastry = new Pastry(0);
      Assert.AreEqual(0, pastry.GetCost());

    }
    [TestMethod]
    public void PastryGetCostOne_ReturnsCost_Cost()
    {
      Pastry pastry1 = new Pastry(1);
      Assert.AreEqual(2, pastry1.GetCost());
    }
    [TestMethod]
    public void PastryGetCostTwo_ReturnsCost_Cost()
    {
      Pastry pastry2 = new Pastry(2);
      Assert.AreEqual(4, pastry2.GetCost());
    }
    [TestMethod]
    public void PastryGetCostThree_ReturnsCost_Cost()
    {
      Pastry pastry3 = new Pastry(3);
      Assert.AreEqual(5, pastry3.GetCost());
    }
    [TestMethod]
    public void PastryGetCostFour_ReturnsCost_Cost()
    {
      Pastry pastry4 = new Pastry(4);
      Assert.AreEqual(7, pastry4.GetCost());
    }
    [TestMethod]
    public void PastryGetCostFive_ReturnsCost_Cost()
    {
      Pastry pastry5 = new Pastry(5);
      Assert.AreEqual(9, pastry5.GetCost());
    }
    [TestMethod]
    public void PastryGetCostSix_ReturnsCost_Cost()
    {
      Pastry pastry6 = new Pastry(6);
      Assert.AreEqual(10, pastry6.GetCost());
    }
    [TestMethod]
    public void PastryGetCostSeven_ReturnsCost_Cost()
    {
      Pastry pastry7 = new Pastry(7);
      Assert.AreEqual(12, pastry7.GetCost());
    }
  }
}