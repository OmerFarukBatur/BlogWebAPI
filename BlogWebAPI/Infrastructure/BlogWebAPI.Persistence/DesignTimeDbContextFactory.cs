using BlogWebAPI.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogWebAPI.Persistence
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<BlogWebAPIDbContext>
    {
        public BlogWebAPIDbContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<BlogWebAPIDbContext> dbContextOptionsBuilder = new();
            dbContextOptionsBuilder.UseOracle(Configuration.ConfigurationString);
            return new(dbContextOptionsBuilder.Options);
        }
    }
}
