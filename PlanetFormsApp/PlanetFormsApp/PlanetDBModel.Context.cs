﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PlanetFormsApp
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Plant_DBEntities : DbContext
    {
        public Plant_DBEntities()
            : base("name=Plant_DBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<categories> categories { get; set; }
        public DbSet<customers> customers { get; set; }
        public DbSet<farmer_location> farmer_location { get; set; }
        public DbSet<farmers> farmers { get; set; }
        public DbSet<location_plant> location_plant { get; set; }
        public DbSet<locations> locations { get; set; }
        public DbSet<plant_brands> plant_brands { get; set; }
        public DbSet<plants> plants { get; set; }
        public DbSet<sales> sales { get; set; }
    }
}
