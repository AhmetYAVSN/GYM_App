﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SporSalonuUygulaması
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DBSporSalonuEntities : DbContext
    {
        public DBSporSalonuEntities()
            : base("name=DBSporSalonuEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tbl_AntremanProgrami> tbl_AntremanProgrami { get; set; }
        public virtual DbSet<tbl_antrenor> tbl_antrenor { get; set; }
        public virtual DbSet<tbl_GirisKarti> tbl_GirisKarti { get; set; }
        public virtual DbSet<tbl_Gunler> tbl_Gunler { get; set; }
        public virtual DbSet<tbl_PersonelBilgileri> tbl_PersonelBilgileri { get; set; }
        public virtual DbSet<tbl_Program> tbl_Program { get; set; }
        public virtual DbSet<tbl_Saatler> tbl_Saatler { get; set; }
        public virtual DbSet<tbl_UyeBilgileri> tbl_UyeBilgileri { get; set; }
    }
}
