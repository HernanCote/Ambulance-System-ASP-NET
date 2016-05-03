using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmbulanceSystem.Entities
{
    public class AmbulanceSystemContext : DbContext
    {
        public virtual DbSet<Ambulance> Ambulance { get; set; }
        public virtual DbSet<IPS> Ips { get; set; }
        public virtual DbSet<Direction> Direction { get; set; }
        public virtual DbSet<Service> Service { get; set; }
    }
}
