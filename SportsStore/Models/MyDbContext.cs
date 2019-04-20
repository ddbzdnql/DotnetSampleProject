using System;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace SportsStore.Models
{
    public class MyDbContext : DbContext{
        public MyDbContext(DbContextOptions<MyDbContext> opt)
            : base(opt) { }

        public DbSet<Product> Products { get; set; }
    }
}
