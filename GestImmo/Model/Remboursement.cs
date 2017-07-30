using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestImmo.Model
{
    class Remboursement
    {
        public int Id_remboursement { get; set; }

        public string Nom { get; set; }

        public float Montant_paye { get; set; }

        public float Montant_total { get; set; }

        public float Montant_a_payer { get; set; }

        public int Id_logement { get; set; }

        /// <summary>
        /// Constructeur vide
        /// </summary>
        public Remboursement()
        {

        }

        /// <summary>
        /// Constructeur complet
        /// </summary>
        /// <param name="Id_remboursement"></param>
        /// <param name="Nom"></param>
        /// <param name="Montant_paye"></param>
        /// <param name="Montant_total"></param>
        /// <param name="Id_logement"></param>
        public Remboursement(int Id_remboursement, string Nom, float Montant_paye,
            float Montant_total, int Id_logement)
        {
            this.Id_remboursement = Id_remboursement;
            this.Nom = Nom;
            this.Montant_paye = Montant_paye;
            this.Montant_total = Montant_total;
            this.Montant_a_payer = Montant_total - Montant_paye;
            this.Id_logement = Id_logement;
        }
    }
}
