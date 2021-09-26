using System.Collections.Generic;

namespace TicketEscalator.Models.Entities
{
    public class SparePart
    {
        public int Id { get; set; }
        public string? PartsNumber { get; set; }
        public string Name { get; set; }
        public int? Price { get; set; }

        // Navigation Properties
        public ICollection<Product> Products { get; set; }
        public ICollection<Ticket> Tickets { get; set; }
    }
}