using AmbulanceSystem.Entities;
using AmbulanceSystem.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmbulanceSystem.ViewModels
{
    public class AmbulanceViewModel
    {
        public ICollection<Ambulance> Ambulances {get; set;}
    }
}
