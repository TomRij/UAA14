using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conception
{
   public class Bouteille
    {
        private Liquide _contenu;
        private double _contenance;

        public Bouteille(Liquide contenu, double contenance)
        {
            Contenu = contenu;
            Contenance = contenance;
        }   

        public Liquide Contenu
        {
            get 
            { 
                return _contenu;
            }
            set
            {
                _contenu = value;
            }
        }
        public double Contenance { 
            get 
            { 
                return _contenance;
            }
            set
            {
                _contenance = value;
            }
         }

        internal bool Verser(Portion portion)
        {
            Console.WriteLine("La portion a été versée dans la bouteille.");
            // Logique pour verser la portion dans la bouteille
            return true; // ou false selon votre logique d'application
        }

        public bool Jeter()
        {
            Console.WriteLine("La bouteille a été jetée.");
            // Logique pour jeter la bouteille
            return true; // ou false selon votre logique d'application
        }


    }
}
