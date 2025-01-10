using System;
using Elif.Entity;
using Microsoft.EntityFrameworkCore;

namespace Elif.Data.Concrete.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {

    }
    public DbSet<Product> Products { get; set; } 
}
