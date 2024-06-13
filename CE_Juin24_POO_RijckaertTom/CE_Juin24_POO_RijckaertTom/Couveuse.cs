using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CE_Juin24_POO_RijckaertTom
{
    class Couveuse : Abeille
    {
        public Couveuse()
        {
            Role = "Gardienne des oeufs";
            EnergiePartQuart=Ruche.MIEL_CONSOMME_PAR_COUVEUSES;
        }

        public void Eclosion()
        {
            if (Ruche.nombreOeufs >= 5)
            {
               Ruche.nombreOeufs -= 5;
               Ruche.abeillesDisponibles += 5;
            }
        }

        public override void FaitLeJob()
        {
            Eclosion();
        }
    }
}
