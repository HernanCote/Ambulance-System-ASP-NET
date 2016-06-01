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
            var model = new IndexVideModel
            {
                Ambulances = _servicesAmbulance.GetAllAmbulances(),
                Ips = _servicesAmbulance.GetAllIps(),
                Services = _servicesAmbulance.GetAllServices()
            };            

            return View(model);
        }      

        
    }
}
