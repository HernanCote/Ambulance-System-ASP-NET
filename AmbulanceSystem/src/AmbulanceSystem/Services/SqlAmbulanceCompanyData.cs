using AmbulanceSystem.Entities;
using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;

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

        public int CountOfAmbulances()
        {
            var ambu = _context.Ambulance.ToList();
            int count = 0;
            foreach (Ambulance ambulancia in ambu)
            {
                count++;
            }
            return count;
        }

        public void AddIps(IPS Ips)
        {
            _context.Ips.Add(Ips);
        }

        public void AddDirection(Direction direction)
        {
            _context.Direction.Add(direction);
        }

        public void AddService(Service service)
        {
            _context.Service.Add(service);
        }

        public ICollection<Ambulance> GetAllAmbulances()
        {
            return _context.Ambulance.OrderBy(a => a.AmbulanceCode).ToList();
        }

        public ICollection<IPS> GetAllIps()
        {
            return _context.Ips.Include(i => i.Direction).ToList();
        }

        public ICollection<Service> GetAllServices()
        {
            return _context.Service.ToList();
        }

        public ICollection<Direction> GetAllDirections()
        {
            return _context.Direction.ToList();
        }
        public Ambulance GetAmbulanceById(int id)
        {            
            return _context.Ambulance.FirstOrDefault(a => a.Id == id);
        }

        public IPS GetIpsById(int id)
        {
            return _context.Ips.FirstOrDefault(i => i.Id == id);
        }

        public Service GetServiceById(int id)
        {
            return _context.Service.FirstOrDefault(s => s.Id == id);
        }

        public Direction GetDirectionById(int id)
        {
            return _context.Direction.FirstOrDefault(d => d.Id == id);
        }
        public int Commit()
        {
            return _context.SaveChanges();
        }
    }
}
