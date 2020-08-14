using Microsoft.AspNetCore.Mvc;
using PierresTreats.Models;
using System.Collections.Generic;

namespace PierresTreats.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}