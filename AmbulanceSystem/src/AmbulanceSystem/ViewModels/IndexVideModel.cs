using AmbulanceSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmbulanceSystem.ViewModels
{
    public class IndexVideModel
    {
        public ICollection<Ambulance> Ambulances { get; set; }
        public ICollection<IPS> Ips { get; set; }
        public ICollection<Service> Services { get; set; }
    }
}
