using System.Collections.Generic;
using System.Linq;
using RealEstateAgency.Data;
using RealEstateAgency.Models;

namespace RealEstateAgency.Services
{
    public class PropertyService
    {
        AppDbContext db = new AppDbContext();

        public List<Property> GetAll()
        {
            return db.Properties.ToList();
        }

        public void Add(Property property)
        {
            db.Properties.Add(property);
            db.SaveChanges();
        }
    }
}