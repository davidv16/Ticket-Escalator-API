using System;
using System.Collections.Generic;

namespace TicketEscalator.Models.Entities
{
    public class Repair
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public double DaytimeHours { get; set; }
        public double OvertimeHours { get; set; }
        public int Trip { get; set; }

        // code generated
        public DateTime RepairDate { get; set; }

        // Navigation Properties
        public ICollection<Employee> Employees { get; set; }
        
    }
}