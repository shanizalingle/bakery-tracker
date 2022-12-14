using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System.Collections.Generic;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test vendor", " ");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "Suzie's cafe";
      Vendor newVendor = new Vendor(name, " ");
      string result = newVendor.Name;
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetLocation_ReturnsLocation_String()
    {
      string location = "23rd Street";
      Vendor newVendor = new Vendor(" ", location);
      string result = newVendor.Location;
      Assert.AreEqual(location, result);
    }

    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      string name = "Suzie's cafe";
      string location = "23rd Street";
      Vendor newVendor = new Vendor(name, location);
      int result = newVendor.Id;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      string name1 = "Suzie's Cafe";
      string name2 = "Matt's Coffee Shop";
      string location1 = "23rd Street";
      string location2 = "SW Main Street";
      Vendor newVendor1 = new Vendor(name1, location1);
      Vendor newVendor2 = new Vendor(name2, location2);
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      string name1 = "Suzie's Cafe";
      string name2 = "Matt's Coffee Shop";
      string location1 = "23rd Street";
      string location2 = "SW Main Street";
      Vendor newVendor1 = new Vendor(name1, location1);
      Vendor newVendor2 = new Vendor(name2, location2);
      Vendor result = Vendor.Find(2);
      Assert.AreEqual(newVendor2, result);
    }

    [TestMethod]
    public void AddItem_AssociatesItemWithCategory_ItemList()
    {
      string item = "3 bread, 2 pastry";
      int cost = 35;
      string date = "09302022";
      Order newOrder = new Order(item, cost, date);
      List<Order> newList = new List<Order> { newOrder };
      string name = "Suzie's Cafe";
      string location = "23rd Street";
      Vendor newVendor = new Vendor(name, location);
      newVendor.AddOrder(newOrder);
      List<Order> result = newVendor.Orders;
      CollectionAssert.AreEqual(newList, result);
    }
  }
}