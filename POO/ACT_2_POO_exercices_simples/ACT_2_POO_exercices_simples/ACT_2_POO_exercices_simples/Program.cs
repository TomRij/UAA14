using System;

namespace ACT_2_POO_exercices_simples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choisissez le programme que vous voulez exécuter :");
            Console.WriteLine("1. Exercice 1 - Cercle");
            Console.WriteLine("2. Exercice 2 - Nombre complexe");
            Console.WriteLine("3. Exercice 3 - Sandwichs aléatoires");
            Console.WriteLine("4. Exercice 4 - Personne");
            Console.WriteLine("0. Quitter");

            if (int.TryParse(Console.ReadLine(), out int choix))
            {
                switch (choix)
                {
                    case 1:
                        ExecuterExerciceCercle();
                        break;
                    case 2:
                        ExecuterExerciceComplexe();
                        break;
                    case 3:
                        ExecuterExerciceSandwich();
                        break;
                    case 4:
                        ExecuterExercicePersonne();
                        break;
                    case 0:
                        Console.WriteLine("Au revoir !");
                        return;
                    default:
                        Console.WriteLine("Choix invalide. Veuillez entrer un numéro valide.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Choix invalide. Veuillez entrer un numéro valide.");
            }

            static void ExecuterExerciceCercle()
            {
                Console.WriteLine("Veuillez entrer le rayon du cercle :");

                if (float.TryParse(Console.ReadLine(), out float rayon))
                {
                    Cercle cercle = new Cercle(rayon);
                    cercle.AfficherInfo();

                    Console.WriteLine("\nLe cercle diviser par deux :");
                    cercle.DiviserParDeux();
                    cercle.AfficherInfo();
                }
                else
                {
                    Console.WriteLine("Entrée invalide. Veuillez entrer un nombre valide pour le rayon.");
                }
            }

            static void ExecuterExerciceComplexe()
            {
                Console.WriteLine("Veuillez entrer la partie réelle du premier nombre complexe :");
                if (int.TryParse(Console.ReadLine(), out int reelle1))
                {
                    Console.WriteLine("Veuillez entrer la partie imaginaire du premier nombre complexe :");
                    if (int.TryParse(Console.ReadLine(), out int imaginaire1))
                    {
                        Complexe complexe1 = new Complexe(reelle1, imaginaire1);

                        Console.WriteLine("Le premier nombre complexe : " + complexe1.AfficheComplexe());
                    }
                    else
                    {
                        Console.WriteLine("Entrée invalide pour la partie imaginaire du premier nombre complexe.");
                    }
                }
                else
                {
                    Console.WriteLine("Entrée invalide pour la partie réelle du premier nombre complexe.");
                }
            }
        }

            static void ExecuterExerciceSandwich()
            {
            SandwichMaker sandwichMaker = new SandwichMaker();
            string sandwich = sandwichMaker.ComposeSandwich();
            Console.WriteLine(sandwich);
        }

        static void ExecuterExercicePersonne()
        {
            Personne personne1 = new Personne("Benoît", 100.0); // Utilisation de double pour le montant
            Personne personne2 = new Personne("Béatrice", 150.0); // Utilisation de double pour le montant

            Console.WriteLine("Porte-monnaie de Benoît : " + personne1.PorteMonnaie);
            Console.WriteLine("Porte-monnaie de Béatrice : " + personne2.PorteMonnaie);

            Console.WriteLine("Combien d'argent Benoît veut-il donner à Béatrice ?");
            if (double.TryParse(Console.ReadLine(), out double montant))
            {
                if (personne1.DonnerArgent(personne2, montant))
                {
                    Console.WriteLine($"Benoît a donné {montant} à Béatrice.");
                }
                else
                {
                    Console.WriteLine("Benoît n'a pas assez d'argent pour effectuer la transaction.");
                }

                Console.WriteLine("Nouveaux soldes :");
                Console.WriteLine("Porte-monnaie de Benoît : " + personne1.PorteMonnaie);
                Console.WriteLine("Porte-monnaie de Béatrice : " + personne2.PorteMonnaie);
            }
            else
            {
                Console.WriteLine("Montant invalide.");
            }
        }

    }
    }
