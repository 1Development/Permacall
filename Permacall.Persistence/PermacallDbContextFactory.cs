using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Permacall.Persistence.Infrastructure;

namespace Permacall.Persistence
{
    public class PermacallDbContextFactory : DesignTimeDbContextFactoryBase<PermacallDbContext>
    {
        protected override PermacallDbContext CreateNewInstance(DbContextOptions<PermacallDbContext> options)
        {
            return new PermacallDbContext(options);
        }
    }
}
