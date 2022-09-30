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
  }
}