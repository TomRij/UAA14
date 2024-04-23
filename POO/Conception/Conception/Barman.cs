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

        public bool Fabriquer(Cocktail cocktail, ref Bouteille[] bouteille, ref Shaker myShake)
        {
            // réalisation de la recette
            
            // prendre les ingrédients / boissons
            for (int prendre = 0; prendre < cocktail.RecetteCocktail.Length; prendre++)
            {
                
                // enlever quantité d'ingrédients prit dans la recette
            }
        }

        public override string ToString() { return Prenom; }
    }
}
