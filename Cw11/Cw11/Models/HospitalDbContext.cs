using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cw11.Models
{
    public class HospitalDbContext : DbContext 
    {
        
        public HospitalDbContext() { }

        public HospitalDbContext(DbContextOptions options)
        :base(options){

        }


        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        public DbSet<Medicament> Medicaments { get; set; }
        public DbSet<PrescriptionMedicament> Prescriptions_Medicaments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<PrescriptionMedicament>()
                .HasKey(e => e.IdMedicament);
            modelBuilder.Entity<PrescriptionMedicament>()
                .HasKey(e => e.IdPrescription);
            
                
        }
    }
}
