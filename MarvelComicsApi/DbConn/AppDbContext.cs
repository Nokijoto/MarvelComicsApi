

using MarvelComicsApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace MarvelComicsApi.DbConn;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }
    
    public DbSet<Comic> Comics { get; set; }

   
    
}