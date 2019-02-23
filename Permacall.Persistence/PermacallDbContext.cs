using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Permacall.Domain.Entities;

namespace Permacall.Persistence
{
    public class PermacallDbContext : DbContext
    {
        public PermacallDbContext(DbContextOptions<PermacallDbContext> options)
        :base(options)
        { }

        public DbSet<Account> Accounts { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(PermacallDbContext).Assembly);
        }
    }
}
