using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicules
{
    class Velo:Vehicule
    {
        protected string _type;
        protected bool _estElectrique;

        public string Type
        {
            get { return _type; }
        }
        public bool EstElectrique
        {
            get { return _estElectrique; }
        }

        public Velo(string type, bool electrique, string modele, string marque, string couleur, decimal prix) : base (modele, marque, couleur, prix)
        {
            _type = type;
            _estElectrique = electrique;
        }
    }
}
