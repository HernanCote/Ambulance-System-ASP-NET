using System;

namespace AmbulanceSystem.Entities
{
    public class Service
    {
        public IPS Ips { get; set; }
        public Ambulance Ambulance { get; set; }
        public int Id { get; set; }
        public DateTime TimeOfRequest { get; set; }
        public String Pacient { get; set; }
        public string Phone { get; set; }
        public string State { get; set; }
        public Direction Direction {get; set;}
    }
}