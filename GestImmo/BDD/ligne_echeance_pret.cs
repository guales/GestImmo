//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class ligne_echeance_pret
    {
        public int id_ligne_echeance_pret { get; set; }
        public Nullable<System.DateTime> date_prelevement { get; set; }
        public Nullable<double> montant_total { get; set; }
        public Nullable<double> montant_capital { get; set; }
        public Nullable<double> montant_interet { get; set; }
        public string statut { get; set; }
        public Nullable<int> id_pret { get; set; }
    
        public virtual pret pret { get; set; }
    }
}
