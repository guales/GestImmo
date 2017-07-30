using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestImmo.Model
{
    class Charge
    {
        public int Id_charge { get; set; }

        public string Type { get; set; }

        public float Montant { get; set; }

        public string Periodicite { get; set; }

        public DateTime Date { get; set; }

        public int Id_logement { get; set; }

        /// <summary>
        /// Constructeur vide
        /// </summary>
        public Charge()
        {

        }

        /// <summary>
        /// Constructeur complet
        /// </summary>
        /// <param name="Id_charge"></param>
        /// <param name="Type"></param>
        /// <param name="Montant"></param>
        /// <param name="Periodicite"></param>
        /// <param name="Date"></param>
        /// <param name="Id_logement"></param>
        public Charge(int Id_charge, string Type, float Montant, 
            string Periodicite, DateTime Date, int Id_logement)
        {
            this.Id_charge = Id_charge;
            this.Type = Type;
            this.Montant = Montant;
            this.Periodicite = Periodicite;
            this.Date = Date;
            this.Id_logement = Id_logement;
        }
    }
}
