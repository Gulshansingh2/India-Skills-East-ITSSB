﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ITSSB
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MarathonSkills2015Entities : DbContext
    {
        public MarathonSkills2015Entities()
            : base("name=MarathonSkills2015Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Charity> Charities { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<EventType> EventTypes { get; set; }
        public virtual DbSet<Gender> Genders { get; set; }
        public virtual DbSet<Marathon> Marathons { get; set; }
        public virtual DbSet<Position> Positions { get; set; }
        public virtual DbSet<RaceKitOption> RaceKitOptions { get; set; }
        public virtual DbSet<Registration> Registrations { get; set; }
        public virtual DbSet<RegistrationEvent> RegistrationEvents { get; set; }
        public virtual DbSet<RegistrationStatu> RegistrationStatus { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Runner> Runners { get; set; }
        public virtual DbSet<Sponsorship> Sponsorships { get; set; }
        public virtual DbSet<Staff> Staffs { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Volunteer> Volunteers { get; set; }
    }
}