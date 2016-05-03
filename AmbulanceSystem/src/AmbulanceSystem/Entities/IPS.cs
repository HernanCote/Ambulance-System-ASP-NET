using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace AmbulanceSystem.Entities
{
    public class IPS
    {
        public ICollection<Service> ServicesList { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public virtual Direction Direction { get; set; }
        
    }
}