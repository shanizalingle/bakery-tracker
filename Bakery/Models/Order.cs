using System.Collections.Generic;

namespace Bakery.Models
{
  public class Order
  {
    public string Items { get; set; }
    public int Cost { get; set; }
    public int Date { get; set; }
    public int Id { get; }

    private static List<Order> _orders = new List<Order>{};
  
    public Order(string orderItems, int orderCost, int orderDate)
    {
      Items = orderItems;
      Cost = orderCost;
      Date = orderDate;
      _orders.Add(this);
      Id = _orders.Count;
    }

    public static void ClearAll()
    {
      _orders.Clear();
    }

    public static List<Order> GetAll()
    {
      return _orders;
    }

    public static Order Find(int searchId)
    {
      return _orders[searchId-1];
    }
  }
}