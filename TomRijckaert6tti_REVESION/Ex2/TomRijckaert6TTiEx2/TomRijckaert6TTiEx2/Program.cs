using System;

namespace TomRijckaert6TTiEx2
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Green;
            Methode MesOutils = new Methode();

            double[] tableau = new double[10];
            for (int i = 0; i < 10; i++)
            {
                tableau[i] = MesOutils.lecture("Entrez un nombre réel ");
            }

            double somme = 0;
            for (int i = 0;i < 10;i++)
            {
                somme += tableau[i];
            }
            double moyenne = somme / 10;
            Console.WriteLine("Voici la myenne du tableau : " + moyenne);
            
        }
    }
}
