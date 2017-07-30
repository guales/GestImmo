using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestImmo.Model
{
    class Logement
    {
        public int Id_logement { get; set; }

        public byte[] Photo { get; set; }

        public string Nom { get; set; }

        public string Adresse { get; set; }

        public int Code_postal { get; set; }

        public string Ville { get; set; }

        public string Taille { get; set; }

        public string Type_logement { get; set; }

        public string Utilisation { get; set; }

        public int Annee_construction { get; set; }

        public string Informations_complementaires { get; set; }

        public string Regles_fiscales { get; set; }

        public int Prix_achat { get; set; }

        /// <summary>
        /// Constructeur vide.
        /// </summary>
        public Logement()
        {

        }

        /// <summary>
        /// Constructeur complet. 
        /// </summary>
        public Logement(int Id_logement, byte[] photo, string nom, string adresse,
            int codePostal, string ville, string taille, string typeLogement,
            string utilisation, int anneeConstruction, string informationsComplementaires,
            string reglesFiscales, int prixAchat)
        {
            this.Id_logement = Id_logement;
            this.Photo = photo;
            this.Nom = nom;
            this.Adresse = adresse;
            this.Code_postal = codePostal;
            this.Ville = ville;
            this.Taille = taille;
            this.Type_logement = typeLogement;
            this.Utilisation = utilisation;
            this.Annee_construction = anneeConstruction;
            this.Informations_complementaires = informationsComplementaires;
            this.Regles_fiscales = reglesFiscales;
            this.Prix_achat = prixAchat;
        }
    }
}
