﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProductionHouseDAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ProductionHouseEntities : DbContext
    {
        public ProductionHouseEntities()
            : base("name=ProductionHouseEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ActorEntity> ActorEntities { get; set; }
        public virtual DbSet<MovieEntity> MovieEntities { get; set; }
        public virtual DbSet<ProducerEntity> ProducerEntities { get; set; }
    }
}
