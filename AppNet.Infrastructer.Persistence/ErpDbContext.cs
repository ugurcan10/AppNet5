using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using Microsoft.Graph;

namespace AppNet.Infrastructer.Persistence
{
    public class ErpDbContext:DbContext
    {
        //"Data Source=LAPTOP-K6ASI2P2;Initial Catalog=AAA;User Id=sa;Password=123456"
        //"Data Source=LAPTOP-K6ASI2P2;Initial Catalog=AAA;User Id=sa;Password=123456"


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {  
            if (!optionsBuilder.IsConfigured)
            {
                ////IConfigurationRoot configuration = new ConfigurationBuilder()
                ////    .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                ////    .AddJsonFile("appsettings.json")
                ////    .Build();


                optionsBuilder.UseSqlServer(DbSettings.Load().ConStr);

            }
        }




















        /*IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json")
            .Build();
        IConfigurationSection dbContext = configuration.GetSection("VT1");
        String aa = dbContext.Value;
        optionsBuilder.UseSqlServer(configuration.GetConnectionString(aa));*/





        //connectionstrings.com



        /*
         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
        .UseSqlServer(
        "Data Source=LAPTOP-K6ASI2P2;Initial Catalog=AAA;User Id=sa;Password=123456"
                      );

        //connectionstrings.com
    }

         */




        //public DbSet <User> Users { get; set; }


    }
}
