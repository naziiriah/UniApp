using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UniApp.Models;

namespace UniApp.Data
{
    public class SchoolContext : DbContext
    {
        public SchoolContext (DbContextOptions<SchoolContext> options)
            : base(options)
        {
        }

        public DbSet<UniApp.Models.Student> Student { get; set; } = default!;
        public DbSet<UniApp.Models.Instructor> Instructor { get; set; } = default!;
    }
}
