using System.Collections.Generic;

namespace VOT.Models
{
  public class Vendor
  {
    public string Name { get; set; }
    public string Id { get; }
    private static List<Vendor> _instances = new List<Vendors> {};
    public List<Order> Order { get; set; }

    public Vendor (string vendorName)
    {
      Name = vendorName;
      _instances.Add(this);
      Id = _instances.Count;
      Order = new List<Order>{};
    }

    public void AddOrder (Order order)
    {
      Order.Add(order);
    }

    public static Vendor Find(int searchId)
    {
      return _instances[searchId - 1];
    }

    public static List<Vendor> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }


  }
}