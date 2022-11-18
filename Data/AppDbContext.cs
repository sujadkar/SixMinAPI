using Microsoft.EntityFrameworkCore;
using SixMinAPI.Models;
using Microsoft.EntityFrameworkCore.Design;

namespace SixMinAPI.Data{
    public class AppDbContext : DbContext{
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<Command> Commands => Set<Command>();
    }


    public class AppDbContextFactery : IDesignTimeDbContextFactory<AppDbContext>{
        //private readonly IConfiguration _configuration;
        public AppDbContextFactery()
        {
            //_configuration = configuration;
        }

    
        public AppDbContext CreateDbContext(string[] args)
        {
            var connectionString = "Server=localhost,1433;Database=CommandsDB;User Id=sa;Password=Sujay@123;Encrypt=False";
       
         var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
        optionsBuilder.UseSqlServer(connectionString);

        return new AppDbContext(optionsBuilder.Options);   
        
        }
    }
}