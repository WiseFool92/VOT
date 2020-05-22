using Microsoft.AspNetCore.Mvc;
using VOT.Models;
using System.Collections.Generic;

namespace VOT.Controllers
{
  public class OrderController : Controller
  {
    [HttpGet("/vendor/{vendorId}/order/new")]
    public ActionResult New (int vendorId)
    {
      Vendor vendor = Vendor.Find(vendorId);
      return View(vendor);
    }

    [HttpGet("/vendor/{vendorId}/order/{orderId}")]
    public ActionResult Show (int vendorId, int orderId)
    {
      Vendor vendor = Vendor.Find(vendorId);
      Order order = Order.Find(orderId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("vendor", vendor);
      model.Add("order", order);
      return View(model);
    }

    [HttpPost("/order/delete")]
    public ActionResult DeleteAll ()
    {
      Order.ClearAll();
      return View();
    }
  }
}