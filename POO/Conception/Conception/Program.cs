using System.Threading;

namespace Conception
{
    internal class Program
    {
        private static int nbreEntre;

        static void Main(string[] args)
        {
            Bar bar = new Bar();
            Barman steve = new Barman();

            // 0. Mojito
            Recette mojito = new Recette();
            mojito.Ingredients = new Portion[]
            {
                new Portion(new Liquide("Rhum blanc", "alcool"), 50),
                new Portion(new Liquide("Jus de citron vert", "jus"), 20),
                new Portion(new Liquide("Feuilles de menthe", "plante"), 6),
                new Portion(new Liquide("Sucre de canne", "sucre"), 2),
                new Portion(new Liquide("Eau gazeuse", "eau"), 100)
            };
            // 1. Margarita
            Recette margarita = new Recette();
            margarita.Ingredients = new Portion[]
            {
                new Portion(new Liquide("Tequila", "alcool"), 50),
                new Portion(new Liquide("Jus de citron vert", "jus"), 30),
                new Portion(new Liquide("Triple sec", "liqueur"), 20),
                new Portion(new Liquide("Sirop d'agave", "sirop"), 10)
            };

            // 2. Piña Colada
            Recette pinaColada = new Recette();
            pinaColada.Ingredients = new Portion[]
            {
                new Portion(new Liquide("Rhum blanc", "alcool"), 60),
                new Portion(new Liquide("Jus d'ananas", "jus"), 100),
                new Portion(new Liquide("Crème de coco", "crème"), 50)
            };

            // 3. Daiquiri
            Recette daiquiri = new Recette();
            daiquiri.Ingredients = new Portion[]
            {
                new Portion(new Liquide("Rhum blanc", "alcool"), 50),
                new Portion(new Liquide("Jus de citron vert", "jus"), 20),
                new Portion(new Liquide("Sirop de sucre", "sirop"), 10)
            };
            // 4. Mojito Framboise
            Recette mojitoFramboise = new Recette();
            mojitoFramboise.Ingredients = new Portion[]
            {
                new Portion(new Liquide("Rhum blanc", "alcool"), 50),
                new Portion(new Liquide("Jus de citron vert", "jus"), 20),
                new Portion(new Liquide("Feuilles de menthe", "plante"), 6),
                new Portion(new Liquide("Sirop de framboise", "sirop"), 10),
                new Portion(new Liquide("Eau gazeuse", "eau"), 100)
            };

            // 5. Mojito Fraise
            Recette mojitoFraise = new Recette();
            mojitoFraise.Ingredients = new Portion[]
            {
                new Portion(new Liquide("Rhum blanc", "alcool"), 50),
                new Portion(new Liquide("Jus de citron vert", "jus"), 20),
                new Portion(new Liquide("Feuilles de menthe", "plante"), 6),
                new Portion(new Liquide("Sirop de fraise", "sirop"), 10),
                new Portion(new Liquide("Eau gazeuse", "eau"), 100)
            };

            // 6. Mojito Ananas
            Recette mojitoAnanas = new Recette();
            mojitoAnanas.Ingredients = new Portion[]
            {
                new Portion(new Liquide("Rhum blanc", "alcool"), 50),
                new Portion(new Liquide("Jus de citron vert", "jus"), 20),
                new Portion(new Liquide("Feuilles de menthe", "plante"), 6),
                new Portion(new Liquide("Sirop d'ananas", "sirop"), 10),
                new Portion(new Liquide("Eau gazeuse", "eau"), 100)
            };

            // 7. Caipirinha
            Recette caipirinha = new Recette();
            caipirinha.Ingredients = new Portion[]
            {
                new Portion(new Liquide("Cachaça", "alcool"), 50),
                new Portion(new Liquide("Citron vert", "fruit"), 20),
                new Portion(new Liquide("Sucre de canne", "sucre"), 10)
            };
            // 8. Mai Tai
            Recette maiTai = new Recette();
            maiTai.Ingredients = new Portion[]
            {
                new Portion(new Liquide("Rhum blanc", "alcool"), 40),
                new Portion(new Liquide("Rhum ambré", "alcool"), 20),
                new Portion(new Liquide("Jus de citron vert", "jus"), 20),
                new Portion(new Liquide("Sirop d'orgeat", "sirop"), 15),
                new Portion(new Liquide("Triple sec", "liqueur"), 10)
            };

            // 9. Mojito Cerise
            Recette mojitoCerise = new Recette();
            mojitoCerise.Ingredients = new Portion[]
            {
                new Portion(new Liquide("Rhum blanc", "alcool"), 50),
                new Portion(new Liquide("Jus de citron vert", "jus"), 20),
                new Portion(new Liquide("Feuilles de menthe", "plante"), 6),
                new Portion(new Liquide("Sirop de cerise", "sirop"), 10),
                new Portion(new Liquide("Eau gazeuse", "eau"), 100)
            };

            // 10. Mojito Mangue
            Recette mojitoMangue = new Recette();
            mojitoMangue.Ingredients = new Portion[]
            {
                new Portion(new Liquide("Rhum blanc", "alcool"), 50),
                new Portion(new Liquide("Jus de citron vert", "jus"), 20),
                new Portion(new Liquide("Feuilles de menthe", "plante"), 6),
                new Portion(new Liquide("Sirop de mangue", "sirop"), 10),
                new Portion(new Liquide("Eau gazeuse", "eau"), 100)
            };

            // 11. Mojito Passion
            Recette mojitoPassion = new Recette();
            mojitoPassion.Ingredients = new Portion[]
            {
                new Portion(new Liquide("Rhum blanc", "alcool"), 50),
                new Portion(new Liquide("Jus de citron vert", "jus"), 20),
                new Portion(new Liquide("Feuilles de menthe", "plante"), 6),
                new Portion(new Liquide("Sirop de fruit de la passion", "sirop"), 10),
                new Portion(new Liquide("Eau gazeuse", "eau"), 100)
            };
            // 12. Sex on the Beach
            Recette sexOnTheBeach = new Recette();
            sexOnTheBeach.Ingredients = new Portion[]
            {
                new Portion(new Liquide("Vodka", "alcool"), 40),
                new Portion(new Liquide("Peach schnapps", "liqueur"), 20),
                new Portion(new Liquide("Jus d'orange", "jus"), 40),
                new Portion(new Liquide("Jus de canneberge", "jus"), 40),
                new Portion(new Liquide("Grenadine", "sirop"), 10)
            };

            // 13. Mojito Pomme Verte
            Recette mojitoPommeVerte = new Recette();
            mojitoPommeVerte.Ingredients = new Portion[]
            {
                new Portion(new Liquide("Rhum blanc", "alcool"), 50),
                new Portion(new Liquide("Jus de citron vert", "jus"), 20),
                new Portion(new Liquide("Feuilles de menthe", "plante"), 6),
                new Portion(new Liquide("Sirop de pomme verte", "sirop"), 10),
                new Portion(new Liquide("Eau gazeuse", "eau"), 100)
            };

            // 14. Mojito Litchi
            Recette mojitoLitchi = new Recette();
            mojitoLitchi.Ingredients = new Portion[]
            {
                new Portion(new Liquide("Rhum blanc", "alcool"), 50),
                new Portion(new Liquide("Jus de citron vert", "jus"), 20),
                new Portion(new Liquide("Feuilles de menthe", "plante"), 6),
                new Portion(new Liquide("Sirop de litchi", "sirop"), 10),
                new Portion(new Liquide("Eau gazeuse", "eau"), 100)
            };

            // 15. Mojito Framboise-Litchi
            Recette mojitoFramboiseLitchi = new Recette();
            mojitoFramboiseLitchi.Ingredients = new Portion[]
            {
                new Portion(new Liquide("Rhum blanc", "alcool"), 50),
                new Portion(new Liquide("Jus de citron vert", "jus"), 20),
                new Portion(new Liquide("Feuilles de menthe", "plante"), 6),
                new Portion(new Liquide("Sirop de framboise", "sirop"), 5),
                new Portion(new Liquide("Sirop de litchi", "sirop"), 5),
                new Portion(new Liquide("Eau gazeuse", "eau"), 100)
            };
            // 16. Mojito Coco
            Recette mojitoCoco = new Recette();
            mojitoCoco.Ingredients = new Portion[]
            {
                new Portion(new Liquide("Rhum blanc", "alcool"), 50),
                new Portion(new Liquide("Jus de citron vert", "jus"), 20),
                new Portion(new Liquide("Feuilles de menthe", "plante"), 6),
                new Portion(new Liquide("Lait de coco", "lait"), 20),
                new Portion(new Liquide("Eau gazeuse", "eau"), 100)
            };

            // 17. Mojito Cerise Noire
            Recette mojitoCeriseNoire = new Recette();
            mojitoCeriseNoire.Ingredients = new Portion[]
            {
                new Portion(new Liquide("Rhum blanc", "alcool"), 50),
                new Portion(new Liquide("Jus de citron vert", "jus"), 20),
                new Portion(new Liquide("Feuilles de menthe", "plante"), 6),
                new Portion(new Liquide("Sirop de cerise noire", "sirop"), 10),
                new Portion(new Liquide("Eau gazeuse", "eau"), 100)
            };

            // 18. Mojito Pêche
            Recette mojitoPeche = new Recette();
            mojitoPeche.Ingredients = new Portion[]
            {
                new Portion(new Liquide("Rhum blanc", "alcool"), 50),
                new Portion(new Liquide("Jus de citron vert", "jus"), 20),
                new Portion(new Liquide("Feuilles de menthe", "plante"), 6),
                new Portion(new Liquide("Sirop de pêche", "sirop"), 10),
                new Portion(new Liquide("Eau gazeuse", "eau"), 100)
            };

            // 19. Mojito Maracuja
            Recette mojitoMaracuja = new Recette();
            mojitoMaracuja.Ingredients = new Portion[]
            {
                new Portion(new Liquide("Rhum blanc", "alcool"), 50),
                new Portion(new Liquide("Jus de citron vert", "jus"), 20),
                new Portion(new Liquide("Feuilles de menthe", "plante"), 6),
                new Portion(new Liquide("Sirop de maracuja", "sirop"), 10),
                new Portion(new Liquide("Eau gazeuse", "eau"), 100)
            };
            // 20. Mojito Melon
            Recette mojitoMelon = new Recette();
            mojitoMelon.Ingredients = new Portion[]
            {
                new Portion(new Liquide("Rhum blanc", "alcool"), 50),
                new Portion(new Liquide("Jus de citron vert", "jus"), 20),
                new Portion(new Liquide("Feuilles de menthe", "plante"), 6),
                new Portion(new Liquide("Sirop de melon", "sirop"), 10),
                new Portion(new Liquide("Eau gazeuse", "eau"), 100)
            };

            // 21. Mojito Cerise Griotte
            Recette mojitoCeriseGriotte = new Recette();
            mojitoCeriseGriotte.Ingredients = new Portion[]
            {
                new Portion(new Liquide("Rhum blanc", "alcool"), 50),
                new Portion(new Liquide("Jus de citron vert", "jus"), 20),
                new Portion(new Liquide("Feuilles de menthe", "plante"), 6),
                new Portion(new Liquide("Sirop de cerise griotte", "sirop"), 10),
                new Portion(new Liquide("Eau gazeuse", "eau"), 100)
            };

            // 22. Mojito Agrumes
            Recette mojitoAgrumes = new Recette();
            mojitoAgrumes.Ingredients = new Portion[]
            {
                new Portion(new Liquide("Rhum blanc", "alcool"), 50),
                new Portion(new Liquide("Jus de citron vert", "jus"), 20),
                new Portion(new Liquide("Feuilles de menthe", "plante"), 6),
                new Portion(new Liquide("Sirop d'agrumes", "sirop"), 10),
                new Portion(new Liquide("Eau gazeuse", "eau"), 100)
            };

            // 23. Mojito Vanille
            Recette mojitoVanille = new Recette();
            mojitoVanille.Ingredients = new Portion[]
            {
                new Portion(new Liquide("Rhum blanc", "alcool"), 50),
                new Portion(new Liquide("Jus de citron vert", "jus"), 20),
                new Portion(new Liquide("Feuilles de menthe", "plante"), 6),
                new Portion(new Liquide("Sirop de vanille", "sirop"), 10),
                new Portion(new Liquide("Eau gazeuse", "eau"), 100)
            };

            // 24. Mojito Figue
            Recette mojitoFigue = new Recette();
            mojitoFigue.Ingredients = new Portion[]
            {
                new Portion(new Liquide("Rhum blanc", "alcool"), 50),
                new Portion(new Liquide("Jus de citron vert", "jus"), 20),
                new Portion(new Liquide("Feuilles de menthe", "plante"), 6),
                new Portion(new Liquide("Sirop de figue", "sirop"), 10),
                new Portion(new Liquide("Eau gazeuse", "eau"), 100)
            };

            // 25. Mojito Fruits Rouges
            Recette mojitoFruitsRouges = new Recette();
            mojitoFruitsRouges.Ingredients = new Portion[]
            {
                new Portion(new Liquide("Rhum blanc", "alcool"), 50),
                new Portion(new Liquide("Jus de citron vert", "jus"), 20),
                new Portion(new Liquide("Feuilles de menthe", "plante"), 6),
                new Portion(new Liquide("Sirop de fruits rouges", "sirop"), 10),
                new Portion(new Liquide("Eau gazeuse", "eau"), 100)
            };
            // 26. Mojito Raisin
            Recette mojitoRaisin = new Recette();
            mojitoRaisin.Ingredients = new Portion[]
            {
                new Portion(new Liquide("Rhum blanc", "alcool"), 50),
                new Portion(new Liquide("Jus de citron vert", "jus"), 20),
                new Portion(new Liquide("Feuilles de menthe", "plante"), 6),
                new Portion(new Liquide("Sirop de raisin", "sirop"), 10),
                new Portion(new Liquide("Eau gazeuse", "eau"), 100)
            };

            // 27. Mojito Cannelle
            Recette mojitoCannelle = new Recette();
            mojitoCannelle.Ingredients = new Portion[]
            {
                new Portion(new Liquide("Rhum blanc", "alcool"), 50),
                new Portion(new Liquide("Jus de citron vert", "jus"), 20),
                new Portion(new Liquide("Feuilles de menthe", "plante"), 6),
                new Portion(new Liquide("Sirop de cannelle", "sirop"), 10),
                new Portion(new Liquide("Eau gazeuse", "eau"), 100)
            };

            // 28. Mojito Anis
            Recette mojitoAnis = new Recette();
            mojitoAnis.Ingredients = new Portion[]
            {
                new Portion(new Liquide("Rhum blanc", "alcool"), 50),
                new Portion(new Liquide("Jus de citron vert", "jus"), 20),
                new Portion(new Liquide("Feuilles de menthe", "plante"), 6),
                new Portion(new Liquide("Sirop d'anis", "sirop"), 10),
                new Portion(new Liquide("Eau gazeuse", "eau"), 100)
            };

            // 29. Mojito Gingembre
            Recette mojitoGingembre = new Recette();
            mojitoGingembre.Ingredients = new Portion[]
            {
                new Portion(new Liquide("Rhum blanc", "alcool"), 50),
                new Portion(new Liquide("Jus de citron vert", "jus"), 20),
                new Portion(new Liquide("Feuilles de menthe", "plante"), 6),
                new Portion(new Liquide("Sirop de gingembre", "sirop"), 10),
                new Portion(new Liquide("Eau gazeuse", "eau"), 100)
            };

            // 30. Mojito Cassis
            Recette mojitoCassis = new Recette();
            mojitoCassis.Ingredients = new Portion[]
            {
                new Portion(new Liquide("Rhum blanc", "alcool"), 50),
                new Portion(new Liquide("Jus de citron vert", "jus"), 20),
                new Portion(new Liquide("Feuilles de menthe", "plante"), 6),
                new Portion(new Liquide("Sirop de cassis", "sirop"), 10),
                new Portion(new Liquide("Eau gazeuse", "eau"), 100)
            };


            Recette[] toutesLesBoissons = new Recette[]
{
                mojito,
                margarita,
                pinaColada,
                daiquiri,
                mojitoFramboise,
                mojitoFraise,
                mojitoAnanas,
                caipirinha,
                maiTai,
                mojitoCerise,
                mojitoMangue,
                mojitoPassion,
                sexOnTheBeach,
                mojitoPommeVerte,
                mojitoLitchi,
                mojitoFramboiseLitchi,
                mojitoCoco,
                mojitoCeriseNoire,
                mojitoPeche,
                mojitoMaracuja,
                mojitoMelon,
                mojitoCeriseGriotte,
                mojitoAgrumes,
                mojitoVanille,
                mojitoFigue,
                mojitoFruitsRouges,
                mojitoRaisin,
                mojitoCannelle,
                mojitoAnis,
                mojitoGingembre,
                mojitoCassis};

            Shaker myShake = new Shaker(100, true);

            // Instanciation des objets Bouteille pour chaque type d'alcool ou de liqueur
            Bouteille rhumBlanc = new Bouteille();
            Bouteille tequila = new Bouteille();
            Bouteille rhumAmbré = new Bouteille();
            Bouteille cachaça = new Bouteille();
            Bouteille vodka = new Bouteille();
            Bouteille tripleSec = new Bouteille();
            Bouteille peachSchnapps = new Bouteille();
            Bouteille crèmeDeCoco = new Bouteille();
            Bouteille siropAgave = new Bouteille();
            Bouteille siropFramboise = new Bouteille();
            Bouteille siropFraise = new Bouteille();
            Bouteille siropAnanas = new Bouteille();

            // Création d'un tableau (ou autre structure de données) pour stocker toutes les bouteilles
            Bouteille[] toutesLesBouteilles = new Bouteille[]
            {
                rhumBlanc,
                tequila,
                rhumAmbré,
                cachaça,
                vodka,
                tripleSec,
                peachSchnapps,
                crèmeDeCoco,
                siropAgave,
                siropFramboise,
                siropFraise,
                siropAnanas
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
                                Console.WriteLine("Taper le numéro de recette qui vous intéresses : ");
                                do
                                {
                                    int numeroEntre = 0;
                                    if (!int.TryParse(Console.ReadLine(), out numeroEntre))
                                    {
                                        Console.WriteLine("Oups vous avez fait une erreur de frappe, réessayez ! ");
                                    }
                                } while ();
                            }
                            break;
                        case 2:
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