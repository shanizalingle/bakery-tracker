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
  }
}