namespace TicketEscalator.Models.Entities
{
    public class CustomerContact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        // Navigation Properties
        public Customer Customer { get; set; }
    }
}