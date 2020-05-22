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
  }

}