﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OurBlog.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class blogEntities : DbContext
    {
        public blogEntities()
            : base("name=blogEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<discussinfos> discussinfos { get; set; }
        public DbSet<docclassts> docclassts { get; set; }
        public DbSet<docclsrelations> docclsrelations { get; set; }
        public DbSet<docclss> docclss { get; set; }
        public DbSet<dockeywords> dockeywords { get; set; }
        public DbSet<docs> docs { get; set; }
        public DbSet<docstatinfos> docstatinfos { get; set; }
        public DbSet<docstores> docstores { get; set; }
        public DbSet<docwritetimeorders> docwritetimeorders { get; set; }
        public DbSet<filemaps> filemaps { get; set; }
        public DbSet<menus> menus { get; set; }
        public DbSet<roleauthrights> roleauthrights { get; set; }
        public DbSet<roles> roles { get; set; }
        public DbSet<userroles> userroles { get; set; }
        public DbSet<users> users { get; set; }
        public DbSet<userselfsettings> userselfsettings { get; set; }
        public DbSet<userthirdnomaps> userthirdnomaps { get; set; }
    }
}
