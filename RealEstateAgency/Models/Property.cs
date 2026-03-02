namespace RealEstateAgency.Models
{
    public class Property
    {
        public int Id { get; set; }

        public string Address { get; set; }
        public decimal Price { get; set; }
        public int Rooms { get; set; }

        public int OwnerId { get; set; }
        public Owner Owner { get; set; }

        public int CityId { get; set; }
        public City City { get; set; }

        public int PropertyTypeId { get; set; }
        public PropertyType PropertyType { get; set; }
    }
}