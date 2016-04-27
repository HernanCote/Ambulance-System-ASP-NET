using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmbulanceSystem.Entities
{
    public class AmbulanceCompany
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Ambulance> AmbulanceList { get; set; }
        public ICollection<Service> ServicesList { get; set; }
        public ICollection<IPS> IpsList { get; set; }
    }
}
