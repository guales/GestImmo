using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestImmo.Model
{
    class Pret
    {
        public int Id_pret { get; set; }

        public string Nom { get; set; }

        public string Banque { get; set; }

        public float Montant { get; set; } 

        public string Duree { get; set; }

        public DateTime Date_debut { get; set; }

        public DateTime Date_fin { get; set; }

        public float Taux { get; set; }

        public int Id_logement { get; set; }

        /// <summary>
        /// Constructeur vide
        /// </summary>
        public Pret()
        {
                
        }


        /// <summary>
        /// Constructeur complet
        /// </summary>
        /// <param name="Id_pret"></param>
        /// <param name="Nom"></param>
        /// <param name="Banque"></param>
        /// <param name="Montant"></param>
        /// <param name="Duree"></param>
        /// <param name="Date_debut"></param>
        /// <param name="Date_fin"></param>
        /// <param name="Taux"></param>
        /// <param name="Id_logement"></param>
        public Pret(int Id_pret, string Nom, string Banque, float Montant,
            string Duree, DateTime Date_debut, DateTime Date_fin, float Taux,
            int Id_logement)
        {
            this.Id_pret = Id_pret;
            this.Nom = Nom;
            this.Banque = Banque;
            this.Montant = Montant;
            this.Duree = Duree;
            this.Date_debut = Date_debut;
            this.Date_fin = Date_fin;
            this.Taux = Taux;
            this.Id_logement = Id_logement;
        }

    }
}
