using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ChapterOneProject
{
    public class VetContext:DbContext
    {
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Visit> Visits { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AnimalType>()
                        .ToTable("Species");
            modelBuilder.Entity<AnimalType>()
                        .Property(p => p.TypeName).IsRequired();

        }


    }
}
