using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using PetzyTrial.Model.Entity;

namespace PetzyTrial.Model.Data
{
    public class PetzyTrialDbContext:DbContext
    {
      protected internal void OnConfiguring(DbContextOptionsBuilder optionsbuilder)
        {
            optionsbuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=PetzyTrialDb;Integrated Security=True");
        }

         public DbSet<Pet> Pets { get; set; }
        public DbSet<Vet> Vets { get; set; }

    }
}
