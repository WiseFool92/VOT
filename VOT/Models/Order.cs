using System.Collections.Generic;

namespace VOT.Models
{
  public class Order
  {
    public int Id { get; }
    public string Description { get; set; }
    public string ImgURL { get; set; }
    public static List<Order> _instances = new List<Order> {};

    public Order (string description)
    {
      Description = description;
      _instances.Add(this);
      Id = _instances.Count;
    }
    public Order (string description, string ImgURL) // Overload constructor
    {
      ImgURL = imgURL;
      Description = description;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static Order Find (int searchId)
    {
      return _instances[searchId - 1];
    }

    public static List<Order> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}