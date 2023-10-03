using System;

namespace ACT_2_POO_exercices_simples
{
    internal class Program
    {
        static void Main(string[] args)
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
    }
}