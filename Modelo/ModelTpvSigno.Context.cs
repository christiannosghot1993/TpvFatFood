﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Modelo
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TpvSignoEntities : DbContext
    {
        public TpvSignoEntities()
            : base("name=TpvSignoEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tbl_Factura_Detalle> tbl_Factura_Detalle { get; set; }
        public virtual DbSet<tbl_Arbol> tbl_Arbol { get; set; }
        public virtual DbSet<tbl_Nodo> tbl_Nodo { get; set; }
        public virtual DbSet<tbl_Privilegios> tbl_Privilegios { get; set; }
        public virtual DbSet<tbl_Roles> tbl_Roles { get; set; }
        public virtual DbSet<tbl_Usuarios> tbl_Usuarios { get; set; }
        public virtual DbSet<tbl_Productos> tbl_Productos { get; set; }
        public virtual DbSet<tbl_Familias> tbl_Familias { get; set; }
        public virtual DbSet<tbl_Clientes> tbl_Clientes { get; set; }
        public virtual DbSet<tbl_Proveedores> tbl_Proveedores { get; set; }
        public virtual DbSet<tbl_Empresa> tbl_Empresa { get; set; }
        public virtual DbSet<vta_Punto_Emision> vta_Punto_Emision { get; set; }
        public virtual DbSet<tbl_Punto_Emision> tbl_Punto_Emision { get; set; }
        public virtual DbSet<tbl_Factura_Cabecera> tbl_Factura_Cabecera { get; set; }
    }
}