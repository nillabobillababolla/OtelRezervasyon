﻿using System.Data.Entity;
using Otel.Models.Abstracts;
using Otel.Models.Entities;

namespace Otel.DAL
{
    public class MyContext : DbContext
    {
        public MyContext() : base("name=OtelCon")
        { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Room>()
                .Property(x => x.Price).HasPrecision(11, 2);

            modelBuilder.Entity<Product>()
                .Property(x => x.Price).HasPrecision(11, 2);
        }

        public virtual DbSet<Room> Rooms { get; set; }

        public virtual DbSet<RoomCategory> RoomCategories { get; set; }

        public virtual DbSet<Reservation> Reservations { get; set; }
        public virtual DbSet<ReservationDetail> ReservationDetails { get; set; }

        public virtual DbSet<Product> Products { get; set; }

        public virtual DbSet<Category> Categories { get; set; }
    }
}
