using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Permacall.Domain.Entities;
using Permacall.Domain.Enumerators;

namespace Permacall.Persistence
{
    public class PermacallInitializer
    {
        public static void Initialize(PermacallDbContext context)
        {
            var initializer = new PermacallInitializer();
            initializer.SeedEverything(context);
        }

        public void SeedEverything(PermacallDbContext context)
        {
            context.Database.EnsureCreated();
            if (context.Accounts.Any())
                return;

            SeedAccounts(context);
        }

        public void SeedAccounts(PermacallDbContext context)
        {
            var accounts = new[]
            {
                new Account() {Username = "admin", Password = "test123", PermissionGroup = PermissionGroups.ADMIN},
                new Account() {Username = "user", Password = "test123", PermissionGroup = PermissionGroups.USER},
                new Account() {Username = "guest", Password = "test123", PermissionGroup = PermissionGroups.GUEST},
            };

            context.Accounts.AddRange(accounts);
            context.SaveChanges();
        }
    }
}
