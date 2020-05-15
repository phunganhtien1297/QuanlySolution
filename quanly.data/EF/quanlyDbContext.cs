using Microsoft.EntityFrameworkCore;
using quanly.data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace quanly.data.EF
{
    public class quanlyDbContext : DbContext
    {
        public quanlyDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
    }
}
