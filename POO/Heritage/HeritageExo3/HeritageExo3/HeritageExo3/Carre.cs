using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeritageExo3
{
    class Carre : Forme
    {
        protected int _cote;
        public int Cote
        {
            get
            {
                return _cote;
            }
            set
            {
                _cote = value;
            }
        }
        public Carre(int cote, string couleur)
        {
            _cote = cote;
            _couleur = couleur;
        }

        public override int CalculPerimetre()
        {
            return 4 * _cote;
        }

        public override int CalculSurface()
        {
            return _cote * _cote;
        }

        public override string Afficher()
        {
            return $"Carre[côté:{_cote}; couleur:{_couleur}; périmètre:{CalculPerimetre()}; surface:{CalculSurface()}]";
        }
    }
}
