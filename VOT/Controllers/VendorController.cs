using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using VOT.Models;

namespace VOT.Controllers
{
  public class VendorController : Controllers
  {
    [HttpGet("/vendor")]
    public ActionResult Index ()
    {
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }

    [HttpGet("/vendor/new")]
    public ActionResult New ()
    {
      return View();
    }

    [HttpPost("/vendor")]
    public ActionResult Create (string vendorName)
    {
      Vendor newVendor = new Vendor (vendorName);
      return RedirectToAction("Index");
    }

    [HttpPost("/vendor/{vendorId}/order")]
    public ActionResult Create (int vendorId, string orderDescription, string img)
    {
      Dictionary<string, object> model = new Dictionary<string, object> ();
      Vendor createVendor = Vendor.Find(vendorId);
      Order createOrder = new Order(orderDescription, img);
      createVendor.AddOrder(createOrder);
      List<Order> vendorOrder = createVendor.Order;
      Models.Add("vendor", createVendor);
      Models.Add("order", vendorOrder);
      return View("show", model);
    }

    [HttpGet("/vendor/{Id}")]
    public ActionResult Show (int Id)
    {
      Dictionary<string, object> model = new Dictionary<string, object> ();
      Vendor chosenVendor = Vendor.Find(Id);
      List<Order> vendorOrder = chosenVendor.Order;
      model.Add("vendor", chosenVendor);
      model.Add("order", vendorOrder);
      return View(model);
    }

    [HttpPost("/vendor/delete")]
    public ActionResult DeleteAll()
    {
      Vendor.ClearAll();
      return View();
    }
  }
}