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
      Order newOrder = new Order("", 0, "");  
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetItems_ReturnItems_String()
    {
      string items = "3 bread, 2 pastry";
      Order newOrder = new Order(items, 0, "");
      string result = newOrder.Items;
      Assert.AreEqual(items, result);
    }

    [TestMethod]
    public void GetCost_ReturnCost_Int()
    {
      int cost = 35;
      Order newOrder = new Order("", 35, "");
      int result = newOrder.Cost;
      Assert.AreEqual(cost, result);
    }

    [TestMethod]
    public void GetDate_ReturnDate_Int()
    {
      string date = "09302022";
      Order newOrder = new Order("", 0, date);
      string result = newOrder.Date;
      Assert.AreEqual(date, result);
    }

    [TestMethod]
    public void SetItem_SetItem_String()
    {
      string items = "3 bread, 2 pastry";
      Order newOrder = new Order(items, 0, "");
      string updatedItems = "0 bread, 4 pastry";
      newOrder.Items = updatedItems;
      string result = newOrder.Items;
      Assert.AreEqual(updatedItems, result);
    }

    [TestMethod]
    public void SetCost_SetCost_Int()
    {
      int cost = 35;
      Order newOrder = new Order("", cost, "");
      int updatedCost = 12;
      newOrder.Cost = updatedCost;
      int result = newOrder.Cost;
      Assert.AreEqual(updatedCost, result);
    }

    [TestMethod]
    public void SetDate_SetDate_Int()
    {
      string date = "09302022";
      Order newOrder = new Order("", 0, date);
      string updatedDate = "1252022";
      newOrder.Date = updatedDate;
      string result = newOrder.Date;
      Assert.AreEqual(updatedDate, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_ItemList()
    {
      List<Order> newList = new List<Order> { };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsItems_ItemList()
    {
      string item1 = "3 bread, 2 pastry";
      string item2 = "0 bread, 4 pastry";
      int cost1 = 35;
      int cost2 = 12;
      string date1 = "09302022";
      string date2 = "12252022";
      Order newOrder1 = new Order(item1, cost1, date1);
      Order newOrder2 = new Order(item2, cost2, date2);
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetId_OrdersReturnId_Int()
    {
      string item = "3 bread, 2 pastry";
      int cost = 35;
      string date = "09302022";
      Order newOrder = new Order(item, cost, date);
      int result = newOrder.Id;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectItem_Item()
    {
      string item1 = "3 bread, 2 pastry";
      string item2 = "0 bread, 4 pastry";
      int cost1 = 35;
      int cost2 = 12;
      string date1 = "09302022";
      string date2 = "12252022";
      Order newOrder1 = new Order(item1, cost1, date1);
      Order newOrder2 = new Order(item2, cost2, date2);
      Order result = new Order("Incorrect test item", 0, "");
      result = Order.Find(2);
    }
  }
}