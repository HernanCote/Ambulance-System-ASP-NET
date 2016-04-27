using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmbulanceSystem.Entities
{
    public class AmbulanceCompany : IServicesAmbulance  
    {
        public string Name { get; set; }

        private List<Ambulance> AmbulanceList;
        private List<Service> ServicesList;
        private List<IPS> IpsList;


        public void AddAmbulance(Ambulance Ambulance)
        {
            AmbulanceList.Add(Ambulance);
        }

        public void AddIps(IPS Ips)
        {
            IpsList.Add(Ips);
        }

        public void FinalizeAService()
        {
            throw new NotImplementedException();
        }

        public void RegisterAmbulancePosition()
        {
            throw new NotImplementedException();
        }

        public void RegisterAService()
        {
            throw new NotImplementedException();
        }
    }
}
