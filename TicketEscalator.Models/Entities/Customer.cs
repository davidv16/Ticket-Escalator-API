using System.Collections.Generic;

namespace TicketEscalator.Models.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Address { get; set; }
        public string SSN { get; set; }
        
        // Navigation Properties
        public ICollection<Ticket> Tickets { get; set; }
        public ICollection<Product> Products { get; set; }
        public ICollection<CustomerContact> Contacts { get; set; }
    }
}