﻿using Microsoft.EntityFrameworkCore;
using WebsiteDotnet.Models;

namespace WebsiteDotnet.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Category>  Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
                new Category { Id = 2, Name = "SciFi", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Spotify", DisplayOrder = 3 },
                new Category { Id = 4, Name = "Youtube", DisplayOrder = 4 },
                new Category { Id = 5, Name = "Google", DisplayOrder = 5 }
                );

        }

    }
}
