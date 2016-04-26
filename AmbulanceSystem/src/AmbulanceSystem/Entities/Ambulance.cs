using System;
using System.Collections.Generic;

namespace AmbulanceSystem.Entities
{
    public class Ambulance
    {
        public int Id { get; set; }
        public List<Service> ServicesList {get; set; }
        public string Plate { get; set; }
        public DateTime TimeOfPosition { get; set; }
        public int Street { get; set; }
        public int Avenue { get; set; }
        public String Type { get; set; }

    }
}