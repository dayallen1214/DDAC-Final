﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Maersk_Line
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MaerskDDACEntities : DbContext
    {
        public MaerskDDACEntities()
            : base("name=MaerskDDACEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<Booking> Bookings { get; set; }
        public virtual DbSet<Container> Containers { get; set; }
        public virtual DbSet<Ship> Ships { get; set; }
        public virtual DbSet<ShipYard> ShipYards { get; set; }
        public virtual DbSet<Warehouse> Warehouses { get; set; }
    }
}
