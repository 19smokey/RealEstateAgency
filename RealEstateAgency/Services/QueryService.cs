using System.Linq;
using RealEstateAgency.Data;

namespace RealEstateAgency.Services
{
    public class QueryService
    {
        AppDbContext db = new AppDbContext();

        // квартиры в городе
        public object ByCity(string city)
        {
            return db.Properties
                .Where(p => p.City.Name == city)
                .Select(p => new { p.Address, p.Price })
                .ToList();
        }

        // квартиры по цене
        public object ByPrice(decimal min, decimal max)
        {
            return db.Properties
                .Where(p => p.Price >= min && p.Price <= max)
                .Select(p => new { p.Address, p.Price })
                .ToList();
        }

        // клиенты со сделками
        public object ClientsWithDeals()
        {
            return db.Deals
                .Select(d => new
                {
                    Client = d.Client.Name,
                    Property = d.Property.Address
                }).ToList();
        }
    }
}