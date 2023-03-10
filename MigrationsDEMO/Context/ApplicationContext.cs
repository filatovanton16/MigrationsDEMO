using Microsoft.EntityFrameworkCore;
using MigrationsDEMO.Model;

namespace MigrationsDEMO.Context;

public class ApplicationContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Books1DB");
    }

    public DbSet<Book> Books => Set<Book>();
}