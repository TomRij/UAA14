using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeritageExo3
{
    abstract class Forme
    {
        protected string _couleur;

        public string Couleur
        {
            get { return _couleur; }
            set { _couleur = value; }
        }

        public abstract int CalculSurface();
        public abstract int CalculPerimetre();

        public abstract string Afficher();

    }
}
