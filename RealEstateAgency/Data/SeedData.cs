using System;
using System.Linq;
using RealEstateAgency.Models;

namespace RealEstateAgency.Data
{
    public static class SeedData
    {
        public static void Initialize()
        {
            using var db = new AppDbContext();

            db.Database.EnsureCreated();

            // если база уже заполнена — не добавляем снова
            if (db.Properties.Any())
                return;

            // ===== ГОРОДА =====
            var moscow = new City { Name = "Москва" };
            var spb = new City { Name = "Санкт-Петербург" };

            db.Cities.AddRange(moscow, spb);

            // ===== ТИПЫ =====
            var flat = new PropertyType { Name = "Квартира" };
            var house = new PropertyType { Name = "Дом" };

            db.PropertyTypes.AddRange(flat, house);

            // ===== ВЛАДЕЛЬЦЫ =====
            var owner1 = new Owner { Name = "Иванов И.И.", Phone = "111-11-11" };
            var owner2 = new Owner { Name = "Сидоров С.С.", Phone = "222-22-22" };
            var owner3 = new Owner { Name = "Петров П.П.", Phone = "333-33-33" };

            db.Owners.AddRange(owner1, owner2, owner3);

            // ===== АГЕНТЫ =====
            var agent1 = new Agent { Name = "Анна Смирнова" };
            var agent2 = new Agent { Name = "Олег Кузнецов" };

            db.Agents.AddRange(agent1, agent2);

            // ===== КЛИЕНТЫ =====
            var client1 = new Client { Name = "Алексей", Phone = "900-01" };
            var client2 = new Client { Name = "Мария", Phone = "900-02" };
            var client3 = new Client { Name = "Дмитрий", Phone = "900-03" };

            db.Clients.AddRange(client1, client2, client3);

            db.SaveChanges();

            // ===== НЕДВИЖИМОСТЬ =====
            var p1 = new Property
            {
                Address = "Ленина 10",
                Price = 5_000_000,
                Rooms = 2,
                City = moscow,
                PropertyType = flat,
                Owner = owner1
            };

            var p2 = new Property
            {
                Address = "Пушкина 5",
                Price = 8_500_000,
                Rooms = 3,
                City = moscow,
                PropertyType = flat,
                Owner = owner2
            };

            var p3 = new Property
            {
                Address = "Невский 20",
                Price = 12_000_000,
                Rooms = 4,
                City = spb,
                PropertyType = house,
                Owner = owner3
            };

            var p4 = new Property
            {
                Address = "Арбат 1",
                Price = 3_200_000,
                Rooms = 1,
                City = moscow,
                PropertyType = flat,
                Owner = owner1
            };

            db.Properties.AddRange(p1, p2, p3, p4);

            db.SaveChanges();

            // ===== СДЕЛКИ =====
            db.Deals.AddRange(
                new Deal
                {
                    Client = client1,
                    Agent = agent1,
                    Property = p1,
                    DealDate = DateTime.Now.AddDays(-10)
                },
                new Deal
                {
                    Client = client2,
                    Agent = agent2,
                    Property = p3,
                    DealDate = DateTime.Now.AddDays(-5)
                },
                new Deal
                {
                    Client = client3,
                    Agent = agent1,
                    Property = p2,
                    DealDate = DateTime.Now.AddDays(-2)
                }
            );

            db.SaveChanges();
        }
    }
}