using HotelUygulama.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelUygulama.DAL
{
    public class HotelDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = LAPTOP-VOH1K0NB;Database = HotelApiDB;Trusted_Connection=true;");
        }
        public DbSet<Hotel> hotels { get; set; }

    }
}
