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
        readonly  Dictionary<int, Account> Accounts = new Dictionary<int, Account>();

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
            Accounts.Add(1, new Account() {Username = "admin", Password = "test123", PermissionGroup = PermissionGroups.ADMIN});
            Accounts.Add(2, new Account() {Username = "user", Password = "test123", PermissionGroup = PermissionGroups.USER});
            Accounts.Add(3, new Account() {Username = "guest", Password = "test123", PermissionGroup = PermissionGroups.GUEST});

            foreach (var account in Accounts.Values)
            {
                context.Accounts.Add(account);
            }

            context.SaveChanges();
        }
    }
}
