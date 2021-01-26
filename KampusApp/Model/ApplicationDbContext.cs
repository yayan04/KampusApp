using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KampusApp.Model
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }

        public DbSet<Mahasiswa> Mahasiswa { get; set; }

        public DbSet<Matakuliah> Matakuliah { get; set; }

        public DbSet<Akademik> Akademik { get; set; }
    }
}
