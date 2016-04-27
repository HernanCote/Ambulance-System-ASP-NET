using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmbulanceSystem.Entities
{
    public interface IServicesAmbulance
    {
        void AddIps(IPS Ips);
        void AddAmbulance(Ambulance Ambulance);
        int Commit();
        
    }
}
