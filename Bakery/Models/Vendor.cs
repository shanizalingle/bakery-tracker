using System.Collections.Generic;

namespace Bakery.Models
{
  public class Vendor
  {
    private static List<Vendor> _vendors = new List<Vendor> {};
    public string Name { get; set; }
    public string Location { get; set; }
    public int Id { get; }
    public List<Order> Orders { get; set; }

    public Vendor(string vendorName, string vendorLocation)
    {
      Name = vendorName;
      Location = vendorLocation;
      _vendors.Add(this);
      Id = _vendors.Count;
      Orders = new List<Order>{};
    }

    public static void ClearAll()
    {
      _vendors.Clear();
    }

    public static List<Vendor> GetAll()
    {
      return _vendors;
    }

    public static Vendor Find(int searchId)
    {
      return _vendors[searchId-1];
    }
  }
}