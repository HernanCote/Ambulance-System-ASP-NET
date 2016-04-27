using AmbulanceSystem.Entities;
using AmbulanceSystem.ViewModels;
using Microsoft.AspNet.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmbulanceSystem.Controllers
{
    public class HomeController : Controller
    {
        private IServicesAmbulance _servicesAmbulance;

        public HomeController(IServicesAmbulance servicesAmbulance)
        {
            _servicesAmbulance = servicesAmbulance;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Ambulances()
        {
            var model = new AmbulanceEditViewModel();
            model.Ambulances = _servicesAmbulance.GetAllAmbulances();
            return View(model);
        }

        [HttpGet]
        public IActionResult CreateAmbulance()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateAmbulance(AmbulanceCreateViewModel model)
        {            
            if (ModelState.IsValid)
            {
                Random rnd = new Random();
                var ambulance = new Ambulance();
                ambulance.AmbulanceCode = model.AmbulanceCode;
                ambulance.Plate = model.Plate;
                ambulance.ServicesList = new List<Service>();
                ambulance.State = model.AmbulanceState;
                ambulance.RoadPosition = rnd.Next(1,200);
                ambulance.StreetPosition = rnd.Next(1,200);
                ambulance.AmbulanceType = model.AmbulanceType;
                ambulance.TimeOfPosition = DateTime.Now;

                _servicesAmbulance.AddAmbulance(ambulance);
                _servicesAmbulance.Commit();
                return RedirectToAction("Ambulances");
            }
            return View();
        }
    }
}
