﻿using CategoriesWebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace CategoriesWebApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        public DbSet<Category> Categories { get; set; }
    }
}