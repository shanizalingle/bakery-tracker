using System.Collections.Generic;

namespace Bakery.Models
{
  public class Order
  {
    public string Items { get; set; }
    public int Cost { get; set; }
    public int Date { get; set; }
    public int Id { get; }

    private static List<Order> _instances = new List<Order>{};
  
    public Order(string orderItems, int orderCost, int orderDate)
    {
      Items = orderItems;
      Cost = orderCost;
      Date = orderDate;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static List<Order> GetAll()
    {
      return _instances;
    }

    public static Order Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}