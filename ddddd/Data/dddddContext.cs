using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ddddd.Models;

namespace ddddd.Data
{
    public class dddddContext : DbContext
    {
        public dddddContext (DbContextOptions<dddddContext> options)
            : base(options)
        {
        }

        public DbSet<ddddd.Models.Student> Student { get; set; } = default!;
        public DbSet<ddddd.Models.Actor> Actor { get; set; } = default!;
    }
}
