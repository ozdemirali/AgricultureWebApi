using AgricultureWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace AgricultureWebApi.Context
{
    public class AgricultureDbContext:DbContext
    {
        public AgricultureDbContext(DbContextOptions<AgricultureDbContext> options):base(options)
        {

        }

        public DbSet<AgricalturalType> AgricalturalTypes { get; set; }  
        public DbSet<Disease> Diseases { get; set; }
        public DbSet<AgricalturalDisease> AgricalturalDiseases { get; set; }
        public DbSet<AgriculturalProduct> AgriculturalProduct { get; set; }


    }
}
