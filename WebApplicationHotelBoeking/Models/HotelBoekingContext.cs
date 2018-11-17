using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationHotelBoeking.Models
{
    public class HotelBoekingContext : DbContext
    {
        public DbSet<HotelBoeking> HotelBoeking { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=WebApplicationHotelBoeking;Trusted_Connection=True;");
        }


    }
}
