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

        public bool PrendreBouteille(Liquide liquide, ref Bouteille bouteille)
        {

        }
        public bool AjouterBouteille(Bouteille bouteille)
        {

        }
        public string AfficherInventaireBar()
        {

        }
    }
}
