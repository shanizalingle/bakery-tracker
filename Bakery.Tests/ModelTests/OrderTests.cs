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
  }
}