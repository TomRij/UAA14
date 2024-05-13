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

        public int Commander(string menu, int nbRecettes)
        {
            string choixUser = "";
            int numeroCocktail = 0;
        }

        public bool Fabriquer(Cocktail cocktail, ref Bouteille[] bouteille, ref Shaker myShake)
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
