using System.Collections.Generic;

namespace Bakery.Models
{
  public class Vendor
  {
    private static List<Vendor> _vendors = new List<Vendor> {};
    public string Name { get; set; }
    public int Id { get; }
    public List<Order> Orders { get; set; }

    public Vendor(string vendorName)
    {
      Name = vendorName;
      _vendors.Add(this);
      Id = _vendors.Count;
      Orders = new List<Order>{};
    }

    public static void ClearAll()
    {
      _vendors.Clear();
    }
  }
}