﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TeknikServis
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class DbTeknikServisEntities : DbContext
    {
        public DbTeknikServisEntities()
            : base("name=DbTeknikServisEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TBLADMIN> TBLADMIN { get; set; }
        public virtual DbSet<TBLARAÇLAR> TBLARAÇLAR { get; set; }
        public virtual DbSet<TBLARIZADETAY> TBLARIZADETAY { get; set; }
        public virtual DbSet<TBLCARİ> TBLCARİ { get; set; }
        public virtual DbSet<TBLDEPARTMAN> TBLDEPARTMAN { get; set; }
        public virtual DbSet<TBLFATURABİLGİ> TBLFATURABİLGİ { get; set; }
        public virtual DbSet<TBLFATURADETAY> TBLFATURADETAY { get; set; }
        public virtual DbSet<TBLGIDER> TBLGIDER { get; set; }
        public virtual DbSet<TBLKATEGORİ> TBLKATEGORİ { get; set; }
        public virtual DbSet<TBLNOTLAR> TBLNOTLAR { get; set; }
        public virtual DbSet<TBLPERSONEL> TBLPERSONEL { get; set; }
        public virtual DbSet<TBLURUN> TBLURUN { get; set; }
        public virtual DbSet<TBLURUNHAREKET> TBLURUNHAREKET { get; set; }
        public virtual DbSet<TBLURUNKABUL> TBLURUNKABUL { get; set; }
        public virtual DbSet<TBLURUNTAKİP> TBLURUNTAKİP { get; set; }
        public virtual DbSet<TBLHAKKIMIZDA> TBLHAKKIMIZDA { get; set; }
        public virtual DbSet<TBLİLETİŞİM> TBLİLETİŞİM { get; set; }
        public virtual DbSet<TBLİLCELER> TBLİLCELER { get; set; }
        public virtual DbSet<TBLİLLER> TBLİLLER { get; set; }
    
        public virtual ObjectResult<string> makskategori()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("makskategori");
        }
    
        public virtual ObjectResult<string> maksurunmarka()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("maksurunmarka");
        }
    }
}
