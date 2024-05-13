using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conception
{
    class Portion
    {
            private Liquide _contenu;
            private double _quantite;

            public Portion(Liquide contenu, double quantite)
            {
                _contenu = contenu;
                _quantite = quantite;
            }

            public Liquide Contenu
            {
                get { return _contenu; }
            }

            public double Quantite
            {
                get { return _quantite; }
            }

            public bool TesterPortion(Shaker myShake, Bouteille bouteille)
            {
                bool ok = false;
                if (myShake.ContenanceMax >= (myShake.CalculQuantiteContenu() + this.Quantite * 0.2) && this.Quantite * 0.2 <= bouteille.Contenance)
                {
                    ok = true;
                }
                return ok;
            }
    }
}
