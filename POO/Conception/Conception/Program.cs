﻿using System.ComponentModel.Design;
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
            Bar bar = new Bar();
            Barman Steve = new Barman();

            Recette[] toutesLesBoissons = new Recette[]
            {
                // 0. Mojito
                new Recette(new Portion[]
                {
                    new Portion(new Liquide("Rhum blanc", "alcool"), 50),
                    new Portion(new Liquide("Jus de citron vert", "jus"), 20),
                    new Portion(new Liquide("Feuilles de menthe", "plante"), 6),
                    new Portion(new Liquide("Sucre de canne", "sucre"), 2),
                    new Portion(new Liquide("Eau gazeuse", "eau"), 100)
                }, "Mojito"),

                // 1. Margarita
                new Recette(new Portion[]
                {
                        new Portion(new Liquide("Tequila", "alcool"), 50),
                        new Portion(new Liquide("Jus de citron vert", "jus"), 30),
                        new Portion(new Liquide("Triple sec", "liqueur"), 20),
                        new Portion(new Liquide("Sirop d'agave", "sirop"), 10)
                }, "Margarita"),

                // 2. Piña Colada
                new Recette(new Portion[]
                {
                        new Portion(new Liquide("Rhum blanc", "alcool"), 60),
                        new Portion(new Liquide("Jus d'ananas", "jus"), 100),
                        new Portion(new Liquide("Crème de coco", "crème"), 50)
                }, "Piña Colada"),

                // 3. Daiquiri
                new Recette(new Portion[]
                {
                            new Portion(new Liquide("Rhum blanc", "alcool"), 50),
                            new Portion(new Liquide("Jus de citron vert", "jus"), 20),
                            new Portion(new Liquide("Sirop de sucre", "sirop"), 10)
                }, "Daiquiri"),

                // 4. Mojito Framboise
                new Recette(new Portion[]
                {
                            new Portion(new Liquide("Rhum blanc", "alcool"), 50),
                            new Portion(new Liquide("Jus de citron vert", "jus"), 20),
                            new Portion(new Liquide("Feuilles de menthe", "plante"), 6),
                            new Portion(new Liquide("Sirop de framboise", "sirop"), 10),
                            new Portion(new Liquide("Eau gazeuse", "eau"), 100)
                }, "Mojito Framboise"),

                // 5. Mojito Fraise
                new Recette(new Portion[]
                {
                            new Portion(new Liquide("Rhum blanc", "alcool"), 50),
                            new Portion(new Liquide("Jus de citron vert", "jus"), 20),
                            new Portion(new Liquide("Feuilles de menthe", "plante"), 6),
                            new Portion(new Liquide("Sirop de fraise", "sirop"), 10),
                            new Portion(new Liquide("Eau gazeuse", "eau"), 100)
                }, "Mojito Fraise"),

                // 6. Mojito Ananas
                new Recette(new Portion[]
                {
                            new Portion(new Liquide("Rhum blanc", "alcool"), 50),
                            new Portion(new Liquide("Jus de citron vert", "jus"), 20),
                            new Portion(new Liquide("Feuilles de menthe", "plante"), 6),
                            new Portion(new Liquide("Sirop d'ananas", "sirop"), 10),
                            new Portion(new Liquide("Eau gazeuse", "eau"), 100)
                }, "Mojito Ananas"),

                // 7. Caipirinha
                new Recette(new Portion[]
                {
                            new Portion(new Liquide("Cachaça", "alcool"), 50),
                            new Portion(new Liquide("Citron vert", "fruit"), 20),
                            new Portion(new Liquide("Sucre de canne", "sucre"), 10)
                }, "Caipirinha"),

                // 8. Mai Tai
                new Recette(new Portion[]
                {
                            new Portion(new Liquide("Rhum blanc", "alcool"), 40),
                            new Portion(new Liquide("Rhum ambré", "alcool"), 20),
                            new Portion(new Liquide("Jus de citron vert", "jus"), 20),
                            new Portion(new Liquide("Sirop d'orgeat", "sirop"), 15),
                            new Portion(new Liquide("Triple sec", "liqueur"), 10)
                }, "Mai Tai"),

                // 9. Mojito Cerise
                new Recette(new Portion[]
                {
                            new Portion(new Liquide("Rhum blanc", "alcool"), 50),
                            new Portion(new Liquide("Jus de citron vert", "jus"), 20),
                            new Portion(new Liquide("Feuilles de menthe", "plante"), 6),
                            new Portion(new Liquide("Sirop de cerise", "sirop"), 10),
                            new Portion(new Liquide("Eau gazeuse", "eau"), 100)
                }, "Mojito Cerise"),

                // 10. Mojito Mangue
                new Recette(new Portion[]
                {
                            new Portion(new Liquide("Rhum blanc", "alcool"), 50),
                            new Portion(new Liquide("Jus de citron vert", "jus"), 20),
                            new Portion(new Liquide("Feuilles de menthe", "plante"), 6),
                            new Portion(new Liquide("Sirop de mangue", "sirop"), 10),
                            new Portion(new Liquide("Eau gazeuse", "eau"), 100)
                }, "Mojito Mangue"),

                // 11. Mojito Passion
                new Recette(new Portion[]
                {
                            new Portion(new Liquide("Rhum blanc", "alcool"), 50),
                            new Portion(new Liquide("Jus de citron vert", "jus"), 20),
                            new Portion(new Liquide("Feuilles de menthe", "plante"), 6),
                            new Portion(new Liquide("Sirop de fruit de la passion", "sirop"), 10),
                            new Portion(new Liquide("Eau gazeuse", "eau"), 100)
                }, "Mojito Passion"),

                // 12. Sex on the Beach
                new Recette(new Portion[]
                {
                            new Portion(new Liquide("Vodka", "alcool"), 40),
                            new Portion(new Liquide("Peach schnapps", "liqueur"), 20),
                            new Portion(new Liquide("Jus d'orange", "jus"), 40),
                            new Portion(new Liquide("Jus de canneberge", "jus"), 40),
                            new Portion(new Liquide("Grenadine", "sirop"), 10)
                }, "Sex on the Beach"),

                // 13. Mojito Pomme Verte
                new Recette(new Portion[]
                {
                            new Portion(new Liquide("Rhum blanc", "alcool"), 50),
                            new Portion(new Liquide("Jus de citron vert", "jus"), 20),
                            new Portion(new Liquide("Feuilles de menthe", "plante"), 6),
                            new Portion(new Liquide("Sirop de pomme verte", "sirop"), 10),
                            new Portion(new Liquide("Eau gazeuse", "eau"), 100)
                }, "Mojito Pomme Verte"),

                // 14. Mojito Litchi
                new Recette(new Portion[]
                {
                        new Portion(new Liquide("Rhum blanc", "alcool"), 50),
                        new Portion(new Liquide("Jus de citron vert", "jus"), 20),
                        new Portion(new Liquide("Feuilles de menthe", "plante"), 6),
                        new Portion(new Liquide("Sirop de litchi", "sirop"), 10),
                        new Portion(new Liquide("Eau gazeuse", "eau"), 100)
                }, "Mojito Litchi"),

                // 15. Mojito Framboise-Litchi
                new Recette(new Portion[]
                {
                        new Portion(new Liquide("Rhum blanc", "alcool"), 50),
                        new Portion(new Liquide("Jus de citron vert", "jus"), 20),
                        new Portion(new Liquide("Feuilles de menthe", "plante"), 6),
                        new Portion(new Liquide("Sirop de framboise", "sirop"), 5),
                        new Portion(new Liquide("Sirop de litchi", "sirop"), 5),
                        new Portion(new Liquide("Eau gazeuse", "eau"), 100)
                }, "Mojito Framboise-Litchi"),

                // 16. Mojito Coco
                new Recette(new Portion[]
                {
                        new Portion(new Liquide("Rhum blanc", "alcool"), 50),
                        new Portion(new Liquide("Jus de citron vert", "jus"), 20),
                        new Portion(new Liquide("Feuilles de menthe", "plante"), 6),
                        new Portion(new Liquide("Lait de coco", "lait"), 20),
                        new Portion(new Liquide("Eau gazeuse", "eau"), 100)
                }, "Mojito Coco"),

                // 17. Mojito Cerise Noire
                new Recette(new Portion[]
                {
                        new Portion(new Liquide("Rhum blanc", "alcool"), 50),
                        new Portion(new Liquide("Jus de citron vert", "jus"), 20),
                        new Portion(new Liquide("Feuilles de menthe", "plante"), 6),
                        new Portion(new Liquide("Sirop de cerise noire", "sirop"), 10),
                        new Portion(new Liquide("Eau gazeuse", "eau"), 100)
                }, "Mojito Cerise Noire"),

                // 18. Mojito Pêche
                new Recette(new Portion[]
                {
                        new Portion(new Liquide("Rhum blanc", "alcool"), 50),
                        new Portion(new Liquide("Jus de citron vert", "jus"), 20),
                        new Portion(new Liquide("Feuilles de menthe", "plante"), 6),
                        new Portion(new Liquide("Sirop de pêche", "sirop"), 10),
                        new Portion(new Liquide("Eau gazeuse", "eau"), 100)
                }, "Mojito Pêche"),

                // 19. Mojito Maracuja
                new Recette(new Portion[]
                {
                        new Portion(new Liquide("Rhum blanc", "alcool"), 50),
                        new Portion(new Liquide("Jus de citron vert", "jus"), 20),
                        new Portion(new Liquide("Feuilles de menthe", "plante"), 6),
                        new Portion(new Liquide("Sirop de maracuja", "sirop"), 10),
                        new Portion(new Liquide("Eau gazeuse", "eau"), 100)
                }, "Mojito Maracuja"),

                // 20. Mojito Melon
                new Recette(new Portion[]
                {
                        new Portion(new Liquide("Rhum blanc", "alcool"), 50),
                        new Portion(new Liquide("Jus de citron vert", "jus"), 20),
                        new Portion(new Liquide("Feuilles de menthe", "plante"), 6),
                        new Portion(new Liquide("Sirop de melon", "sirop"), 10),
                        new Portion(new Liquide("Eau gazeuse", "eau"), 100)
                }, "Mojito Melon"),

                // 21. Mojito Cerise Griotte
                new Recette(new Portion[]
                {
                        new Portion(new Liquide("Rhum blanc", "alcool"), 50),
                        new Portion(new Liquide("Jus de citron vert", "jus"), 20),
                        new Portion(new Liquide("Feuilles de menthe", "plante"), 6),
                        new Portion(new Liquide("Sirop de cerise griotte", "sirop"), 10),
                        new Portion(new Liquide("Eau gazeuse", "eau"), 100)
                }, "Mojito Cerise Griotte"),

                // 22. Mojito Agrumes
                new Recette(new Portion[]
                {
                        new Portion(new Liquide("Rhum blanc", "alcool"), 50),
                        new Portion(new Liquide("Jus de citron vert", "jus"), 20),
                        new Portion(new Liquide("Feuilles de menthe", "plante"), 6),
                        new Portion(new Liquide("Sirop d'agrumes", "sirop"), 10),
                        new Portion(new Liquide("Eau gazeuse", "eau"), 100)
                }, "Mojito Agrumes"),

                // 23. Mojito Vanille
                new Recette(new Portion[]
                {
                            new Portion(new Liquide("Rhum blanc", "alcool"), 50),
                            new Portion(new Liquide("Jus de citron vert", "jus"), 20),
                            new Portion(new Liquide("Feuilles de menthe", "plante"), 6),
                            new Portion(new Liquide("Sirop de vanille", "sirop"), 10),
                            new Portion(new Liquide("Eau gazeuse", "eau"), 100)
                }, "Mojito Vanille"),

                // 24. Mojito Figue
                new Recette(new Portion[]
                {
                        new Portion(new Liquide("Rhum blanc", "alcool"), 50),
                        new Portion(new Liquide("Jus de citron vert", "jus"), 20),
                        new Portion(new Liquide("Feuilles de menthe", "plante"), 6),
                        new Portion(new Liquide("Sirop de figue", "sirop"), 10),
                        new Portion(new Liquide("Eau gazeuse", "eau"), 100)
                }, "Mojito Figue"),

                // 25. Mojito Fruits Rouges
                new Recette(new Portion[]
                {
                            new Portion(new Liquide("Rhum blanc", "alcool"), 50),
                            new Portion(new Liquide("Jus de citron vert", "jus"), 20),
                            new Portion(new Liquide("Feuilles de menthe", "plante"), 6),
                            new Portion(new Liquide("Sirop de fruits rouges", "sirop"), 10),
                            new Portion(new Liquide("Eau gazeuse", "eau"), 100)
                }, "Mojito Fruits Rouges"),

                // 26. Mojito Raisin
                new Recette(new Portion[]
                {
                            new Portion(new Liquide("Rhum blanc", "alcool"), 50),
                            new Portion(new Liquide("Jus de citron vert", "jus"), 20),
                            new Portion(new Liquide("Feuilles de menthe", "plante"), 6),
                            new Portion(new Liquide("Sirop de raisin", "sirop"), 10),
                            new Portion(new Liquide("Eau gazeuse", "eau"), 100)
                }, "Mojito Raisin"),

                // 27. Mojito Cannelle
                new Recette(new Portion[]
                {
                            new Portion(new Liquide("Rhum blanc", "alcool"), 50),
                            new Portion(new Liquide("Jus de citron vert", "jus"), 20),
                            new Portion(new Liquide("Feuilles de menthe", "plante"), 6),
                            new Portion(new Liquide("Sirop de cannelle", "sirop"), 10),
                            new Portion(new Liquide("Eau gazeuse", "eau"), 100)
                }, "Mojito Cannelle"),
            };


            Shaker myShake = new Shaker(100, true);

            Bouteille[] toutesLesBouteilles = new Bouteille[]
            {
                new Bouteille(new Liquide("rhumBlanc", "alcool"), 100),
                new Bouteille(new Liquide("tequila", "alcool"), 100),
                new Bouteille(new Liquide("rhumAmbré", "alcool"), 100),
                new Bouteille(new Liquide("cachaça", "alcool"), 100),
                new Bouteille(new Liquide("vodka", "alcool"), 100),
                new Bouteille(new Liquide("Peach Schnapps", "liqueur"), 100),
                new Bouteille(new Liquide("Crème de coco", "crème"), 100),
                new Bouteille(new Liquide("Sirop d'agave", "sirop"), 100),
                new Bouteille(new Liquide("Sirop de framboise", "sirop"), 100),
                new Bouteille(new Liquide("Sirop de fraise", "sirop"), 100),
                new Bouteille(new Liquide("Sirop d'ananas", "sirop"), 100),

            };
            
            Cave cave = new Cave();

            // Création d'un tableau pour stocker les portions de chaque boisson
            Portion[] toutesLesPortions = new Portion[toutesLesBouteilles.Length];

            // Création des portions pour chaque bouteille
            for (int i = 0; i < toutesLesBouteilles.Length; i++)
            {
                Bouteille bouteille = toutesLesBouteilles[i];
                toutesLesPortions[i] = new Portion(bouteille.Contenu, 100); // Par exemple, 100 unités par portion
            }

            Cocktail theMojito = new Cocktail("Mojito", 178, mojito);
            Cocktail theMargarita = new Cocktail("Margarita", 178, margarita);
            Cocktail thePinaColada = new Cocktail("Piña Colada", 178, pinaColada);
            Cocktail theDaiquiri = new Cocktail("Daiquiri", 178, daiquiri);
            Cocktail theMojitoFramboise = new Cocktail("Mojito Framboise", 178, mojitoFramboise);
            Cocktail theMojitoFraise = new Cocktail("Mojito Fraise", 178, mojitoFraise);
            Cocktail theMojitoCassis = new Cocktail("Mojito Cassis", 178, mojitoCassis);


            do
            {
                Console.WriteLine("Bienvenue dans le grand bar du Fight Club");
                Console.WriteLine("Tapez : ");
                Console.WriteLine("1. Pour voire la carte,");
                Console.WriteLine("2. Pour choisir un recette,");
                Console.WriteLine("3. Pour quitter");

                int nbreEntre = 0;
                if (!int.TryParse(Console.ReadLine(), out nbreEntre))
                {
                    Console.WriteLine("Oups vous avez fait une erreur de frappe, réessayez ! ");
                }
                else
                {
                    switch (nbreEntre)
                    {
                        case 1:
                            foreach (Recette recette in toutesLesBoissons)
                            {
                                Console.WriteLine(recette);
                            }
                            break;
                        case 2:
                            Console.WriteLine("Taper le numéro de recette qui vous intéresses : ");
                            int numeroEntre = 0;
                            do
                            {
                                if (!int.TryParse(Console.ReadLine(), out numeroEntre))
                                {
                                    Console.WriteLine("Oups vous avez fait une erreur de frappe, réessayez ! ");
                                }
                                Console.WriteLine(Steve + "va s'occuper de votre" + toutesLesBoissons[numeroEntre]);
                                toutesLesBoissons[numeroEntre] = string ""cocktailFinito"";
                                Steve.Commander(toutesLesBoissons[numeroEntre], );
                            } while (!int.TryParse(Console.ReadLine(), out numeroEntre));
                            break;
                        case 3:
                            Console.WriteLine(":(");
                            break;
                        default:
                            Console.WriteLine("Je pense que vous vous êtes malencontreusement perdus dans les touches de votre clavier");
                            break;
                    }
                }

            } while (nbreEntre != 7);
             

            }
        }
}