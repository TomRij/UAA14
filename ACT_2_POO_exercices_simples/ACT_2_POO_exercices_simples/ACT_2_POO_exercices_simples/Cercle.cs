using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT_2_POO_exercices_simples
{
    class Cercle
    {
        private float _rayon;

        public Cercle(float rayon)
        {
            _rayon = rayon;
        }

        public double CalculAire()
        {
            return Math.PI * _rayon * _rayon;
        }
        public double CalculePerimetre()
        {
            return 2 * Math.PI * _rayon;
        }

        public void DiviserParDeux()
        {
            _rayon /= 2;
        }

        public void AfficherInfo()
        {
            Console.WriteLine("Caractéristiques du cercle :");
            Console.WriteLine($"Rayon : {_rayon}");
            Console.WriteLine($"Aire : {CalculAire()}");
            Console.WriteLine($"Périmètre : {CalculePerimetre()}");

        }
    }
}
