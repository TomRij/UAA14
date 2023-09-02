using System;

namespace ACT00_REVISION
{
    class Program
    {
        static void Main(string[] args)
        {
            // déclaration des variables.... COMPLETER AVEC CE QUI MANQUE

            string rep;
            
            double c1 = 0;
            double c2 = 0;
            double c3 = 0;
            bool ok = false;
            string infos;
            MethodesDuProjet MesOutils = new MethodesDuProjet();// instanciation de la structure
            // ...... COMPLETER

            Console.WriteLine("Testez les polygones !");
            //On recommence tant que désiré
            do
            {
                //lecture des 3 côtés
                c1 = lireDouble(1);// ...
                c2 = lireDouble(2);// ...
                c3 = lireDouble(3);// ...
                if (c1 < c2)
                {
                    double a = c1;
                    double b = c2;
                    c1 = b;
                    c2 = a; 
                }
                if (c1 < c3)
                {
                    double a = c1;
                    double b = c3;
                    c1 = b;
                    c3 = a;
                }

                // ...
                // série de test (voir consignes)
                if (MesOutils.Triangle(c1, c2, c3))// on a un triangle...)
                {
                    MesOutils.Affiche("triangle", true, out infos);// préparation et affichage du résultat du test 'triangle' avec la procédure 'Affiche'
                    Console.WriteLine(infos);
                    // ...
                    // ...

                    // vérification équilatéral
                    if (MesOutils.Equi(c3, c2, c3))// on a un triangle équilatéral...)
                    {
                        MesOutils.Affiche("equilateral", true, out infos);// préparation et affichage du résultat du test 'equilateral' avec la procédure 'Affiche'
                        Console.WriteLine(infos);
                        // ...
                        // ...
                    }
                    else
                    {
                        // vérification triangle rectangle
                        if (MesOutils.TriangeRectangle(c1, c2, c3))// on a un triangle équilatéral...)
                        {
                            MesOutils.Affiche("rectangle", true, out infos);// préparation et affichage du résultat positif du test 'rectangle' avec la procédure 'Affiche'
                            Console.WriteLine(infos);
                            // ...
                            // ...
                        }
                        else
                        {
                            MesOutils.Affiche("rectangle", false, out infos);// préparation et affichage du résultat négatif du test 'rectangle' avec la procédure 'Affiche'
                            Console.WriteLine(infos);
                            // ...
                            // ...
                        }
                        MesOutils.Isocele(c1, c2, c3, out ok);
                        if (ok == true)
                        {
                            MesOutils.Affiche("isocele", true, out infos);
                            Console.WriteLine(infos);

                        }
                        // vérification du cas isocèle et affichage dans le cas positif
                        //...
                        //...
                        //... A vous de voir en combien de lignes...
                    }
                }
                else // si ce n'est pas un triangle
                {
                    MesOutils.Affiche("triangle", false, out infos);
                    Console.WriteLine(infos);

                    // préparation et affichage du résultat négataif du test 'triangle' avec la procédure 'Affiche'
                    // ...
                    // ...
                }
                // reprise ?
                Console.WriteLine("Voulez-vous tester un autre polygône ? (Tapez espace)");
                rep = Console.ReadLine();
            } while (rep == " ");
        }

        double donnee = Double.Parse("Entrée une donnée ");//Récupération d'une donnée fournie par l'utilisateur en 'double' : on suppose qu'il ne se trompe pas !
        static double lireDouble(int numeroCote)
        {
            double cote;
            Console.Write("Tapez la valeur du côté " + numeroCote + " : ");
            cote = double.Parse(Console.ReadLine());
            return cote;
        }
    }
}
