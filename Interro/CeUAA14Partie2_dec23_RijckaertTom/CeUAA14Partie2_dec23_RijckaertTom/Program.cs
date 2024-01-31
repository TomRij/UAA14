namespace CeUAA14Partie2_dec23_RijckaertTom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tapper = "";
            PaintBallGun joueur1 = new PaintBallGun(30, 0);
            while (true)
            {
                // Présentation du jeu
                Console.WriteLine("Bienvenue dans ce jeu de tir --- Vous commencez avec 30 balles");
                Console.WriteLine("==============================================================");
                // Affiche au joueur le nombre de balles restant dans sa poche et dans son chargeur
                Console.WriteLine("Vous avez un totale de " + joueur1.nbreBalles + " balles dans votre poches et " + joueur1.chargeur + " balles dans votre chargeur");
                Console.WriteLine(joueur1.ChargeurRecharger());
                Console.WriteLine(joueur1.Vide());

                Console.WriteLine("");
                Console.WriteLine("Espace pour tirer");
                Console.WriteLine("r pour recharger");
                Console.WriteLine("+ pour reprendre des munitions");
                Console.WriteLine("q pour quitter");

                tapper = Console.ReadLine();
                // fait exécuter la fonction de tir
                if (tapper == " ")
                {
                    joueur1.Tirer();
                    Console.WriteLine("=> Tir effectué!");
                    
                }
                // fait exécuter la fonction de recharger
                if (tapper == "r") 
                {  
                    joueur1.Recharger();
                }
                // fait exécuter la fonction de faire le plein dans ses poches
                if (tapper == "+")
                {
                    joueur1.PrendreMunitions();
                }
                // fait sortir le joueur du jeu
                if (tapper == "q")
                {
                    break;
                }
            }
            
            
        }
    }
}

