using MachinistShiftProject.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachinistShiftProject.DataAccess
{
    public class MachinistShiftDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=S2771; Database=MachinistShiftDb; Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
               
        }
        public DbSet<Machinist> Machinists { set; get; }
        public DbSet<Expedition> Expedition { set; get; }
        public DbSet<TaskDefinition> TaskDefinitions { set; get; }
        public DbSet<TaskTitle> TaskTitles { set; get; }
        public DbSet<Title> Titles { get; set; }
        public DbSet<Staff> Staffs { get; set; }
    }
}
