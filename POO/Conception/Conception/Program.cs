using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Threading;

namespace Conception
{
    internal class Program
    {
        private static int nbreEntre;

        static void Main(string[] args)
        {
            // Création des objets nécessaires
            Barman steve = new Barman();
            Shaker myShaker = new Shaker(500, true);
            Bar bar = new Bar();

            // Remplissage du stock de bouteilles dans le bar
            Bouteille[] stockBouteilles = new Bouteille[]
            {
                new Bouteille(new Liquide("Rhum", "Alcool"), 750),
                new Bouteille(new Liquide("Jus d'orange", "Jus"), 1000),
                new Bouteille(new Liquide("Vodka", "Alcool"), 700),
                new Bouteille(new Liquide("Liqueur de pêche", "Alcool"), 500),
                new Bouteille(new Liquide("Crème de noix de coco", "Alcool"), 500)
            };
            bar.Bouteille = stockBouteilles;

            // Création de recettes de cocktails
            Recette mojitoRecette = new Recette(new Portion[]
            {
                new Portion(new Liquide("Rhum", "Alcool"), 50),
                new Portion(new Liquide("Jus de citron vert", "Jus"), 20),
                new Portion(new Liquide("Feuilles de menthe", "Décoration"), 10),
                new Portion(new Liquide("Eau gazeuse", "Boisson"), 100),
                new Portion(new Liquide("Sucre", "Condiment"), 10)
            }, "Mojito");

            Recette pinaColadaRecette = new Recette(new Portion[]
            {
                new Portion(new Liquide("Rhum", "Alcool"), 50),
                new Portion(new Liquide("Jus d'ananas", "Jus"), 50),
                new Portion(new Liquide("Crème de noix de coco", "Alcool"), 50)
            }, "Pina Colada");

            // Boucle principale
            bool continuer = true;
            while (continuer)
            {
                // Préparation du menu
                string menu = "Menu:\n1. Mojito\n2. Pina Colada\n3. Quitter";
                Console.WriteLine(menu);

                // Prise de commande
                int choix = steve.Commander(menu, 2);
                if (choix == 3)
                {
                    continuer = false;
                    break;
                }

                // Sélection de la recette
                Recette recetteChoisie = (choix == 1) ? mojitoRecette : pinaColadaRecette;

                // Création du cocktail
                Cocktail cocktail = new Cocktail(recetteChoisie);

                // Affichage de la recette choisie
                Console.WriteLine("Recette choisie :");
                Console.WriteLine(cocktail.AfficherRecette());

                // Fabrication du cocktail
                bool fabricationOk = steve.Fabriquer(cocktail, myShaker, ref bar);

                // Service
                steve.Servir(cocktail, fabricationOk, ref myShaker);
            }
        }
    }
}