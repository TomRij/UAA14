namespace Tom_Rijckaert_ACT_3_Éléphants
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Elephant zazou = new Elephant("Zazou", 70);
            Elephant titi = new Elephant("Titi", 60);

            int nbreEntre;
            Elephant[] troupeau = new Elephant[7];
            troupeau[0] = new Elephant("Ellie", 80);
            troupeau[1] = new Elephant("Dumbo", 75);
            troupeau[2] = new Elephant("Jumbo", 85);
            troupeau[3] = new Elephant("Babar", 90);
            troupeau[4] = new Elephant("Stampy", 65);
            troupeau[5] = new Elephant("Horton", 78);
            troupeau[6] = new Elephant("Mambo", 82);

            do
            {
                Console.WriteLine("Bienvenue dans cet échange d'éléphants");
                Console.WriteLine("Tapez : ");
                Console.WriteLine("1. Pour afficher les informations de Zazou,");
                Console.WriteLine("2. Pour afficher les informations de Titi");
                Console.WriteLine("3. Pour les échanger");
                Console.WriteLine("4. Pour voir le transfert d'un message de Zazou à Titi");
                Console.WriteLine("5. Pour réviser la notion de tableaux et l'appliquer à des objets");
                Console.WriteLine("6. Pour afficher l'éléphant avec les plus grandes oreilles");
                Console.WriteLine("7. Pour quitter");


                if (!int.TryParse(Console.ReadLine(), out nbreEntre))
                {
                    Console.WriteLine("Oups vous avez fait une erreur de frappe, réessayez ! ");
                }
                else
                {
                    switch (nbreEntre)
                    {
                        case 1:
                            Console.WriteLine(zazou.Affichequijesuis());
                            break;
                        case 2:
                            Console.WriteLine(titi.Affichequijesuis());
                            break;
                        case 3:
                            Elephant temp = zazou;
                            zazou = titi;
                            titi = temp;
                            Console.WriteLine("Après permutation :");
                            Console.WriteLine("Zazou : " + zazou.Affichequijesuis());
                            Console.WriteLine("Titi : " + titi.Affichequijesuis());
                            break;
                        case 4:
                            titi.EcouteMessage("Salut Titi, comment vas-tu ?", zazou);
                            break;
                        case 5:
                            foreach(Elephant ele in troupeau)
                            {
                                ele.TailleOreilles += 5; 
                            }
                            break; 
                        case 6:
                            Elephant plusGrandesOreilles = troupeau[0];
                            foreach (Elephant ele in troupeau)
                            {
                                if (ele.TailleOreilles > plusGrandesOreilles.TailleOreilles)
                                {
                                    plusGrandesOreilles = ele;
                                }
                            }
                            Console.WriteLine("L'éléphant avec les plus grandes oreilles est :");
                            Console.WriteLine(plusGrandesOreilles.Affichequijesuis());
                            break;
                        case 7:
                            Console.WriteLine(":'(");
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
