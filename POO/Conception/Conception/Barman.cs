using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conception
{
    class Barman
    {
        private string _prenom = "";
        
        public string Prenom
        {
            get { return _prenom; }
        }

        public bool Commander(Recette recette, out Cocktail cocktail)
        {
            // réalisation de la recette
            cocktail = null;
            // prendre les ingrédients / boissons
            for (int prendre = 0; prendre < recette.Length; prendre++)
            {
                Bouteille bouteille = 
                // enlever quantité d'ingrédients prit dans la recette
            }
        }

        public override string ToString() { return Prenom; }
    }
}
