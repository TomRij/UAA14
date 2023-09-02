using System;
using System.Collections.Generic;
using System.Text;

namespace TomRijckaert6TTiEx2
{
    struct Methode
    {
        public double lecture(string question)
        {
            double resultat;
            bool valide = false;

            do
            {
                Console.Write(question);
                string saisie = Console.ReadLine();

                if (double.TryParse(saisie, out resultat))
                {
                    valide = true;
                }
                else
                {
                    Console.WriteLine("Valeur incorrecte. Veuillez réessayer!");
                }
            } while (valide == false);

            return resultat;
        }
    } 
    
}
