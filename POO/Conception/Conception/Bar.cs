using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conception
{
    class Bar
    {
        private Bouteille[] _bouteille;
        
        public Bouteille[] Bouteille
        {
            get { return _bouteille; } set { _bouteille = value; }
        }

        public bool PrendreBouteille(Liquide liquide, out int placeBouteille)
        {
            bool trouve = false;
            placeBouteille = -1;
            int i = 0;

            while (i < Bouteille.Length && !trouve)
            {
                if (Bouteille[i].Contenu == liquide)
                {
                    trouve = true;
                    placeBouteille = i;
                    i++;
                }
            }
            return trouve;
        }

        
    }
}
