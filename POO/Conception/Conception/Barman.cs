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
            cocktail = null;

            // Vérification recette 
            if (recette == null || recette.Ingredients == null || recette.Ingredients.Length == 0) 
            {
                Console.WriteLine("Malheureusement on dirait bien que la recette est invalide snif sniffff");
                return false;
            }

            // Préparation du cocktail
            Console.WriteLine($"Préparation du cocktail {recette.NomRecettes}");

            // Utiliser le shaker
            Shaker shaker = new Shaker(150, true);

            foreach (var portion in recette.Ingredients)
            {
                // Vérification si ingédients dispo dans bar
                if (!)
                {
                    
                }
            }
        }

        public override string ToString() { return Prenom; }
    }
}
