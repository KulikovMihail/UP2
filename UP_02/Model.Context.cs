﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UP_02
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    public partial class Entities : DbContext
    {
        private static Entities _context;

        public Entities()
            : base("name=Entities")
        {
        }

        public static Entities GetContext()
        {
            if (_context == null)
                _context = new Entities();
            return _context;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        public virtual DbSet<MaterialType> MaterialType { get; set; }
        public virtual DbSet<PartnerProducts> PartnerProducts { get; set; }
        public virtual DbSet<Partners> Partners { get; set; }
        public virtual DbSet<PartnersType> PartnersType { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<ProductsType> ProductsType { get; set; }
    }
}