using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NhsWebDemo.DataContext
{
    public class NhsDBContext : DbContext
    {
        public NhsDBContext(DbContextOptions<NhsDBContext> options)
            : base(options)
        {
        }

        public DbSet<Models.NationalModel> NationalModels { get; set; }
        public DbSet<Models.RegionalModel> RegionalModels { get; set; }
        public DbSet<Models.LocalModel> LocalModels { get; set; }
    }
}
