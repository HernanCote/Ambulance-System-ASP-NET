using System;
using System.Collections.Generic;

namespace AmbulanceSystem.Entities
{
    public class Ambulance
    {
        public int Id { get; set; }
        public List<Service> ServicesList {get; set; }
        public long AmbulanceCode { get; set; }
        public string Plate { get; set; }
        public DateTime TimeOfPosition { get; set; }
        public int StreetPosition { get; set; }
        public int RoadPosition { get; set; }
        public String Type { get; set; }
        public AmbulanceState State { get; set; }
    }
}