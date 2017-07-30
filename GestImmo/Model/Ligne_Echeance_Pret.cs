using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestImmo.Model
{
    class Ligne_echeance_pret
    {
        public int Id_ligne_echeance_pret { get; set; }

        public DateTime Date_prelevement { get; set; }

        public float Montant_total { get; set; }

        public float Montant_capital { get; set; }

        public float Montant_interet { get; set; }

        public string Statut { get; set; }

        public int Id_pret { get; set; }

        /// <summary>
        /// Constructeur vide
        /// </summary>
        public Ligne_echeance_pret()
        {

        }

        /// <summary>
        /// Constructeur complet
        /// </summary>
        /// <param name="Id_ligne_echeance_pret"></param>
        /// <param name="Date_prelevement"></param>
        /// <param name="Montant_total"></param>
        /// <param name="Montant_capital"></param>
        /// <param name="Montant_interet"></param>
        /// <param name="Statut"></param>
        /// <param name="Id_pret"></param>
        public Ligne_echeance_pret(int Id_ligne_echeance_pret, DateTime Date_prelevement,
            float Montant_total, float Montant_capital, float Montant_interet,
            string Statut, int Id_pret)
        {
            this.Id_ligne_echeance_pret = Id_ligne_echeance_pret;
            this.Date_prelevement = Date_prelevement;
            this.Montant_total = Montant_total;
            this.Montant_capital = Montant_capital;
            this.Montant_interet = Montant_interet;
            this.Statut = Statut;
            this.Id_pret = Id_pret;
        }
    }
}
