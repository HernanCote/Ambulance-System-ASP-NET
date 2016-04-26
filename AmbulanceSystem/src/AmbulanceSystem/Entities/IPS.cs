using System.Collections.Generic;

namespace AmbulanceSystem.Entities
{
    public class IPS
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public List<Service> ServicesList { get; set; }
        public Direction Direction { get; set; }
    }
}