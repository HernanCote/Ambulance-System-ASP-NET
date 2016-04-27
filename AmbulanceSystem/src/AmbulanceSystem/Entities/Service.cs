using AmbulanceSystem.Enums;
using System;

namespace AmbulanceSystem.Entities
{
    public class Service
    {
        public IPS Ips { get; set; }
        public Ambulance Ambulance { get; set; }
        public Direction Direction { get; set; }
        public int Id { get; set; }
        public DateTime TimeOfRequest { get; set; }
        public string Pacient { get; set; }
        public string Phone { get; set; }
        public ServiceType Type { get; set; }
        public ServiceState State { get; set; }
    }
}