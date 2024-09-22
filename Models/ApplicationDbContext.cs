using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace book.Models
{
    public class ApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
           : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        internal async Task SaveChangesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
