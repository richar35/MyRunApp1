using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace MyRunApp.Models
{
    public class ShoeContext : DbContext
    {
        public ShoeContext(DbContextOptions<ShoeContext> options) : base(options) { }
        public DbSet<Shoe> Shoes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           

            modelBuilder.Entity<Shoe>().HasData(
                new Shoe
                {
                    ShoeId = 1,
                    Brand = "Brooks",
                    Name = "Ghost 13",
                    Use = "Road Running",
                    Support= "Neutral"
                    
                },
                  new Shoe
                  {
                      ShoeId = 2,
                      Brand = "Hoka",
                      Name = "Tennine",
                      Use = "Trail Running",
                      Support = "Stability"
                    
                  },
                  new Shoe
                  {
                      ShoeId =31,
                      Brand = "Saucany",
                      Name = "Triumph 17 LE",
                      Use = "Road Running",
                      Support = "Neutral"
                      
                  }

                );
        }
    }
}


