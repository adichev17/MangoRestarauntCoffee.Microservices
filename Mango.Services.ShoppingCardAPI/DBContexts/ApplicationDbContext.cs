﻿using Mango.Services.ShoppingCardAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Mango.Services.ShoppingCardAPI.DBContexts
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<CartHeader> CartHeaders { get; set; }
        public DbSet<CartDetails> CartDetails { get; set; }
    }
}
