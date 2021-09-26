using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace TicketEscalator.Models.Entities
{
    public class Ticket
    {
        public int Id { get; set; }
        public string ExtraItems { get; set; }
        public string Description { get; set; }
        public bool CustomerContacted { get; set; }
        

        // Code Generated
        public DateTime RegisterDate { get; set; }
        public DateTime ReadyDate { get; set; }
        
        // Navigation Properties
        public int CreatorID { get; set; }
        public int AssigneeID { get; set; }
        public Employee Creator { get; set; }
        public Employee Assignee { get; set; }
        public Customer Customer { get; set; }
        public ICollection<Product> Products { get; set; }
        public ICollection<Repair> Repairs { get; set; }
        public ICollection<SparePart> SpareParts { get; set; }

    }
}