﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GestImmo.BDD
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BDD_GestImmoEntities : DbContext
    {
        public BDD_GestImmoEntities()
            : base("name=BDD_GestImmoEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<assurance> assurance { get; set; }
        public virtual DbSet<charge> charge { get; set; }
        public virtual DbSet<deblocage_fond> deblocage_fond { get; set; }
        public virtual DbSet<frais> frais { get; set; }
        public virtual DbSet<frais_pret> frais_pret { get; set; }
        public virtual DbSet<ligne_echeance_pret> ligne_echeance_pret { get; set; }
        public virtual DbSet<ligne_echeancier_assurance> ligne_echeancier_assurance { get; set; }
        public virtual DbSet<logement> logement { get; set; }
        public virtual DbSet<piece> piece { get; set; }
        public virtual DbSet<pret> pret { get; set; }
        public virtual DbSet<remboursement> remboursement { get; set; }
    }
}
