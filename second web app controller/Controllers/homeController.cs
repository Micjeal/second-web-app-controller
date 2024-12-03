using second_web_app_controller.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace second_web_app_controller.Controllers
{
    public class homeController : Controller
    {
        // GET: home
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult UserProfile( string Name, string Age)
        {
            Name = "Micheal";
            ViewBag.UserName = Name;

            Age = "12";
            ViewBag.Ages = Age;
            return View();
        }
        [HttpPost]
        public ActionResult UserProfile()
        {
            return View();
        }

        public ActionResult Vehicles()
        {
            ViewBag.Cars = new List<string>
            {
                "Benz","Toyota","Ferrari","Audi"
            };
            return View();
        }
        public ActionResult Planes()
        {
            var planedata = new List<Planes>
            {
                new Planes{planeid=1,planename="corcode",planedescription="heavy"},
                new Planes{planeid=2,planename="Bombardier",planedescription="heavy"},
                new Planes{planeid=3,planename="Airbus",planedescription="heavy"},
            };
            return View(planedata);           
        }

        public ActionResult NewPlane()
        {
            return View();
        }
        public ActionResult NewPlanes(Planes NewPlane)
        {
            ViewBag.PlaneAdd = $"PlaneAdded: {NewPlane.planename}";

            return View();
        }
    }
}