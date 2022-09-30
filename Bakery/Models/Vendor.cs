using System.Collections.Generic;

namespace Bakery.Models
{
  public class Vendor
  {
    private static List<Vendor> _vendors = new List<Vendor> {};
    

    public Vendor(string vendorName)
    {
     
    }

    public static void ClearAll()
    {
      _vendors.Clear();
    }
  }
}