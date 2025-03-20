
using MarvelComicsApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace MarvelComicsApi.DbConn;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    
    // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    // {
    //     if (!optionsBuilder.IsConfigured)
    //     {
    //         optionsBuilder.UseSqlite("Data Source=Marvel_Comics.db");
    //     }
    // }
    public DbSet<Comic> Comics { get; set; }

    // public void SeedDataBase()
    // {
    //     using var scope = this.Database.BeginTransaction();
    //     this.Comics
    //         .Where(x => x.Id == Guid.Empty)
    //         .ToList()
    //         .ForEach(x => 
    //         {
    //             x.Id = Guid.NewGuid();
    //             x.CreatedAt = DateTime.Now;
    //         });
    //
    //     this.SaveChanges();
    //     scope.Commit();
    // }
}
