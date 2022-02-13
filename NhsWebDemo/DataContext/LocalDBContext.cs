using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NhsWebDemo.DataContext
{
    public class LocalDBContext : DbContext
    {
        public LocalDBContext(DbContextOptions<LocalDBContext> options)
            : base(options)
        {
        }

        public DbSet<Models.LocalUserModel> LocalUserModels { get; set; }
        public DbSet<Models.LocalUserMapModel> LocalUserMapModels { get; set; }
    }
}
