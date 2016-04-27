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
        public DbSet<Ambulance> Ambulance { get; set; }
        public DbSet<IPS> Ips { get; set; }
        public DbSet<Direction> Direction { get; set; }
        public DbSet<Service> Service { get; set; }
    }
}
