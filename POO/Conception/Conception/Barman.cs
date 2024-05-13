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

                while (!int.TryParse(Console.ReadLine(), out numeroCocktail))
                {
                    Console.WriteLine(menu);
                }

                if (numeroCocktail < 0 || numeroCocktail > nbRecettes)
                {
                    Console.WriteLine("Numéro de cocktail invalide.");
                }
            return numeroCocktail;
            
        }

        public bool Fabriquer(Cocktail cocktail, Shaker myShake, ref Bar monBar)
        {
            bool ok = true;
            int numeroBouteille = 0;

            foreach (Portion portion in cocktail.Recette.Ingredients)
            {
                Liquide ingredient = portion.Contenu;
                if (monBar.PrendreBouteille(ingredient, out numeroBouteille))
                {
                    if (portion.TesterPortion(myShake, monBar.Bouteille[numeroBouteille]))
                    {
                        monBar.Bouteille[numeroBouteille].Verser(portion);
                        myShake.AjouterPortion(portion);
                    }
                    else
                    {
                        // Utilisation de la méthode Jeter sur la bouteille
                        Console.WriteLine(monBar.Bouteille[numeroBouteille].Jeter());
                        ok = false;
                    }
                }
                else
                {
                    ok = false;
                }
            }
            return ok;
        }

        public string Servir(Cocktail cocktail, bool fabricationOk, ref Shaker myShake)
        {
            string chaine = "";
            if (fabricationOk)
            {
                Console.WriteLine("Voici votre cocktail ! :)");
            }
            else
            {
                Console.WriteLine("Nous avons rencontré un problème lors de la création de votre cocktail SNIF SNIF");
            }
            return chaine;
        }



        public override string ToString() { return Prenom; }
    }
}
