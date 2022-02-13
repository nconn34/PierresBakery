using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Bakery.Logic;

namespace Bakery.Tests
{
    [TestClass]
  public class ItemTests
  {
    [TestMethod]
    public void Bread_ReturnsPrice()
    {
    //Arrange
    int bread1 = 1;
  
    //Act
    int cost = 5;
    int breadCost = Bread.costOfBread(bread1);

    //Assert
    Assert.AreEqual(breadCost, cost);
    }
    [TestMethod]
    public void Bread_BuyTwoGetOneFree()
    {
    //Arrange
    int bread3 = 3;
  
    //Act
    int cost = 10;
    int breadCost = Bread.costOfBread(bread3);

    //Assert
    Assert.AreEqual(breadCost, cost);
    }
    [TestMethod]
    public void Bread_FourthLoafShouldRestartDeal()
    {
    //Arrange
    int bread4 = 4;
  
    //Act
    int cost = 15;
    int breadCost = Bread.costOfBread(bread4);

    //Assert
    Assert.AreEqual(breadCost, cost);
    }
    [TestMethod]
    public void Pastry_Cost()
    {
    //Arrange
    int pastry = 3;
  
    //Act
    int cost = 5;
    int pastryCost = Pastry.costOfPastry(pastry);

    //Assert
    Assert.AreEqual(pastryCost, cost);
    }
}
}