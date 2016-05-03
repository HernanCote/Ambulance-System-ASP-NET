using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmbulanceSystem.Entities
{
    public interface IServicesAmbulance
    {
        ICollection<Ambulance> GetAllAmbulances();
        ICollection<IPS> GetAllIps();
        ICollection<Service> GetAllServices();
        ICollection<Direction> GetAllDirections();
        Ambulance GetAmbulanceById(int id);
        IPS GetIpsById(int id);
        Service GetServiceById(int id);
        Direction GetDirectionById(int id);
        void AddIps(IPS ips);
        void AddAmbulance(Ambulance ambulance);
        void AddService(Service service);
        void AddDirection(Direction direction);
        int Commit();        
    }
}
