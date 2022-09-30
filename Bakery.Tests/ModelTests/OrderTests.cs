using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System.Collections.Generic;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {

    public void Dispose(){
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesOrdersOfOrder_Order()
    {
      Order newOrder = new Order("", 0, 0);  
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetItems_ReturnItems_String()
    {
      string items = "3 bread, 2 pastry";
      Order newOrder = new Order(items, 0, 0);
      string result = newOrder.Items;
      Assert.AreEqual(items, result);
    }

    [TestMethod]
    public void GetCost_ReturnCost_Int()
    {
      int cost = 35;
      Order newOrder = new Order("", 35, 0);
      int result = newOrder.Cost;
      Assert.AreEqual(cost, result);
    }

    [TestMethod]
    public void GetDate_ReturnDate_Int()
    {
      int date = 09302022;
      Order newOrder = new Order("", 0, 09302022);
      int result = newOrder.Date;
      Assert.AreEqual(date, result);
    }

    [TestMethod]
    public void SetItem_SetItem_String()
    {
      string items = "3 bread, 2 pastry";
      Order newOrder = new Order(items, 0, 0);
      string updatedItems = "0 bread, 4 pastry";
      newOrder.Items = updatedItems;
      string result = newOrder.Items;
      Assert.AreEqual(updatedItems, result);
    }

    [TestMethod]
    public void SetCost_SetCost_Int()
    {
      int Cost = 35;
      Order newOrder = new Order("", 35, 0);
      int updatedCost = 12;
      newOrder.Cost = updatedCost;
      int result = newOrder.Cost;
      Assert.AreEqual(updatedCost, result);
    }

    [TestMethod]
    public void SetDate_SetDate_Int()
    {
      int Date = 09302022;
      Order newOrder = new Order("", 0, 09302022);
      int updatedDate = 1252022;
      newOrder.Date = updatedDate;
      int result = newOrder.Date;
      Assert.AreEqual(updatedDate, result);
    }
  }
}