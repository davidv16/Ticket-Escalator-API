using System.Collections.Generic;

namespace TicketEscalator.Models.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? SerialNumber { get; set; }
        public int? Usage { get; set; }

        // Navigation Properties
        public ICollection<Customer> Customers { get; set; }
        public ICollection<Ticket> Tickets { get; set; }
        public ICollection<SparePart> SpareParts { get; set; }
    }
}