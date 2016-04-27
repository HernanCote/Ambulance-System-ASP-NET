using AmbulanceSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmbulanceSystem.Services
{
    public class SqlAmbulanceCompanyData : IServicesAmbulance
    {
        private AmbulanceSystemContext _context;

        public SqlAmbulanceCompanyData(AmbulanceSystemContext context)
        {
            _context = context;
        }

        public void AddAmbulance(Ambulance Ambulance)
        {
            _context.Ambulance.Add(Ambulance);
        }

        public void AddIps(IPS Ips)
        {
            _context.Ips.Add(Ips);
        }

        public int Commit()
        {
            return _context.SaveChanges();
        }
    }
}
