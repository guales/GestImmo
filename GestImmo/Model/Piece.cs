using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestImmo.Model
{
    class Piece
    {
        public int Id_piece {get; set;}

        public float Taille { get; set; }

        public string Mesure { get; set; }

        public int Id_logement { get; set; }

        /// <summary>
        /// Constructeur vide
        /// </summary>
        public Piece()
        {

        }

        /// <summary>
        /// Constructeur complet
        /// </summary>
        /// <param name="Id_piece"></param>
        /// <param name="Taille"></param>
        /// <param name="Mesure"></param>
        /// <param name="Id_logement"></param>
        public Piece(int Id_piece, float Taille, string Mesure, int Id_logement)
        {
            this.Id_piece = Id_piece;
            this.Taille = Taille;
            this.Mesure = Mesure;
            this.Id_logement = Id_logement;
        }
    }
}
