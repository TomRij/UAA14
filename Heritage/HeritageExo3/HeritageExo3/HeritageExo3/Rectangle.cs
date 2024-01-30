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
            get
            {
                return _longueur;
            }
            set
            {
                _longueur = value;
            }
        }
        public int Largeur
        {
            get
            {
                return _largeur;
            }
            set
            {
                _largeur = value;
            }
        }
    }
}
