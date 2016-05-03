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
    public class IpsController : Controller
    {
        private IServicesAmbulance _servicesAmbulance;

        public IpsController(IServicesAmbulance servicesAmbulance)
        {
            _servicesAmbulance = servicesAmbulance;
        }

        [HttpGet]
        public IActionResult Ips()
        {
            var model = new IpsViewModel();
            model.Ips = _servicesAmbulance.GetAllIps().ToList();

            return View(model);
        }

        [HttpGet]
        public IActionResult CreateIps()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateIps(CreateIpsViewModel model)
        {
            if (ModelState.IsValid)
            {
                var ips = new IPS();
                var direction = new Direction();

                ips.Name = model.Name;
                ips.Type = model.Type;
                ips.ServicesList = new List<Service>();

                direction.Type = model.Direction.Type;
                direction.Avenue = model.Direction.Avenue;
                direction.Street = model.Direction.Street;
                direction.Number = model.Direction.Number;


                _servicesAmbulance.AddDirection(direction);
                ips.Direction = direction;
                _servicesAmbulance.AddIps(ips);

                _servicesAmbulance.Commit();
                return RedirectToAction("Ips");
            }
            return View();
        }
    }
}
