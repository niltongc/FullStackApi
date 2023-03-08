using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FullStackAPI.Moldes;
using Microsoft.EntityFrameworkCore;

namespace FullStackAPI.Data
{
    public class FullStackDbContext: DbContext
    {
        public FullStackDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Employee> Employees { get; set; }
    }
}