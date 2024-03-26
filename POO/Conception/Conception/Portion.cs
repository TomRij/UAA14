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

        public int Contenu
		{
			get { return _contenu; }
		}
        public int Quantite
        {
            get { return _quantite; }
        }

        public bool AjouterPortion(Portion portion)
        {

        }
    }
}
