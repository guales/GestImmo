using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestImmo.Model
{
    class Frais_pret
    {
        public int Id_frais_pret { get; set; }

        public string Nom { get; set; }

        public float Montant { get; set; }

        public DateTime Date_paiement { get; set; }

        public string Statut { get; set; }

        public string Informations_complementaires { get; set; }

        public int Id_pret { get; set; }

        /// <summary>
        /// Constructeur vide
        /// </summary>
        public Frais_pret()
        {

        }

        /// <summary>
        /// Constructeur complet
        /// </summary>
        /// <param name="Id_frais_pret"></param>
        /// <param name="Nom"></param>
        /// <param name="Montant"></param>
        /// <param name="Date_paiement"></param>
        /// <param name="Statut"></param>
        /// <param name="Informations_complementaires"></param>
        /// <param name="Id_pret"></param>
        public Frais_pret(int Id_frais_pret, string Nom, float Montant,
            DateTime Date_paiement, string Statut, string Informations_complementaires,
            int Id_pret)
        {
            this.Id_frais_pret = Id_frais_pret;
            this.Nom = Nom;
            this.Montant = Montant;
            this.Date_paiement = Date_paiement;
            this.Statut = Statut;
            this.Informations_complementaires = Informations_complementaires;
            this.Id_pret = Id_pret;              
        }
    }
}
