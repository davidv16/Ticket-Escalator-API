using Microsoft.EntityFrameworkCore;
using TicketEscalator.Models.Entities;

namespace TicketEscalator.Repositories.Contexts
{
    public class TicketEscalatorDbContext : DbContext
    {
        public TicketEscalatorDbContext(DbContextOptions<TicketEscalatorDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Ticket>( act => {
                act.HasOne(field => field.Creator)
                    .WithMany(fk => fk.Creator)
                    .HasForeignKey(fk => fk.CreatorID)
                    .HasConstraintName("Creator_FK");

                act.HasOne(field => field.Assignee)
                    .WithMany(fk => fk.Assignee)
                    .HasForeignKey(fk => fk.AssigneeID)
                    .HasConstraintName("Assignee_FK");

            });
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerContact> CustomerContacts { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Repair> Repairs { get; set; }
        public DbSet<SparePart> SpareParts { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
    }
}