using Microsoft.EntityFrameworkCore;
using API_Transaction.Models.Entities;

namespace API_Transaction.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {           
        }

        public DbSet<Transaction> Transactions { get; set; }
    }
}
