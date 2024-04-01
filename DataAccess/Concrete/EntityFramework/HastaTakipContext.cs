using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class HastaTakipContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=HastaTakip;Trusted_Connection=true");
        }
        public DbSet<Date> Dates { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Medicine> Medicines { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
