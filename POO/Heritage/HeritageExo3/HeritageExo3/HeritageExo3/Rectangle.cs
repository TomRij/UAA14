using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeritageExo3
{
    class Rectangle : Forme
    {
        protected int _longueur;
        protected int _largeur;

        public int Longueur
        {
            get { return _longueur; }
            set { _longueur = value; }
        }

        public int Largeur
        {
            get { return _largeur; }
            set { _largeur = value; }
        }

        public override int CalculPerimetre()
        {
            return 2 * (_longueur + _largeur);
        }

        public override int CalculSurface()
        {
            return _longueur * _largeur;
        }

        public override string Afficher()
        {
            return $"Rectangle[longueur:{_longueur}; largeur:{_largeur}; couleur:{_couleur}; périmètre:{CalculPerimetre()}; surface:{CalculSurface()}]";
        }
    }
}
