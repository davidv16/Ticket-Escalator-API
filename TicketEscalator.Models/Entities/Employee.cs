using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace TicketEscalator.Models.Entities
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        // Navigation Properties
        public ICollection<Repair> Repairs { get; set; }
        
        public ICollection<Ticket> Creator { get; set; }
        public ICollection<Ticket> Assignee { get; set; }
    }
}