using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestImmo.Model
{
    class Frais
    {
        public int Id_frais { get; set; }

        public string Categorie { get; set; }

        public string Nom { get; set; }

        public float Valeur { get; set; }

        public int Id_logement { get; set; }

        /// <summary>
        /// Constructeur vide
        /// </summary>
        public Frais()
        {

        }

        /// <summary>
        /// Constructeur complet
        /// </summary>
        /// <param name="Id_frais"></param>
        /// <param name="Categorie"></param>
        /// <param name="Nom"></param>
        /// <param name="Valeur"></param>
        /// <param name="Id_logement"></param>
        public Frais(int Id_frais, string Categorie, string Nom,
            float Valeur, int Id_logement)
        {
            this.Id_frais = Id_frais;
            this.Categorie = Categorie;
            this.Nom = Nom;
            this.Valeur = Valeur;
            this.Id_logement = Id_logement;
        }
    }
}
