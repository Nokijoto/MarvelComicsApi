﻿
using MarvelComicsApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace MarvelComicsApi.DbContext;

public class AppDbContext : Microsoft.EntityFrameworkCore.DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Comic> Comics { get; set; }    
}