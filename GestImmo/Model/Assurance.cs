using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestImmo.Model
{
    class Assurance
    {
        public int Id_assurance { get; set; }

        public string Compagnie { get; set; }

        public string Frequence_paiement { get; set; }

        public string Garantie { get; set; }

        public int Id_pret { get; set; }

        /// <summary>
        /// Constructeur vide
        /// </summary>
        public Assurance()
        {

        }

        /// <summary>
        /// Constructeur complet
        /// </summary>
        /// <param name="Id_assurance"></param>
        /// <param name="Compagnie"></param>
        /// <param name="Frequence_paiement"></param>
        /// <param name="Garantie"></param>
        /// <param name="Id_pret"></param>
        public Assurance(int Id_assurance, string Compagnie, string Frequence_paiement,
           string Garantie, int Id_pret)
        {
            this.Id_assurance = Id_assurance;
            this.Compagnie = Compagnie;
            this.Frequence_paiement = Frequence_paiement;
            this.Garantie = Garantie;
            this.Id_pret = Id_pret;
        }
    }
}
