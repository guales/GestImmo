using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestImmo.Model
{
    class Deblocage_fond
    {
        public int Id_deblocage_fond { get; set; }

        public float Pourcentage { get; set; }

        public string Statut { get; set; }

        public int Id_logement { get; set; }

        /// <summary>
        /// Constructeur vide
        /// </summary>
        public Deblocage_fond()
        {

        }

        /// <summary>
        /// Constructeur complet
        /// </summary>
        /// <param name="Id_deblocage_fond"></param>
        /// <param name="Pourcentage"></param>
        /// <param name="Statut"></param>
        /// <param name="Id_logement"></param>
        public Deblocage_fond(int Id_deblocage_fond, float Pourcentage,
            string Statut, int Id_logement)
        {
            this.Id_deblocage_fond = Id_deblocage_fond;
            this.Pourcentage = Pourcentage;
            this.Statut = Statut;
            this.Id_logement = Id_logement;
        }
    }
}
