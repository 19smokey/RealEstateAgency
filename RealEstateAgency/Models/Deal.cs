using System;

namespace RealEstateAgency.Models
{
    public class Deal
    {
        public int Id { get; set; }

        public int ClientId { get; set; }
        public Client Client { get; set; }

        public int AgentId { get; set; }
        public Agent Agent { get; set; }

        public int PropertyId { get; set; }
        public Property Property { get; set; }

        public DateTime DealDate { get; set; }
    }
}