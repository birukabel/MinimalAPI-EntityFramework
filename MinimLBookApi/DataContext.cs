global using Microsoft.EntityFrameworkCore;
using System.Data.Entity;

namespace MinimLBookApi
{
    public class DataContext: Microsoft.EntityFrameworkCore.DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)
        { 
        
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { 
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("data source=DESKTOP-V0UBMDF\\SQLEXPRESS; initial catalog=minimalBookdb;TrustServerCertificate=True;integrated security=True;");
        }

        public Microsoft.EntityFrameworkCore.DbSet<Book> Books => Set<Book>();
    }
}
