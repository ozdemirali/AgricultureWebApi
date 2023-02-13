using AgricultureWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace AgricultureWebApi.Context
{
    public class AgricultureDbContext:DbContext
    {
        public AgricultureDbContext(DbContextOptions<AgricultureDbContext> options):base(options)
        {

        }

        public DbSet<AgriculturalType> AgriculturalTypes { get; set; }  
        public DbSet<Disease> Diseases { get; set; }
        public DbSet<AgriculturalDisease> AgriculturalDiseases { get; set; }
        public DbSet<AgriculturalProduct> AgriculturalProduct { get; set; }
        public DbSet<Error> Errors { get; set; }


    }
}
