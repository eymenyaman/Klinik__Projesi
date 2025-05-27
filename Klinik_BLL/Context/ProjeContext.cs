using Klinik.ENTITY;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klinik.DAL.Context
{
    public class ProjeContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=EYMEN\\SQLDERS;Database=KlinikDB;Integrated Security=True;TrustServerCertificate=True");
        }
        
        public DbSet<Doctor> doctors { get; set; }
        public DbSet<About> abouts { get; set; }
        public DbSet<Contact> contacts { get; set; }
        public DbSet<Testımonıal> testımonıals { get; set; }

    }
}
