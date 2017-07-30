using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestImmo.Model
{
    class Ligne_echeance_assurance
    {
        public int Id_ligne_echeance_assurance { get; set; }

        public string Nom { get; set; }

        public DateTime Date_prelevement { get; set; }

        public string Motif { get; set; }

        public float Montant { get; set; }

        public DateTime Date_debut { get; set; }

        public DateTime Date_fin { get; set; }

        public string Statut { get; set; }

        public int Id_assurance { get; set; }

        /// <summary>
        /// Constructeur vide
        /// </summary>
        public Ligne_echeance_assurance()
        {

        }

        /// <summary>
        /// Constructeur complet
        /// </summary>
        /// <param name="Id_ligne_echeance_assurance"></param>
        /// <param name="Nom"></param>
        /// <param name="Date_prelevement"></param>
        /// <param name="Motif"></param>
        /// <param name="Montant"></param>
        /// <param name="Date_debut"></param>
        /// <param name="Date_fin"></param>
        /// <param name="Statut"></param>
        /// <param name="Id_assurance"></param>
        public Ligne_echeance_assurance(int Id_ligne_echeance_assurance, string Nom,
            DateTime Date_prelevement, string Motif, float Montant,
            DateTime Date_debut, DateTime Date_fin, string Statut,
            int Id_assurance)
        {
            this.Id_ligne_echeance_assurance = Id_ligne_echeance_assurance;
            this.Nom = Nom;
            this.Date_prelevement = Date_prelevement;
            this.Motif = Motif;
            this.Montant = Montant;
            this.Date_debut = Date_debut;
            this.Date_fin = Date_fin;
            this.Statut = Statut;
            this.Id_assurance = Id_assurance;
        }
    }
}
