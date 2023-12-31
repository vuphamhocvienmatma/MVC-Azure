﻿using Microsoft.EntityFrameworkCore;

namespace Blazor_Azure.Data
{
    public class AzureCosmosDbContext : DbContext
    {
        public AzureCosmosDbContext(DbContextOptions<AzureCosmosDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Engineer>()
                .HasPartitionKey(o => o.id);
        }

        public DbSet<Engineer> Engineers { get; set; }
    }
}
