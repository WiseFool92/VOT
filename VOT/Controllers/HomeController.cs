using Microsoft.AspNetCore.Mvc;

namespace VOT.Controllers
{
  public class HomeController : Controllers
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}