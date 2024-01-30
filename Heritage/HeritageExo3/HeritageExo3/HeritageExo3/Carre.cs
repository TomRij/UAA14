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
        public Carre(int carre, string couleur)
        {
            _couleur = couleur;
        }

        public override int CalculPerimertre()
        {
            return 4 * _cote;
        }

        public override int CalculSurface()
        {
            return _cote * _cote;
        }

        public override string Afficher()
        {
            return "Carre[tailleCotes:" + cote + ";couleur:" + _couleur + ";perimetre:" + CalculPerimetre() + ";surface:" + CalculSurface() + "]";
        }
    }
}
