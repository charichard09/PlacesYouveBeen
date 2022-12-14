using PlacesYouveBeen.Models;
using Microsoft.AspNetCore.Mvc;

namespace PlacesContoller.Controllers
{
  public class PlacesController : Controller
  {
    [HttpGet("/place")]
    public ActionResult Index()
    {
      return View(Place.GetPlaces());
    }

    [HttpGet("/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/place")]
    public ActionResult Create(string cityname)
    {
      Place newPlace = new Place(cityname);
      return RedirectToAction("Index");
    }

    [HttpGet("/place/{id}")]
    public ActionResult Show(int id)
    {
      // can also use this as argument to save declaring Find method: Place.GetPlaces()[id-1]

      return View(Place.Find(id));
    }
  }
}