﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Omu.ProDinner.Core.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class prodinnerEntities : DbContext
    {
        public prodinnerEntities()
            : base("name=prodinnerEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<chef> chefs { get; set; }
        public virtual DbSet<country> countries { get; set; }
        public virtual DbSet<dinner> dinners { get; set; }
        public virtual DbSet<feedback> feedbacks { get; set; }
        public virtual DbSet<meal> meals { get; set; }
        public virtual DbSet<role> roles { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<user> users { get; set; }
    }
}