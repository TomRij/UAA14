using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CE_Juin24_POO_RijckaertTom
{
    internal class Collectrice : Abeille
    {
        public const double QTE_NECTAR_MAX_COLLECTE = 33.25d;

        public Collectrice()
        {
            Role = "Collectrice de Nectar";
            EnergiePartQuart = Ruche.MIEL_CONSOMME_PAR_COLLECTRICES;
        }

        public double CollecteNectar()
        {
            Random alea = new Random();
            double quantiteRecoltee = alea.NextDouble() * QTE_NECTAR_MAX_COLLECTE;
            return quantiteRecoltee;
        }

        public override void FaitLeJob()
        {
            double quantiteRecoltee = CollecteNectar();
            if (quantiteRecoltee > 0)
            {
                Ruche.quantiteNectar += quantiteRecoltee;
            }
        }
    }
}
