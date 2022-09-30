using System.Collections.Generic;

namespace Bakery.Models
{
  public class Order
  {
    public string Items { get; set; }
    public int Cost { get; set; }
    public int Date { get; set; }
    private static List<Order> _orders = new List<Order>{};
  
    public Order(string items, int cost, int date)
    {
      Items = items;
      Cost = cost;
      Date = date;
      _orders.Add(this);
    }

    public static void ClearAll()
    {
      _orders.Clear();
    }

    public static List<Order> GetAll()
    {
      return _orders;
    }
  }
}