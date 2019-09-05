using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

 namespace PrograLabPC1.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext (DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }

         public DbSet<Factura> Factura { get; set; }

     }
} 