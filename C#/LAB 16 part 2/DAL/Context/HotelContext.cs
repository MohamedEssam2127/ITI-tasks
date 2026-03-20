
using D16PCSharp_HotelManagement.Entities;
using HotelManagment.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Context
{
    public  class HotelContext:DbContext
    {
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<KitchenLog> Kitchens { get; set; }
        public DbSet<FrontendLog> Frontends { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
          => optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=Hotel_Management;Integrated Security=True;Encrypt=false");

    }
}
